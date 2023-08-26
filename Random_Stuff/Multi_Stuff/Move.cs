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
                case null:
                    //La cella è libera
                    return 0;
                case Gang:
                    //Nella cella c'è una gang
                    return 1;
                case Police:
                    //Nella cella c'è la polizia
                    return 2;
            }
            return 93;
        }


        public int isOk (int x,int y)
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
                case Gang:
                    return 1;
                case Police:
                    return 2;
            }
            return 3;
        }

        public void moveThroughMap(int[] last_pos,object? team)
        {
            Map game_map = new Map();
            if (isOk(last_pos) == 0)
            {
                object[,] map = Map.getMatrix();
                map[last_pos[0]+1, last_pos[1]+1] = team;
                game_map.updateMatrix(map);
            }

        }





    }
}
