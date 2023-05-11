namespace Coinbase.Commerce.Models.Models.Statuses;

public enum TransactionStatuses
{
    None,
    New,
    Pending,
    Completed,
    Overdue,
    Unresolved,
    Resolved,
    Refunded,
    PendingRefund,
    Expired,
    Canceled
}