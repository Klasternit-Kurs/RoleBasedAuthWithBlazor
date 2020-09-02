using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace BlazorAuthorization.Shared
{
    public class RegisterResult
    {
        public bool Successful { get; set; }
        public IEnumerable<string> Errors { get; set; }
    }
}
