using escolaAPI.src.Controller;

class Program
{
    static async Task Main(string[] args)
    {
        var controller = new EscolaController();
        await controller.ProcessarDados();
    }
}