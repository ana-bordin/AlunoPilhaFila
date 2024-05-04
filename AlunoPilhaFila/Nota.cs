using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlunoPilhaFila
{
    internal class Nota
    {
        int Number;
        float Grade;
        Nota Next;

        public Nota(int number, float grade)
        {
            Number = number;
            Grade = grade;
            Next = null;
        }
        public void SetNext(Nota proximaNota)
        {
            this.Next = proximaNota;
        }
        public Nota GetNext()
        {
            return Next;
        }
        public override string ToString()
        {
            return $"{Grade}";
        }
    }
}
