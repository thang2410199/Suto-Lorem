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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI;

namespace SutoLorem
{
    public abstract class LoremImage
    {
        ImageProvider _provider = ImageProvider.AdorableAvatars;
        IImageProvider imageProvider = new AdorableAvatarsProvider(200);
        Color background = Colors.Gray;
        Color foreground = Colors.White;

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

        public string GetPlaceholder(double width, double height, string text = null)
        {
            return "http://placehold.it/" + width + "x" + height + "/" + ColorToHex(background) + "/" + ColorToHex(foreground);
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
