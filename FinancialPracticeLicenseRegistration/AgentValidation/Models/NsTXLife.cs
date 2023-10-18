using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace AgentValidation.Models
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class NsAddress
    {
        [JsonProperty("ns:AddressStateTC")]
        public NsAddressStateTC nsAddressStateTC { get; set; }
    }

    public class NsAddressStateTC
    {
        [JsonProperty("@tc")]
        public string tc { get; set; }

        [JsonProperty("#text")]
        public string text { get; set; }
    }

    public class NsApplicationInfo
    {
        [JsonProperty("ns:ApplicationJurisdiction")]
        public NsApplicationJurisdiction nsApplicationJurisdiction { get; set; }

        [JsonProperty("ns:SignedDate")]
        public string nsSignedDate { get; set; }

        [JsonProperty("ns:ApplicationCollectionDate")]
        public string nsApplicationCollectionDate { get; set; }
    }

    public class NsApplicationJurisdiction
    {
        [JsonProperty("@tc")]
        public string tc { get; set; }
    }

    public class NsCarrierAppointment
    {
        [JsonProperty("ns:DistributionChannelInfo")]
        public NsDistributionChannelInfo nsDistributionChannelInfo { get; set; }
    }

    public class NsDistributionChannel
    {
        [JsonProperty("@tc")]
        public string tc { get; set; }
    }

    public class NsDistributionChannelInfo
    {
        [JsonProperty("ns:DistributionChannel")]
        public NsDistributionChannel nsDistributionChannel { get; set; }
    }

    public class NsHolding
    {
        [JsonProperty("@id")]
        public string id { get; set; }

        [JsonProperty("ns:HoldingTypeCode")]
        public NsHoldingTypeCode nsHoldingTypeCode { get; set; }

        [JsonProperty("ns:Policy")]
        public NsPolicy nsPolicy { get; set; }
    }

    public class NsHoldingTypeCode
    {
        [JsonProperty("@tc")]
        public string tc { get; set; }

        [JsonProperty("#text")]
        public string text { get; set; }
    }

    public class NsOLifE
    {
        [JsonProperty("ns:Holding")]
        public NsHolding nsHolding { get; set; }

        [JsonProperty("ns:Party")]
        public List<NsParty> nsParty { get; set; }

        [JsonProperty("ns:Relation")]
        public List<NsRelation> nsRelation { get; set; }
    }

    public class NsOLifEExtension
    {
        [JsonProperty("ns:LegalEntityCode")]
        public string nsLegalEntityCode { get; set; }

        [JsonProperty("ns:DetachedOfficeCode")]
        public object nsDetachedOfficeCode { get; set; }
    }

    public class NsOriginatingObjectType
    {
        [JsonProperty("@tc")]
        public string tc { get; set; }

        [JsonProperty("#text")]
        public string text { get; set; }
    }

    public class NsParty
    {
        [JsonProperty("@id")]
        public string id { get; set; }

        [JsonProperty("ns:GovtID")]
        public string nsGovtID { get; set; }

        [JsonProperty("ns:Producer")]
        public NsProducer nsProducer { get; set; }

        [JsonProperty("ns:Address")]
        public NsAddress nsAddress { get; set; }
    }

    public class NsPolicy
    {
        [JsonProperty("ns:ProductCode")]
        public string nsProductCode { get; set; }

        [JsonProperty("ns:PolicyStatus")]
        public NsPolicyStatus nsPolicyStatus { get; set; }

        [JsonProperty("ns:ApplicationInfo")]
        public NsApplicationInfo nsApplicationInfo { get; set; }
    }

    public class NsPolicyStatus
    {
        [JsonProperty("@tc")]
        public string tc { get; set; }

        [JsonProperty("#text")]
        public string text { get; set; }
    }

    public class NsProducer
    {
        [JsonProperty("ns:NIPRNumber")]
        public string nsNIPRNumber { get; set; }

        [JsonProperty("ns:CarrierAppointment")]
        public NsCarrierAppointment nsCarrierAppointment { get; set; }

        [JsonProperty("ns:OLifEExtension")]
        public NsOLifEExtension nsOLifEExtension { get; set; }
    }

    public class NsRelatedObjectType
    {
        [JsonProperty("@tc")]
        public string tc { get; set; }

        [JsonProperty("#text")]
        public string text { get; set; }
    }

    public class NsRelation
    {
        [JsonProperty("@id")]
        public string id { get; set; }

        [JsonProperty("@OriginatingObjectID")]
        public string OriginatingObjectID { get; set; }

        [JsonProperty("@RelatedObjectID")]
        public string RelatedObjectID { get; set; }

        [JsonProperty("ns:OriginatingObjectType")]
        public NsOriginatingObjectType nsOriginatingObjectType { get; set; }

        [JsonProperty("ns:RelatedObjectType")]
        public NsRelatedObjectType nsRelatedObjectType { get; set; }

        [JsonProperty("ns:RelationRoleCode")]
        public NsRelationRoleCode nsRelationRoleCode { get; set; }

        [JsonProperty("ns:InterestPercent")]
        public string nsInterestPercent { get; set; }
    }

    public class NsRelationRoleCode
    {
        [JsonProperty("@tc")]
        public string tc { get; set; }

        [JsonProperty("#text")]
        public string text { get; set; }
    }

    public class NsTransSubType
    {
        [JsonProperty("@tc")]
        public string tc { get; set; }

        [JsonProperty("#text")]
        public string text { get; set; }
    }

    public class NsTransType
    {
        [JsonProperty("@tc")]
        public string tc { get; set; }

        [JsonProperty("#text")]
        public string text { get; set; }
    }


    //[DataContract(Name = "ns:TXLife")]
    public class NsTXLife
    {
        [JsonProperty("@xmlns:ns")]
        public string xmlnsns { get; set; }

        [JsonProperty("ns:UserAuthRequest")]
        public NsUserAuthRequest nsUserAuthRequest { get; set; }

        [JsonProperty("ns:TXLifeRequest")]
        public NsTXLifeRequest nsTXLifeRequest { get; set; }
    }

    public class NsTXLifeRequest
    {
        [JsonProperty("ns:TransRefGUID")]
        public string nsTransRefGUID { get; set; }

        [JsonProperty("ns:TransType")]
        public NsTransType nsTransType { get; set; }

        [JsonProperty("ns:TransSubType")]
        public NsTransSubType nsTransSubType { get; set; }

        [JsonProperty("ns:TransExeDate")]
        public string nsTransExeDate { get; set; }

        [JsonProperty("ns:TransExeTime")]
        public string nsTransExeTime { get; set; }

        [JsonProperty("ns:OLifE")]
        public NsOLifE nsOLifE { get; set; }
    }

    public class NsUserAuthRequest
    {
        [JsonProperty("ns:UserLoginName")]
        public string nsUserLoginName { get; set; }
    }

    public class Root
    {
        [JsonProperty("ns:TXLife")]
        public NsTXLife nsTXLife { get; set; }
    }

}
