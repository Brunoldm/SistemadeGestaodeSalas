using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemadeGestãodeSalas.Models
{
    public class Professor
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public DateTime DataNascimento { get; set; }

        public Professor() { }
        public Professor(int codigo, string nome, string cpf, DateTime dataNascimento)
        {
            Codigo = codigo;
            Nome = nome;
            CPF = cpf;
            DataNascimento = dataNascimento;
        }
    }
}