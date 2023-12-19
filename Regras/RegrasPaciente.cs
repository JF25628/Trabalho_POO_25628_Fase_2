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

using Dados;
using Objetos;
using InputOutput;

namespace Regras
{
    public class RegrasPaciente
    {
        /// <summary>
        /// Metodo InserirPaciente. Utilizado para aceder ao metodo AdicionarLista que insere um paciente na lista.
        /// </summary>
        /// <param name="paciente"></param>
        /// <returns></returns>
        public static bool InserirPaciente(Paciente paciente)
        {
            Pacientes.AdicionarLista(paciente);
            return true;
        }

        /// <summary>
        /// Metodo LerListaPaciente. Utilziado para obter o output de dados da lista.
        /// </summary>
        public static void LerListaPaciente()
        {
            IO.MostrarPacientes(Pacientes.ListaPacientes);
        }

        /// <summary>
        /// Metodo GuardarListaPacientes. Utilizado para guardar os dados na lista num ficheiro.
        /// </summary>
        /// <param name="ficheiro"></param>
        /// <returns></returns>
        public static bool GuardarListaPacientes(string ficheiro)
        {
            Pacientes.GuardarPaciente(ficheiro);
            return true;
        }

        /// <summary>
        /// Metodo RemoverListaPacientes. Utilizada para remover um paciente da lista.
        /// </summary>
        /// <param name="paciente"></param>
        /// <returns></returns>
        public static bool RemoverListaPacientes(Paciente paciente)
        {
            Pacientes.RemoverPaciente(paciente);
            return true;
        }

        /// <summary>
        /// Metodo AtualizarDadosPaciente. Utilizado para atualizar os dados de um paciente.
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
        public static bool AtualizarDadosPaciente(Paciente paciente, string nome, int idade, tipoSanguineo sangue, DateTime dataNascimento, int contato, int numeroUtente, string historioMedico)
        {
            Pacientes.AtualizarPaciente(paciente, nome, idade, sangue, dataNascimento, contato, numeroUtente, historioMedico);
            return true;
        }

        /// <summary>
        /// Metodo ConsultarSanguePacientes. Utilizado para verificar todos os pacientes com todos o mesmo tipo sanguineo.
        /// </summary>
        /// <param name="tipoSanguineo"></param>
        /// <returns></returns>
        public static bool ConsultarSanguePacientes(tipoSanguineo tipoSanguineo)
        {
            Pacientes.SanguePaciente(tipoSanguineo);
            return true;
        }
    }
}
