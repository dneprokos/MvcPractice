using MvcPractice.Models;
using System.Collections.Generic;

namespace MvcPractice.ViewModels
{
    public class CustomerFormViewModel
    {
        public IEnumerable<MemberShipType> MemberShipTypes { get; set; }

        public Customer Customer { get; set; }
    }
}