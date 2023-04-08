using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Random_Stuff;


namespace randomMap
{
    class Map
    {
        private int[,] map_game = new int[5, 5];
        public Map(){}
        public int[,] getMatrix()
        {
            return map_game;
        }

        private void random_shit(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                Console.Write("Row " + i + ": ");

                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + " ");

                }
                Console.WriteLine();

            }
        }
        private void init_matrix()
        {
            for(int i = 0; i< map_game.GetLength(0); i++)
            {
                for(int j = 0;i< map_game.GetLength(1); j++) {
                    map_game[i,j] = 0;
                }
            }
        }
        public void show_Stuff(Map map)
        {
            for (int i = 0; i < map.map_game.GetLength(0); i++)
            {
                for (int j = 0; j < map.map_game.GetLength(1); j++)
                {
                    switch(map.map_game[i, j])
                    {
                        case 0:
                            Console.Write("X\t");
                            break;
                        case 1:
                            Console.Write("G\t");
                            break;
                        case 2:
                            Console.Write("P\t");
                            break;

                    }
                }
                Console.Write("\n");
            }
        }
        public static void Main(String[] args)
        {
            Map map = new Map();

            Boss boss1 = new Boss("Fabio");
            Boss boss2 = new Boss("Arianna");

            Gang gang1 = new Gang(101, boss1);
            Gang gang2 = new Gang(102, boss2);

            Move move = new Move();

            int x = map.map_game.GetLength(0);
            int y = map.map_game.GetLength(1);

            map.map_game[0, 0] = 2;
            map.map_game[4, 4] = 1;

            map.random_shit(map.map_game);
            map.show_Stuff(map);
            //Console.WriteLine(map.map_game.GetValue(5,5));
        }
    }
}