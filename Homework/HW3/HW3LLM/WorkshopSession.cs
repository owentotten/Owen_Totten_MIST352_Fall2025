using System;
using System.Collections.Generic;
using System.Linq;

public class WorkshopSession
{
    private readonly List<Seat> _seats;

    // “Viewable only” outside (no one can add/remove seats)
    public IReadOnlyList<Seat> Seats => _seats;

    public WorkshopSession()
    {
        // Build 20 seats: 10 rows x 2 seats
        _seats = Enumerable
            .Range(1, 10)
            .SelectMany(row =>
            {
                SectionType section = (row <= 5) ? SectionType.Premium : SectionType.Standard;
                return new[]
                {
                    new Seat(row, 1, section),
                    new Seat(row, 2, section)
                };
            })
            .ToList();
    }

    // REQUIRED public API (used by DebugFillAllSeats)
    public bool AssignPremiumSeat(Participant p) => AssignSeat(p, SectionType.Premium);
    public bool AssignStandardSeat(Participant p) => AssignSeat(p, SectionType.Standard);

    // REQUIRED checks (used by DebugFillAllSeats)
    public bool IsPremiumFull() => !_seats.Any(s => !s.IsBooked && s.Section == SectionType.Premium);
    public bool IsStandardFull() => !_seats.Any(s => !s.IsBooked && s.Section == SectionType.Standard);
    public bool IsWorkshopFull() => _seats.All(s => s.IsBooked);

    public void DisplayAllSeats()
    {
        Console.WriteLine();
        foreach (Seat seat in _seats)
            Console.WriteLine(seat.GetSeatStatus());
        Console.WriteLine();
    }

    // Internal helper: assign first available seat in a given section
    private bool AssignSeat(Participant p, SectionType section)
    {
        Seat? seat = _seats.FirstOrDefault(s => !s.IsBooked && s.Section == section);
        return seat != null && seat.AssignParticipant(p);
    }
}
