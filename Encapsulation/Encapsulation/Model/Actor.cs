using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsulation.Model
{
    class Actor
    {
        private int ActorId;
        private string Name;
        private int NoOffilmsActed;
        private int Experience;
        private string FavroiteFood;

        public int actorId
        {
             get { return ActorId; }
            set { ActorId = value; }
        }
        public string name 
        {
            get { return Name;}
            set { Name = value; }
        
        }
        public int nooffilmsacted
        {
            get { return NoOffilmsActed; }
            set { NoOffilmsActed = value; }
        }
        public  int experience
        {
            get { return Experience; }
            set { Experience = value; }
        }
        public string favoritefood
        {
            get { return FavroiteFood; }
            set { FavroiteFood = value; }
        }

        //by using this we can the the all the data without using number of  consoles
        // we can access the data in single override class
        public override string ToString()
        {
            return "\nActorId:" + actorId + "\nName:" + name + "\nNoOfFilmsActed:" + nooffilmsacted +
                         "\nExperience:" + experience + "\nFavoriteFood:" + favoritefood ;
        }
    }
    }

 