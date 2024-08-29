using Common;
using Domain.Domain;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace DBBroker
{
    public class Broker
    {
        private DbConnection connection;
        public Broker()
        {
            connection = new DbConnection();
        }
        #region ocbcr
        public void OpenConnection()
        {
            connection.OpenConnection();
        }
        public void CloseConnection()
        {
            connection.CloseConnection();
        }
        public void BeginTransaction()
        {
            connection.BeginTransaction();
        }
        public void Commit()
        {
            connection.Commit();
        }
        public void Rollback()
        {
            connection.Rollback();
        }

        #endregion

 

        public IEntity LoginII(IEntity obj)
        {
            SqlCommand command = connection.CreateCommand();
            command.CommandText = $"select * from {obj.TableName} a where {obj.Condition}";
            using (SqlDataReader reader = command.ExecuteReader())
            {

                List<IEntity> resList = obj.GetReaderList(reader);
                if (resList.Count > 0)
                {
                    return resList[0];
                }

            }
            command.Dispose();
            return null;
        }

        public object Add(IEntity obj)
        {
            SqlCommand command = connection.CreateCommand();
            command.CommandText = $"insert into {obj.TableName} output inserted.{obj.ColName} values ({obj.Values})";
            command.Dispose();
            return command.ExecuteScalar();

        }
        public List<IEntity> GetAll(IEntity entity, string condition = null, string joinCondition = null)
        {
            SqlCommand command = connection.CreateCommand();
            if (!string.IsNullOrEmpty(joinCondition))
            {
                if (!string.IsNullOrEmpty(condition))
                    command.CommandText = $"select * from {entity.TableName} {joinCondition} where {condition}";
                else
                    command.CommandText = $"select * from {entity.TableName} {joinCondition}";
            }
            else if (!string.IsNullOrEmpty(condition))
            {
                command.CommandText = $"select * from {entity.TableName} where {condition}";
            }
            else
            {
                command.CommandText = $"select * from {entity.TableName}";
            }
            List<IEntity> list;
            using (SqlDataReader reader = command.ExecuteReader())
            {
                list = entity.GetReaderList(reader);

            }

            command.Dispose();
            return list;
        }
        public List<IEntity> GetAllSearch(IEntity entity, string colName, string text,string joinCondition=null)
        {
            SqlCommand command = connection.CreateCommand();
            if (!string.IsNullOrEmpty(joinCondition))
            {
                command.CommandText = $"select * from {entity.TableName} {joinCondition} where {colName} like '%" + text + "%'";
            }
            else
            {
            command.CommandText = $"select * from {entity.TableName} where {colName} like '%" + text + "%'";

            }
            List<IEntity> list;
            using (SqlDataReader reader = command.ExecuteReader())
            {
                list = entity.GetReaderList(reader);

            }

            command.Dispose();
            return list;
        }

        public void Delete(IEntity obj)
        {
            SqlCommand command = connection.CreateCommand();
            command.CommandText = $"delete from {obj.TableName}  where {obj.Condition}";
            command.ExecuteNonQuery();
            command.Dispose();
        }


        public void Update(IEntity obj)
        {
            SqlCommand command = connection.CreateCommand();
            command.CommandText = $"update {obj.TableName} set {obj.UpdateValues} where {obj.Condition}";
            command.ExecuteNonQuery();
            command.Dispose();

        }






    }
}
