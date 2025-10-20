namespace ClubManegment.Repository
{
    public interface IGeneric <T> where T : class
    {
        Task<IEnumerable<T>> GetAll();
        Task Add(T en);
        Task Update(T EN);
        Task<T> GetBy(int id);
        Task Delete(T en);
        Task SaveChange();
    }
}
