using System;
using System.Drawing;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace King_Land
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private Guna2Panel panelSidebar;
        private Guna2Panel panelLogo;
        private Label lblAppTitle;
        private Guna2ToggleSwitch toggleTheme;
        private Guna2Button btnDashboard;
        private Guna2Button btnManagement;
        private Guna2Panel panelManagementSubmenu;
        private Guna2Button btnCompany;
        private Guna2Button btnProduct;
        private Guna2Button btnProject;
        private Guna2Button btnUsers;
        private Guna2Button btnWorkflow;
        private Guna2Button btnLogout;
        private Guna2Panel panelMain;

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
            this.components = new System.ComponentModel.Container();
            this.panelSidebar = new Guna2Panel();
            this.panelLogo = new Guna2Panel();
            this.lblAppTitle = new Label();
            this.toggleTheme = new Guna2ToggleSwitch();
            this.btnDashboard = new Guna2Button();
            this.btnManagement = new Guna2Button();
            this.panelManagementSubmenu = new Guna2Panel();
            this.btnCompany = new Guna2Button();
            this.btnProduct = new Guna2Button();
            this.btnProject = new Guna2Button();
            this.btnUsers = new Guna2Button();
            this.btnWorkflow = new Guna2Button();
            this.btnLogout = new Guna2Button();
            this.panelMain = new Guna2Panel();
            this.panelSidebar.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panelManagementSubmenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSidebar
            // 
            this.panelSidebar.BackColor = Color.White;
            this.panelSidebar.FillColor = Color.White;
            this.panelSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSidebar.Location = new System.Drawing.Point(0, 0);
            this.panelSidebar.Name = "panelSidebar";
            this.panelSidebar.Size = new System.Drawing.Size(240, 800);
            this.panelSidebar.TabIndex = 0;
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = Color.Transparent;
            this.panelLogo.FillColor = Color.Transparent;
            this.panelLogo.Controls.Add(this.lblAppTitle);
            this.panelLogo.Controls.Add(this.toggleTheme);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(240, 80);
            this.panelLogo.TabIndex = 0;
            // 
            // lblAppTitle
            // 
            this.lblAppTitle.AutoSize = true;
            this.lblAppTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppTitle.ForeColor = System.Drawing.Color.Black;
            this.lblAppTitle.Location = new System.Drawing.Point(16, 24);
            this.lblAppTitle.Name = "lblAppTitle";
            this.lblAppTitle.Size = new System.Drawing.Size(119, 30);
            this.lblAppTitle.TabIndex = 0;
            this.lblAppTitle.Text = "KingLand";
           
            // 
            // btnDashboard
            // 
            this.btnDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDashboard.Text = "  Dashboard";
            this.btnDashboard.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDashboard.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.TabIndex = 1;
            this.btnDashboard.FillColor = Color.Black;
            this.btnDashboard.ForeColor = Color.White;
            this.btnDashboard.Size = new System.Drawing.Size(240, 48);
            this.btnDashboard.BorderRadius = 6;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // btnManagement
            // 
            this.btnManagement.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnManagement.Text = "  Management";
            this.btnManagement.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnManagement.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.btnManagement.Name = "btnManagement";
            this.btnManagement.TabIndex = 2;
            this.btnManagement.FillColor = Color.White;
            this.btnManagement.ForeColor = Color.Black;
            this.btnManagement.Size = new System.Drawing.Size(240, 44);
            this.btnManagement.BorderRadius = 6;
            this.btnManagement.Click += new System.EventHandler(this.btnManagement_Click);
            // 
            // panelManagementSubmenu
            // 
            this.panelManagementSubmenu.BackColor = Color.White;
            this.panelManagementSubmenu.FillColor = Color.White;
            this.panelManagementSubmenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelManagementSubmenu.Location = new System.Drawing.Point(0, 0);
            this.panelManagementSubmenu.Name = "panelManagementSubmenu";
            this.panelManagementSubmenu.Size = new System.Drawing.Size(240, 0);
            this.panelManagementSubmenu.TabIndex = 3;
            this.panelManagementSubmenu.Visible = false;
            // 
            // btnCompany
            // 
            this.btnCompany.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCompany.Text = "    Company";
            this.btnCompany.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnCompany.Padding = new System.Windows.Forms.Padding(32, 0, 0, 0);
            this.btnCompany.Name = "btnCompany";
            this.btnCompany.TabIndex = 4;
            this.btnCompany.FillColor = Color.White;
            this.btnCompany.ForeColor = Color.Black;
            this.btnCompany.Size = new System.Drawing.Size(240, 40);
            this.btnCompany.Click += new System.EventHandler(this.btnCompany_Click);
            // 
            // btnProduct
            // 
            this.btnProduct.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProduct.Text = "    Product";
            this.btnProduct.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnProduct.Padding = new System.Windows.Forms.Padding(32, 0, 0, 0);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.TabIndex = 5;
            this.btnProduct.FillColor = Color.White;
            this.btnProduct.ForeColor = Color.Black;
            this.btnProduct.Size = new System.Drawing.Size(240, 40);
            this.btnProduct.Click += new System.EventHandler(this.btnProduct_Click);
            // 
            // btnProject
            // 
            this.btnProject.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProject.Text = "    Project";
            this.btnProject.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnProject.Padding = new System.Windows.Forms.Padding(32, 0, 0, 0);
            this.btnProject.Name = "btnProject";
            this.btnProject.TabIndex = 6;
            this.btnProject.FillColor = Color.White;
            this.btnProject.ForeColor = Color.Black;
            this.btnProject.Size = new System.Drawing.Size(240, 40);
            this.btnProject.Click += new System.EventHandler(this.btnProject_Click);
            // 
            // btnUsers
            // 
            this.btnUsers.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUsers.Text = "    Users";
            this.btnUsers.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnUsers.Padding = new System.Windows.Forms.Padding(32, 0, 0, 0);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.TabIndex = 7;
            this.btnUsers.FillColor = Color.White;
            this.btnUsers.ForeColor = Color.Black;
            this.btnUsers.Size = new System.Drawing.Size(240, 40);
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            // 
            // btnWorkflow
            // 
            this.btnWorkflow.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnWorkflow.Text = "    Workflow Templates";
            this.btnWorkflow.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnWorkflow.Padding = new System.Windows.Forms.Padding(32, 0, 0, 0);
            this.btnWorkflow.Name = "btnWorkflow";
            this.btnWorkflow.TabIndex = 8;
            this.btnWorkflow.FillColor = Color.White;
            this.btnWorkflow.ForeColor = Color.Black;
            this.btnWorkflow.Size = new System.Drawing.Size(240, 40);
            this.btnWorkflow.Click += new System.EventHandler(this.btnWorkflow_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogout.Text = "Logout";
            this.btnLogout.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnLogout.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.TabIndex = 9;
            this.btnLogout.FillColor = Color.White;
            this.btnLogout.ForeColor = Color.Black;
            this.btnLogout.Size = new System.Drawing.Size(240, 48);
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // panelMain
            // 
            this.panelMain.FillColor = System.Drawing.Color.White;
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(240, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(880, 800);
            this.panelMain.TabIndex = 1;
            // 
            // assemble sidebar hierarchy
            // 
            this.panelManagementSubmenu.Controls.Add(this.btnWorkflow);
            this.panelManagementSubmenu.Controls.Add(this.btnUsers);
            this.panelManagementSubmenu.Controls.Add(this.btnProject);
            this.panelManagementSubmenu.Controls.Add(this.btnProduct);
            this.panelManagementSubmenu.Controls.Add(this.btnCompany);
            this.panelSidebar.Controls.Add(this.btnLogout);
            this.panelSidebar.Controls.Add(this.panelManagementSubmenu);
            this.panelSidebar.Controls.Add(this.btnManagement);
            this.panelSidebar.Controls.Add(this.btnDashboard);
            this.panelSidebar.Controls.Add(this.panelLogo);
            // 
            // Main (form)
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(251)))));
            this.ClientSize = new System.Drawing.Size(1120, 800);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelSidebar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = true;
            this.MinimizeBox = true;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KingLand Management";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Main_Load);
            this.panelManagementSubmenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            this.panelSidebar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
    }
}