using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace UnibucWebAgentFrontend.Models
{
    public class ServerStatusResponse
    {
        [JsonPropertyName("config")]
        public ServerConfiguration Configuration { get; set; }
    }

    public class ServerConfiguration
    {
        [JsonPropertyName("ledger.genesis_url")]
        public string Ledger { get; set; }

        [JsonPropertyName("default_endpoint")]
        public string Endpoint { get; set; }

        [JsonPropertyName("tails_server_base_url")]
        public string RevocationEndpoint { get; set; }

    }
}
