using ProjectEF.Domain.Enums;

namespace ProjectEF.Service.DTOs.FeedbackDTOs
{
    public class FeedbackForCreation
    {
        public string Content { get; set; } = string.Empty;
        public FeedbackType Type { get; set; }
        public FeedbackScore Score { get; set; }
    }
}
