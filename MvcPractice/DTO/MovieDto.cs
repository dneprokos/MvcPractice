using MvcPractice.Models;
using System;
using System.ComponentModel.DataAnnotations;

namespace MvcPractice.DTO
{
    public class MovieDto
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [Required]
        public byte GenreId { get; set; }

        public DateTime DateAdded { get; set; }

        //[MinMovieReleaseDate]
        public DateTime ReleaseDate { get; set; }

        [Range(1, 20)]
        public byte NumberInStock { get; set; }
    }
}