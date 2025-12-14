using System;
// Stores participant info and validates input

public class Participant
{
    public int ID { get; private set; }
    public string Name { get; set; }
    public string Email { get; set; }
    // Create participant and validate ID, name, and email

    public Participant(int id, string name, string email)
    {
        if (id <= 0)
            throw new ArgumentException("ID must be greater than 0");
        if (string.IsNullOrWhiteSpace(name))
            throw new ArgumentException("Name required");
        if (string.IsNullOrWhiteSpace(email) || !email.Contains("@"))
            throw new ArgumentException("Invalid email");

        ID = id;
        Name = name;
        Email = email;
    }
}

