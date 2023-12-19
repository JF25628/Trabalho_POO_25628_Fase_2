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
    /// Representa um internado, derivado da classe Paciente.
    /// </summary>
    [Serializable]
    public class Internado : Paciente
    {
        #region ESTADO
        private DateTime diaEntrada;
        private DateTime diaSaida;
        private int idMedicoResponsavel;
        private string motivo;
        private int numeroQuarto;
        #endregion


        #region COMPORTAMENTO

        #region CONSTRUTORES

        /// <summary>
        /// Construtor padrão para a classe Internado.
        /// Inicializa as propriedades e o array de Internado.
        /// </summary>
        public Internado()
        {
            Nome = String.Empty;
            Idade = 0;
            TipoSanguineo = tipoSanguineo.APOSITIVO;
            DataNascimento = DateTime.Now;
            Contato = 0;
            NumeroUtente = 0;
            HistoricoMedico = String.Empty;


            diaEntrada = DateTime.Now;
            diaSaida = DateTime.Now;
            idMedicoResponsavel = 0;
            motivo = String.Empty;
            numeroQuarto = 0;
        }


        /// <summary>
        /// Inserir Informação de um novo Internado
        /// </summary>
        /// <param name="nome"></param>
        /// <param name="idade"></param>
        /// <param name="sangue"></param>
        /// <param name="dataNascimento"></param>
        /// <param name="contato"></param>
        /// <param name="numeroUtente"></param>
        /// <param name="historicoMedico"></param>
        /// <param name="diaEntrada"></param>
        /// <param name="diaSaida"></param>
        /// <param name="idMedicoResponsavel"></param>
        /// <param name="motivo"></param>
        /// <param name="numeroQuarto"></param>

        public Internado(string nome, int idade, tipoSanguineo sangue, DateTime dataNascimento, int contato, int numeroUtente, string historicoMedico, DateTime diaEntrada, DateTime diaSaida, int idMedicoResponsavel, string motivo, int numeroQuarto)
        {
            this.Nome = nome;
            this.Idade = idade;
            this.TipoSanguineo = sangue;
            this.DataNascimento = dataNascimento;
            this.Contato = contato;
            this.NumeroUtente = numeroUtente;
            this.HistoricoMedico = historicoMedico;

            this.diaEntrada = diaEntrada;
            this.diaSaida = diaSaida;
            this.idMedicoResponsavel = idMedicoResponsavel;
            this.motivo = motivo;
            this.numeroQuarto = numeroQuarto;

            //Internados internados = new Internados();
            //internados.AdicionarLista(this);
        }
        #endregion

        /// <summary>
        /// Obtém ou define a especialidade do internado.
        /// </summary>
        #region PROPRIEDADES
        public DateTime DiaEntrada
        {
            get { return diaEntrada; }
            set { diaEntrada = value; }
        }

        public DateTime DiaSaida
        {
            get { return diaSaida; }
            set { diaSaida = value; }
        }

        public int IdMedicoResponsavel
        {
            get { return idMedicoResponsavel; }
            set { idMedicoResponsavel = value; }
        }

        public string Motivo
        {
            get { return motivo; }
            set { motivo = value; }
        }

        public int NumeroQuarto
        {
            get { return numeroQuarto; }
            set { numeroQuarto = value; }
        }



        #endregion

        #region OPERADORES
        /// <summary>
        /// Sobrecarga do operador de igualdade para comparar dois objetos do tipo internado.
        /// </summary>
        public static bool operator ==(Internado internado1, Internado internado2)
        {
            if (ReferenceEquals(internado1, null) && ReferenceEquals(internado2, null))
                return true;

            if (ReferenceEquals(internado1, null) || ReferenceEquals(internado2, null))
                return false;

            if ((internado1.Nome == internado2.Nome) && (internado1.Idade == internado2.Idade) && (internado1.TipoSanguineo == internado2.TipoSanguineo) && (internado1.DataNascimento == internado2.DataNascimento) && (internado1.Contato == internado2.Contato) && (internado1.NumeroUtente == internado2.NumeroUtente) && (internado1.HistoricoMedico == internado2.HistoricoMedico) && (internado1.diaEntrada == internado2.diaEntrada) && (internado1.diaSaida == internado2.diaSaida) && (internado1.idMedicoResponsavel == internado2.idMedicoResponsavel) && (internado1.motivo == internado2.motivo))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Sobrecarga do operador de desigualdade para comparar dois objetos do tipo internado.
        /// </summary>
        public static bool operator !=(Internado internado1, Internado internado2)
        {
            if (internado1 == internado2)
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
        /// Retorna uma representação em string do objeto itnernado.
        /// </summary>
        public override string ToString()
        {
            return String.Format("Nome: {0} - Idade: {1} - Sangue: {2} - Data de Nascimento: {3} - Contato: {4} - Numero de utente: {5} - Historio Medico: {6} - Dia de Entrada: {7} - Dia de saida: {8} - Medico Responsavel: {9} - Motivo: {10} - Numero do Quarto: {11}", Nome, Idade.ToString(), TipoSanguineo.ToString(), DataNascimento.ToString(), Contato.ToString(), NumeroUtente.ToString(), HistoricoMedico, diaEntrada.ToString(), diaSaida.ToString(), idMedicoResponsavel.ToString(), motivo, numeroQuarto);
        }

        /// <summary>
        /// Verifica se o objeto é igual a outro objeto Paciente.
        /// </summary>
        public override bool Equals(object obj)
        {
            if (obj is Internado)
            {
                Internado t = (Internado)obj;
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
        ~Internado() { }
        #endregion

        #endregion
        
    }
}
