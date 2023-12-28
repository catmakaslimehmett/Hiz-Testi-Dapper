using DataAccessLayer.Abstract;
using EntityLayer.Entities;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class Repository<T> : IRepository<T> where T : class
    {
        Context db = new Context();
        DbSet<T> _object;
        public Repository()
        {
            _object = db.Set<T>();
        }

        public int Delete(T p)
        {          
                _object.Remove(p);
                return db.SaveChanges();          
        }

        public T GetById(int id)
        {         
                 return _object.Find(id);           
        }

        public int Insert(T p)
        {
                _object.Add(p);
                return db.SaveChanges();                                 
        }


        public List<T> List()
        {           
                 return _object.ToList();           
        }

        public int Update(T p)
        {        
                 return db.SaveChanges();           
        }
    }
}
