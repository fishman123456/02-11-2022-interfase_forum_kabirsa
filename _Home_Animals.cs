using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    abstract class _Home_Animals
    {
        protected string? _name;
        protected string? _age;
        public _Home_Animals(string? name, string? age)
        {
            this._name = name;
            this._age = age;
        }

        public override string ToString() // прегрузка string для передачи полей для вывода на консоль
        {
            return $"Имя {this._name}, возраст {this._age}";
        }
    }
}
