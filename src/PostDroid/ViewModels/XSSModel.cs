using System.Collections.Generic;

namespace SuperPostDroidPunk.ViewModels
{
    public class XSSModel
    {
        public string ParamName { get; set; }

        public IEnumerable<string> XssValues {get;set;}
    }
}