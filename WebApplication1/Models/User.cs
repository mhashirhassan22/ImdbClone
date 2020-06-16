using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace db_imdb.Models
{
    public class User
    {
        public string userId;
        public string name;
    }
    public class Movies
    {
        public string id;
        public string path;
        public string title;
        public string rt;
        public string date;
        public string rating;
        public string director;
    }
    public class TV_Show
    {
        public string id;
        public string path;
        public string title;
        public string no_of_s;
        public string date;
        public string rating;
        public string director;
    }
    public class Actor
    {
        public string id;
        public string path;
        public string name;
        public string gender;
        public string age;
    }
    public class Director
    {
        public string id;
        public string path;
        public string name;
        public string gender;
        public string age;
    }
    public class Watchlist
    {
        public string id;
        public string title;
    }
    public class newmodel
    {
        public List<Movies> movies { get; set; }
        public User curr { get; set; }
    }
    public class Reviews_t
    {
        public string mid;
        public string movie;
        public string reviewed_by;
        public string summary;
        public string upvotes;
    }
}