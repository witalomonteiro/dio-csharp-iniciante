using System;

namespace Revisao {
    class Program {
        static void Main(string[] args) {
            
            int opcao = 0;
            Aluno[] alunos = new Aluno[5];
            var i = 0;

            while (opcao != 4) {
                Console.WriteLine();
                Console.WriteLine("--------------------------");
                Console.WriteLine("--- Controle de Alunos ---");
                Console.WriteLine("--------------------------");
                Console.WriteLine("[1] Cadastrar");
                Console.WriteLine("[2] Listar");
                Console.WriteLine("[3] Calcular Média");
                Console.WriteLine("[4] Sair");
                Console.WriteLine();
                Console.Write("Opção escolhida: ");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao) {
                    case 1:
                        Console.WriteLine();
                        Console.WriteLine("-----------------------");
                        Console.WriteLine("--- Cadastrar Aluno ---");
                        Console.WriteLine("-----------------------");
                        Aluno aluno = new Aluno();
                        Console.Write("Nome: ");
                        aluno.setNome(Console.ReadLine());
                        Console.Write("Nota: ");
                        aluno.setNota(decimal.Parse(Console.ReadLine()));
                        alunos[i] = aluno;
                        i++;
                        break;
                    case 2:
                        Console.WriteLine();
                        Console.WriteLine("---------------------");
                        Console.WriteLine("--- Listar Alunos ---");
                        Console.WriteLine("---------------------");
                        Console.WriteLine("Nome | Nota");
                        for (int x = 0; x < i; x++) {
                            Console.WriteLine($"{alunos[x].getNome()} | {alunos[x].getNota()}");
                        }
                        break;
                    case 3:
                        Console.WriteLine();
                        Console.WriteLine("------------------------");
                        Console.WriteLine("--- Média dos Alunos ---");
                        Console.WriteLine("------------------------");
                        decimal total = 0;
                        string categoria = "";
                        for (int x = 0; x < i; x++) {
                            total += alunos[x].getNota();
                        }
                        var media = total / i;
                        if (media < 5) {
                            categoria = "C";
                        } else if (media < 8) {
                            categoria = "B";
                        } else if (media >= 8) {
                            categoria = "A";
                        }
                        Console.WriteLine($"Quant. de Alunos: {i}");
                        Console.WriteLine($"Média Geral: {media}");
                        Console.WriteLine($"Categoria da Turma: {categoria}");
                        break;
                    default:
                        //throw new ArgumentOutOfRangeException();
                        break;
                }
            }
        }
    }
}
