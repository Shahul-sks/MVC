using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCassignment.Models
{
    public class Movie
    {
        [Key]
        public int mid { get; set; }

        public string Moviename { get; set; }

        public DateTime dateofrelease { get; set; }

    }
}