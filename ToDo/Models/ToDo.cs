using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace ToDoList.Models
{
    public class ToDo
    {
        private Category category = null!;

        public int Id { get; set; }

        [Required(ErrorMessage = "Veuillez saisir une description.")]
        public string Description { get; set; } = string.Empty;

        [Required(ErrorMessage = "Veuillez entrer une date d'échéance.")]
        public DateTime? DueDate { get; set; }

        [Required(ErrorMessage = "Veuillez sélectionner une catégorie.")]
        public string CategoryId { get; set; } = string.Empty;

        [ValidateNever]
        public Category Category { get; set; } = null!;

        [Required(ErrorMessage = "Veuillez sélectionner un statut.")]
        public string StatusId { get; set; } = string.Empty;

        [ValidateNever]
        public Status Status { get; set; } = null!;

        public bool Overdue => StatusId == "open" && DueDate < DateTime.Today;



    }
}
