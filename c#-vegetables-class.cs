using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObstGemuese
{
    class ObstGemuese
    {
        private string name;
        private int gewicht;
        private double preis;
        private string herkunft;
        private int obst;
        private int gemuese;

        public ObstGemuese(string n, double p, int o, int g, int ge, string h){
            name = n;
            preis = p;
            gemuese = g;
            obst = o;
            gewicht = ge;
            herkunft = h;
            }

        public string getName()
        {
            return name;
        }

        public double getPreis()
        {
            return preis;
        }

        public int getObst()
        {
            return obst;
        }
        public int getGemuese()
        {
            return gemuese;
        }
    }
}
