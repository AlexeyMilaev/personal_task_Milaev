//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace personal_task_Milaev.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Request
    {
        public int RequestID { get; set; }
        public int InsuranceID { get; set; }
        public int UserID { get; set; }
    
        public virtual Insurance Insurance { get; set; }
        public virtual User User { get; set; }
    }
}
