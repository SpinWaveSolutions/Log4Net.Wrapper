﻿using log4net.Layout;
using log4net.Util;

namespace Log4Net
{
    public class CustomPatternLayout : PatternLayout
    {
        public CustomPatternLayout ()
        {
            AddConverter(new ConverterInfo { Name = "method", Type = typeof(CustomPatternConverter) });
        }
    }
}
