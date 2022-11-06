using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Animals
{
    internal class dog : _Home_Animals, Interface_1
    {
        bool _isComp = true;// компаньон или нет иными словами помошник
        public string? _speed; //скорость передвижения
        public string? _owner; // имя хозяина

        public dog (string? name, string? age, string? speed, string? owner) : base(name, age)
        {
            this._speed = speed;
            this._owner = owner;
        }
        public bool IsComp
        {
            get { return _isComp; }
        }
        public string TypeName()
        {
            return "Собака";
        }
        public override string ToString() // прегрузка string для передачи полей для вывода на консоль
        {
            return $"Имя {this._name}, возраст {this._age}," +
                $"скорость {this._speed}, имя хозяина {this._owner}" +
                $" идентифицирует себя как {this.TypeName()}";
            
        }
    }
    
}
