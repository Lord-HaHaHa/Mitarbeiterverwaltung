using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mitarbeiterverwaltung
{
    class CArbeiter:CMitarbeiter
    {
        private int stunden;
        private double stundenlohn;

        public CArbeiter() { }
        public CArbeiter(string nachname, string vorname, int stunden, double stundenlohn)
        {
            this.SetNachname(nachname);
            this.SetVorname(vorname);
            this.SetStunden(stunden);
        }
        public bool SetStunden(int stunden)
        {
            if (stunden >= 0)
            {
                this.stunden = stunden;
                return true;
            }
            else
                return false;
        }
        public bool SetStundenlohn(double stundenlohn)
        {
            if (stundenlohn > 0)
            {
                this.stundenlohn = stundenlohn;
                return true;
            }
            else
                return false;
        }
        public double GetBrutto()
        {
            return (stunden * stundenlohn);
        }
    }
}
