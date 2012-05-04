namespace Notes
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTrouble = new System.Windows.Forms.TextBox();
            this.txtResolution = new System.Windows.Forms.TextBox();
            this.drpPrefabs = new System.Windows.Forms.ComboBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnCopy = new System.Windows.Forms.Button();
            this.txtIssue = new System.Windows.Forms.TextBox();
            this.chkSpell = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Issue";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Troubleshooting Steps";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 423);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Resolution";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Prefabs:";
            // 
            // txtTrouble
            // 
            this.txtTrouble.Location = new System.Drawing.Point(13, 199);
            this.txtTrouble.Multiline = true;
            this.txtTrouble.Name = "txtTrouble";
            this.txtTrouble.Size = new System.Drawing.Size(527, 221);
            this.txtTrouble.TabIndex = 3;
            // 
            // txtResolution
            // 
            this.txtResolution.Location = new System.Drawing.Point(13, 440);
            this.txtResolution.Multiline = true;
            this.txtResolution.Name = "txtResolution";
            this.txtResolution.Size = new System.Drawing.Size(527, 138);
            this.txtResolution.TabIndex = 4;
            // 
            // drpPrefabs
            // 
            this.drpPrefabs.FormattingEnabled = true;
            this.drpPrefabs.Items.AddRange(new object[] {
<<<<<<< HEAD
            "<nothing>"});
=======
            "<nothing>",
            "Aircard Setup",
            "Android Email Setup",
            "Beyond Trust Repair",
            "Blackberry Activation",
            "ESS Portal Prompting for Password",
            "Guest Wireless Password",
            "HP 460/470 Installation",
            "Windows Password"});
>>>>>>> a649b4c37807889e279882f9c96323aebec7c276
            this.drpPrefabs.Location = new System.Drawing.Point(13, 30);
            this.drpPrefabs.Name = "drpPrefabs";
            this.drpPrefabs.Size = new System.Drawing.Size(121, 21);
            this.drpPrefabs.TabIndex = 1;
            this.drpPrefabs.SelectedIndexChanged += new System.EventHandler(this.drpPrefabs_SelectedIndexChanged);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(465, 604);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnCopy
            // 
            this.btnCopy.Location = new System.Drawing.Point(384, 603);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(75, 23);
            this.btnCopy.TabIndex = 5;
            this.btnCopy.Text = "Copy";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // txtIssue
            // 
            this.txtIssue.Location = new System.Drawing.Point(13, 90);
            this.txtIssue.Multiline = true;
            this.txtIssue.Name = "txtIssue";
            this.txtIssue.Size = new System.Drawing.Size(527, 89);
            this.txtIssue.TabIndex = 2;
            // 
            // chkSpell
            // 
            this.chkSpell.Location = new System.Drawing.Point(13, 604);
            this.chkSpell.Name = "chkSpell";
            this.chkSpell.Size = new System.Drawing.Size(87, 23);
            this.chkSpell.TabIndex = 7;
            this.chkSpell.Text = "Check Spelling";
            this.chkSpell.UseVisualStyleBackColor = true;
            this.chkSpell.Click += new System.EventHandler(this.chkSpell_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 639);
            this.Controls.Add(this.chkSpell);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.drpPrefabs);
            this.Controls.Add(this.txtResolution);
            this.Controls.Add(this.txtTrouble);
            this.Controls.Add(this.txtIssue);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "SJM Service Desk Note Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTrouble;
        private System.Windows.Forms.TextBox txtResolution;
        private System.Windows.Forms.ComboBox drpPrefabs;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.TextBox txtIssue;
        private System.Windows.Forms.Button chkSpell;
    }
}

