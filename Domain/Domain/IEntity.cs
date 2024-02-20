using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Domain
{
    public interface IEntity
    {

        string TableName { get; }
        string Values { get; }
        
        string ColName {  get; }

        string Condition {  get; }
        string UpdateValues {  get; }

        List<IEntity> GetReaderList(SqlDataReader reader);


    }
}
