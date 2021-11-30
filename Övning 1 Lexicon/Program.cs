using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Övning_1_Lexicon
{
    class Program
    {
        static void Main(string[] args)
        {
            byte[] b;

            BinaryFormatter bf = new BinaryFormatter();
            using (MemoryStream ms = new MemoryStream())
            {
                object o = "🐱";
                bf.Serialize(ms, o);
                b = ms.ToArray();
            }

            foreach(byte _b in b)
            {
                Console.WriteLine($"{Convert.ToString(_b, toBase: 2),8} ");
            }
        }
    }
}
