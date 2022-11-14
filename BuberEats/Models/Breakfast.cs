public class Breakfast
{
    Guid Id { get; }
    string Name { get; }
    string Description { get; }
    DateTime StartDateTime { get; }
    DateTime EndDateTime { get; }
    DateTime LastModifiedDateTime { get; }
    List<string> Savory { get; }
    List<string> Sweet { get; }

    public Breakfast(
    Guid id,
    string name,
    string description,
    DateTime startDateTime,
    DateTime endDateTime,
    DateTime lastModifiedDateTime,
    List<string> savory,
    List<string> sweet)

    {
        Id = id;
        Name = name;
        Description = description;
        StartDateTime = startDateTime;
        EndDateTime = endDateTime;
        LastModifiedDateTime = lastModifiedDateTime;
        Savory = savory;
        Sweet = sweet;
    }
}