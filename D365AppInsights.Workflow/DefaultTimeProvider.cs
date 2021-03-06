﻿using System;

namespace D365AppInsights.Workflow
{
    internal sealed class DefaultTimeProvider : ITimeProvider
    {
        public DateTime Now => DateTime.Now;

        public DateTime UtcNow => DateTime.UtcNow;

        public DateTime Today => DateTime.Today;
    }
}