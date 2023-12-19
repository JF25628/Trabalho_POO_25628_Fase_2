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


using Objetos;
using System.Runtime.Serialization.Formatters.Binary;

namespace Dados
{
    /// <summary>
    /// Representa a lista dos medicos.
    /// </summary>
    [Serializable]
    public static class Medicos
    {
        #region ESTADO
        private static List<Medico> medicosLista = new List<Medico>();
        #endregion

        #region PROPRIEDADES

        public static List<Medico> ListaMedicos
        {
            get { return medicosLista; }
            //new list<paciente>(pacienteslista)
        }
        #endregion

        #region CONSTUTORES

        static Medicos()
        {
            if (medicosLista == null)
            {
                //numPacientes = 0;
                medicosLista = new List<Medico>();
            }
        }
        #endregion

        #region METODOS
        /// <summary>
        /// Adiciona um medico à lista de medicos.
        /// </summary>
        /// <param name="medico"></param>
        public static void AdicionarLista(Medico medico)
        {
            medicosLista.Add(medico);
        }

        /// <summary>
        /// Exibe todas os medicos na lista.
        /// </summary>
        public static void LerLista()
        {
            foreach (Medico medico in medicosLista)
            {
                Console.WriteLine(medico.ToString());
            }
        }

        /// <summary>
        /// Exibe os detalhes de um medico específico com base no idMedico.
        /// </summary>
        /// <param name="idMedico"></param>
        public static void LerMedico(int idMedico)
        {
            foreach (Medico medico in medicosLista)
            {
                if (medico.IdFuncionario == idMedico)
                {
                    Console.WriteLine(medico.ToString());
                }
            }
        }

        /// <summary>
        /// Remove um medico da lista com base no idMedico.
        /// </summary>
        /// <param name="idMedico"></param>
        public static void ApagarMedico(int idMedico)
        {
            medicosLista.RemoveAll(medico => medico.IdFuncionario == idMedico);
        }

        /// <summary>
        /// Cria um clone da lista de medicos.
        /// </summary>
        /// <returns></returns>
        public static List<Medico> ClonarMedicos()
        {
            return new List<Medico>(medicosLista);
        }

        /// <summary>
        /// Guardar lista num ficheiro
        /// </summary>
        /// <param name="ficheiro"></param>
        /// <returns></returns>
        public static bool GuardarMedico(string ficheiro)
        {
            if (!File.Exists(ficheiro))
            {
                try
                {
                    Stream stream = File.Open(ficheiro, FileMode.Create);
                    BinaryFormatter bin = new BinaryFormatter();
                    bin.Serialize(stream, medicosLista);
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
        /// Remover um medico da lista
        /// </summary>
        /// <param name="medico"></param>
        /// <returns></returns>
        public static bool RemoverMedico(Medico medico)
        {
            if (medicosLista.Exists(p => p.Equals(medico)) == true)
            {
                medicosLista.Remove(medico);
                return true;

            }

            return false;
        }

        /// <summary>
        /// Ver medicos com uma especialidade
        /// </summary>
        /// <param name="especialidade"></param>
        /// <returns></returns>
        public static bool EspecialidadeMedico(string especialidade)
        {
            List<Medico> espMedicos = new List<Medico>();

            foreach (Medico medico in medicosLista)
            {
                if (medico.Especialidade == especialidade)
                {
                    espMedicos.Add(medico);
                }
            }

            //isto é aqui?
            if (espMedicos.Count() == 0)
            {
                Console.WriteLine("Não existem medicos com a especialidade {0}.\n", especialidade);
                return false;
            }

            //IO.MostrarMedicos(espMedicos);

            return true;
        }

        /// <summary>
        /// Comparar dois medicos
        /// </summary>
        /// <param name="medico1"></param>
        /// <param name="medico2"></param>
        /// <returns></returns>
        public static bool CompararMedicos(Medico medico1, Medico medico2)
        {
            if (medico1 == medico2)
            {
                return true;
            }

            return false;
        }

        /// <summary>
        /// Veficar se um medico existe na lista
        /// </summary>
        /// <param name="medico"></param>
        /// <returns></returns>
        public static bool MedicoExiste(Medico medico)
        {
            if (medicosLista.Exists(p => p.Equals(medico)) == true)
            {
                return true;
            }

            return false;
        }

        #endregion

    }
}
