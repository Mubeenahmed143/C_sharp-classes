using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__class
{

    
    internal class IndexerClass
    {
        private string[] in_arr = new string[5];

        public string this[int i]
        {
            get
            {
                return in_arr[i];
            }

            set
            {
                in_arr[i] = value;
            }
        }

        private int[] sal_arr = new int[4];

        public int this[int i,int j]
        {
            get
            {
                return sal_arr[j];
            }
            set
            {
                sal_arr[j] = value;
            }
        }
    }
}
