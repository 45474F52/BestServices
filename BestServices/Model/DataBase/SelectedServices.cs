//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BestServices.Model.DataBase
{
    using System;
    using System.Collections.Generic;
    
    public partial class SelectedServices
    {
        public int ID { get; set; }
        public int UserID { get; set; }
        public int ServiceID { get; set; }
    
        public virtual Services Services { get; set; }
        public virtual Users Users { get; set; }
    }
}
