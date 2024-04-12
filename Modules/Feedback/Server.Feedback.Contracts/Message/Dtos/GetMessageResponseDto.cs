using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.Feedback.Contracts.Message.Dtos
{
    public class GetMessageResponseDto
    {
        public required string Text { get; set; }
    }
}
