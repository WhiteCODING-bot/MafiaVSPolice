using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using randomMap;
namespace Random_Stuff
{
    internal class Police
    {
        private int[,] matrix = Map.getMatrix();
        private int[] last_pos = {0,0};
        public int whereIs()
        {
            for (int i = 0; i < this.matrix.GetLength(0); i++)
            {
                for (int j = 0; j < this.matrix.GetLength(1); j++)
                {
                    if (this.matrix[i,j] == 2)
                    {
                        last_pos[0] = i;
                        last_pos[1] = j;
                    }
                }
            }
            Console.WriteLine(last_pos[0] + " ; " + last_pos[1]);
            return 0;
        }
    }
}
