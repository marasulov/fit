using System;

namespace fit.BL.Model
{
    /// <summary>
    /// Пол
    /// </summary>
    class Gender
    {
        /// <summary>
        /// Название
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// Создать новый пол
        /// </summary>
        /// <param name="name">Имя пола</param>
        public Gender(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException("Имя пола должно быть не пустым", nameof(name));
            }

            Name = name;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
