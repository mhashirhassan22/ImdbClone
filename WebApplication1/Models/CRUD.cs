using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data.SqlClient;
using System.Data.Sql;
using System.Data;

namespace db_imdb.Models
{
    public class CRUD
    {
        public static string connectionString = "data source=localhost; Initial Catalog=imdb;Integrated Security=true";

        public static List<User> getAllUsers()
        {
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand cmd;

            try
            {
                cmd = new SqlCommand("ViewUsers", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                SqlDataReader rdr = cmd.ExecuteReader();

                List<User> list = new List<User>();
                while (rdr.Read())
                {
                    User user = new User();

                    user.userId = rdr["userId"].ToString();
                    list.Add(user);
                }
                rdr.Close();
                con.Close();

                return list;
            }

            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error" + ex.Message.ToString());
                return null;

            }
        }
        public static User getuser(string id)
        {
            //SqlConnection con = new SqlConnection(connectionString);
            //con.Open();
            //SqlCommand cmd;

            try
            {
                //cmd = new SqlCommand("getname", con);
                //cmd.CommandType = System.Data.CommandType.StoredProcedure;
                //cmd.Parameters.Add("@id", SqlDbType.NVarChar, 30).Value = id;
                //SqlDataReader rdr = cmd.ExecuteReader();

                User user = new User();
                user.userId = id;
                //while (rdr.Read())
                //{
                //    //User user = new User();

                //    user.userId = rdr["id"].ToString();
                //    //list.Add(user);
                //}
                //rdr.Close();
                //con.Close();

                return user;
            }

            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error" + ex.Message.ToString());
                return null;

            }
        }
        public static List<Actor> getactorsformovie(string id)
        {
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand cmd;

            try
            {
                cmd = new SqlCommand("getmovieactor", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add("@id", SqlDbType.NVarChar, 30).Value = id;
                SqlDataReader rdr = cmd.ExecuteReader();

                List<Actor> list = new List<Actor>();
                while (rdr.Read())
                {
                    Actor movi = new Actor();

                    movi.id = rdr["id"].ToString();
                    movi.path = rdr["path_img"].ToString();
                    movi.name = rdr["name"].ToString();
                    movi.gender = rdr["gender"].ToString();
                    movi.age = rdr["age"].ToString();

                    list.Add(movi);
                }
                rdr.Close();
                con.Close();

                return list;
            }
            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error" + ex.Message.ToString());
                return null;

            }
        }
        public static List<Actor> getactorsfortvshow(string id)
        {
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand cmd;

            try
            {
                cmd = new SqlCommand("gettvshowactor", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add("@id", SqlDbType.NVarChar, 30).Value = id;
                SqlDataReader rdr = cmd.ExecuteReader();

                List<Actor> list = new List<Actor>();
                while (rdr.Read())
                {
                    Actor movi = new Actor();

                    movi.id = rdr["id"].ToString();
                    movi.path = rdr["path_img"].ToString();
                    movi.name = rdr["name"].ToString();
                    movi.gender = rdr["gender"].ToString();
                    movi.age = rdr["age"].ToString();

                    list.Add(movi);
                }
                rdr.Close();
                con.Close();

                return list;
            }
            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error" + ex.Message.ToString());
                return null;

            }
        }
        public static List<Director> getAlldirectors()
        {
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand cmd;

            try
            {
                cmd = new SqlCommand("getdirectors", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                SqlDataReader rdr = cmd.ExecuteReader();

                List<Director> list = new List<Director>();
                while (rdr.Read())
                {
                    Director movi = new Director();

                    movi.id = rdr["id"].ToString();
                    movi.path = rdr["path_img"].ToString();
                    movi.name = rdr["name"].ToString();
                    movi.gender = rdr["gender"].ToString();
                    movi.age = rdr["age"].ToString();

                    list.Add(movi);
                }
                rdr.Close();
                con.Close();

                return list;
            }
            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error" + ex.Message.ToString());
                return null;

            }
        }
        public static Director getdirector(string id)
        {
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand cmd;

            try
            {
                cmd = new SqlCommand("getsomedirector", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add("@id", SqlDbType.NVarChar, 30).Value = id;
                SqlDataReader rdr = cmd.ExecuteReader();

                Director movi = new Director();
                while (rdr.Read())
                {
                    //Director movi = new Director();

                    movi.id = rdr["id"].ToString();
                    movi.path = rdr["path_img"].ToString();
                    movi.name = rdr["name"].ToString();
                    movi.gender = rdr["gender"].ToString();
                    movi.age = rdr["age"].ToString();
                }
                rdr.Close();
                con.Close();

                return movi;
            }
            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error" + ex.Message.ToString());
                return null;

            }
        }
        public static List<Actor> getAllactors()
        {
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand cmd;

            try
            {
                cmd = new SqlCommand("getactors", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                SqlDataReader rdr = cmd.ExecuteReader();

                List<Actor> list = new List<Actor>();
                while (rdr.Read())
                {
                    Actor movi = new Actor();

                    movi.id = rdr["id"].ToString();
                    movi.path = rdr["path_img"].ToString();
                    movi.name = rdr["name"].ToString();
                    movi.gender = rdr["gender"].ToString();
                    movi.age = rdr["age"].ToString();

                    list.Add(movi);
                }
                rdr.Close();
                con.Close();

                return list;
            }
            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error" + ex.Message.ToString());
                return null;

            }
        }
        public static List<TV_Show> getAlltvshows()
        {
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand cmd;

            try
            {
                cmd = new SqlCommand("gettvshows", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                SqlDataReader rdr = cmd.ExecuteReader();

                List<TV_Show> list = new List<TV_Show>();
                while (rdr.Read())
                {
                    TV_Show movi = new TV_Show();

                    movi.id = rdr["id"].ToString();
                    movi.path = rdr["path_img"].ToString();
                    movi.title = rdr["title"].ToString();
                    movi.no_of_s = rdr["no_of_season"].ToString();
                    movi.date = rdr["release_date"].ToString();
                    movi.rating = rdr["rating"].ToString();

                    list.Add(movi);
                }
                rdr.Close();
                con.Close();

                return list;
            }
            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error" + ex.Message.ToString());
                return null;

            }
        }
        public static TV_Show gettvshow(string id)
        {
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand cmd;

            try
            {
                cmd = new SqlCommand("getonetvshow", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add("@id", SqlDbType.NVarChar, 30).Value = id;
                SqlDataReader rdr = cmd.ExecuteReader();

                TV_Show movi = new TV_Show();
                while (rdr.Read())
                {
                    //Director movi = new Director();

                    movi.id = rdr["id"].ToString();
                    movi.path = rdr["path_img"].ToString();
                    movi.title = rdr["title"].ToString();
                    movi.no_of_s = rdr["no_of_season"].ToString();
                    movi.date = rdr["release_date"].ToString();
                    movi.rating = rdr["rating"].ToString();
                }
                rdr.Close();
                con.Close();

                return movi;
            }
            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error" + ex.Message.ToString());
                return null;

            }
        }
        public static List<Movies> getrecmovies()
        {
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand cmd;

            try
            {
                cmd = new SqlCommand("getrecmovies", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                SqlDataReader rdr = cmd.ExecuteReader();

                List<Movies> list = new List<Movies>();
                while (rdr.Read())
                {
                    Movies movi = new Movies();

                    movi.id = rdr["id"].ToString();
                    movi.path = rdr["path_img"].ToString();
                    movi.title = rdr["title"].ToString();
                    movi.rt = rdr["duration"].ToString();
                    movi.date = rdr["release_date"].ToString();
                    movi.rating = rdr["rating"].ToString();
                    movi.director = rdr["name"].ToString();
                    list.Add(movi);
                }
                rdr.Close();
                con.Close();

                return list;
            }

            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error" + ex.Message.ToString());
                return null;

            }
        }
        public static Movies getmovie(string id)
        {
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand cmd;

            try
            {
                cmd = new SqlCommand("getonemovie", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add("@id", SqlDbType.NVarChar, 30).Value = id;
                SqlDataReader rdr = cmd.ExecuteReader();

                Movies movi = new Movies();
                while (rdr.Read())
                {
                    //Director movi = new Director();

                    movi.id = rdr["id"].ToString();
                    movi.path = rdr["path_img"].ToString();
                    movi.title = rdr["title"].ToString();
                    movi.rt = rdr["duration"].ToString();
                    movi.date = rdr["release_date"].ToString();
                    movi.rating = rdr["rating"].ToString();
                    movi.director = rdr["name"].ToString();
                }
                rdr.Close();
                con.Close();

                return movi;
            }
            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error" + ex.Message.ToString());
                return null;

            }
        }
        public static List<Movies> getAllmovies()
        {
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand cmd;

            try
            {
                cmd = new SqlCommand("getmovies", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                SqlDataReader rdr = cmd.ExecuteReader();

                List<Movies> list = new List<Movies>();
                while (rdr.Read())
                {
                    Movies movi = new Movies();

                    movi.id = rdr["id"].ToString();
                    movi.path = rdr["path_img"].ToString();
                    movi.title = rdr["title"].ToString();
                    movi.rt = rdr["duration"].ToString();
                    movi.date = rdr["release_date"].ToString();
                    movi.rating = rdr["rating"].ToString();
                    movi.director=rdr["name"].ToString();
                    list.Add(movi);
                }
                rdr.Close();
                con.Close();

                return list;
            }

            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error" + ex.Message.ToString());
                return null;

            }
        }
        public static List<Reviews_t> getreview_m(string id)
        {
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand cmd;

            try
            {
                cmd = new SqlCommand("getreview_m", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add("@id", SqlDbType.NVarChar, 30).Value = id;
                SqlDataReader rdr = cmd.ExecuteReader();

                List<Reviews_t> list = new List<Reviews_t>();
                while (rdr.Read())
                {
                    Reviews_t movi = new Reviews_t();

                    movi.mid = rdr["id"].ToString();
                    movi.movie = rdr["title"].ToString();
                    movi.reviewed_by = rdr["uuid"].ToString();
                    movi.summary = rdr["summary"].ToString();

                    list.Add(movi);
                }
                rdr.Close();
                con.Close();

                return list;
            }
            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error" + ex.Message.ToString());
                return null;

            }
        }
        public static List<Reviews_t> getreview_t(string id)
        {
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand cmd;

            try
            {
                cmd = new SqlCommand("getreview_t", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add("@id", SqlDbType.NVarChar, 30).Value = id;
                SqlDataReader rdr = cmd.ExecuteReader();

                List<Reviews_t> list = new List<Reviews_t>();
                while (rdr.Read())
                {
                    Reviews_t movi = new Reviews_t();

                    movi.mid = rdr["id"].ToString();
                    movi.movie = rdr["title"].ToString();
                    movi.reviewed_by = rdr["uuid"].ToString();
                    movi.summary = rdr["summary"].ToString();

                    list.Add(movi);
                }
                rdr.Close();
                con.Close();

                return list;
            }
            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error" + ex.Message.ToString());
                return null;

            }
        }
        public static int addreview_m(String subjectname,string userID,string mid)
        {
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand cmd;
            //int result = 0;

            try
            {
                cmd = new SqlCommand("addreview_m", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add("@mid", SqlDbType.NVarChar, 30).Value = mid;
                cmd.Parameters.Add("@uid", SqlDbType.NVarChar, 30).Value = userID;
                cmd.Parameters.Add("@summary", SqlDbType.NVarChar, 30).Value = subjectname;


                cmd.ExecuteNonQuery();
                return 0;
            }

            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error" + ex.Message.ToString());
                //result = -1; //-1 will be interpreted as "error while connecting with the database."
            }
            finally
            {
                con.Close();
            }
            return -1;
        }
        public static int addreview_t(String subjectname, string userID, string mid)
        {
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand cmd;
            //int result = 0;

            try
            {
                cmd = new SqlCommand("addreview_t", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add("@mid", SqlDbType.NVarChar, 30).Value = mid;
                cmd.Parameters.Add("@uid", SqlDbType.NVarChar, 30).Value = userID;
                cmd.Parameters.Add("@summary", SqlDbType.NVarChar, 30).Value = subjectname;


                cmd.ExecuteNonQuery();
                return 0;
            }

            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error" + ex.Message.ToString());
                //result = -1; //-1 will be interpreted as "error while connecting with the database."
            }
            finally
            {
                con.Close();
            }
            return -1;
        }
        public static int updaterating_t(string rate,string tid)
        {
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand cmd;
            int result = 0;

            try
            {
                cmd = new SqlCommand("updaterating_t", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add("@tid", SqlDbType.NVarChar, 30).Value = tid;
                cmd.Parameters.Add("@new_rate", SqlDbType.NVarChar, 30).Value = rate;


                cmd.ExecuteNonQuery();
                return result;
            }

            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error" + ex.Message.ToString());
                return -1; //-1 will be interpreted as "error while connecting with the database."
            }
            finally
            {
                con.Close();
            }
            return result;
        }
        public static int check_upass(string userid, string pass, string pass1) //Requested by user
        {

            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand cmd;
            int result = 0;

            try
            {
                cmd = new SqlCommand("UP_PIN", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add("@id", SqlDbType.NVarChar, 30).Value = userid;
                cmd.Parameters.Add("@pin", SqlDbType.NVarChar, 15).Value = pass;
                cmd.Parameters.Add("@pin1", SqlDbType.NVarChar, 15).Value = pass1;


                cmd.Parameters.Add("@output", SqlDbType.Int).Direction = ParameterDirection.Output;

                cmd.ExecuteNonQuery();
                result = Convert.ToInt32(cmd.Parameters["@output"].Value);
            }

            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error" + ex.Message.ToString());
                result = -1; //-1 will be interpreted as "error while connecting with the database."
            }
            finally
            {
                con.Close();
            }
            return result;
        }
        public static int check_accounttodelete(string userid,string pass) //Requested by user
        {

            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand cmd;
            int result = 0;

            try
            {
                cmd = new SqlCommand("User_del_by_user", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add("@username", SqlDbType.NVarChar, 30).Value = userid;
                cmd.Parameters.Add("@pass", SqlDbType.NVarChar, 15).Value = pass;


                cmd.Parameters.Add("@output", SqlDbType.Int).Direction = ParameterDirection.Output;

                cmd.ExecuteNonQuery();
                result = Convert.ToInt32(cmd.Parameters["@output"].Value);
            }

            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error" + ex.Message.ToString());
                result = -1; //-1 will be interpreted as "error while connecting with the database."
            }
            finally
            {
                con.Close();
            }
            return result;
        }
        public static int check_usertodelete(string userId) //Admin panel
        {

            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand cmd;
            int result = 0;

            try
            {
                cmd = new SqlCommand("User_del", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add("@username", SqlDbType.NVarChar, 30).Value = userId;


                cmd.Parameters.Add("@output", SqlDbType.Int).Direction = ParameterDirection.Output;

                cmd.ExecuteNonQuery();
                result = Convert.ToInt32(cmd.Parameters["@output"].Value);
            }

            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error" + ex.Message.ToString());
                result = -1; //-1 will be interpreted as "error while connecting with the database."
            }
            finally
            {
                con.Close();
            }
            return result;
        }
        public static int Login(string userId, string password)
        {

            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand cmd;
            int result = 0;

            try
            {
                cmd = new SqlCommand("Loginn", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add("@id", SqlDbType.NVarChar, 30).Value = userId;
                cmd.Parameters.Add("@pin", SqlDbType.NVarChar, 30).Value = password;


                cmd.Parameters.Add("@output", SqlDbType.Int).Direction = ParameterDirection.Output;

                cmd.ExecuteNonQuery();
                result = Convert.ToInt32(cmd.Parameters["@output"].Value);
            }

            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error" + ex.Message.ToString());
                result = -1; //-1 will be interpreted as "error while connecting with the database."
            }
            finally
            {
                con.Close();
            }
            return result;
        }
        public static int signup(String fnamename, String lnamename, String phonenoname, String unamename, String dobname, String countryname, String gender, String emailname, String passwordname)
        {
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand cmd;
            int result = 0;

            try
            { 
                cmd = new SqlCommand("Users_ADD", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add("@id", SqlDbType.NVarChar, 30).Value = unamename;
                cmd.Parameters.Add("@fn", SqlDbType.NVarChar, 30).Value = fnamename;
                cmd.Parameters.Add("@ln", SqlDbType.NVarChar, 30).Value = lnamename;
                cmd.Parameters.Add("@gen", SqlDbType.Char).Value = gender;
                cmd.Parameters.Add("@pin", SqlDbType.NVarChar, 15).Value = passwordname;
                cmd.Parameters.Add("@country", SqlDbType.NVarChar, 15).Value = countryname;
                cmd.Parameters.Add("@dob", SqlDbType.NVarChar, 50).Value = dobname;
                cmd.Parameters.Add("@email", SqlDbType.NVarChar, 25).Value = emailname;
                cmd.Parameters.Add("@phoneno", SqlDbType.NVarChar, 30).Value = phonenoname;

                cmd.Parameters.Add("@output", SqlDbType.Int).Direction = ParameterDirection.Output;

                cmd.ExecuteNonQuery();
                result = Convert.ToInt32(cmd.Parameters["@output"].Value);
            }

            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error" + ex.Message.ToString());
                result = -1; //-1 will be interpreted as "error while connecting with the database."
            }
            finally
            {
                con.Close();
            }
            return result;
        }
        public static List<Watchlist> getwatch_m(string id)
        {
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand cmd;

            try
            {
                cmd = new SqlCommand("getwatch_m", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add("@id", SqlDbType.NVarChar, 30).Value = id;
                SqlDataReader rdr = cmd.ExecuteReader();

                List<Watchlist> list = new List<Watchlist>();
                while (rdr.Read())
                {
                    Watchlist movi = new Watchlist();

                    movi.id = rdr["id"].ToString();
                    movi.title = rdr["title"].ToString();

                    list.Add(movi);
                }
                rdr.Close();
                con.Close();

                return list;
            }
            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error" + ex.Message.ToString());
                return null;

            }
        }
        public static int addwatch_m(string id,string mid)
        {
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand cmd;
            int result = 0;
            try
            {
                cmd = new SqlCommand("addwatch_m", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add("@uid", SqlDbType.NVarChar, 30).Value = id;
                cmd.Parameters.Add("@mid", SqlDbType.NVarChar, 30).Value = mid;

                cmd.Parameters.Add("@output", SqlDbType.Int).Direction = ParameterDirection.Output;

                cmd.ExecuteNonQuery();
                result = Convert.ToInt32(cmd.Parameters["@output"].Value);

                return result;
            }
            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error" + ex.Message.ToString());
                return -1;

            }
        }
        public static List<Watchlist> getwatch_t(string id)
        {
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand cmd;

            try
            {
                cmd = new SqlCommand("getwatch_t", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add("@id", SqlDbType.NVarChar, 30).Value = id;
                SqlDataReader rdr = cmd.ExecuteReader();

                List<Watchlist> list = new List<Watchlist>();
                while (rdr.Read())
                {
                    Watchlist movi = new Watchlist();

                    movi.id = rdr["id"].ToString();
                    movi.title = rdr["title"].ToString();

                    list.Add(movi);
                }
                rdr.Close();
                con.Close();

                return list;
            }
            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error" + ex.Message.ToString());
                return null;

            }
        }
        public static int addwatch_t(string id, string tid)
        {
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand cmd;
            int result = 0;
            try
            {
                cmd = new SqlCommand("addwatch_t", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add("@uid", SqlDbType.NVarChar, 30).Value = id;
                cmd.Parameters.Add("@tid", SqlDbType.NVarChar, 30).Value = tid;

                cmd.Parameters.Add("@output", SqlDbType.Int).Direction = ParameterDirection.Output;

                cmd.ExecuteNonQuery();
                result = Convert.ToInt32(cmd.Parameters["@output"].Value);

                return result;
            }
            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error" + ex.Message.ToString());
                return -1;

            }
        }
        public static int addmoviee(String _id, String _title, String _duration, String _release_date, String _genre, String _summary, String _rating, String _director)
        {
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand cmd;
            int result = 0;

            try
            {
                cmd = new SqlCommand("MOVIE_INSERT", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add("@id", SqlDbType.NVarChar, 30).Value = _id;
                cmd.Parameters.Add("@name", SqlDbType.NVarChar, 30).Value = _title;
                cmd.Parameters.Add("@duration", SqlDbType.NVarChar, 30).Value = _duration;
                cmd.Parameters.Add("@release", SqlDbType.Char).Value = _release_date;
                cmd.Parameters.Add("@genre", SqlDbType.NVarChar, 15).Value = _genre;
                cmd.Parameters.Add("@summary", SqlDbType.NVarChar, 300).Value = _summary;
                cmd.Parameters.Add("@rating", SqlDbType.NVarChar, 50).Value = _rating;
                cmd.Parameters.Add("@director", SqlDbType.NVarChar, 25).Value = _director;

                cmd.Parameters.Add("@output", SqlDbType.Int).Direction = ParameterDirection.Output;

                cmd.ExecuteNonQuery();
                result = Convert.ToInt32(cmd.Parameters["@output"].Value);
            }

            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error" + ex.Message.ToString());
                result = -1; //-1 will be interpreted as "error while connecting with the database."
            }
            finally
            {
                con.Close();
            }
            return result;
        }

