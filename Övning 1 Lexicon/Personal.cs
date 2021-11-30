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
            this.AddPersonal();
        }

        public void AddPersonal()
        {
            Register.Add(this);
        }

        public static void SkrivUtPersonal()
        {
            for(int i = 0; i < Register.Count; i++)
            {
                Console.WriteLine($"Namn: {Register[i].fNamn} {Register[i].eNamn} med årsinkomst på {Register[i].pengar} svenska riksdaler");
            }
        }
    }
}
