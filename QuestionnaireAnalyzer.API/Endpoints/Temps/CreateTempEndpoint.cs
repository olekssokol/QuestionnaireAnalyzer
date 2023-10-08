using Ardalis.ApiEndpoints;
using ManagedCode.Communication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using QuestionnaireAnalyzer.Contracts.Commands.Test;
using QuestionnaireAnalyzer.Contracts.Constants;
using QuestionnaireAnalyzer.Contracts.Interfaces.Handlers;
using QuestionnaireAnalyzer.Contracts.Models.Test;
using QuestionnaireAnalyzer.Common.Extensions;

namespace QuestionnaireAnalyzer.API.Endpoints.Tests;

public class CreateTempEndpoint: EndpointBaseAsync
    .WithRequest<UpsertTempCommand>
    .WithActionResult<Result<TempModel>>
{
    private readonly ITempsHendler _tempsHendler;
    private readonly ILogger<CreateTempEndpoint> _logger;

    public CreateTempEndpoint(ITempsHendler tempsHendler, ILogger<CreateTempEndpoint> logger)
    {
        _tempsHendler = tempsHendler;
        _logger = logger;
    }

    [HttpPost(ApiEndpoints.Temps.Create)]
    public override async Task<ActionResult<Result<TempModel>>> HandleAsync(
       UpsertTempCommand upsertTempCommand,
        CancellationToken cancellationToken = default)
    {
        return await _tempsHendler.CreateTempAsync(upsertTempCommand).ToActionResult();
    }
}
