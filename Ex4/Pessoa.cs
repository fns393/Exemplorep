using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex4
{
    internal class Pessoa
    {
        public string nome = "Carla";
        public int idade = 15;
        public string genero = "Feminina";
        public string cidade = "Guimarães";
        public string profissao = "Eletrecista";

        public string Dados => $"Nome: {nome}, \nIdade: {idade}, \nGénero: {genero}, \nCidade: {cidade}, \nProfissão: {profissao}";

    }
}
