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
    /// Representa a lista dos pacientes.
    /// </summary>
    [Serializable]
    public static class Pacientes
    {
        #region ESTADO
        private static List<Paciente> pacientesLista = new List<Paciente>();
        #endregion

        #region METODOS

        #region CONSTUTORES
        //criar ficheiro
        static Pacientes()
        {
            if (pacientesLista == null)
            {
                pacientesLista = new List<Paciente>();
            }
        }
        #endregion

        #region PROPRIEDADES
        public static List<Paciente> ListaPacientes
        {
            get { return pacientesLista; }
            //new list<paciente>(pacienteslista)
        }

        #endregion

        /// <summary>
        /// Adiciona uma pacientes à lista de pacientes.
        /// </summary>
        /// <param name="paciente></param>
        public static bool AdicionarLista(Paciente paciente)
        {
            //verificar se esta vazia e se ja existe

            pacientesLista.Add(paciente);

            return true;
        }

        /// <summary>
        /// Exibe os detalhes de um paciente específica com base no numeroUtente.
        /// </summary>
        /// <param name="numeroUtente"></param>
        public static void LerPaciente(int numeroUtente)
        {
            foreach (Paciente paciente in pacientesLista)
            {
                if (paciente.NumeroUtente == numeroUtente)
                {
                    Console.WriteLine(paciente.ToString());
                }
            }
        }

        /// <summary>
        /// Remove um paciente da lista com base no numeroUtente.
        /// </summary>
        /// <param name="numeroUtente"></param>
        public static void ApagarPaciente(int numeroUtente)
        {
            pacientesLista.RemoveAll(paciente => paciente.NumeroUtente == numeroUtente);
        }

        /// <summary>
        /// Cria um clone da lista de pacientes.
        /// </summary>
        /// <returns></returns>
        public static List<Paciente> ClonarPacientes()
        {
            return new List<Paciente>(pacientesLista);
        }

        /// <summary>
        /// Guardar lista num ficheiro
        /// </summary>
        /// <param name="ficheiro"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public static bool GuardarPaciente(string ficheiro)
        {
            if (File.Exists(ficheiro))
            {
                try
                {
                    Stream stream = File.Open(ficheiro, FileMode.Append);
                    BinaryFormatter bin = new BinaryFormatter();
                    bin.Serialize(stream, pacientesLista);
                    stream.Close();
                    return true;
                }
                catch (IOException e) 
                {
                    throw e;
                }
            }
            else
            {
                Console.WriteLine("Ficheiro pacientes nao existe");
                //throw new Exception();
                return false;
            }
        }

        public static bool gp2(string filename)
        {
            try
            {
                if (!File.Exists(filename))
                {
                    using (File.Create(filename)) { }
                }

                using (Stream s = File.Open(filename, FileMode.Create, FileAccess.ReadWrite))
                {
                    BinaryFormatter bin = new BinaryFormatter();
                    bin.Serialize(s, pacientesLista);
                }

                return true;
            }
            catch(Exception e)
            {
                //throw
                return false;
            }
        }

        public static bool lp2()
        {
            return false;
        }



        /// <summary>
        /// Ler o ficheiro dos pacientes
        /// </summary>
        /// <param name="nomeFicheiro"></param>
        /// <returns></returns>
        public static bool LerPacientes(string nomeFicheiro)
        {
            if (File.Exists(nomeFicheiro))
            {
                try
                {
                    Stream stream = File.Open(nomeFicheiro, FileMode.Open);
                    BinaryFormatter bin = new BinaryFormatter();
                    pacientesLista = (List<Paciente>)bin.Deserialize(stream);
                    stream.Close();
                    return true;
                }
                catch (IOException e)
                {
                    throw e;
                }
                catch (Exception e)
                {

                }
            }
            else
            {
                //criar ficheiro
            }

            //exception erro
            return false;
        }
        
       /// <summary>
       /// Remove o paciente da lista
       /// </summary>
       /// <param name="paciente"></param>
       /// <returns></returns>
        public static bool RemoverPaciente(Paciente paciente)
        {
            //mudar isto para o meu metodo
            //verificar se é melhor contains ou exists
            if (pacientesLista.Exists(p => p.Equals(paciente)) == true)
            {
                pacientesLista.Remove(paciente);
                return true;

            }

            return false;
        }

        /// <summary>
        /// Atualizar um Paciente
        /// </summary>
        /// <param name="paciente"></param>
        /// <param name="nome"></param>
        /// <param name="idade"></param>
        /// <param name="sangue"></param>
        /// <param name="dataNascimento"></param>
        /// <param name="contato"></param>
        /// <param name="numeroUtente"></param>
        /// <param name="historioMedico"></param>
        /// <returns></returns>
        public static bool AtualizarPaciente(Paciente paciente, string nome, int idade, tipoSanguineo sangue, DateTime dataNascimento, int contato, int numeroUtente, string historioMedico) 
        {
            if(PacienteExiste(paciente) == false)
            {
                //console.writeline paciente nao existe na lista
                return false;
            }

            paciente.Nome = nome;
            paciente.Idade = idade;
            paciente.TipoSanguineo = sangue;
            paciente.DataNascimento = dataNascimento;
            paciente.Contato = contato;
            paciente.NumeroUtente = numeroUtente;
            paciente.HistoricoMedico = historioMedico;

            return true;
        }

        /// <summary>
        /// Obter todos pacientes com um tipo de sangue.
        /// </summary>
        /// <param name="tipoSanguineo"></param>
        /// <returns></returns>
        public static bool SanguePaciente(tipoSanguineo tipoSanguineo)
        {
            List<Paciente> sanguePaciente = new List<Paciente>();

            foreach (Paciente paciente in pacientesLista)
            {
                if (paciente.TipoSanguineo == tipoSanguineo)
                {
                    sanguePaciente.Add(paciente);
                }
            }

            //isto é aqui?
            if (sanguePaciente.Count() == 0)
            {
                //Console.WriteLine("Não existem pacientes com o tipo sangueano {0}.\n", tipoSanguineo.ToString());
                return false;
            }

            //mudar isto para regras
            //IO.MostrarPacientes(sanguePaciente);

            return true;
        }

        /// <summary>
        /// Comparar dois pacientes
        /// </summary>
        /// <param name="paciente1"></param>
        /// <param name="paciente2"></param>
        /// <returns></returns>
        public static bool CompararPacientes(Paciente paciente1, Paciente paciente2)
        {
            if (paciente1 == paciente2)
            {
                return true;
            }

            return false;
        }

        /// <summary>
        /// Veficar se um paciente existe na lista
        /// </summary>
        /// <param name="paciente"></param>
        /// <returns></returns>
        public static bool PacienteExiste(Paciente paciente)
        {
            if (pacientesLista.Exists(p => p.Equals(paciente)) == true)
            {
                return true;
            }

            return false;
        }

        #endregion
    }
}
