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
    public class RegrasExame
    {
        /// <summary>
        /// Metodo InserirExames. Utilizado para inserir exames na lista.
        /// </summary>
        /// <param name="exame"></param>
        /// <returns></returns>
        public static bool InserirExames(Exame exame)
        {
            Exames.AdicionarLista(exame);
            return true;
        }

        /// <summary>
        /// Metodo LerListaExame. Utilizado para obter o output da lista dos exames.
        /// </summary>
        public static void LerListaExame()
        {
            IO.MostrarExames(Exames.ListaExames);
        }

        /// <summary>
        /// Metodo GuardarListaExames. Utilizado para guardar a lista dos exames num ficheiro.
        /// </summary>
        /// <param name="ficheiro"></param>
        /// <returns></returns>
        public static bool GuardarListaExames(string ficheiro)
        {
            Exames.GuardarExame(ficheiro);
            return true;
        }

        /// <summary>
        /// Metodo RemoverListaExames. Utilizado para remover um exame da lista.
        /// </summary>
        /// <param name="exame"></param>
        /// <returns></returns>
        public static bool RemoverListaExames(Exame exame)
        {
            Exames.RemoverExame(exame);
            return true;
        }

        /// <summary>
        /// Metodo ConsultaExamesEnfermeiro. Utilizado para consultar os exames onde um enfermeiro foi responsavel.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static bool ConsultaExamesEnfermeiro(int id)
        {
            Exames.ExamesEnfermeiro(id);
            return true;
        }
    }
}
