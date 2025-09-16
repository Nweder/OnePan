// src/backend/OnePan.Dpp.Api/Controllers/DppController.cs
using Microsoft.AspNetCore.Mvc;
using OnePan.Dpp.Application.Dtos;
using OnePan.Dpp.Infrastructure.Repositories;
using DppEntity = OnePan.Dpp.Domain.Entities.Dpp;

namespace OnePan.Dpp.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class DppController : ControllerBase
{
    private static readonly InMemoryDppRepository Repo = new();

    [HttpGet("{productId}")]
    public IActionResult Get(string productId)
    {
        DppEntity? dpp = Repo.Get(productId);
        return dpp is null ? NotFound(new { error = "Product not found" }) : Ok(dpp);
    }

    [HttpPost("{productId}/co2")]
    public IActionResult Update(string productId, [FromBody] Co2UpdateDto dto)
    {
        var dpp = Repo.Save(productId, dto.Co2);
        return Ok(dpp);
    }
}
