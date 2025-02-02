namespace Core.Models.Exam
{
    using Core.Models.Resource;

    public class ExamResourceServiceModel
    {
        public string ResourceId { get; set; } = string.Empty;

        public string ExamId { get; set; } = string.Empty;

        public ExamServiceModel Exam { get; set; } = null!;

        public ResourceServiceModel Resource { get; set; } = null!;
    }
}
