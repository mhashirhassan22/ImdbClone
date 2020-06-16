using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading;
using System.Web.UI;
using System.Windows.Forms;
using System.Web.Mvc;
using db_imdb.Models;
using WebApplication1.Models;
using System.IO;
using System.Dynamic;

namespace db_imdb.Controllers
{
    public class siteController : Controller
    {
        public static string userID=null;
        public ActionResult Login()
        {
            if (Session["userId"] == null)
                return View();


            return RedirectToAction("Home");
            //return View();
        }
        public ActionResult Logout()
        {
            Session["userId"] = null;
            userID = null;


            return RedirectToAction("Login");
            //return View();
        }
        public ActionResult SignUp()
        {
            return View();
        }
        public ActionResult Admin()
        {
            return View();
        }
        public ActionResult Home()
        {
            if(Session["userid"]!=null)
            {
                return RedirectToAction("Home_Logged");
            }
            List<Movies> users = CRUD.getrecmovies();
            if (users == null)
            {
                //RedirectToAction("Login");
                return View();
            }
            Console.Write(users);
            return View(users);
        }
        public ActionResult Home_Logged()
        {
            if (Session["userid"] == null)
            {
                return RedirectToAction("Login");
            }
            List<Movies> users = CRUD.getrecmovies();
            //User obj = CRUD.getuser(userID);
            //newmodel mymodel = new newmodel();
            //mymodel.movies= CRUD.getrecmovies();
            //mymodel.curr = CRUD.getuser(userID);
            if (users == null)
            {
                RedirectToAction("Login");
                //return View();
            }
            ViewBag.Name = userID;
            //Console.Write(users);
            return View(users);
        }
        public ActionResult Movie()
        {
            List<Movies> users = CRUD.getAllmovies();
            if (users == null)
            {
                //RedirectToAction("Login");
                return View();
            }
            Console.Write(users);
            return View(users);
        }
        public ActionResult Movie_View(string id)
        {
            Movies users = CRUD.getmovie(id);
            if (users == null)
            {
                //RedirectToAction("Login");
                return View();
            }
            //Console.Write(users);
            ViewBag.reviews = CRUD.getreview_m(id);
            ViewBag.list = CRUD.getactorsformovie(id);
            return View(users);
        }
        public ActionResult Movie_Review(string id)
        {
            List<Reviews_t> reviews= CRUD.getreview_m(id);
            return View(reviews);
        }
        public ActionResult TVShow_Review(string id)
        {
            List<Reviews_t> reviews = CRUD.getreview_t(id);
            return View(reviews);
        }
        public ActionResult Addreview_m(string subjectname,string movie_id)
        {
            if(Session["userId"]==null)
            {
                MessageBox.Show("Login/SignUp to review");
                return RedirectToAction("Login");
            }
            CRUD.addreview_m(subjectname, userID, movie_id);
            return RedirectToAction("Movie");
        }
        public ActionResult Addreview_t(string subjectname, string movie_id)
        {
            if (Session["userId"] == null)
            {
                MessageBox.Show("Login/SignUp to review");
                return RedirectToAction("Login");
            }
            CRUD.addreview_t(subjectname, userID, movie_id);
            return RedirectToAction("TVShows_View", new { movie_id });
        }
        public ActionResult Movie_Actor(string id)
        {
            List<Actor> list = CRUD.getactorsformovie(id);
            if(list==null)
            {
                RedirectToAction("Login");
            }
            return View(list);
        }
        public ActionResult TVShows()
        {
            List<TV_Show> users1 = CRUD.getAlltvshows();
            if (users1 == null)
            {
                RedirectToAction("Login");
                //return View();
            }
            //Console.Write(users1);
            return View(users1);
        }
        public ActionResult TVShows_View(string id)
        {
            TV_Show users1 = CRUD.gettvshow(id);
            if (users1 == null)
            {
                RedirectToAction("Login");
                //return View();
            }
            //Console.Write(users1);
            ViewBag.reviews = CRUD.getreview_t(id);
            ViewBag.list = CRUD.getactorsfortvshow(id);
            return View(users1);
        }
        