        public static int deletemoviee(String _id)
        {
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand cmd;
            int result = 0;

            try
            {
                cmd = new SqlCommand("MOVIE_DELETE", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add("@id", SqlDbType.NVarChar, 30).Value = _id;

                cmd.Parameters.Add("@output", SqlDbType.Int).Direction = ParameterDirection.Output;

                cmd.ExecuteNonQuery();
                result = Convert.ToInt32(cmd.Parameters["@output"].Value);
            }

            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error" + ex.Message.ToString());
                result = -1; //-1 will be interpreted as "error while connecting with the database."
            }
            finally
            {
                con.Close();
            }
            return result;
        }


        public static int addtvshoww(String _id, String _title, String _noofseasons, String _release_date, String _genre, String _summary, String _rating, String _director)
        {
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand cmd;
            int result = 0;

            try
            {
                cmd = new SqlCommand("TVSHOW_INSERT", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add("@id", SqlDbType.NVarChar, 30).Value = _id;
                cmd.Parameters.Add("@name", SqlDbType.NVarChar, 30).Value = _title;
                cmd.Parameters.Add("@num_seasons", SqlDbType.NVarChar, 30).Value = _noofseasons;
                cmd.Parameters.Add("@release", SqlDbType.Char).Value = _release_date;
                cmd.Parameters.Add("@genre", SqlDbType.NVarChar, 15).Value = _genre;
                cmd.Parameters.Add("@summary", SqlDbType.NVarChar, 15).Value = _summary;
                cmd.Parameters.Add("@rating", SqlDbType.NVarChar, 50).Value = _rating;
                cmd.Parameters.Add("@director", SqlDbType.NVarChar, 25).Value = _director;

                cmd.Parameters.Add("@output", SqlDbType.Int).Direction = ParameterDirection.Output;

                cmd.ExecuteNonQuery();
                result = Convert.ToInt32(cmd.Parameters["@output"].Value);
            }

            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error" + ex.Message.ToString());
                result = -1; //-1 will be interpreted as "error while connecting with the database."
            }
            finally
            {
                con.Close();
            }
            return result;
        }

