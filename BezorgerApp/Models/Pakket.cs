using System;
using System.Collections.Generic;
using System.Text;

namespace CasusRitAfronden.Models
{
    public class Pakket
    {
        public int PakketId { get; set; }
        public string Barcode { get; set; }


        public Pakket(string barcode)
        {
            Barcode = barcode;
        }
    }
}