using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Maior_Idade
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Pessoa Obj = new Pessoa();
            Console.WriteLine("Informe o nome da 1° pessoa");
            Obj.Nome1 = string.Format(Console.ReadLine());
            Console.WriteLine("informe a idade dessa pessoa");
            Obj.Idade1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o nome da 2° pessoa");
            Obj.Nome2 = string.Format(Console.ReadLine());
            Console.WriteLine("informe a idade dessa pessoa");
            Obj.Idade2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o nome da 3° pessoa");
            Obj.Nome3 = string.Format(Console.ReadLine());
            Console.WriteLine("informe a idade dessa pessoa");
            Obj.Idade3 = int.Parse(Console.ReadLine());
            Obj.ExibirDados();
        }
    }
}
