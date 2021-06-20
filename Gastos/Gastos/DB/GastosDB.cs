using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Gastos.Models;

namespace Gastos.DB
{
    public static class GastosDB
    {
        public static ObservableCollection<Gasto> gastos = new ObservableCollection<Gasto>();
    }
}
