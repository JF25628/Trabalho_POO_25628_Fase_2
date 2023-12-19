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
    public class RegrasMedico
    {
        /// <summary>
        /// Metodo InserirMedicos. Utilizado para inserir medicos na lista.
        /// </summary>
        /// <param name="medico"></param>
        /// <returns></returns>
        public static bool InserirMedicos(Medico medico)
        {
            Medicos.AdicionarLista(medico);
            return true;
        }

        /// <summary>
        /// Metodo LerListaMedico. Utilizado para obter o output da lista dos medicos.
        /// </summary>
        public static void LerListaMedico()
        {
            IO.MostrarMedicos(Medicos.ListaMedicos);
        }

        /// <summary>
        /// Metodo GuardarListaMedicos. Utilizado para guardar a lista dos medicos num ficheiro.
        /// </summary>
        /// <param name="ficheiro"></param>
        /// <returns></returns>
        public static bool GuardarListaMedicos(string ficheiro)
        {
            Medicos.GuardarMedico(ficheiro);
            return true;
        }

        /// <summary>
        /// Metodo RemoverListaMedicos. Utilizado para remover um medico da lista.
        /// </summary>
        /// <param name="medico"></param>
        /// <returns></returns>
        public static bool RemoverListaMedicos(Medico medico)
        {
            Medicos.RemoverMedico(medico);
            return true;
        }

        /// <summary>
        /// Metodo MedicosComEspecialidade. Utilizado para obter os medicos com uma especialidade especifica.
        /// </summary>
        /// <param name="especialidade"></param>
        /// <returns></returns>
        public static bool MedicosComEspecialidade(string especialidade)
        {
            Medicos.EspecialidadeMedico(especialidade);
            return true;
        }
    }
}
