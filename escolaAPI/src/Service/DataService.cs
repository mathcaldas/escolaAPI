namespace escolaAPI.src.Service;

public class DataService
{
    private readonly HttpClient _httpClient;
    private const string ApiUrl = "https://api.example.com/data"; // Replace with actual API URL

    public DataService()
    {
        _httpClient = new HttpClient();
    }

    public async Task<string> GetDataAsync()
    {
        var response = await _httpClient.GetStringAsync(ApiUrl);
        return response;
    }
}
