using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.Bl.DTOs.User
{
    public class ErrorResponse
    {
        public string Error { get; set; }

        public ErrorResponse(string error)
        {
            Error = error;
        }
    }
}
