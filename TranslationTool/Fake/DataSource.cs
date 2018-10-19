using System.Collections.Generic;
using TranslationTool.Models;

namespace TranslationTool
{
    public static class DataSource
    {
        private static IList<Text> _texts { get; set; }

        public static IList<Text> GetTranslations()
        {
            if (_texts != null)
            {
                return _texts;
            }

            _texts = new List<Text>();

            var item = new Text
            {
                Id = 1,
                Key = "play-button",
                Comment = "this is just comment",
                OriginalText = "Play",
                TranslatorNotes = "hi, this is new text on play button",
                Translations = new List<Translation>()
            };
            item.Translations.Add(new Translation()
            {
                Id = 1,
                TextKey = "play-button",
                Text = "German Translated text"
            });
            _texts.Add(item);

             item = new Text
            {
                Id = 2,
                Key = "play-again",
                Comment = "this is just comment",
                OriginalText = "Play Again",
                TranslatorNotes = "hi, this is new text on play button",
                Translations = new List<Translation>()
             };
            _texts.Add(item);

            return _texts;
        }
    }
}
