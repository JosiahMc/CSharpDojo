using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using CSharpBeltExamOne.Models;
namespace CSharpBeltExamOne
{
    public class Guest
    {
        public int GuestId {get;set;}

        public int UserId {get;set;}
        public User User {get;set;}

        public int WeddingId {get;set;}
        public Wedding Wedding {get;set;}



    }
}