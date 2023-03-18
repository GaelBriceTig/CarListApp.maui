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
        int result = 0;
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

        public Car GetCar(int id)
        {
            try
            {
                Init();
                return conn.Table<Car>().FirstOrDefault(q => q.Id == id);
            }
            catch (Exception)
            {
                StatusMessage = "FAILED TO RETRIEVE DATA.";
            }
            return null;
        }
        public int DeleteCar(int id)
        {
            try
            {
                Init();
                return conn.Table<Car>().Delete(q => q.Id == id);
            }
            catch (Exception)
            {
                StatusMessage = "Failled to data.";
            }

            return 0;
        }

        public void AddCar(Car car) 
        {
            try
            {
                Init();

                if (car == null)
                    throw new Exception("Invalid car record");

               result = conn.Insert(car);
                StatusMessage = result == 0 ? "Insert Failled" : "Iinsert succeed";
            }
            catch (Exception ) 
            {
                StatusMessage = "Failled to insert data";
            }
        }

        public void UpdateCar(Car car) 
        {
            try
            {
                Init();

                if (car == null)
                    throw new Exception("Invalid car record");

                result = conn.Update(car);
                StatusMessage = result == 0 ? "Update Failled" : "Update succeed";
            }
            catch (Exception )
            {
                StatusMessage = "Failled to insert data";
            }
        }

        
    }
}
