using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;



namespace Register.Models
{

    public class Escola
    {
        public Escola()
        {
            Alunos = new();
            try
            {
                string lendoDocumento = File.ReadAllText("Arquivos/listaAlunos.json");
                Alunos = JsonConvert.DeserializeObject<List<Aluno>>(lendoDocumento);
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public List<Aluno> Alunos;

        public void CadastrarAlunos()
        {


            string Nome, Curso;
            int Matricula, Idade;
            Console.WriteLine("Informe o Nome:");
            Nome = Console.ReadLine();
            Console.WriteLine("Informe A Idade:");
            try
            {
                Idade = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException)
            {
                throw new ArgumentException("Formato de dado inválido!!");
            }

            Console.WriteLine("Informe sua Matrícula:");
            try
            {
                Matricula = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException)
            {
                throw new ArgumentException("Formato de dado inválido!!");
            }

            Console.WriteLine("Informe o curso do aluno:");
            Curso = Console.ReadLine();

            Aluno a = new(Nome, Idade, Matricula, Curso);
            Alunos.Add(a);
            SerializarLIsta(Alunos);
        }

        public void SerializarLIsta(List<Aluno> alunos)
        {
            string listaSerializada = JsonConvert.SerializeObject(alunos, Formatting.Indented);
            File.WriteAllText("Arquivos/listaAlunos.json", listaSerializada);//Encoding serve para gravar os dados que utilizam caracteres especiais
        }

        public void ExibirAlunosMatriculados()
        {

            if (Alunos.Count <= 0)
            {
                Console.WriteLine("Não existe aluno matrículado");
            }
            else
            {
                Console.Clear();
                foreach (var item in Alunos)
                {
                    item.InformacaoAluno();

                }
            }

        }
    }
}