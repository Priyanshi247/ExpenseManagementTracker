﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExpenseManagement.Models
{
    public class ExpenseEntity
    {
        [Key]
        public int ExpenseId {  get; set; }

        [Required(ErrorMessage ="Please select Expense Date")]
        [DataType(DataType.Date)]
        [Display(Name ="Expense Date")]
        public DateTime ExpenseDate { get; set; }

        [Required(ErrorMessage = "Please select Expense given to details")]
        [MinLength(3, ErrorMessage = "The name of the expense given to is TOO SHORT")]
        [Display(Name = "Paid To")]
        public string ExpenseGivenTo { get; set;}

        
        [Required(ErrorMessage = "Please select Expense Amount")]
        [Range(0, double.MaxValue,ErrorMessage = "Please enter a valid Expense Amount")]
        [Display(Name = "Expense Amount")]
        public double ExpenseAmount { get; set;}

        [Display(Name = "Expense Category")]
        public int ExpenseCategoryId { get; set;}

        [ForeignKey("ExpenseCategoryId")]
        public virtual ExpenseCategoryEntity? ExpenseCategory { get; set;}
        //virtual means referring entire table

    }
}
