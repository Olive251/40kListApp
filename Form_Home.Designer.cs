namespace _40kListApp
{
    partial class Form_Home
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
            this.btn_newArmy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_newArmy
            // 
            this.btn_newArmy.Location = new System.Drawing.Point(199, 82);
            this.btn_newArmy.Name = "btn_newArmy";
            this.btn_newArmy.Size = new System.Drawing.Size(132, 23);
            this.btn_newArmy.TabIndex = 0;
            this.btn_newArmy.Text = "Create New Army";
            this.btn_newArmy.UseVisualStyleBackColor = true;
            this.btn_newArmy.Click += new System.EventHandler(this.btn_newArmy_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 205);
            this.Controls.Add(this.btn_newArmy);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_newArmy;
    }
}

