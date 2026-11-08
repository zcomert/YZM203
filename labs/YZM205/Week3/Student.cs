namespace Week3
{
    public class Student
    {
        // Field
        public int studentId;
        public string studentName;
        public string studentSurname;
        public float midtermScore;
        public float finalScore;

        // Property

        // Constructor
        public Student(int studentId, string studentName, string studentSurname, float midtermScore, float finalScore)
        {
            this.studentId = studentId;
            this.studentName = studentName;
            this.studentSurname = studentSurname;
            this.midtermScore = ValueChecker(midtermScore);
            this.finalScore = ValueChecker(finalScore);
        }

        // Methods
        float ValueChecker(float value)
        {
            if (value >= 0 && value <= 100)
                return value;
            throw new ArgumentOutOfRangeException("Verilen değer sınırlar dışında!");
        }

        public float FinalResult() => (midtermScore * 0.4f) + (finalScore * 0.6f);

        public string NoteCalculator()
        {
            float value = FinalResult();
            if (value >= 85)
                return "AA";
            else if (value >= 70)
                return "BB";
            else if (value >= 60)
                return "CC";
            else if (value >= 50)
                return "DD";
            else return "FF";
        }

        public string PassCalculator()
        {
            float value = FinalResult();
            if (value >= 60)
                return "Geçti";
            return "Kaldi";
        }
    }
}