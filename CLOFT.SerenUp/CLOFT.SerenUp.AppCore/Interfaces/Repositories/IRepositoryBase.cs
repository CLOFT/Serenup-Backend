namespace CLOFT.SerenUp.AppCore.Interfaces;

public interface IRepositoryBase<TEntity, TPrimaryKey>
{
    Task<IEnumerable<TEntity>> GetAllAsync();
    Task<TEntity> GetAsync(TPrimaryKey id);
    Task<TPrimaryKey> InsertAsync(TEntity entity);
    Task<TPrimaryKey> UpdateAsync(TEntity entity);
    Task DeleteAsync(TPrimaryKey id);
    Task<long> CountAsync();
}