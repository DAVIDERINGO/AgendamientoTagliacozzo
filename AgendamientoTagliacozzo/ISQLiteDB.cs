using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
namespace AgendamientoTagliacozzo
{
    public interface ISQLiteDB
    {
        SQLiteAsyncConnection GetConnection();
    }
}
