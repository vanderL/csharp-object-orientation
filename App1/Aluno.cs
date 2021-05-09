using System;
using System.Collections.Generic;
using System.Text;

namespace App1
{
    class Aluno
    {
        public string Name;
        public double Nota1, Nota2, Nota3;

        public double NotaFinal()
        {
            return Nota1 + Nota2 + Nota3;
        }

        public bool Aprovado()
        {
            if (NotaFinal() >= 60)
            {
                return true;
            } else
            {
                return false;
            }
        }

        public double NotaFaltante()
        {
            return 60.00 - NotaFinal();
        }
    }
}
