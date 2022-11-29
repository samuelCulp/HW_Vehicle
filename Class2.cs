using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace WindowsFormsApp2
{
    internal class Class2
    {





        public class BodyType
        {
            public string[] BuickSUV = {"Enclave", "Encore", "Envision"};
            public string[] CadillacSUV = { "Escalade" };
            public string[] ChevroletSUV = { "Blazer" };
            public string[] DodgeSUV = { "Durango" };
            public string[] FordSUV = { "Explorer" };
            public string[] GMCSUV = { "Acadia", "Yukon" };
            public string[] HyundaySUV = { "Kona" };
            public string[] JeepSUV = { "Compass", "Cherokee", "Liberty", "Wrangler" };
            public string[] NissanSUV = { "Pathfinder" };
            public string[] SaturnSUV = { "VUE" };
            public string[] SubaruSUV = { "Forester","Crosstrek",  "Ascent"};
            public string[] ToyotaSuv = { "4Runner" };

            public string[] BuickSedan = { "LaCrosse" };
            public string[] CadillacSedan = { "ATS", "CTS", "DTS" };
            public string[] ChevroletSedan = { "Cruze" };
            public string[] DodgeSedan = { "Charger", "Avenger" };
            public string[] FordSedan = { "Fusion" };
            public string[] HyundaiSedan = { "Sonata", "Elantra", "Azera", "Accent" };
            public string[] NissanSedan = { "Altima", "Sentra" };
            public string[] PontiacSedan = { "G8", "G6", "G5" };
            public string[] SaturnSedan = { "Aura" };
            public string[] ToyotaSedan = { "Cramry", "Corolla" };
            public string[] SubaruSedan = { "WRX" };

            public string[] ToyotaHatch = { "Prius" };
            public string[] PontiacHatch = { "Vibe" };

            public string[] ChevroletCoupe = { "Camaro", "Corvette" };
            public string[] DodgeCoupe = { "Challenger" };
            public string[] FordCoupe = { "Mustang" };
            public string[] NissanCoupe = { "GT-R" };
            public string[] SubaruCoupe = { "BRZ" };

            public string[] ChevroletTruck = { "Silverado 1500 Double Cab" };
            public string[] FordTruck = {"F150", "Maverick"};
            public string[] GMCTruck = { "Sierra 1500 Crew Cab", "Savana 1500 Passenger", "Canyon Extended Cab" };
            public string[] JeppTruck = { "Gladiator" };
            public string[] RAMTruck = { "1500 Classic", "1500 Classic Quad Cab", "2500 Regular Cab", "3500 Crew Cab", "C/V" };
            public string[] ToyotaTruck = { "Tacoma Double Cab" };

            public string[] NissanVan = { "Quest" };

            public string[] BuickConvertible = { "Cascada" };
            public string[] PoniacConvertible = { "Solstice" };
        }


 

        public static string[] GetModel(int x) 
            {
                switch (x)
                {
                    case 0:
                        string[] v = { "Cascada", "Enclave", "Encore", "Envision", "LaCrosse" };
                        return v;
                    case 1:
                        string[] c = { "ATS", "CTS", "DTS", "ELR", "Escalade" };
                        return c;
                    case 2:
                        string[] b = { "Silverado 1500 Double Cab", "Camaro", "Blazer", "Cruze", "Corvette" };
                        return b;
                    case 3:
                        string[] a = { "Avenger", "Charger", "Challenger", "Dart", "Durango" };
                        return a;
                    case 4:
                        string[] i = { "F150", "Fusion", "Maverick", "Mustang", "Explorer" };
                        return i;
                    case 5:
                        string[] j = { "Acadia", "Sierra 1500 Crew Cab", "Savana 1500 Passenger", "Canyon Extended Cab", "Yukon" };
                        return j;
                    case 6:
                        string[] k = { "Azera", "Accent", "Elantra", "Kona", "Sonata" };
                        return k;
                    case 7:
                        string[] l = { "Cherokee", "Compass", "Gladiator", "Liberty", "Wrangler" };
                        return l;
                    case 8:
                        string[] m = { "Quest", "Altima", "GT-R", "Pathfinder", "Sentra" };
                        return m;
                    case 9:
                        string[] n = { "G5", "G6", "G8", "Solstice", "Vibe" };
                        return n;
                    case 10:
                        string[] o = { "1500 Classic", "1500 Classic Quad Cab", "2500 Regular Cab", "3500 Crew Cab", "C/V" };
                        return o;
                    case 11:
                        string[] p = { "Aura", "SKY", "VUE" };// thats all i could find on carvana
                        return p;
                    case 12:
                        string[] q = { "Ascent", "BRZ", "Crosstrek", "Forester", "WRX" };
                        return q;
                    case 13:
                        string[] r = { "4Runner", "Cramry", "Corolla", "Prius", "Tacoma Double Cab" };
                        return r;
                }
                return null;
            }
        public static string[] GetTypeAllSUV(int t)
        {
            string[] j = { "Encore", "Enclave", "Envision","Escalade", "Blazer", "Durango", "Explorer", "Acadia",
                        "Yukon", "Kona", "Compass", "Cherokee","Liberty", "Wrangler", "Pathfinder", "VUE", "Forester",
                           "Crosstrek",  "Ascent", "4Runner"};
            return j;
        }
        public static string[] GetTypeAllSedan(int t)
        {
            string[] j = { "LaCrosse" , "CTS", "ATS" , "DTS", "Cruze", "Dart" , "Charger" , "Avenger" , "Fusion" 
            , "Sonata", "Elantra", "Azera", "Accent", "Altima", "Sentra", "G8", "G6", "G5", "Aura", "Cramry", "Corolla", "WRX"};
            return j;
        }
        public static string[] GetTypeAllHatchback(int t)
        {
            string[] j = { "Prius", "Vibe" };
            return j;
        }
        public static string[] GetTypeAllCoupe(int t)
        {
            string[] j = { "CTS", "Camaro", "Corvette", "Challenger", "Mustang", "GT-R", "BRZ" };
            
            return j;
        }
        public static string[] GetTypeAllTruck(int t)
        {
            string[] j = { "Silverado 1500 Double Cab", "F150", "Maverick" , "Sierra 1500 Crew Cab", "Savana 1500 Passenger", "Canyon Extended Cab" ,
                            "Gladiator",  "1500 Classic", "1500 Classic Quad Cab", "2500 Regular Cab", "3500 Crew Cab",
                            "Tacoma Double Cab", "C/V"};
            return j;
        }
        public static string[] GetTypeAllMinivan(int t)
        {
            string[] j = { "Quest"  };
            return j;
        }
        public static string[] GetTypeAllConvertible(int t)
        {
            string[] j = { "Cascada", "Solstice" };
            return j;
        }
        public static string[] GetTypeAllWagon(int t)
        {
            string[] j = { "NO_RESULTS"};
            return j;
        }

        
    }
}
