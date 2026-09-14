namespace Domain.Platform.Marketing;
public class NewsLetterSubscriber : BaseEntity
{
    public string Email { get; set; } = default!;
    public bool IsConfirmed { get; set; } = false;
    public string? ConfirmationCode { get; set; }
    public DateTime? ConfirmationCodeSentAtUtc { get; set; }
    public int FailedAttempts { get; set; } 
    public DateTime SubscribedAtUtc { get; set; } = DateTime.UtcNow;
    public DateTime? UnsubscribedAtUtc { get; set; }
}