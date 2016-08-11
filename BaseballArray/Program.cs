using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseballArray
{
    class Program
    {
        static void Main(string[] args)
        {
            ListTools lists = new ListTools();
            List<string> baseballStats = new List<string>();
            lists.addStats();
        }
    }
}
