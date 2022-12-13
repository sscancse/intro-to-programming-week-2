namespace GiftingAPI.Domain;

public class PersonEntity
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime CreatedAt { get; set; }
    public bool UnFriended { get; set; } = false;
}
