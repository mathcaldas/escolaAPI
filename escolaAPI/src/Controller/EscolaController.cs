using escolaAPI.src.Factories;
using escolaAPI.src.Model;
using escolaAPI.src.Service;
using Newtonsoft.Json;

namespace escolaAPI.src.Controller;
public class EscolaController
{
    private readonly WebServiceConnection webService;
    private readonly IEntityFactory entityFactory;
    private readonly XmlService xmlService;

    public EscolaController()
    {
        webService = WebServiceConnection.Instance;
        var factoryCreator = new JsonEntityFactoryCreator();
        entityFactory = factoryCreator.CreateFactory();
        xmlService = new XmlService();
    }

    public async Task ProcessarDados()
    {
        try
        {
            // Buscar dados
            var alunosJson = await webService.GetDataAsync("alunos");
            var disciplinasJson = await webService.GetDataAsync("disciplinas");
            var matriculasJson = await webService.GetDataAsync("matriculas");

            // Converter dados
            var alunos = JsonConvert.DeserializeObject<List<Aluno>>(alunosJson);
            var disciplinas = JsonConvert.DeserializeObject<List<Disciplina>>(disciplinasJson);
            var matriculas = JsonConvert.DeserializeObject<List<Matricula>>(matriculasJson);

            // Salvar em XML
            xmlService.SaveToXml(alunos, "alunos.xml");
            xmlService.SaveToXml(disciplinas, "disciplinas.xml");
            xmlService.SaveToXml(matriculas, "matriculas.xml");

            Console.WriteLine("Dados processados com sucesso!");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro ao processar dados: {ex.Message}");
        }
    }
}
