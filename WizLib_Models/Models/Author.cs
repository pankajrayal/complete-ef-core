﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace WizLib_Models.Models
{
    public class Author
    {
        [Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)] //Generated by Database, Default is Identity
        //[DatabaseGenerated(DatabaseGeneratedOption.None)] //Prevents value being generatd by DB automatically
        public int Author_Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Location { get; set; }

        [NotMapped]
        public string FullName 
        {
            get {
                return $"{FirstName} {LastName}";
            }
        }

        public ICollection<BookAuthor> BookAuthors { get; set; }
    }
}
