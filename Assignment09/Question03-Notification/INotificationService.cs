﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment09.Question03_Notification
{
    internal interface INotificationService
    {
        void SendNotification(string recipient, string message);
    }
}
