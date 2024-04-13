using FluentValidation;
using Server.Module1.Contracts.Message.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.Module1.Application.Validators
{
    internal class GetMessageQueryValidator:AbstractValidator<GetMessageQuery>
    {
        public GetMessageQueryValidator()
        {
            RuleFor(x=> x.Text).NotEmpty();
        }
    }
}
