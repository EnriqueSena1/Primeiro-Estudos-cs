using System;
using System.Globalization;

namespace Primeiro {
    class Program {
        static void Main(string[] args) {

            CultureInfo CI = CultureInfo.InvariantCulture; // Variavel CI criada para abreviação da função de importar o . ponto

            int idade;
            double salario, altura;
            char genero;
            string nome;

            idade = 32;
            salario = 4000.9;
            altura = 1.73;
            genero = 'F';
            nome = "Eduarda";

            Console.WriteLine(idade);
            Console.WriteLine(salario.ToString("F2", CI));
            Console.WriteLine(altura.ToString("F2",CI));
            Console.WriteLine(genero);
            Console.WriteLine(nome);
        }

    }
}


