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

public enum tipoSanguineo { APOSITIVO, ANEGATIVO, BPOSITIVO, BNEGATIVO, ABPOSITIVO, ABNEGATÍVO, OPOSITIVO, ONEGATIVO }



namespace Objetos
{
    /// <summary>
    /// Representa um paciente, derivado da classe Pessoa.
    /// </summary>
    [Serializable]
    public class Paciente : Pessoa
    {

        #region ESTADO
        private int numeroUtente;
        private string historicoMedico;
        private tipoSanguineo sangue;
        

        #endregion

        #region COMPORTAMENTO

        #region CONSTRUTORES
        /// <summary>
        /// Construtor padrão para a classe Paciente.
        /// Inicializa as propriedades e o array de paciente.
        /// </summary>
        public Paciente()
        {
            Nome = String.Empty;
            Idade = 0;//idade pode ser calculada
            sangue = tipoSanguineo.APOSITIVO;
            DataNascimento = DateTime.Now;
            Contato = 0;
            numeroUtente = 0;
            historicoMedico = String.Empty;
        }

        /// <summary>
        /// Inserir Informação de um novo paciente
        /// </summary>
        /// <param name="nome"></param>
        /// <param name="idade"></param>
        /// <param name="sangue"></param>
        /// <param name="dataNascimento"></param>
        /// <param name="contato"></param>
        /// <param name="numeroUtente"></param>
        /// <param name="historicoMedico"></param>
        public Paciente(string nome, int idade, tipoSanguineo sangue, DateTime dataNascimento, int contato, int numeroUtente, string historicoMedico)
        {
            //if(dataNascimento < DateTime.Now)
            //{
            //    throw new Exception();
            //}

            //regras com ifs


            /*
             * regra 0 - verificar se as variais sao do tipo certo e nao vazias
             * regra 1 - idade > 0 
             * regra 2 - contato 9 digitos
             * 
             * 
             * 
             * 
             * 
             */

            if (nome == null || idade == null || sangue == null || dataNascimento == null || contato == null || numeroUtente == null || historicoMedico == null)
            {
                throw new ArgumentNullException("Não podem existir dados vazios");
            }


            if (nome.Any(char.IsDigit))
            {
                throw new NomeInvaliadoException();
            }

            if(idade <= 0)
            {
                throw new IdadeInvalidaException();
            }


            this.Nome = nome;
            this.Idade = idade;
            this.sangue = sangue;
            this.DataNascimento = dataNascimento;
            this.Contato = contato;
            this.numeroUtente = numeroUtente;
            this.historicoMedico = historicoMedico;

        }

        #endregion


        /// <summary>
        /// Obtém ou define a especialidade do paciente.
        /// </summary>
        #region PROPRIEDADES
        public string HistoricoMedico
        {
            get { return historicoMedico; }
            set { historicoMedico = value; }
        }

        public tipoSanguineo TipoSanguineo
        {
            get { return sangue; }
            set { sangue = value; }
        }

        public int NumeroUtente
        {
            get { return numeroUtente; }
            set { numeroUtente = value; }
        }


        #endregion

        #region OPERADORES
        /// <summary>
        /// Sobrecarga do operador de igualdade para comparar dois objetos do tipo paciente.
        /// </summary>
        public static bool operator ==(Paciente paciente1, Paciente paciente2)
        {
            if (ReferenceEquals(paciente1, null) && ReferenceEquals(paciente2, null))
                return true;

            if(ReferenceEquals(paciente1,null) || ReferenceEquals(paciente2, null))
                return false;


            if ((paciente1.Nome == paciente2.Nome) && (paciente1.Idade == paciente2.Idade) && (paciente1.TipoSanguineo == paciente2.TipoSanguineo) && (paciente1.DataNascimento == paciente2.DataNascimento) && (paciente1.Contato == paciente2.Contato) && (paciente1.NumeroUtente == paciente2.NumeroUtente) && (paciente1.historicoMedico== paciente2.historicoMedico))
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        /// <summary>
        /// Sobrecarga do operador de desigualdade para comparar dois objetos do tipo paciente.
        /// </summary>
        public static bool operator !=(Paciente paciente1, Paciente paciente2)
        {
            if (paciente1 == paciente2)
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
        /// Retorna uma representação em string do objeto Paciente.
        /// </summary>
        public override string ToString()
        {
            return String.Format("Nome: {0} - Idade: {1} - Sangue: {2} - Data de Nascimento: {3} - Contato: {4} - Numero de utente: {5} - Historio Medico: {6}", Nome, Idade.ToString(), sangue.ToString(), DataNascimento.ToString(), Contato.ToString(),  numeroUtente.ToString(), historicoMedico);
        }


        /// <summary>
        /// Verifica se o objeto é igual a outro objeto Paciente.
        /// </summary>
        public override bool Equals(object obj)
        {

            if (obj is Paciente)
            {
                Paciente t = (Paciente)obj;
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
        ~Paciente() { }
        #endregion

        #endregion

    }
}
