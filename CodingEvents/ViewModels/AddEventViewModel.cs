using System;
using System.ComponentModel.DataAnnotations;

namespace CodingEvents.ViewModels
{
    public class AddEventViewModel
    {
        [Required(ErrorMessage = "Name is required.")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Username must be more between 3 and 50 characters.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter a description for your event.")]
        [StringLength(500, ErrorMessage = "Description too long; it cannot be more than 500 characters.")]
        public string Description { get; set; }

        [EmailAddress]
        public string ContactEmail { get; set; }

        //This property should not be null or blank.
        [Required(ErrorMessage = "This field is required")]
        public string EventLocation { get; set; }

        //should be any number between zero and 100,000
        [Range(0, 100000)]
        public int NumOfAttendees { get; set; }

    }
}
