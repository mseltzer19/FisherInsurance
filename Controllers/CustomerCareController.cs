using Microsoft.AspNetCore.Mvc;

[Route("claims")]

public class CustomerCareController : Controller
{
    public IActionResult Index()
    {
        return Ok("This is the index of the CustomerCareController");
    }

  [Route("fileclaim")]
    public IActionResult NewClaim()
    {
        return Ok("This is the new claims of the CustomerCareController");
    }

    [Route("claimstatus")]

    public IActionResult ClaimHistory()
    {
        return Ok("This is the history of claims of the CustomerCareController");
    }
}
