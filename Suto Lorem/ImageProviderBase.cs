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

namespace SutoLorem
{
    internal abstract class ImageProviderBase : IImageProvider
    {
        protected double width, height = 200;
        public abstract string Get(string identifier = null);

        public void SetSize(double width, double height)
        {
            this.width = width;
            this.height = height;
        }
    }
}
