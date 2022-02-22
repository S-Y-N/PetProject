using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team2PetProject.ConnectClass
{
    /// <summary>
    /// Класс описывает взаимодействие таблицы InfoOfCats с формой 
    /// Прозводит взаимодействие с полями таблицы и элементами на форме
    /// </summary>
    class CatsInfo
    {
        //Id животного в таблице
        public int Id { get; private set; }
        //Название породы кошки
        public string Name { get; private set; }
        //Страна проихождения породы
        public string Country { get; private set; }
        //Длительность жизни
        public string TimeOfLife { get; private set; }
        //Размер породы, нужен для сортировки пород
        public string Size { get; private set; }
        //Вес животного
        public string Height { get; private set; }
        //Длина шерсти
        public string TypeOfWool { get; private set; }
        //Группа  животных - для дальнейшей сортировки по группам
        public string Groupa { get; private set; }
        //Цена
        public int Price { get; private set; }
        /// <summary>
        /// Метод для создание объекта и и присвоения ему значений с таблицы
        /// </summary>
        /// <param name="values">Создаем массив и наполняем его значениями с таблицы</param>
        /// <returns>Возвращаем объект наполненый значениями с таблицы</returns>
        public static CatsInfo FillTableValues(object [] values)
        {
            CatsInfo catsInfo = new CatsInfo();
            catsInfo.Id = (int)values[0];
            catsInfo.Name = (string)values[1];
            catsInfo.Country = (string)values[2];
            catsInfo.TimeOfLife = (string)values[3];
            catsInfo.Size = (string)values[4];
            catsInfo.Height = (string)values[5];
            catsInfo.TypeOfWool = (string)values[6];
            catsInfo.Groupa = (string)values[7];
            catsInfo.Price = (int)values[8];

            return catsInfo;
        
        }
    }

}
