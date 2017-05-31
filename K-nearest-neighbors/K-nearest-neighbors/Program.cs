using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K_nearest_neighbors
{
    class Program
    {
        static void Main(string[] args)
        {
            Distance dist = new Distance();
            File_manager fm = new File_manager();
            dist.Winner(fm.setosa[0], 3);
            dist.Winner(fm.versicolor[0], 3);

        }
    }
}
