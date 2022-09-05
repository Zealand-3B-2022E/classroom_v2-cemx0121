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
            return $"Navn: {Navn} | Fødselsdag(Dag/Måned): {Fødselsdag}/{Fødselsmåned}";
        }
    }
}
