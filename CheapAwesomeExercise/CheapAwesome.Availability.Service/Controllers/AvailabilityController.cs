using System;
using System.Collections.Generic;
using CheapAwesome.Availability.Core.Business;
using Microsoft.AspNetCore.Mvc;

namespace CheapAwesome.Availability.Service.Controllers
{
    /**
     * e.g. https://localhost:44309/api/v1/availabilities?destinationId=5&startDate=2020-08-08&endDate=2020-08-10
     */
    [Route("api/v1/availabilities")]
    [ApiController]
    public class AvailabilityController : ControllerBase
    {
        private readonly AvailabilityService service;

        public AvailabilityController(AvailabilityService service)
        {
            this.service = service;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Core.Domain.Availability>> Get(
            [FromQuery] int destinationId, 
            [FromQuery] DateTime startDate, 
            [FromQuery] DateTime endDate, 
            [FromQuery] string authToken
        ) {
            return Ok(service.GetAvailabilities(destinationId, (int)(endDate - startDate).TotalDays, authToken));
        }
    }
}

