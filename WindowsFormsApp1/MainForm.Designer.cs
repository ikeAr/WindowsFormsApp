namespace WindowsFormsApp1
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.allUser = new System.Windows.Forms.Button();
            this.addUser = new System.Windows.Forms.Button();
            this.deleteUser = new System.Windows.Forms.Button();
            this.updateUser = new System.Windows.Forms.Button();
            this.findUser = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // allUser
            // 
            this.allUser.Location = new System.Drawing.Point(65, 51);
            this.allUser.Name = "allUser";
            this.allUser.Size = new System.Drawing.Size(124, 46);
            this.allUser.TabIndex = 0;
            this.allUser.Text = "查看所有用户";
            this.allUser.UseVisualStyleBackColor = true;
            this.allUser.Click += new System.EventHandler(this.allUser_Click);
            // 
            // addUser
            // 
            this.addUser.Location = new System.Drawing.Point(218, 53);
            this.addUser.Name = "addUser";
            this.addUser.Size = new System.Drawing.Size(104, 42);
            this.addUser.TabIndex = 1;
            this.addUser.Text = "添加用户";
            this.addUser.UseVisualStyleBackColor = true;
            this.addUser.Click += new System.EventHandler(this.addUser_Click);
            // 
            // deleteUser
            // 
            this.deleteUser.Location = new System.Drawing.Point(350, 53);
            this.deleteUser.Name = "deleteUser";
            this.deleteUser.Size = new System.Drawing.Size(92, 43);
            this.deleteUser.TabIndex = 2;
            this.deleteUser.Text = "删除用户";
            this.deleteUser.UseVisualStyleBackColor = true;
            this.deleteUser.Click += new System.EventHandler(this.deleteUser_Click);
            // 
            // updateUser
            // 
            this.updateUser.Location = new System.Drawing.Point(492, 57);
            this.updateUser.Name = "updateUser";
            this.updateUser.Size = new System.Drawing.Size(104, 37);
            this.updateUser.TabIndex = 3;
            this.updateUser.Text = "修改用户";
            this.updateUser.UseVisualStyleBackColor = true;
            this.updateUser.Click += new System.EventHandler(this.updateUser_Click);
            // 
            // findUser
            // 
            this.findUser.Location = new System.Drawing.Point(630, 57);
            this.findUser.Name = "findUser";
            this.findUser.Size = new System.Drawing.Size(102, 38);
            this.findUser.TabIndex = 4;
            this.findUser.Text = "寻找用户";
            this.findUser.UseVisualStyleBackColor = true;
            this.findUser.Click += new System.EventHandler(this.findUser_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(69, 140);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(675, 302);
            this.dataGridView1.TabIndex = 5;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.findUser);
            this.Controls.Add(this.updateUser);
            this.Controls.Add(this.deleteUser);
            this.Controls.Add(this.addUser);
            this.Controls.Add(this.allUser);
            this.Name = "MainForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button allUser;
        private System.Windows.Forms.Button addUser;
        private System.Windows.Forms.Button deleteUser;
        private System.Windows.Forms.Button updateUser;
        private System.Windows.Forms.Button findUser;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

