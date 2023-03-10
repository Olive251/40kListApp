namespace _40kListApp
{
    partial class Form_NewArmy
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
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_nArmyName = new System.Windows.Forms.TextBox();
            this.tb_nArmyFaction = new System.Windows.Forms.TextBox();
            this.btn_nArmyCancel = new System.Windows.Forms.Button();
            this.btn_createArmy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(135, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "New Army";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Army Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(47, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Army Faction:";
            // 
            // tb_nArmyName
            // 
            this.tb_nArmyName.Location = new System.Drawing.Point(176, 90);
            this.tb_nArmyName.Name = "tb_nArmyName";
            this.tb_nArmyName.Size = new System.Drawing.Size(196, 20);
            this.tb_nArmyName.TabIndex = 4;
            // 
            // tb_nArmyFaction
            // 
            this.tb_nArmyFaction.Location = new System.Drawing.Point(176, 132);
            this.tb_nArmyFaction.Name = "tb_nArmyFaction";
            this.tb_nArmyFaction.Size = new System.Drawing.Size(196, 20);
            this.tb_nArmyFaction.TabIndex = 5;
            // 
            // btn_nArmyCancel
            // 
            this.btn_nArmyCancel.Location = new System.Drawing.Point(50, 196);
            this.btn_nArmyCancel.Name = "btn_nArmyCancel";
            this.btn_nArmyCancel.Size = new System.Drawing.Size(104, 23);
            this.btn_nArmyCancel.TabIndex = 6;
            this.btn_nArmyCancel.Text = "Cancel";
            this.btn_nArmyCancel.UseVisualStyleBackColor = true;
            this.btn_nArmyCancel.Click += new System.EventHandler(this.btn_nArmyCancel_Click);
            // 
            // btn_createArmy
            // 
            this.btn_createArmy.Location = new System.Drawing.Point(259, 196);
            this.btn_createArmy.Name = "btn_createArmy";
            this.btn_createArmy.Size = new System.Drawing.Size(113, 23);
            this.btn_createArmy.TabIndex = 7;
            this.btn_createArmy.Text = "Create Army";
            this.btn_createArmy.UseVisualStyleBackColor = true;
            this.btn_createArmy.Click += new System.EventHandler(this.btn_createArmy_Click);
            // 
            // Form_NewArmy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 255);
            this.Controls.Add(this.btn_createArmy);
            this.Controls.Add(this.btn_nArmyCancel);
            this.Controls.Add(this.tb_nArmyFaction);
            this.Controls.Add(this.tb_nArmyName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form_NewArmy";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_nArmyName;
        private System.Windows.Forms.TextBox tb_nArmyFaction;
        private System.Windows.Forms.Button btn_nArmyCancel;
        private System.Windows.Forms.Button btn_createArmy;
    }
}