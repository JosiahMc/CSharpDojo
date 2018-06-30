using System.ComponentModel.DataAnnotations;
using LoginRegDemo.Models;


namespace LoginRegDemo
{
    public class Like
    {
        [Key]
        public int LikeId {get; set;}

        public int UserId {get; set;}
        public User user {get; set;}

        public int PostId {get; set;}
        public Post posts {get; set;}

    }
}

