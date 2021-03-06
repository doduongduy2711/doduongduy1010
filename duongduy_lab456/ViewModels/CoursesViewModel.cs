﻿using duongduy_lab456.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Globalization;
namespace duongduy_lab456.ViewModels
{
    public class CoursesViewModel
    {
       
        [Required]
        public string Place { get; set; }
        [Required]
        [FutureDate]
        public string Date { get; set; }
        [Required]
        [ValidTime]
        public string Time { get; set; }
        [Required]
        public byte Category { get; set; }
        public IEnumerable<Course> UpcomingCourses { get; set; }
       
        public IEnumerable<ApplicationUser> Follows { get; set; }
        public IEnumerable<Category> Categories { get; set; }
       
        public bool ShowAction { get; set; }
        public DateTime GetDateTime()
        {
            return DateTime.Parse(string.Format("{0} {1}", Date, Time));
        }

    }
}