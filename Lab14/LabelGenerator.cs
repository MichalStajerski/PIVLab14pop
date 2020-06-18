using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Lab14
{
    public class LabelGenerator : IControlGenerator
    {
        public LabelGenerator()
        {
        }

        public UIElement Generate(string parameter)
        {
            return new Label()
            {
                Content = parameter
            };
        }
    }
}
