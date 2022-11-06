using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Animals
{
    internal class cow : _Home_Animals, Interface_1
    {
        bool _isComp = true; // компаньон или нет иными словами помошник
        public string? _efficiency; // производительность
        public string? _weight; // вес
        public bool IsComp
        {
            get { return _isComp; }
        }


        public string TypeName()
        {
            return "Корова";
        }
        public cow (string? name, string? age, string? efficiency, string weight ) : base( name, age)
        {
            this._efficiency = efficiency;
            this._weight = weight;
        }
        public string Voice()
        {
            return "Мууууууууу";
        }
        public override string ToString() // прегрузка string для передачи полей для вывода на консоль
        {
            return $"Имя {this._name}, возраст {this._age}" +
                $"кол-во молока {this._efficiency}, вес животного {this._weight}"+
                $" идентифицирует себя как {this.TypeName()}";
        }
    }
}
