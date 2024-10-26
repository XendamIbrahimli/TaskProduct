using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Helper.Exceptions
{
    public class PriceMustBeGratherThanZeroException:Exception
    {

        public PriceMustBeGratherThanZeroException():base("Price must be greater than zero.") 
        { 

        }
        

    }
}
