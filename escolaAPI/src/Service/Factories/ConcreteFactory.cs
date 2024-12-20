using escolaAPI.src.Model;

namespace escolaAPI.src.Service.Factories
{
    public class ConcreteFactory : IAbstractFactory
    {
        public Aluno CreateAluno(int id, string name, string address)
        {
            return new Aluno
            {
                Id = id,
                Nome = name,
                Endereco = address
            };
        }

        public Disciplina CreateDisciplina(int id, string name)
        {
            return new Disciplina
            {
                Id = id,
                Nome = name,
            };
        }
    }
}