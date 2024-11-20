namespace BlogApi.Models
{
    public record Post(int PostId, string PostTitle, string PostBody, string[] Tags);
}