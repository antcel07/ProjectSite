namespace ProjectSite.Models.JsonModel2
{
    public class NewVideosRoot
    {
        public Meta meta { get; set; }
        public Data data { get; set; }
    }

    public class Data
    {
        public Videos videos { get; set; }
    }

    public class Meta
    {
        public int status_code { get; set; }
        public string message { get; set; }
        public string description { get; set; }
        public string brand { get; set; }
    }

    public class Response
    {
        public object BroadcastKind { get; set; }
        public string CategoryId { get; set; }
        public string CategoryName { get; set; }
        public bool ChapterShowTag { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime CreatedDateReal { get; set; }
        public string Description { get; set; }
        public object Episode { get; set; }
        public string External { get; set; }
        public bool HeadlineTitleCategory { get; set; }
        public bool HeadlineTitleMainPage { get; set; }
        public string Id { get; set; }
        public int IdentityId { get; set; }
        public bool IsGeoBlocked { get; set; }
        public bool IsGeoBlockedDomestic { get; set; }
        public bool IsModified { get; set; }
        public bool IsTokenRequired { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string NameForUrl { get; set; }
        public string OutputDate { get; set; }
        public string primaryImage { get; set; }
        public object ReferenceSiteId { get; set; }
        public object Season { get; set; }
        public bool ShowWebView { get; set; }
        public int SortOrderCurrent { get; set; }
        public string Spot { get; set; }
        public string SpotShort { get; set; }
        public string Title { get; set; }
        public string TitleShort { get; set; }
        public string Url { get; set; }
        public string VideoDuration { get; set; }
        public string VideoDurationDisplay { get; set; }
        public object VideoMobileUrl { get; set; }
        public string VideoSmilUrl { get; set; }
        public object VideoSourceInfo { get; set; }
        public object VideoSrtFile { get; set; }
        public string VideoType { get; set; }
        public int VideoTypeId { get; set; }
        public string VideoUrl { get; set; }
        public string WebSiteId { get; set; }
    }



    public class Videos
    {
        public Response[] Response { get; set; }
        public bool Status { get; set; }
    }

}
