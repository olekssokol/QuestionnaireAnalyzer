using ManagedCode.Communication;
using Microsoft.AspNetCore.Mvc;

namespace QuestionnaireAnalyzer.Common.Extensions;

public static class ResultExtensions
{
    public static IActionResult ToActionResult<T>(this Result<T> result)
    {
        if (result.IsSuccess)
        {
            return new OkObjectResult(result);
        }
        else
        {
            return new BadRequestObjectResult(result);
        }
    }

    public static IActionResult ToActionResult(this Result result)
    {
        if (result.IsSuccess)
        {
            return new OkObjectResult(result);
        }
        else
        {
            return new BadRequestObjectResult(result);
        }
    }

    public static async Task<ActionResult<Result<T>>> ToActionResult<T>(this Task<Result<T>> task)
    {
        var response = await task;

        if (response.IsSuccess)
        {
            return new OkObjectResult(response);
        }
        else
        {
            return new BadRequestObjectResult(response);
        }
    }

    public static async Task<ActionResult<Result>> ToActionResult(this Task<Result> task)
    {
        var response = await task;

        if (response.IsSuccess)
        {
            return new OkObjectResult(response);
        }
        else
        {
            return new BadRequestObjectResult(response);
        }
    }

    public static async Task<ActionResult<CollectionResult<T>>> ToActionResult<T>(this Task<CollectionResult<T>> task)
    {
        var response = await task;

        if (response.IsSuccess)
        {
            return new OkObjectResult(response);
        }
        else
        {
            return new BadRequestObjectResult(response);
        }
    }
}
