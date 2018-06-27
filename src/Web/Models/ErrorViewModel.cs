using System;

namespace Web.Models
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }

        public bool IsSuccess { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);

        public string ErrorText { get; set; }
    }
}