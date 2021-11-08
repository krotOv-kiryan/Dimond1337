using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace Dimond1337
{

    
       
    
    public class Db //: DbContext
    {
        static Db db;
        private Db()
        {
            //Database.EnsureCreated();
        }

        public static Db GetDb()
        {
            if (db == null)
                db = new Db();
            return db;
        }

      //  public DbSet<Inbox> Inboxs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var sb = new SqlConnectionStringBuilder();//генерируем строку 

            sb.DataSource = @"DESKTOP-EOQO5SP\SQLEXPRESS";
            sb.InitialCatalog = "books";
            sb.IntegratedSecurity = true;// подключимся к ... пользователя

            optionsBuilder.UseSqlServer(sb.ToString());//передать строк уподклбчения. получаем тут же

            base.OnConfiguring(optionsBuilder);//переопределяем. оставляем базовый вызов 
        }


    }
}
