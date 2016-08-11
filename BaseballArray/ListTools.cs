using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseballArray
{
    class ListTools
    {
        List<double> stats;
        List<string> mlb;
        public ListTools()
        {
            mlb = new List<string> { "Singles:", "Doubles:", "Triples:", "Home Runs:" };
            stats = new List<double>();
        }
        public void addStats()
        {
            for (int i = 0; i < mlb.Count; i++)
            {
                Console.WriteLine("Please enter stats for {0}", mlb[i]);
                stats.Add(Convert.ToDouble(Console.ReadLine()));
            }
            printList();   
        }
        public void printList()
        {
            for(int i = 0; i < mlb.Count; i++)
            {
                Console.WriteLine(mlb[i] + " " + stats[i]);
            }
        }
    }
}
