using System;

namespace eWAY.Rapid 
{
    /// <summary>
    /// Options to create an IRapidClient.
    /// </summary>
    public sealed class NewRapidClientOptions
    {
        /// <summary>
        /// API Key. User-name in the basic authentication used by the API.
        /// </summary>
        public string ApiKey { get; set; }
        /// <summary>
        /// API Password. Password in the basic authentication used by the API.
        /// </summary>
        public string Password { get; set; }
        /// <summary>
        /// Endpoint to use. "Sandbox", "Production" or a custom URL.
        /// </summary>
        public string RapidEndpoint { get; set; }
        /// <summary>
        /// Invoked before every HTTP Request. You can set a UserData field which will be provided in the AfterRequest handler.
        /// </summary>
        public Action<BeforeRequestEvent> BeforeRequest { get; set; }
        /// <summary>
        /// Invoked after every HTTP Request. Will include the UserData field set in the corresponding BeforeRequest call.
        /// </summary>
        public Action<AfterRequestEvent> AfterRequest { get; set; }
    }
}
