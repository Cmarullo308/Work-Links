using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work_Links {
    public class GroupData {
        private BindingList<Group> groups = new BindingList<Group>();

        public GroupData() {

        }

        public bool groupExists(string name) {
            foreach (Group group in groups) {
                if (group.Name.Equals(name)) {
                    return true;
                }
            }

            return false;
        }

        public void setGroups(BindingList<Group> groups) {
            this.groups = groups;
        }

        public Group groupFromIndex(int index) {
            if(index < 0) {
                return null;
            }

            return groups[index];
        }

        public BindingList<Group> getGroups() {
            return groups;
        }

        public void addGroup(Group newGroup) {
            groups.Add(newGroup);
            sortGroups();
        }

        public void removeGroupAt(int index) {
            groups.RemoveAt(index);
        }

        public void sortGroups() {
            quickSortGroups(0, groups.Count - 1);
        }

        private void quickSortGroups(int low, int high) {
            int i = low;
            int j = high;

            Group pivot = groups[low + (high - low) / 2];

            while (i <= j) {
                while (groups[i].CompareTo(pivot) < 0) {
                    i++;
                }

                while (groups[j].CompareTo(pivot) > 0) {
                    j--;
                }

                if (i <= j) {
                    Group tempSwap = groups[i];
                    groups[i] = groups[j];
                    groups[j] = tempSwap;

                    i++;
                    j--;
                }
            }

            if (low < j) {
                quickSortGroups(low, j);
            }
            if (i < high) {
                quickSortGroups(i, high);
            }
        }
    }
}
