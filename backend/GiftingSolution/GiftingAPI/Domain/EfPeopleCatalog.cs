using GiftingAPI.Adapters;

namespace GiftingAPI.Domain;

public class EfPeopleCatalog : IPeopleCatalog
{
    private readonly GiftingDataContext _context;

    public EfPeopleCatalog(GiftingDataContext context)
    {
        _context = context;
    }

    public async Task<PersonResponse> GetPeopleAsync()
    {
        var data = await _context.People
            .Where(x => x.UnFriended == false)
            .Select(x => new PersonItemResponse(x.Id.ToString(), x.FirstName.ToString(), x.LastName.ToString()))
            .ToListAsync();

        return new PersonResponse(data);
    }
}
