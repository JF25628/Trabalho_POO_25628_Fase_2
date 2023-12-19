/*
 * trabalhoPOO_25628
 * Nome: João Miguel Oliveira Figueiredo 
 * Numero de aluno: 25628
 * Email: a25628alunos.ipca.pt
 * Escola de tecnologia
 * Curso de Licenciatura de Engenharia de Sistemas Informaticos
 * Disciplina: Programação Orientada a Objetos
 * 07/11/2023
 * 
 */

namespace Objetos
{
    public interface IPessoa
    {
        int CalcularIdade(DateTime dataNascimento);
    }

    /// <summary>
    /// Classe que representa uma pessoa com informações básicas como nome, idade e data de nascimento.
    /// </summary>
    [Serializable]
    public class PessoaAbstract : IPessoa
    {
        public int CalcularIdade(DateTime dataNascimento)
        {
            int idade = 0;

            DateTime hoje = DateTime.Now;
            idade = dataNascimento.Year - hoje.Year;

            if (dataNascimento.Date > hoje.AddYears(-idade)) idade--;

            return idade;
        }
 
    }
}
