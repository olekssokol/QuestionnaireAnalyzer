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

public class CreateDirEndpoint: EndpointBaseAsync
    .WithRequest<UpsertDirCommand>
    .WithActionResult<Result<DirModel>>
{
    private readonly IDirsHendler _DirsHendler;
    private readonly ILogger<CreateDirEndpoint> _logger;

    public CreateDirEndpoint(IDirsHendler DirsHendler, ILogger<CreateDirEndpoint> logger)
    {
        _DirsHendler = DirsHendler;
        _logger = logger;
    }

    [HttpPost(ApiEndpoints.Dirs.Create)]
    public override async Task<ActionResult<Result<DirModel>>> HandleAsync(
       UpsertDirCommand upsertDirCommand,
        CancellationToken cancellationToken = default)
    {
        return await _DirsHendler.CreateDirAsync(upsertDirCommand).ToActionResult();
    }
}
