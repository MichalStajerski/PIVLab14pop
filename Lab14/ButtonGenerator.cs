using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Lab14
{
    class ButtonGenerator : IControlGenerator
    {
        public UIElement Generate(string parameter)
        {
            return new Button()
            {
                Content = parameter
            };
        }
    }
}
