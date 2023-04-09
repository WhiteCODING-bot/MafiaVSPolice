using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Random_Stuff
{
    internal class Boss
    {
        String name = "";

        public Boss(string name){this.name = name;}
        public Boss(){}
        public void show()
        {
            Console.WriteLine(name);
        }

    }
}
