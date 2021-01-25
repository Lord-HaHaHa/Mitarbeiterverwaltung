using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mitarbeiterverwaltung
{
    class CAngestellter : CMitarbeiter
    {
        private double bruttogehalt;

        public CAngestellter() { }
        public CAngestellter(string nachname, string vorname, double brutto)
        {
            this.SetNachname(nachname);
            this.SetVorname(vorname);
            this.SetBrutto(brutto);
        }

        public bool SetBrutto(double butto)
        {
            if (butto > 0)
            {
                bruttogehalt = butto;
                return true;
            }
            else
                return false;
        }
        public double GetBrutto()
        {
            return (this.bruttogehalt);
        }
    }
}
