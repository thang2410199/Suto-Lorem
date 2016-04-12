using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SutoLorem
{
    public class AdorableAvatarsProvider : ImageProviderBase
    {
        string identifier = null;

        public AdorableAvatarsProvider(double width)
        {
            this.width = width;
        }

        public override string Get(string identifier = null)
        {
            if (string.IsNullOrEmpty(identifier))
                identifier = Guid.NewGuid().ToString();

            return "http://api.adorable.io/avatar/" + width + "/" + identifier;
        }
    }
}
