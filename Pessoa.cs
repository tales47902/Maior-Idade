using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Maior_Idade
{
    public class Pessoa
    {
        private string nome1, nome2, nome3;
        private int idade1, idade2, idade3;
        public string Nome1
        {
            get { return nome1; }
            set { nome1 = value; }
        }

        public string Nome2
        {
            get { return nome2; }
            set { nome2 = value; }
        }

        public string Nome3
        {
            get { return nome3; }
            set { nome3 = value; }
        }

        public int Idade1
        {
            get { return idade1; }
            set { idade1 = value; }
        }

        public int Idade2
        {
            get { return idade2; }
            set { idade2 = value; }
        }
        public int Idade3
        {
            get { return idade3; }
            set { idade3 = value; }
        }
        public void ExibirDados()
        {
            if (idade1 > idade2 && idade1 > idade3)
            {
                Console.WriteLine("A pessoa mais velha e o(a) " + nome1 + " com " + idade1 + " anos de idade!");
            }
            else
            {

                if (idade2 > idade1 && idade2 > idade3)
                {
                    Console.WriteLine("A pessoa mais velha e o(a) " + nome2 + " com " + idade2 + " anos de idade!");
                }

                if (idade3 > idade1 && idade3 > idade2)
                {
                    Console.WriteLine("A pessoa mais velha e o(a) " + nome3 + " com " + idade3 + " anos de idade!");
                }

                Console.WriteLine("A idade de todos são iguais");
            }
        
        }
    }
}
