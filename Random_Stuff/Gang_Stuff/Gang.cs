using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Random_Stuff
{
    internal class Gang
    {
        int gangester = 0;
        Boss boss = new Boss();
        
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
    }
}
