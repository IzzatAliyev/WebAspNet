// Copyright (c) IUA. All rights reserved.

namespace Web.Api;

using Web.Api.DB;
using Web.Api.Model;

/// <summary>
/// Generator.
/// </summary>
public static class Generator
{
    /// <summary>
    /// Create cars.
    /// </summary>
    public static void CreateCars()
    {
        using (AppDbContext db = new AppDbContext())
        {
            for (int i = 0; i < 5; i++)
            {
                Car car = new Car
                {
                    Id = i,
                    Name = $"Tom {i}",
                    Price = 200 + i,
                };

                db.Car.Add(car);
            }

            db.SaveChanges();
        }
    }
}
