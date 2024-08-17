using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace api.Dtos.Comment
{
    public class UpdateCommentRequestDto
    {
        [Required]
        [MinLength(5, ErrorMessage = "Title Must be atleast 5 characters")]
        [MaxLength(280, ErrorMessage ="Title Cannot be over than 280 characters")]
        public string Title { get; set; } = string.Empty;
        [Required]
        [MinLength(5, ErrorMessage = "Content Must be atleast 5 characters")]
        [MaxLength(280, ErrorMessage ="Content Cannot be over than 280 characters")]
        public string Content { get; set; } = string.Empty;
    }
}