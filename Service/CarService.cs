// Copyright (c) IUA. All rights reserved.

namespace Web.Service;

using Microsoft.EntityFrameworkCore;
using Web.DB;
using Web.Dto.Req;
using Web.Dto.Res;
using Web.Model;

/// <summary>
/// Car service.
/// </summary>
public class CarService : ICarService
{
    private readonly AppDbContext appDbContext;

    /// <summary>
    /// Initializes a new instance of the <see cref="CarService"/> class.
    /// </summary>
    /// <param name="appDbContext">the db context.</param>
    public CarService(AppDbContext appDbContext)
    {
        this.appDbContext = appDbContext;
    }

    /// <inheritdoc/>
    public async Task<bool> AddCar(CarRequest car)
    {
        Car newCar = new Car { Name = car.name, Price = car.price };
        await this.appDbContext.Set<Car>().AddAsync(newCar);
        await this.appDbContext.SaveChangesAsync();
        return true;
    }

    /// <inheritdoc/>
    public async Task<bool> DeleteCar(int id)
    {
        var userToDelete = await this.appDbContext.Set<Car>().FirstOrDefaultAsync(u => u.Id == id);
        if (userToDelete != null)
        {
            this.appDbContext.Set<Car>().Remove(userToDelete);
            await this.appDbContext.SaveChangesAsync();

            return true;
        }

        return false;
    }

    /// <inheritdoc/>
    public async ValueTask<CarResponse> GetCar(int id)
    {
        Car? car = await this.appDbContext.Set<Car>().FindAsync(id);
        if (car != null && car.Name != null)
        {
            return new CarResponse(car.Name, car.Price);
        }

        return null!;
    }

    /// <inheritdoc/>
    public async IAsyncEnumerable<CarResponse> GetCars()
    {
        var responseList = new List<CarResponse>();
        var carList = await this.appDbContext.Set<Car>().ToListAsync();
        foreach (var car in carList)
        {
            if (car.Name != null)
            {
                yield return new CarResponse(car.Name, car.Price);
            }
        }
    }

    /// <inheritdoc/>
    public async Task<bool> UpdateCar(int id, CarRequest car)
    {
        var userToUpdate = await this.appDbContext.Set<Car>().FirstOrDefaultAsync(x => x.Id == id);
        if (userToUpdate != null)
        {
            userToUpdate.Name = car.name != null ? car.name : userToUpdate.Name;
            userToUpdate.Price = car.price != 0 ? car.price : userToUpdate.Price;
            await this.appDbContext.SaveChangesAsync();
            return true;
        }

        return false;
    }
}
