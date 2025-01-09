namespace SEGURETAT_eric_peralta
{
    partial class formlogin
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
            this.label1 = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.acceptButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Correu";
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(129, 26);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(571, 20);
            this.emailTextBox.TabIndex = 1;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(508, 102);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(87, 42);
            this.cancelButton.TabIndex = 2;
            this.cancelButton.Text = "Cancelar";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(129, 57);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(571, 20);
            this.passwordTextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Contrasenya";
            // 
            // acceptButton
            // 
            this.acceptButton.Location = new System.Drawing.Point(613, 102);
            this.acceptButton.Name = "acceptButton";
            this.acceptButton.Size = new System.Drawing.Size(87, 42);
            this.acceptButton.TabIndex = 5;
            this.acceptButton.Text = "Acceptar";
            this.acceptButton.UseVisualStyleBackColor = true;
            this.acceptButton.Click += new System.EventHandler(this.acceptButton_Click);
            // 
            // formlogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 171);
            this.Controls.Add(this.acceptButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.label1);
            this.Name = "formlogin";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button acceptButton;
    }
}