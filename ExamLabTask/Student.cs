using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamLabTask
{
    internal class Student
    {
        public string Name;
        public string Surname;
        public string Faculty;
        public char ResultWithLetter;
        public Exam[] ExamsEntry;
        public Exam[] ExamsOut;

        public Student(string name, string surname, string faculty)
        {
            Name = name;
            Surname = surname;
            Faculty = faculty;
        }
        public void CheckExam(Student student)
        {
            Console.WriteLine($"Telebe: {student.Name} {student.Surname}");

            for (int i = 0; i < student.ExamsEntry.Length; i++)
            {
                string examName = student.ExamsEntry[i].ExamName;
                int totalScore = student.ExamsEntry[i].Score + student.ExamsOut[i].Score;
                ResultWithLetter = '0';

                if (student.ExamsEntry[i].Score >= 17)
                {
                    if (totalScore > 50 && totalScore < 60)
                    {
                        ResultWithLetter = 'E';
                    }
                    else if (totalScore > 60 && totalScore < 70)
                    {
                        ResultWithLetter = 'D';
                    }
                    else if (totalScore > 70 && totalScore < 80)
                    {
                        ResultWithLetter = 'C';
                    }
                    else if (totalScore > 80 && totalScore < 90)
                    {
                        ResultWithLetter = 'B';
                    }
                    else if (totalScore > 90 && totalScore < 100)
                    {
                        ResultWithLetter = 'A';
                    }
                    else
                    {
                        Console.WriteLine(examName + " " + "imtahanindan kesilmisiz..");
                    }

                    if (ResultWithLetter != '0') Console.WriteLine(examName + " imtahanindan neticeniz: " + ResultWithLetter);
                }
                else
                {
                    Console.WriteLine(examName + " " + "imtahanina buraxilmirsiz..");
                }
            }
        }

        public void StudentInfo()
        {
            Console.WriteLine($"Fullname:{Name} {Surname},Faculty:{Faculty}");
        }
    }
}
