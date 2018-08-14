using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DXWebApplication {
    public class JQueryValidationData {
        [Display(Name = "Author:")]
        [Required(ErrorMessage = "Author is required")]
        public string Author { get; set; }

        [Display(Name = "Publisher:")]
        [StringLength(10, ErrorMessage = "Must be under 10 characters")]
        public string Publisher { get; set; }

        [Display(Name = "Release Date:")]
        [Required(ErrorMessage = "Release date is required")]
        [Remote("CheckReleaseDate", "Common", ErrorMessage = "Release date can not be earlier than today")]
        public DateTime ReleaseDate { get; set; }

        [Display(Name = "Annotation:")]
        [Required(ErrorMessage = "Annotation is required")]
        public string Annotation { get; set; }
    }
}