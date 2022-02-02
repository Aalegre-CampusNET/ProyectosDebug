using System;
using System.Collections.Generic;

namespace DosColecciones
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Elemento> a = new List<Elemento>();
            List<Elemento> b = new List<Elemento>();
            for (int i = 0; i < 10; i++)
            {
                Elemento temp = new Elemento();
                temp.num = i;
                a.Add(temp);
            }
            foreach (var item in a)
            {
                b.Add(item);
            }
        }
    }
    class Elemento
    {
        public int num;
    }
}
