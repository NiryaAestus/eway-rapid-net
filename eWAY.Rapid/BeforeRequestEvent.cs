using System;
using System.Net;

namespace eWAY.Rapid {
    /// <summary>
    /// Event handler for event handling invoked directly before an Event occurs.
    /// </summary>
    public class BeforeRequestEvent : EventArgs 
    {
        /// <summary>
        /// 
        /// </summary>
        public HttpWebRequest Request { get; }
        
        /// <summary>
        /// 
        /// </summary>
        public string RequestBody { get; }

        /// <summary>
        /// 
        /// </summary>
        public object UserData { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestBody"></param>
        internal BeforeRequestEvent(HttpWebRequest request, string requestBody) 
        {
            Request = request;
            RequestBody = requestBody;
            UserData = null;
        }
    }
}
