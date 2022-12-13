using Microsoft.AspNetCore.Mvc;

namespace GiftingAPI.Controllers;

public class PeopleController : ControllerBase
{
    private readonly IPeopleCatalog _peopleCatalog;

    public PeopleController(IPeopleCatalog peopleCatalog)
    {
        _peopleCatalog = peopleCatalog;
    }

    // GET /people
    [HttpGet("/people")]
    public async Task<ActionResult> GetAllPeople()
    {
        PersonResponse response = await _peopleCatalog.GetPeopleAsync();
        return Ok(response);
    }
}