        public ActionResult updaterating(string rate,string mid)
        {
            //if(Session["userId"]==null)
            //{
            //    MessageBox.Show("Login/SignUp to rate.");
            //    //return RedirectToAction("Login");
            //}
            //MessageBox.Show("Reached controller");
            int res=CRUD.updaterating_t(rate,mid);
            if(res==-1)
            {
                MessageBox.Show("Error in controller");
            }
            return RedirectToAction("TVShows");
            //return mid;
        }
        public ActionResult Actor()
        {
            List<Actor> users1 = CRUD.getAllactors();
            if (users1 == null)
            {
                RedirectToAction("Login");
                //return View();
            }
            //Console.Write(users1);
            return View(users1);
        }
        public ActionResult Director()
        {
            List<Director> users2 = CRUD.getAlldirectors();
            if (users2 == null)
            {
                RedirectToAction("Login");
                //return View();
            }
            //Console.Write(users1);
            return View(users2);
        }
        public ActionResult Director_View(string id)
        {
            Director list = CRUD.getdirector(id);
            if (list == null)
            {
                RedirectToAction("Login");
            }
            return View(list);
        }
        public ActionResult U_Pass()
        {
            return View();
        }
        public ActionResult U_Pass_Check(String passname,String passname1)
        {
            int result = CRUD.check_upass(userID, passname, passname1);
            if (result == -1)
            {
                String data = "Something went wrong while connecting with the database.";
                return View("U_Pass", (object)data);
            }
            else if (result == 0)
            {
                String data = "Incorrect Credentials";
                return View("U_Pass", (object)data);
            }

            MessageBox.Show("Account password successfully updated.");
            return RedirectToAction("Home");
        }
        public ActionResult Delete_Account()
        {
            return View();
        }
        public ActionResult Delete_Account_Check(String passname)
        {
            int result = CRUD.check_accounttodelete(userID,passname);
            if (result == -1)
            {
                String data = "Something went wrong while connecting with the database.";
                return View("Delete_Account", (object)data);
            }
            else if (result == 0)
            {
                String data = "Incorrect Credentials";
                return View("Delete_Account", (object)data);
            }

            MessageBox.Show("Account successfully deleted.");
            return RedirectToAction("Home");
        }
        public ActionResult AddUser()
        {
            return View();
        }
        public ActionResult DeleteUser()
        {
            return View();
        }
        public ActionResult addwatch_m(string mid)
        {
            if (Session["userId"] != null)
            {
                int result=CRUD.addwatch_m(userID, mid);
                if (result == -1)
                {
                    MessageBox.Show("Something went wrong while connecting with the database.");
                    return RedirectToAction("Movie");
                }
                else if (result == 0)
                {
                    MessageBox.Show("Movie already exists in watchlist");
                    return RedirectToAction("Movie");
                }
                MessageBox.Show("Movie added to watchlist");
                return RedirectToAction("Movie");
            }
            MessageBox.Show("Login/SignUp to add to watchlist");
            return RedirectToAction("Login");
        }
        public ActionResult addwatch_t(string tid)
        {
            if (Session["userId"] != null)
            {
                int result = CRUD.addwatch_t(userID, tid);
                if (result == -1)
                {
                    MessageBox.Show("Something went wrong while connecting with the database.");
                    return RedirectToAction("TVShows");
                }
                else if (result == 0)
                {
                    MessageBox.Show("TV Show already exists in watchlist");
                    return RedirectToAction("TVShows");
                }
                MessageBox.Show("TV Show added to watchlist");
                return RedirectToAction("TVShows");
            }
            MessageBox.Show("Login/SignUp to add to watchlist");
            return RedirectToAction("Login");
        }
        public ActionResult Watchlist_M()
        {
            if (Session["userid"] == null)
            {
                return RedirectToAction("Login");
            }
            List<Watchlist> users1 = CRUD.getwatch_m(userID);
            ViewBag.tvid = CRUD.getwatch_t(userID);
            if (users1 == null)
            {
                RedirectToAction("Login");
                //return View();
            }
            //Console.Write(users1);
            return View(users1);
        }
        public ActionResult Watchlist_T()
        {
            if (Session["userid"] == null)
            {
                return RedirectToAction("Login");
            }
            List<Watchlist> users1 = CRUD.getwatch_t(userID);
            if (users1 == null)
            {
                RedirectToAction("Home");
                //return View();
            }
            //Console.Write(users1);
            return View(users1);
        }
        public ActionResult delete_check(String unamename)
        {
            int result = CRUD.check_usertodelete(unamename);
            if (result == -1)
            {
                String data = "Something went wrong while connecting with the database.";
                return View("Login", (object)data);
            }
            else if (result == 0)
            {
                String data = "Incorrect Credentials";
                return View("Login", (object)data);
            }

            return RedirectToAction("Admin");
        }
        public ActionResult authenticate(String emailname,String passwordname)
        {
            int result = CRUD.Login(emailname, passwordname);

            if (result == -1)
            {
                String data = "Something went wrong while connecting with the database.";
                return View("Login", (object)data);
            }
            else if (result == 0)
            {
                String data = "Incorrect Credentials";
                return View("Login", (object)data);
            }


            Session["userId"] = emailname;
            userID = emailname;
            return RedirectToAction("Home_Logged");
        }
        public ActionResult signnup(String fnamename, String lnamename, String phonenoname, String unamename, String dobname, String countryname, String gendername,String emailname, String passwordname)
        {
            int result = CRUD.signup(fnamename, lnamename, phonenoname,unamename,dobname,countryname,gendername,emailname,passwordname);

            if (result == -1)
            {
                String data = "Something went wrong while connecting with the database.";
                return View("SignUp", (object)data);
            }
            else if (result == 0)
            {
                String data = "Incorrect Credentials";
                return View("SignUp", (object)data);
            }
            MessageBox.Show("Redirecting to Login page..");
            return RedirectToAction("Login");
        }

