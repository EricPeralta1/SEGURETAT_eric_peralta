namespace SEGURETAT_eric_peralta
{
    partial class formUsuaris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formUsuaris));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.addButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.deleteButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.sortirButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.dataGridViewUsuaris = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Correu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cognoms = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Actiu = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Rol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsuaris)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addButton,
            this.toolStripLabel1,
            this.deleteButton,
            this.toolStripLabel2,
            this.toolStripSeparator1,
            this.sortirButton,
            this.toolStripLabel3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(985, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // addButton
            // 
            this.addButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.addButton.Image = global::SEGURETAT_eric_peralta.Properties.Resources.anadir;
            this.addButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(23, 22);
            this.addButton.Text = "addButton";
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(39, 22);
            this.toolStripLabel1.Text = "Afegir";
            // 
            // deleteButton
            // 
            this.deleteButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.deleteButton.Image = global::SEGURETAT_eric_peralta.Properties.Resources.borrar;
            this.deleteButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(23, 22);
            this.deleteButton.Text = "deleteButton";
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(50, 22);
            this.toolStripLabel2.Text = "Esborrar";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // sortirButton
            // 
            this.sortirButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.sortirButton.Image = global::SEGURETAT_eric_peralta.Properties.Resources.exiticon;
            this.sortirButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.sortirButton.Name = "sortirButton";
            this.sortirButton.Size = new System.Drawing.Size(23, 22);
            this.sortirButton.Text = "exitButton";
            this.sortirButton.Click += new System.EventHandler(this.sortirButton_Click);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(35, 22);
            this.toolStripLabel3.Text = "Sortir";
            // 
            // dataGridViewUsuaris
            // 
            this.dataGridViewUsuaris.AllowUserToAddRows = false;
            this.dataGridViewUsuaris.AllowUserToDeleteRows = false;
            this.dataGridViewUsuaris.AllowUserToResizeColumns = false;
            this.dataGridViewUsuaris.AllowUserToResizeRows = false;
            this.dataGridViewUsuaris.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUsuaris.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Correu,
            this.Nom,
            this.Cognoms,
            this.Actiu,
            this.Rol});
            this.dataGridViewUsuaris.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataGridViewUsuaris.Location = new System.Drawing.Point(0, 28);
            this.dataGridViewUsuaris.Name = "dataGridViewUsuaris";
            this.dataGridViewUsuaris.RowHeadersVisible = false;
            this.dataGridViewUsuaris.Size = new System.Drawing.Size(985, 422);
            this.dataGridViewUsuaris.TabIndex = 1;
            // 
            // Id
            // 
            this.Id.Frozen = true;
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // Correu
            // 
            this.Correu.Frozen = true;
            this.Correu.HeaderText = "Correu";
            this.Correu.Name = "Correu";
            this.Correu.ReadOnly = true;
            this.Correu.Width = 225;
            // 
            // Nom
            // 
            this.Nom.Frozen = true;
            this.Nom.HeaderText = "Nom";
            this.Nom.Name = "Nom";
            this.Nom.ReadOnly = true;
            this.Nom.Width = 225;
            // 
            // Cognoms
            // 
            this.Cognoms.Frozen = true;
            this.Cognoms.HeaderText = "Cognoms";
            this.Cognoms.Name = "Cognoms";
            this.Cognoms.ReadOnly = true;
            this.Cognoms.Width = 225;
            // 
            // Actiu
            // 
            this.Actiu.Frozen = true;
            this.Actiu.HeaderText = "Actiu";
            this.Actiu.Name = "Actiu";
            this.Actiu.ReadOnly = true;
            this.Actiu.Width = 85;
            // 
            // Rol
            // 
            this.Rol.Frozen = true;
            this.Rol.HeaderText = "Rol";
            this.Rol.Name = "Rol";
            this.Rol.ReadOnly = true;
            this.Rol.Width = 225;
            // 
            // formUsuaris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 450);
            this.Controls.Add(this.dataGridViewUsuaris);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "formUsuaris";
            this.Text = "Usuaris";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsuaris)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripButton addButton;
        private System.Windows.Forms.ToolStripButton deleteButton;
        private System.Windows.Forms.ToolStripButton sortirButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.DataGridView dataGridViewUsuaris;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Correu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cognoms;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Actiu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rol;
    }
}