using System.Windows.Forms;

namespace ManageCash_Desktop.Administration {
    public partial class FrmRoles : Form {
        
        public FrmRoles() {
            InitializeComponent();
            DGV_Roles = SetDataGridView();
        }

        private void BtnAdd_Click(object sender, System.EventArgs e) {
            Program.Roles = Program.Types.Add;
        }

        private DataGridView SetDataGridView(dynamic _model) {
            Program.DataGridView = new DataGridView();
            foreach(var l in _model.Cols) {
                Program.DataGridView.Columns.Add(l.ColName, l.header);
            }
            
            Program.DataGridView.Columns.Add("RoleName", "");
            foreach(var l in _model.List) {
                Program.DataGridView.Rows.Add("", "");
            }
            return Program.DataGridView;
        }
    }
}