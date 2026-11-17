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



void PrintStudentsCard(string name, int age, string numberGroup)
{
    Console.WriteLine($"Студент: {name}, возраст: {age}, номер группы {numberGroup}");
}

PrintStudentsCard("Егор", 18, "ИСП-254");
PrintStudentsCard("Валерий", 17, "РУПО-265");