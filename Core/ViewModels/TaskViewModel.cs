using MyTasks.Core.Models.Domains;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;


namespace MyTasks.Core.ViewModels
{
    public class TaskViewModel
    {
        public string Heading { get; set; }
        public Task Task { get; set; }

        [Required(ErrorMessage = "Pole Kategoria jest wymagane")]
        [Display(Name = "Kategoria")]
        public IEnumerable<Category> Categories { get; set; }
    }
}
