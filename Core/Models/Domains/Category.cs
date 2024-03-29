﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyTasks.Core.Models.Domains
{
    public class Category
    {
        public Category()
        {
            Tasks = new Collection<Task>();
        }
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string UserId { get; set; }
        public bool IsChecked { get; set; }

        public ICollection<Task> Tasks { get; set; }

        public ApplicationUser User { get; set; }

    }
}
