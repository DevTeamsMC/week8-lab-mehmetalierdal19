using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangmanGameDemo
{
    public class GameSettings
    {
        private static GameSettings _instance;
        private static readonly object _lock = new object();

        public string Category { get; set; }
        public string Level { get; set; } = "Kolay";
        public int GameDuration { get; set; } = 60;
        public int ImageID { get; set; } = 0;

        private GameSettings() { }
        public static GameSettings Instance
        {
            get
            {
                lock (_lock)
                {
                    return _instance ??= new GameSettings();
                }
            }
        }
    }
}
