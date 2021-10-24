using System;

namespace DietDash.Shared.Patient
{
    public class Patient
    {
        public Guid Id { get; set; }
        public Guid DietitianId { get; set; }
        public string FileName { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string LastName { get; set; }
        public string IdNumber { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }
        public string UpdatedBy { get; set; }

        public Anthropology Anthropology { get; set; }
    }
}