        public ActionResult AddMovie()
        {
            return View();
        }
        public ActionResult DeleteMovie()
        {
            return View();
        }

        public ActionResult AddAdmin()
        {
            return View();
        }
        public ActionResult DeleteAdmin()
        {
            return View();
        }
        public ActionResult AddGenre()
        {
            return View();
        }
        public ActionResult DeleteGenre()
        {
            return View();
        }
        public ActionResult AddTvShow()
        {
            return View();
        }
        public ActionResult DeleteTvShow()
        {
            return View();
        }
        public ActionResult AddDirector()
        {
            return View();
        }
        public ActionResult DeleteDirector()
        {
            return View();
        }
        public ActionResult AddEpisode()
        {
            return View();
        }
        public ActionResult DeleteEpisode()
        {
            return View();
        }
        public ActionResult AddActor()
        {
            return View();
        }
        public ActionResult DeleteActor()
        {
            return View();
        }
        public ActionResult AddTvshowActor()
        {
            return View();
        }
        public ActionResult AddMovieActor()
        {
            return View();
        }
        public ActionResult DeleteTvShowActor()
        {
            return View();
        }
        public ActionResult DeleteMovieActor()
        {
            return View();
        }
        public ActionResult _addmovie(String _id, String _title, String _duration, String _releasedate, String _genre, String _summary, String _rating, String _director)
        {

            int result = CRUD.addmoviee(_id, _title, _duration, _releasedate, _genre, _summary, _rating, _director);
            if (result == -1)
            {
                String data = "Something went wrong while connecting with the database.";
                return View("AddMovie", (object)data);
            }
            else if (result == 0)
            {
                string data = "Movie already exist";
                return View("AddMovie", (object)data);
            }
            return RedirectToAction("Admin");

        }

