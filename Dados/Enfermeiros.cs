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
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;
using Objetos;

namespace Dados

{   /// <summary>
    /// Representa a lista dos enfermeiros.
    /// </summary>
    [Serializable]
    public static class Enfermeiros
    {
        #region ESTADO
        private static List<Enfermeiro> enfermeirosLista = new List<Enfermeiro>();
        #endregion

        #region PROPRIEDADES

        public static List<Enfermeiro> ListaEnfermeiros
        {
            get { return enfermeirosLista; }
            //new list<paciente>(pacienteslista)
        }
        #endregion

        #region CONSTUTORES

        static Enfermeiros()
        {
            if (enfermeirosLista == null)
            {
                //numPacientes = 0;
                enfermeirosLista = new List<Enfermeiro>();
            }
        }
        #endregion

        #region METODOS
        /// <summary>
        /// Adiciona um enfermeiro à lista de enfermeiros.
        /// </summary>
        /// <param name="enfermeiro"></param>
        public static void AdicionarLista(Enfermeiro enfermeiro)
        {
            enfermeirosLista.Add(enfermeiro);
        }


        /// <summary>
        /// Exibe todos os enfermeiros na lista.
        /// </summary>
        public static void LerLista()
        {
            foreach (Enfermeiro enfermeiro in enfermeirosLista)
            {
                Console.WriteLine(enfermeiro.ToString());
            }
        }

        /// <summary>
        /// Exibe os detalhes de um enfermeiro específica com base no idEnfermeiro.
        /// </summary>
        /// <param name="idEnfermeiro"></param>
        public static void LerEnfermeiro(int idEnfermeiro)
        {
            foreach (Enfermeiro enfermeiro in enfermeirosLista)
            {
                if (enfermeiro.IdFuncionario == idEnfermeiro)
                {
                    Console.WriteLine(enfermeiro.ToString());
                }
            }
        }

        /// <summary>
        /// Remove um enfermeiro da lista com base no idEnfermeiro.
        /// </summary>
        /// <param name="idEnfermeiro"></param>
        public static void ApagarEnfermeiro(int idEnfermeiro)
        {
            enfermeirosLista.RemoveAll(enfermeiro => enfermeiro.IdFuncionario == idEnfermeiro);
        }


        /// <summary>
        /// Cria um clone da lista de enfermeiros.
        /// </summary>
        /// <returns></returns>
        public static List<Enfermeiro> ClonarEnfermeiros()
        {
            return new List<Enfermeiro>(enfermeirosLista);
        }

        /// <summary>
        /// guardar a lista num ficheiro
        /// </summary>
        /// <param name="ficheiro"></param>
        /// <returns></returns>
        public static bool GuardarEnfermeiro(string ficheiro)
        {
            if (!File.Exists(ficheiro))
            {
                try
                {
                    Stream stream = File.Open(ficheiro, FileMode.Create);
                    BinaryFormatter bin = new BinaryFormatter();
                    bin.Serialize(stream, enfermeirosLista);
                    stream.Close();
                    return true;
                }
                catch (IOException e)
                {
                    throw e;
                }

            }

            return false;
        }

        /// <summary>
        /// remover um enfermeiro da lista
        /// </summary>
        /// <param name="enfermeiro"></param>
        /// <returns></returns>
        public static bool RemoverEnfermeiro(Enfermeiro enfermeiro)
        {
            if (enfermeirosLista.Exists(p => p.Equals(enfermeiro)) == true)
            {
                enfermeirosLista.Remove(enfermeiro);
                return true;

            }

            return false;
        }

        /// <summary>
        /// Ver enfermeiros com uma certa qualificacao
        /// </summary>
        /// <param name="qualificacao"></param>
        /// <returns></returns>
        public static bool QualificacaoEnfermeiro(string qualificacao)
        {
            List<Enfermeiro> qualEnfermeiros = new List<Enfermeiro>();

            foreach (Enfermeiro enfermeiro in enfermeirosLista)
            {
                if (enfermeiro.Qualificacao == qualificacao)
                {
                    qualEnfermeiros.Add(enfermeiro);
                }
            }

            //isto é aqui?
            if (qualEnfermeiros.Count() == 0)
            {
                Console.WriteLine("Não existem enfermeiros com a qualificação {0}.\n", qualificacao);
                return false;
            }

            //IO.MostrarEnfermeiros(qualEnfermeiros);

            return true;
        }

        /// <summary>
        /// Comparar dois enfermeiros
        /// </summary>
        /// <param name="enfermeiro1"></param>
        /// <param name="enfermeiro2"></param>
        /// <returns></returns>
        public static bool CompararEnfermeiros(Enfermeiro enfermeiro1, Enfermeiro enfermeiro2)
        {
            if (enfermeiro1 == enfermeiro2)
            {
                return true;
            }

            return false;
        }

        /// <summary>
        /// Veficar se um enfermeiro existe na lista
        /// </summary>
        /// <param name="enfermeiro"></param>
        /// <returns></returns>
        public static bool EnfermeiroExiste(Enfermeiro enfermeiro)
        {
            if (enfermeirosLista.Exists(p => p.Equals(enfermeiro)) == true)
            {
                return true;
            }

            return false;
        }

        #endregion
    }
}
