namespace ExamLabTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("Punhan", "Aliyeva", "MexMat");
            student1.ExamsEntry = new Exam[5];
            student1.ExamsEntry[0] = new Exam("Math", 16);
            student1.ExamsEntry[1] = new Exam("English", 33);
            student1.ExamsEntry[2] = new Exam("History", 34);
            student1.ExamsEntry[3] = new Exam("Geometry", 35);
            student1.ExamsEntry[4] = new Exam("Programming", 36);

            student1.ExamsOut = new Exam[5];
            student1.ExamsOut[0] = new Exam("Math", 33);
            student1.ExamsOut[1] = new Exam("English", 33);
            student1.ExamsOut[2] = new Exam("History", 34);
            student1.ExamsOut[3] = new Exam("Geometry", 35);
            student1.ExamsOut[4] = new Exam("Programming", 36);

            Student student2 = new Student("Selma", "Mammedli", "History");
            student2.ExamsEntry = new Exam[5];
            student2.ExamsEntry[0] = new Exam("Math", 35);
            student2.ExamsEntry[1] = new Exam("English", 46);
            student2.ExamsEntry[2] = new Exam("History", 34);
            student2.ExamsEntry[3] = new Exam("Geometry", 19);
            student2.ExamsEntry[4] = new Exam("Programming", 27);

            student2.ExamsOut = new Exam[5];
            student2.ExamsOut[0] = new Exam("Math", 42);
            student2.ExamsOut[1] = new Exam("English", 37);
            student2.ExamsOut[2] = new Exam("History", 23);
            student2.ExamsOut[3] = new Exam("Geometry", 35);
            student2.ExamsOut[4] = new Exam("Programming", 29);

            Student student3 = new Student("Narmin", "Valizada", "Law");
            student3.ExamsEntry = new Exam[5];
            student3.ExamsEntry[0] = new Exam("Math", 22);
            student3.ExamsEntry[1] = new Exam("English", 33);
            student3.ExamsEntry[2] = new Exam("History", 15);
            student3.ExamsEntry[3] = new Exam("Geometry", 35);
            student3.ExamsEntry[4] = new Exam("Programming", 47);

            student3.ExamsOut = new Exam[5];
            student3.ExamsOut[0] = new Exam("Math", 32);
            student3.ExamsOut[1] = new Exam("English", 33);
            student3.ExamsOut[2] = new Exam("History", 34);
            student3.ExamsOut[3] = new Exam("Geometry", 35);
            student3.ExamsOut[4] = new Exam("Programming", 36);

            Student[] students = { student1, student2, student3 };

            foreach (var stu in students)
            {
                stu.CheckExam(stu);
                Console.WriteLine();
            }
        }
    }
}