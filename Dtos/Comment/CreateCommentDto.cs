using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace api.Dtos.Comment
{
    public class CreateCommentDto
    {
        [Required]
        [MinLength(5, ErrorMessage = "Must be atleast 5 characters")]
        [MaxLength(280, ErrorMessage ="Cannot be over than 280 characters")]
        public string Title { get; set; } = string.Empty;
        [Required]
        [MinLength(5, ErrorMessage = "Must be atleast 5 characters")]
        [MaxLength(280, ErrorMessage ="Cannot be over than 280 characters")]
        public string Content { get; set; } = string.Empty;
    }
}