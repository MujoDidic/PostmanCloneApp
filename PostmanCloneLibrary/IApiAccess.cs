
namespace PostmanCloneLibrary
{
    public interface IApiAccess
    {
        Task<string> CallApiAsync(string url, bool formatUotput = true, HttpAction action = HttpAction.GET);
        bool IsValidUrl(string url);
    }
}