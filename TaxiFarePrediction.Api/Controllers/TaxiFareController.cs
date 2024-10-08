using Microsoft.AspNetCore.Mvc;
using TaxiFarePrediction.Api.Adapter;
using static TaxiFarePrediction_Core.TaxiFareModel;

namespace TaxiFarePrediction.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class TaxiFareController : ControllerBase
{
    [HttpPost]
    [Route("/TaxiFare/Calculate")]
    public IActionResult Post([FromBody] ModelInput input)
    {
        var prediction = Predict(input);
        var taxiValue = ModelOutputAdapter.Adapt(input, prediction);
        return Ok(taxiValue);
    }
}
