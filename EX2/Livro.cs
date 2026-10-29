using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX2
{
    internal class Livro
    {
        public string Titulo = "A sibila";
        public string Autor = "Augustina Bessa-Luis";
        public bool Disponivel = true;
        public int Ano = 1954;
        public string estado = "Disponivel";

        public void Emprestar()
        {
            
            if (Disponivel == true)
            {
                estado = "Disponivel";
            }
            else
            {
                estado = "Emprestado";
            }
        }

        public void Mostrar() => Console.WriteLine($"\n\n\nTítulo: {Titulo}, \n Autor: {Autor}, \n Ano: {Ano}, \n Estado: {estado}");
    }
}
