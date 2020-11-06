using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work_Links {
    public class Link : IComparable<Link> {
        public string name;
        public string path;

        public Link(string name, string path) {
            this.name = name;
            this.path = path;
        }

        public int CompareTo(Link other) {
            return name.CompareTo(other.name);
        }

        public override string ToString() {
            return name;
        }
    }
}
