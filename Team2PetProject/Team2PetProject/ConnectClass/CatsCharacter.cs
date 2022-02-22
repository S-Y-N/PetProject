using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team2PetProject
{
    /// <summary>
    /// Класс - реализует таблицу Characteristics
    /// </summary>
    class CatsCharacter
    {
        //ID поля в таблице
        public int Id { get; private set; }
        //Название породы
        public string Name { get; private set; }
        //Балл адаптации животного
        public int Adapt { get; private set; }
        //Балл дружелюбности
        public int Atach { get; private set; }
       //Интелект
        public int Intel { get; private set; }
      //Общее здоровье
        public int Health { get; private set; }

        /// <summary>
        /// Создание объекта 
        ///Наполнение его значениями 
        /// </summary>
        /// <param name="values">Массив значений</param>
        /// <returns>вернуть заполненый объект</returns>
       public static CatsCharacter FromTableToForm(object[]values)
        {
            CatsCharacter catsCharacter = new CatsCharacter();
            catsCharacter.Id = (int)values[0];
            catsCharacter.Name = (string)values[1];
            catsCharacter.Adapt = (int)values[2];
            catsCharacter.Atach = (int)values[3];
            catsCharacter.Intel = (int)values[4];
            catsCharacter.Health = (int)values[5];
            return catsCharacter;
        }
    }
}
