﻿using FastEndpoints;
using MediatR;
using Server.Module1.Contracts.Message.Dtos;
using Server.Module1.Contracts.Message.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.Module1.EndPoints.HelloWorld
{
    internal class GetHelloWorldEndPoint(ISender sender) : Endpoint<GetMessageQuery,GetMessageResponseDto>
    {
        public override void Configure()
        {

            Post("/hello/world");
            AllowAnonymous(); ;
        }

        public override async Task HandleAsync(GetMessageQuery req, CancellationToken ct)
        {
            var response = await sender.Send(new GetMessageQuery { Text = req.Text}, ct);
           if(response.IsSuccess)
            {
                await SendOkAsync(response.Value, ct);
                return;
            }
            await SendErrorsAsync(400, ct);
        }
    }
}
