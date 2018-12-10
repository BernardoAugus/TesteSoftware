using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teste
{
    class fibonacci
    {
        public string pegarfibonacci(int n)
        {
            string retorno = "";
            if(n <= 0)
            {
                retorno = "n deve ser positivo";
            }
            else
            {
                int x = 0;
                int y = 1;
                for (int i = 0; i < n; i++)
                {
                    int temp = x;
                    x = y;
                    y = temp + y;
                    retorno += x.ToString() + ' ';
                }
               
            }

            return retorno;
        }
    }
}
