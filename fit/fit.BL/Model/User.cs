using System;
using System.Dynamic;

namespace fit.BL.Model
{
    /// <summary>
    /// Пользователь.
    /// </summary>
    class User
    {
        #region свойства
        public string Name { get; }
        public Gender Gender { get; }

        public DateTime BirthDate { get; }

        public double Weight { get; set; }
        public double Height { get; set; }
        #endregion

        /// <summary>
        /// Создать нового пользователя.
        /// </summary>
        /// <param name="name">Имя.</param>
        /// <param name="gender">Пол.</param>
        /// <param name="birthDate">Дата рождения.</param>
        /// <param name="weight">Вес.</param>
        /// <param name="height">Рост.</param>
        public User(string name, Gender gender, DateTime birthDate, double weight, double height)
        {
              
            #region проверка условий
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException("Имя не может быть пустым", nameof(name));
            }

            if(gender == null)
            {
                throw new ArgumentNullException("Пол не может быть пустым", nameof(gender));
            }

            if (birthDate < DateTime.Parse("01.01.1900") || birthDate >= DateTime.Now)
            {
                throw new ArgumentException("Невозможная дата рождения", nameof(birthDate));
            }

            if(weight <= 0)
            {
                throw new ArgumentNullException("Вес не может быть пустым", nameof(weight));
            }

            if (height <= 0)
            {
                throw new ArgumentException("Рост не может быть пустым", nameof(height));
            }
            #endregion

            Name = name;
            Gender = gender;
            BirthDate = birthDate;
            Weight = weight;
            Height = height;
        }

        public override string ToString()
        {
            return Name; 
        }
    }
}
