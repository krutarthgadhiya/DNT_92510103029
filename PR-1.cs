using System;

class StudentAdmission
{
    // Private Data Members
    private string name;
    private int age;
    private double percentage;
    private int entranceScore;
    private char english;
    private char documents;

    // Constructor
    public StudentAdmission(string name, int age, double percentage,
                            int entranceScore, char english, char documents)
    {
        this.name = name;
        this.age = age;
        this.percentage = percentage;
        this.entranceScore = entranceScore;
        this.english = Char.ToUpper(english);
        this.documents = Char.ToUpper(documents);
    }

    // Method to Check Eligibility
    public void CheckEligibility()
    {
        Console.WriteLine("\n -> Admission Result");

        if (age < 17)
        {
            Console.WriteLine("Not Eligible!");
            Console.WriteLine("Reason: Minimum age should be 17.");
            return;
        }

        if (percentage < 60)
        {
            Console.WriteLine("Not Eligible!");
            Console.WriteLine("Reason: Minimum 60% in Class 12.");
            return;
        }

        if (entranceScore < 50)
        {
            Console.WriteLine("Not Eligible!");
            Console.WriteLine("Reason: Entrance exam score should be at least 50.");
            return;
        }

        if (english != 'Y')
        {
            Console.WriteLine("Not Eligible!");
            Console.WriteLine("Reason: English proficiency required.");
            return;
        }

        if (documents != 'Y')
        {
            Console.WriteLine("Not Eligible!");
            Console.WriteLine("Reason: Required documents missing.");
            return;
        }

        Console.WriteLine("\nCongratulations " + name + "!");
        Console.WriteLine("You are Eligible for University Admission.");

        // Hostel Questions
        Console.Write("\nDo you require Hostel? (Y/N): ");
        char hostel = Char.ToUpper(Console.ReadLine()[0]);

        if (hostel == 'Y')
        {
            Console.WriteLine("\n -> Hostel Preferences ");

            Console.WriteLine("1. AC Room");
            Console.WriteLine("2. Non-AC Room");
            Console.Write("Select Room Type (1 or 2): ");
            int roomType = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n -> Room Sharing Options");
            Console.WriteLine("1. Single Sharing");
            Console.WriteLine("2. Double Sharing");
            Console.WriteLine("3. Triple Sharing");
            Console.Write("Select Option (1-3): ");
            int sharing = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nDo you require Mess Facility? (Y/N): ");
            char mess = Char.ToUpper(Console.ReadLine()[0]);

            Console.Write("Do you need Laundry Service? (Y/N): ");
            char laundry = Char.ToUpper(Console.ReadLine()[0]);

            Console.WriteLine("\n -> Hostel Allocation ");

            Console.Write("Room Type: ");
            if (roomType == 1)
                Console.WriteLine("AC");
            else
                Console.WriteLine("Non-AC");

            Console.Write("Sharing: ");
            switch (sharing)
            {
                case 1:
                    Console.WriteLine("Single Sharing");
                    break;
                case 2:
                    Console.WriteLine("Double Sharing");
                    break;
                case 3:
                    Console.WriteLine("Triple Sharing");
                    break;
                default:
                    Console.WriteLine("Invalid Choice");
                    break;
            }

            Console.WriteLine("Mess Facility: " + (mess == 'Y' ? "Yes" : "No"));
            Console.WriteLine("Laundry Service: " + (laundry == 'Y' ? "Yes" : "No"));

            Console.WriteLine("\nHostel request submitted successfully.");
        }
        else
        {
            Console.WriteLine("\nHostel not required.");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("\n -> UNIVERSITY ADMISSION MANAGEMENT");

        Console.Write("Enter Student Name: ");
        string name = Console.ReadLine();

        Console.Write("Enter Age: ");
        int age = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter 12th Percentage: ");
        double percentage = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter Entrance Exam Score (0-100): ");
        int score = Convert.ToInt32(Console.ReadLine());

        Console.Write("Do you have English Proficiency? (Y/N): ");
        char english = Char.ToUpper(Console.ReadLine()[0]);

        Console.Write("Do you have all Required Documents? (Y/N): ");
        char documents = Char.ToUpper(Console.ReadLine()[0]);

        // Create Object
        StudentAdmission student = new StudentAdmission(
            name, age, percentage, score, english, documents);

        // Check Eligibility
        student.CheckEligibility();

        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}
