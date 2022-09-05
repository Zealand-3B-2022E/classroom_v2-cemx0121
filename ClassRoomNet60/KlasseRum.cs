﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoomNet60
{
    public class KlasseRum
    {
        public string KlasseNavn { get; set; }
        public List<Studerende> Klasseliste { get; set; }

        public DateTime SemesterStart { get; set; }

        public KlasseRum()
        {
            Klasseliste = new List<Studerende>();
        }
    }
}