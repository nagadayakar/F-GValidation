using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace AgentValidation.Models
{
    [XmlRoot(ElementName = "UserAuthRequest")]
    public class UserAuthRequest
    {

        [XmlElement(ElementName = "UserLoginName")]
        public string UserLoginName { get; set; }
    }
}
