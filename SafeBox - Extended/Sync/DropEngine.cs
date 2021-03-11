using Dropbox.Api;
using Dropbox.Api.Files;
using Dropbox.Api.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafeBox3.Sync
{
    public static class DropEngine
    {
        private static readonly string token = "o0gP4bR01wAAAAAAAAAAHnmWnqzlOmHBDIpAhQMWIJ9fSmAolJ6mw2VTzp9vFuCG";
        public static bool Connected = false;
        public static DropboxClient Engine;
        public static List<string> StoredImagesPatterns = new List<string>();
        public static List<string> StoredVideosPatterns = new List<string>();
        public static void Run()
        {
            Engine = new DropboxClient(token);
            CheckMainFolder();
        }

        private async static void CheckMainFolder()
        {
            var RootFolder = await Engine.Files.ListFolderAsync("//");
            var folder = RootFolder.Entries.Where(i => i.IsFolder && i.Name == "safebox");
            if (folder == null || !RootFolder.Entries.Contains(folder.FirstOrDefault()))
            {
#pragma warning disable CS0618 // Type or member is obsolete
                await Engine.Files.CreateFolderAsync("/safebox");
#pragma warning restore CS0618 // Type or member is obsolete
#pragma warning disable CS0618 // Type or member is obsolete
                await Engine.Files.CreateFolderAsync("/safebox/pics");
#pragma warning restore CS0618 // Type or member is obsolete
#pragma warning disable CS0618 // Type or member is obsolete
                await Engine.Files.CreateFolderAsync("/safebox/vids");
#pragma warning restore CS0618 // Type or member is obsolete

            }
            FeedLists();
        }

        private static async void FeedLists()
        {
            var list = await Engine.Files.ListFolderAsync("/safebox/pics");

            foreach (var item in list.Entries.Where(i => i.IsFile))
            {
                StoredImagesPatterns.Add(item.Name);
            }
            var list2 = await Engine.Files.ListFolderAsync("/safebox/vids");

            foreach (var item in list2.Entries.Where(i => i.IsFile))
            {
                StoredVideosPatterns.Add(item.Name);
            }
        }
    }
}

