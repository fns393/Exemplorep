using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex3
{
    internal class Professor
    {
        public string nome = "Alberto";
        public string disciplina = "Matematica";
        public int anosExperiencia = 12;
        public string escola = "D.Afonso Henriques";
        public string email = "a17231@aedah.pt";

        public string Dados => $"Nome: {nome}, \nDisciplina: {disciplina}, \nEscola: {escola}, \nEmail: {email}, Experiencia: {anosExperiencia}";

    }
}
