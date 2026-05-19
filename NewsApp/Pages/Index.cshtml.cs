using Microsoft.AspNetCore.Mvc.RazorPages;
using NewsApp.Models;

namespace NewsApp.Pages
{
    public class IndexModel : PageModel
    {
        public Article FeaturedArticle { get; set; } = new();
        public List<Article> SecondaryArticles { get; set; } = new();
        public List<string> NavItems { get; set; } = new();

        public void OnGet()
        {
            NavItems = new List<string>
            {
                "VnE-GO", "Thời sự", "Thế giới", "Kinh doanh",
                "Khoa học công nghệ", "Góc nhìn", "Spotlight",
                "Bất động sản", "Sức khỏe", "Giải trí", "Thể thao"
            };

            FeaturedArticle = new Article
            {
                Id = 1,
                Title = "'Ưu tiên tái định cư trước khi triển khai Trục cảnh quan sông Hồng'",
                Summary = "Hà Nội sẽ ưu tiên xây dựng các khu tái định cư trước khi triển khai Trục Đại lộ cảnh quan sông Hồng - dự án hơn 11.400 ha, liên quan khoảng 247.000 dân ven sông, thực hiện giai đoạn 2026-2038.",
                ImageUrl = "/images/song-hong.jpg",
                TimeAgo = "1h trước",
                Category = "Thời sự"
            };

            SecondaryArticles = new List<Article>
            {
                new Article
                {
                    Id = 2,
                    Title = "Hà Nội giải phóng mặt bằng cho hơn 1.400 dự án",
                    ImageUrl = "/images/don.jpg",
                    Category = "Thời sự",
                    TimeAgo = "2h trước"
                },
                new Article
                {
                    Id = 3,
                    Title = "TP HCM siết kiểm soát người nhập cảnh phòng Ebola",
                    ImageUrl = "/images/xuatnhap.jpg",
                    Category = "Thời sự",
                    TimeAgo = "3h trước"
                },
                new Article
                {
                    Id = 4,
                    Title = "'Bóc lột' trên YouTube",
                    Summary = "Khi cỗ máy Content ID của YouTube bị trục lợi, nhiều nghệ s...",
                    Category = "Góc nhìn",
                    Author = "Hoàng Hà",
                    CommentCount = 24,
                    IsOpinion = true
                }
            };
        }
    }
}