        public ActionResult _deletemovie(String _id)
        {

            int result = CRUD.deletemoviee(_id);
            if (result == -1)
            {
                String data = "Something went wrong while connecting with the database.";
                return View("DeleteMovie", (object)data);
            }
            else if (result == 0)
            {
                string data = "Movie doesn't exist";
                return View("DeleteMovie", (object)data);
            }
            return RedirectToAction("Admin");

        }



        public ActionResult _addtvshow(String _id, String _title, String _noofseasons, String _release_date, String _genre, String _summary, String _rating, String _director)
        {

            int result = CRUD.addtvshoww(_id, _title, _noofseasons, _release_date, _genre, _summary, _rating, _director);
            if (result == -1)
            {
                String data = "Something went wrong while connecting with the database.";
                return View("AddTvShow", (object)data);
            }
            else if (result == 0)
            {
                string data = "TVshow already exist";
                return View("AddTvShow", (object)data);
            }
            return RedirectToAction("Admin");

        }

        public ActionResult _deletetvshow(String _id, String _name)
        {

            int result = CRUD.deletetvshoww(_id, _name);
            if (result == -1)
            {
                String data = "Something went wrong while connecting with the database.";
                return View("DeleteTvShow", (object)data);
            }
            else if (result == 1)
            {
                string data = "TvSHOW doesn't exist";
                return View("DeleteTvShow", (object)data);
            }
            return RedirectToAction("Admin");

        }



        public ActionResult _addepisode(String _id, String _tvshowid, String _title, String _duration, String _seasonno)
        {

            int result = CRUD.addepisodee(_id, _title, _title, _duration, _seasonno);
            if (result == -1)
            {
                String data = "Something went wrong while connecting with the database.";
                return View("AddEpisode", (object)data);
            }
            else if (result == 0)
            {
                string data = "Episode already exist";
                return View("AddEpisode", (object)data);
            }
            return RedirectToAction("Admin");

        }

        public ActionResult _deleteepisode(String _id, String _sno)
        {

            int result = CRUD.deleteepisodee(_id, _sno);
            if (result == -1)
            {
                String data = "Something went wrong while connecting with the database.";
                return View("DeleteEpisode", (object)data);
            }
            else if (result == 1)
            {
                string data = "Episode doesn't exist";
                return View("DeleteEpisode", (object)data);
            }
            return RedirectToAction("Admin");

        }

        public ActionResult _addadmin(String idd)
        {

            int result = CRUD.addadminn(idd,userID);
            if (result == -1)
            {
                String data = "Something went wrong while connecting with the database.";
                return View("AddAdmin", (object)data);
            }
            else if (result == 0)
            {
                string data = "Incorrect data";
                return View("AddAdmin", (object)data);
            }
            return RedirectToAction("Admin");

        }

        public ActionResult _deleteadmin(String _id, String _uid)
        {

            int result = CRUD.deleteadminn(_id, _uid);
            if (result == -1)
            {
                String data = "Something went wrong while connecting with the database.";
                return View("DeleteAdmin", (object)data);
            }
            else if (result == 1)
            {
                string data = "Movie doesn't exist of this user id to be deleted.";
                return View("DeleteAdmin", (object)data);
            }
            return RedirectToAction("Admin");

        }

        public ActionResult _addactor(String _id, String _name, String _gender, String _age)
        {

            int result = CRUD.addactorr(_id, _name, _gender, _age);
            if (result == -1)
            {
                String data = "Something went wrong while connecting with the database.";
                return View("AddActor", (object)data);
            }
            else if (result == 0)
            {
                string data = "Actor already exist";
                return View("AddActor", (object)data);
            }
            return RedirectToAction("Admin");

        }

