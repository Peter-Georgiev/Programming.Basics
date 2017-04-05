using System;
class Hospital
{
    static void Main()
    {
        int period = int.Parse(Console.ReadLine());

        int patientsTreated = 0;
        int patientsUntreated = 0;
        int doctor = 7;
        for (int i = 1; i <= period; i++)
        {
            if (i % 3 == 0 && patientsUntreated > patientsTreated)
            {
                doctor++;
            }
            int patientsDays = int.Parse(Console.ReadLine());
            if (patientsDays > doctor)
            {
                patientsUntreated += patientsDays - doctor;
                patientsTreated += patientsDays - (patientsDays - doctor);
            }
            else
            {
                patientsTreated += doctor - (doctor - patientsDays);
            }
        }
        Console.WriteLine($"Treated patients: {patientsTreated}.");
        Console.WriteLine($"Untreated patients: {patientsUntreated}.");
    }
}