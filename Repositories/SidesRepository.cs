using System.Collections.Generic;
using System.Data;
using burgershackApi.Models;
using Dapper;

namespace burgershackApi.Repositories
{
  public class SidesRepository
  {
    private readonly IDbConnection _db;
    public SidesRepository(IDbConnection db)
    {
      _db = db;
    }
    internal IEnumerable<Side> Get()
    {
      string sql = "SELECT * FROM sides";
      return _db.Query<Side>(sql);
    }
    internal Side GetById(int Id)
    {
      string sql = "SELECT * FROM sides WHERE id = @id";
      return _db.QueryFirstOrDefault<Side>(sql, new { Id });
    }
    internal Side Create(Side newData)
    {
      string sql = @"
      INSERT INTO sides (name, description, price)
      VALUES
      (@Name, @Description, @Price);
      SELECT LAST_INSERT_ID();";
      int id = _db.ExecuteScalar<int>(sql, newData);
      newData.Id = id;
      return newData;
    }
    internal void Edit(Side update)
    {
      string sql = @"
      UPDATE sides
      SET
      name = @Name,
      description = @Description,
      price = @Price
      WHERE id = @Id;";
      _db.Execute(sql, update);
    }
    internal void Delete(int id)
    {
      string sql = "DELETE FROM sides WHERE id = @id";
      _db.Execute(sql, new { id });
    }
  }
}