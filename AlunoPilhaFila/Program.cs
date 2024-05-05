using System;

namespace AlunoPilhaFila
{
    internal class Program
    {
        static PilhaAluno pilhaAluno = new PilhaAluno();
        static int numAluno = 1;
        static FilaNota filaNota = new FilaNota();
        static bool sair = false;
        static void Menu()
        {        
            Console.WriteLine("Digite a opção desejada:\n" +
                              "1. cadastrar aluno;\n" +
                              "2. cadastrar nota do aluno;\n" +
                              "3. calcular media do aluno;\n" +
                              "4. listar o nome dos alunos sem nota;\n" +
                              "5. excluir aluno;\n" +
                              "6. excluir nota;\n" +
                              "7. sair\n");
        }
        static void EscolhaMenu(int op)
        {
            switch (op)
            {
                case 1:
                    AdicionarAluno();
                    break;
                case 2:
                    AdicionarNota();
                    break;
                case 3:
                    MostrarMedia();
                    break;
                case 4:
                    ListarAlunoSemNota();
                    break;
                case 5:
                    ExcluirAluno();
                    break;
                case 6:
                    ExcluirNota();
                    break;
                case 7:
                    sair = true;
                    break;
                default:
                    break;
            }
        }
        static void AdicionarAluno()
        {
            Console.WriteLine("Digite o nome do aluno:");
            pilhaAluno.Push(new Aluno(numAluno, Console.ReadLine()));
            numAluno++;
        }
        static void AdicionarNota()
        {
            Console.WriteLine("Digite o numero do aluno:");
            int num = ChecarAluno();

            float nota = 0;
            do
            {
                Console.WriteLine("Digite a nota do aluno:");
                nota = float.Parse(Console.ReadLine());
                if (nota < 0)
                    Console.WriteLine("Digite uma nota válida!!!");
            } while (nota <= 0);

            filaNota.Push(new Nota(num, nota));
        }
        static int ChecarAluno()
        {
            bool alunoExiste = false;
            int num;
            do
            {
                num = int.Parse(Console.ReadLine());
                alunoExiste = pilhaAluno.Check(num);
                if (!alunoExiste)
                    Console.WriteLine("Aluno não existe!\nDigite um número válido!");

            } while (alunoExiste == false);
            return num;
        }
        static void MostrarMedia()
        {
            Console.WriteLine("Digite o numero do aluno:");
            int num = ChecarAluno();
            ImprimirNotaMedia(num, 1);
        }
        static void ImprimirNotaMedia(int num, int op)
        {
            float resultado = filaNota.RunOver(num);
            if (resultado == -1 && op == 1)
                Console.WriteLine("Aluno sem notas suficientes para média!");
            else if (resultado > 0 && op == 1)
                Console.WriteLine($"A média do aluno {num} foi {resultado};");
            else if (resultado == -1 && op == 2)
                Console.WriteLine($"Aluno {num} não possui NENHUMA nota!");
        }
        static void ListarAlunoSemNota()
        {
            Aluno auxPilha = pilhaAluno.GetTopo();
            while (auxPilha != null)
            {
                int numAluno = auxPilha.GetNumber();
                ImprimirNotaMedia(numAluno, 2);
                auxPilha = auxPilha.GetPrevious();
            }
        }

        static void ExcluirAluno()
        {
            Console.WriteLine("Digite o numero do aluno:");
            int num = ChecarAluno();
            if (pilhaAluno.GetTopo() != null && num == pilhaAluno.GetTopo().GetNumber())
            {
                if (-1 != filaNota.RunOver(num))
                {
                    Console.WriteLine($"Aluno {num} foi excluido!");
                    pilhaAluno.Pop();
                }              
                else
                    Console.WriteLine("Você não pode excluir esse aluno por que ele possui notas!");
            }
            else
                Console.WriteLine("Você não pode excluir esse aluno porque ele não esta no topo da pilha!");
        }
        static void ExcluirNota()
        {
            Console.WriteLine("Digite o numero do aluno:");
            int num = ChecarAluno();
            if (filaNota.GetHead() != null)
            {
                if (filaNota.GetHead().GetNumber() == num)
                {
                    Console.WriteLine($"A nota do aluno {num} foi excluido!");
                    pilhaAluno.Pop();
                }
                else
                    Console.WriteLine("Você não pode excluir essa nota porque ela não está no inicio da fila!");
            }
            else
                Console.WriteLine("Fila de notas vazia!");
        }
        static void Main(string[] args)
        {
            do
            {
                Console.Clear();
                Console.WriteLine(">>>Alunos<<<");
                Menu();
                EscolhaMenu(int.Parse(Console.ReadLine()));
            } while (sair == true);
        }
    }
}
