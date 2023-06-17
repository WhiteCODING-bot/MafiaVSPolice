using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using randomMap;

namespace Random_Stuff
{
    internal class Gang
    {
        Map map = new Map();
        Boss boss = new Boss();

        int gangester = 0;
        private object [,] matrix = Map.getMatrix();
        private int[] last_pos = new int[2];

        public int getGangester() { return gangester; }
        public Boss getBoss() { return boss; }
        public void setGangester(int gangester) { this.gangester = gangester; }
        public void setBoss(Boss boss) { this.boss = boss; }
        public Gang(int gangester, Boss boss)
        {
            this.gangester = gangester;
            this.boss = boss;
        }

        public Gang()
        {
        }
        public void show()
        {
            boss.show();
            Console.WriteLine(this.gangester);
            Console.WriteLine();
        }
        public int[] whereIs()
        {
            for (int i = 0; i < this.matrix.GetLength(0); i++)
            {
                for (int j = 0; j < this.matrix.GetLength(1); j++)
                {
                    if (this.matrix[i, j] == this)
                    {
                        this.last_pos[0] = i;
                        this.last_pos[1] = j;
                    }
                }
            }
            return this.last_pos;
        }
    }
}
