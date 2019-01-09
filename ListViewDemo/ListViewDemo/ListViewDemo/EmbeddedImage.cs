using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ListViewDemo
{
    [ContentProperty(nameof(ID))] // Standardproperty ala {Binding Vorname} // <- geht auf Path
    class EmbeddedImage : IMarkupExtension
    {
        public string ID { get; set; }
        public object ProvideValue(IServiceProvider serviceProvider)
        {
            if (string.IsNullOrWhiteSpace(ID))
                return null;

            return ImageSource.FromResource(ID);
        }
    }
}
