/*                  ___           ___           ___           ___
 *      ___        /__/\         /  /\         /__/\         /  /\    
 *     /  /\       \  \:\       /  /::\        \  \:\       /  /:/_   
 *    /  /:/        \__\:\     /  /:/\:\        \  \:\     /  /:/ /\  
 *   /  /:/     ___ /  /::\   /  /:/~/::\   _____\__\:\   /  /:/_/::\ 
 *  /  /::\    /__/\  /:/\:\ /__/:/ /:/\:\ /__/::::::::\ /__/:/__\/\:\
 * /__/:/\:\   \  \:\/:/__\/ \  \:\/:/__\/ \  \:\~~\~~\/ \  \:\ /~~/:/
 * \__\/  \:\   \  \::/       \  \::/       \  \:\  ~~~   \  \:\  /:/ 
 *      \  \:\   \  \:\        \  \:\        \  \:\        \  \:\/:/  
 *       \__\/    \  \:\        \  \:\        \  \:\        \  \::/   
 *                 \__\/         \__\/         \__\/         \__\/    
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SutoLorem
{
    internal class LoremPixelProvider : ImageProviderBase
    {

        //    http://lorempixel.com/400/200to get a random picture of 400 x 200 pixels
        //    http://lorempixel.com/g/400/200to get a random gray picture of 400 x 200 pixels
        //    http://lorempixel.com/400/200/sportsto get a random picture of the sports category
        //    http://lorempixel.com/400/200/sports/1to get picture no. 1/10 from the sports category
        //    http://lorempixel.com/400/200/sports/Dummy-Text...with a custom text on the random Picture
        //    http://lorempixel.com/400/200/sports/1/Dummy-Text...with a custom text on the selected Picture
        internal LoremPixelProvider(double width, double height)
        {
            this.width = width;
            this.height = height;
        }

        public override string Get(string identifier = null)
        {
            return string.Format("http://lorempixel.com/{0}/{1}", this.width, this.height);
        }
    }
}
