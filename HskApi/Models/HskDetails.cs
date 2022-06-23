using System.ComponentModel.DataAnnotations;

namespace HskApi.Models
{
    public class HskDetails
    {
        public string Id { get; set; }
        public string? Pinyin { get; set; }
        public string? Hanzi { get; set; }
        public string? Translation1 { get; set; }
        public string? Translation2 { get; set; }
        public string? Translation3 { get; set; }
        public int? HskLevel { get; set; }

    }
}
