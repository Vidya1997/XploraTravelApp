using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xplora.Model;

namespace Xplora.Controller
{
    public class clsDatabaseLayer
    {
        readonly SQLiteAsyncConnection db_Database;
        public clsDatabaseLayer(String a_dbPath)
        {
            db_Database = new SQLiteAsyncConnection(a_dbPath);
            db_Database.CreateTableAsync<tblUsers>().Wait();
            db_Database.CreateTableAsync<tblUserDetails>().Wait();
            db_Database.CreateTableAsync<tblStates>().Wait();
            db_Database.CreateTableAsync<tblPlaces>().Wait();
            db_Database.CreateTableAsync<tblPackage>().Wait();
            db_Database.CreateTableAsync<tblUserPlaces>().Wait();
            db_Database.CreateTableAsync<tblDistricts>().Wait();
            db_Database.CreateTableAsync<tblReviews>().Wait();
            db_Database.CreateTableAsync<tblRestaurants>().Wait();
        }
        public Task<int> pro_saveUser(tblUsers tblUsers)
        {
            return db_Database.InsertAsync(tblUsers);
        }
        public Task<int> pro_UpdateUser(tblUsers tblUsers)
        {
            return db_Database.UpdateAsync(tblUsers);
        }
        public Task<List<tblUsers>> pro_getUsers()
        {
            return db_Database.Table<tblUsers>().ToListAsync();
        }
        public Task<int> pro_saveUserDetails(tblUserDetails tblUserDetails)
        {
            return db_Database.InsertAsync(tblUserDetails);
        }
        public Task<List<tblUserDetails>> pro_getUserDetails()
        {
            return db_Database.Table<tblUserDetails>().ToListAsync();
        }
        public Task<int> pro_saveState(tblStates tblStates)
        {
            return db_Database.InsertAsync(tblStates);
        }
        public Task<List<tblStates>> pro_getStates()
        {
            return db_Database.Table<tblStates>().ToListAsync();
        }
        public Task<int> pro_savePlaces(tblPlaces tblPlaces)
        {
            return db_Database.InsertAsync(tblPlaces);
        }
        public Task<List<tblPlaces>> pro_getPlaces()
        {
            return db_Database.Table<tblPlaces>().ToListAsync();
        }
        public Task<int> pro_savePackage(tblPackage tblPackage)
        {
            return db_Database.InsertAsync(tblPackage);
        }
        public Task<List<tblPackage>> pro_getPackage()
        {
            return db_Database.Table<tblPackage>().ToListAsync();
        }
        public Task<int> pro_saveUserPlaces(tblUserPlaces tblUserPlaces)
        {
            return db_Database.InsertAsync(tblUserPlaces);
        }
        public Task<int> pro_DeletePlaces(tblUserPlaces tblUserPlaces)
        {
            return db_Database.DeleteAsync(tblUserPlaces);
        }
        public Task<List<tblUserPlaces>> pro_getUserPlaces()
        {
            return db_Database.Table<tblUserPlaces>().ToListAsync();
        }
        public Task<int> pro_saveDistrict(tblDistricts tblDisctricts)
        {
            return db_Database.InsertAsync(tblDisctricts);
        }
        public Task<List<tblDistricts>> pro_getDistricts()
        {
            return db_Database.Table<tblDistricts>().ToListAsync();
        }
        public Task<int> pro_UpdatePackage(tblPackage tblPackage)
        {
            return db_Database.UpdateAsync(tblPackage);
        }
        public Task<int> pro_saveReview(tblReviews tblReviews)
        {
            return db_Database.InsertAsync(tblReviews);
        }
        public Task<List<tblReviews>> pro_getReviews()
        {
            return db_Database.Table<tblReviews>().ToListAsync();
        }
        public Task<int> pro_saveRestaurants(tblRestaurants tblRestaurants)
        {
            return db_Database.InsertAsync(tblRestaurants);
        }
        public Task<List<tblRestaurants>> pro_getRestaurants()
        {
            return db_Database.Table<tblRestaurants>().ToListAsync();
        }
    }
}
