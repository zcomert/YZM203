float ValueChecker(float value)
{
    if (value >= 0 && value <= 100)
        return value;
    throw new Exception("Input need to be between 0 to 100!");
}

float FinalNoteCalculator(float midterm, float final)
=> (midterm * 0.4f) + (final * 0.6f);

string NoteCalculator(float value)
{
    if (value >= 85)
        return "AA";
    else if (value >= 70)
        return "BB";
    else if (value >= 60)
        return "CC";
    else if (value >= 50)
        return "DD";
    else
        return "FF";
}

string PassChecker(float value)
{
    if (value >= 60)
        return "Geçti";
    return "Kaldı";
}

int[] studentId = new int[10];
string[] studentName = new string[10];
string[] studentSurname = new string[10];
float[] studentMidterm = new float[10];
float[] studentFinal = new float[10];

studentId[0] = 111;
studentName[0] = "Deniz";
studentSurname[0] = "Bora";
studentMidterm[0] = ValueChecker((float)70.0);
studentFinal[0] = ValueChecker(80.0f);

studentId[1] = 112;
studentName[1] = "Mehmet";
studentSurname[1] = "Kar";
studentMidterm[1] = ValueChecker((float)50.0);
studentFinal[1] = ValueChecker(35.0f);

for (int i = 0; i < 2; i++)
{
    Console.WriteLine($"Öğrenci Numarası: {studentId[i]}\n" +
    $"Öğrenci Adı: {studentName[i]}\n" +
    $"Öğrenci Soyadı: {studentSurname[i]}\n" +
    $"Vize: {studentMidterm[i]}\n" +
    $"Final: {studentFinal[i]}");
    float finalNote = FinalNoteCalculator(studentMidterm[i], studentFinal[i]);
    Console.WriteLine($"Harf Notu: {NoteCalculator(finalNote)}");
    Console.WriteLine($"Başarı Durumu: {PassChecker(finalNote)}");
    Console.WriteLine();
}
