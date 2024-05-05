namespace AlunoPilhaFila
{
    internal class PilhaAluno
    {
        Aluno Topo;
        public PilhaAluno()
        {
            Topo = null;
        }
        bool IsEmpty()
        {
            return Topo == null;
        }
        string EmptyMessage()
        {
            return "Pilha Vazia!";
        }
        public void Push(Aluno aux)
        {
            if (IsEmpty())
                Topo = aux;
            else
            {
                aux.SetPrevious(Topo);
                Topo = aux;
            }
        }
        public void Pop()
        {
            if (IsEmpty())
                EmptyMessage();
            else
                Topo = Topo.GetPrevious();
        }
        public void Print()
        {
            Aluno aux = Topo;
            if (IsEmpty())
                EmptyMessage();
            else
            {
                do
                {
                    Console.WriteLine(aux.ToString());
                    aux = aux.GetPrevious();
                } while (aux != null);
            }
        }
        public bool Check(int number)
        {
            bool check = false;
            Aluno aux = Topo;
            if (IsEmpty())
                EmptyMessage();
            else
            {
                do
                {
                    if (number == aux.GetNumber())
                        check = true;
                    aux = aux.GetPrevious();
                } while (aux != null);
            }
            return check;
        }

        public Aluno GetTopo()
        {
            return Topo;
        }
    }
}
