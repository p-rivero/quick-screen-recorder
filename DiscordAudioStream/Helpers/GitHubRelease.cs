using System.Text.Json;

// Required for dotnet format
using HttpClient = System.Net.Http.HttpClient;

namespace DiscordAudioStream;

public record GitHubRelease(string tag_name, Uri html_url)
{
    private const string TAG_PREFIX = "v";
    private static readonly Uri githubBaseUrl = new("https://api.github.com");
    private static readonly GitHubRelease defaultRelease = new("v0.0.0", new("https://example.com"));

    public Version Version => Version.Parse(RemovePrefix(tag_name, TAG_PREFIX));
    public Uri DownloadUrl => html_url;

    public static async Task<GitHubRelease> GetLatest(string author = "pol-rivero", string repoName = "DiscordAudioStream")
    {
        try
        {
            string response = await Get($"repos/{author}/{repoName}/releases/latest").ConfigureAwait(false);
            GitHubRelease? release = JsonSerializer.Deserialize<GitHubRelease>(response);
            return release ?? defaultRelease;
        }
        catch (Exception e)
        {
            Logger.Log("Failed to get latest GitHub release!");
            Logger.Log(e);
            return defaultRelease;
        }
    }

    private static async Task<string> Get(string relativeUrl)
    {
        const string USER_AGENT = "dummy-user-agent";
        Uri requestUri = new(githubBaseUrl, relativeUrl);

        using HttpClient client = new();
        client.DefaultRequestHeaders.Add("User-Agent", USER_AGENT);
        return await client.GetStringAsync(requestUri).ConfigureAwait(false);
    }

    private static string RemovePrefix(string text, string prefix)
    {
        bool startsWithPrefix = text.StartsWith(prefix, StringComparison.InvariantCulture);
        return startsWithPrefix ? text.Substring(prefix.Length) : text;
    }
}
