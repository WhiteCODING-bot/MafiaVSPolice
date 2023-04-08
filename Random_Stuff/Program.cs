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
                                    { 0, 0, 0, 0 , 0 , 0},
                                    { 0, 0, 0, 0 , 0 , 0},
        };
        public Map(){}
        public int[,] getMatrix()
        {
            return map_game;
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
            map.map_game[5, 5] = 1;

            switch (move.isOk(x,y))
            {
                case -1:
                    Console.WriteLine("La matrice non può essere nulla");
                    break;

                case 1:
                    Console.WriteLine("La cella di in posizione " + x + " ; " + y + " e' libera");
                    break;

                case 0:
                    Console.WriteLine("La cella di in posizione " + x + " ; " + y + " e' non libera");
                    break;
            }


            map.show_Stuff(map);

        }
    }
}