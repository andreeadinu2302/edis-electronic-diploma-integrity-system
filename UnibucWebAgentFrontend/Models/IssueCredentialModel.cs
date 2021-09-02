using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UnibucWebAgentFrontend.Models
{
    public class IssueCredentialModel
    {
        public bool auto_remove { get; set; }
        public string comment { get; set; }
        public string connection_id { get; set; }
        public CredentialProposal credential_proposal { get; set; }
        public Filter filter { get; set; }
        public bool trace { get; set; }
    }

    public class Filter
    {
        public Indy indy { get; set; }
    }

    public class Indy
    {
        public string cred_def_id { get; set; }
        public string issuer_did { get; set; }
        public string schema_id { get; set; }
        public string schema_issuer_did { get; set; }
        public string schema_name { get; set; }
        public string schema_version { get; set; }
    }

    public class CredentialProposal
    {
        public string @type { get; set; }
        public List<CredentialAttributes> attributes { get; set; }
    }

    public class CredentialAttributes
    {
        public string name { get; set; }
        public string value { get; set; }
    }
}
