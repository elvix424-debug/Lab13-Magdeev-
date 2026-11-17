// PrintHeader();
// PrintHeader();
// Console.WriteLine("Основная часть программы");
// PrintFooter();

// void PrintHeader()
// {
//     Console.WriteLine("^_^");
//     Console.WriteLine("Лабораторная работа №13");
//     Console.WriteLine("Дата формирования отчёта: 17.11.2026");
//     Console.WriteLine("0_0");
// }

// void PrintFooter()
// {
//     Console.WriteLine(">_<");
//     Console.WriteLine("   Конец программы");
//     Console.WriteLine("Х_Х");
// }



// void PrintStudentsCard(string name, int age, string numberGroup)
// {
//     Console.WriteLine($"Студент: {name}, возраст: {age}, номер группы {numberGroup}");
// }

// PrintStudentsCard("Егор", 18, "ИСП-254");
// PrintStudentsCard("Валерий", 17, "РУПО-265");


// double averageGrade = 4.7;
// double result;

// double CalculateScholarship(double baseAmount, double bonusPercent) {
//     return baseAmount + baseAmount * bonusPercent / 100;
// }

// bool IsEligibleForBonus(double averageGrade)
// {
//     return averageGrade >= 4.5;
// }

// if (IsEligibleForBonus(averageGrade)) {
//     result = CalculateScholarship(2000, 15);
// } else {
//     result = CalculateScholarship(2000, 0);
// }

// Console.WriteLine(result);



double CalculateAverageGrade(int[] grades)
{
    int sum = 0;
    foreach (int grade in grades)
    {
        sum += grade;
    }
    return (double)sum / grades.Length;
}
int CountFives(int[] grades)
{
    int count = 0;
    foreach (int cn in grades)
    {
        if (cn == 5)
        {
            count++;
        }
    }
     return count;
}

int[] grades = { 4, 5, 3, 5, 4 };
double average = CalculateAverageGrade(grades);
Console.WriteLine(average);
Console.WriteLine(CountFives(grades));