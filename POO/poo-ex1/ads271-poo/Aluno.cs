using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ads271_poo
{
    class Aluno
    {
        public string name;
        public double nota1;
        public double nota2;

        public string calcMedia(){
            return name + ", sua média é " + ((nota1 / nota2) / 2).ToString("N2");
        }
    }
}
