using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using SQLitePCL;
using Foundation;
using UIKit;
using GuideForDDOn.Date;
using SQLite;
using Xamarin.Forms;
using System.IO;

[assembly: Dependency(typeof(GuideForDDOn.iOS.SqLite_Ios))]
namespace GuideForDDOn.iOS
{

    public class SqLite_Ios : ISqLite
    {
        public SQLiteConnection GetConnection()
        {
            var file = "DDON.db3";
            var documents = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            var path = Path.Combine(documents, "..", "Library", file);

            if (!File.Exists(path))
                Copia(path);

            return new SQLiteConnection(path);
        }

        public void Copia(string Local)
        {
            string nome = "DDON";
            var Copia = NSBundle.MainBundle.PathForResource(nome, "db3");
            File.Copy(Copia, Local);
        }
    }
}