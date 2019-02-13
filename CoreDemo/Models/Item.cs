using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.Models {
    /// <summary>
    ///  Things that actors can use.
    /// </summary>
    public class Item :DatabaseNamedObject {
        
        private string _Name;

        public string Name { get => _Name; set => _Name = value; }
    }
}
