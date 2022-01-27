using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoSimulator
{
    internal class Autos
    {
        int ps;
        int AktuelleGeschwindigkeit;
        int AkutellerGang;
        int IstMotorGestartet;
        string carName;

        public Autos(int ps, string CarName)
        {
            this.ps = ps;
            this.carName = CarName;
        }
        public string CarName
        {
            get { return carName; }
            set { carName = value; }
        }
        public int Ps
        {
            get { return ps; }   // get method
            set { ps = value; }  // set method
        }
        public int istMotorGestartet
        {
            get { return IstMotorGestartet; }
            set { IstMotorGestartet = value;}
        }
        public int aktuelleGeschwindikeit
        {
            get { return AktuelleGeschwindigkeit;  }
            set { AktuelleGeschwindigkeit = value; }
        }
        public int akutellerGang
        {
            get { return AkutellerGang; }
            set { AkutellerGang = value; }
        }
        public void speed()
        {
            if(istMotorGestartet == 1)
            {
                if(AktuelleGeschwindigkeit < ((ps / 3)+ 100))
                {
                    AktuelleGeschwindigkeit += (ps / 200);
                }
            }
        }
        public void bremsen()
        {
            if(istMotorGestartet == 1)
            {
                if (AktuelleGeschwindigkeit > 0)
                {
                    AktuelleGeschwindigkeit -= (ps / 200);
                }
            }
        }
        public void gaenge()
        {
            if (AktuelleGeschwindigkeit >= 1)
            {
                AkutellerGang = 1;
            }

            if (AktuelleGeschwindigkeit > (((ps / 3) + 100) / 7 * 1))
            {
                AkutellerGang = 2;
            }

            if (AktuelleGeschwindigkeit > (((ps / 3) + 100) / 7 * 2))
            {
                AkutellerGang = 3;
            }

            if (AktuelleGeschwindigkeit > (((ps / 3) + 100) / 7 * 3))
            {
                AkutellerGang = 4;
            }

            if (AktuelleGeschwindigkeit > (((ps / 3) + 100) / 7 * 4))
            {
                AkutellerGang = 5;
            }

            if (AktuelleGeschwindigkeit > (((ps / 3) + 100) / 7 * 5))
            {
                AkutellerGang = 6;
            }
        }
       
    }
}
