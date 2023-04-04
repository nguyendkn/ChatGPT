namespace ChatGPT.Models
{
    public class SearchModel
    {
        public string SearchText { get; set; } = default!;
        public string SystemContext { get; set; } = default!;
        public string AssistantContext { get; set; } = default!;
    }
}
