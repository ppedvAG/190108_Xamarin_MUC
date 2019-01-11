using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

[assembly: Xamarin.Forms.Dependency(typeof(DatenSpeichernUndLaden.Droid.AndroidTextHelper))]

namespace DatenSpeichernUndLaden.Droid
{
    public class AndroidTextHelper : ITextHelper
    {
        public string LoadText(string filename)
        {
            var path = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            var fullPath = Path.Combine(path, filename);

            return File.ReadAllText(fullPath);
        }

        public void SaveText(string filename, string content)
        {
            // Ordner in Android, der immer verfügbar ist:
            // /data/data/[name der applikation]/files

            var path = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            var fullPath = Path.Combine(path, filename);

            File.WriteAllText(fullPath, content);
        }
    }
}