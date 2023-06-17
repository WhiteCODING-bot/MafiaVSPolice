using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using randomMap;

namespace Random_Stuff
{
     class Move
    {
        private Map map = new Map();
        public Move() { }

        public int isOk(int[] pos)
        {
            int x = pos[0];
            int y = pos[1];

            object[,] matrix = randomMap.Map.getMatrix();
            if (matrix == null)
            {
                Console.WriteLine("La matrice non può essere vuota");
                return -1;
            }
            switch (matrix.GetValue(x, y))
            {
                case 0:
                    //La cella è libera
                    return 0;
                case 1:
                    //Nella cella c'è una gang
                    return 1;
                case 2:
                    //Nella cella c'è la polizia
                    return 2;
            }
            return 93;
        }

        public int isOk(int x,int y)
        {
            object[,] matrix = randomMap.Map.getMatrix();
            if( matrix == null)
            {
                Console.WriteLine("La matrice non può essere vuota");
                return -1;
            }
            switch(matrix.GetValue(x,y)){
                case 0:
                    return 0;
                case 1:
                    return 1;
                case 2:
                    return 2;
            }
            return 3;
        }

        public void moveThroughMap(int[] last_pos,int team)
        {
            Police police = new Police();
            int x = last_pos[0];
            int y = last_pos[1];
            if(team == 2)
            {
                if (isOk(x, y + 1) == 0)
                {
                    object[,] matrix = randomMap.Map.getMatrix();
                    matrix[x, y] = 0;
                    matrix[x + 1, y] = team;
                    police.setLastPos(police.whereIs());
                }
                else
                {
                    Console.Write("Cella occupata");
                }

            }
            else {
                object[,] matrix = randomMap.Map.getMatrix();
                matrix[x, y] = 0;
                matrix[x + 1, y] = team;

            }
        }





    }
}
