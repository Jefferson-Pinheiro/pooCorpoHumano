using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooCorpoHumano
{
    public class Program
    {
        static void Main(string[] args)
        {
            Pessoa p = new Pessoa();//UTILIZANDO CONSTRUTOR DEFAULT
            p.Nome = "Tiago";
            p.Bracos = 2;
            p.Pernas = 2;
            p.Olhos = 2;
            p.CorCabelo = "Preto";
            Console.WriteLine(p.Nome + " possui " + p.Bracos +
            " braços," + "\n" + p.Pernas + " pernas, \n " + p.Olhos +
            " olhos e cabelo " + p.CorCabelo + "\n");

            Pessoa p1 = new Pessoa("Loiro");
            //UTILIZANDO CONSTRUTOR PERSONALIZADO
            p1.Nome = "Jefferson";

            Console.WriteLine(p1.Nome + " possui " + p1.Bracos +
            " braços" + ",\n" + p1.Pernas + " pernas, \n " + p1.Olhos +
            " olhos e cabelo " + p1.CorCabelo);


            Console.ReadKey();
        }
    }
}
