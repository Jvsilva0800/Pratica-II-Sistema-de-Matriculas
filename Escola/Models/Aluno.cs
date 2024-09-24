using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;



namespace Register.Models
{

    public class Aluno
    {
        public Aluno()
        {

        }
        public Aluno(string nome, int idade, int matricula, string curso)
        {
            Nome = nome;
            Idade = idade;
            Matricula = matricula;
            Curso = curso;
        }

        private string _nome;
        private int _idade;
        public string Nome
        {

            get => _nome.ToUpper();
            set
            {
                if (value == "")
                {
                    throw new ArgumentException("O nome não pode ser vazio.");
                }

                _nome = value;
            }
        }
        public int Idade
        {
            get => _idade;
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Valor inválido para a idade");
                }
                _idade = value;
            }

        }
        public int Matricula { get; set; }
        public string Curso { get; set; }
        public void InformacaoAluno()
        {
            Console.WriteLine($"Nome: {Nome}\nIdade: {Idade}\nMatrícula: {Matricula}\nCurso: {Curso}\n");
        }



    }
}