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
        private static int[,] map_game = new int[10,10];
        Random random = new Random();
        public Map(){}
        public void initPos()
        {
            Move move = new Move();
            int[] pos = { random.Next(0, map_game.GetLength(0)),
                random.Next(0, map_game.GetLength(0)),
                random.Next(0, map_game.GetLength(0)),
                random.Next(0, map_game.GetLength(0))};

            map_game[pos[0], pos[1]] = 1;
            map_game[pos[2], pos[3]] = 2;
        }
        public static int[,] getMatrix()
        {
            return map_game;
        }
        public void show_Stuff(Map map)
        {
            for (int i = 0; i < randomMap.Map.map_game.GetLength(0); i++)
            {
                for (int j = 0; j < randomMap.Map.map_game.GetLength(1); j++)
                {
                    switch(randomMap.Map.map_game[i, j])
                    {
                        case 0:
                            Console.Write("X ");
                            break;
                        case 1:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write("G ");
                            Console.ForegroundColor = ConsoleColor.White;
                            break;
                        case 2:
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write("P ");
                            Console.ForegroundColor = ConsoleColor.White;
                            break;

                    }
                }
                Console.Write("\n");
            }
        }
        public static void Main(String[] args)
        {
            Map map = new Map();

            Police police = new Police();

            Boss boss1 = new Boss("Fabio");
            Boss boss2 = new Boss("Arianna");

            Gang gang1 = new Gang(101, boss1);
            Gang gang2 = new Gang(102, boss2);

            int x = randomMap.Map.map_game.GetLength(0)-1;
            int y = randomMap.Map.map_game.GetLength(1)-1;

            map.initPos();
            map.show_Stuff(map);
            
        }
    }
}