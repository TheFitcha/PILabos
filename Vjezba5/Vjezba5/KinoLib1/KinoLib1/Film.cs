﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KinoLib1
{
    internal class Film
    {
        public string Naziv { get; set; }   
        public int Trajanje { get; set; }
        public Film(string naziv, int trajanje)
        {
            Naziv = naziv;
            Trajanje = trajanje;
        }
    }
}
