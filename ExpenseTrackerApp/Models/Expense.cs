using System;
using System.ComponentModel.DataAnnotations;

namespace ExpenseTrackerApp.Models
{
    public class Expense
    {
        public int Id { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public decimal Amount { get; set; }

        [Required]
        public string Category { get; set; }

        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
    }
}
