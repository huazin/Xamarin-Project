using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using SQLite;
using Xamarin.Forms;
using System.IO;
using GuideForDDOn.Date;

[assembly: Dependency(typeof(GuideForDDOn.Droid.SqLite_Android))]
namespace GuideForDDOn.Droid
{
    public class SqLite_Android : ISqLite
    {
        String Folder = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);

        public SqLite_Android()
        {

        }
        public SQLiteConnection GetConnection()
        {
            SQLiteConnection con = new SQLiteConnection(SqLite_Android.GetLocalFilePath("DDON.db3"));
            return con;
        }


        public static string GetLocalFilePath(string filename)
        {
            string path = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            string dbPath = System.IO.Path.Combine(path, filename);

            CopyDatabaseIfNotExists(dbPath);

            return dbPath;
        }

        private static void CopyDatabaseIfNotExists(string dbPath)
        {
                if (!File.Exists(dbPath))
                {
                    using (var br = new BinaryReader(Android.App.Application.Context.Assets.Open("DDON.db3")))
                    {
                        using (var bw = new BinaryWriter(new FileStream(dbPath, FileMode.Create)))
                        {
                            byte[] buffer = new byte[2048];
                            int length = 0;
                            while ((length = br.Read(buffer, 0, buffer.Length)) > 0)
                            {
                                bw.Write(buffer, 0, length);
                            }
                        }
                    }
                  }
        }
    }
}