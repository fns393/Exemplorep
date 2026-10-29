using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Livro livro3 = new Livro();
            livro3.Mostrar();
            livro3.Disponivel = false;
            livro3.Emprestar();
            livro3.Mostrar();
        }
    }
}
