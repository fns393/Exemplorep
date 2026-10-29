using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex5
{
    internal class Cargo
    {
        public string nome;
        public string cargo;
        public double salario;
        public string departamento;
        public int anosEmpresa;


        public string dados() => $"Nome: {nome} \nCargo: {cargo} \nSalário: {salario}€ \nDepartamento: {departamento} \nAnos na Empresa: {anosEmpresa}";

        public void introduzir(string NOME, string CARGO, double SALARIO, string DEPARTAMENTO, int ANOSEMPRESA)
        {
            nome = NOME;
            cargo = CARGO;
            salario = SALARIO;
            departamento = DEPARTAMENTO;
            anosEmpresa = ANOSEMPRESA;
            dados();
        }
    }
}