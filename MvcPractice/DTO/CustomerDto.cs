using MvcPractice.Models;
using System;
using System.ComponentModel.DataAnnotations;

namespace MvcPractice.DTO
{
    public class CustomerDto
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter customer's name.")]
        [StringLength(255)]
        public string Name { get; set; }

        public bool isSubscribedToNewsLetter { get; set; }

        public byte MemberShipTypeId { get; set; }

        //[MinYearsIfAMember] Was disabled because it cannot be invoked from Api.
        public DateTime? Birthdate { get; set; }
    }
}