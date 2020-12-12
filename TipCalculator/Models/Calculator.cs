namespace TipCalculator.Models
{

    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Threading.Tasks;
    using System.Transactions;
    public class Calculator
    {
        [Required(ErrorMessage = "Please enter a value for the cost of the meal")]
        [Range(0.01, 1000000, ErrorMessage = "Cost of meal must be greater than zero")]
        [Display(Name = "Cost of Meal.")]
        public double? MealCost { get; set; }
        public double CalculateTip(double tipPercent)
        {
            return MealCost.HasValue ? MealCost.Value * tipPercent : 0;
        }
    }
}


