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
    /// Representa uma consulta, derivado da classe servico.
    /// </summary>
    [Serializable]
    public class Consulta : Servico
    {

        #region ESTADO
        private int idMedico;
        private int numeroUtentePaciente;
        private string receita;
        #endregion


        #region COMPORTAMENTO

        #region CONSTRUTORES

        /// <summary>
        /// Construtor padrão para a classe Consulta.
        /// Inicializa as propriedades.
        /// </summary>
        public Consulta()
        {
            Nome = string.Empty;
            Data = DateTime.Now;
            Diagnostico = string.Empty;
            Custo = 0.0;

            idMedico = 0;
            numeroUtentePaciente = 0;
            receita = string.Empty;
        }

        /// <summary>
        /// Construtor parametrizado para a classe Consulta.
        /// Inicializa as propriedades com os valores fornecidos.
        /// </summary>
        /// <param name="nome"></param>
        /// <param name="data"></param>
        /// <param name="diagnostico"></param>
        /// <param name="custo"></param>
        /// <param name="idMedico"></param>
        /// <param name="numeroUtentePaciente"></param>
        /// <param name="receita"></param>
        public Consulta(string nome, DateTime data, string diagnostico, double custo, int idMedico, int numeroUtentePaciente, string receita)
        {
            this.Nome = nome;
            this.Data = data;
            this.Diagnostico = diagnostico;
            this.Custo = Custo;

            this.idMedico = idMedico;
            this.numeroUtentePaciente = numeroUtentePaciente;
            this.receita = receita;

            //Consultas consultas = new Consultas();
            //Consultas.AdicionarLista(this);

        }

        #endregion

        /// <summary>
        /// Obtém ou define as propriedades da consulta.
        /// </summary>
        #region PROPRIEDADES
        public int IdMedico
        {
            get { return idMedico; }
            set { idMedico = value; }
        }

        public int NumeroUtentePaciente
        {
            get { return numeroUtentePaciente; }
            set { numeroUtentePaciente = value; }
        }
        public string Receita
        {
            get { return receita; }
            set { receita = value; }
        }
        #endregion

        #region OPERADORES

        /// <summary>
        /// Sobrecarga do operador de igualdade para comparar dois objetos do tipo Consulta.
        /// </summary>
        /// <param name="consulta1"></param>
        /// <param name="consulta2"></param>
        /// <returns></returns>
        public static bool operator ==(Consulta consulta1, Consulta consulta2)
        {
            if (ReferenceEquals(consulta1, null) && ReferenceEquals(consulta2, null))
                return true;

            if (ReferenceEquals(consulta1, null) || ReferenceEquals(consulta2, null))
                return false;

            if ((consulta1.Nome == consulta2.Nome) && (consulta1.Data == consulta2.Data) && (consulta1.Diagnostico == consulta2.Diagnostico) && (consulta1.Custo == consulta2.Custo) && (consulta1.IdMedico == consulta2.IdMedico) && (consulta1.NumeroUtentePaciente == consulta2.NumeroUtentePaciente) && (consulta1.receita == consulta2.receita))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Verifica se o objeto é igual a outro objeto Consulta.
        /// </summary>
        /// <param name="consulta1"></param>
        /// <param name="consulta2"></param>
        /// <returns></returns>
        public static bool operator !=(Consulta consulta1, Consulta consulta2)
        {
            if (consulta1 == consulta2)
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
        /// Retorna uma representação em string do objeto Consulta.
        /// </summary>
        public override string ToString()
        {
            return String.Format("Nome: {0} - Data: {1} - Diagnostico: {2} - Custo: {3} - Id Medico: {4} - Numero de utente do paciente: {5} - Receita: {6}", Nome, Data.ToString(), Diagnostico, Custo.ToString(), idMedico.ToString(), numeroUtentePaciente.ToString(), receita);
            //ir buscar o nome das pessoas?
        }

        /// <summary>
        /// Verifica se o objeto é igual a outro objeto Consulta.
        /// </summary>
        public override bool Equals(object obj)
        {
            if (obj is Consulta)
            {
                Consulta t = (Consulta)obj;
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
        ~Consulta() { }
        #endregion

        #endregion
        
    }
}
