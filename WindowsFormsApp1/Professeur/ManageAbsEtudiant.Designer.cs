
namespace WindowsFormsApp1.Professeur
{
    partial class ManageAbsEtudiant
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Absences__ = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Absencesss = new System.Windows.Forms.DataGridViewButtonColumn();
            this.NbAbs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nom_et_Prenom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_prof = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CNI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Absences__,
            this.Absencesss,
            this.NbAbs,
            this.Nom_et_Prenom,
            this.id_prof,
            this.CNI});
            this.dataGridView1.Location = new System.Drawing.Point(0, 83);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(894, 426);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 125;
            // 
            // Absences__
            // 
            this.Absences__.HeaderText = "++Absences";
            this.Absences__.MinimumWidth = 6;
            this.Absences__.Name = "Absences__";
            this.Absences__.ReadOnly = true;
            this.Absences__.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Absences__.Text = "fbrbr";
            this.Absences__.ToolTipText = "++";
            this.Absences__.Width = 125;
            // 
            // Absencesss
            // 
            this.Absencesss.HeaderText = "--Absences";
            this.Absencesss.MinimumWidth = 6;
            this.Absencesss.Name = "Absencesss";
            this.Absencesss.ReadOnly = true;
            this.Absencesss.Width = 125;
            // 
            // NbAbs
            // 
            this.NbAbs.HeaderText = "Nombre d\'Absences";
            this.NbAbs.MinimumWidth = 6;
            this.NbAbs.Name = "NbAbs";
            this.NbAbs.ReadOnly = true;
            this.NbAbs.Width = 125;
            // 
            // Nom_et_Prenom
            // 
            this.Nom_et_Prenom.HeaderText = "Nom et Prenom";
            this.Nom_et_Prenom.MinimumWidth = 6;
            this.Nom_et_Prenom.Name = "Nom_et_Prenom";
            this.Nom_et_Prenom.ReadOnly = true;
            this.Nom_et_Prenom.Width = 125;
            // 
            // id_prof
            // 
            this.id_prof.HeaderText = "ID Etudiant";
            this.id_prof.MinimumWidth = 6;
            this.id_prof.Name = "id_prof";
            this.id_prof.ReadOnly = true;
            this.id_prof.Width = 125;
            // 
            // CNI
            // 
            this.CNI.HeaderText = "CNE";
            this.CNI.MinimumWidth = 6;
            this.CNI.Name = "CNI";
            this.CNI.ReadOnly = true;
            this.CNI.Width = 125;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DarkGreen;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(726, 22);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(124, 41);
            this.button3.TabIndex = 4;
            this.button3.Text = "Actualiser";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // ManageAbsEtudiant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ManageAbsEtudiant";
            this.Size = new System.Drawing.Size(900, 540);
            this.Load += new System.EventHandler(this.ManageAbsEtudiant_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewButtonColumn Absences__;
        private System.Windows.Forms.DataGridViewButtonColumn Absencesss;
        private System.Windows.Forms.DataGridViewTextBoxColumn NbAbs;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom_et_Prenom;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_prof;
        private System.Windows.Forms.DataGridViewTextBoxColumn CNI;
        private System.Windows.Forms.Button button3;
    }
}
