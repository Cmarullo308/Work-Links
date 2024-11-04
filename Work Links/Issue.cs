using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work_Links {
    public class Issue : IComparable<Issue> {
        public string name { get; set; }
        public List<string> tags { get; set; }
        public Guid idNumber { get; set; }
        public string textBoxText { get; set; }
        public BindingList<Link> links = new BindingList<Link>();
        public bool locked { get; set; } = false;

        public Issue(string name, List<String> tags) {
            this.name = name;
            this.tags = tags;
            idNumber = Guid.NewGuid();
        }

        public int CompareTo(Issue other) {
            return name.CompareTo(other.name);
        }

        public void sortLinks() {
            quickSortLinks(0, links.Count - 1);
        }

        private void quickSortLinks(int low, int high) {
            int i = low;
            int j = high;

            Link pivot = links[low + (high - low) / 2];

            while (i <= j) {
                while (links[i].CompareTo(pivot) < 0) {
                    i++;
                }

                while (links[j].CompareTo(pivot) > 0) {
                    j--;
                }

                if (i <= j) {
                    Link tempSwap = links[i];
                    links[i] = links[j];
                    links[j] = tempSwap;

                    i++;
                    j--;
                }
            }

            if (low < j) {
                quickSortLinks(low, j);
            }
            if (i < high) {
                quickSortLinks(i, high);
            }
        }

        public override string ToString() {
            return name;
        }
    }
}
