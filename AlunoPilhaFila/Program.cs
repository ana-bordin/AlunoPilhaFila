namespace AlunoPilhaFila
{
    internal class Program
    {
        static PilhaAluno pilhaAluno = new PilhaAluno();
        static int numAluno = 1;
        static FilaNota filaNota = new FilaNota();
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
            int num = Checar(int.Parse(Console.ReadLine()));

            Console.WriteLine("Digite a nota do aluno:");
            int nota = Checar(int.Parse(Console.ReadLine()));

            filaNota.Push(new Nota(num, nota));
        }
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine(">>>Alunos<<<");
                Menu();
                EscolhaMenu(int.Parse(Console.ReadLine()));
            } while (true);
        }
    }
}
