using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OnePan.Dpp.Domain.Entities;


// src/backend/OnePan.Dpp.Infrastructure/Repositories/InMemoryDppRepository.cs
using DppEntity = OnePan.Dpp.Domain.Entities.Dpp;

namespace OnePan.Dpp.Infrastructure.Repositories;

public class InMemoryDppRepository
{
    private readonly Dictionary<string, DppEntity> _store = new();

    public DppEntity? Get(string productId) =>
        _store.TryGetValue(productId, out var dpp) ? dpp : null;

    public DppEntity Save(string productId, double co2)
    {
        var dpp = new DppEntity
        {
            ProductId = productId,
            Co2 = co2,
            UpdatedAt = DateTime.UtcNow
        };
        _store[productId] = dpp;
        return dpp;
    }
}

