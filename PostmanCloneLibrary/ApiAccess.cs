using System.Runtime.CompilerServices;
using System.Text.Json;

namespace PostmanCloneLibrary;

public class ApiAccess : IApiAccess
{
    private readonly HttpClient client = new();

    public async Task<string> CallApiAsync(//string url,bool formatUotput = true,HttpAction action = HttpAction.GET)
        string url,
        bool formatUotput = true,
        HttpAction action = HttpAction.GET
    )
    {
        //Api call
        var response = await client.GetAsync(url);

        if (response.IsSuccessStatusCode)
        {

            string json = await response.Content.ReadAsStringAsync();
            if (formatUotput)
            {
                var jsonElement = JsonSerializer.Deserialize<JsonElement>(json);
                json = JsonSerializer.Serialize(jsonElement,
                    new JsonSerializerOptions { WriteIndented = true });

                //return prettyJson;
            }

            return json;
        }
        else
        {
            return $"Error: {response.StatusCode}";
        }
    }

    public bool IsValidUrl(string url)
    {
        if (string.IsNullOrWhiteSpace(url))
        {
            return false;
        }

        bool output = Uri.TryCreate(url, UriKind.Absolute, out Uri uriOutput) &&
            (uriOutput.Scheme == Uri.UriSchemeHttps);

        return output;
    }
}
