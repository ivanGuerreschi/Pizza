using System.Data.SQLite;

namespace Pizza
{
    class DBPizza : IDBPizza
    {
        public void VersionDB()
        {
            var cs = "Data Source=:memory:";
            var stm = "SELECT SQLITE_VERSION()";

            using var con = new SQLiteConnection(cs);
            con.Open();

            using var cmd = new SQLiteCommand(stm, con);
            var version = cmd.ExecuteScalar().ToString();

            Console.WriteLine($"SQLite version: {version}");
        }
    }
}