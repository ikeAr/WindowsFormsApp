using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Repository;
using Service;

namespace WindowsFormsApp1
{

    public partial class UserForm : Form
    {
        private Manage newManage = new Manage();
        private EditMode model;
        private UserModel user;
        public UserForm(UserModel user, EditMode model)
        {
            InitializeComponent();
            this.user = user ?? new UserModel();
            this.model = model;
            InitializeData();

        }
        private void InitializeData()
        {
            if (this.model == EditMode.View)
            {
                this.ClassId.ReadOnly = true;
                this.ClassName.ReadOnly = true;
                this.Name.ReadOnly = true;
                this.Credits.ReadOnly = true;
                this.Gender.ReadOnly = true;
                this.Team.ReadOnly = true;
                this.GitHub.ReadOnly = true;
            }
         
                this.ClassId.Text = this.user.ClassId;
                this.ClassName.Text = this.user.ClassName;
                this.Name.Text = this.user.Name;
                this.Credits.Text = this.user.Credits.ToString();
                this.Gender.Text = this.user.Gender;
                this.Team.Text = this.user.Team;
                this.GitHub.Text = this.user.GitHub;
            

        }

        private void Submit_Click(object sender, EventArgs e)
        {
            if (model == EditMode.Create)
            {
                this.user.ClassId = this.ClassId.Text;
                this.user.ClassName = this.ClassName.Text;
                this.user.Credits = Convert.ToInt32(this.Credits.Text);
                this.user.Name = this.Name.Text;
                this.user.Gender = this.Gender.Text;
                this.user.Team = this.Team.Text;
                this.user.GitHub = this.GitHub.Text;
                this.newManage.AddUser(this.user);
                MessageBox.Show("恭喜你，添加成功");
                this.Close();

            }
            else if (model == EditMode.Edit)
            {
                this.user.ClassId = this.ClassId.Text;
                this.user.ClassName = this.ClassName.Text;
                this.user.Credits = Convert.ToInt32(this.Credits.Text);
                this.user.Name = this.Name.Text;
                this.user.Gender = this.Gender.Text;
                this.user.Team = this.Team.Text;
                this.user.GitHub = this.GitHub.Text;
                this.newManage.UpdateUser(this.user);
                MessageBox.Show("恭喜你，更新成功");
                this.Close();
            }
            else if (model == EditMode.View)
            {
                return;
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}