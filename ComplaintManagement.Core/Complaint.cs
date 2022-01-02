using System;

namespace ComplaintManagement.Core
{
    public class Complaint
    {
        public int Id { get; private set; }
        public int UserId { get; private set; }
        public User User { get; private set; }
        public string Text { get; private set; }
        public ComplaintStatus Status { get; private set; }
        public DateTime CreatedOn { get; private set; }
        public DateTime UpdatedOn { get; private set; }

        public Complaint(User user, string text)
        {
            UserId = user.Id;
            User = user;
            Text = text;
            Status = ComplaintStatus.Initialized;
            CreatedOn = DateTime.UtcNow;
            UpdatedOn = DateTime.UtcNow;
        }

        public void UpdateComplaintStatus(ComplaintStatus status)
        {
            Status = status;
            UpdatedOn = DateTime.UtcNow;
        }
    }

    public enum ComplaintStatus
    {
        Initialized = 1,
        InProgress,
        Resolved
    }
}