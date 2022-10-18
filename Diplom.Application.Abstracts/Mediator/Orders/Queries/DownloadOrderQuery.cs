using MediatR;

namespace Diplom.Application.Abstracts.Mediator.Orders.Queries;

public record DownloadOrderQuery(Guid OrderId) : IRequest<Stream>;
