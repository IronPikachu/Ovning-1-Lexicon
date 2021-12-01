using System;
using System.Collections.Generic;

namespace Övning_1_Lexicon
{
    class Personal
    {
        private string fNamn;
        private string eNamn;
        private int pengar;

        private static List<Personal> Register = new List<Personal>();

        public Personal(string f, string e, int p)
        {
            fNamn = f;
            eNamn = e;
            pengar = p;
        }

        public static void AddPersonal(Personal p)
        {
            Register.Add(p);
        }

        public static void SkrivUtPersonal()
        {
            foreach(Personal p in Register)
            {
                Console.WriteLine(p);
            }
        }

        public override string ToString()
        {
            return $"Namn: {fNamn} {eNamn}; årslön: {pengar}";
        }
    }
}
