﻿#nullable disable

namespace Models
{
    public class Appsettings
    {
        public JwtSettings JwtSettings { get; set; }

        public MailSettings Mail { get; set; }
    }

    public class JwtSettings
    {
        public string Issuer { get; set; }

        public string Key { get; set; }
    }

    public class MailSettings
    {
        public IEnumerable<string> Recipients { get; set; }

        public AWS Aws { get; set; }
    }

    public class AWS
    {
        public string AccessKeyId { get; set; }

        public string SecretAccessKey { get; set; }

        public Source Source { get; set; }

        public bool HasValue => !string.IsNullOrWhiteSpace(AccessKeyId)
            && !string.IsNullOrWhiteSpace(SecretAccessKey)
            && !string.IsNullOrWhiteSpace(Source.Domain)
            && !string.IsNullOrWhiteSpace(Source.Arn);
    }

    public class Source
    {
        public string Domain { get; set; }

        public string Arn { get; set; }
    }
}
