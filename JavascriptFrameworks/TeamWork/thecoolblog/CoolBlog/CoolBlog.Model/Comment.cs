//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CoolBlog.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Comment
    {
        public int Id { get; set; }
        public string CommentContent { get; set; }
        public int CreatorId { get; set; }
        public int PostId { get; set; }
        public Nullable<System.DateTime> CreationDate { get; set; }
    
        public virtual Post Post { get; set; }
        public virtual User User { get; set; }
    }
}