        public static int deletetvshoww(String _id, String _name)
        {
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand cmd;
            int result = 0;

            try
            {
                cmd = new SqlCommand("TVSHOW_DEL", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add("@id", SqlDbType.NVarChar, 30).Value = _id;
                cmd.Parameters.Add("@name", SqlDbType.NVarChar, 30).Value = _name;

                cmd.Parameters.Add("@output", SqlDbType.Int).Direction = ParameterDirection.Output;

                cmd.ExecuteNonQuery();
                result = Convert.ToInt32(cmd.Parameters["@output"].Value);
            }

            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error" + ex.Message.ToString());
                result = -1; //-1 will be interpreted as "error while connecting with the database."
            }
            finally
            {
                con.Close();
            }
            return result;
        }




        public static int addepisodee(String _id, String _tvshowid, String _title, String _duration, String _seasonno)
        {
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand cmd;
            int result = 0;

            try
            {
                cmd = new SqlCommand("epi_ADD", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add("@id", SqlDbType.NVarChar, 30).Value = _id;
                cmd.Parameters.Add("@tid", SqlDbType.NVarChar, 30).Value = _tvshowid;
                cmd.Parameters.Add("@t", SqlDbType.NVarChar, 30).Value = _title;
                cmd.Parameters.Add("@duration", SqlDbType.Char).Value = _duration;
                cmd.Parameters.Add("@s", SqlDbType.NVarChar, 15).Value = _seasonno;
                cmd.Parameters.Add("@output", SqlDbType.Int).Direction = ParameterDirection.Output;

                cmd.ExecuteNonQuery();
                result = Convert.ToInt32(cmd.Parameters["@output"].Value);
            }

            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error" + ex.Message.ToString());
                result = -1; //-1 will be interpreted as "error while connecting with the database."
            }
            finally
            {
                con.Close();
            }
            return result;
        }

