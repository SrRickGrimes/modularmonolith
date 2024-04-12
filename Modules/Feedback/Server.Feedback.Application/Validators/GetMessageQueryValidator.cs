using FluentValidation;
using Server.Feedback.Contracts.Message.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.Feedback.Application.Validators
{
    internal class GetMessageQueryValidator:AbstractValidator<GetMessageQuery>
    {
        public GetMessageQueryValidator()
        {
            RuleFor(x=> x.Text).NotEmpty();
        }
    }
}
