//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplicationMVC
{
    using System;
    using System.Collections.Generic;
    
    public partial class Articles
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string ArticleTypeName { get; set; }
        public Nullable<int> ArticleTypeId { get; set; }
        public string Contents { get; set; }
        public string ImagesAddr { get; set; }
        public Nullable<int> ReadTimes { get; set; }
        public Nullable<int> CommentTimes { get; set; }
        public string ReleaseTime { get; set; }
        public string CommentContents { get; set; }
        public Nullable<int> DelFlag { get; set; }
        public Nullable<int> UsersId { get; set; }
        public Nullable<int> IsRecommend { get; set; }
    }
}
