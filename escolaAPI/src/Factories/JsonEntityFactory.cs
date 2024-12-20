using Newtonsoft.Json;
using escolaAPI.src.Model;

namespace escolaAPI.src.Factories;
public class JsonEntityFactory : IEntityFactory
{
    public Aluno CreateAluno(string jsonData)
    {
        return JsonConvert.DeserializeObject<Aluno>(jsonData);
    }

    public Disciplina CreateDisciplina(string jsonData)
    {
        return JsonConvert.DeserializeObject<Disciplina>(jsonData);
    }

    public Matricula CreateMatricula(string jsonData)
    {
        return JsonConvert.DeserializeObject<Matricula>(jsonData);
    }
}