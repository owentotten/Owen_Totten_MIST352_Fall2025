using System;
using System.Collections.Generic;

//Owen Totten
//12/1/25
//Homework 3 - Workshop Reseervation System



class Program
{
    static void Main()
    {
        WorkshopSession session = new WorkshopSession();

        while (true)
        {
            Console.WriteLine("1) Assign Premium seat");
            Console.WriteLine("2) Assign Standard seat");
            Console.WriteLine("3) Display all seats");
            Console.WriteLine("4) Exit");
            Console.WriteLine("9) DEBUG fill all seats");

            int choice = ReadInt("Choice: ");

            if (choice == 1)
                AddParticipant(session, "Premium");
            else if (choice == 2)
                AddParticipant(session, "Standard");
            else if (choice == 3)
                session.DisplayAllSeats();
            else if (choice == 4)
                break;
            else if (choice == 9)
                DebugFillAllSeats(session);
            else
                Console.WriteLine("Invalid choice\n");
        }
    }

    static void AddParticipant(WorkshopSession session, string section)
    {
        if (session.IsWorkshopFull())
        {
            Console.WriteLine("Workshop is full\n");
            return;
        }

        int id = ReadInt("Enter ID: ");
        Console.Write("Enter Name: ");
        string name = Console.ReadLine();
        Console.Write("Enter Email: ");
        string email = Console.ReadLine();

        Participant p;
        try
        {
            p = new Participant(id, name, email);
        }
        catch
        {
            Console.WriteLine("Invalid participant info\n");
            return;
        }

        bool assigned;

        if (section == "Premium")
            assigned = session.AssignPremiumSeat(p);
        else
            assigned = session.AssignStandardSeat(p);

        if (assigned)
            Console.WriteLine("Seat assigned\n");
        else
            Console.WriteLine("Section full\n");
    }

    static int ReadInt(string prompt)
    {
        while (true)
        {
            Console.Write(prompt);
            int val;
            if (int.TryParse(Console.ReadLine(), out val))
                return val;
            Console.WriteLine("Invalid number");
        }
    }

    // ===== DO NOT EDIT =====
    static void DebugFillAllSeats(WorkshopSession session)
    {
        int nextId = 9000;

        while (!session.IsWorkshopFull())
        {
            bool preferPremium = !session.IsPremiumFull();
            string section = preferPremium ? "Premium" : "Standard";

            Participant p = new Participant(
                nextId,
                section + "_Debug_" + nextId,
                section.ToLower() + nextId + "@test.com"
            );

            bool assigned;
            if (preferPremium)
                assigned = session.AssignPremiumSeat(p);
            else
                assigned = session.AssignStandardSeat(p);

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
