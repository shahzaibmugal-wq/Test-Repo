using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Dotnet.GitHubDevOps.Core.Repos.Options
{
    public class PushFilesOption
    {
        [JsonPropertyName("branch")]
        [Required]
        public string Branch { get; set; }

        [JsonPropertyName("files")]
        [Required]
        public List<FileUpload> Files { get; set; }

        [JsonPropertyName("message")]
        [Required]
        public string Message { get; set; }

        [JsonPropertyName("repository_name")]
        [Required]
        public string RepositoryName { get; set; }
    }

    public class FileUpload
    {
        [JsonPropertyName("path")]
        public string Path { get; set; } = string.Empty;

        [JsonPropertyName("content")]
        public string Content { get; set; } = string.Empty;
    }
}
