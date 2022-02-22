using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LEARNING_RESOURCES.Models
{
    public class User : Object
    {
        public User() : base()
        {
        }

        // **********
        [System.ComponentModel.DataAnnotations.Range
            (type: typeof(int), minimum: "25", maximum: "35")]
        public int Age { get; set; }
        // **********

        // **********
        public bool IsActive { get; set; }
        // **********

        // **********
    

        [System.ComponentModel.DataAnnotations.Display
            (ResourceType = typeof(Resources.DataDictionary),
            Name = nameof(Resources.DataDictionary.Username))]

        //[System.ComponentModel.DataAnnotations.Required]


        //[System.ComponentModel.DataAnnotations.Required
        //    (AllowEmptyStrings = false)]//""

        //[System.ComponentModel.DataAnnotations.Required
        //    (AllowEmptyStrings = false,
        //    ErrorMessage = "You did not specify username!")]

        //[System.ComponentModel.DataAnnotations.Required
        //    (AllowEmptyStrings = false,
        //    ErrorMessage = "You did not specify {0}!")]

        //[System.ComponentModel.DataAnnotations.Required
        //    (AllowEmptyStrings = false,
        //    ErrorMessageResourceType = typeof(Resources.ErrorMessages),
        //    ErrorMessageResourceName = "Required")]

        [System.ComponentModel.DataAnnotations.Required
            (AllowEmptyStrings = false,
            ErrorMessageResourceType = typeof(Resources.ErrorMessages),
            ErrorMessageResourceName = nameof(Resources.ErrorMessages.Required))]


        [System.ComponentModel.DataAnnotations.StringLength
            (maximumLength: 20, MinimumLength = 6)]

        public string Username { get; set; }
        // **********

        // **********
        [System.ComponentModel.DataAnnotations.Required
            (AllowEmptyStrings = false)]

        [System.ComponentModel.DataAnnotations.StringLength
            (maximumLength: 20, MinimumLength = 8)]

        //[System.ComponentModel.DataAnnotations.StringLength
        //	(maximumLength: 40, MinimumLength = 8)]
        public string Password { get; set; }
        // **********

        // **********
        [System.ComponentModel.DataAnnotations.StringLength
            (maximumLength: 50, MinimumLength = 3)]

        // وجود ندارد ef core کار می کند ولی در  ef6  این اتریبیوت در   
        //[System.ComponentModel.DataAnnotations.Schema.Index
        //	(IsUnique = false)]
        public string FullName { get; set; }
        // **********

        // **********
        [System.ComponentModel.DataAnnotations.Required
            (AllowEmptyStrings = false)]

        [System.ComponentModel.DataAnnotations.StringLength
            (maximumLength: 250, MinimumLength = 5)]

        //[System.ComponentModel.DataAnnotations.Schema.Index
        //	(IsUnique = true)]
        public string EmailAddress { get; set; }
        // **********
    }
}
