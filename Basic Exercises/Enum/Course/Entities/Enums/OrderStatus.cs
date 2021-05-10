using System;
using System.Collections.Generic;
using System.Text;

namespace Course.Entities.Enums
{
    enum OrderStatus : int
    {
        PendingPayment= 0, //O valor por padrão será 0 se não for deifinido.
        Processing = 1,
        Shipped = 2,
        Delivered = 3

    }
}
