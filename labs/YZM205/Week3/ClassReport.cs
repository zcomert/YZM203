namespace Week3
{
    public class ClassReport
    {
        Student[] students;
        int counter; // = 0;

        public ClassReport(int size = 4)
        {
            students = new Student[size];
            counter = 0;
        }

        public void Add(Student student)
        {
            if (counter == students.Length)
                throw new StackOverflowException("Dizi dolu, yeni eleman eklenemez!");
            students[counter] = student;
            counter++;
        }

        public Student Remove()
        {
            if (counter == 0)
                throw new ArgumentNullException("Dizi boş, çıkartma yapılamaz!");
            Student student = students[counter-1];
            students[counter-1] = default;
            counter--;
            return student;
        }

        public void Display()
        {
            for (int i = 0; i < counter; i++)
            {
                Console.WriteLine($"Öğrenci Adı: {students[i].studentName} {students[i].studentSurname}\n" +
                    $"Vize Notu: {students[i].midtermScore}\n" +
                    $"Final Notu: {students[i].finalScore}\n" +
                    $"Harf Notu: {students[i].NoteCalculator()}\n" +
                    $"Başarı Durumu: {students[i].PassCalculator()}\n");
            }
        }
    }
}
