using ManageCash_Desktop.Administration;
using System;
using System.Windows.Forms;

namespace ManageCash_Desktop {
    static class Program {
        /// <summary>
        /// This param 
        /// </summary>
        public static Types Roles { get; internal set; }
        public static Language Lang { get; internal set; }
        public static DataGridView DataGridView;

        public enum Types {
            Add,
            Upd
        }
        public enum Language {
            English,
            Spanish
        }
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmRoles());
        }
    }
}