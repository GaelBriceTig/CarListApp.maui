using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarListApp.maui.Models;
using SQLite;

namespace CarListApp.maui.Services
{
    public class CarService
    {
        private SQLiteConnection conn;
        string _dbPath;
        public string StatusMessage;
        public CarService(SQLiteConnection conn, string dbPath)
        {
            
            _dbPath = dbPath;
        }

        
        private void Init()
        {
            if (conn != null) 
                return;

            conn = new SQLiteConnection(_dbPath);
            conn.CreateTable<Car>();
        }


        public List<Car> GetCars()
        {
            Init();
            try
            {
                Init();
                return conn.Table<Car>().ToList();
            }
            catch (Exception)
            {
                StatusMessage = "FAILED TO RETRIEVE DATA.";
            }

            return new List<Car>(); 
        }
    }
}
