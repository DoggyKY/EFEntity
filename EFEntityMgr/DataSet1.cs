using EFEntityMgr.DataSet1TableAdapters;
using System.Data.SqlClient;

namespace EFEntityMgr
{
    public static class ActionsM
    {
        public static DataSet1.ActionsDataTable GetActions()
        {
            return TANew().GetData();
        }
        public static ActionsTableAdapter TANew()
        {
            return new ActionsTableAdapter();
        }
    }
}
namespace EFEntityMgr.DataSet1TableAdapters
{ 
    partial class ActionsTableAdapter
    {
        public  SqlDataAdapter DataAdapter
        { get => this.DataAdapter; }
        public SqlCommand SelectCommand
        { get => this.CommandCollection[0]; }
        public ActionsTableAdapter(SqlConnection conn) : this()
        {
            this.Connection = conn;
        }
    }
}
