namespace ProvaPub.Pagination
{
    public static class QuantityPagination
    {
        public static bool VerificarHasNext(int page, int qtRegistrosPagina, int total)
        {
            return total - page * qtRegistrosPagina > 1;
        }
    }
}
