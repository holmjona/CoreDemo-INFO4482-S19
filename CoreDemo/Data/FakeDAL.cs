using CoreDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.Data {
    public static class FakeDAL {
        private static List<Actor> _Actors = new List<Actor>() {
            new Actor() { ID = 48, Name = "Bob", Title = "the Awesome" },
            new Actor() { ID = 2, Name = "Freak", Title = "Monkey" },
            new Actor() { ID = 3, Name = "Doom", Title = "Slayer", HairColor = Actor.HairColors.Blonde },
            new Actor() { ID = 4, Name = "Stabby", Title = "McStabberson" },
            new Actor() { ID = 5, Name = "Jane", Title = "Doe" }
        };

        public static List<Actor> GetActors() {
            return _Actors;
        }

        public static Actor GetActor(int actorID) {
            return _Actors.First(a => a.ID == actorID);
        }


        public static int Add(Actor a) {
            if (a != null) {
                a.ID = _Actors.Max(aa => aa.ID) + 1;
                _Actors.Add(a);
                return 1;
            }
            return -1;
        }

        public static int Edit(Actor a) {
            Actor a2Edit = _Actors.First(aa => aa.ID == a.ID) ;
            if (a2Edit != null) {
                a2Edit.Name = a.Name;
                a2Edit.Title = a.Title;
                a2Edit.HairColor = a.HairColor;
                return 1;
            }
            return -1;
        }



    }
}
