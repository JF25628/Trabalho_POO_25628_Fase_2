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
using Excecoes;

namespace Objetos
{
    /// <summary>
    /// Classe que representa uma pessoa com informações básicas como nome, idade e data de nascimento.
    /// </summary>
    [Serializable]
    public class Pessoa : PessoaAbstract
    {

        /// <summary>
        /// Campos privados para armazenar o estado da pessoa
        /// </summary>
        #region ESTADO
        private string nome;
        private int idade;
        private DateTime dataNascimento;
        private int contato;
        #endregion

        #region COMPORTAMENTO

        #region CONSTRUTORES

        /// <summary>
        /// Construtor padrão para a classe Pessoa.
        /// Inicializa nome, idade e contato com valores padrão. 
        /// </summary>
        public Pessoa()
        {
            nome = String.Empty;
            idade = 0;
            contato = 0;
        }

        /*
        public Pessoa(string nome, int idade, tipoSanguineo sangue, DateTime dataNascimento, int numeroUtente)
        {
            this.nome = nome;
            this.idade = idade;
            this.sangue = sangue;
            this.dataNascimento = dataNascimento;
            this.numeroUtente = numeroUtente;
        }
        */

        #endregion


        /// <summary>
        /// Obter ou definer as propriedades das vareaveis.
        /// </summary>
        #region PROPRIEDADES
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public int Idade
        {
            get { return idade; }
            set { idade = value; }
        }

        public DateTime DataNascimento
        {
            get { return dataNascimento; }
            set { dataNascimento = value; }
        }

        public int Contato
        {
            get { return contato; }
            set { contato = value; }
        }

        #endregion

        #region OPERADORES
        
        public static bool operator ==(Pessoa pessoa1, Pessoa pessoa2)
        {
            if ((pessoa1.Nome == pessoa2.Nome) && (pessoa1.Idade == pessoa2.Idade) && (pessoa1.DataNascimento == pessoa2.DataNascimento))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator !=(Pessoa pessoa1, Pessoa pessoa2)
        {
            if (pessoa1 == pessoa2)
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
        
        public override string ToString()
        {
            return String.Format("Nome: {0} - Idade: {1} - Tipo Sanguineio: {2} - Data de Nascimento: {2} - Numero de Utente: {4}", nome, idade.ToString(), dataNascimento.ToString());
        }

        public override bool Equals(object obj)
        {
            if (obj is Pessoa)
            {
                Pessoa t = (Pessoa)obj;
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
        ~Pessoa() { }
        #endregion

        #endregion
    }
}
