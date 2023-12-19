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

using Excecoes;

namespace Objetos
{
    /// <summary>
    /// Classe que representa um membro da Staff com informações básicas como o id de Funcionario e Salario.
    /// Herda as caracteristicas da Classe Pessoa.
    /// </summary>
    [Serializable]
    public class Staff : Pessoa
    {

        /// <summary>
        /// Campos privados para armazenar o estado da staff
        /// </summary>
        #region ESTADO
        private int idFuncionario;
        private double salario;
        #endregion

        #region COMPORTAMENTO

        #region CONSTRUTORES

        /// <summary>
        /// Construtor padrão para a classe Staff.
        /// Inicializa o id de Funcionario e Salario com valores padrão. 
        /// </summary>
        public Staff()
        {
            idFuncionario = 0;
            salario = 0.0;

        }
        
        /*
        public Staff(int idFuncionario, double salario)
        {
            this.idFuncionario += 1;
            this.salario += salario;
        }
        */
        #endregion


        /// <summary>
        /// Obter ou definer as propriedades das vareaveis.
        /// </summary>
        #region PROPRIEDADES
        public int IdFuncionario
        {
            get { return idFuncionario; }
            set { idFuncionario = value; }
        }

        public double Salario
        {
            get { return salario; }
            set { salario = value; }
        }

        #endregion

        #region OPERADORES
        /*
        public static bool operator ==(Staff pessoa1, Staff pessoa2)
        {
            if ((pessoa1.Nome == pessoa2.Nome) && (pessoa1.Idade == pessoa2.Idade) && (pessoa1.Sangue == pessoa2.Sangue) && (pessoa1.DataNascimento == pessoa2.DataNascimento) && (pessoa1.NumeroUtente == pessoa2.NumeroUtente))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator !=(Staff pessoa1, Staff pessoa2)
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
        */
        #endregion

        #region OVERRIDES
        /*
        public override string ToString()
        {
            return String.Format("Nome: {0} - Idade: {1} - Tipo Sanguineio: {2} - Data de Nascimento: {2} - Numero de Utente: {4}", nome, idade.ToString(), sangue.ToString(), dataNascimento.ToString(), numeroUtente.ToString());
        }

        public override bool Equals(object obj)
        {
            if (obj is Staff)
            {
                Staff t = (Staff)obj;
                if (this == t)
                {
                    return true;
                }
            }

            return false;
        }
        */
        #endregion

        #region OUTROSMETODOS
        #endregion

        #region DESTRUCTOR
        ~Staff() { }
        #endregion

        #endregion

    }
}