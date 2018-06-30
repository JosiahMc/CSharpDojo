using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using LoginRegDemo.Models;
namespace LoginRegDemo
{
    public class Guest
    {
        public int GuestId {get;set;}

        public int UserId {get;set;}
        public User User {get;set;}

        public int EventId {get;set;}
        public Event Event {get;set;}



    }
}