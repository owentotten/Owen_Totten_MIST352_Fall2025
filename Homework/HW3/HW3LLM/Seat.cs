using System;

public class Seat
{
    public int RowNumber { get; }
    public int SeatNumber { get; }
    public SectionType Section { get; }

    public bool IsBooked { get; private set; }
    public Participant? AssignedParticipant { get; private set; }
    public DateTime? ReservationTime { get; private set; }

    public Seat(int rowNumber, int seatNumber, SectionType section)
    {
        if (rowNumber < 1 || rowNumber > 10) throw new ArgumentOutOfRangeException(nameof(rowNumber));
        if (seatNumber != 1 && seatNumber != 2) throw new ArgumentOutOfRangeException(nameof(seatNumber));

        RowNumber = rowNumber;
        SeatNumber = seatNumber;
        Section = section;

        IsBooked = false;
        AssignedParticipant = null;
        ReservationTime = null;
    }

    public bool AssignParticipant(Participant p)
    {
        if (IsBooked) return false;

        AssignedParticipant = p;
        IsBooked = true;
        ReservationTime = DateTime.Now;
        return true;
    }

    public string GetSeatStatus()
    {
        if (!IsBooked || AssignedParticipant == null || ReservationTime == null)
            return $"Row {RowNumber}, Seat {SeatNumber} ({Section}) - FREE";

        return $"Row {RowNumber}, Seat {SeatNumber} ({Section}) - TAKEN by {AssignedParticipant} at {ReservationTime}";
    }
}
