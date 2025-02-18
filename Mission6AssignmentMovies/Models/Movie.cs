using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mission6AssignmentMovies.Models
{
    public class Movie
    {
        [Key]
        [Required]
        public int MovieId { get; set; }

        [ForeignKey("CategoryId")]
        public int? CategoryId { get; set; }
        public Category? Category { get; set; }


        [Required(ErrorMessage = "You must enter a title")]
        public string Title { get; set; }
        [Required]
        [Range(1888, int.MaxValue, ErrorMessage = "Year must be after 1888.")]
        public int Year { get; set; }
        public string? Director { get; set; }
        public string? Rating { get; set; }
        [Required(ErrorMessage = "You must enter if the movie is edited or not")]
        public bool Edited { get; set; }
        public string? LentTo { get; set; }
        [Required(ErrorMessage = "You must enter if the movie has been copied to Plex")]
        public bool? CopiedToPlex { get; set; }
        [MaxLength(25)]
        public string? Notes { get; set; }
    }
}