        public ActionResult _deleteactor(String _id)
        {

            int result = CRUD.deleteactorr(_id);
            if (result == -1)
            {
                String data = "Something went wrong while connecting with the database.";
                return View("DeleteActor", (object)data);
            }
            else if (result == 1)
            {
                string data = "Actor to be delete doesn't exist";
                return View("DeleteActor", (object)data);
            }
            return RedirectToAction("Admin");

        }


        public ActionResult _addmovieactor(String _id, String _movieid)
        {

            int result = CRUD.addmovieactorr(_id, _movieid);
            if (result == -1)
            {
                String data = "Something went wrong while connecting with the database.";
                return View("AddMovieActor", (object)data);
            }
            else if (result == 0)
            {
                string data = "Actor already exist";
                return View("AddMovieActor", (object)data);
            }
            return RedirectToAction("Admin");

        }

        public ActionResult _deletemovieactor(String _id, String _movieid)
        {

            int result = CRUD.deletemovieactorr(_id,_movieid);
            if (result == -1)
            {
                String data = "Something went wrong while connecting with the database.";
                return View("DeleteMovieActor", (object)data);
            }
            else if (result == 0)
            {
                string data = "Actor to be delete doesn't exist";
                return View("DeleteMovieActor", (object)data);
            }
            return RedirectToAction("Admin");

        }


        public ActionResult _addtvshowactor(String _id, String _tvshowid)
        {

            int result = CRUD.addtvshowactorr(_id, _tvshowid);
            if (result == -1)
            {
                String data = "Something went wrong while connecting with the database.";
                return View("AddTvhowActor", (object)data);
            }
            else if (result == 0)
            {
                string data = "Actor already exist";
                return View("AddTvshowActor", (object)data);
            }
            return RedirectToAction("Admin");

        }

        public ActionResult _deletetvshowactor(String _id, String _tvshowid)
        {

            int result = CRUD.deletetvshowactorr(_id,_tvshowid);
            if (result == -1)
            {
                String data = "Something went wrong while connecting with the database.";
                return View("DeleteTvShowActor", (object)data);
            }
            else if (result == 1)
            {
                string data = "Actor to be delete doesn't exist";
                return View("DeleteTvShowActor", (object)data);
            }
            return RedirectToAction("Admin");

        }




        public ActionResult _adddirector(String _id, String _name, String _gender, String _age)
        {

            int result = CRUD.adddirector(_id, _name, _gender, _age);
            if (result == -1)
            {
                String data = "Something went wrong while connecting with the database.";
                return View("AddDirector", (object)data);
            }
            else if (result == 0)
            {
                string data = "Director already exist";
                return View("AddDirector", (object)data);
            }
            return RedirectToAction("Admin");

        }

        public ActionResult _deletedirector(String _id)
        {

            int result = CRUD.deletedirector(_id);
            if (result == -1)
            {
                String data = "Something went wrong while connecting with the database.";
                return View("DeleteDirector", (object)data);
            }
            else if (result == 1)
            {
                string data = "Director to be deleted doesn't exist";
                return View("DeleteDirector", (object)data);
            }
            return RedirectToAction("Admin");

        }
        public ActionResult _addgenre(String _id, String _category)
        {

            int result = CRUD.addgenree(_id, _category);
            if (result == -1)
            {
                String data = "Something went wrong while connecting with the database.";
                return View("AddGenre", (object)data);
            }
            else if (result == 0)
            {
                string data = "Genre already exist";
                return View("AddGenre", (object)data);
            }
            return RedirectToAction("Admin");

        }
        public ActionResult _deletegenre(String _id)
        {

            int result = CRUD.deletegenree(_id);
            if (result == -1)
            {
                String data = "Something went wrong while connecting with the database.";
                return View("_deletegenre", (object)data);
            }
            else if (result == 1)
            {
                string data = "Genre to be delete doesn't exist";
                return View("_deletegenre", (object)data);
            }
            return RedirectToAction("Admin");

        }

    }
}
