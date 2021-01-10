using System;
using _02_12___Criando_um_sistema_orientado_objetos.classes;

namespace _02_12___Criando_um_sistema_orientado_objetos
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Aluno aluno = new Aluno();

            Console.WriteLine("Digite o nome do aluno: ");
            aluno.nome = Console.ReadLine();

            Console.WriteLine($"Digite o curso do Aluno:");
            aluno.curso = Console.ReadLine();
            
            Console.WriteLine($"Digite o RG do aluno");
            aluno.rg = Console.ReadLine();
            
            Console.WriteLine($"Digite a idade do aluno");
            aluno.idade = int.Parse(Console.ReadLine());
            
            Console.WriteLine($"Digite a média final do aluno");
            aluno.mediaFinal = float.Parse(Console.ReadLine());

            Console.WriteLine($"Digite o valor da mensalidade");
            aluno.valorMensalidade = float.Parse(Console.ReadLine());

            Console.WriteLine($"Digite se o aluno é bolsista ou não s/n");
            string resposta = Console.ReadLine();

            if(resposta == "s"){
                aluno.bolsista = true;
            }else{
                aluno.bolsista = false;
            }
            
            // Menu
            int opcao = 0;
            do{
                Console.WriteLine($"Selecione uma opção");
                Console.WriteLine($"[1] - Ver média do aluno");
                Console.WriteLine($"[2] - Ver mensalidade do aluno");
                Console.WriteLine($"[3] - Sair");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                    Console.WriteLine($"A média final do aluno {aluno.nome} = {aluno.VerMediaAluno()}");
                    break;
                    case 2:
                    Console.WriteLine($"O valor da mensalidade do aluno {aluno.nome} será de {aluno.VerMensalidade()}");
                    break;
                    case 3:
                    break;
                }
                
            }while (opcao != 0);
            
            
            
            
            
            
            
        }
    }
}
