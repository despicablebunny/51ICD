//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Docimax.Data_ICD
{
    using System;
    using System.Collections.Generic;
    
    public partial class Dic_Service_UploadItem
    {
        public int Service_UploadItemID { get; set; }
        public Nullable<int> ServiceID { get; set; }
        public Nullable<int> UploadItemID { get; set; }
        public Nullable<System.DateTime> CreateTime { get; set; }
        public string CreateUserID { get; set; }
        public Nullable<System.DateTime> LastModifyTime { get; set; }
        public string LastModifyUserID { get; set; }
        public Nullable<int> DeleteFlag { get; set; }
        public byte[] LastModifyStamp { get; set; }
    }
}
