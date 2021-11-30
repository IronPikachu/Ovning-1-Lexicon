using System;

namespace Övning_1_Lexicon
{
    class Personal
    {
        private string fNamn;
        private string eNamn;
        private int pengar;

        private static Personal[] Register;

        public Personal(string f, string e, int p)
        {
            fNamn = f;
            eNamn = e;
            pengar = p;
            if(Register == null)
            {
                Register = new Personal[1];
                Register[0] = this;
            }
            else
            {
                Personal[] _reg = Register;
                Register = new Personal[_reg.Length + 1];
                for(int i = 0; i < _reg.Length; i++)
                {
                    Register[i] = _reg[i];
                }
                Register[^1] = this;
            }
        }

        public static void SkrivUtPersonal()
        {
            for(int i = 0; i < Register.Length; i++)
            {
                Console.WriteLine($"Namn: {Register[i].fNamn} {Register[i].eNamn} med årsinkomst på {Register[i].pengar} svenska riksdaler");
            }
        }
    }
}
