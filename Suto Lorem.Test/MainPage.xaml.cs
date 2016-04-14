using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Suto_Lorem.Test
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public string ImageSource { get; set; }
        public string Placeholder { get; set; }
        public MainPage()
        {
            this.InitializeComponent();
            var imageProvider = new SutoLorem.LoremImage();
            var textProvider = new SutoLorem.LoremText();
            ImageSource = imageProvider.GetAvatar();
            Placeholder = imageProvider.GetPlaceholder(300, 200);
            paragraph.Text = textProvider.GetParagraph(3);
            this.DataContext = this;
        }
    }
}
