using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquazioniLibrary
{
    public static class Equazioni
    {
        public static bool IsDetermined(double a)
        {
            bool risp = true;
            if (a == 0)
            {
                risp = false; 
            }
            

            return true;

        }
        public static bool IsImpossible(double b, double a)
        {
            bool risp = false;
            if (b != 0 && a == 0)
            {
                risp = true;
            }
            return risp;
        }
            public static bool IsIndetermined(double b, double a)
            {
                bool risp = false;
                if (b != 0 && a == 0)
                {
                    risp = true;
                }


                return risp;

        }

    }
}
