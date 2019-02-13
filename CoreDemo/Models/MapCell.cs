using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.Models {
    public class MapCell : DatabaseObject {
        
        private bool _IsFound;
        

        public bool IsFound {
            get { return _IsFound; }
            set { _IsFound = value; }
        }

    }
}
