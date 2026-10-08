using System;
using System.Collections.Generic;
using System.Text;

namespace Szállodai_Szobafoglalási_Rendszer
{
    public class Szoba
    {
        private int ejszakaiAr;
        private int ferohely;
        private static int osszesRegisztraltSzoba = 0;

        public string Szobaszam { get; set; }
        public int Emelet { get; set; }
         
        public int EjszakaiAr
        {
            get => ejszakaiAr;
            set => ejszakaiAr = value < 0 ? 0 : value;

            //get 
            //{
            //    return ejszakaiAr;
            //}

            //set 
            //{
            //    if (value < 0) ejszakaiAr = 0;
            //    else ejszakaiAr = value;
               

            //}

        }
        public int Ferohely 
        {
            get => ferohely;
            set => ferohely = value < 1 ? 1 : value;
        }

        public static int OsszesRegisztraltSzoba 
        {
            get => osszesRegisztraltSzoba;
        }

        public Szoba(string szobaszam, int emelet, int ejszakaiAr):this(szobaszam, emelet, ejszakaiAr, 2)
        {


        }

        public Szoba(string szobaszam, int emelet, int ejszakaiAr, int ferohely) 
        { 
            Szobaszam = szobaszam;
            Emelet = emelet;
            EjszakaiAr = ejszakaiAr;
            osszesRegisztraltSzoba++;
        }
    }
}
