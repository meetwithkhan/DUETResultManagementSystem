using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DUET_ResultManagementSystem
{
    public partial class FinalResultForm : Form
    {
        private static Students student = null;

        internal static Students Student { get => student; set => student = value; }

        public FinalResultForm()
        {
            InitializeComponent();
            label1.UseMnemonic = false;
            FinalResult_Load();
            setStudentInformation();
            resultGridView.AutoGenerateColumns = false;
            resultInfo();
            vScrollBar.Value = 0;
           // SizeOfDataGrid();
        }
        private void setStudentInformation()
        {
            studentNameLabel.Text = student.Name;
            studentNoLabel.Text = student.ID.ToString();
            departmentLabel.Text = student.Department;
            yearLabel.Text = student.Year;
            semesterLabel.Text = student.Semester;
            sessionLabel.Text = student.Session;
        }
        private void resultInfo()
        {
            FinalResultsGateway finalResultsGateway = new FinalResultsGateway();
            //get Taken Credit Info
            totalCreditTakenlabel.Text = (finalResultsGateway.getTotlaCreditTaken(student.ID)).ToString();
            //get Earned Credit Info
            creditEarnedLabel.Text = (finalResultsGateway.getCreditEarned(student.ID)).ToString();

            double creditEarned = finalResultsGateway.getCreditEarned(student.ID);
            double ProductSum = finalResultsGateway.getSummationOfCreditAndGradePoint(student.ID);

            GPALabel.Text = (ProductSum / creditEarned).ToString();
            CGPALabel.Text = GPALabel.Text;
            totalCreditLabel.Text = creditEarnedLabel.Text;
        }
        private void FinalResult_Load()
        {

            List<FinalResult> finalResults = new List<FinalResult>();
            FinalResultsGateway finalResultsGateway = new FinalResultsGateway();
            finalResults = finalResultsGateway.getResultsInfoById(student.ID);
            resultGridView.DataSource = finalResults;

            resultGridView.BorderStyle = BorderStyle.None;
            resultGridView.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            resultGridView.DefaultCellStyle.SelectionBackColor = Color.White;
            resultGridView.DefaultCellStyle.SelectionForeColor = Color.Black;
            resultGridView.BackgroundColor = Color.White;

            resultGridView.EnableHeadersVisualStyles = false;
            resultGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            resultGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
        }
        //private void SizeOfDataGrid()
        //{
        //    resultGridView.Height = ( 49 +((resultGridView.RowCount) * 22));
        //    MessageBox.Show((resultGridView.RowCount).ToString());
        //    GPALabel.Location = new Point(676, resultGridView.Location.Y + 10);
        //    label12.Location = new Point(606, resultGridView.Location.Y + 10);
        //}
        private void finalResultPrintDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bm = new Bitmap(this.resultContentPanel.Width, this.resultContentPanel.Height);
            resultContentPanel.DrawToBitmap(bm, new Rectangle(0, 0, this.resultContentPanel.Width, this.resultContentPanel.Height));
            e.Graphics.DrawImage(bm, 0, 0);
        }

        private void printButton_Click(object sender, EventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();
            PrintDocument printDocument = new PrintDocument();

            printDocument = finalResultPrintDocument;
            printDocument.DocumentName = "Grade Sheet (Provisional)" + " " +student.ID.ToString();

            printDialog.Document = finalResultPrintDocument;
            printDialog.AllowSomePages = true;
            printDialog.AllowSelection = true;
            if (printDialog.ShowDialog() == DialogResult.OK)
                printDocument.Print();
        }

        private void vScrollBar_MouseHover(object sender, EventArgs e)
        {
            vScrollBar.Width = 15;
        }

        private void vScrollBar_MouseLeave(object sender, EventArgs e)
        {
            vScrollBar.Width = 5;
        }

        private void vScrollBar_ValueChanged(object sender, EventArgs e)
        {
            if (vScrollBar.Value == 0)
                resultContentPanel.Location = new Point(0, 0);
            else if(vScrollBar.Value == 1)
                resultContentPanel.Location = new Point(0, -70);
            else if (vScrollBar.Value == 2)
                resultContentPanel.Location = new Point(0, -140);
            else if (vScrollBar.Value == 3)
                resultContentPanel.Location = new Point(0, -210);
            else if (vScrollBar.Value == 4)
                resultContentPanel.Location = new Point(0, -280);
            else if (vScrollBar.Value == 5)
                resultContentPanel.Location = new Point(0, -300);
            else
                resultContentPanel.Location = new Point(0, -330);
        }

        private void vScrollBar_Scroll(object sender, ScrollEventArgs e)
        {

        }
    }
}
