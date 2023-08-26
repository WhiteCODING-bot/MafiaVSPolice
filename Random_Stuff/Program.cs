using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Random_Stuff;

/*
 * TO DO:
 * --> Add random move + recursion
 * --> Add fight
 
 
*/



namespace randomMap
{
    class Map
    {
        private static object[,] map_game = new object[10,10];
        public Map(){
        }

        public static object[,] getMatrix()
        {
            return map_game;
        }

        public void updateMatrix(object[,] u_map)
        {
            for (int i = 0; i < u_map.GetLength(0); i++)
            {
                for(int j = 0; j < u_map.GetLength(1); j++)
                {
                    map_game[i,j] = u_map[i,j];
                }
            }
        }

        public static void initMatrix()
        {
            object[,] map = map_game;
            for (int i = 0; i < map.GetLength(0); i++)
            {
                for (int j = 0; j < map.GetLength(1); j++)
                {
                    map[i, j] = null;
                }
            }
        }

        public void show_Stuff(Map map)
        {
            for (int i = 0; i < randomMap.Map.map_game.GetLength(0); i++)
            {
                for (int j = 0; j < randomMap.Map.map_game.GetLength(1); j++)
                {
                    Console.Write("| ");
                    switch(randomMap.Map.map_game[i, j])
                    {
                        case null:
                            Console.Write("X ");
                            break;
                        
                        case Police:
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write("P ");
                            Console.ForegroundColor = ConsoleColor.White;
                            break;
                        
                        case Gang:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write("G ");
                            Console.ForegroundColor = ConsoleColor.White;
                            break;

                    }
                }
                Console.Write("|\n");
            }
        }
        public static void Main(String[] args)
        {
            Map map = new Map();
            Police police = new Police();
            Gang gang = new Gang();
            Move move = new Move();
            Random random = new Random();

            initMatrix();
            object[,] game_map = Map.getMatrix();

            game_map[0,0] = gang;
            game_map[random.Next(game_map.GetLength(1)), random.Next(game_map.GetLength(1))] = police;


            map.show_Stuff(map);
            int[] tmp = gang.whereIs();
            Console.WriteLine(tmp[0] + " " + tmp[1]);
            move.moveThroughMap(tmp,gang);

            Console.WriteLine("\n\n");
            map.show_Stuff(map);

        }
    }
}