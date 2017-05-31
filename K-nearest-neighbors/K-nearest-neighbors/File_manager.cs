using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K_nearest_neighbors
{
    public class File_manager
    {
        public List<Point> all = new List<Point>();
        public List<Point> virginica = new List<Point>();
        public List<Point> setosa = new List<Point>();
        public List<Point> versicolor = new List<Point>();
        public List<Point> testdatasets = new List<Point>();

        public File_manager()
        {
            using (StreamReader reader = new StreamReader("test.txt"))
            {
                string line = null;
                while (null != (line = reader.ReadLine()))
                {

                    String[] strArray = line.Split(';');
                    String label = null;
                    double[] parameters = new double[4];
                    for (int i = 0; i < 4; i++)
                    {
                        parameters[i] = Double.Parse(strArray[i]);
                        label = strArray.Last();
                    }

                    Point p = new Point(parameters, label);
                    all.Add(p);

                }



                foreach (Point p in all)
                {
                    if (p.Label.Equals("Iris-setosa"))
                    {
                        setosa.Add(p);
                    }

                    if (p.Label.Equals("Iris-versicolor"))
                    {
                        versicolor.Add(p);
                    }


                    if (p.Label.Equals("Iris-virginica"))
                    {
                        virginica.Add(p);
                    }

                    if (p.Label.Equals(""))
                    {
                        testdatasets.Add(p);
                    }


                }
            }

        }


    }
}
