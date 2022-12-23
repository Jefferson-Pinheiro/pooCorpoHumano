using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooCorpoHumano
{
    public class Pessoa
    {
        public Pessoa(string cabelo)//Valor obrigatório
        {
            Olhos = 2;//Valor default
            Bracos = 2;
            Pernas = 2;
            CorCabelo = cabelo;
        }
        public Pessoa()
        {
        }
        public string Nome { get; set; }
        public int Olhos { get; set; }
        public string CorCabelo { get; set; }
        public int Bracos { get; set; }
        public int Pernas { get; set; }
    }
}
