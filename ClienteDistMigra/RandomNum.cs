using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClienteDistMigra
{
    class RandomNum
    {

        public int randomNumber()
        {
            int min = 1;
            int max = 3;

            Random ran = new Random();
            return ran.Next(min, max);

        }
    }
}
