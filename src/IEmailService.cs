// ReSharper disable UnusedMember.Global
namespace Ximo.EmailMessaging;

/// <summary>
///     Service contract for sending emails.
/// </summary>
public interface IEmailService
{
    /// <summary>
    ///     Sends the email asynchronously.
    /// </summary>
    /// <param name="email">The recipient of this email message.</param>
    /// <param name="subject">The  subject line for the email message.</param>
    /// <param name="htmlMessage">The message body in HTML format.</param>
    /// <returns>Task.</returns>
    Task SendEmailAsync(string email, string subject, string htmlMessage);

    /// <summary>
    ///     Sends the email asynchronously.
    /// </summary>
    /// <param name="subject">The  subject line for the email message.</param>
    /// <param name="senderEmail">The sender's email address for this email message.</param>
    /// <param name="toRecipients">The collection that contains the recipients of this email message.</param>
    /// <param name="htmlMessage">The message body in HTML format.</param>
    /// <param name="txtMessage">The message body in plain text.</param>
    /// <param name="ccRecipients">The  collection that contains the carbon copy (CC) recipients for the email message.</param>
    /// <param name="bccRecipients">The collection that contains the blind carbon copy (BCC) recipients for the email message.</param>
    /// <returns>A value indicating whether the email was sent successfully.</returns>
    Task<bool> SendEmailAsync(string subject, EmailAddress senderEmail, IEnumerable<EmailAddress> toRecipients,
        string? htmlMessage = null, string? txtMessage = null,
        IEnumerable<EmailAddress>? ccRecipients = null,
        IEnumerable<EmailAddress>? bccRecipients = null);
}