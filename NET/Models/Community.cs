﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Lab4.Models
{
    public class Community
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Registration Number")]
        [Required]
        public string ID { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 3)]
        public string Title { get; set; }

        [DataType(DataType.Currency)]
        [Column(TypeName = "money")]
        public decimal Budget { get; set; }

        // public Student Membership { get; set; }
        //public IEnumerable<Student> Students { get; internal set; }
        //public IEnumerable<Student> Student { get; internal set; }
        //public IEnumerable<CommunityMembership> Membership { get; set; }
        public IEnumerable<CommunityMembership> CommunityMemberships { get; set; }
        public IEnumerable<Student> Students { get; set; }
        public IEnumerable<Ads> AdsImages { get; set; }

    }
}
