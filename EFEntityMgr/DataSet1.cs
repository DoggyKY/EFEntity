using EFEntityMgr.DataSet1TableAdapters;
using System.Data.SqlClient;

namespace EFEntityMgr
{
}

namespace EFEntityMgr
{
}

namespace EFEntityMgr
{
}

namespace EFEntityMgr
{
}

namespace EFEntityMgr
{
    public static class ActionsM
    {
        public static Task<DataSet1.ActionsDataTable> GetActions()
        {
            return Task.Run(() => TANew().GetData());
        }
        public static ActionsTableAdapter TANew()
        {
            return new ActionsTableAdapter();
        }
    }
    public static class AocM
    {
        public static Task<DataSet1.aocDataTable> GetAOCCodes()
        {
            return Task.Run(() => TANew().GetData());
        }
        public static aocTableAdapter TANew()
        {
            return new aocTableAdapter();
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
    partial class aocTableAdapter
    {
        public SqlDataAdapter DataAdapter
        { get => this.DataAdapter; }
        public SqlCommand SelectCommand
        { get => this.CommandCollection[0]; }
        public aocTableAdapter(SqlConnection conn) : this()
        {
            this.Connection = conn;
        }

    }
}