        public static int deleteepisodee(String _id, String _sno)
        {
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand cmd;
            int result = 0;

            try
            {
                cmd = new SqlCommand("epi_del", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add("@id", SqlDbType.NVarChar, 30).Value = _id;
                cmd.Parameters.Add("@sno", SqlDbType.NVarChar, 30).Value = _sno;

                cmd.Parameters.Add("@output", SqlDbType.Int).Direction = ParameterDirection.Output;

                cmd.ExecuteNonQuery();
                result = Convert.ToInt32(cmd.Parameters["@output"].Value);
            }

            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error" + ex.Message.ToString());
                result = -1; //-1 will be interpreted as "error while connecting with the database."
            }
            finally
            {
                con.Close();
            }
            return result;
        }






        public static int addadminn(String idd, String uid)
        {
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand cmd;
            int result = 0;

            try
            {
                cmd = new SqlCommand("ADMIN_ADD", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add("@id", SqlDbType.NVarChar, 30).Value = idd;
                cmd.Parameters.Add("@uid", SqlDbType.NVarChar, 30).Value = uid;

                cmd.Parameters.Add("@output", SqlDbType.Int).Direction = ParameterDirection.Output;

                cmd.ExecuteNonQuery();
                result = Convert.ToInt32(cmd.Parameters["@output"].Value);
            }

            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error" + ex.Message.ToString());
                result = -1; //-1 will be interpreted as "error while connecting with the database."
            }
            finally
            {
                con.Close();
            }
            return result;
        }

