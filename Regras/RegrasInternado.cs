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
    public class RegrasInternado
    {
        /// <summary>
        /// Metodo InserirInternados. Utilizado para inserir um internado na lista.
        /// </summary>
        /// <param name="internado"></param>
        /// <returns></returns>
        public static bool InserirInternados(Internado internado)
        {
            Internados.AdicionarLista(internado);
            return true;
        }

        /// <summary>
        /// Metodo LerListaInternado. Utilizado para obter o output da lista dos internados.
        /// </summary>
        public static void LerListaInternado()
        {
            IO.MostrarInternados(Internados.ListaInternados);
        }

        /// <summary>
        /// Metodo GuardarListaInternados. Utilizado para guardar a lista dos internados num ficheiro.
        /// </summary>
        /// <param name="ficheiro"></param>
        /// <returns></returns>
        public static bool GuardarListaInternados(string ficheiro)
        {
            Internados.GuardarInternado(ficheiro);
            return true;
        }

        /// <summary>
        /// Metodo RemoverListaInternados. Utilizado para remover um internado da lista.
        /// </summary>
        /// <param name="internado"></param>
        /// <returns></returns>
        public static bool RemoverListaInternados(Internado internado)
        {
            Internados.RemoverInternado(internado);
            return true;
        }

        /// <summary>
        /// Metodo ConsultarInternadosQuarto. Utilizado para consultar os internados num determinado quarto.
        /// </summary>
        /// <param name="quarto"></param>
        /// <returns></returns>
        public static bool ConsultarInternadosQuarto(int quarto)
        {
            Internados.InternadosQuarto(quarto);
            return true;
        }
    }
}
