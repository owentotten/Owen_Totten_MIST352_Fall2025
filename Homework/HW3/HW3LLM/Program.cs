using System;

class Program
{
    static void Main()
    {
        WorkshopSession session = new WorkshopSession();

        while (true)
        {
            ShowMenu();
            int choice = ReadInt("Choice: ");

            switch (choice)
            {
                case 1:
                    AssignFlow(session, preferPremium: true);
                    break;

                case 2:
                    AssignFlow(session, preferPremium: false);
                    break;

                case 3:
                    session.DisplayAllSeats();
                    break;

                case 4:
                    Console.WriteLine("Thank you for using the system.");
                    return;

                case 9:
                    DebugFillAllSeats(session); // required
                    break;

                default:
                    Console.WriteLine("Invalid choice.\n");
                    break;
            }
        }
    }

    static void ShowMenu()
    {
        Console.WriteLine("1) Assign Premium seat");
        Console.WriteLine("2) Assign Standard seat");
        Console.WriteLine("3) Display all seats");
        Console.WriteLine("4) Exit");
        Console.WriteLine("9) DEBUG fill all seats");
    }

    static void AssignFlow(WorkshopSession session, bool preferPremium)
    {
        if (session.IsWorkshopFull())
        {
            Console.WriteLine("Workshop is full.\n");
            return;
        }

        Participant p;
        try
        {
            int id = ReadInt("Enter ID: ");
            string name = ReadNonEmpty("Enter Name: ");
            string email = ReadNonEmpty("Enter Email: ");

            p = new Participant(id, name, email);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Invalid participant: " + ex.Message + "\n");
            return;
        }

        bool assigned = preferPremium
            ? session.AssignPremiumSeat(p)
            : session.AssignStandardSeat(p);

        if (assigned)
        {
            Console.WriteLine("Seat assigned.\n");
            return;
        }

        // Section full -> ask to swap
        if (preferPremium)
        {
            Console.Write("Premium is full. Assign Standard instead? (Y/N): ");
            if (AskYesNo())
            {
                if (session.AssignStandardSeat(p))
                    Console.WriteLine("Seat assigned.\n");
            }
            else
            {
                Console.WriteLine("Next workshop starts in 3 hours.\n");
            }
        }
        else
        {
            Console.Write("Standard is full. Assign Premium instead? (Y/N): ");
            if (AskYesNo())
            {
                if (session.AssignPremiumSeat(p))
                    Console.WriteLine("Seat assigned.\n");
            }
            else
            {
                Console.WriteLine("Next workshop starts in 3 hours.\n");
            }
        }
    }

    static bool AskYesNo()
    {
        string? s = Console.ReadLine();
        return s != null && s.Trim().Equals("Y", StringComparison.OrdinalIgnoreCase);
    }

    static int ReadInt(string prompt)
    {
        while (true)
        {
            Console.Write(prompt);
            string? s = Console.ReadLine();
            if (int.TryParse(s, out int value)) return value;
            Console.WriteLine("Invalid number.");
        }
    }

    static string ReadNonEmpty(string prompt)
    {
        while (true)
        {
            Console.Write(prompt);
            string? s = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(s)) return s.Trim();
            Console.WriteLine("Cannot be empty.");
        }
    }

    // ===== REQUIRED – DO NOT EDIT =====
    static void DebugFillAllSeats(WorkshopSession session)
    {
        int nextId = 9000;

        while (!session.IsWorkshopFull())
        {
            bool preferPremium = !session.IsPremiumFull();

            string section = preferPremium ? "Premium" : "Standard";
            Participant p = new Participant(
                nextId,
                $"{section}_Debug_{nextId}",
                $"{section.ToLower()}{nextId}@test.com"
            );

            bool assigned = preferPremium
                ? session.AssignPremiumSeat(p)
                : session.AssignStandardSeat(p);

            if (!assigned)
            {
                if (preferPremium && !session.IsStandardFull())
                    session.AssignStandardSeat(p);
                else if (!preferPremium && !session.IsPremiumFull())
                    session.AssignPremiumSeat(p);
            }

            nextId++;
        }

        Console.WriteLine("DEBUG: All seats auto-filled.\n");
    }
}

