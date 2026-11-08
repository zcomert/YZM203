
using Week3;

ClassReport report = new ClassReport(5);
report.Add(new Student(111, "Deniz", "Bora", 70.0f, 80.0f));
report.Add(new Student(112, "Mehmet", "Kar", 50.0f, 35.0f));
report.Add(new Student(113, "Ece", "Yağmur", 95.0f, 65.0f));

report.Display();