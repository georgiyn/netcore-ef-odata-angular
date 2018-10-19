using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TranslationTool.Models
{
    public class Text
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Key { get; set; }
        public string Comment { get; set; }
        public string TranslatorNotes { get; set; }
        public string OriginalText { get; set; }
        public ICollection<Translation> Translations { get; set; }
    }
}
