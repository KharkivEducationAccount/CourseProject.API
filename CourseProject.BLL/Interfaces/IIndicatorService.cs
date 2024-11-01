using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CourseProject.BLL.Interfaces
{
    public interface IIndicatorService
    {
        Task CreateIndicator(Indicator model);
        Task<List<Indicator>> GetIndicators();
        Task DeleteIndicator(Guid id);
        Task UpdateIndicatorValue(Indicator model);

    }
}