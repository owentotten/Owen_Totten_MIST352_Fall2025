using System;
using System.Collections.Generic;



// Manages all seats and booking logic

public class WorkshopSession
{
    private List<Seat> seats;

    public WorkshopSession()
    {
        seats = new List<Seat>();
        
        // Rows 1–5 = Premium, Rows 6–10 = Standard

        for (int row = 1; row <= 10; row++)
        {
            string section;
            if (row <= 5)
                section = "Premium";
            else
                section = "Standard";

            seats.Add(new Seat(row, 1, section));
            seats.Add(new Seat(row, 2, section));
        }
    }

    public bool AssignPremiumSeat(Participant p)
    {
        return AssignSeatInRange(p, 1, 5);
    }

    public bool AssignStandardSeat(Participant p)
    {
        return AssignSeatInRange(p, 6, 10);
    }

    // Find first available seat in given rows

    private bool AssignSeatInRange(Participant p, int startRow, int endRow)
    {
        for (int i = 0; i < seats.Count; i++)
        {
            if (!seats[i].IsBooked &&
                seats[i].RowNumber >= startRow &&
                seats[i].RowNumber <= endRow)
            {
                return seats[i].AssignParticipant(p);
            }
        }
        return false;
    }

    public bool IsPremiumFull()
    {
        return IsRangeFull(1, 5);
    }

    public bool IsStandardFull()
    {
        return IsRangeFull(6, 10);
    }

    public bool IsWorkshopFull()
    {
        for (int i = 0; i < seats.Count; i++)
        {
            if (!seats[i].IsBooked)
                return false;
        }
        return true;
    }

    private bool IsRangeFull(int startRow, int endRow)
    {
        for (int i = 0; i < seats.Count; i++)
        {
            if (!seats[i].IsBooked &&
                seats[i].RowNumber >= startRow &&
                seats[i].RowNumber <= endRow)
                return false;
        }
        return true;
    }

    public void DisplayAllSeats()
    {
        for (int i = 0; i < seats.Count; i++)
        {
            Console.WriteLine(seats[i].GetSeatStatus());
        }
        Console.WriteLine();
    }
}

