using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K_nearest_neighbors
{
    public class Distance
    {
        private double distance;
        private Point point;


        public Distance(double _distance, Point _point)
        {
            this.distance = _distance;
            this.point = _point;

        }

        public Distance() { }

        public double _Distance
        {
            get { return distance; }
            set { distance = value; }
        }

        public Point Point
        {
            get { return point; }
            set { point = value; }
        }




        public double EuclideanDistance(Point p1, Point p2)
        {
            double euclidean_distance = 0;
            for (int i = 0; i < 3; i++)
            {
                euclidean_distance += (Math.Pow(p1.Attributes[i] - p2.Attributes[i], 2));

            }

            return Math.Sqrt(euclidean_distance);
        }


        public double CzebyszewDistance(Point p1, Point p2)
        {
            double czebyszew_distance = 0;
            List<double> distances = new List<double>();
            for (int i = 0; i < 3; i++)
            {
                czebyszew_distance = Math.Abs(p1.Attributes[i] - p2.Attributes[i]);
                distances.Add(czebyszew_distance);
            }

            return distances.Max();


        }

        public double ManhatanDistance(Point p1, Point p2)
        {
            double manhatan_distance = 0;
            for (int i = 0; i < 3; i++)
            {
                manhatan_distance += Math.Abs(p1.Attributes[i] - p2.Attributes[i]);
            }

            return manhatan_distance;
        }

        public override string ToString()
        {
            String str;
            str = point.Attributes[0] + ";" + point.Attributes[1] + ";" + point.Attributes[2] + ";" + point.Attributes[3] + " " + point.Label + " " + distance;


            return str;
        }

        public void Winner(Point p, int k)
        {
            List<Distance> distance_ = new List<Distance>();
            File_manager fm = new File_manager();

            Distance distance = new Distance();
            for (int i = 0; i < fm.all.Count; i++)
            {
                //distance = new Distance(distance.EuclideanDistance(p, fm.all[i]), fm.all[i]);
                //distance = new Distance(distance.CzebyszewDistance(p, fm.all[i]), fm.all[i]);
                distance = new Distance(distance.ManhatanDistance(p, fm.all[i]), fm.all[i]);
                distance_.Add(distance);
            }

            /* Wypisanie wszystkich punktów
            foreach (object o in distance_)
            {
                Console.WriteLine(o);
            }
            */

            var query = (from i in distance_ select new { i.Point.Label, i._Distance, i.Point.Att }).Where(i => i._Distance != 0).OrderBy(i => i._Distance).Take(k);
            Console.WriteLine(k + " najbliższych sąsiadów dla: " + p.Attributes[0] + ";" + p.Attributes[1] + ";" + p.Attributes[2] + ";" + p.Attributes[3] + " " + p.Label);
            foreach (var x in query)
            {
                Console.WriteLine(x);
            }

            Console.Write("Zwycięzca: ");

            var mostCommonName = query.GroupBy(x => x.Label).Select(x => new { Name = x.Key, Count = x.Count() }).OrderByDescending(x => x.Count).Select(x => x.Name).First();
            foreach (var m in mostCommonName)
            {

                Console.Write(m);

            }

            Console.WriteLine();
        }


    }
}
