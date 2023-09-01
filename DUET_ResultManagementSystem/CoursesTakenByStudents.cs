using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DUET_ResultManagementSystem
{
    class CoursesTakenByStudents
    {
        private int studentId;
        private double finalMarks;
        private double classtestsMarks;
        private double attendenceMarks;
        private double totalMarks;
        private string letterGrade;
        private string gradePoint;

        public int StudentId { get => studentId; set => studentId = value; }
        public double FinalMarks { get => finalMarks; set => finalMarks = value; }
        public double ClasstestsMarks { get => classtestsMarks; set => classtestsMarks = value; }
        public double AttendenceMarks { get => attendenceMarks; set => attendenceMarks = value; }
        public double TotalMarks { get => totalMarks; set => totalMarks = value; }
        public string LetterGrade { get => letterGrade; set => letterGrade = value; }
        public string GradePoint { get => gradePoint; set => gradePoint = value; }
        

    }
}
