using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangmanGameDemo
{
    public class WordData
    {
        public string Word {  get; set; }
        public string Clue { get; set; }
        public string Level { get; set; }
        public string Category { get; set; }
    }
    public class WordRepo
    {
        private List<WordData> words;

        public WordRepo(string csvpath)
        {
            words = LoadFromCsv(csvpath);
        }

        private List<WordData> LoadFromCsv(string path) 
        { 
            var list = new List<WordData>();
            var lines = File.ReadAllLines(path);

            foreach (var line in lines.Skip(1))
            {
                var parts = line.Split(",");
                if (parts.Length >= 4)
                {
                    list.Add(new WordData {
                        Word = parts[0].Trim(),
                        Clue = parts[1].Trim(),
                        Level = parts[2].Trim(),
                        Category = parts[3].Trim(),
                    });
                } 
            }

            return list;
        }

        public WordData GetWord() 
        {
            var settings = GameSettings.Instance;

            var filtered = words.Where(w =>
                w.Category.Equals(settings.Category, StringComparison.OrdinalIgnoreCase) &&
                w.Level.Equals(settings.Level, StringComparison.OrdinalIgnoreCase)
            ).ToList();

            if (filtered.Count == 0) 
            {
                return null;
            }

            return filtered[new Random().Next(filtered.Count)];
        }
    }
}
