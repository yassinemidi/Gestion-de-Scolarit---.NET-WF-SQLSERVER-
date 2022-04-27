
namespace WindowsFormsApp1.Admin
{
    partial class ListAbsenceProfesseur
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
            this.Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CNI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Matricul = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nb_abs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Nom,
            this.CNI,
            this.Matricul,
            this.nb_abs});
            this.dataGridView1.Location = new System.Drawing.Point(3, 106);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(894, 395);
            this.dataGridView1.TabIndex = 6;
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
            // Nom
            // 
            this.Nom.HeaderText = "Nom et Prenom";
            this.Nom.MinimumWidth = 6;
            this.Nom.Name = "Nom";
            this.Nom.ReadOnly = true;
            this.Nom.Width = 125;
            // 
            // CNI
            // 
            this.CNI.HeaderText = "CNI";
            this.CNI.MinimumWidth = 6;
            this.CNI.Name = "CNI";
            this.CNI.ReadOnly = true;
            this.CNI.Width = 125;
            // 
            // Matricul
            // 
            this.Matricul.HeaderText = "Matricul";
            this.Matricul.MinimumWidth = 6;
            this.Matricul.Name = "Matricul";
            this.Matricul.ReadOnly = true;
            this.Matricul.Width = 125;
            // 
            // nb_abs
            // 
            this.nb_abs.HeaderText = "Nombre d\'absences";
            this.nb_abs.MinimumWidth = 6;
            this.nb_abs.Name = "nb_abs";
            this.nb_abs.ReadOnly = true;
            this.nb_abs.Width = 125;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(167, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(266, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "Liste d\'absence professeur";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(88)))), ((int)(((byte)(154)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(688, 28);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(134, 53);
            this.button2.TabIndex = 7;
            this.button2.Text = "Actualiser";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ListAbsenceProfesseur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Name = "ListAbsenceProfesseur";
            this.Size = new System.Drawing.Size(900, 540);
            this.Load += new System.EventHandler(this.ListAbsenceProfesseur_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn CNI;
        private System.Windows.Forms.DataGridViewTextBoxColumn Matricul;
        private System.Windows.Forms.DataGridViewTextBoxColumn nb_abs;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
    }
}
