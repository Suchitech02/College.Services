using System;
using System.ComponentModel.DataAnnotations;

namespace College.Services.Entities
{

    public class Student
    {
        [Key]
        public int StudentId { get; set; }

        public string Name { get; set; }

        public string RollNumber { get; set; }

        public int ProfessorId { get; set; }

        public decimal Fees { get; set; }
    }

}