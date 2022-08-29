using System.ComponentModel.DataAnnotations;

namespace web_asp.Models.DataModels
{
    public enum Levels { 
        BASIC = 'B', 
        MEDIUM = 'M', 
        ADVANCED = 'A' 
    }

    public class Course: BaseEntity
    {
        [Required]
        public string Name { get; set; } = string.Empty;

        public string ShortDescription { get; set; } = string.Empty;

        [MaxLength(280)]
        public string LongDescription { get; set; } = string.Empty;

        public string TargetAudiences { get; set; } = string.Empty;

        public string Objectives { get; set; } = string.Empty;

        public string Requirements { get; set; } = string.Empty;

        public Levels Level { get; set; } = Levels.BASIC;

    }
}
