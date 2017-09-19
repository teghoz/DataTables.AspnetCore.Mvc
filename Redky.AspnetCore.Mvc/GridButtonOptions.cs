﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Redky.AspnetCore.Mvc
{
    /// <summary>
    /// Represents a global grid button
    /// </summary>
    class GridButtonOptions
    {
        /// <summary>
        /// Define which button type the button should be based on
        /// </summary>
        public string Extend { get; set; }

        /// <summary>
        /// The text to show in the button
        /// </summary>
        public string Text { get; set; }
    }
}