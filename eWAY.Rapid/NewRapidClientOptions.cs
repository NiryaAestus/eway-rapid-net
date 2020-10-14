using System;

namespace eWAY.Rapid {
    public sealed class NewRapidClientOptions 
    {
        public string ApiKey { get; set; }
        public string Password { get; set; }
        public string RapidEndpoint { get; set; }
        public Action<BeforeRequestEvent> BeforeRequest { get; set; }
        public Action<AfterRequestEvent> AfterRequest { get; set; }
    }
}