        public static int deleteadminn(String _id, String _uid)
        {
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand cmd;
            int result = 0;

            try
            {
                cmd = new SqlCommand("ADMIN_DEL", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add("@id", SqlDbType.NVarChar, 30).Value = _id;
                cmd.Parameters.Add("@id", SqlDbType.NVarChar, 30).Value = _uid;

                cmd.Parameters.Add("@output", SqlDbType.Int).Direction = ParameterDirection.Output;

                cmd.ExecuteNonQuery();
                result = Convert.ToInt32(cmd.Parameters["@output"].Value);
            }

            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error" + ex.Message.ToString());
                result = -1; //-1 will be interpreted as "error while connecting with the database."
            }
            finally
            {
                con.Close();
            }
            return result;
        }






        public static int addgenree(String _id, String _category)
        {
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand cmd;
            int result = 0;

            try
            {
                cmd = new SqlCommand("GENRE_ADD", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add("@id", SqlDbType.NVarChar, 30).Value = _id;
                cmd.Parameters.Add("@cat", SqlDbType.NVarChar, 30).Value = _category;

                cmd.Parameters.Add("@output", SqlDbType.Int).Direction = ParameterDirection.Output;

                cmd.ExecuteNonQuery();
                result = Convert.ToInt32(cmd.Parameters["@output"].Value);
            }

            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error" + ex.Message.ToString());
                result = -1; //-1 will be interpreted as "error while connecting with the database."
            }
            finally
            {
                con.Close();
            }
            return result;
        }

