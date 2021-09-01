namespace databaseconnwampp
{
    partial class dbconnectwampp
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
            this.btninsert = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnshow = new System.Windows.Forms.Button();
            this.textBoxid = new System.Windows.Forms.TextBox();
            this.textBoxname = new System.Windows.Forms.TextBox();
            this.labelid = new System.Windows.Forms.Label();
            this.labelname = new System.Windows.Forms.Label();
            this.labelgender = new System.Windows.Forms.Label();
            this.radioBtnmale = new System.Windows.Forms.RadioButton();
            this.radioBtnfemale = new System.Windows.Forms.RadioButton();
            this.labelage = new System.Windows.Forms.Label();
            this.comboBoxage = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btninsert
            // 
            this.btninsert.BackColor = System.Drawing.Color.CadetBlue;
            this.btninsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btninsert.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btninsert.Location = new System.Drawing.Point(85, 275);
            this.btninsert.Name = "btninsert";
            this.btninsert.Size = new System.Drawing.Size(126, 44);
            this.btninsert.TabIndex = 0;
            this.btninsert.Text = "INSERT";
            this.btninsert.UseVisualStyleBackColor = false;
            this.btninsert.Click += new System.EventHandler(this.btninsert_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.Color.CadetBlue;
            this.btnupdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnupdate.Location = new System.Drawing.Point(239, 275);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(126, 44);
            this.btnupdate.TabIndex = 1;
            this.btnupdate.Text = "UPDATE";
            this.btnupdate.UseVisualStyleBackColor = false;
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.CadetBlue;
            this.btndelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btndelete.Location = new System.Drawing.Point(400, 275);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(126, 44);
            this.btndelete.TabIndex = 2;
            this.btndelete.Text = "DELETE";
            this.btndelete.UseVisualStyleBackColor = false;
            // 
            // btnshow
            // 
            this.btnshow.BackColor = System.Drawing.Color.CadetBlue;
            this.btnshow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnshow.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnshow.Location = new System.Drawing.Point(562, 275);
            this.btnshow.Name = "btnshow";
            this.btnshow.Size = new System.Drawing.Size(126, 44);
            this.btnshow.TabIndex = 3;
            this.btnshow.Text = "SHOW";
            this.btnshow.UseVisualStyleBackColor = false;
            // 
            // textBoxid
            // 
            this.textBoxid.Location = new System.Drawing.Point(293, 27);
            this.textBoxid.Name = "textBoxid";
            this.textBoxid.Size = new System.Drawing.Size(179, 20);
            this.textBoxid.TabIndex = 4;
            // 
            // textBoxname
            // 
            this.textBoxname.Location = new System.Drawing.Point(293, 87);
            this.textBoxname.Name = "textBoxname";
            this.textBoxname.Size = new System.Drawing.Size(179, 20);
            this.textBoxname.TabIndex = 5;
            // 
            // labelid
            // 
            this.labelid.AutoSize = true;
            this.labelid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelid.Location = new System.Drawing.Point(129, 30);
            this.labelid.Name = "labelid";
            this.labelid.Size = new System.Drawing.Size(21, 16);
            this.labelid.TabIndex = 7;
            this.labelid.Text = "Id";
            // 
            // labelname
            // 
            this.labelname.AutoSize = true;
            this.labelname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelname.Location = new System.Drawing.Point(129, 87);
            this.labelname.Name = "labelname";
            this.labelname.Size = new System.Drawing.Size(49, 16);
            this.labelname.TabIndex = 8;
            this.labelname.Text = "Name";
            // 
            // labelgender
            // 
            this.labelgender.AutoSize = true;
            this.labelgender.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelgender.Location = new System.Drawing.Point(129, 146);
            this.labelgender.Name = "labelgender";
            this.labelgender.Size = new System.Drawing.Size(59, 16);
            this.labelgender.TabIndex = 9;
            this.labelgender.Text = "Gender";
            // 
            // radioBtnmale
            // 
            this.radioBtnmale.AutoSize = true;
            this.radioBtnmale.Location = new System.Drawing.Point(293, 146);
            this.radioBtnmale.Name = "radioBtnmale";
            this.radioBtnmale.Size = new System.Drawing.Size(48, 17);
            this.radioBtnmale.TabIndex = 10;
            this.radioBtnmale.TabStop = true;
            this.radioBtnmale.Text = "Male";
            this.radioBtnmale.UseVisualStyleBackColor = true;
            // 
            // radioBtnfemale
            // 
            this.radioBtnfemale.AutoSize = true;
            this.radioBtnfemale.Location = new System.Drawing.Point(413, 146);
            this.radioBtnfemale.Name = "radioBtnfemale";
            this.radioBtnfemale.Size = new System.Drawing.Size(59, 17);
            this.radioBtnfemale.TabIndex = 11;
            this.radioBtnfemale.TabStop = true;
            this.radioBtnfemale.Text = "Female";
            this.radioBtnfemale.UseVisualStyleBackColor = true;
            // 
            // labelage
            // 
            this.labelage.AutoSize = true;
            this.labelage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelage.Location = new System.Drawing.Point(132, 204);
            this.labelage.Name = "labelage";
            this.labelage.Size = new System.Drawing.Size(36, 16);
            this.labelage.TabIndex = 12;
            this.labelage.Text = "Age";
            // 
            // comboBoxage
            // 
            this.comboBoxage.FormattingEnabled = true;
            this.comboBoxage.Items.AddRange(new object[] {
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30"});
            this.comboBoxage.Location = new System.Drawing.Point(293, 201);
            this.comboBoxage.Name = "comboBoxage";
            this.comboBoxage.Size = new System.Drawing.Size(121, 21);
            this.comboBoxage.TabIndex = 13;
            // 
            // dbconnectwampp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 343);
            this.Controls.Add(this.comboBoxage);
            this.Controls.Add(this.labelage);
            this.Controls.Add(this.radioBtnfemale);
            this.Controls.Add(this.radioBtnmale);
            this.Controls.Add(this.labelgender);
            this.Controls.Add(this.labelname);
            this.Controls.Add(this.labelid);
            this.Controls.Add(this.textBoxname);
            this.Controls.Add(this.textBoxid);
            this.Controls.Add(this.btnshow);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btninsert);
            this.Name = "dbconnectwampp";
            this.Text = "Database Connection Using Wampp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btninsert;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnshow;
        private System.Windows.Forms.TextBox textBoxid;
        private System.Windows.Forms.TextBox textBoxname;
        private System.Windows.Forms.Label labelid;
        private System.Windows.Forms.Label labelname;
        private System.Windows.Forms.Label labelgender;
        private System.Windows.Forms.RadioButton radioBtnmale;
        private System.Windows.Forms.RadioButton radioBtnfemale;
        private System.Windows.Forms.Label labelage;
        private System.Windows.Forms.ComboBox comboBoxage;
    }
}

