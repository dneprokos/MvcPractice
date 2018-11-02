
using System;
using System.ComponentModel.DataAnnotations;

namespace MvcPractice.Models
{
    public class Customer
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter customer's name.")]
        [StringLength(255)]
        public string Name { get; set; }

        public bool isSubscribedToNewsLetter { get; set; }

        public MemberShipType MemberShipType { get; set; }

        [Display(Name = "Membership Type")]
        public byte MemberShipTypeId { get; set; }

        [Display(Name = "Date of Birth")]
        [MinYearsIfAMember]
        public DateTime? Birthdate { get; set; }
    }
}