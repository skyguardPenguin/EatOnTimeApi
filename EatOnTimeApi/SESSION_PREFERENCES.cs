//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EatOnTimeApi
{
    using System;
    using System.Collections.Generic;
    
    public partial class SESSION_PREFERENCES
    {
        public int SESSION_ID { get; set; }
        public int SESSION_MENU_ID { get; set; }
        public int USER_ID_ { get; set; }
        public Nullable<System.DateTime> UPDATED_ON { get; set; }
    
        public virtual MENU MENU { get; set; }
        public virtual USERS USERS { get; set; }
    }
}
