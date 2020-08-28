using System;
namespace Estrutura {
    class Program {
        static void Main(string[] args) {
            var s = new Pilha();
            s.Empilhar(1);
            s.Empilhar(10);
            s.Empilhar(100);
            Console.WriteLine(s.Desempilhar());
            Console.WriteLine(s.Desempilhar());
            Console.WriteLine(s.Desempilhar());
            Console.WriteLine(s.Desempilhar());
        }
    }
}