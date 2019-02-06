using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CoreDemo.Models {
    public class Actor {
        private int _ID;
        private string _Name;
        private string _Title;
        private HairColors _HairColor;
        public enum HairColors {
            Brown,
            Blonde,
            White,
            Black,
            Red
        }

        [Key]
        public int ID {
            get { return _ID; }
            set { _ID = value; }
        }


        public string Name {
            get { return _Name; }
            set { _Name = value; }
        }

        [Display(Name ="Character Title",
            Description ="What other awesome words to describe this actor.")]
        public string Title {
            get { return _Title; }
            set { _Title = value; }
        }

        [Display(Name = "Hair Color")]
        public HairColors HairColor {
            get { return _HairColor; }
            set { _HairColor = value; }
        }

        private int _SomeValue;
        [Range(0,100,ErrorMessage ="Value should be between 0 and 50")]
        public int SomeValue {
            get { return _SomeValue; }
            set { _SomeValue = value; }
        }


    }
}
