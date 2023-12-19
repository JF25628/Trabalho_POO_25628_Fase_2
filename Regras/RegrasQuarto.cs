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
    public class RegrasQuarto
    {
        /// <summary>
        /// Metodo InserirQuartos. Utilizado para inserir quartos na lista.
        /// </summary>
        /// <param name="quarto"></param>
        /// <returns></returns>
        public static bool InserirQuartos(Quarto quarto)
        {
            Quartos.AdicionarLista(quarto);
            return true;
        }

        /// <summary>
        /// Metodo LerListaQuartos. Utilizado para receber o output da lista dos quartos.
        /// </summary>
        public static void LerListaQuartos()
        {
            IO.MostrarQuartos(Quartos.ListaQuartos);
        }

        /// <summary>
        /// Metodo GuardarListaQuartos. Utilizado para guardar a lista dos quartos num ficheiro.
        /// </summary>
        /// <param name="ficheiro"></param>
        /// <returns></returns>
        public static bool GuardarListaQuartos(string ficheiro)
        {
            Quartos.GuardarQuarto(ficheiro);
            return true;
        }

        /// <summary>
        /// Metodo RemoverListaQuartos. Utilizado para remover um quarto da lista.
        /// </summary>
        /// <param name="quarto"></param>
        /// <returns></returns>
        public static bool RemoverListaQuartos(Quarto quarto)
        {
            Quartos.RemoverQuarto(quarto);
            return true;
        }
    }
}
