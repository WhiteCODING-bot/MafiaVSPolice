using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using randomMap;

namespace Random_Stuff
{
     class Move
    {
        private Map map = new Map();
        public Move() { }
        public int isOk(int x,int y)
        {
            int[,] matrix = map.getMatrix();
            Console.WriteLine(x + y);
            if( matrix == null)
            {
                return -1;
            }
            if (matrix[x,y] == 0 )
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
}
