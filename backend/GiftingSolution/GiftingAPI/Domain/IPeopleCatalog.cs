using GiftingAPI.Models;

namespace GiftingAPI.Domain;

public interface IPeopleCatalog
{
    Task<PersonResponse> GetPeopleAsync();
}