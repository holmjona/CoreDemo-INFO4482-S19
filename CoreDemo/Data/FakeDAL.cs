using CoreDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.Data {
    public static class FakeDAL {
        public static List<Actor> Actors = new List<Actor>() {
            new Actor() { ID = 48, Name = "Bob", Title = "the Awesome" },
            new Actor() { ID = 2, Name = "Freak", Title = "Monkey" },
            new Actor() { ID = 3, Name = "Doom", Title = "Slayer", HairColor = Actor.HairColors.Blonde },
            new Actor() { ID = 4, Name = "Stabby", Title = "McStabberson" },
            new Actor() { ID = 5, Name = "Jane", Title = "Doe" }
        };
    }
}
