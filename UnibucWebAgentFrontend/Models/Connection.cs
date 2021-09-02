using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UnibucWebAgentFrontend.Models
{
    public class Connection
    {
        public string their_role { get; set; }
        public string rfc23_state { get; set; }
        public string accept { get; set; }
        public string their_did { get; set; }
        public string their_label { get; set; }
        public string connection_protocol { get; set; }
        public string created_at { get; set; }
        public string invitation_mode { get; set; }
        public string my_did { get; set; }
        public string routing_state { get; set; }
        public string state { get; set; }
        public string invitation_key { get; set; }
        public string connection_id { get; set; }
        public string alias { get; set; }
    }

    public class ConnectionsResponse
    {
        public List<Connection> results { get; set; }
    }

    public class CreateConnectionResponse
    {
        public string invitation_url { get; set; }
    }
}
