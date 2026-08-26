using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using VEnergie.DataAccess;

namespace VEnergie.Helpers
{
    public class MenuHelper
    {
        private DataAccess.DatabaseDataContext DB;
        public string GetMenuItemData()
        {
            DB = new DataAccess.DatabaseDataContext();
            List<MENUITEM> mnuList = DB.MENUITEMs.Where(m => m.MNUSEEN == true).ToList();
            DataTable table = ConvertToDataTable(mnuList);
            DataRow[] parentMenus = table.Select("PARENTID = 0");
            var sb = new StringBuilder();
           return GenerateUL(parentMenus, table, sb);
        }

        private DataTable ConvertToDataTable<T>(IList<T> data)
        {
            PropertyDescriptorCollection properties =
               TypeDescriptor.GetProperties(typeof(T));
            DataTable table = new DataTable();
            foreach (PropertyDescriptor prop in properties)
                table.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);
            foreach (T item in data)
            {
                DataRow row = table.NewRow();
                foreach (PropertyDescriptor prop in properties)
                    row[prop.Name] = prop.GetValue(item) ?? DBNull.Value;
                table.Rows.Add(row);
            }
            return table;

        }

        private string GenerateUL(DataRow[] menu, DataTable table, StringBuilder sb)
        {
            //sb.AppendLine("<ul class='nav navbar-nav'>");
            if (menu.Length > 0)
            {
                foreach (DataRow dr in menu)
                {
                    string handler = dr["Handler"].ToString();
                    string menuText = dr["MENU"].ToString();
                    string pid = dr["ID"].ToString();


                    DataRow[] subMenu = table.Select(String.Format("ParentId = {0}", pid));

                    if (subMenu.Length == 0)
                    {
                        string line = String.Format(@"<li id={2}><a href=""{0}"">{1}</a>", handler, menuText, "li" + pid);
                        sb.Append(line);
                    }

                    if (subMenu.Length > 0)
                    {
                        string line = String.Format(@"<li class=dropdown><a class=dropdown-toggle data-toggle=dropdown
                                                     href =""{0}"">{1}</a>"
                                                    , handler, menuText);
                        sb.Append(line);
                        sb.AppendLine("<ul class = dropdown-menu>");
                        var subMenuBuilder = new StringBuilder();
                        sb.Append(GenerateUL(subMenu, table, subMenuBuilder));
                        sb.AppendLine("</ul>");
                    }
                    sb.Append("</li>");
                }
            }

            //sb.Append("</ul>");
            return sb.ToString();
        }
    }
}