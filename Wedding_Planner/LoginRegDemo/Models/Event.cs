using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
namespace LoginRegDemo.Models

{
    public class Event 
        {
            [Key]            
            public int EventId {get;set;}
            
            public string WedderOne {get; set;}

            public string WedderTwo {get; set;}

            public DateTime Date {get; set;}

            public string Address {get; set;}

            public int UserId {get; set;}

            public User user {get; set;} 
            
            public List<Guest> Guests {get;set;}

            public Event()
            {
                Guests = new List<Guest>();
            }
            
        }
    
    }