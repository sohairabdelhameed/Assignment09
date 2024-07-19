using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment09.Part02
{
    internal interface IRectangle:IShape
    
    {
        double Length { get; }
        double Width { get; }
    }
}
