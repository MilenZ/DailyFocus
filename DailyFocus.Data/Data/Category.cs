using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyFocus.Data.Data
{
    /*
     * Category will be used to group tasks into different categories.  
     * It will be defined by the Admin of the application.
     */
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = null!;
         
        [Required]
        public string Color { get; set; } = null!;

        [MaxLength(500)]
        public string? Description { get; set; }
    }
}

/*
Name	    ColorHex
Work	    #2196F3 (син)       (project, meeting)
Personal	#9C27B0 (лилав)     (family, Home)
Health	    #4CAF50 (зелен)     (Excercise, Wellness)
Learning	#FF9800 (оранжев)   (Skills)
Creative	#E91E63 (розов)     (Side Project)
Finance	    #795548 (кафяв)     
*/