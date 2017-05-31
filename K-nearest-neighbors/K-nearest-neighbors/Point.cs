using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K_nearest_neighbors
{
    public class Point
    {
        private double[] attributes;
        private string label;
        public Point(double[] _attributes, string _label)
        {
            this.attributes = _attributes;
            this.label = _label;
        }

        public Point() { }

        public double[] Attributes
        {
            get { return attributes; }
            set { attributes = value; }
        }

        public String Att
        {
            get
            {
                String str = null;
                for (int i = 0; i < 4; i++)
                {
                    str += attributes[i] + " ; ";
                }

                return str;
            }


        }



        public string Label
        {
            get { return label; }
            set { label = value; }
        }




    }
}
