using System;
using System.Collections.Generic;
using System.Text;

namespace methotlar
{
    class emlak
    {
        private string semt;
        private string renk;
        private int odasayi;
        private int katno;
        private double alan;

        public string SEMTİ
        {get { return semt; }
            set { semt = value.ToUpper(); }

        }
        public string Rengi
        {
            
            get { return renk; }
            set { renk = value.ToLower(); }
        }
        public int ODASAYİSİ
        {
            get { return odasayi; }
            set { odasayi = Math.Abs(value); }
        }
        public int KATNO
        {
            get { return katno; }
            set { katno = Math.Abs(value); }
        }
        public Double ALAN
        {
            get { return alan; }
            set { alan = Math.Abs(value); }
        }
    }
}