        public static int deletegenree(String _id)
        {
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand cmd;
            int result = 0;

            try
            {
                cmd = new SqlCommand("GENRE_DELETE", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add("@id", SqlDbType.NVarChar, 30).Value = _id;

                cmd.Parameters.Add("@output", SqlDbType.Int).Direction = ParameterDirection.Output;

                cmd.ExecuteNonQuery();
                result = Convert.ToInt32(cmd.Parameters["@output"].Value);
            }

            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error" + ex.Message.ToString());
                result = -1; //-1 will be interpreted as "error while connecting with the database."
            }
            finally
            {
                con.Close();
            }
            return result;
        }


        public static int addactorr(String _id, String _name, String _gender, String _age)
        {
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand cmd;
            int result = 0;

            try
            {
                cmd = new SqlCommand("actor_ADD", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add("@id", SqlDbType.NVarChar, 30).Value = _id;
                cmd.Parameters.Add("@n", SqlDbType.NVarChar, 30).Value = _name;
                cmd.Parameters.Add("@g", SqlDbType.NVarChar, 30).Value = _gender;
                cmd.Parameters.Add("@age", SqlDbType.NVarChar, 30).Value = _age;

                cmd.Parameters.Add("@output", SqlDbType.Int).Direction = ParameterDirection.Output;

                cmd.ExecuteNonQuery();
                result = Convert.ToInt32(cmd.Parameters["@output"].Value);
            }

            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error" + ex.Message.ToString());
                result = -1; //-1 will be interpreted as "error while connecting with the database."
            }
            finally
            {
                con.Close();
            }
            return result;
        }


