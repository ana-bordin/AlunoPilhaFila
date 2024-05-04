namespace AlunoPilhaFila
{
    internal class FilaNota
    {
        Nota Head;
        Nota Tail;
        public FilaNota()
        {
            Head = null;
            Tail = null;
        }
        bool IsEmpty()
        {
            return Head == null && Tail == null;
        }
        string EmptyMessage()
        {
            return "Fila Vazia!";
        }
        public void Push(Nota aux)
        {
            if (IsEmpty())
                Head = Tail = aux;
            else
            {
                Tail.SetNext(aux);
                Tail = aux;
            }
        }
        public void Print()
        {
            int qtdElementos = 0;
            if (IsEmpty())
                EmptyMessage();
            else
            {
                Nota aux = Head;
                do
                {
                    Console.WriteLine(aux.ToString());
                    aux = aux.GetNext();
                } while (aux != Tail.GetNext());
            }
        }
        public void Pop()
        {
            if (IsEmpty())
                EmptyMessage();

            else
            {
                if (Tail == Head)
                    this.Head = this.Tail = null;
                else
                    this.Head = Head.GetNext();
            }               
        }
        public int RunOver()
        {
            int qtdElementos = 0;
            if (IsEmpty())
                EmptyMessage();
            else
            {
                Nota aux = Head;
                do
                {
                    aux = aux.GetNext();
                    qtdElementos++;
                } while (aux != Tail.GetNext());
            }
            return qtdElementos;
        }
    }
}
