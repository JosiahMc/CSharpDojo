using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LoginRegDemo.Models
{
    public class Post
    {
        [Key]
        public int PostId {get; set;}

    
    [Required(ErrorMessage   = "Must have content in your post!")]
    // [MinLength(2)]
    public string Description {get; set;}
    
    // [Required]
    // [MyDate(ErrorMessage = "Must have a date in the future")]
    // public DateTime Date{get; set;}


    // [Required(ErrorMessage = "Must have time")]
    // public TimeSpan Time {get; set;}


    // [Required(ErrorMessage = "You don't leave your front door unlocked do you? Or maybe you just don't own one.")]
    // // [MinLength(1)]
    // public int DurationInt {get; set;}


    // [Required(ErrorMessage = "Duration Required")]
    // public string DurationStr {get; set;}

    // [Required(ErrorMessage = "Duration Required")]
    // // [MinLength(10)]
    // public string Description {get; set;}

    public int UserId {get; set;}

    
    
    public User user {get; set;}
    //the above line is the user referenced on the success query in the controller


    public List<Like> Likes {get; set;}
    
        
    // public class MyDateAttribute : ValidationAttribute
    //     {
    // public override bool IsValid(object value)
    // {
    //     DateTime d = Convert.ToDateTime(value);
    //     return d >= DateTime.Now;
    // }
    //     }    

    public Post() {
        Likes = new List<Like>();

        
    }    

}
}