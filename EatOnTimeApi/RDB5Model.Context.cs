﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Core.Objects;
    using System.Data.Entity.Infrastructure;

    using System.Linq;
    
    public partial class RDB5Entities : DbContext
    {
        public RDB5Entities()
            : base("name=RDB5Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<AUX_PARAMETER> AUX_PARAMETER { get; set; }
        public DbSet<ERROR_LOG> ERROR_LOG { get; set; }
        public DbSet<MENU> MENU { get; set; }
        public DbSet<PRODUCT_DETAIL> PRODUCT_DETAIL { get; set; }
        public DbSet<PRODUCT_IN_MENU> PRODUCT_IN_MENU { get; set; }
        public DbSet<PRODUCT_ORDER> PRODUCT_ORDER { get; set; }
        public DbSet<RORDER> RORDER { get; set; }
        public DbSet<RTABLES> RTABLES { get; set; }
        public DbSet<SESSION_PREFERENCES> SESSION_PREFERENCES { get; set; }
        public DbSet<STATUS_DETAIL> STATUS_DETAIL { get; set; }
        public DbSet<TABLE_ACTIVITY> TABLE_ACTIVITY { get; set; }
        public DbSet<USERS> USERS { get; set; }
    
        public virtual int INSERT_LOG_ERROR(string code, string desc, string obj_name, Nullable<System.DateTime> date)
        {
            var codeParameter = code != null ?
                new ObjectParameter("code", code) :
                new ObjectParameter("code", typeof(string));
    
            var descParameter = desc != null ?
                new ObjectParameter("desc", desc) :
                new ObjectParameter("desc", typeof(string));
    
            var obj_nameParameter = obj_name != null ?
                new ObjectParameter("obj_name", obj_name) :
                new ObjectParameter("obj_name", typeof(string));
    
            var dateParameter = date.HasValue ?
                new ObjectParameter("date", date) :
                new ObjectParameter("date", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("INSERT_LOG_ERROR", codeParameter, descParameter, obj_nameParameter, dateParameter);
        }
    
        public virtual ObjectResult<PROC_GET_TABLES_Result> PROC_GET_TABLES()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<PROC_GET_TABLES_Result>("PROC_GET_TABLES");
        }
    
        public virtual ObjectResult<API_PROC_GET_TABLES_Result> API_PROC_GET_TABLES()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<API_PROC_GET_TABLES_Result>("API_PROC_GET_TABLES");
        }
    
        public virtual ObjectResult<GET_MENU_BY_ID_Result> GET_MENU_BY_ID(Nullable<int> iD)
        {
            var iDParameter = iD.HasValue ?
                new ObjectParameter("ID", iD) :
                new ObjectParameter("ID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GET_MENU_BY_ID_Result>("GET_MENU_BY_ID", iDParameter);
        }
    
        public virtual ObjectResult<GET_MENU_DETAIL_BY_ID_Result> GET_MENU_DETAIL_BY_ID(Nullable<int> iD)
        {
            var iDParameter = iD.HasValue ?
                new ObjectParameter("ID", iD) :
                new ObjectParameter("ID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GET_MENU_DETAIL_BY_ID_Result>("GET_MENU_DETAIL_BY_ID", iDParameter);
        }
    
        public virtual ObjectResult<GET_TABLE_ACTIVITY_Result> GET_TABLE_ACTIVITY(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GET_TABLE_ACTIVITY_Result>("GET_TABLE_ACTIVITY", idParameter);
        }
    
        public virtual ObjectResult<GET_MENU_BY_ID_Result> API_GET_MENU_BY_ID(Nullable<int> iD)
        {
            var iDParameter = iD.HasValue ?
                new ObjectParameter("ID", iD) :
                new ObjectParameter("ID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GET_MENU_BY_ID_Result>("API_GET_MENU_BY_ID", iDParameter);
        }
    
        public virtual int GET_CHECK(Nullable<int> id, ObjectParameter out_subtotal, ObjectParameter out_total)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("GET_CHECK", idParameter, out_subtotal, out_total);
        }
    
        public virtual int CHANGE_TABLE_STATUS(Nullable<int> id, Nullable<int> qTY, ObjectParameter order_id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            var qTYParameter = qTY.HasValue ?
                new ObjectParameter("QTY", qTY) :
                new ObjectParameter("QTY", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("CHANGE_TABLE_STATUS", idParameter, qTYParameter, order_id);
        }
    
        public virtual ObjectResult<GET_EMPLOYEES_Result> GET_EMPLOYEES()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GET_EMPLOYEES_Result>("GET_EMPLOYEES");
        }
    
        public virtual ObjectResult<GET_TABLE_ORDER_Result> GET_TABLE_ORDER(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GET_TABLE_ORDER_Result>("GET_TABLE_ORDER", idParameter);
        }
    
        public virtual ObjectResult<NUEVO_PLATILLO_Result> NUEVO_PLATILLO(string dESC, Nullable<double> pRECIO, string tIPO, Nullable<int> status)
        {
            var dESCParameter = dESC != null ?
                new ObjectParameter("DESC", dESC) :
                new ObjectParameter("DESC", typeof(string));
    
            var pRECIOParameter = pRECIO.HasValue ?
                new ObjectParameter("PRECIO", pRECIO) :
                new ObjectParameter("PRECIO", typeof(double));
    
            var tIPOParameter = tIPO != null ?
                new ObjectParameter("TIPO", tIPO) :
                new ObjectParameter("TIPO", typeof(string));
    
            var statusParameter = status.HasValue ?
                new ObjectParameter("status", status) :
                new ObjectParameter("status", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<NUEVO_PLATILLO_Result>("NUEVO_PLATILLO", dESCParameter, pRECIOParameter, tIPOParameter, statusParameter);
        }
    
        public virtual int UPDATE_MENU_BY__ID(Nullable<int> iD, string iD2, string dESC, Nullable<double> pRICE, string tIPO)
        {
            var iDParameter = iD.HasValue ?
                new ObjectParameter("ID", iD) :
                new ObjectParameter("ID", typeof(int));
    
            var iD2Parameter = iD2 != null ?
                new ObjectParameter("ID2", iD2) :
                new ObjectParameter("ID2", typeof(string));
    
            var dESCParameter = dESC != null ?
                new ObjectParameter("DESC", dESC) :
                new ObjectParameter("DESC", typeof(string));
    
            var pRICEParameter = pRICE.HasValue ?
                new ObjectParameter("PRICE", pRICE) :
                new ObjectParameter("PRICE", typeof(double));
    
            var tIPOParameter = tIPO != null ?
                new ObjectParameter("TIPO", tIPO) :
                new ObjectParameter("TIPO", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UPDATE_MENU_BY__ID", iDParameter, iD2Parameter, dESCParameter, pRICEParameter, tIPOParameter);
        }
    
        public virtual int UPDATE_NEXT_VALUE(string param_name, ObjectParameter next)
        {
            var param_nameParameter = param_name != null ?
                new ObjectParameter("param_name", param_name) :
                new ObjectParameter("param_name", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UPDATE_NEXT_VALUE", param_nameParameter, next);
        }
    
        public virtual int VALIDATE_LOGIN(string user, string userp, ObjectParameter result)
        {
            var userParameter = user != null ?
                new ObjectParameter("user", user) :
                new ObjectParameter("user", typeof(string));
    
            var userpParameter = userp != null ?
                new ObjectParameter("userp", userp) :
                new ObjectParameter("userp", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("VALIDATE_LOGIN", userParameter, userpParameter, result);
        }

        public System.Data.Entity.DbSet<EatOnTimeApi.Models.Menu> Menus { get; set; }
    }
}
