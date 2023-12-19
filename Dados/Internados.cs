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
    /// Representa a lista dos internados.
    /// </summary>
    [Serializable]
    public static class Internados
    {
        #region ESTADO
        private static List<Internado> internadosLista = new List<Internado>();
        #endregion

        #region PROPRIEDADES

        public static List<Internado> ListaInternados
        {
            get { return internadosLista; }
            //new list<paciente>(pacienteslista)
        }
        #endregion

        #region CONSTUTORES

        static Internados()
        {
            if (internadosLista == null)
            {
                //numPacientes = 0;
                internadosLista = new List<Internado>();
            }
        }
        #endregion

        #region METODOS
        /// <summary>
        /// Adiciona um internado à lista de internados.
        /// </summary>
        /// <param name="internado"></param>
        public static void AdicionarLista(Internado internado)
        {
            internadosLista.Add(internado);
        }

        /// <summary>
        /// Exibe todos os internddos na lista.
        /// </summary>
        public static void LerLista()
        {
            foreach (Internado internado in internadosLista)
            {
                Console.WriteLine(internado.ToString());
            }
        }

        /// <summary>
        /// Exibe os detalhes de um Internado específica com base no numeroUtente.
        /// </summary>
        /// <param name="numeroUtente"></param>
        public static void LerInternado(int numeroUtente)
        {
            foreach (Internado internado in internadosLista)
            {
                if (internado.NumeroUtente == numeroUtente)
                {
                    Console.WriteLine(internado.ToString());
                }
            }
        }

        /// <summary>
        /// Remove um internado da lista com base no numeroUtente.
        /// </summary>
        /// <param name="numeroUtente"></param>
        public static void ApagarInternado(int numeroUtente)
        {
            internadosLista.RemoveAll(internado => internado.NumeroUtente == numeroUtente);
        }

        /// <summary>
        /// Cria um clone da lista de internados.
        /// </summary>
        /// <returns></returns>
        public static List<Internado> ClonarInternados()
        {
            return new List<Internado>(internadosLista);
        }


        /// <summary>
        /// Guardar a lista num ficheiro
        /// </summary>
        /// <param name="ficheiro"></param>
        /// <returns></returns>
        public static bool GuardarInternado(string ficheiro)
        {
            if (!File.Exists(ficheiro))
            {
                try
                {
                    Stream stream = File.Open(ficheiro, FileMode.Create);
                    BinaryFormatter bin = new BinaryFormatter();
                    bin.Serialize(stream, internadosLista);
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
        /// remover um internado da lista
        /// </summary>
        /// <param name="internado"></param>
        /// <returns></returns>
        public static bool RemoverInternado(Internado internado)
        {
            if (internadosLista.Exists(p => p.Equals(internado)) == true)
            {
                internadosLista.Remove(internado);
                return true;

            }

            return false;
        }

        /// <summary>
        /// Ver internados num quarto
        /// </summary>
        /// <param name="quarto"></param>
        /// <returns></returns>
        public static bool InternadosQuarto(int quarto)
        {
            List<Internado> internadosQuarto = new List<Internado>();

            foreach (Internado internado in internadosLista)
            {
                if (internado.NumeroQuarto == quarto)
                {
                    internadosQuarto.Add(internado);
                }
            }

            if (internadosQuarto.Count() == 0)
            {
                Console.WriteLine("Não existe internados no quarto {0}.", quarto);
                return false;
            }

            //IO.MostrarInternados(internadosQuarto);

            return true;
        }

        /// <summary>
        /// Comparar dois internados
        /// </summary>
        /// <param name="internado1"></param>
        /// <param name="internado2"></param>
        /// <returns></returns>
        public static bool CompararInternados(Internado internado1, Internado internado2)
        {
            if (internado1 == internado2)
            {
                return true;
            }

            return false;
        }

        /// <summary>
        /// Veficar se um internado existe na lista
        /// </summary>
        /// <param name="internado"></param>
        /// <returns></returns>
        public static bool InternadoExiste(Internado internado)
        {
            if (internadosLista.Exists(p => p.Equals(internado)) == true)
            {
                return true;
            }

            return false;
        }

        #endregion

    }
}
