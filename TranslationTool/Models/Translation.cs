using System.ComponentModel.DataAnnotations.Schema;

namespace TranslationTool.Models
{
    public class Translation
    {
        public int Id { get; set; }
        [ForeignKey("TextKey")]
        public string TextKey { get; set; }
        public string Text { get; set; }
        public string Lang { get; set; }
    }
}
