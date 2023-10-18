using System.Net;
using System.Xml;
using System.Xml.Serialization;
using AgentValidation.Models;
using AgentValidation.Models.FGAgentValidationRequest;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Azure.Functions.Worker.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using static AgentValidation.Models.NsTXLife;

namespace AgentValidation
{
    public class Function1
    {
        private readonly ILogger _logger;

        public Function1(ILoggerFactory loggerFactory)
        {
            _logger = loggerFactory.CreateLogger<Function1>();
        }

        [Function("Function1")]
        public async Task<HttpResponseData> RunAsync([HttpTrigger(AuthorizationLevel.Function, "get", "post")] HttpRequestData req)
        {
            _logger.LogInformation("C# HTTP trigger function processed a request.");
            string requestBody = await new StreamReader(req.Body).ReadToEndAsync();
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(requestBody);
            string jsonText = JsonConvert.SerializeXmlNode(doc);
            var alipRequestObject = JsonConvert.DeserializeObject<Models.Root>(jsonText);

            // MAPPING 
            var FGValidationRequest = CreateMappingRequest(alipRequestObject);
            

            var response = req.CreateResponse(HttpStatusCode.OK);
            response.Headers.Add("Content-Type", "text/plain; charset=utf-8");
            response.WriteString("Welcome to Azure Functions!");

            return response;

            // 1. Sample successful request
            // 2. I will create custom c# class model for this
            // 3. I will extract the fields from request and then I will map this to out going req(f&g)
            // 4. I will convert f&g model into xml
            // 5. Finally we will call the f&g webserive using basic authentication.

        }

        private Models.FGAgentValidationRequest.Root CreateMappingRequest(Models.Root AlipRequest)
        {
            Models.FGAgentValidationRequest.Root rootFGAgentValieationRequest = new Models.FGAgentValidationRequest.Root();
            SourceInfo sourceInfo = new SourceInfo();
            Policy policy = new Policy();
            ApplicationInfo applicationInfo = new ApplicationInfo();
            Annuity annuity = new Annuity();
            Payout payout = new Payout();
            Holding holding = new Holding();
            Envelope envelope = new Envelope();
            Body body = new Body();
            GetEAppAgentValidationDetails details = new GetEAppAgentValidationDetails();
            Request request = new Request();
            Models.FGAgentValidationRequest.TXLifeRequest tXLifeRequest = new Models.FGAgentValidationRequest.TXLifeRequest();
            Models.FGAgentValidationRequest.OLifE oLifE = new Models.FGAgentValidationRequest.OLifE();
            Models.FGAgentValidationRequest.Party party = new Party();
            Models.FGAgentValidationRequest.Producer producer = new Models.FGAgentValidationRequest.Producer();
            Models.FGAgentValidationRequest.CarrierAppointment carrierAppointment = new CarrierAppointment();
            var relation = new Models.FGAgentValidationRequest.Relation();
            details.request = request;
            tXLifeRequest.TransRefGUID = AlipRequest.nsTXLife.nsTXLifeRequest.nsTransRefGUID;
            tXLifeRequest.TransType = AlipRequest.nsTXLife.nsTXLifeRequest.nsTransSubType.text;
            tXLifeRequest.TransExeDate = AlipRequest.nsTXLife.nsTXLifeRequest.nsTransExeDate;
            tXLifeRequest.TransExeTime = AlipRequest.nsTXLife.nsTXLifeRequest.nsTransExeTime;
            
            sourceInfo.SourceInfoName = "ALIP";
            oLifE.SourceInfo = sourceInfo;

            //Need to check
            //relation.OriginatingObjectType = 
            // RelatedObjectType
            // RelatedRefIDType
            // RelationRoleCode
            // RelatedRefID

            // Party : PartyTypeCode

            party.PartyTypeCode = "Person";
            
            holding.HoldingTypeCode = AlipRequest.nsTXLife.nsTXLifeRequest.nsOLifE.nsHolding.nsHoldingTypeCode.text;
            holding.CurrencyTypeCode = "USD (United States Dollar)";

            // Policy :

            //payout.PayoutAmt
            //annuity.QualPlanType
            //policy.CusipNum
            //policy.ApplicationInfo
            //policy.LineOfBusiness


            request.TXLifeRequest = tXLifeRequest;
            tXLifeRequest.OLifE = oLifE;
            producer.CarrierAppointment= carrierAppointment;
            party.Producer = producer;
            oLifE.Party = party;
            oLifE.Relation= relation;
            annuity.Payout = payout;
            policy.Annuity = annuity;
            holding.Policy = policy;
            oLifE.Holding= holding;
            body.GetEAppAgentValidationDetails = details;
            envelope.Body = body;
            rootFGAgentValieationRequest.Envelope = envelope;
            

            return rootFGAgentValieationRequest;
        }
    }
}
