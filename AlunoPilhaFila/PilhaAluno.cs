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
        public int RunOver()
        {
            int qtdElementos = 0;
            Aluno aux = Topo;
            if (IsEmpty())
                EmptyMessage();
            else
            {
                do
                {
                    aux = aux.GetPrevious();
                    qtdElementos++;
                } while (aux != null);
            }
            return qtdElementos;
        }
    }
}
