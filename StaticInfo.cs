using System;
using System.Collections.Generic;
using System.Windows.Controls;

namespace MoneyInEveryPocket
{
    public static class StaticInfo
    {
        public static MainWindow MainWindow;
        public static Frame MainFrame;
        public static Page CurrentPage;

        public static string EntityConnectionString = "metadata=res://*/AwfulDB.csdl|res://*/AwfulDB.ssdl|res://*/AwfulDB.msl;provider=System.Data.SqlClient;provider connection string=&quot;data source=(localdb);initial catalog=shilov_money_in_every_pocket;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework&quot;";
        public static string DatabaseConnectionString = "Data Source=(localdb);Initial Catalog=shilov_money_in_every_pocket;Integrated Security=True";
    }
}
