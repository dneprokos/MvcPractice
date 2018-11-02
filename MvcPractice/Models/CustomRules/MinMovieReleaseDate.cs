using System;
using System.ComponentModel.DataAnnotations;

namespace MvcPractice.Models
{
    public class MinMovieReleaseDate: ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var movie = (Movie)validationContext.ObjectInstance;

            DateTime minReleaseDate = new DateTime(1930, 1, 1);
            
            if (movie.ReleaseDate == null)
                return new ValidationResult("Release Date is required");

            return (movie.ReleaseDate >= minReleaseDate)
                ? ValidationResult.Success 
                : new ValidationResult("Release date cannot be less than 1 Jan 1930");


        }
    }
}