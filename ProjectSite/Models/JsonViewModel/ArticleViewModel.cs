using ProjectSite.Models.JsonModel;
using ProjectSite.Models.JsonModel2;

namespace ProjectSite.Models.JsonViewModel
{
    public class ArticleViewModel
    {

        public NewsArticleRoot NewsArticleViewModel { get; set; }
        public NewVideosRoot NewsVideosViewModel { get; set; }
        public List<string> CatergoryNames { get; set; }
        
    }
}
