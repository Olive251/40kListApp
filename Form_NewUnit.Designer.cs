namespace _40kListApp
{
    partial class Form_NewUnit
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
            this.lbl_CreateNewUnit = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_addUnit = new System.Windows.Forms.Button();
            this.tb_unitName = new System.Windows.Forms.TextBox();
            this.tb_faction = new System.Windows.Forms.TextBox();
            this.tb_unitType = new System.Windows.Forms.TextBox();
            this.cb_battlefieldRole = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_powerRating = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_keywords = new System.Windows.Forms.TextBox();
            this.lbl_keywords = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_CreateNewUnit
            // 
            this.lbl_CreateNewUnit.AutoSize = true;
            this.lbl_CreateNewUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CreateNewUnit.Location = new System.Drawing.Point(134, 9);
            this.lbl_CreateNewUnit.Name = "lbl_CreateNewUnit";
            this.lbl_CreateNewUnit.Size = new System.Drawing.Size(229, 31);
            this.lbl_CreateNewUnit.TabIndex = 0;
            this.lbl_CreateNewUnit.Text = "Create New Unit";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Unit Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Unit Type:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Battlefield Role:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Crusade Faction:";
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(35, 305);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 10;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_addUnit
            // 
            this.btn_addUnit.Location = new System.Drawing.Point(432, 305);
            this.btn_addUnit.Name = "btn_addUnit";
            this.btn_addUnit.Size = new System.Drawing.Size(104, 23);
            this.btn_addUnit.TabIndex = 11;
            this.btn_addUnit.Text = "Save Unit";
            this.btn_addUnit.UseVisualStyleBackColor = true;
            this.btn_addUnit.Click += new System.EventHandler(this.btn_addUnit_Click);
            // 
            // tb_unitName
            // 
            this.tb_unitName.Location = new System.Drawing.Point(174, 3);
            this.tb_unitName.Name = "tb_unitName";
            this.tb_unitName.Size = new System.Drawing.Size(308, 20);
            this.tb_unitName.TabIndex = 1;
            // 
            // tb_faction
            // 
            this.tb_faction.Location = new System.Drawing.Point(174, 102);
            this.tb_faction.Name = "tb_faction";
            this.tb_faction.Size = new System.Drawing.Size(308, 20);
            this.tb_faction.TabIndex = 4;
            // 
            // tb_unitType
            // 
            this.tb_unitType.Location = new System.Drawing.Point(174, 36);
            this.tb_unitType.Name = "tb_unitType";
            this.tb_unitType.Size = new System.Drawing.Size(308, 20);
            this.tb_unitType.TabIndex = 2;
            // 
            // cb_battlefieldRole
            // 
            this.cb_battlefieldRole.FormattingEnabled = true;
            this.cb_battlefieldRole.Items.AddRange(new object[] {
            "HQ",
            "Troop",
            "Elite",
            "Flyer",
            "Fast Attack",
            "Heavy Support",
            "Dedicated Transport",
            "Lord of War"});
            this.cb_battlefieldRole.Location = new System.Drawing.Point(174, 69);
            this.cb_battlefieldRole.Name = "cb_battlefieldRole";
            this.cb_battlefieldRole.Size = new System.Drawing.Size(308, 21);
            this.cb_battlefieldRole.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Power Rating:";
            // 
            // tb_powerRating
            // 
            this.tb_powerRating.Location = new System.Drawing.Point(174, 201);
            this.tb_powerRating.Name = "tb_powerRating";
            this.tb_powerRating.Size = new System.Drawing.Size(74, 20);
            this.tb_powerRating.TabIndex = 7;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.13174F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.86826F));
            this.tableLayoutPanel1.Controls.Add(this.textBox2, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.tb_keywords, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.lbl_keywords, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tb_unitName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tb_faction, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.cb_battlefieldRole, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.tb_unitType, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.tb_powerRating, 1, 6);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(35, 59);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(501, 221);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(174, 168);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(308, 20);
            this.textBox2.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Equipment:";
            // 
            // tb_keywords
            // 
            this.tb_keywords.Location = new System.Drawing.Point(174, 135);
            this.tb_keywords.Name = "tb_keywords";
            this.tb_keywords.Size = new System.Drawing.Size(308, 20);
            this.tb_keywords.TabIndex = 5;
            // 
            // lbl_keywords
            // 
            this.lbl_keywords.AutoSize = true;
            this.lbl_keywords.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_keywords.Location = new System.Drawing.Point(3, 132);
            this.lbl_keywords.Name = "lbl_keywords";
            this.lbl_keywords.Size = new System.Drawing.Size(163, 17);
            this.lbl_keywords.TabIndex = 8;
            this.lbl_keywords.Text = "Selectable Keywords:";
            // 
            // Form_NewUnit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 349);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.btn_addUnit);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.lbl_CreateNewUnit);
            this.Name = "Form_NewUnit";
            this.Text = "Form_NewUnit";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_CreateNewUnit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_addUnit;
        private System.Windows.Forms.TextBox tb_unitName;
        private System.Windows.Forms.TextBox tb_faction;
        private System.Windows.Forms.TextBox tb_unitType;
        private System.Windows.Forms.ComboBox cb_battlefieldRole;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_powerRating;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_keywords;
        private System.Windows.Forms.Label lbl_keywords;
    }
}