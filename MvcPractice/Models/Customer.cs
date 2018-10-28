
using System;

namespace MvcPractice.Models
{
    public class Customer
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public bool isSubscribedToNewsLetter { get; set; }

        public MemberShipType MemberShipType { get; set; }

        public byte MemberShipTypeId { get; set; }

        public DateTime? Birthdate { get; set; }
    }
}