using System;
using System.ComponentModel.DataAnnotations;

namespace GuessTheNumber.Models
{
    public class MyModel
    {
        public int MyNumber { get; set; }

        [Display(Name = "Enter your Number ")]
        [Range( 0, 101,ErrorMessage ="The number is between 0 and 100.")]
        public int EnteredNum { get; set; }
        public bool ShowResult { get; set; }


        public void GetGuessNumber()
        {
            var random = new Random();
          this.  MyNumber = random.Next(1, 100);
        }
    }
}
