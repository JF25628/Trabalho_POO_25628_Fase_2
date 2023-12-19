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
    public class Servico
    {

        /// <summary>
        /// Campos privados para armazenar o estado da pessoa
        /// </summary>
        #region ESTADO
        private string nome;
        private DateTime data;
        private string diagnostico;
        private double custo;
        #endregion

        #region COMPORTAMENTO

        #region CONSTRUTORES

        /// <summary>
        /// Construtor padrão para a classe Pessoa.
        /// Inicializa nome, idade e contato com valores padrão. 
        /// </summary>
        public Servico()
        {
            nome = String.Empty;
            data = DateTime.Now;
            diagnostico = String.Empty;
            custo = 0.0;
        }
        
        public Servico(string nome, DateTime data, string diagnostico, int custo)
        {
            this.nome = nome;
            this.data = data;
            this.diagnostico = diagnostico;
            this.custo = custo;
        }
        

        #endregion


        /// <summary>
        /// Obter ou definer as propriedades dos servicos.
        /// </summary>
        #region PROPRIEDADES
        
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public DateTime Data
        {
            get { return Data; }
            set { Data = value; }
        }

        public string Diagnostico
        {
            get { return diagnostico; }
            set { diagnostico = value; }
        }

        public double Custo
        {
            get { return custo; }
            set { custo = value; }
        }


        #endregion

        #region OPERADORES

        #endregion

        #region OVERRIDES

        #endregion

        #region OUTROSMETODOS
        #endregion

        #region DESTRUCTOR
        ~Servico() { }
        #endregion

        #endregion

    }
}
