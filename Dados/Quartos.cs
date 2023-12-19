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
    /// Representa a lista dos quartos.
    /// </summary>
    [Serializable]
    public static class Quartos
    {
        #region ESTADO
        private static List<Quarto> quartosLista = new List<Quarto>();
        #endregion

        #region PROPRIEDADES

        public static List<Quarto> ListaQuartos
        {
            get { return quartosLista; }
            //new list<paciente>(pacienteslista)
        }
        #endregion

        #region CONSTUTORES

        static Quartos()
        {
            if (quartosLista == null)
            {
                //numPacientes = 0;
                quartosLista = new List<Quarto>();
            }
        }
        #endregion

        #region METODOS
        /// <summary>
        /// Adiciona um quarto à lista de quartos.
        /// </summary>
        /// <param name="quarto"></param>
        public static void AdicionarLista(Quarto quarto)
        {
            quartosLista.Add(quarto);
        }

        /// <summary>
        /// Exibe todos is quartos na lista.
        /// </summary>
        public static void LerLista()
        {
            foreach (Quarto quarto in quartosLista)
            {
                Console.WriteLine(quarto.ToString());
            }
        }

        /// <summary>
        /// Exibe os detalhes de um quarto específica com base no numero do quarto.
        /// </summary>
        /// <param name="numeroQuarto"></param>
        public  static void LerQuarto(int numeroQuarto)
        {
            foreach (Quarto quarto in quartosLista)
            {
                if (quarto.NumeroQuarto == numeroQuarto)
                {
                    Console.WriteLine(quarto.ToString());
                }
            }
        }

        /// <summary>
        /// Remove uma consulta da lista com base no numero do quarto.
        /// </summary>
        /// <param name="numeroQuarto"></param>
        public static void ApagarQuarto(int numeroQuarto)
        {
            quartosLista.RemoveAll(quarto => quarto.NumeroQuarto == numeroQuarto);
        }

        /// <summary>
        /// Cria um clone da lista de quartos.
        /// </summary>
        /// <returns></returns>
        public static List<Quarto> ClonarQuartos()
        {
            return new List<Quarto>(quartosLista);
        }

        /// <summary>
        /// Metodo que guarda a lista num ficheiro
        /// </summary>
        /// <param name="ficheiro"></param>
        /// <returns></returns>
        public static bool GuardarQuarto(string ficheiro)
        {
            if (!File.Exists(ficheiro))
            {
                try
                {
                    Stream stream = File.Open(ficheiro, FileMode.Create);
                    BinaryFormatter bin = new BinaryFormatter();
                    bin.Serialize(stream, quartosLista);
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
        /// Remove um quarto da lista
        /// </summary>
        /// <param name="quarto"></param>
        /// <returns></returns>
        public static bool RemoverQuarto(Quarto quarto)
        {
            if (quartosLista.Exists(p => p.Equals(quarto)) == true)
            {
                quartosLista.Remove(quarto);
                return true;

            }

            return false;
        }

        /// <summary>
        /// Comparar dois quartos
        /// </summary>
        /// <param name="quarto1"></param>
        /// <param name="quarto2"></param>
        /// <returns></returns>
        public static bool CompararQuartos(Quarto quarto1, Quarto quarto2)
        {
            if (quarto1 == quarto2)
            {
                return true;
            }

            return false;
        }

        /// <summary>
        /// Veficar se um quarto existe na lista
        /// </summary>
        /// <param name="quarto"></param>
        /// <returns></returns>
        public static bool QuartoExiste(Quarto quarto)
        {
            if (quartosLista.Exists(p => p.Equals(quarto)) == true)
            {
                return true;
            }

            return false;
        }

        #endregion

    }
}
