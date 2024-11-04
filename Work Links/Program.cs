using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;
using Work_Links.Windows;

namespace Work_Links {
    static class Program {
        public static MainWindow mainWindow;
        public static string version = "1.1";

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            bool exists = System.Diagnostics.Process.GetProcessesByName(System.IO.Path.GetFileNameWithoutExtension(System.Reflection.Assembly.GetEntryAssembly().Location)).Count() > 1;

            if (exists) {
                Application.Exit();
                new AlreadyAnInstanceWindow().ShowDialog();
                return;
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            mainWindow = new MainWindow();
            Application.Run(mainWindow);
        }

        public static void saveData() {
            BindingList<Group> groups = mainWindow.groupData.getGroups();

            string serializedGroups = JsonConvert.SerializeObject(groups, Formatting.Indented);

            if (!Directory.Exists(@"Data")) {
                Directory.CreateDirectory(@"Data");
            }

            File.WriteAllText(@"Data\Groups.json", serializedGroups);
        }

        public static void loadFile() {
            BindingList<Group> groups = new BindingList<Group>();

            if (File.Exists(@"Data\Groups.json")) {
                string jsonResult = File.ReadAllText(@"Data\Groups.json");
                groups = JsonConvert.DeserializeObject<BindingList<Group>>(jsonResult);
            }

            mainWindow.groupData.setGroups(groups);
        }
    }
}
