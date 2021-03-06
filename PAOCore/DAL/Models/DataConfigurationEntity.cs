// This is an independent project of an individual developer. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: http://www.viva64.com

namespace PAOCore.DAL.Models
{
    public class DataConfigurationEntity
    {
        public bool OrderAsc { get; set; }
        public int PageNo { get; set; }
        public int PageSize { get; set; }

        public DataConfigurationEntity(bool orderAsc = true, int pageNo = 0, int pageSize = 10)
        {
            OrderAsc = orderAsc;
            PageNo = pageNo;
            PageSize = pageSize;
        }

        public override string ToString()
        {
            return $"{nameof(OrderAsc)}: {OrderAsc}. " +
                   $"{nameof(PageNo)}: {PageNo}. " +
                   $"{nameof(PageSize)}: {PageSize}.";
        }
    }
}
