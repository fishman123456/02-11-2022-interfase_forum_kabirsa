using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    internal class cat : _Home_Animals, Interface_1
    {
        bool _isComp = true;// компаньон или нет иными словами помошник
        protected string? _breed; // порода
        protected string? _color; // цвет
        public cat(string? name, string? age, string? breed, string? color):base (name, age)
        {
            this._breed = breed;
            this._color = color;
        }
        public bool IsComp
        {
            get { return _isComp; }
        }
        public string TypeName()
        {
            return "Кошка";
        }
        public override string ToString() // прегрузка string для передачи полей для вывода на консоль
        {
            return $"Имя {this._name}, возраст {this._age}, " +
                $"порода {this._breed}, цвет {this._color} " +
                $" идентифицирует себя как { this.TypeName()}";
        }
    }
}
