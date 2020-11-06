using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work_Links {
    public class Group : IComparable<Group> {
        public string Name;
        public BindingList<Issue> issues = new BindingList<Issue>();

        public Group(string name) {
            this.Name = name;
        }

        public void addIssue(Issue issue) {
            issues.Add(issue);
            sortIssues();
        }

        public void removeIssue(int index) {
            issues.RemoveAt(index);
        }

        public void sortIssues() {
            quickSort(0, issues.Count - 1);
        }

        private void quickSort(int low, int high) {
            int i = low;
            int j = high;

            Issue pivot = issues[low + (high - low) / 2];

            while(i <= j) {
                while(issues[i].CompareTo(pivot) < 0) {
                    i++;
                }

                while(issues[j].CompareTo(pivot) > 0) {
                    j--;
                }

                if(i <= j) {
                    Issue tempSwap = issues[i];
                    issues[i] = issues[j];
                    issues[j] = tempSwap;

                    i++;
                    j--;
                }
            }

            if(low < j) {
                quickSort(low, j);
            }
            if(i < high) {
                quickSort(i, high);
            }
        }

        public override string ToString() {
            return Name;
        }

        public int CompareTo(Group other) {
            return Name.CompareTo(other.Name);
        }
    }
}
