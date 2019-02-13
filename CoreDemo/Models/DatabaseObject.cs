using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.Models {
    public abstract class DatabaseObject {
        private int _ID;

        [Key]
        public int ID {
            get { return _ID; }
            set { _ID = value; }
        }

    }
}
