using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SutoLorem
{
    public interface IImageProvider
    {
        string Get(string identifier = null);
        void SetSize(double width, double height);
    }
}
