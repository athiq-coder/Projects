using System;
using System.Collections.Generic;

namespace Train_ticket_reservation
{ 

    class Seat
    {
        int no;

        public Seat(int no)
        {
            this.no = no;
           
        }

        public int getNo() { return this.no; }
    };

    class Compartment
    {
        string name;
        List<Seat> seats;
        int totalSeats;

        public Compartment(string name,int seats)
        {
            this.name = name;
            this.totalSeats = seats;
            this.seats = new List<Seat>(this.totalSeats);
        }

        public string getName() { return this.name; }

        public int getTotalSeats() { return this.totalSeats; }

    };

    class Train
    {
        string name;
        int no;
        List<Compartment> compartments;

        public Train(string name,int no)
        {
            this.name = name;
            this.no = no;
            this.compartments = new List<Compartment>();
        }

        public int getNo() { return this.no; }

        public string getName() { return this.name; }

        public int getTotalCompartments() { return this.compartments.Count; }

        public void addCompartment(Compartment compartment)
        {
            this.compartments.Add(compartment);
        }

        public void removeCompartment()
        {
            if(compartments.Count == 0)
            {
                return;
            }

            compartments.RemoveAt(compartments.Count - 1);
        }

    };

    class TrainDetails
    {
        Train train;
        string from;
        string to;
        string fromTime;
        string toTime;

        TrainDetails(Train train,string from,string to,string fromTime,string toTime)
        {
            this.train = train;
            this.from = from;
            this.to = to;
            this.fromTime = fromTime;
            this.toTime = toTime;
        }

        public void setTime(string fromTime,string toTime)
        {
            this.fromTime = fromTime;
            this.toTime = toTime;
        }

        public void setRoute(string from,string to)
        {
            this.from = from;
            this.to = to;
        }
    };

    class Admin
    {
        Dictionary<Train, TrainDetails> trains;
       

        Admin()
        {
            this.trains = new Dictionary<Train, TrainDetails>();
        }

        public void addTrain(Train train,TrainDetails trainDetails)
        {
            this.trains.Add(train,trainDetails);
        }

        public void removeTrain(Train train)
        {
            this.trains.Remove(train);
        }

        public void changeTime(Train train,string fromTime,string toTime)
        {
            this.trains[train].setTime(fromTime, toTime);
        }

        public void changeRoute(Train train,string from,string to)
        {
            this.trains[train].setRoute(from, to);
        }
    };

    class UserDetails
    {
        string name;
        int age;
        string dob;
        string email;
        string password;
        bool isAdmin;

        public UserDetails(string name,int age,string dob,string email,string password,bool isAdmin)
        {
            this.name = name;
            this.age = age;
            this.dob = dob;
            this.email = email;
            this.isAdmin = isAdmin;
        }

        public bool isAdministrator() { return this.isAdmin; }
       
        public string getEmail() { return this.email; }
        
        public string getPassword() { return this.password; }
       
    };

    class UserRegistration
    {
        static List<UserDetails> registeredUsers = new List<UserDetails>();
        static List<UserDetails> registeredAdmins = new List<UserDetails>();

        public UserRegistration() { }

        public void register(UserDetails user)
        {
            if (registeredUsers.Contains(user))
            {
                return;
            }

            if (user.isAdministrator())
            {
                registeredAdmins.Add(user);
                return;
            }
            registeredUsers.Add(user);
        }

        public bool isUser(string email,string password)
        {
           for(int i=0; i < registeredUsers.Count; i++)
            {
                if(registeredUsers[i].getEmail() == email && registeredUsers[i].getPassword() == password)
                {
                    return true;
                }
            }
            return false;
        }

        public bool isAdmin(string email,string password)
        {
            for (int i = 0; i < registeredAdmins.Count; i++)
            {
                if (registeredAdmins[i].getEmail() == email && registeredAdmins[i].getPassword() == password)
                {
                    return true;
                }
            }
            return false;
        }
    };

    class LoginScreen
    {
        UserRegistration allUsers;
        string email;
        string password;
        bool isValid;

        LoginScreen()
        {
            this.allUsers = new UserRegistration();
            this.isValid = false;
        }

        public void signIn(string email,string password)
        {
            if(this.allUsers.isUser(email,password))
            {
                this.isValid = true;
                return;
            }
        }

        public void signUp()

    };



    public enum Berth
    {
        window = 'W',
        middle = 'M',
        Aisle  = 'A'
    };
}
