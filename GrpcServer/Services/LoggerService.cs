using Grpc.Core;

namespace GrpcServer.Services;

public class LoggerService : Logger.LoggerBase
{
    private readonly ILogger<LoggerService> _logger;
    public LoggerService(ILogger<LoggerService> logger)
    {
        _logger = logger;
    }

    public override Task<DefenitionReply> GetRTAInfo(InfoRequest request, ServerCallContext context)
    {
        return Task.FromResult(new DefenitionReply
        {
            Defenition = request.Info + "Два легковых автомобиля, люди не пострадали."
        });
    }
}