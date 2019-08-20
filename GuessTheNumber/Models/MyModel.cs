using System;
using System.ComponentModel.DataAnnotations;

namespace GuessTheNumber.Models
{
    public class MyModel
    {
        public int MyNumber { get; set; }

        [Required]
        [Range( 0, 101,ErrorMessage ="Please enter a valide number between 0 and 100.")]
        public int EnteredNum { get; set; }

        public bool ShowResult { get; set; }
        public bool Success { get; set; }
        public int TryCounter { get; set; }


        /// <summary>
        /// Generating the class with a random number for the game to start guess
        /// </summary>
        public void GetGuessNumber()
        {
            var random = new Random();
          this.  MyNumber = random.Next(1, 100);
        }
    }
}
