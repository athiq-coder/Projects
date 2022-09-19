using System;
using GradeCalculator;
using System.Collections.Generic;

namespace Electronic_Gradebook
{
    public class ElectronicGradeBook
    {
        public static void Main(String[] args)
        {
            List<GradeBook> gradeBooks = new List<GradeBook>();
            // Add Students
            Student student1 = new Student("student1");
            Student student2 = new Student("student2");
            Student student3 = new Student("student3");

            // Add Subjects
            Subject physics = new Subject("Physics", 100);
            Subject maths = new Subject("Maths", 100);
            Subject english = new Subject("English", 100);
            Subject chemistry = new Subject("Chemistry", 100);
            Subject geography = new Subject("Geography", 100);


            // Student 1 Exam scores
            SubjectScore s1PhysicsScore = new SubjectScore(physics, 50);
            SubjectScore s1MathsScore = new SubjectScore(maths, 50);
            SubjectScore s1ChemistryScore = new SubjectScore(chemistry, 50);
            SubjectScore s1EnglishScore = new SubjectScore(english, 50);

            List<SubjectScore> s1SubjectScoredMarks = new List<SubjectScore>();
            s1SubjectScoredMarks.Add(s1PhysicsScore);
            s1SubjectScoredMarks.Add(s1MathsScore);
            s1SubjectScoredMarks.Add(s1ChemistryScore);
            s1SubjectScoredMarks.Add(s1EnglishScore);

            Exam s1QuartelyExam = new Exam("Quartely", s1SubjectScoredMarks);

            GradeBook student1GradeBook = new GradeBook(student1);
            student1GradeBook.addSubject(physics);
            student1GradeBook.addSubject(maths);
            student1GradeBook.addSubject(chemistry);
            student1GradeBook.addSubject(english);

            student1GradeBook.addExamAttended(s1QuartelyExam);
            gradeBooks.Add(student1GradeBook);


            // Student 2 Exam scores
            SubjectScore s2PhysicsScore = new SubjectScore(physics, 60);
            SubjectScore s2MathsScore = new SubjectScore(maths, 60);
            SubjectScore s2ChemistryScore = new SubjectScore(chemistry, 60);
            SubjectScore s2EnglishScore = new SubjectScore(english, 60);

            List<SubjectScore> s2SubjectScoredMarks = new List<SubjectScore>();
            s2SubjectScoredMarks.Add(s2PhysicsScore);
            s2SubjectScoredMarks.Add(s2MathsScore);
            s2SubjectScoredMarks.Add(s2ChemistryScore);
            s2SubjectScoredMarks.Add(s2EnglishScore);

            Exam s2QuartelyExam = new Exam("Quartely", s2SubjectScoredMarks);

            GradeBook student2GradeBook = new GradeBook(student2);
            student2GradeBook.addSubject(physics);
            student2GradeBook.addSubject(maths);
            student2GradeBook.addSubject(chemistry);
            student2GradeBook.addSubject(english);

            student2GradeBook.addExamAttended(s2QuartelyExam);
            gradeBooks.Add(student2GradeBook);


            // Student 3 Exam scores
            SubjectScore s3PhysicsScore = new SubjectScore(physics, 60);
            SubjectScore s3MathsScore = new SubjectScore(maths, 70);
            SubjectScore s3ChemistryScore = new SubjectScore(chemistry, 50);
            SubjectScore s3EnglishScore = new SubjectScore(english, 40);

            List<SubjectScore> s3SubjectScoredMarks = new List<SubjectScore>();
            s3SubjectScoredMarks.Add(s3PhysicsScore);
            s3SubjectScoredMarks.Add(s3MathsScore);
            s3SubjectScoredMarks.Add(s3ChemistryScore);
            s3SubjectScoredMarks.Add(s3EnglishScore);

            Exam s3QuartelyExam = new Exam("Quartely", s3SubjectScoredMarks);

            GradeBook student3GradeBook = new GradeBook(student3);
            student3GradeBook.addSubject(physics);
            student3GradeBook.addSubject(maths);
            student3GradeBook.addSubject(chemistry);
            student3GradeBook.addSubject(english);

            student3GradeBook.addExamAttended(s3QuartelyExam);
            gradeBooks.Add(student3GradeBook);


            Dictionary<Grade, List<String>> studentGrades = new Dictionary<Grade, List<String>>();
            foreach(GradeBook gradeBook in gradeBooks)
            {
                Grade grade = gradeBook.getGrade("Quartely");

                String studentName = gradeBook.GetStudent().getName();

                if (studentGrades.ContainsKey(grade))
                {
                    studentGrades[grade].Add(studentName);
                } else
                {
                    List<String> studentNames = new List<String>();
                    studentNames.Add(studentName);

                    studentGrades.Add(grade, studentNames);
                }
                
            }

            List<String> AGradeList = new List<string>();
            List<String> BGradeList = new List<string>();
            List<String> CGradeList = new List<string>();

            if (studentGrades.ContainsKey(Grade.A))
            {
                AGradeList = studentGrades[Grade.A];
            }

            if (studentGrades.ContainsKey(Grade.B))
            {
                BGradeList = studentGrades[Grade.B];
            }

            if (studentGrades.ContainsKey(Grade.C))
            {
                CGradeList = studentGrades[Grade.C];
            }

            // Statistics to find Low, Medium and High grade students
            Console.WriteLine("******************************************");
            Console.WriteLine("Grade A");
            foreach(String studentName in AGradeList)
            {
                Console.WriteLine(studentName);
            }
            Console.WriteLine("******************************************");

            Console.WriteLine("Grade B");
            foreach (String studentName in BGradeList)
            {
                Console.WriteLine(studentName);
            }
            Console.WriteLine("******************************************");
            Console.WriteLine("Grade C");
            foreach (String studentName in CGradeList)
            {
                Console.WriteLine(studentName);
            }
            Console.WriteLine("******************************************");

        }
    }
}
