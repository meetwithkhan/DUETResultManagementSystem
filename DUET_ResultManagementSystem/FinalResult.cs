using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DUET_ResultManagementSystem
{
    class FinalResult
    {
        private string courseNo;
        private string courseTitle;
        private string creditHour;
        private string letterGrade;
        private string gradePoint;

        private string gPA;
        private string previousGPA;
        private string takenCredit;
        private string completeCredit;
        private string previousCredit;

        public string CourseNo { get => courseNo; set => courseNo = value; }
        public string CourseTitle { get => courseTitle; set => courseTitle = value; }
        public string CreditHour { get => creditHour; set => creditHour = value; }
        public string LetterGrade { get => letterGrade; set => letterGrade = value; }
        public string GradePoint { get => gradePoint; set => gradePoint = value; }
        public string GPA { get => gPA; set => gPA = value; }
        public string PreviousGPA { get => previousGPA; set => previousGPA = value; }
        public string TakenCredit { get => takenCredit; set => takenCredit = value; }
        public string CompleteCredit { get => completeCredit; set => completeCredit = value; }
        public string PreviousCredit { get => previousCredit; set => previousCredit = value; }
    }
}
