using System.Text;
using Register.Models;
using Newtonsoft.Json;

Console.OutputEncoding = Encoding.UTF8;
Console.InputEncoding = Encoding.UTF8;

Escola escola = new();
//escola.CadastrarAlunos();

escola.ExibirAlunosMatriculados();
