//------------------------------------------------------------------------------
// <auto-generated>
//     這個程式碼是由範本產生。
//
//     對這個檔案進行手動變更可能導致您的應用程式產生未預期的行為。
//     如果重新產生程式碼，將會覆寫對這個檔案的手動變更。
// </auto-generated>
//------------------------------------------------------------------------------

namespace hsdc.dpt.Control.Structural.Flyweight.Dao
{
    using System;
    using System.Collections.Generic;
    
    internal partial class Code
    {
        public Code()
        {
            this.Code1 = new HashSet<Code>();
        }
    
        internal int Id { get; set; }
        internal string CodeType { get; set; }
        internal string CodeValue { get; set; }
        internal string CodeText { get; set; }
        internal Nullable<int> ParentId { get; set; }
    
        internal virtual ICollection<Code> Code1 { get; set; }
        internal virtual Code Code2 { get; set; }
    }
}
