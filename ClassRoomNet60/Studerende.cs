using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoomNet60
{
    public class Studerende
    {
        public string Navn { get; private set; }
        public int Fødselsmåned { get; private set; }

        public int Fødselsdag { get; private set; }

        public Studerende(string navn, int fødselsmåned, int fødselsdag)
        {
            Navn = navn;
            Fødselsmåned = fødselsmåned;
            Fødselsdag = fødselsdag;
        }

        public override string ToString()
        {
            return $"Navn: {Navn} | Fødselsdag(Dag/Måned): {Fødselsdag}/{Fødselsmåned} | Årstid: {UdskrivÅrstidForFødselsdag()}";
        }

        public string UdskrivÅrstidForFødselsdag()
        {
            string årstid;
            if (Fødselsmåned == 12 || Fødselsmåned == 1 || Fødselsmåned == 2)
            {
                årstid = "Vinter";
            }
            else if (Fødselsmåned == 3 || Fødselsmåned == 4 || Fødselsmåned == 5)
            {
                årstid = "Forår";
            }
            else if (Fødselsmåned == 6 || Fødselsmåned == 7 || Fødselsmåned == 8)
            {
                årstid = "Sommer";
            }
            else if (Fødselsmåned == 9 || Fødselsmåned == 10 || Fødselsmåned == 11)
            {
                årstid = "Efterår";
            }
            else
            {
                årstid = "Ugyldig fødselsmåned";
            }
            return årstid;
        }

        public void AntalFødselsdageIÅrstid()
        {
            
        }
    }
}
