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
{
    /// <summary>
    /// Representa a lista dos exames.
    /// </summary>
    [Serializable]
    public static class Exames
    {
        #region ESTADO
        private static List<Exame> examesLista = new List<Exame>();
        #endregion

        #region PROPRIEDADES

        public static List<Exame> ListaExames
        {
            get { return examesLista; }
            //new list<paciente>(pacienteslista)
        }
        #endregion

        #region CONSTUTORES

        static Exames()
        {
            if (examesLista == null)
            {
                //numPacientes = 0;
                examesLista = new List<Exame>();
            }
        }
        #endregion

        #region METODOS
        /// <summary>
        /// Adiciona um exame à lista de exames.
        /// /// </summary>
        /// <param name="exame"></param>
        public static void AdicionarLista(Exame exame)
        {
            examesLista.Add(exame);
        }

        /// <summary>
        /// Exibe todos os exames na lista.
        /// </summary>
        public static void LerLista()
        {
            foreach (Exame exame in examesLista)
            {
                Console.WriteLine(exame.ToString());
            }
        }

        /// <summary>
        /// Exibe os detalhes de um exame específica com base no nome, enfermeiroResponsavel e pacienteExaminado.
        /// </summary>
        /// <param name="nome"></param>
        /// <param name="enfermeiroResponsavel"></param>
        /// <param name="pacienteExaminado"></param>
        public static void LerExame(string nome, int enfermeiroResponsavel, int pacienteExaminado)
        {
            foreach (Exame exame in examesLista)
            {
                if (exame.Nome == nome && exame.EnfermeiroResponsavel == enfermeiroResponsavel && exame.PacienteExaminado == pacienteExaminado)
                {
                    Console.WriteLine(exame.ToString());
                }
            }
        }

        /// <summary>
        /// Remove um exame da lista com base no nome, enfermeiroResponsavel e pacienteExaminado.
        /// </summary>
        /// <param name="nome"></param>
        /// <param name="enfermeiroResponsavel"></param>
        /// <param name="pacienteExaminado"></param>
        public static void ApagarExame(string nome, int enfermeiroResponsavel, int pacienteExaminado)//adicionar id aos servicos?
        {
            examesLista.RemoveAll(exame => exame.Nome == nome && exame.EnfermeiroResponsavel == enfermeiroResponsavel && exame.PacienteExaminado == pacienteExaminado);
        }

        /// <summary>
        /// Cria um clone da lista de exames.
        /// </summary>
        /// <returns></returns>
        public static List<Exame> ClonarExames()
        {
            return new List<Exame>(examesLista);
        }

        /// <summary>
        /// Guardar lista num ficheiro
        /// </summary>
        /// <param name="ficheiro"></param>
        /// <returns></returns>
        public static bool GuardarExame(string ficheiro)
        {
            if (!File.Exists(ficheiro))
            {
                try
                {
                    Stream stream = File.Open(ficheiro, FileMode.Create);
                    BinaryFormatter bin = new BinaryFormatter();
                    bin.Serialize(stream, examesLista);
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
        /// remover um exame da lista
        /// </summary>
        /// <param name="exame"></param>
        /// <returns></returns>
        public static bool RemoverExame(Exame exame)
        {
            if (examesLista.Exists(p => p.Equals(exame)) == true)
            {
                examesLista.Remove(exame);
                return true;

            }

            return false;
        }

        /// <summary>
        /// Ver exames onde este enfermeiro foi o responsavel
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static bool ExamesEnfermeiro(int id)
        {
            List<Exame> examesEnfermeiro = new List<Exame>();

            foreach (Exame exame in examesLista)
            {
                if (exame.EnfermeiroResponsavel == id)
                {
                    examesEnfermeiro.Add(exame);
                }
            }

            if (examesEnfermeiro.Count() == 0)
            {
                Console.WriteLine("O enfermeiro {0} não tem nenhum exame.", id);
                return false;
            }

            //IO.MostrarExames(examesEnfermeiro);

            return true;
        }

        /// <summary>
        /// Comparar dois exames
        /// </summary>
        /// <param name="exame1"></param>
        /// <param name="exame2"></param>
        /// <returns></returns>
        public static bool CompararExames(Exame exame1, Exame exame2)
        {
            if (exame1 == exame2)
            {
                return true;
            }

            return false;
        }

        /// <summary>
        /// Veficar se um exame existe na lista
        /// </summary>
        /// <param name="consulta"></param>
        /// <returns></returns>
        public static bool ExameExiste(Exame exame)
        {
            if (examesLista.Exists(p => p.Equals(exame)) == true)
            {
                return true;
            }

            return false;
        }

        #endregion
    }
}
