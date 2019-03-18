using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Service;
using Repository;
namespace WindowsFormsApp1
{

    public partial class MainForm : Form
    {
        Manage newManage = new Manage();
        public MainForm()
        {
            InitializeComponent();
        }
        private void allUser_Click(object sender, EventArgs e)
        {
            var allUser = newManage.GetAllUser();
            this.dataGridView1.DataSource = allUser;
        }

        private void addUser_Click(object sender, EventArgs e)
        {
            var userForm = new UserForm(new UserModel(), EditMode.Create);
            userForm.Show();
        }

        private void deleteUser_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.SelectedRows.Count < 1) { return; }
            var currrentName = (string)this.dataGridView1.SelectedRows[0].Cells["Name"].Value;
            var confirmResult = MessageBox.Show("你确定要删除这位成员么", "删除成员", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
            if (confirmResult == DialogResult.Yes)
            {
                this.newManage.DeleteUser(currrentName);
                var allUser = newManage.GetAllUser();
                this.dataGridView1.DataSource = allUser;
            }
        }

        private void updateUser_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.SelectedRows.Count < 1) { return; }
            var currentName = (string)this.dataGridView1.SelectedRows[0].Cells["Name"].Value;
            var infoUser = this.newManage.FindUser(currentName);
            var userForm = new UserForm(infoUser, EditMode.Edit);
          
            userForm.Show();
        }

        private void findUser_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.SelectedRows.Count < 1) { return; }
            var currentName=(string)this.dataGridView1.SelectedRows[0].Cells["Name"].Value;
            var infoUser = this.newManage.FindUser(currentName);
            var userForm = new UserForm(infoUser, EditMode.View);
            userForm.ShowDialog();
        }
    }
}
