using System;
using System.Collections.Generic;
namespace GradeCalculator
{
    class Student
    {
        string name;

        public Student(string name)
        {
            this.name = name;
        }

        public string getName()
        {
            return this.name;
        }
    };


    class Subject
    {
        string name;
        int marks;

        public Subject(string name,int marks)
        {
               this.name = name;
               this.marks = marks;
        }

        public string getName()
        {
            return name;
        }

        public int getMarks()
        {
            return marks;
        }
    };

    class SubjectScore
    {
        Subject subject;
        int total;

        public SubjectScore(Subject subject, int total)
        {
            this.subject = subject;
            this.total = total;
        }

        public int getTotal()
        {
            return this.total;
        }

        public Subject getSubject()
        {
            return this.subject;
        }
    }

    class Exam
    {
        string name;
        List<SubjectScore> subjectScores;

        public Exam(string name, List<SubjectScore> scores)
        {
            this.name = name;
            this.subjectScores = scores;
        }

        public string getName()
        {
            return this.name;
        }

        public int getTotalScore()
        {
            int total = 0;
            foreach(SubjectScore subject in this.subjectScores) {
                total += subject.getTotal();
            }

            return total;
        }

        public List<SubjectScore> getSubjectScores()
        {
            return this.subjectScores;
        }

        public int getTotalSubjectScore()
        {
            int total = 0;

            foreach(SubjectScore subjectScore in this.subjectScores)
            {
                total += subjectScore.getSubject().getMarks();
            }

            return total;
        }
    }

   
    class GradeBook
    {
        Student student;
        List<Subject> subjects;

        char grade;
        int minSubjects = 3;
        int maxSubjects = 10;

        List<Exam> exams = new List<Exam>();
        
        public GradeBook(Student student)
        {
            this.student = student;

            this.subjects = new List<Subject>();
        }

        int totalSubjects()
        {
            return this.subjects.Count;
        }

        public bool addSubject(Subject subject)
        {
            if (this.subjects.Count > this.maxSubjects)
                return false;

            this.subjects.Add(subject);
            return true;
        }

        public void addExamAttended(Exam exam)
        {
            this.exams.Add(exam);
        }

        Exam getExam(String name)
        {
            foreach(Exam exam in this.exams) {
                if (name == exam.getName())
                {
                    return exam;
                }
            }

            return null;
        }

        public Student GetStudent()
        {
            return this.student;
        }

        public Grade getGrade(String examName)
        {
            Exam exam = this.getExam(examName);
            int totalScore = exam.getTotalScore();
            int totalSubjectScore = exam.getTotalSubjectScore();

            float averageScore = ((float)totalScore / (float)totalSubjectScore) * 100f;

            if (averageScore >= (int)Grade.A)
            {
                return Grade.A;
            }
            else if (averageScore >= (int)Grade.B)
            {
                return Grade.B;
            }
            else
            {
                return Grade.C;
            }
        }

    }

   public enum Grade
    {
        A = 70,
        B = 60,
        C = 0
    }

}
