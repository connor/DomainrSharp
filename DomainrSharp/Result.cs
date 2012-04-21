﻿using System.Runtime.Serialization;

#if (SILVERLIGHT && !WINDOWS_PHONE)
namespace DomainrSharp.Silverlight
#elif WINDOWS_PHONE
namespace DomainrSharp.WindowsPhone
#else
namespace DomainrSharp
#endif
{
    [DataContract]
    public class Result
    {
        [DataMember(Name="domain")]
        public string Domain { get; set; }
        [DataMember(Name = "host")]
        public string Host { get; set; }
        [DataMember(Name = "subdomain")]
        public string Subdomain { get; set; }
        [DataMember(Name = "path")]
        public string Path { get; set; }
        [DataMember(Name = "availability")]
        public string Availability { get; set; }
        [DataMember(Name = "register_url")]
        public string RegisterUrl { get; set; }
    }
}
