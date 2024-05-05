using System.ComponentModel.Design;

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
        public float RunOver(int number)
        {
            float result = -1;
            if (IsEmpty())
                EmptyMessage();
            else
            {
                float[] grade = new float[2];
                grade[0] = -1;
                grade[1] = -1;
                int index = 0;
                Nota aux = Head;
                do
                {
                    if (number == aux.GetNumber())
                    {
                        grade[index] = aux.GetGrade();
                        index++;
                    }
                    aux = aux.GetNext();
                } while (aux != Tail.GetNext());
                if (grade[0] == 0 && grade[1] == 0)
                    result = 0;
                else if ((grade[0] > 0 && grade[1] > 0)|| (grade[0] > 0 && grade[1] == 0) || (grade[0] == 0 && grade[1] > 0))
                    result = (grade[0] + grade[1]) / 2;
            }
        return result;
        }
        public Nota GetHead() 
        { 
            return Head; 
        }
    }
}
