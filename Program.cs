using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patika_23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            kisiler K = new kisiler("Meryem");
            K.isimyazdir();

            kisiler M = new kisiler();
            M.isimyazdir();

            Console.ReadLine();

        }
    }

    internal class kisiler{
        private string isim;
        public string _isim { get => this.isim.Substring(0,3); set => this.isim = value; }

        public kisiler()
        {
            this._isim = "Ömer";
        }

        public kisiler(string ad)
        {
            this._isim = ad;
        }

        public void isimyazdir()
        {
            Console.WriteLine(_isim);
        }
    }
}
