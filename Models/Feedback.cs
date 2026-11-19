using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Prac7.Models
{
    public class Feedback
    {
        public int FeedbackId { get; set; }

        [Required(ErrorMessage = "Please enter your name.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter your email.")]
        [EmailAddress(ErrorMessage = "Enter a valid email address.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please enter the subject.")]
        public string Subject { get; set; }

        [Required(ErrorMessage = "Please enter your feedback.")]
        public string Message { get; set; }

        [Required(ErrorMessage = "Please select a rating.")]
        public string Rating { get; set; }
    }
}