        public static int deleteactorr(String _id)
        {
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand cmd;
            int result = 0;

            try
            {
                cmd = new SqlCommand("actor_del", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add("@id", SqlDbType.NVarChar, 30).Value = _id;

                cmd.Parameters.Add("@output", SqlDbType.Int).Direction = ParameterDirection.Output;

                cmd.ExecuteNonQuery();
                result = Convert.ToInt32(cmd.Parameters["@output"].Value);
            }

            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error" + ex.Message.ToString());
                result = -1; //-1 will be interpreted as "error while connecting with the database."
            }
            finally
            {
                con.Close();
            }
            return result;
        }




        public static int addmovieactorr(String _id, String _movieid)
        {
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand cmd;
            int result = 0;

            try
            {
                cmd = new SqlCommand("supmovie_ADD", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add("@id", SqlDbType.NVarChar, 30).Value = _id;
                cmd.Parameters.Add("@actor", SqlDbType.NVarChar, 30).Value = _movieid;

                cmd.Parameters.Add("@output", SqlDbType.Int).Direction = ParameterDirection.Output;

                cmd.ExecuteNonQuery();
                result = Convert.ToInt32(cmd.Parameters["@output"].Value);
            }

            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error" + ex.Message.ToString());
                result = -1; //-1 will be interpreted as "error while connecting with the database."
            }
            finally
            {
                con.Close();
            }
            return result;
        }


