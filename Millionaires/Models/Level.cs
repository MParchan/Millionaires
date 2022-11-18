using System.ComponentModel.DataAnnotations;

namespace Millionaires.Models
{
    public class Level
    {
        public int LevelId { get; set; }
        public int Prize { get; set; }
        [Range(1,5)]
        public int DifficultyLevel { get; set; }
        public bool Guaranteed { get; set; }
    }
}