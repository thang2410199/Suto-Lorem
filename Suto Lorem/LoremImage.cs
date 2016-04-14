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
    public class LoremImage
    {
        public Color Background { get; set; } = Colors.Gray;
        public Color Foreground { get; set; } = Colors.White;


        private double defaultWidth = 200;
        private double defaultHeight = 200;
        IImageProvider imageProvider;

        public LoremImage()
        {
            CreateProvider(defaultWidth, defaultHeight, ImageProvider.AdorableAvatars);
        }

        /// <summary>
        /// Used for image generating, not affect place holder size
        /// </summary>
        /// <param name="width"></param>
        /// <param name="height"></param>
        public void SetSize(double width, double height)
        {
            defaultWidth = width;
            defaultHeight = height;
            imageProvider.SetSize(width, height);
        }

        /// <summary>
        /// use for applying custom image provider
        /// </summary>
        /// <param name="imageProvider"></param>
        public void SetProvider(IImageProvider imageProvider)
        {
            this.imageProvider = imageProvider;
        }

        public void SetProvider(ImageProvider provider)
        {
            CreateProvider(defaultWidth, defaultHeight, provider);
        }

        private void CreateProvider(double width, double height, ImageProvider provider)
        {
            switch (provider)
            {
                case ImageProvider.AdorableAvatars:
                    imageProvider = new AdorableAvatarsProvider(width);
                    break;
                case ImageProvider.LoremPixel:
                    imageProvider = new LoremPixelProvider(width, height);
                    break;
            }
        }

        /// <summary>
        /// get a random avatar or the same with same identifier. Default size is 200x200
        /// </summary>
        /// <param name="identifier"></param>
        /// <returns></returns>
        public string GetAvatar(string identifier = null)
        {
            return imageProvider.Get(identifier);
        }

        public string GetPlaceholder(int width, int height, Color? background = null, Color? foreground = null, string text = null)
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
        AdorableAvatars,
        LoremPixel,
        Custom
    }
}
