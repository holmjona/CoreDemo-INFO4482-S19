using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CoreDemo.Models {
    /// <summary>
    /// Objects that interact with the game
    /// </summary>
    public class Actor : DatabaseNamedObject {


        private string _Title;
        private HairColors _HairColor;
        public enum HairColors {
            Brown,
            Blonde,
            White,
            Black,
            Red
        }



        [Display(Name = "Character Title",
            Description = "What other awesome words to describe this actor.")]
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
        [Range(0, 100, ErrorMessage = "Value should be between 0 and 50")]
        public int SomeValue {
            get { return _SomeValue; }
            set { _SomeValue = value; }
        }
        // Foreign key
        private int _ItemID;

        public int ItemID {
            get { return _ItemID; }
          private  set { _ItemID = value; }
        }


        private Item _Weapon;

        public Item Weapon {
            get {
                if(_Weapon == null) {
                    _Weapon = FakeDAL.GetWeapon(_ItemID);
                }
                return _Weapon;
            }
            set {
                if(value == null) {
                    _ItemID = -1;
                } else {
                    _ItemID = value.ID;
                }
                _Weapon = value;
            }
        }



    }
}
