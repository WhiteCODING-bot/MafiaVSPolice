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
        private object[,] matrix = Map.getMatrix();
        private int[] last_pos = new int[2];
        public void setLastPos(int[] newPos)
        {
            last_pos = newPos;
        }
        public int[] getLastPos() 
        {
            return this.last_pos;
        }
        public int[] whereIs()
        {
            for (int i = 0; i < this.matrix.GetLength(0); i++)
            {
                for (int j = 0; j < this.matrix.GetLength(1); j++)
                {
                    if (this.matrix[i,j] == this)
                    {
                        this.last_pos[0] = i;
                        this.last_pos[1] = j;
                    }
                }
            }
            return this.last_pos;
        }
    }
}
