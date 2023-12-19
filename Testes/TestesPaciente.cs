/*
 * trabalhoPOO_25628
 * Nome: João Miguel Oliveira Figueiredo 
 * Numero de aluno: 25628
 * Email: a25628alunos.ipca.pt
 * Escola de tecnologia
 * Curso de Licenciatura de Engenharia de Sistemas Informaticos
 * Disciplina: Programação Orientada a Objetos
 * 07/11/2023
 * 
 */

using Dados;
using Objetos;
using System.Reflection.Emit;

namespace Testes
{
    [TestClass]
    public class TestesPaciente
    {

        /// <summary>
        /// Metodo TesteInserirPaciente. Metodo de teste para verificar as excecoes ao inserir um paciente.
        /// </summary>
        [TestMethod]
        public void TesteInserirPaciente()
        {
            Paciente p3 = new Paciente(null, 1, tipoSanguineo.APOSITIVO, DateTime.Now, 0, 0, "");

            bool resultado = Pacientes.AdicionarLista(p3);

            Assert.IsTrue(resultado);
        }
    }
}