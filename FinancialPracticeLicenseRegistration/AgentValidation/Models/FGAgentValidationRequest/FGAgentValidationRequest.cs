using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgentValidation.Models.FGAgentValidationRequest
{
    public class FGAgentValidationRequest
    {
    }

    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class Annuity
    {
        public string QualPlanType { get; set; }
        public Payout Payout { get; set; }
    }

    public class ApplicationInfo
    {
        public string ApplicationJurisdiction { get; set; }
        public string ApplicationCollectionDate { get; set; }
        public string ApplicationCollectionTime { get; set; }
    }

    public class Body
    {
        public GetEAppAgentValidationDetails GetEAppAgentValidationDetails { get; set; }
    }

    public class CarrierAppointment
    {
        public int CompanyProducerID { get; set; }
        public string CarrierCode { get; set; }
    }

    public class Envelope
    {
        public Header Header { get; set; }
        public Body Body { get; set; }
    }

    public class GetEAppAgentValidationDetails
    {
        public Request request { get; set; }
    }

    public class Header
    {
        public Security Security { get; set; }
    }

    public class Holding
    {
        public string HoldingTypeCode { get; set; }
        public string CurrencyTypeCode { get; set; }
        public Policy Policy { get; set; }
    }

    public class OLifE
    {
        public SourceInfo SourceInfo { get; set; }
        public Holding Holding { get; set; }
        public Party Party { get; set; }
        public Relation Relation { get; set; }
    }

    public class Party
    {
        public string PartyTypeCode { get; set; }
        public Producer Producer { get; set; }
    }

    public class Payout
    {
        public int PayoutAmt { get; set; }
    }

    public class Policy
    {
        public string LineOfBusiness { get; set; }
        public string ProductType { get; set; }
        public string CusipNum { get; set; }
        public Annuity Annuity { get; set; }
        public ApplicationInfo ApplicationInfo { get; set; }
    }

    public class Producer
    {
        public CarrierAppointment CarrierAppointment { get; set; }
    }

    public class Relation
    {
        public string OriginatingObjectType { get; set; }
        public string RelatedObjectType { get; set; }
        public string RelationRoleCode { get; set; }
        public int RelatedRefID { get; set; }
        public string RelatedRefIDType { get; set; }
    }

    public class Request
    {
        public TXLifeRequest TXLifeRequest { get; set; }
    }

    public class Root
    {
        public Envelope Envelope { get; set; }
    }

    public class Security
    {
        public UsernameToken UsernameToken { get; set; }
    }

    public class SourceInfo
    {
        public string SourceInfoName { get; set; }
    }

    public class TXLifeRequest
    {
        public string TransRefGUID { get; set; }
        public string TransType { get; set; }
        public string TransSubType { get; set; }
        public string TransExeDate { get; set; }
        public string TransExeTime { get; set; }
        public OLifE OLifE { get; set; }
    }

    public class UsernameToken
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
