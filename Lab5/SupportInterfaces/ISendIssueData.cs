﻿using Lab5.UserSupport;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5.SupportInterfaces
{
    public interface ISendIssueData
    {
        void SendData(int id, HashSet<KEY_DATA_ENTITY> keyData, string issue);
    }
}
