using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Counter
{
    public class Counter
    {

        int value = 0;
        public void Increment()
        {
            value++;
        }

       
        public void Reset()
        {
            value = 0;
        }

      
        public int GetValue()
        {
            
            return value;
        }
    }


}
