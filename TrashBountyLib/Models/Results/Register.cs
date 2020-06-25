using System.Collections.Generic;

namespace TrashBountyLib.Models.Results
{
    public class RegisterResult
    {
        public bool Successful { get; set; }
        public IEnumerable<string> Errors { get; set; }
    }
}