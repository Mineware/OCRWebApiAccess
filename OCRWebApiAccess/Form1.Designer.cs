namespace OCRWebApiAccess
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
            this.btnGetFormInfo = new System.Windows.Forms.Button();
            this.btnPrintReport = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFormName = new System.Windows.Forms.TextBox();
            this.txtFromID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvDataStructure = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGetReport = new System.Windows.Forms.Button();
            this.txtPDF = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtError = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFormPrintID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.FRMID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataStructure)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGetFormInfo
            // 
            this.btnGetFormInfo.Location = new System.Drawing.Point(12, 14);
            this.btnGetFormInfo.Name = "btnGetFormInfo";
            this.btnGetFormInfo.Size = new System.Drawing.Size(119, 40);
            this.btnGetFormInfo.TabIndex = 0;
            this.btnGetFormInfo.Text = "Get Form Info";
            this.btnGetFormInfo.UseVisualStyleBackColor = true;
            this.btnGetFormInfo.Click += new System.EventHandler(this.btnGetFormInfo_Click);
            // 
            // btnPrintReport
            // 
            this.btnPrintReport.Location = new System.Drawing.Point(12, 390);
            this.btnPrintReport.Name = "btnPrintReport";
            this.btnPrintReport.Size = new System.Drawing.Size(119, 40);
            this.btnPrintReport.TabIndex = 1;
            this.btnPrintReport.Text = "Print Report";
            this.btnPrintReport.UseVisualStyleBackColor = true;
            this.btnPrintReport.Click += new System.EventHandler(this.btnPrintReport_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(137, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Form Name";
            // 
            // txtFormName
            // 
            this.txtFormName.Location = new System.Drawing.Point(140, 25);
            this.txtFormName.Name = "txtFormName";
            this.txtFormName.Size = new System.Drawing.Size(411, 20);
            this.txtFormName.TabIndex = 3;
            // 
            // txtFromID
            // 
            this.txtFromID.Location = new System.Drawing.Point(140, 64);
            this.txtFromID.Name = "txtFromID";
            this.txtFromID.Size = new System.Drawing.Size(411, 20);
            this.txtFromID.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(137, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Form ID";
            // 
            // dgvDataStructure
            // 
            this.dgvDataStructure.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDataStructure.Location = new System.Drawing.Point(140, 103);
            this.dgvDataStructure.Name = "dgvDataStructure";
            this.dgvDataStructure.Size = new System.Drawing.Size(844, 150);
            this.dgvDataStructure.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(137, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Data Structure";
            // 
            // btnGetReport
            // 
            this.btnGetReport.Location = new System.Drawing.Point(12, 266);
            this.btnGetReport.Name = "btnGetReport";
            this.btnGetReport.Size = new System.Drawing.Size(119, 40);
            this.btnGetReport.TabIndex = 8;
            this.btnGetReport.Text = "Get Report";
            this.btnGetReport.UseVisualStyleBackColor = true;
            this.btnGetReport.Click += new System.EventHandler(this.btnGetReport_Click);
            // 
            // txtPDF
            // 
            this.txtPDF.Location = new System.Drawing.Point(140, 282);
            this.txtPDF.Name = "txtPDF";
            this.txtPDF.Size = new System.Drawing.Size(411, 20);
            this.txtPDF.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(137, 266);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "PDF File Location";
            // 
            // txtError
            // 
            this.txtError.Location = new System.Drawing.Point(140, 360);
            this.txtError.Name = "txtError";
            this.txtError.Size = new System.Drawing.Size(411, 20);
            this.txtError.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(137, 344);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Error";
            // 
            // txtFormPrintID
            // 
            this.txtFormPrintID.Location = new System.Drawing.Point(140, 321);
            this.txtFormPrintID.Name = "txtFormPrintID";
            this.txtFormPrintID.Size = new System.Drawing.Size(411, 20);
            this.txtFormPrintID.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(137, 305);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Form Print ID";
            // 
            // FRMID
            // 
            this.FRMID.Location = new System.Drawing.Point(12, 87);
            this.FRMID.Name = "FRMID";
            this.FRMID.Size = new System.Drawing.Size(119, 20);
            this.FRMID.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Form ID To  Use";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 442);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.FRMID);
            this.Controls.Add(this.txtFormPrintID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtError);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPDF);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnGetReport);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvDataStructure);
            this.Controls.Add(this.txtFromID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFormName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPrintReport);
            this.Controls.Add(this.btnGetFormInfo);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataStructure)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGetFormInfo;
        private System.Windows.Forms.Button btnPrintReport;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFormName;
        private System.Windows.Forms.TextBox txtFromID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvDataStructure;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnGetReport;
        private System.Windows.Forms.TextBox txtPDF;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtError;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtFormPrintID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox FRMID;
        private System.Windows.Forms.Label label7;
    }
}

