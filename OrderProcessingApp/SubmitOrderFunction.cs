using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace OrderProcessingApp;

public class SubmitOrderFunction
{
    private readonly ILogger<SubmitOrderFunction> _logger;

    public SubmitOrderFunction(ILogger<SubmitOrderFunction> logger)
    {
        _logger = logger;
    }

    [Function("SubmitOrderFunction")]
    public IActionResult Run([HttpTrigger(AuthorizationLevel.Function, "get", "post")] HttpRequest req)
    {
        _logger.LogInformation("C# HTTP trigger function processed a request.");
        return new OkObjectResult("Welcome to Azure Functions!");
    }
}
