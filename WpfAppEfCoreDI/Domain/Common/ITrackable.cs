using System;
using System.Collections.Generic;
using System.Text;

namespace WpfAppEfCoreDI.Domain.Common
{
    public interface ITrackable
    {
        DateTime CreatedAt { get; set; }
        DateTime ModifiedAt { get; set; }
    }
}
