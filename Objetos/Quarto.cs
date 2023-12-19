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
    /// Representa um Quarto.
    /// </summary>
    [Serializable]
    public class Quarto
    {

        #region ESTADO
        private int numeroQuarto;
        private int numeroCamas;
        //private int numeroCamasOcupadas;
        private int idEnfermeiro;
        //private int idInternado;
        private double custo;
        #endregion

        #region COMPORTAMENTO

        #region CONSTRUTORES

        /// <summary>
        /// Construtor padrão para a classe Quarto.
        /// Inicializa as propriedades.
        /// </summary>
        public Quarto()
        {
            numeroQuarto = 0;
            numeroCamas = 0;
            //numeroCamasOcupadas = 0;
            idEnfermeiro = 0;
            //idInternado = 0;
            custo = 0.0;
        }

        /// <summary>
        /// Construtor parametrizado para a classe Quartos.
        /// Inicializa as propriedades com os valores fornecidos.
        /// </summary>
        /// <param name="numeroQuarto"></param>
        /// <param name="numeroCamas"></param>
        /// <param name="numeroCamasOcupadas"></param>
        /// <param name="idEnfermeiro"></param>
        /// <param name="idInternado"></param>
        /// <param name="custo"></param>
        public Quarto(int numeroQuarto, int numeroCamas, int numeroCamasOcupadas, int idEnfermeiro, int idInternado, double custo)
        {
            this.numeroQuarto = numeroQuarto;
            this.numeroCamas = numeroCamas;
            //this.numeroCamasOcupadas = numeroCamasOcupadas;
            this.idEnfermeiro = idEnfermeiro;
            //this.idInternado = idInternado;
            this.custo = custo;

            //tava dar erro arranja
            //Quartos quartos = new Quartos();
            //quartos.AdicionarLista(this);
        }
        #endregion

        /// <summary>
        /// Obtém ou define a especialidade do Quarto.
        /// </summary>
        #region PROPRIEDADES

        public int NumeroQuarto
        {
            get { return numeroQuarto; }
            set { numeroQuarto = value; }
        }

        public int NumeroCamas
        {
            get { return numeroCamas; }
            set { numeroCamas = value; }
        }

        //public int NumeroCamasOcupadas
        //{
        //    get { return numeroCamasOcupadas; }
        //    set { numeroCamasOcupadas = value; }
        //}


        public int IdEnfermeiro
        {
            get { return idEnfermeiro; }
            set { idEnfermeiro = value; }
        }

        public double Custo
        {
            get { return custo; }
            set { custo = value; }
        }



        #endregion

        #region OPERADORES
        /// <summary>
        /// Sobrecarga do operador de igualdade para comparar dois objetos do tipo Medico.
        /// </summary>
        /// <param name="quarto1"></param>
        /// <param name="quarto2"></param>
        /// <returns></returns>
        public static bool operator ==(Quarto quarto1, Quarto quarto2)
        {
            if (ReferenceEquals(quarto1, null) && ReferenceEquals(quarto2, null))
                return true;

            if (ReferenceEquals(quarto1, null) || ReferenceEquals(quarto2, null))
                return false;

            if ((quarto1.numeroQuarto == quarto2.numeroQuarto) && (quarto1.numeroCamas == quarto2.numeroCamas) && /*(quarto1.numeroCamasOcupadas == quarto2.numeroCamasOcupadas) &&*/ (quarto1.idEnfermeiro == quarto2.idEnfermeiro) && /*(quarto1.idInternado == quarto2.idInternado) &&*/ (quarto1.custo == quarto2.custo))
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
        public static bool operator !=(Quarto quartos1, Quarto quartos2)
        {
            if (quartos1 == quartos2)
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
        /// Retorna uma representação em string do objeto Quarto.
        /// </summary>
        public override string ToString()
        {
            return String.Format("^Numero Quarto: {0} - Numero de camas: {1} - ID Enfermeiro: {2} - Custo: {3}", numeroQuarto.ToString(), numeroCamas.ToString(), /*numeroCamasOcupadas.ToString(),*/ idEnfermeiro.ToString(), /*idInternado.ToString(),*/ custo.ToString());
        }

        /// <summary>
        /// Verifica se o objeto é igual a outro objeto Quarto.
        /// </summary>
        public override bool Equals(object obj)
        {
            if (obj is Quarto)
            {
                Quarto t = (Quarto)obj;
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
        ~Quarto() { }
        #endregion

        #endregion


    }
}
