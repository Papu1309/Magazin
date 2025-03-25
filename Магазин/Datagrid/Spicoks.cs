using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Магазин.Datagrid
{
    public class Spicokk
    {
        public ObservableCollection<Spicok> Spicoks { get; set; }
        public Spicokk()
        {
            Spicoks = new ObservableCollection<Spicok>
           {
                new Spicok { Name = "Товар 1", Price = 100 },
                new Spicok { Name = "Товар 2", Price = 200 },
                new Spicok { Name = "Товар 3", Price = 300 }
           };
        }
    }
}
