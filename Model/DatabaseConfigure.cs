﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;
using System.Data.Entity.Core.EntityClient;
using System.Data.SqlClient;
namespace RestaurantSystem.Model
{
    public class DatabaseConfigure
    {
        public static Model.ResturantManagementEntities getConfigure()
        {
            try
            {
                return new ResturantManagementEntities(getConnectionString());

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public static string getConnectionString()
        {

            if (ManageKeys.Manage.checkForDatabase())
            {
                RegistryKey reg = Registry.CurrentUser.OpenSubKey(INFO.guid + "\\database", false);
                SqlConnectionStringBuilder sqlString = new SqlConnectionStringBuilder()
                {
                    DataSource = reg.GetValue("server") as string, // Server name
                    InitialCatalog = reg.GetValue("database") as string,  //Database
                    MultipleActiveResultSets = true,
                    UserID = reg.GetValue("username") as string,     //Username
#if DEBUG
                    Password = CustomControls.Encrypt.DecryptString(reg.GetValue("password") as string, "Kankuro9800916365"),  //Password
#else
                    Password = CustomControls.Encrypt.DecryptString(reg.GetValue("password") as string,"Kankuro9800916365"),  //Password
#endif
                };
                //Build an Entity Framework connection string

                EntityConnectionStringBuilder entityString = new EntityConnectionStringBuilder()
                {
                    Provider = "System.Data.SqlClient",
                    Metadata = "res://*/Model.Resturantmanagement.csdl|res://*/Model.Resturantmanagement.ssdl|res://*/Model.Resturantmanagement.msl",
                    ProviderConnectionString = sqlString.ToString()
                };



                return entityString.ConnectionString;

            }
            else
            {
                throw new Exception("Database Connection Not Found");
            }

        }
        public static bool hasAdmin()
        {
           return getConfigure().admins.Count(o => o.name == "Admin") > 0;
        }
    }
}
