﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbakonXVWPF.Views
{
    interface IProgressView
    {
        void ProgressViewInit(int stepCount, string titleText, bool showCancel);
        bool ProgressViewUpdate(int progress, string titleText);
        bool ProgressViewUpdate(int progress);
        void ProgressViewRemove();
    }
}
