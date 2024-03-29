// Copyright (c) IUA. All rights reserved.

namespace Web.Api.Service;

using Web.Api.Dto.Req;
using Web.Api.Dto.Res;

/// <summary>
/// Interface for car service.
/// </summary>
public interface ICarService
{
    /// <summary>
    /// Get cars.
    /// </summary>
    /// <returns>list of cars.</returns>
    public IAsyncEnumerable<CarResponse> GetCars();

    /// <summary>
    /// Get car by id.
    /// </summary>
    /// <param name="id">the id of car.</param>
    /// <returns>A <see cref="Task{TResult}"/> representing the result of the asynchronous operation.</returns>
    public ValueTask<CarResponse> GetCar(int id);

    /// <summary>
    /// Add new car.
    /// </summary>
    /// <param name="car">the car.</param>
    /// <returns>A <see cref="Task{TResult}"/> representing the result of the asynchronous operation.</returns>
    public Task<bool> AddCar(CarRequest car);

    /// <summary>
    /// Update the car.
    /// </summary>
    /// <param name="id">the id of car.</param>
    /// <param name="car">the car.</param>
    /// <returns>A <see cref="Task{TResult}"/> representing the result of the asynchronous operation.</returns>
    public Task<bool> UpdateCar(int id, CarRequest car);

    /// <summary>
    /// Delete the car by id.
    /// </summary>
    /// <param name="id">the id of car.</param>
    /// <returns>A <see cref="Task{TResult}"/> representing the result of the asynchronous operation.</returns>
    public Task<bool> DeleteCar(int id);
}
