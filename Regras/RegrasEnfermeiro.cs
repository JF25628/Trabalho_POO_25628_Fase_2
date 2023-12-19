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
    public class RegrasEnfermeiro
    {
        /// <summary>
        /// Metodo InserirEnfermeiros. Utilizado para inserir enfermeiros na lista.
        /// </summary>
        /// <param name="enfermeiro"></param>
        /// <returns></returns>
        public static bool InserirEnfermeiros(Enfermeiro enfermeiro)
        {
            Enfermeiros.AdicionarLista(enfermeiro);
            return true;
        }

        /// <summary>
        /// Metodo LerListaEnfermeiro. Utilizado para obter o output da lista dos enfermeiros.
        /// </summary>
        public static void LerListaEnfermeiro()
        {
            IO.MostrarEnfermeiros(Enfermeiros.ListaEnfermeiros);
        }

        /// <summary>
        /// Metodo GuardarListaEnfermeiros. Utilizado para guardar a lista dos enfermeiros num ficheiro.
        /// </summary>
        /// <param name="ficheiro"></param>
        /// <returns></returns>
        public static bool GuardarListaEnfermeiros(string ficheiro)
        {
            Enfermeiros.GuardarEnfermeiro(ficheiro);
            return true;
        }

        /// <summary>
        /// Metodo RemoverListaEnfermeiros. Utilizado para remover um enfermeiro da lista.
        /// </summary>
        /// <param name="enfermeiro"></param>
        /// <returns></returns>
        public static bool RemoverListaEnfermeiros(Enfermeiro enfermeiro)
        {
            Enfermeiros.RemoverEnfermeiro(enfermeiro);
            return true;
        }

        /// <summary>
        /// Metodo EnfermeirosComQualificacao. Utilizado para verificar quais enfermeiros tem uma qualificacao especifica.
        /// </summary>
        /// <param name="qualificacao"></param>
        /// <returns></returns>
        public static bool EnfermeirosComQualificacao(string qualificacao)
        {
            Enfermeiros.QualificacaoEnfermeiro(qualificacao);
            return true;
        }
    }
}
