using System;
using System.Text;

namespace SIS.HTTP
{
    public class ResponseCookie : Cookie
    {
        public ResponseCookie(string name, string value)
            : base (name, value)
        {
            this.SameSite = SameSiteType.Lax;
            this.Path = "/";
            this.Expires = DateTime.UtcNow.AddDays(30);
        }

        public string Domain { get; set; }

        public string Path { get; set; }

        public DateTime? Expires { get; set; }

        public long? MaxAge { get; set; }

        public bool Secure { get; set; }

        public bool HttpOnly { get; set; }

        public SameSiteType SameSite { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"{this.Name}={this.Value}");

            if (this.MaxAge.HasValue)
            {
                sb.Append("; MaxAge=" + this.MaxAge.Value.ToString());
            }
            else if (this.Expires.HasValue)
            {
                sb.Append("; Expires=" + this.Expires.Value.ToString("R"));
            }

            if (!string.IsNullOrWhiteSpace(this.Domain))
            {
                sb.Append("; Domain=" + this.Domain);
            }

            if (!string.IsNullOrWhiteSpace(this.Path))
            {
                sb.Append("; Path=" + this.Path);
            }

            if (this.Secure)
            {
                sb.Append("; Secure");
            }

            if (this.HttpOnly)
            {
                sb.Append("; HttpOnly");
            }

            sb.Append("; SameSite=" + this.SameSite.ToString());

            return sb.ToString();
        }
    }
}
