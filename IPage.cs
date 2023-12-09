using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseApp
{
    internal interface IPage
    {
        string Title { get; }
        abstract void RefreshPage();
    }
}
