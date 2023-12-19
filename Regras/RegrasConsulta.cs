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
    public class RegrasConsulta
    {
        /// <summary>
        /// Metodo InserirConsultas. Utilizado para inserir uma consulta na lista.
        /// </summary>
        /// <param name="consulta"></param>
        /// <returns></returns>
        public static bool InserirConsultas(Consulta consulta)
        {
            Consultas.AdicionarLista(consulta);
            return true;
        }

        /// <summary>
        /// Metodo LerListaConsultas. Utilizado para obter o output da lista das consultas.
        /// </summary>
        public static void LerListaConsultas()
        {
            IO.MostrarConsultas(Consultas.ListaConsultas);
        }

        /// <summary>
        /// Metodo GuardarListaConsultas. Utilizado para guardar a lista das consultas num ficheiro.
        /// </summary>
        /// <param name="ficheiro"></param>
        /// <returns></returns>
        public static bool GuardarListaConsultas(string ficheiro)
        {
            Consultas.GuardarConsulta(ficheiro);
            return true;
        }

        /// <summary>
        /// Metodo RemoverListaConsultas. Utilizado para remover uma consulta da lista.
        /// </summary>
        /// <param name="consulta"></param>
        /// <returns></returns>
        public static bool RemoverListaConsultas(Consulta consulta)
        {
            Consultas.RemoverConsulta(consulta);
            return true;
        }

        /// <summary>
        /// Metodo ConsultarConsultasPaciente. Utilizado para verificar as consultas de um paciente.
        /// </summary>
        /// <param name="numUtente"></param>
        /// <returns></returns>
        public static bool ConsultarConsultasPaciente(int numUtente)
        {
            Consultas.ConsultasPaciente(numUtente);
            return true;
        }

        /// <summary>
        /// Metodo ConsultarConsultasMedico. Utilizado para verificar as consultas de um medico.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static bool ConsultarConsultasMedico(int id)
        {
            Consultas.ConsultasMedico(id);
            return true;
        }
    }
}
