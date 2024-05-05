using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlunoPilhaFila
{
    internal class Aluno
    {
        int Number;
        string Name;
        Aluno Previous;

        public Aluno(int number, string name)
        {
            Number = number;
            Name = name;
            Previous = null;          
        }
        public void SetPrevious(Aluno alunoAnterior)
        {
            this.Previous = alunoAnterior;
        }
        public Aluno GetPrevious()
        {
            return Previous;
        }        
        public int GetNumber()
        {
            return Number;
        }
        public override string ToString()
        {
            return $"{Name}";
        }
    }
}
