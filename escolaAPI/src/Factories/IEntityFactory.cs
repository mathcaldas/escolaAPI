using escolaAPI.src.Model;

namespace escolaAPI.src.Factories;
public interface IEntityFactory
{
    Aluno CreateAluno(string jsonData);
    Disciplina CreateDisciplina(string jsonData);
    Matricula CreateMatricula(string jsonData);

}