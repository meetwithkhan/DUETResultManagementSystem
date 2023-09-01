namespace DUET_ResultManagementSystem
{
    partial class FinalResultForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FinalResultForm));
            this.printButton = new System.Windows.Forms.Button();
            this.resultContentPanel = new System.Windows.Forms.Panel();
            this.CGPALabel = new System.Windows.Forms.Label();
            this.GPALabel = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.totalCreditLabel = new System.Windows.Forms.Label();
            this.creditEarnedLabel = new System.Windows.Forms.Label();
            this.totalCreditTakenlabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.resultGridView = new System.Windows.Forms.DataGridView();
            this.courseNoColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseTitleColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.creditColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.letterColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gradeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.studentNoLabel = new System.Windows.Forms.Label();
            this.studentNameLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.sessionLabel = new System.Windows.Forms.Label();
            this.departmentLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.semesterLabel = new System.Windows.Forms.Label();
            this.yearLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.finalResultPrintDocument = new System.Drawing.Printing.PrintDocument();
            this.finalResultPrintPreviewDialog = new System.Windows.Forms.PrintPreviewDialog();
            this.vScrollBar = new System.Windows.Forms.VScrollBar();
            this.panel3 = new System.Windows.Forms.Panel();
            this.resultContentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resultGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // printButton
            // 
            this.printButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.printButton.FlatAppearance.BorderSize = 0;
            this.printButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.printButton.ForeColor = System.Drawing.Color.White;
            this.printButton.Location = new System.Drawing.Point(1, 1);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(94, 33);
            this.printButton.TabIndex = 0;
            this.printButton.Text = "Print";
            this.printButton.UseVisualStyleBackColor = false;
            this.printButton.Click += new System.EventHandler(this.printButton_Click);
            // 
            // resultContentPanel
            // 
            this.resultContentPanel.Controls.Add(this.CGPALabel);
            this.resultContentPanel.Controls.Add(this.GPALabel);
            this.resultContentPanel.Controls.Add(this.label12);
            this.resultContentPanel.Controls.Add(this.label11);
            this.resultContentPanel.Controls.Add(this.label10);
            this.resultContentPanel.Controls.Add(this.label9);
            this.resultContentPanel.Controls.Add(this.totalCreditLabel);
            this.resultContentPanel.Controls.Add(this.creditEarnedLabel);
            this.resultContentPanel.Controls.Add(this.totalCreditTakenlabel);
            this.resultContentPanel.Controls.Add(this.label8);
            this.resultContentPanel.Controls.Add(this.resultGridView);
            this.resultContentPanel.Controls.Add(this.label7);
            this.resultContentPanel.Controls.Add(this.studentNoLabel);
            this.resultContentPanel.Controls.Add(this.studentNameLabel);
            this.resultContentPanel.Controls.Add(this.label5);
            this.resultContentPanel.Controls.Add(this.sessionLabel);
            this.resultContentPanel.Controls.Add(this.departmentLabel);
            this.resultContentPanel.Controls.Add(this.label3);
            this.resultContentPanel.Controls.Add(this.label6);
            this.resultContentPanel.Controls.Add(this.label4);
            this.resultContentPanel.Controls.Add(this.semesterLabel);
            this.resultContentPanel.Controls.Add(this.yearLabel);
            this.resultContentPanel.Controls.Add(this.label2);
            this.resultContentPanel.Controls.Add(this.logoPictureBox);
            this.resultContentPanel.Controls.Add(this.label1);
            this.resultContentPanel.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultContentPanel.Location = new System.Drawing.Point(0, 3);
            this.resultContentPanel.MaximumSize = new System.Drawing.Size(791, 746);
            this.resultContentPanel.Name = "resultContentPanel";
            this.resultContentPanel.Size = new System.Drawing.Size(779, 746);
            this.resultContentPanel.TabIndex = 1;
            // 
            // CGPALabel
            // 
            this.CGPALabel.AutoSize = true;
            this.CGPALabel.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CGPALabel.Location = new System.Drawing.Point(404, 677);
            this.CGPALabel.MaximumSize = new System.Drawing.Size(45, 21);
            this.CGPALabel.Name = "CGPALabel";
            this.CGPALabel.Size = new System.Drawing.Size(45, 21);
            this.CGPALabel.TabIndex = 7;
            this.CGPALabel.Text = "4.00";
            // 
            // GPALabel
            // 
            this.GPALabel.AutoSize = true;
            this.GPALabel.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GPALabel.Location = new System.Drawing.Point(676, 559);
            this.GPALabel.MaximumSize = new System.Drawing.Size(45, 21);
            this.GPALabel.Name = "GPALabel";
            this.GPALabel.Size = new System.Drawing.Size(45, 21);
            this.GPALabel.TabIndex = 7;
            this.GPALabel.Text = "4.00";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(606, 559);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 21);
            this.label12.TabIndex = 7;
            this.label12.Text = "GPA  =";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(329, 677);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 21);
            this.label11.TabIndex = 7;
            this.label11.Text = "CGPA :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(169, 650);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(228, 21);
            this.label10.TabIndex = 7;
            this.label10.Text = "Total Credit Hours Earned :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(80, 620);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(317, 21);
            this.label9.TabIndex = 7;
            this.label9.Text = "Credit Hours Earned in this Semester :";
            // 
            // totalCreditLabel
            // 
            this.totalCreditLabel.AutoSize = true;
            this.totalCreditLabel.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalCreditLabel.Location = new System.Drawing.Point(402, 650);
            this.totalCreditLabel.Name = "totalCreditLabel";
            this.totalCreditLabel.Size = new System.Drawing.Size(107, 21);
            this.totalCreditLabel.TabIndex = 7;
            this.totalCreditLabel.Text = "Total credit";
            // 
            // creditEarnedLabel
            // 
            this.creditEarnedLabel.AutoSize = true;
            this.creditEarnedLabel.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creditEarnedLabel.Location = new System.Drawing.Point(402, 620);
            this.creditEarnedLabel.Name = "creditEarnedLabel";
            this.creditEarnedLabel.Size = new System.Drawing.Size(127, 21);
            this.creditEarnedLabel.TabIndex = 7;
            this.creditEarnedLabel.Text = "Earned credit";
            // 
            // totalCreditTakenlabel
            // 
            this.totalCreditTakenlabel.AutoSize = true;
            this.totalCreditTakenlabel.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalCreditTakenlabel.Location = new System.Drawing.Point(402, 591);
            this.totalCreditTakenlabel.Name = "totalCreditTakenlabel";
            this.totalCreditTakenlabel.Size = new System.Drawing.Size(164, 21);
            this.totalCreditTakenlabel.TabIndex = 7;
            this.totalCreditTakenlabel.Text = "Total Taken credit";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(51, 590);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(346, 21);
            this.label8.TabIndex = 7;
            this.label8.Text = "Registered Credit Hours in this Semester :";
            // 
            // resultGridView
            // 
            this.resultGridView.AllowUserToAddRows = false;
            this.resultGridView.AllowUserToDeleteRows = false;
            this.resultGridView.AllowUserToResizeColumns = false;
            this.resultGridView.AllowUserToResizeRows = false;
            this.resultGridView.BackgroundColor = System.Drawing.Color.White;
            this.resultGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.resultGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.resultGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resultGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.courseNoColumn,
            this.courseTitleColumn,
            this.creditColumn,
            this.letterColumn,
            this.gradeColumn});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.resultGridView.DefaultCellStyle = dataGridViewCellStyle4;
            this.resultGridView.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.resultGridView.Location = new System.Drawing.Point(39, 273);
            this.resultGridView.Name = "resultGridView";
            this.resultGridView.ReadOnly = true;
            this.resultGridView.RowHeadersVisible = false;
            this.resultGridView.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultGridView.RowTemplate.ReadOnly = true;
            this.resultGridView.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.resultGridView.Size = new System.Drawing.Size(702, 271);
            this.resultGridView.TabIndex = 6;
            // 
            // courseNoColumn
            // 
            this.courseNoColumn.DataPropertyName = "CourseNo";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.courseNoColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.courseNoColumn.HeaderText = "Course No.";
            this.courseNoColumn.Name = "courseNoColumn";
            this.courseNoColumn.ReadOnly = true;
            this.courseNoColumn.Width = 115;
            // 
            // courseTitleColumn
            // 
            this.courseTitleColumn.DataPropertyName = "CourseTitle";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.courseTitleColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.courseTitleColumn.HeaderText = "Course Title";
            this.courseTitleColumn.Name = "courseTitleColumn";
            this.courseTitleColumn.ReadOnly = true;
            this.courseTitleColumn.Width = 355;
            // 
            // creditColumn
            // 
            this.creditColumn.DataPropertyName = "CreditHour";
            this.creditColumn.HeaderText = "Credit Hours";
            this.creditColumn.Name = "creditColumn";
            this.creditColumn.ReadOnly = true;
            this.creditColumn.Width = 70;
            // 
            // letterColumn
            // 
            this.letterColumn.DataPropertyName = "LetterGrade";
            this.letterColumn.HeaderText = "Letter Grade";
            this.letterColumn.Name = "letterColumn";
            this.letterColumn.ReadOnly = true;
            this.letterColumn.Width = 85;
            // 
            // gradeColumn
            // 
            this.gradeColumn.DataPropertyName = "GradePoint";
            this.gradeColumn.HeaderText = "Grade Point";
            this.gradeColumn.Name = "gradeColumn";
            this.gradeColumn.ReadOnly = true;
            this.gradeColumn.Width = 75;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(51, 246);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(155, 21);
            this.label7.TabIndex = 5;
            this.label7.Text = "Student No         : ";
            // 
            // studentNoLabel
            // 
            this.studentNoLabel.AutoSize = true;
            this.studentNoLabel.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentNoLabel.Location = new System.Drawing.Point(202, 246);
            this.studentNoLabel.Name = "studentNoLabel";
            this.studentNoLabel.Size = new System.Drawing.Size(102, 21);
            this.studentNoLabel.TabIndex = 5;
            this.studentNoLabel.Text = "StudentNo";
            // 
            // studentNameLabel
            // 
            this.studentNameLabel.AutoSize = true;
            this.studentNameLabel.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentNameLabel.Location = new System.Drawing.Point(202, 216);
            this.studentNameLabel.Name = "studentNameLabel";
            this.studentNameLabel.Size = new System.Drawing.Size(129, 21);
            this.studentNameLabel.TabIndex = 5;
            this.studentNameLabel.Text = "StudentName";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(51, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 21);
            this.label5.TabIndex = 5;
            this.label5.Text = "Student Name    : ";
            // 
            // sessionLabel
            // 
            this.sessionLabel.AutoSize = true;
            this.sessionLabel.BackColor = System.Drawing.Color.Transparent;
            this.sessionLabel.Location = new System.Drawing.Point(633, 156);
            this.sessionLabel.Name = "sessionLabel";
            this.sessionLabel.Size = new System.Drawing.Size(76, 21);
            this.sessionLabel.TabIndex = 4;
            this.sessionLabel.Text = "2017-18";
            // 
            // departmentLabel
            // 
            this.departmentLabel.AutoSize = true;
            this.departmentLabel.Location = new System.Drawing.Point(336, 186);
            this.departmentLabel.Name = "departmentLabel";
            this.departmentLabel.Size = new System.Drawing.Size(293, 21);
            this.departmentLabel.TabIndex = 3;
            this.departmentLabel.Text = "Computer Science and Engineering";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(212, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Department of ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(216, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(421, 21);
            this.label6.TabIndex = 3;
            this.label6.Text = "Semester B. Sc. Engineering Examination, Session:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(138, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Year";
            // 
            // semesterLabel
            // 
            this.semesterLabel.AutoSize = true;
            this.semesterLabel.BackColor = System.Drawing.Color.Transparent;
            this.semesterLabel.Location = new System.Drawing.Point(182, 156);
            this.semesterLabel.Name = "semesterLabel";
            this.semesterLabel.Size = new System.Drawing.Size(40, 21);
            this.semesterLabel.TabIndex = 3;
            this.semesterLabel.Text = "2nd";
            // 
            // yearLabel
            // 
            this.yearLabel.AutoSize = true;
            this.yearLabel.BackColor = System.Drawing.Color.Transparent;
            this.yearLabel.Location = new System.Drawing.Point(103, 156);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(40, 21);
            this.yearLabel.TabIndex = 3;
            this.yearLabel.Text = "2nd";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(266, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(274, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "Grade Sheet (Provisional)";
            // 
            // logoPictureBox
            // 
            this.logoPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("logoPictureBox.Image")));
            this.logoPictureBox.Location = new System.Drawing.Point(344, 59);
            this.logoPictureBox.Name = "logoPictureBox";
            this.logoPictureBox.Size = new System.Drawing.Size(66, 54);
            this.logoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoPictureBox.TabIndex = 1;
            this.logoPictureBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(91, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(588, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dhaka University of Engineering & Technology, Gazipur";
            // 
            // finalResultPrintDocument
            // 
            this.finalResultPrintDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.finalResultPrintDocument_PrintPage);
            // 
            // finalResultPrintPreviewDialog
            // 
            this.finalResultPrintPreviewDialog.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.finalResultPrintPreviewDialog.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.finalResultPrintPreviewDialog.ClientSize = new System.Drawing.Size(400, 300);
            this.finalResultPrintPreviewDialog.Enabled = true;
            this.finalResultPrintPreviewDialog.Icon = ((System.Drawing.Icon)(resources.GetObject("finalResultPrintPreviewDialog.Icon")));
            this.finalResultPrintPreviewDialog.Name = "finalResultPrintPreviewDialog";
            this.finalResultPrintPreviewDialog.Visible = false;
            // 
            // vScrollBar
            // 
            this.vScrollBar.Dock = System.Windows.Forms.DockStyle.Right;
            this.vScrollBar.Location = new System.Drawing.Point(782, 0);
            this.vScrollBar.Maximum = 12;
            this.vScrollBar.Name = "vScrollBar";
            this.vScrollBar.Size = new System.Drawing.Size(10, 733);
            this.vScrollBar.TabIndex = 11;
            this.vScrollBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScrollBar_Scroll);
            this.vScrollBar.ValueChanged += new System.EventHandler(this.vScrollBar_ValueChanged);
            this.vScrollBar.MouseLeave += new System.EventHandler(this.vScrollBar_MouseLeave);
            this.vScrollBar.MouseHover += new System.EventHandler(this.vScrollBar_MouseHover);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.printButton);
            this.panel3.Location = new System.Drawing.Point(680, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(97, 30);
            this.panel3.TabIndex = 12;
            // 
            // FinalResultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(792, 733);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.vScrollBar);
            this.Controls.Add(this.resultContentPanel);
            this.Font = new System.Drawing.Font("Century", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FinalResultForm";
            this.Text = "DUET Result Management System -  Final Result";
            this.resultContentPanel.ResumeLayout(false);
            this.resultContentPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resultGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button printButton;
        private System.Windows.Forms.Panel resultContentPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label semesterLabel;
        private System.Windows.Forms.Label yearLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox logoPictureBox;
        private System.Windows.Forms.Label sessionLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label departmentLabel;
        private System.Windows.Forms.Label studentNoLabel;
        private System.Windows.Forms.Label studentNameLabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Drawing.Printing.PrintDocument finalResultPrintDocument;
        private System.Windows.Forms.PrintPreviewDialog finalResultPrintPreviewDialog;
        private System.Windows.Forms.DataGridView resultGridView;
        private System.Windows.Forms.Label totalCreditTakenlabel;
        private System.Windows.Forms.Label creditEarnedLabel;
        private System.Windows.Forms.Label totalCreditLabel;
        private System.Windows.Forms.Label GPALabel;
        private System.Windows.Forms.Label CGPALabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseNoColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseTitleColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn creditColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn letterColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gradeColumn;
        private System.Windows.Forms.VScrollBar vScrollBar;
        private System.Windows.Forms.Panel panel3;
    }
}