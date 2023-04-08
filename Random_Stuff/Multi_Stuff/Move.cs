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
            int[,] matrix = randomMap.Map.getMatrix();
            if( matrix == null)
            {
                Console.WriteLine("La matrice non può essere vuota");
                return -1;
            }
            switch(matrix.GetValue(x,y)){
                case 0:
                    Console.WriteLine("la cella è libera");
                    return 0;
                case 1:
                    Console.WriteLine("Nella cella c'è una gang");
                    return 1;
                case 2:
                    Console.WriteLine("Nella cella c'è la polizia");
                    return 2;
            }
            return 93;
        }
    }
}
