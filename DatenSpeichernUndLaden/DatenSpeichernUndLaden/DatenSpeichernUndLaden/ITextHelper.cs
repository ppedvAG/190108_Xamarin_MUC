using System;
using System.Collections.Generic;
using System.Text;

namespace DatenSpeichernUndLaden
{
    public interface ITextHelper
    {
        void SaveText(string filename, string content);
        string LoadText(string filename);
    }
}
