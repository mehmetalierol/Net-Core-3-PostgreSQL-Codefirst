using System;

namespace Net_Core_3_Postgre_Codefirst.Base
{
    public interface IBaseEntity
    {
        Guid ID { get; set; }

        int? AutoID { get; set; }

        DateTime? CreatedDate { get; set; }

        Guid? CreatedBy { get; set; }

        DateTime? ModifiedDate { get; set; }

        Guid? ModifiedBy { get; set; }
    }
}
