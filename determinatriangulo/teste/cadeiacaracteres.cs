using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teste
{
    class cadeiacaracteres
    {
        public string buscar(string caracteres, char c) {
            int comprimentocaracteres = caracteres.Length;

            string retorno = "";
            if(comprimentocaracteres < 1 || comprimentocaracteres > 20)
            {
                retorno = "erro: cadeia inválida";
            }else if (char.IsWhiteSpace(c))
            {
                retorno = "erro: caractere inválido";
            }
            else
            {
                retorno = "erro: não encontrado";
                for (int i = 0; i < comprimentocaracteres; i++)
                {
                    if (caracteres[i].ToString() == c.ToString() )
                    {
                        retorno = i.ToString();
                        break;
                    }
                }
            }

            return retorno;
        }
    }
}
