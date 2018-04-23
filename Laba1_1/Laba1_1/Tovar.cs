using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Laba1_1
{
    public class Tovar
    {
        private string name;
        private int kol_vo;
        private float stoimost;

        /// <summary>
        /// Инициализирует новый экземпляр класса Tovar значением по умалчанию
        /// </summary> 

        public Tovar()
        {
            this.name = "";
            this.kol_vo = 0;
            this.stoimost = 0;

        }
        /// <summary>
        /// Инициализирует новый экземпляр класса Tovar значением 
        /// </summary>
        /// <param name="name">Имя</param>
        /// <param name="kol_vo">Количество</param>
        /// <param name="stoimost">Стоимость</param>
        public Tovar(string Name, int Kol_vo, float Stoimost)
        {
            Name = name;
            Kol_vo = kol_vo;
            Stoimost = stoimost;
        }
        /// <summary>
        /// Вход объекта класса
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "\n Имя: " + name + "\n Количество: " + kol_vo + "\n Стоимость  : " + stoimost;
        }
    }
}
