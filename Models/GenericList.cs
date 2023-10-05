using NPOI.SS.Formula.Functions;

namespace ProvaPub.Models
{
    public class GenericList<T>
    {
        public List<T>? Elements { get; set; }
        public int TotalCount { get; set; }
        public bool HasNext { get; set; }
    }
}
