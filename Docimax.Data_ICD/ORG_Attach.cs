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
    
    public partial class ORG_Attach
    {
        public int ORGAttachID { get; set; }
        public Nullable<int> ORGID { get; set; }
        public Nullable<int> ORGAttachType { get; set; }
        public string ORGAttachURL { get; set; }
        public string AttachDescription { get; set; }
        public Nullable<System.DateTime> CreateTime { get; set; }
        public Nullable<int> CreateUserID { get; set; }
        public Nullable<System.DateTime> LastModityTime { get; set; }
        public Nullable<int> LastModifyUserID { get; set; }
        public Nullable<int> DeleteFlag { get; set; }
    }
}
