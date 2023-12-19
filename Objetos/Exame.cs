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
    /// Representa um exame
    /// </summary>
    [Serializable]
    public class Exame : Servico
    {

        #region ESTADO
        private int enfermeiroResponsavel;
        private int pacienteExaminado;
        #endregion


        #region COMPORTAMENTO

        #region CONSTRUTORES

        /// <summary>
        /// Construtor padrão para a classe Exame.
        /// Inicializa as propriedades.
        /// </summary>
        public Exame()
        {
            Nome = string.Empty;
            Data = DateTime.Now;
            Diagnostico = string.Empty;
            Custo = 0.0;
            enfermeiroResponsavel = 0;
            pacienteExaminado = 0;
        }

        /// <summary>
        /// Construtor parametrizado para a classe Exame.
        /// Inicializa as propriedades com os valores fornecidos.
        /// </summary>
        /// <param name="nome"></param>
        /// <param name="data"></param>
        /// <param name="diagnostico"></param>
        /// <param name="custo"></param>
        /// <param name="enfermeiroResponsavel"></param>
        /// <param name="pacienteExaminado"></param>
        public Exame(string nome, DateTime data, string diagnostico, double custo, int enfermeiroResponsavel, int pacienteExaminado)
        {
            this.Nome = nome;
            this.Data = data;
            this.Diagnostico = diagnostico;
            this.Custo = custo;
            this.enfermeiroResponsavel= enfermeiroResponsavel;
            this.pacienteExaminado = pacienteExaminado;

            //Exames exames = new Exames();
            //7exames.AdicionarLista(this);
        }

        #endregion


        /// <summary>
        /// Obtém ou define as propriedades do Exame.
        /// </summary>
        #region PROPRIEDADES
        public int EnfermeiroResponsavel
        {
            get { return enfermeiroResponsavel; }
            set { enfermeiroResponsavel = value; }
        }

        public int PacienteExaminado
        {
            get { return pacienteExaminado; }
            set { pacienteExaminado = value; }
        }

        #endregion

        #region OPERADORES
        /// <summary>
        /// Sobrecarga do operador de igualdade para comparar dois objetos do tipo Exame.
        /// </summary>
        public static bool operator ==(Exame exame1, Exame exame2)
        {
            if (ReferenceEquals(exame1, null) && ReferenceEquals(exame2, null))
                return true;

            if (ReferenceEquals(exame1, null) || ReferenceEquals(exame2, null))
                return false;


            if ((exame1.Nome == exame2.Nome) && (exame1.Data == exame2.Data) && (exame1.Diagnostico == exame2.Diagnostico) && (exame1.Custo == exame2.Custo) && (exame1.pacienteExaminado == exame2.pacienteExaminado))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Sobrecarga do operador de desigualdade para comparar dois objetos do tipo Exame.
        /// </summary>
        public static bool operator !=(Exame exame1, Exame exame2)
        {
            if (exame1 == exame2)
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
        /// Retorna uma representação em string do objeto Exame.
        /// </summary>
        public override string ToString()
        {
            return String.Format("Nome: {0} - DAta: {1} - Diagnostico: {2} - Custo: {3} - Enfermeiro: {4} - Paciente: {5}", Nome, Data.ToString(), Diagnostico, Custo.ToString(), enfermeiroResponsavel.ToString(), pacienteExaminado.ToString());
        }

        /// <summary>
        /// Verifica se o objeto é igual a outro objeto Exame.
        /// </summary>
        public override bool Equals(object obj)
        {
            if (obj is Exame)
            {
                Exame t = (Exame)obj;
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
        ~Exame() { }
        #endregion

        #endregion
        
    }
}
