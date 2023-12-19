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

namespace InputOutput
{
    public class IO
    {
        /// <summary>
        /// Imprimir Pacientes
        /// </summary>
        /// <param name="pacientesLista"></param>
        public static void MostrarPacientes(List<Paciente> pacientesLista)
        {
            foreach (Paciente paciente in pacientesLista)
            {
                Console.WriteLine(paciente.ToString());
            }
        }

        /// <summary>
        /// Imprimir Consultas
        /// </summary>
        /// <param name="consultasLista"></param>
        public static void MostrarConsultas(List<Consulta> consultasLista)
        {
            foreach (Consulta consulta in consultasLista)
            {
                Console.WriteLine(consulta.ToString());   
            }
        }

        /// <summary>
        /// Imprimir Enfermeiros
        /// </summary>
        /// <param name="enfermeirosLista"></param>
        public static void MostrarEnfermeiros(List<Enfermeiro> enfermeirosLista)
        {
            foreach (Enfermeiro enfermeiro in enfermeirosLista)
            {
                Console.WriteLine(enfermeiro.ToString());
            }
        }

        /// <summary>
        /// Imprimir Exames
        /// </summary>
        /// <param name="examesLista"></param>
        public static void MostrarExames(List<Exame> examesLista)
        {
            foreach (Exame exame in examesLista)
            {
                Console.WriteLine(exame.ToString());
            }
        }

        /// <summary>
        /// Imprimir Internados
        /// </summary>
        /// <param name="internadosLista"></param>
        public static void MostrarInternados(List<Internado> internadosLista)
        {
            foreach (Internado internado in internadosLista)
            {
                Console.WriteLine(internado.ToString());
            }
        }

        /// <summary>
        /// Imprimir Medicos
        /// </summary>
        /// <param name="medicosLista"></param>
        public static void MostrarMedicos(List<Medico> medicosLista)
        {
            foreach (Medico medico in medicosLista)
            {
                Console.WriteLine(medico.ToString());
            }
        }

        /// <summary>
        /// Imprimir Quartos
        /// </summary>
        /// <param name="quartosLista"></param>
        public static void MostrarQuartos(List<Quarto> quartosLista)
        {
            foreach (Quarto quarto in quartosLista)
            {
                Console.WriteLine(quarto.ToString());
            }
        }
    }
}
