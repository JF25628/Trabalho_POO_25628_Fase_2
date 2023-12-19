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

using System;
using Objetos;
using Regras;

namespace GerirHospital
{
    public class Program
    {
        static void Main(string[] args)
        {
            Paciente p1 = new Paciente("Paciente", 1, tipoSanguineo.APOSITIVO, DateTime.Now, 0, 0, "");
            //Paciente p2 = new Paciente("T1", 0, tipoSanguineo.APOSITIVO, DateTime.Now, 0, 0, "");
            //Paciente p3 = new Paciente(null, 1, tipoSanguineo.APOSITIVO, DateTime.Now, 0, 0, "");


            RegrasPaciente.InserirPaciente(p1);
            RegrasPaciente.LerListaPaciente();

            RegrasPaciente.GuardarListaPacientes("pacientes");


            Console.ReadLine();
        }
    }
}