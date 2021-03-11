using SafeBox3.Ui;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SafeBox3.Respority
{
    public delegate void ProgressChangeDelegate(double Percentage, ref bool Cancel);
    public delegate void Completedelegate();
    public delegate void Faileddelegate(string ErrMsg);
    class FileHandler
    {
        /// <summary>
        /// File Copy , Move  and Encrypt After Being Copied;
        /// </summary>
        /// <param name="Source">Source File Path</param>
        /// <param name="Dest">Destination File Path</param>
        /// <param name="EncAfterProccess">True if you want to Encrypt File after any process</param>
        public FileHandler(string Source,  string Dest ,bool EncAfterProccess = false)
        {
            this.SourceFilePath = Source;
            this.EncryptionOn = EncAfterProccess;
            this.DestFilePath = Dest;
            OnProgressChanged += delegate { };
            OnComplete += delegate { };
            OnFailure += delegate { };
        }
        public void Copy()
        {
           MainForm.Frm.data.working = true;
            try
            {
                byte[] buffer = new byte[2048 * 1024]; // 1MB buffer
                bool cancelFlag = false;

                using (FileStream source = new FileStream(SourceFilePath, FileMode.Open, FileAccess.Read))
                {
                    long fileLength = source.Length;
                    using (FileStream dest = new FileStream(DestFilePath, FileMode.CreateNew, FileAccess.Write))
                    {
                        long totalBytes = 0;
                        int currentBlockSize = 0;

                        while ((currentBlockSize = source.Read(buffer, 0, buffer.Length)) > 0)
                        {
                            totalBytes += currentBlockSize;
                            double persentage = (double)totalBytes * 100.0 / fileLength;

                            dest.Write(buffer, 0, currentBlockSize);

                            cancelFlag = false;
                            OnProgressChanged(persentage, ref cancelFlag);

                            if (cancelFlag == true)
                            {
                                // Delete dest file here
                                break;
                            }
                        }
                    }
                }


                OnComplete();
                new Thread(() =>
                {
                    ENC(EncryptionOn);
                }).Start();
            }
            catch (Exception q)
            {
                OnFailure(q.Message);
            }
            MainForm.Frm.data.working = false;

        }
        public async Task CopyAsync()
        {
            MainForm.Frm.data.working = true;

            try
            {
                byte[] buffer = new byte[4096 * 1024]; // 1MB buffer
                bool cancelFlag = false;

                using (FileStream source = new FileStream(SourceFilePath, FileMode.Open, FileAccess.Read))
                {
                    long fileLength = source.Length;
                    using (FileStream dest = new FileStream(DestFilePath, FileMode.CreateNew, FileAccess.Write))
                    {
                        long totalBytes = 0;
                        int currentBlockSize = 0;

                        while ((currentBlockSize = source.Read(buffer, 0, buffer.Length)) > 0)
                        {
                            totalBytes += currentBlockSize;
                            double persentage = (double)totalBytes * 100.0 / fileLength;

                            await dest.WriteAsync(buffer, 0, currentBlockSize);

                            cancelFlag = false;
                            OnProgressChanged(persentage, ref cancelFlag);

                            if (cancelFlag == true)
                            {
                                // Delete dest file here
                                break;
                            }
                        }
                    }
                }

                OnComplete();
               await Task.Run(() => { ENC(EncryptionOn); });

            }catch(Exception q) { OnFailure(q.Message); }
            MainForm.Frm.data.working = false;

        }

        public void Move()
        {
            Copy();
            try
            {
                File.Delete(SourceFilePath);
            }
            catch (Exception q) { Debug.WriteLine("Delete Operation Failed ####"); OnFailure(q.Message); }
        }
        public async Task MoveAsync()
        {
            MainForm.Frm.data.working = true;

            await CopyAsync();
            try
            {
                File.Delete(SourceFilePath);
            }
            catch (Exception q) { Debug.WriteLine("Delete Operation Failed ####"); OnFailure(q.Message); }
            MainForm.Frm.data.working = false;

        }


       
        private void ENC(bool encryptionOn)
        {
            MainForm.Frm.data.working = true;

            if (encryptionOn == false) return;

            string SKey = "_?73^?dVTMokahar3";
            string SaltKey = "!2S@LT&MoKat5har3EY";
            int Iterations = 1510;
            var bytes = new byte[SaltKey.Length * sizeof(char)];
            Buffer.BlockCopy(SaltKey.ToCharArray(), 0, bytes, 0, bytes.Length);
            var aes = new AesManaged();
            aes.BlockSize = aes.LegalBlockSizes[0].MaxSize;
            aes.KeySize = aes.LegalKeySizes[0].MaxSize;
            var salt = bytes;
            var key = new Rfc2898DeriveBytes(SKey, salt, Iterations);
            aes.Key = key.GetBytes(aes.KeySize / 8);
            aes.IV = key.GetBytes(aes.BlockSize / 8);
            aes.Mode = CipherMode.CBC;
            ICryptoTransform transform = aes.CreateEncryptor(aes.Key, aes.IV);

            using (var dest = new FileStream((DestFilePath + "Enc"), FileMode.CreateNew, FileAccess.Write, FileShare.None))
            {
                using (var cryptoStream = new CryptoStream(dest, transform, CryptoStreamMode.Write))
                {
                    using (var source = new FileStream(SourceFilePath, FileMode.Open, FileAccess.Read, FileShare.Read))
                    {
                        source.CopyToAsync(cryptoStream).Wait();

                    }
                }
            }
            File.Delete(DestFilePath);
            File.Move(DestFilePath + "Enc", DestFilePath.Replace("Enc", ""));
            MainForm.Frm.data.working = false;

        }


        public string SourceFilePath { get; set; }
        public string DestFilePath { get; set; }

        public bool  EncryptionOn { get; set; }
        public event ProgressChangeDelegate OnProgressChanged;
        public event Completedelegate OnComplete;
        public event Faileddelegate OnFailure;
    }
}
