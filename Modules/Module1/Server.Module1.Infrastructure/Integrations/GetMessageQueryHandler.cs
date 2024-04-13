using Ardalis.Result;
using MediatR;
using Server.Module1.Contracts.Message.Dtos;
using Server.Module1.Contracts.Message.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.Module1.Infrastructure.Integrations
{
    internal class GetMessageQueryHandler : IRequestHandler<GetMessageQuery, Result<GetMessageResponseDto>>
    {
        public Task<Result<GetMessageResponseDto>> Handle(GetMessageQuery request, CancellationToken cancellationToken) => 
            Task.FromResult(Result<GetMessageResponseDto>.Success(new GetMessageResponseDto() { Text = request.Text }));
    }
}
