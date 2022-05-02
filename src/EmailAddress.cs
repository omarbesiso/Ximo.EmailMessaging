using System.Net.Mail;
using System.Text;

namespace Ximo.EmailMessaging;

public class EmailAddress : MailAddress
{
    public EmailAddress(string address) : base(address.ToLowerInvariant())
    {
    }

    public EmailAddress(string address, string? displayName) : base(address.ToLowerInvariant(), displayName)
    {
    }

    public EmailAddress(string address, string? displayName, Encoding? displayNameEncoding) : base(
        address.ToLowerInvariant(), displayName, displayNameEncoding)
    {
    }
}