using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestApi.Models.Enum;
using TestApi.Models;

namespace TestApi.Services.ViewModels
{
    public class StudentViewModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string IsDeleted { get; set; }
        public int TeacherId { get; set; }
    }
}
