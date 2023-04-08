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
        private int[,] map_game = { { 0, 0, 0, 0 , 0 , 0}, 
                                    { 0, 0, 0, 0 , 0 , 0},
                                    { 0, 0, 0, 0 , 0 , 0},
                                    { 0, 0, 0, 0 , 0 , 0},
                                    { 0, 0, 0, 0, 0 , 0 },
                                    { 0, 0, 0, 0, 0 , 0 },
                                    { 0, 0, 0, 0, 0 , 0 }};
        Map(){}
        public void show_Stuff(Map map)
        {
            for (int i = 0; i < map.map_game.GetLength(0) - 1; i++)
            {
                for (int j = 0; j < map.map_game.GetLength(1); j++)
                {
                    if (map.map_game[i, j] == 0)
                    {
                        Console.Write("X\t");
                    }
                    else
                    {
                        Console.Write("O\t");
                    }
                }
                Console.Write("\n");
            }
        }
        public static void Main(String[] args)
        {
            /*
             TO DO:
                -> Gang 1
                -> Gang 2
                -> Polizia
                -> Matrice 5 x 5
             */
            Map map = new Map();

            Boss boss1 = new Boss("Fabio");
            Boss boss2 = new Boss("Arianna");

            Gang gang1 = new Gang(101, boss1);
            Gang gang2 = new Gang(102, boss2);

            int x = map.map_game.GetLength(0);
            int y = map.map_game.GetLength(1);
            int tmp = map.map_game.GetLength(0);
            map.map_game[0, 0] = 1;
            map.map_game[5, 5] = 1;

            map.show_Stuff(map);

        }
    }
}