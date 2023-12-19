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
    /// Representa a lista das consultas medicas.
    /// </summary>
    [Serializable]
    public static class Consultas
    {
        #region ESTADO
        private static List<Consulta> consultasLista;
        #endregion

        #region CONSTUTORES

        static Consultas()
        {
            if (consultasLista == null)
            {
                //numPacientes = 0;
                consultasLista = new List<Consulta>();
            }
        }
        #endregion

        #region PROPRIEDADES

        public static List<Consulta> ListaConsultas
        {
            get { return consultasLista; }
            //new list<paciente>(pacienteslista)
        }
        #endregion

        #region METODOS
        /// <summary>
        /// Adiciona uma consulta à lista de consultas.
        /// </summary>
        /// <param name="consulta"></param>
        public static void AdicionarLista(Consulta consulta)
        {
            consultasLista.Add(consulta);
        }

        /// <summary>
        /// Remove uma consulta da lista com base no nome do paciente,ID do médico e número do utente do paciente.
        /// </summary>
        /// <param name="nome"></param>
        /// <param name="idMedico"></param>
        /// <param name="numeroUtentePaciente"></param>
        public static void ApagarConsulta(string nome, int idMedico, int numeroUtentePaciente)//adicionar id aos servicos?
        {
            consultasLista.RemoveAll(consulta => consulta.Nome == nome && consulta.IdMedico == idMedico && consulta.NumeroUtentePaciente == numeroUtentePaciente);
        }

        /// <summary>
        /// Cria um clone da lista de consultas.
        /// </summary>
        /// <returns></returns>
        public static List<Consulta> ClonarConsultas()
        {
            return new List<Consulta>(consultasLista);
        }

        /// <summary>
        /// Guardar consulta num ficcheiro
        /// </summary>
        /// <param name="ficheiro"></param>
        /// <returns></returns>
        public static bool GuardarConsulta(string ficheiro)
        {
            if (!File.Exists(ficheiro))
            {
                try
                {
                    Stream stream = File.Open(ficheiro, FileMode.Create);
                    BinaryFormatter bin = new BinaryFormatter();
                    bin.Serialize(stream, consultasLista);
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
        /// Remover uma consulta da lista
        /// </summary>
        /// <param name="consulta"></param>
        /// <returns></returns>
        public static bool RemoverConsulta(Consulta consulta)
        {
            if (consultasLista.Exists(p => p.Equals(consulta)) == true)
            {
                consultasLista.Remove(consulta);
                return true;

            }

            return false;
        }

        /// <summary>
        /// Ver as consultas de um paciente
        /// </summary>
        /// <param name="numUtente"></param>
        /// <returns></returns>
        public static bool ConsultasPaciente(int numUtente)//Paciente paciente
        {
            List<Consulta> consultasPaciente = new List<Consulta>();

            foreach (Consulta consulta in consultasLista)
            {
                if (consulta.NumeroUtentePaciente == numUtente)
                {
                    consultasPaciente.Add(consulta);
                }
            }

            if (consultasPaciente.Count() == 0)
            {
                Console.WriteLine("O paciente {0} não tem nenhuma consulta.", numUtente);
                return false;
            }

            //IO.MostrarConsultas(consultasPaciente);


            return true;
        }

        /// <summary>
        /// Ver as consultas de um medico
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static bool ConsultasMedico(int id)
        {
            List<Consulta> consultasMedico = new List<Consulta>();

            foreach (Consulta consulta in consultasLista)
            {
                if (consulta.IdMedico == id)
                {
                    consultasMedico.Add(consulta);
                }
            }

            if (consultasMedico.Count() == 0)
            {
                Console.WriteLine("O medico {0} não tem nenhuma consulta.", id);
                return false;
            }

            //mandar para regras
            //IO.MostrarConsultas(consultasMedico);

            return true;
        }

        /// <summary>
        /// Comparar duas consultas
        /// </summary>
        /// <param name="consulta1"></param>
        /// <param name="consulta2"></param>
        /// <returns></returns>
        public static bool CompararConsultas(Consulta consulta1, Consulta consulta2)
        {
            if (consulta1 == consulta2)
            {
                return true;
            }

            return false;
        }

        /// <summary>
        /// Veficar se uma consulta existe na lista
        /// </summary>
        /// <param name="consulta"></param>
        /// <returns></returns>
        public static bool ConsultaExiste(Consulta consulta)
        {
            if(consultasLista.Exists(p => p.Equals(consulta)) == true)
            {             
                return true;
            }

            return false;
        }

        #endregion

    }
}
