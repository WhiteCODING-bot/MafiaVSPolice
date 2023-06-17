using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Random_Stuff;
using randomMap;

namespace Random_Stuff.Multi_Stuff
{
    /*
     * Parametri:
     *  ->Matrice
     *  ->Posizioni:
     *      ->Mafia
     *      ->Polizia
     *      
     */

    internal class Ambrogio
    {
        Gang gang = new Gang();
        Police police = new Police();
        Map map = new Map();

        //int[,][,] mappa = Map.map_game;
        Ambrogio() {
            
            
            
            int[] last_Pos_Police= police.whereIs();
            int[] last_Pos_Gang = gang.whereIs();



        }
    }
}
