using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemadeGestãodeSalas.Models
{
    public class Sala
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public string Tipo { get; set; }
        public int Capacidade { get; set; }

        public Sala() { }

        public Sala(int codigo, string nome, string tipo, int capacidade)
        {
            Codigo = codigo;
            Nome = nome;
            Tipo = tipo;
            Capacidade = capacidade;
        }
    }
}
