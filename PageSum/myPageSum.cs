using System.Collections.Generic;
using System.Linq;

namespace PageSum
{
    public class myPageSum
    {
        public List<int> CostTotal(int page, List<SourceData> obj)
        {
            return SumTotal(page, obj, enSourceColumn.Cost);
        }

        public List<int> RevenueTotal(int page, List<SourceData> obj)
        {
            return SumTotal(page, obj, enSourceColumn.Revenue);
        }

        enum enSourceColumn
        {
            Cost,
            Revenue
        }

        private List<int> SumTotal(int page, List<SourceData> obj, enSourceColumn col)
        {
            int loop = obj.Count() / page;
            int left = obj.Count() % page;
            int start = 0;
            int end = (loop == 0 ? left : page);

            int i;
            List<int> rtn = new List<int>();

            for (i = 1; i <= loop + 1; i++)
            {
                int temp = 0, j = 0;
                for (j = start; j < end; j++)
                {
                    switch (col)
                    {
                        case enSourceColumn.Cost:
                            temp += obj[j].Cost;
                            break;
                        case enSourceColumn.Revenue:
                            temp += obj[j].Revenue;
                            break;
                    }
                }
                rtn.Add(temp);
                start = j;
                end = (i < loop ? (page * (i + 1)) : end + left);
            }

            return rtn;
        }
    }
}
