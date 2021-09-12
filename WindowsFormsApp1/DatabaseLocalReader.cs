using System.Data;
using System.Data.SQLite;
//using System.Data.Sqlite;
//using Mono.Data.Sqlite;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    internal class DatabaseLocalReader
    {
        private string _commandText;
        private string _pathToDatabase;
        private string _dbName = "db.db";
        private SQLiteConnection _connection;
        private DataTable _dataTable;
        private string PathDB => Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
        public DatabaseLocalReader(string commandText)
        {
            _commandText = commandText;
            _pathToDatabase = $"Data Source={PathDB}\\{_dbName}";
            
            _connection = new SQLiteConnection(_pathToDatabase);
        }

        public DataTable SendReuqest()
        {
            try
            {
                _connection.Open();
                SQLiteDataAdapter sqLiteDataAdapter = new SQLiteDataAdapter(new SQLiteCommand(_commandText, _connection));
                _dataTable = new DataTable();
                sqLiteDataAdapter.Fill(_dataTable);
                _connection.Close();
            }
            catch (SQLiteException ex)
            {
                if (ex.ErrorCode != 1)
                    return null;
                int num2 = (int)MessageBox.Show("Файл db.sqlite не найден. Положите файл в папку вместе с exe.");
            }
            return _dataTable;
        }
    }
}