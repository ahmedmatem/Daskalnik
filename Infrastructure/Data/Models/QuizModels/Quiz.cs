using Infrastructure.Data.Abstracts;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using static Infrastructure.Constants.DataConstants;
using static Infrastructure.Data.ErrorMessages;

namespace Infrastructure.Data.Models
{
    /// <summary>
    /// Quiz data model
    /// </summary>
    [Comment("Quiz data model.")]
    public class Quiz : DataModel
    {
        /// <summary>
        /// The name of the Quiz
        /// </summary>
        [Comment("The name of the Quiz")]
        [MaxLength(QuizNameMaxLength, ErrorMessage = MaxLengthErrorMessage)]
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Collection of <see cref="Question"/>s belonging to the Quiz.
        /// </summary>
        [Comment("Collection of questions belonging to the Quiz.")]
        public ICollection<Question> Questions { get; set; } = new HashSet<Question>();
    }
}
