using Ardalis.Result;
using MediatR;
using Server.Module1.Contracts.Message.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.Module1.Contracts.Message.Queries
{
    public class GetMessageQuery:IRequest<Result<GetMessageResponseDto>>
    {
        public required string Text { get; set; }
    }
}
