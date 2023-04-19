namespace ProjectSite.Models.JsonModel
{

    public class NewsArticleRoot
    {
        public Meta meta { get; set; }
        public Data data { get; set; }
    }

    public class Meta
    {
        public int status_code { get; set; }
        public string message { get; set; }
        public string description { get; set; }
        public string brand { get; set; }
    }

    public class Data
    {
        public Articles articles { get; set; }
    }

    public class Articles
    {
        public Response[] Response { get; set; }
        public bool Status { get; set; }
    }

    public class Response
    {
        public string ArticleId { get; set; }
        public string ArticleSourceId { get; set; }
        public Articlesourceinfo[] ArticleSourceInfo { get; set; }
        public string ArticleSourceType { get; set; }
        public string ArticleType { get; set; }
        public bool CanUserWriteComments { get; set; }
        public string CategoryId { get; set; }
        public string CategoryName { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedDateInt { get; set; }
        public DateTime CreatedDateReal { get; set; }
        public string CreatedUser { get; set; }
        public string Description { get; set; }
        public object[] DescriptionList { get; set; }
        public object DetailCounterScript { get; set; }
        public string External { get; set; }
        public bool HideArticleRightColumn { get; set; }
        public string Id { get; set; }
        public int IdentityId { get; set; }
        public bool IsModified { get; set; }
        public object ListCounterScript { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string NameForUrl { get; set; }
        public string NameForUrl2 { get; set; }
        public string OutputDate { get; set; }
        public string primaryImage { get; set; }
        public string primaryImageAlternateText { get; set; }
        public int QuickImageType { get; set; }
        public string secondaryImage { get; set; }
        public string secondaryImageAlternateText { get; set; }
        public bool ShowWebView { get; set; }
        public int SortOrderCurrent { get; set; }
        public string Source { get; set; }
        public string Spot { get; set; }
        public string SpotShort { get; set; }
        public bool SurmansetBaslik { get; set; }
        public bool SurmansetBaslikKategori { get; set; }
        public string Title { get; set; }
        public string TitleShort { get; set; }
        public string Url { get; set; }
        public bool UsedMethod { get; set; }
    }

    public class Articlesourceinfo
    {
        public string Id { get; set; }
        public string primaryImage { get; set; }
        public string Source { get; set; }
        public string SourceForUrl { get; set; }
        public string Type { get; set; }
    }
}
