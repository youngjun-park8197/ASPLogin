using ASPLogin.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ASPLogin.Context
{
    public class usersList : DbContext
    {
        public usersList() : base(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\SW기술진흥협회 교육\C++ 프로젝트 파일\EquipManager\EquipDataBase.mdf;Integrated Security=True;Connect Timeout=30")
        { }

        public DbSet<user> users { get; set; }
    }
}