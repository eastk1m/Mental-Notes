using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MentalNotesNew.Model;

//instatiate data source it's just a class right now 

//now you have data // mock data 

namespace MentalNotesNew.Data

//mock datasource list of users and notifications

{
    internal class Datasource
    {
        public static List<User> UserList;
        public static List<Notification> NotificationList;

        //create a method called CreateData that is public

        public static void CreateData()
        {
            //inside here take user list

            UserList = new List<User>()
            {
                 new User() { Username = "ekim", Password = "password123", FirstName = "Esther", LastName = "Kim" },
                 new User() { Username = "jdevries", Password = "password123", FirstName = "John", LastName = "DeVries" },
                 new User() { Username = "jdevries", Password = "password123", FirstName = "John", LastName = "DeVries" }
            };

            NotificationList = new List<Notification>()
            //title, created, scheduled - dateTime is the type of data - to do item
            // time stamp when created
            // notification should be a due date time 
            // when it was created + when it is scheduled to go off 
            // details ?? modify model to add the property so you can add strings or images 
            // modeled after the remindme! in reddit / outlook calendar / notes app in apple 

            //popping up notifications when it is not running
            // add a calendar for data entry - fundamental issue is going to be how do I notify a User from an app that isn't running 
            // to do list type thing 

            {
                new Notification() { Title = "Time to sleep", Created = DateTime.Now, Scheduled = DateTime.Now},
                new Notification() { Title = "Time to do homework", Created = DateTime.Now, Scheduled = DateTime.Now},
                new Notification() { Title = "Test day", Created = DateTime.Now, Scheduled = DateTime.Now},


            };

            //collection view page to show notifications on the main page = next step 
            //add collection view to the main page, set it up so that it can bind to the notification list 



        }

    }
}
