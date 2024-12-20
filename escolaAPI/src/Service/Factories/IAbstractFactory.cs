using escolaAPI.src.Model;

namespace escolaAPI.src.Service.Factories
{
    public interface IAbstractFactory
    {
        Aluno CreateAluno(int id, string nome, string endereco);
        Disciplina CreateDisciplina(int id, string nome);
    }
}