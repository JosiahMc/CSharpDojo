using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using LoginRegDemo.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace LoginRegDemo.Controllers {
    public class HomeController : Controller {

        private UserContext _context;
        private object userFactory;

        public HomeController (UserContext context) {
            _context = context;
        }

        public IActionResult Index () {
            return View ();
        }

        [HttpPost]
        [Route ("RegisterUser")]
        public IActionResult RegisterUser (User MyUser, string ConfirmPassword) {
            
            System.Console.WriteLine ("WE HIT REGISTERED USER FUNCTION IN CONTROLLER");
            if(MyUser.Password != ConfirmPassword) {
                System.Console.WriteLine("DAMN HOMIE your passwords dont match **************************");
                ViewBag.PasswordError = $"{MyUser.FirstName} I'm so terribly sorry but I'm a robot and I don't understand why you would type passwords that don't match. THANKS FOR PLAYING. TRY AGAIN!";
                return View ("Index");
            }

            if (ModelState.IsValid) {
                PasswordHasher<User> Hasher = new PasswordHasher<User>();
                MyUser.Password = Hasher.HashPassword(MyUser, MyUser.Password);
                User ExistingUser = _context.users.SingleOrDefault (u => u.Email == MyUser.Email);
                if (ExistingUser != null) {
                    System.Console.WriteLine (" *************EMAIL ALREADY IN USE**********************");
                    ViewBag.AlreadyInUseEmail = true;
                    // ViewBag.AlreadyInUseEmail = $"{MyUser.Email} is already in the Data base, YOU FUCK!";
                    return View ("Index");
                    // Yo dude Have you ever watched Mike Tyson Mysteries? Its really good show.
                }
                else{
                    _context.Add (MyUser);
                    _context.SaveChanges ();

                    HttpContext.Session.SetString("userEmail", MyUser.Email);
                    HttpContext.Session.SetInt32("userID", MyUser.UserId);
                    // var user = HttpContext.Session.GetInt32("userId");

                    // grabs all reviews from database
                    return RedirectToAction ("Success");
                }
            } else {
                System.Console.WriteLine ("There were errors adding user returned to index********************");
                return View ("Index");
            }

        }

        [Route("Home/LikeStatus/{id}")]
        public IActionResult LikeStatus (int id) {
            
            Post posts2 = _context.posts.SingleOrDefault(u => u.PostId == id);
            
            User userPoster = _context.users.SingleOrDefault(up => up.UserId == posts2.UserId);
            // ViewBag.event2 = _context.posts.Include(ig => ig.user).Include(pa => pa.Likes).ThenInclude(u => u.user).SingleOrDefault(uq => uq.PostId == id);
            // List<Like> likes = _context.posts.Include(ig => ig.user).Include(pa => pa.Likes).ThenInclude(u => u.user).SingleOrDefault(uq => uq.PostId == id);
            // ViewBag.ActivityPlan = _context.posts.Include(a => a.user).ThenInclude(uap => uap.User).SingleOrDefault(a => a.ActivityPlanID == ActivityPlanID);
            List<Like> likes = _context.likes.Include(un => un.user).ToList();
            // List<Like> distinct = likes.DistinctBy(uid => uid.UserId).ToList();
            
            
            ViewBag.LIKES = likes;
            ViewBag.Poster = userPoster;
            ViewBag.Posts = posts2;
            
            
            
            return View("LikeStatus");
        }

        public IActionResult Success () {
            var userEmail = HttpContext.Session.GetString("userEmail");
            User users = _context.users.SingleOrDefault(u => u.Email == userEmail);
            List<Like> likes = _context.likes.ToList();


            List<Post> posts = _context.posts.Include(ig => ig.user).Include(pa => pa.Likes).ThenInclude(u => u.user).OrderByDescending(ev => ev.Likes.Count).ToList();
            // *took this from the line above
            DateTime CurrentDate = DateTime.Today;

            ViewBag.CurrentDate = CurrentDate;
            ViewBag.Posts = posts;
            ViewBag.User = users;
            ViewBag.Like = likes;

            return View ("Home");
        }
        [HttpPost]
        [Route("Logout")]
        public IActionResult Logout() {
            HttpContext.Session.Clear();
            return RedirectToAction("Index");
        }

        [Route("Home/LikeStatus/Userprofile/{id}")]
        public IActionResult UserprofileShow(int id)
        {
            

            return RedirectToAction("Userprofile");
        }
        
        [Route("Home/Userprofile/{id}")]
        public IActionResult Userprofile(int id)
        {
            
            User users = _context.users.SingleOrDefault(u => u.UserId == id);
            // List<Like> likes = _context.likes.ToList();


            List<Post> posts = _context.posts.Where(ui => ui.UserId == id).Include(pa => pa.Likes).ThenInclude(u => u.user).ToList();
            List<Like> likes = _context.likes.Where(ui => ui.UserId == id).ToList();
            // *took this from the line above
            

            
            ViewBag.Posts = posts;
            ViewBag.User = users;
            ViewBag.Likes = likes;

            return View("Userprofile");
        }


        [Route("Home/New")]
        public IActionResult New() {

            return View();
        }

        [HttpPost]
        public IActionResult Process(Post posts) {
            var UserEmail = HttpContext.Session.GetString("userEmail");
            User Users = _context.users.SingleOrDefault(u => u.Email == UserEmail);

            if(ModelState.IsValid) {
            posts.UserId = Users.UserId;
            _context.Add(posts);
            _context.SaveChanges();
            

            HttpContext.Session.SetInt32("postID", posts.PostId);
            // HttpContext.Session.SetString("userEmail", MyUser.Email);
            // HttpContext.Session.SetInt32("userID", MyUser.UserId);
            return RedirectToAction ("Success");

            }
            else {
                System.Console.WriteLine("You done screwed up kid that post didnt post to the db");
                return View("Home");
            }

        }
        [Route("Home/SinglePost/{id}")]
        public IActionResult SinglePost (int id) {
            int? postsID = HttpContext.Session.GetInt32("postID");
            Post posts = _context.posts.SingleOrDefault(u => u.PostId == id);

            User users = _context.users.SingleOrDefault(ui => ui.UserId == posts.UserId);

            

            
            ViewBag.Posts = posts;
            ViewBag.Users = users;

            return View();
        }

        

        [Route("Home/Join/{id}")]
        public IActionResult Join (int id)
        {
            int? userid = HttpContext.Session.GetInt32("userID");
            User users = _context.users.SingleOrDefault(u => u.UserId == userid);

            Like Like = new Like();
            Like.PostId = id;
            Like.UserId = users.UserId;
            _context.Add(Like);
            _context.SaveChanges();

            return RedirectToAction("Success");
        }

        [Route("Home/Unjoin/{id}")]
        public IActionResult Unjoin (int id)
        {
            int? userid = HttpContext.Session.GetInt32("userID");
            User users = _context.users.SingleOrDefault(u => u.UserId == userid);
            System.Console.WriteLine(id);

            Like Like = _context.likes.SingleOrDefault(p => p.UserId == users.UserId && p.PostId == id);
            _context.Remove(Like);
            _context.SaveChanges();

            return RedirectToAction("Success");
        }

        [Route("Home/Delete/{id}")]
        public IActionResult Delete (int id)
        {
            Post posts = _context.posts.SingleOrDefault(u => u.PostId == id);
            _context.posts.Remove(posts);
            _context.SaveChanges();
            return RedirectToAction("Success");
        }


        // [HttpPost]
        // [Route ("LoginUser")]
        // public IActionResult LoginUser (string Email, string Password) {
        //     //is user in database???? Use where or Singleordefault or firstordefault
        //     //check queried user's password against our passed in password

        //     //go to success(maybe add stuff to session first?)
        //     //otherwise, get some error messages to our user
        //     return RedirectToAction ("Index");
        // }
        [HttpPost]
        [Route("LoginUser")]
        public IActionResult Login(string email, string Password){
            
            var user = _context.users.SingleOrDefault(u => u.Email == email);
            if(user != null && Password != null){
                var Hasher = new PasswordHasher<User>();
                if(0 != Hasher.VerifyHashedPassword(user, user.Password, Password)){
                    HttpContext.Session.SetString("userEmail", email);
                    HttpContext.Session.SetInt32("userID", user.UserId);
                    return RedirectToAction("Success");
                }
                else{
                    System.Console.WriteLine("*************************$$$$$$$$$$$#################################$$$$$$$$$$$$$$************");
                    System.Console.WriteLine("Else for login if password doesnt match");
                    System.Console.WriteLine("*************************$$$$$$$$$$$#################################$$$$$$$$$$$$$$************");

                    ViewBag.loginError = "Wrong password!";
                    return View("Index");
                }
            }
            else{
                System.Console.WriteLine("*************************$$$$$$$$$$$#################################$$$$$$$$$$$$$$************");
                System.Console.WriteLine("Else for login email doesnt exist");
                System.Console.WriteLine("*************************$$$$$$$$$$$#################################$$$$$$$$$$$$$$************");

                ViewBag.loginError = "Email not registered";
                return View("Index");
            }
            
        }


        // public IActionResult About()
        // {
        //     ViewData["Message"] = "Your application description page.";

        //     return View();
        // }

        // public IActionResult Contact()
        // {
        //     ViewData["Message"] = "Your contact page.";

        //     return View();
        // }

        public IActionResult Error () {
            return View (new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}