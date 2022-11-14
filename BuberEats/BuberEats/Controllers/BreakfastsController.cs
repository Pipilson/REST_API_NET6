using Microsoft.AspNetCore.Mvc;

[ApiController]

public class BreakfastsController : ControllerBase
{
    private readonly IBreakfastService _breakfastService;
    
    public BreakfastsController(IBreakfastService breakfastService)
    {
        _breakfastService = breakfastService;
    }

    [HttpPost("/breakfasts")]
    public IActionResult CreateBreakfast(CreateBreakfastRequest request)
    {
        var breakfast = new Breakfast(
            Guid.NewGuid(),
            request.Name,
            request.Description,
            request.StartDateTime,
            request.EndDateTime,
            DateTime.UtcNow,
            request.Savory,
            request.Sweet);

        var response = new BreakfastResponse(
            breakfast.Id,
            breakfast.Name,
            breakfast.Description,
            breakfast.StartDateTime,
            breakfast.EndDateTime,
            breakfast.LastModifiedDateTime,
            breakfast.Savory,
            breakfast.Sweet);

        return CreatedAtAction(
            nameof(GetBreakfast),
            new {id = breakfast.Id},
            response);
    }

    [HttpGet("/breakfasts/{id:guid}")]
    public IActionResult GetBreakfast(Guid id)
    {
        return Ok(id);
    }

    [HttpPut("/breakfasts/{id:guid}")]
    public IActionResult UpsertBreakfast(Guid id, UpsertBreakfastRequest request)
    {
        return Ok(request);
    }

    [HttpDelete("/breakfasts/{id:guid}")]
    public IActionResult DeleteBreakfast(Guid id)
    {
        return Ok(id);
    }
}

internal interface IBreakfastService
{
}