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
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excecoes
{
    /// <summary>
    /// Excecoes relacionadas aos nomes.
    /// </summary>
    public class NomeInvaliadoException : ApplicationException
    {
        public NomeInvaliadoException() : base("Nome Inválido")
        {
        }

        public NomeInvaliadoException(string s) : base(s)
        {
        }

        public NomeInvaliadoException(string s, Exception e)
        {
            //throw new Exception(e.Message + " - " + s);
            throw new NomeInvaliadoException(e.Message + " - " + s);
        }

    }

    /// <summary>
    /// Excecoes relacionadas as idades.
    /// </summary>
    public class IdadeInvalidaException : ApplicationException
    {
        public IdadeInvalidaException() : base("Idade Inválida")
        {
        }

        public IdadeInvalidaException(string s) : base(s)
        {
        }

        public IdadeInvalidaException(string s, Exception e)
        {
            //throw new Exception(e.Message + " - " + s);
            throw new IdadeInvalidaException(e.Message + " - " + s);
        }

    }

    /// <summary>
    /// Excecoes relacionadas aos tipos de sangue.
    /// </summary>
    public class SangueInvalidoException : ApplicationException
    {
        public SangueInvalidoException() : base("Tipo sanguineo Inválido")
        {
        }

        public SangueInvalidoException(string s) : base(s)
        {
        }

        public SangueInvalidoException(string s, Exception e)
        {
            //throw new Exception(e.Message + " - " + s);
            throw new SangueInvalidoException(e.Message + " - " + s);
        }

    }

    /// <summary>
    /// Excecoes relacionadas as datas.
    /// </summary>
    public class DataInvalidaException : ApplicationException
    {
        public DataInvalidaException() : base("Data de nascimento Inválida")
        {
        }

        public DataInvalidaException(string s) : base(s)
        {
        }

        public DataInvalidaException(string s, Exception e)
        {
            //throw new Exception(e.Message + " - " + s);
            throw new DataInvalidaException(e.Message + " - " + s);
        }

    }

    /// <summary>
    /// Excecoes relacionadas aos numeros de contato.
    /// </summary>
    public class ContatoInvalidoException : ApplicationException
    {
        public ContatoInvalidoException() : base("Contato Inválido")
        {
        }

        public ContatoInvalidoException(string s) : base(s)
        {
        }

        public ContatoInvalidoException(string s, Exception e)
        {
            //throw new Exception(e.Message + " - " + s);
            throw new ContatoInvalidoException(e.Message + " - " + s);
        }

    }

    /// <summary>
    /// Excecoes relacionadas aos numero de utente.
    /// </summary>
    public class UtenteInvalidoException : ApplicationException
    {
        public UtenteInvalidoException() : base("Nunero de utente Inválido")
        {
        }

        public UtenteInvalidoException(string s) : base(s)
        {
        }

        public UtenteInvalidoException(string s, Exception e)
        {
            //throw new Exception(e.Message + " - " + s);
            throw new UtenteInvalidoException(e.Message + " - " + s);
        }

    }

    /// <summary>
    /// Excecoes relacionadas aos historico medico.
    /// </summary>
    public class HistoricoInvalidoException : ApplicationException
    {
        public HistoricoInvalidoException() : base("Historico medico Inválido")
        {
        }

        public HistoricoInvalidoException(string s) : base(s)
        {
        }

        public HistoricoInvalidoException(string s, Exception e)
        {
            //throw new Exception(e.Message + " - " + s);
            throw new HistoricoInvalidoException(e.Message + " - " + s);
        }

    }
}