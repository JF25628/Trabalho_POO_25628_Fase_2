/*
 * trabalhoPOO_25628 - Fase 2
 * Nome: João Miguel Oliveira Figueiredo 
 * Numero de aluno: 25628
 * Email: a25628alunos.ipca.pt
 * Escola de tecnologia
 * Curso de Licenciatura de Engenharia de Sistemas Informaticos
 * Unidade Curricular: Programação Orientada a Objetos
 * 19/12/2023
 * 
 */

using System;
using System.ComponentModel;
using Excecoes;

namespace Objetos
{
    [Serializable]
    public class Enfermeiro : Staff
    {
        /// <summary>
        /// Representa um enfermeiro, derivado da classe Staff.
        /// </summary>

        #region ESTADO
        private string qualificacao;
        #endregion


        #region COMPORTAMENTO

        #region CONSTRUTORES

        /// <summary>
        /// Construtor padrão para a classe Enfermeiro.
        /// Inicializa as propriedades e o array de enfermeiros.
        /// </summary>
        public Enfermeiro()
        {
            IdFuncionario = 0;
            Nome = string.Empty;
            Idade = 0;
            DataNascimento = DateTime.Now;
            Contato = 0;
            IdFuncionario = 0;
            Salario = 0.0;
            qualificacao = string.Empty;
        }

        /// <summary>
        /// Construtor parametrizado para a classe Enfermeiro.
        /// Inicializa as propriedades com os valores fornecidos.
        /// </summary>
        /// <param name="nome"></param>
        /// <param name="idade"></param>
        /// <param name="dataNascimento"></param>
        /// <param name="contato"></param>
        /// <param name="idfuncionario"></param>
        /// <param name="salario"></param>
        /// <param name="qualificacao"></param>
        public Enfermeiro(string nome, int idade, DateTime dataNascimento, int contato, int idfuncionario, double salario, string qualificacao)
        {
            this.Nome = nome;
            this.Idade = idade;
            this.DataNascimento = dataNascimento;
            this.Contato = Contato;
            this.IdFuncionario = idfuncionario;
            this.Salario = salario;
            this.qualificacao = qualificacao;

            //Enfermeiros enfermeiros = new Enfermeiros();
            //enfermeiros.AdicionarLista(this);
        }

        #endregion

        /// <summary>
        /// Obtém ou define a qualificacao do enfermeiro.
        /// </summary>
        #region PROPRIEDADES
        public string Qualificacao
        {
            get { return qualificacao; }
            set { qualificacao = value; }
        }


        #endregion

        #region OPERADORES
        /// <summary>
        /// Sobrecarga do operador de igualdade para comparar dois objetos do tipo Enfermeiro.
        /// </summary>

        public static bool operator ==(Enfermeiro enfermeiro1, Enfermeiro enfermeiro2)
        {
            if (ReferenceEquals(enfermeiro1, null) && ReferenceEquals(enfermeiro2, null))
                return true;

            if (ReferenceEquals(enfermeiro1, null) || ReferenceEquals(enfermeiro2, null))
                return false;

            if ((enfermeiro1.Nome == enfermeiro2.Nome) && (enfermeiro1.Idade == enfermeiro2.Idade) && (enfermeiro1.DataNascimento == enfermeiro2.DataNascimento) && (enfermeiro1.Contato == enfermeiro2.Contato) && (enfermeiro1.IdFuncionario == enfermeiro2.IdFuncionario) && (enfermeiro1.Salario == enfermeiro2.Salario) && (enfermeiro1.qualificacao == enfermeiro2.qualificacao))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Sobrecarga do operador de desigualdade para comparar dois objetos do tipo Enfermeiro.
        /// </summary>
        public static bool operator !=(Enfermeiro enfermeiro1, Enfermeiro enfermeiro2)
        {
            if (enfermeiro1 == enfermeiro2)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        #endregion

        #region OVERRIDES
        /// <summary>
        /// Retorna uma representação em string do objeto Enfermeiro.
        /// </summary>
        public override string ToString()
        {
            return String.Format("Nome: {0} - Idade: {1} - Data de Nascimento: {2} - Contato: {3} - ID de Funcionario: {4} - Salario: {5} -  Qualificacao: {6}", Nome, Idade.ToString(), DataNascimento.ToString(), Contato.ToString(), IdFuncionario.ToString(), Salario.ToString(), qualificacao);
        }

        /// <summary>
        /// Verifica se o objeto é igual a outro objeto Enfermeiro.
        /// </summary>
        public override bool Equals(object obj)
        {
            if (obj is Enfermeiro)
            {
                Enfermeiro t = (Enfermeiro)obj;
                if (this == t)
                {
                    return true;
                }
            }

            return false;
        }

        #endregion

        #region OUTROSMETODOS

        #endregion

        #region DESTRUCTOR
        ~Enfermeiro() { }
        #endregion

        #endregion


    }
}