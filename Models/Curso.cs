using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exemploexplorando.Models
{
    public class Curso
    {
        public string Nome { get; set; }
        public List <Pessoa> Alunos { get; set; } //lista é uma coleção de um tipo, nesse caso Pessoa //Essas public são duas propriedades

        public void AdicionarAluno(Pessoa aluno) //assinatura de um metodo, desde Void até o final das seções. //Void significa sem retorno
        {
            Alunos.Add(aluno);
        }
        public int ObterQuantidadeDeAlunosMatriculados()
        {
            int quantidade = Alunos.Count; //Count retorna a quantidade de alunos listados na lista Pessoa
            return quantidade; //para que ele entenda que terminou é necessario inserir o return se não ele se perde
        }
        public bool RemoverAluno(Pessoa aluno) 
        {
            return  Alunos.Remove(aluno);
        }

        public void ListarAlunos()
        {
            Console.WriteLine($"Alunos do curso de: {Nome}");

            for (int count = 0; count <Alunos.Count; count ++)
            {
                // string texto = "N° " + count + " - " + Alunos[count].NomeCompleto;//Metdodo concatenação:  o + é usado para concatenar os valores das minhas String, enquanto que o count ele conta os valores de cada string começacando com o Zero
                //int exibicao = count + 1;  //para tirar de dentro do meu count caso seja necessario, não esquecer de alterar o count para exibição.
                string texto  = $"N° {count + 1} - {Alunos[count].NomeCompleto} ";//Metodo Interpolação: age da mesma forma só que define em apenas um texto a string não em partes como o caso da concatenação. 
                Console.WriteLine(texto);
            }
        }
    }
}