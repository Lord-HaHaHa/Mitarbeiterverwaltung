using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mitarbeiterverwaltung
{
    class CMitarbeiter
    {
        //Attibutet
        private string nachname;
        private string vorname;

        //Methoden
        public string GetNachname()
        {
            return nachname;
        }
        public string GetVorname()
        {
            return vorname;
        }
        public void SetNachname(string nachname)
        {
            this.nachname = nachname;
        }
        public void SetVorname(string vorname)
        {
            this.vorname = vorname;
        }
    }
}
