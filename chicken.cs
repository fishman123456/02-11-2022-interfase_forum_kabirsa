using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Animals
{
    internal class chicken : _Home_Animals, Interface_1
    {
        bool _isComp = true;// компаньон или нет иными словами помошник
        public string? _eggs; // сколько яиц дает курица
        public string? _meal; // какую еду предпочитает

        public chicken (string? name, string? age, string? eggs, string? meal) : base(name, age)
        {
            this._eggs = eggs;
            this._meal = meal;
        }
        public bool IsComp
        {
            get { return _isComp; }
        }
        public string TypeName()
        {
            return "Курица";
        }
        public override string ToString() // прегрузка string для передачи полей для вывода на консоль
        {
            return $"Имя {this._name}, возраст {this._age} ," +
                $" кол-во яиц в день {this._eggs}, какую еду любит {this._meal}" +
                $" идентифицирует себя как {this.TypeName()}";
        }
    }
}
