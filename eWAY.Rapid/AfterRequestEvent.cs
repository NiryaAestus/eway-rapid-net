using System;
using System.Net;

namespace eWAY.Rapid {
    /// <summary>
    /// Event handler for event handling invoked directly before an Event occurs.
    /// </summary>
    public class AfterRequestEvent : EventArgs
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
        public HttpWebResponse Respose { get; }

        /// <summary>
        /// 
        /// </summary>
        public string ResponseBody { get; }

        /// <summary>
        /// 
        /// </summary>
        public object UserData { get; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestBody"></param>
        /// <param name="response"></param>
        /// <param name="responseBody"></param>
        /// <param name="userData"></param>
        internal AfterRequestEvent(HttpWebRequest request, string requestBody, HttpWebResponse response, string responseBody, object userData)
        {
            Request = request;
            RequestBody = requestBody;
            Respose = response;
            ResponseBody = responseBody;
            UserData = userData;
        }
    }

}
