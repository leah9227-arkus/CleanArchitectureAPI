using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.Incfrastructure.Settings
{
    public class JwtSettings
    {
        public const string SectionName = "JwtSettings";
        public string Secret { get; set; }
        public string Issuer { get; set; }
        public string Audience { get; set; }
        public int ExpirationDateInDays { get; set; }
    }
}