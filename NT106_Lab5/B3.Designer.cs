namespace NT106_Lab5
{
    partial class frmB3
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
            this.btnSend = new System.Windows.Forms.Button();
            this.tbFrom = new System.Windows.Forms.TextBox();
            this.tbTo = new System.Windows.Forms.TextBox();
            this.rtbCnt = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbPass = new System.Windows.Forms.TextBox();
            this.tbSubj = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "FROM:";
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(1220, 56);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(99, 42);
            this.btnSend.TabIndex = 1;
            this.btnSend.Text = "SEND";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // tbFrom
            // 
            this.tbFrom.Location = new System.Drawing.Point(43, 56);
            this.tbFrom.Name = "tbFrom";
            this.tbFrom.Size = new System.Drawing.Size(455, 31);
            this.tbFrom.TabIndex = 2;
            this.tbFrom.Text = "17520642@nhom05.nt106";
            // 
            // tbTo
            // 
            this.tbTo.Location = new System.Drawing.Point(43, 120);
            this.tbTo.Name = "tbTo";
            this.tbTo.Size = new System.Drawing.Size(1113, 31);
            this.tbTo.TabIndex = 3;
            this.tbTo.Text = "hahaha@nhom05.nt106";
            // 
            // rtbCnt
            // 
            this.rtbCnt.Location = new System.Drawing.Point(43, 306);
            this.rtbCnt.Name = "rtbCnt";
            this.rtbCnt.Size = new System.Drawing.Size(1266, 403);
            this.rtbCnt.TabIndex = 5;
            this.rtbCnt.Text = "hahaha";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "TO:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 278);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "CONTENT";
            // 
            // tbPass
            // 
            this.tbPass.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.tbPass.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.tbPass.Location = new System.Drawing.Point(701, 62);
            this.tbPass.Name = "tbPass";
            this.tbPass.Size = new System.Drawing.Size(455, 31);
            this.tbPass.TabIndex = 8;
            this.tbPass.Text = "Ivagrentina123@";
            // 
            // tbSubj
            // 
            this.tbSubj.Location = new System.Drawing.Point(43, 229);
            this.tbSubj.Name = "tbSubj";
            this.tbSubj.Size = new System.Drawing.Size(1113, 31);
            this.tbSubj.TabIndex = 9;
            this.tbSubj.Text = "haha";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "SUBJECT";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // frmB3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1360, 829);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbSubj);
            this.Controls.Add(this.tbPass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rtbCnt);
            this.Controls.Add(this.tbTo);
            this.Controls.Add(this.tbFrom);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.label1);
            this.Name = "frmB3";
            this.Text = "BÀI 3 MAIL CLIENT";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox tbFrom;
        private System.Windows.Forms.TextBox tbTo;
        private System.Windows.Forms.RichTextBox rtbCnt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbPass;
        private System.Windows.Forms.TextBox tbSubj;
        private System.Windows.Forms.Label label4;
    }
}

