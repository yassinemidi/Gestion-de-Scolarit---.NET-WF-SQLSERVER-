
namespace WindowsFormsApp1.Admin
{
    partial class AdminEtudiant
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.closebtn = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.Label();
            this.manageNiveau1 = new WindowsFormsApp1.Admin.ManageNiveau();
            this.listAbsenceEtudiant1 = new WindowsFormsApp1.Admin.ListAbsenceEtudiant();
            this.addEtudiant1 = new WindowsFormsApp1.Admin.AddEtudiant();
            this.listEtudiant1 = new WindowsFormsApp1.Admin.ListEtudiant();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(132)))), ((int)(((byte)(172)))));
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(233, 600);
            this.panel1.TabIndex = 0;
            // 
            // button5
            // 
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(0, 1);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(37, 48);
            this.button5.TabIndex = 6;
            this.button5.Text = "<";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(140, 552);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 21);
            this.label4.TabIndex = 1;
            this.label4.Text = "ENSAS";
            this.label4.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(69, 531);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 21);
            this.label3.TabIndex = 1;
            this.label3.Text = "Developper par:";
            this.label3.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 34);
            this.label1.TabIndex = 1;
            this.label1.Text = "Dashboard";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(87)))), ((int)(((byte)(126)))));
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(0, 410);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(233, 80);
            this.button4.TabIndex = 0;
            this.button4.Text = "Gestion des niveaux ";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(87)))), ((int)(((byte)(126)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(0, 330);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(233, 80);
            this.button3.TabIndex = 0;
            this.button3.Text = "Liste d\'absence";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(87)))), ((int)(((byte)(126)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(0, 250);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(233, 80);
            this.button2.TabIndex = 0;
            this.button2.Text = "Ajouter un Etudiant";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(87)))), ((int)(((byte)(126)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(0, 170);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(233, 80);
            this.button1.TabIndex = 0;
            this.button1.Text = "Liste Des Etudiants";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(132)))), ((int)(((byte)(172)))));
            this.panel2.Controls.Add(this.closebtn);
            this.panel2.Controls.Add(this.title);
            this.panel2.Location = new System.Drawing.Point(233, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(900, 58);
            this.panel2.TabIndex = 1;
            // 
            // closebtn
            // 
            this.closebtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closebtn.FlatAppearance.BorderSize = 0;
            this.closebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closebtn.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closebtn.ForeColor = System.Drawing.Color.White;
            this.closebtn.Location = new System.Drawing.Point(860, 0);
            this.closebtn.Name = "closebtn";
            this.closebtn.Size = new System.Drawing.Size(40, 40);
            this.closebtn.TabIndex = 2;
            this.closebtn.Text = "X";
            this.closebtn.UseVisualStyleBackColor = false;
            this.closebtn.Click += new System.EventHandler(this.closebtn_Click);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Century Gothic", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(262, 9);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(266, 34);
            this.title.TabIndex = 1;
            this.title.Text = "Gerer les Etudiants";
            this.title.Click += new System.EventHandler(this.label1_Click);
            // 
            // manageNiveau1
            // 
            this.manageNiveau1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.manageNiveau1.ForeColor = System.Drawing.Color.Black;
            this.manageNiveau1.Location = new System.Drawing.Point(233, 58);
            this.manageNiveau1.Name = "manageNiveau1";
            this.manageNiveau1.Size = new System.Drawing.Size(900, 540);
            this.manageNiveau1.TabIndex = 2;
            // 
            // listAbsenceEtudiant1
            // 
            this.listAbsenceEtudiant1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.listAbsenceEtudiant1.ForeColor = System.Drawing.Color.Black;
            this.listAbsenceEtudiant1.Location = new System.Drawing.Point(233, 58);
            this.listAbsenceEtudiant1.Name = "listAbsenceEtudiant1";
            this.listAbsenceEtudiant1.Size = new System.Drawing.Size(900, 540);
            this.listAbsenceEtudiant1.TabIndex = 3;
            // 
            // addEtudiant1
            // 
            this.addEtudiant1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.addEtudiant1.Location = new System.Drawing.Point(233, 58);
            this.addEtudiant1.Name = "addEtudiant1";
            this.addEtudiant1.Size = new System.Drawing.Size(900, 540);
            this.addEtudiant1.TabIndex = 4;
            // 
            // listEtudiant1
            // 
            this.listEtudiant1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.listEtudiant1.ForeColor = System.Drawing.Color.Black;
            this.listEtudiant1.Location = new System.Drawing.Point(233, 58);
            this.listEtudiant1.Name = "listEtudiant1";
            this.listEtudiant1.Size = new System.Drawing.Size(900, 540);
            this.listEtudiant1.TabIndex = 5;
            // 
            // AdminEtudiant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1133, 600);
            this.Controls.Add(this.listEtudiant1);
            this.Controls.Add(this.addEtudiant1);
            this.Controls.Add(this.listAbsenceEtudiant1);
            this.Controls.Add(this.manageNiveau1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminEtudiant";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminEtudiant";
            this.Load += new System.EventHandler(this.AdminEtudiant_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button closebtn;
        private System.Windows.Forms.Button button5;
        private ManageNiveau manageNiveau1;
        private ListAbsenceEtudiant listAbsenceEtudiant1;
        private AddEtudiant addEtudiant1;
        private ListEtudiant listEtudiant1;
    }
}