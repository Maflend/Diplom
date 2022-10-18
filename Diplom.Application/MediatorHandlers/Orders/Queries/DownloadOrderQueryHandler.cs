using Diplom.Application.Abstracts.Mediator.Orders.Queries;
using MediatR;

namespace Diplom.Application.MediatorHandlers.Orders.Queries;

public class DownloadOrderQueryHandler : IRequestHandler<DownloadOrderQuery, Stream>
{
    private readonly string _path = "D:\\Orders";

    public DownloadOrderQueryHandler()
    {

    }

    public async Task<Stream> Handle(DownloadOrderQuery request, CancellationToken cancellationToken)
    {
        return new FileStream($"{_path}\\{request.OrderId}.txt", FileMode.Open);
    }
}