        public static int deletemovieactorr(String _id, String _movieid)
        {
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand cmd;
            int result = 0;

            try
            {
                cmd = new SqlCommand("supmovie_del", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add("@id", SqlDbType.NVarChar, 30).Value = _id;
                cmd.Parameters.Add("@actor", SqlDbType.NVarChar, 30).Value = _movieid;

                cmd.Parameters.Add("@output", SqlDbType.Int).Direction = ParameterDirection.Output;

                cmd.ExecuteNonQuery();
                result = Convert.ToInt32(cmd.Parameters["@output"].Value);
            }

            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error" + ex.Message.ToString());
                result = -1; //-1 will be interpreted as "error while connecting with the database."
            }
            finally
            {
                con.Close();
            }
            return result;
        }



        public static int addtvshowactorr(String _id, String _movieid)
        {
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand cmd;
            int result = 0;

            try
            {
                cmd = new SqlCommand("supTV_ADD", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add("@id", SqlDbType.NVarChar, 30).Value = _id;
                cmd.Parameters.Add("@actor", SqlDbType.NVarChar, 30).Value = _movieid;

                cmd.Parameters.Add("@output", SqlDbType.Int).Direction = ParameterDirection.Output;

                cmd.ExecuteNonQuery();
                result = Convert.ToInt32(cmd.Parameters["@output"].Value);
            }

            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error" + ex.Message.ToString());
                result = -1; //-1 will be interpreted as "error while connecting with the database."
            }
            finally
            {
                con.Close();
            }
            return result;
        }


        public static int deletetvshowactorr(String _id, String _tvshowid)
        {
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand cmd;
            int result = 0;

            try
            {
                cmd = new SqlCommand("supTV_del", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add("@id", SqlDbType.NVarChar, 30).Value = _id;
                cmd.Parameters.Add("@tid", SqlDbType.NVarChar, 30).Value = _tvshowid;
                cmd.Parameters.Add("@output", SqlDbType.Int).Direction = ParameterDirection.Output;

                cmd.ExecuteNonQuery();
                result = Convert.ToInt32(cmd.Parameters["@output"].Value);
            }

            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error" + ex.Message.ToString());
                result = -1; //-1 will be interpreted as "error while connecting with the database."
            }
            finally
            {
                con.Close();
            }
            return result;
        }





        public static int adddirector(String _id, String _name, String _gender, String _age)
        {
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand cmd;
            int result = 0;

            try
            {
                cmd = new SqlCommand("Director_ADD", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add("@id", SqlDbType.NVarChar, 30).Value = _id;
                cmd.Parameters.Add("@n", SqlDbType.NVarChar, 30).Value = _name;
                cmd.Parameters.Add("@g", SqlDbType.NVarChar, 30).Value = _gender;
                cmd.Parameters.Add("@age", SqlDbType.NVarChar, 30).Value = _age;

                cmd.Parameters.Add("@output", SqlDbType.Int).Direction = ParameterDirection.Output;

                cmd.ExecuteNonQuery();
                result = Convert.ToInt32(cmd.Parameters["@output"].Value);
            }

            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error" + ex.Message.ToString());
                result = -1; //-1 will be interpreted as "error while connecting with the database."
            }
            finally
            {
                con.Close();
            }
            return result;
        }


        public static int deletedirector(String _id)
        {
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand cmd;
            int result = 0;

            try
            {
                cmd = new SqlCommand("Director_del", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add("@id", SqlDbType.NVarChar, 30).Value = _id;

                cmd.Parameters.Add("@output", SqlDbType.Int).Direction = ParameterDirection.Output;

                cmd.ExecuteNonQuery();
                result = Convert.ToInt32(cmd.Parameters["@output"].Value);
            }

            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error" + ex.Message.ToString());
                result = -1; //-1 will be interpreted as "error while connecting with the database."
            }
            finally
            {
                con.Close();
            }
            return result;
        }


    }
}