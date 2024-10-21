using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tuplas_operador_ternario_e_desconstrução_de_um_objeto_com_C_.Models
{
    public class LeituraArquivo
    {
        public (bool sucesso, string[]Linhas, int Quantidade) LerArquivo(string caminho)
        {
            try
            {
            string [] linhas = File.ReadAllLines(caminho);

            return(true, linhas, linhas.Count());//caso seja verdadeiro o retorno dá a quantidade de dados.
            }
            catch(Exception)
            {
                return (false, new string[0],0);//caso ele falhe da o retorno falso
            }

        
        }
    }
}