namespace Sorting.Models
{
    public class IndexViewModel
    {
        public string Names { get; set; } = string.Empty;
        public string SortOrder { get; set; } = string.Empty;
        public List<string> Sorted { get; set; } = new List<string>();
    }
}
