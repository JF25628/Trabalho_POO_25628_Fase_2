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
    /// Representa um médico, derivado da classe Staff.
    /// </summary>
    [Serializable]
    public class Medico : Staff
    {
        #region ESTADO
        private string especialidade;
        private string licenca;
        #endregion

        #region COMPORTAMENTO

        #region CONSTRUTORES

        /// <summary>
        /// Construtor padrão para a classe Medico.
        /// Inicializa as propriedades.
        /// </summary>
        public Medico()
        {
            IdFuncionario = 0;
            Nome = string.Empty;
            Idade = 0;
            DataNascimento = DateTime.Now;
            Contato = 0;
            IdFuncionario = 0;
            Salario = 0.0;
            especialidade = string.Empty;
            licenca = string.Empty;
        }

        /// <summary>
        /// Construtor parametrizado para a classe Medico.
        /// Inicializa as propriedades com os valores fornecidos.
        /// </summary>
        /// <param name="nome"></param>
        /// <param name="idade"></param>
        /// <param name="dataNascimento"></param>
        /// <param name="contato"></param>
        /// <param name="idfuncionario"></param>
        /// <param name="salario"></param>
        /// <param name="especialidade"></param>
        /// <param name="licenca"></param>
        public Medico(string nome, int idade, DateTime dataNascimento, int contato,int idfuncionario, double salario, string especialidade, string licenca)
        {
            this.IdFuncionario = idfuncionario;//mudar para depois ser automatico
            this.Nome = nome;
            this.Idade = idade;
            this.DataNascimento = dataNascimento;
            this.Contato = contato;
            this.IdFuncionario = idfuncionario;
            this.Salario = salario;
            this.especialidade = especialidade;
            this.licenca = licenca;

            //Medicos medicos = new Medicos();
            //medicos.AdicionarLista(this);
        }

        #endregion

        /// <summary>
        /// Obtém ou define as propriedades do médico.
        /// </summary>
        #region PROPRIEDADES
        public string Especialidade
        {
            get { return especialidade; }
            set { especialidade = value; }
        }

        public string Licenca
        {
            get { return licenca; }
            set { licenca = value; }
        }


        #endregion

        #region OPERADORES
        /// <summary>
        /// Sobrecarga do operador de igualdade para comparar dois objetos do tipo Medico.
        /// </summary>
        public static bool operator ==(Medico medico1, Medico medico2)
        {
            if (ReferenceEquals(medico1, null) && ReferenceEquals(medico2, null))
                return true;

            if (ReferenceEquals(medico1, null) || ReferenceEquals(medico2, null))
                return false;

            if ((medico1.Nome == medico2.Nome) && (medico1.Idade == medico2.Idade) && (medico1.DataNascimento == medico2.DataNascimento) && (medico1.Contato == medico2.Contato) && (medico1.IdFuncionario == medico2.IdFuncionario) && (medico1.Salario == medico2.Salario) && (medico1.especialidade == medico2.especialidade) && (medico1.licenca == medico2.licenca))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Sobrecarga do operador de desigualdade para comparar dois objetos do tipo Medico.
        /// </summary>
        public static bool operator !=(Medico medico1, Medico pessoa2)
        {
            if (medico1 == pessoa2)
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
        /// Retorna uma representação em string do objeto Medico.
        /// </summary>
        public override string ToString()
        {
            return String.Format("Nome: {0} - Idade: {1} - Data de Nascimento: {2} - Contato: {3} - ID de Funcionario: {4} - Salario: {5} -  Especialidade: {6} -  Licença: {7}", Nome, Idade.ToString(), DataNascimento.ToString(), Contato.ToString(), IdFuncionario.ToString(), Salario.ToString(), especialidade, licenca);
        }

        /// <summary>
        /// Verifica se o objeto é igual a outro objeto Medico.
        /// </summary>
        public override bool Equals(object obj)
        {
            if (obj is Medico)
            {
                Medico t = (Medico)obj;
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
        ~Medico() { }
        #endregion

        #endregion

    }
}
