
using System.ComponentModel.DataAnnotations;

namespace MvcPractice.Models
{
    public class MemberShipType
    {

        public byte Id { get; set; }

        [Required]
        public string Name { get; set; }

        public short SignUpFee { get; set; }

        public byte DurationInMonth { get; set; }

        public byte DiscountRate { get; set; }

        public static readonly byte Uknown = 0;

        public static readonly byte PayAsYouGo = 1;
    }
}