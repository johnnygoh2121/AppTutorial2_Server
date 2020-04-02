using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppTutorial2_Server.Class
{

    // an object to send over server 
    // to activate action and verification of token

        /// <summary>
        /// Both client and server need to maintain the same object field
        /// As it use for passing paramater in one whole object
        /// </summary>
    public class Cio
    {        
        public string token { get; set; }
        public string request { get; set; } // used to process action

        /// <summary>
        /// Json ignore attribute 
        /// used to inform json to ignore this field, when convert object into json string
        /// this field with this annotation will be ignore and continue 
        /// </summary>
        [JsonIgnore]
        public string password { get; set; }
    }
}
