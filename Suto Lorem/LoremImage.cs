//                  ___           ___           ___           ___
//      ___        /__/\         /  /\         /__/\         /  /\    
//     /  /\       \  \:\       /  /::\        \  \:\       /  /:/_   
//    /  /:/        \__\:\     /  /:/\:\        \  \:\     /  /:/ /\  
//   /  /:/     ___ /  /::\   /  /:/~/::\   _____\__\:\   /  /:/_/::\ 
//  /  /::\    /__/\  /:/\:\ /__/:/ /:/\:\ /__/::::::::\ /__/:/__\/\:\
// /__/:/\:\   \  \:\/:/__\/ \  \:\/:/__\/ \  \:\~~\~~\/ \  \:\ /~~/:/
// \__\/  \:\   \  \::/       \  \::/       \  \:\  ~~~   \  \:\  /:/ 
//      \  \:\   \  \:\        \  \:\        \  \:\        \  \:\/:/  
//       \__\/    \  \:\        \  \:\        \  \:\        \  \::/   
//                 \__\/         \__\/         \__\/         \__\/    

using System.Net;
using Windows.UI;

namespace SutoLorem
{
    public abstract class LoremImage
    {
        public ImageProvider Provider = ImageProvider.AdorableAvatars;
        IImageProvider imageProvider = new AdorableAvatarsProvider(200);
        public Color Background { get; set; } = Colors.Gray;
        public Color Foreground { get; set; } = Colors.White;

        public LoremImage()
        {

        }

        public void SetSizeAvatar(double width, double height)
        {
            imageProvider.SetSize(width, height);
        }

        //private void CreateProvider(double width, double height, ImageProvider provider)
        //{
        //    switch(provider)
        //    {
        //        case ImageProvider.AdorableAvatars:
        //            imageProvider = new AdorableAvatarsProvider(width);
        //            break;
        //    }
        //}

        public string GetAvatar(string identifier = null)
        {
            return imageProvider.Get(identifier);
        }

        public string GetPlaceholder(double width, double height, Color? background = null, Color? foreground = null, string text = null)
        {
            //http://placehold.it/350x150?text=hello
            return "http://placehold.it/" + width + "x" + height + "/" + ColorToHex(background != null ? (Color)background : Background) + "/" + ColorToHex(foreground != null ? (Color)foreground : Foreground) + (string.IsNullOrEmpty(text) ? "" : WebUtility.UrlEncode(text));
        }

        private string ColorToHex(Color c)
        {
            return c.R.ToString("X2") + c.G.ToString("X2") + c.B.ToString("X2");
        }
    }

    public enum ImageProvider
    {
        AdorableAvatars
    }
}
