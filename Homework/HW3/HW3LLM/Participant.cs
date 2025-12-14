using System;

public record Participant
{
    public int ID { get; }
    public string Name { get; set; }
    public string Email { get; set; }

    public Participant(int id, string name, string email)
    {
        if (id <= 0) throw new ArgumentOutOfRangeException(nameof(id), "ID must be > 0.");
        if (string.IsNullOrWhiteSpace(name)) throw new ArgumentException("Name required.", nameof(name));
        if (string.IsNullOrWhiteSpace(email) || !email.Contains("@"))
            throw new ArgumentException("Email must contain @.", nameof(email));

        ID = id;
        Name = name.Trim();
        Email = email.Trim();
    }

    public override string ToString() => $"{Name} (ID {ID})";
}

