using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex6_4
{
    internal class MakeRnd
    {
        public void GetRnd(int[] ary)
        {
            Random rnd = new Random();
            int temp;
            for (int i = 0; i <= 5; i++)
            {
                temp = rnd.Next(1, 50);
                while (ary.Contains(temp))
                {
                    temp = rnd.Next(1, 50);
                }
                ary[i] = temp;
            }
        }
    }
}
