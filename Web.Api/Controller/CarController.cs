// Copyright (c) IUA. All rights reserved.

namespace Web.Api.Controller;

using System.Net.Mime;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OutputCaching;
using Web.Api.Dto.Req;
using Web.Api.Service;

/// <summary>
/// Car controller.
/// </summary>
[ApiController]
[Route("api/[controller]")]
public class CarController : ControllerBase
{
    private readonly ICarService carService;

    /// <summary>
    /// Initializes a new instance of the <see cref="CarController"/> class.
    /// </summary>
    /// <param name="carService">the car service.</param>
    public CarController(ICarService carService)
    {
        this.carService = carService;
    }

    /// <summary>
    /// Get cars.
    /// </summary>
    /// <returns>the list of cars.</returns>
    [HttpGet]
    [OutputCache(PolicyName = "Cars")]
    [Produces(MediaTypeNames.Application.Json)]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public ActionResult GetCars()
    {
        return this.Ok(this.carService.GetCars());
    }

    /// <summary>
    /// Get car by id.
    /// </summary>
    /// <param name="id">the id of car.</param>
    /// <returns>the car.</returns>
    [HttpGet("{id}")]
    [OutputCache(PolicyName = "Car")]
    [Produces(MediaTypeNames.Application.Json)]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public async Task<ActionResult> GetCar([FromRoute] int id)
    {
        return this.Ok(await this.carService.GetCar(id));
    }

    /// <summary>
    /// Add car.
    /// </summary>
    /// <param name="car">the car.</param>
    /// <returns>true, if car created.</returns>
    [HttpPost]
    [Produces(MediaTypeNames.Application.Json)]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public async Task<ActionResult> AddCar([FromBody] CarRequest car)
    {
        return this.Ok(await this.carService.AddCar(car));
    }

    /// <summary>
    /// Update car.
    /// </summary>
    /// <param name="id">the id of car.</param>
    /// <param name="car">the car.</param>
    /// <returns>true, if car updated.</returns>
    [HttpPatch("{id}")]
    [Produces(MediaTypeNames.Application.Json)]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public async Task<ActionResult> UpdateCar([FromRoute] int id, [FromBody] CarRequest car)
    {
        return this.Ok(await this.carService.UpdateCar(id, car));
    }

    /// <summary>
    /// Delete car.
    /// </summary>
    /// <param name="id">the id of car.</param>
    /// <returns>true, if car updated.</returns>
    [HttpDelete("{id}")]
    [Produces(MediaTypeNames.Application.Json)]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public async Task<ActionResult> DeleteCar([FromRoute] int id)
    {
        return this.Ok(await this.carService.DeleteCar(id));
    }
}
