using System;
// Represents a single seat in the workshop

public class Seat
{
    public int RowNumber { get; private set; }
    public int SeatNumber { get; private set; }
    public string SectionType { get; private set; }

    public bool IsBooked { get; private set; }
    public Participant AssignedParticipant { get; private set; }
    public DateTime ReservationTime { get; private set; }

    public Seat(int row, int seat, string section)
    {
        RowNumber = row;
        SeatNumber = seat;
        SectionType = section;

        IsBooked = false;
        AssignedParticipant = null;
    }
   
    
    // Book seat and save reservation time

    public bool AssignParticipant(Participant p)
    {
        if (IsBooked)
            return false;

        AssignedParticipant = p;
        IsBooked = true;
        ReservationTime = DateTime.Now;
        return true;
    }

    public string GetSeatStatus()
    {
        if (!IsBooked)
            return "Row " + RowNumber + " Seat " + SeatNumber + " (" + SectionType + ") - FREE";

        return "Row " + RowNumber + " Seat " + SeatNumber + " (" + SectionType +
               ") - TAKEN by " + AssignedParticipant.Name +
               " at " + ReservationTime;
    }
}
