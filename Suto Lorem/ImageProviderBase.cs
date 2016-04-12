using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SutoLorem
{
    public abstract class ImageProviderBase : IImageProvider
    {
        protected double width, height = 200;
        public virtual string Get(string identifier = null)
        {
            return "";
        }

        public void SetSize(double width, double height)
        {
            this.width = width;
            this.height = height;
        }
    }
}
