namespace escolaAPI.src.Service;
public sealed class WebServiceConnection
{
    private static WebServiceConnection instance;
    private static readonly object lockObject = new object();
    private readonly HttpClient httpClient;

    private WebServiceConnection()
    {
        httpClient = new HttpClient();
        httpClient.BaseAddress = new Uri("http://localhost:3000/");
    }

    public static WebServiceConnection Instance
    {
        get
        {
            if (instance == null)
            {
                lock (lockObject)
                {
                    instance ??= new WebServiceConnection();
                }
            }
            return instance;
        }
    }

    public async Task<string> GetDataAsync(string endpoint)
    {
        var response = await httpClient.GetAsync(endpoint);
        return await response.Content.ReadAsStringAsync();
    }
}