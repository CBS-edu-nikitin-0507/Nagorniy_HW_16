using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class MyMatrix
    {
        public int[,] arr;

        

        public MyMatrix(int length_0, int length_1)
        {
            arr = new int[length_0, length_1];


        }


        public int this[int index_1, int index_2]
        {

            get => arr[index_1, index_2];
            set => arr[index_1, index_2] = value;
          

        }

       




    }
}


