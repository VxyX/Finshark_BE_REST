using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using api.Dtos.Comment;

namespace api.Dtos.Stock
{
    //DTO(Data Transfer Object)
    //digunakan untuk melakukan 'trim' data dari model yang ada
    //maksudnya menghilangkan kolom yang tidak mau ditampilkan saat
    //api dipanggil
    //cara pakenya: copas dari model, hapus yang ga perlu
    public class StockDto
    {
        public int Id { get; set; }
        public string Symbol { get; set; } = string.Empty;
        public string CompanyName { get; set; } = string.Empty;

        public decimal Purchase { get; set; }

        public decimal LastDiv { get; set; }
        public string Industry { get; set; } = string.Empty;
        public long MarketCap { get; set; }
        public List<CommentDto> Comments { get; set; }
    }
}