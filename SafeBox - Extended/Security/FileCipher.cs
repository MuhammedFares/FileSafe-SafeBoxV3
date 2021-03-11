using SafeBox3.Security;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SafeBox3.Security
{
    class FileCipher
    {
        private const string SKey = "_?73^?dVTMokahar3";
        private const string SaltKey = "!2S@LT&MoKat5har3EY";
        private const int Iterations = 1510;

        public enum TaskResult
        {
            Done,
            Failed
        }
        private static async Task<byte[]> GetBytes(string str)
        {
            var bytes = new byte[str.Length * sizeof(char)];
            await Task.Run(() => { Buffer.BlockCopy(str.ToCharArray(), 0, bytes, 0, bytes.Length); });
            return bytes;
        }
        public static async Task<TaskResult> EncryptFile(string file, string OutPath = "")
        {
            string output =file;

            if (OutPath != "")
            {
                output = OutPath;
            }
            try
            {
                output = Path.Combine(Path.GetDirectoryName(output),StringCipher.GenerateName(Path.GetFileName(output)));
                var aes = new AesManaged();
                aes.BlockSize = aes.LegalBlockSizes[0].MaxSize;
                aes.KeySize = aes.LegalKeySizes[0].MaxSize;
                var salt = await GetBytes(SaltKey);
                var key = new Rfc2898DeriveBytes(SKey, salt, Iterations);
                aes.Key = key.GetBytes(aes.KeySize / 8);
                aes.IV = key.GetBytes(aes.BlockSize / 8);
                aes.Mode = CipherMode.CBC;
                ICryptoTransform transform = aes.CreateEncryptor(aes.Key, aes.IV);
                using (var dest = new FileStream((output), FileMode.CreateNew, FileAccess.Write, FileShare.None))
                {
                    using (var cryptoStream = new CryptoStream(dest, transform, CryptoStreamMode.Write))
                    {
                        using (var source = new FileStream(file, FileMode.Open, FileAccess.Read, FileShare.Read))
                        {
                            await source.CopyToAsync(cryptoStream);

                        }
                    }
                }

                File.Delete(file);
                return TaskResult.Done;
            }
            catch (Exception e)
            { Debug.WriteLine("EncryptFileMethod Error " + e.Message); return TaskResult.Failed; }
        }
        public static async Task<TaskResult> DecryptFile(string file, string OutPath = "")
        {
            string output;

            if (OutPath != "")
            {
                output = OutPath;
            }
            else { output = file; }
            try
            {
                var aes = new AesManaged();
                aes.BlockSize = aes.LegalBlockSizes[0].MaxSize;
                aes.KeySize = aes.LegalKeySizes[0].MaxSize;
                var salt = await GetBytes(SaltKey);
                var key = new Rfc2898DeriveBytes(SKey, salt, Iterations);
                aes.Key = key.GetBytes(aes.KeySize / 8);
                aes.IV = key.GetBytes(aes.BlockSize / 8);
                aes.Mode = CipherMode.CBC;
                ICryptoTransform transform = aes.CreateDecryptor(aes.Key, aes.IV);
                output = Path.Combine(Path.GetDirectoryName(output),StringCipher.ReGenerateName(Path.GetFileName(output)));


                using (var dest = new FileStream((output), FileMode.CreateNew, FileAccess.Write, FileShare.None))
                {
                    using (var cryptoStream = new CryptoStream(dest, transform, CryptoStreamMode.Write))
                    {
                        using (var source = new FileStream(file, FileMode.Open, FileAccess.Read, FileShare.Read))
                        {
                            await source.CopyToAsync(cryptoStream);
                        }
                    }
                }
                File.Delete(file);
                return TaskResult.Done;
            }
            catch (Exception e)
            { Debug.WriteLine("DecryptFileMethod Error " + e.Message); return TaskResult.Failed; }
        }


        public static async Task<TaskResult> enc(string file, string OutPath = "")
        {
            string output = file + "encd";

            try { 
                var aes = new AesManaged();
                aes.BlockSize = aes.LegalBlockSizes[0].MaxSize;
                aes.KeySize = aes.LegalKeySizes[0].MaxSize;
                var salt = await GetBytes(SaltKey);
                var key = new Rfc2898DeriveBytes(SKey, salt, Iterations);
                aes.Key = key.GetBytes(aes.KeySize / 8);
                aes.IV = key.GetBytes(aes.BlockSize / 8);
                aes.Mode = CipherMode.CBC;
                ICryptoTransform transform = aes.CreateEncryptor(aes.Key, aes.IV);
                using (var dest = new FileStream((output), FileMode.CreateNew, FileAccess.Write, FileShare.None))
                {
                    using (var cryptoStream = new CryptoStream(dest, transform, CryptoStreamMode.Write))
                    {
                        using (var source = new FileStream(file, FileMode.Open, FileAccess.Read, FileShare.Read))
                        {
                            await source.CopyToAsync(cryptoStream);

                        }
                    }
                }

                File.Delete(file);
                return TaskResult.Done;
            }
            catch (Exception e)
            { Debug.WriteLine("EncryptFileMethod Error " + e.Message); return TaskResult.Failed; }
        }
        public static async Task<TaskResult> dec(string file, string OutPath = "")
        {
            string output = file.Replace("encd", "");

          
            try
            {
                var aes = new AesManaged();
                aes.BlockSize = aes.LegalBlockSizes[0].MaxSize;
                aes.KeySize = aes.LegalKeySizes[0].MaxSize;
                var salt = await GetBytes(SaltKey);
                var key = new Rfc2898DeriveBytes(SKey, salt, Iterations);
                aes.Key = key.GetBytes(aes.KeySize / 8);
                aes.IV = key.GetBytes(aes.BlockSize / 8);
                aes.Mode = CipherMode.CBC;
                ICryptoTransform transform = aes.CreateDecryptor(aes.Key, aes.IV);


                using (var dest = new FileStream((output), FileMode.CreateNew, FileAccess.Write, FileShare.None))
                {
                    using (var cryptoStream = new CryptoStream(dest, transform, CryptoStreamMode.Write))
                    {
                        using (var source = new FileStream(file, FileMode.Open, FileAccess.Read, FileShare.Read))
                        {
                            await source.CopyToAsync(cryptoStream);
                        }
                    }
                }
                File.Delete(file);
                return TaskResult.Done;
            }
            catch (Exception e)
            { Debug.WriteLine("DecryptFileMethod Error " + e.Message); return TaskResult.Failed; }
        }

        public static async Task<TaskResult> EncryptDataSet(string respo)
        {
            try
            {
                var files = Directory.GetFiles(respo);

                foreach (var item in files)
                {
                    await enc(item);
                }

                return TaskResult.Done;
            }
            catch(Exception a) { Debug.WriteLine("## ENC . " + a.Message); return TaskResult.Failed; }
        }
        public static async Task<TaskResult> DecryptDataSet(string respo)
        {
            try
            {
                var files = Directory.GetFiles(respo);

                foreach (var item in files)
                {
                    await dec(item);
                }

                return TaskResult.Done;
            }
            catch (Exception a) { Debug.WriteLine("## DEC . " + a.Message); return TaskResult.Failed; }
        }


        public static async Task<MemoryStream> StreamFromEncdFile(string file)
        {
            try
            {
                var aes = new AesManaged();
                aes.BlockSize = aes.LegalBlockSizes[0].MaxSize;
                aes.KeySize = aes.LegalKeySizes[0].MaxSize;
                var salt = await GetBytes(SaltKey);
                var key = new Rfc2898DeriveBytes(SKey, salt, Iterations);
                aes.Key = key.GetBytes(aes.KeySize / 8);
                aes.IV = key.GetBytes(aes.BlockSize / 8);
                aes.Mode = CipherMode.CBC;
                ICryptoTransform transform = aes.CreateDecryptor(aes.Key, aes.IV);

                MemoryStream Output = new MemoryStream();
                var dest = Output;

                var cryptoStream = new CryptoStream(dest, transform, CryptoStreamMode.Write);

                var source = new FileStream(file, FileMode.Open, FileAccess.Read, FileShare.Read);

                await source.CopyToAsync(cryptoStream);                    

                return Output;
            }
            catch (Exception e)
            { Debug.WriteLine("DecryptFileMethod Error " + e.Message); return new MemoryStream(); }
        }
    }
}
