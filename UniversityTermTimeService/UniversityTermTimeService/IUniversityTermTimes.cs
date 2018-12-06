using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace UniversityTermTimeService {
    [ServiceContract]
    public interface IUniversityTermTimes {

        [OperationContract]
        List<DateTime> GetHolidayDates(string university, string timeOfYear);

    }
}
