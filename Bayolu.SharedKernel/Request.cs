namespace Bayolu.SharedKernel
{
    public class Request<T>
    {
        public T Item { get; set; }
        public int UserId { get; set; }
        public Request(T item, int userid)
        {
            Item = item;
            UserId = userid;
        }
    }
}
