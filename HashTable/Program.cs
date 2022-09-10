using System;

namespace HashTable
{
    class Program
    {
        static void Main(string[] args)
        {
            // Создаем новую хеш таблицу.
            var hashTable = new Model.HashTable();

            // Добавляем данные в хеш таблицу в виде пар Ключ-Значение.
            hashTable.Insert("Носов", "Приключения Незнайки");
            hashTable.Insert("Аксаков", "Аленький цветочек");
            hashTable.Insert("Баруздин", "Короткие сказки");
            hashTable.Insert("Олеша", "Три толстяка");

            // Выводим хранимые значения на экран.
            ShowHashTable(hashTable, "Созданные хеш-таблицы.");
            Console.ReadLine();

            // Удаляем элемент из хеш таблицы по ключу и выводим измененную таблицу на экран.
            hashTable.Delete("Олеша");
            ShowHashTable(hashTable, "Удаление элемента из хеш-таблицы.");
            Console.ReadLine();

            // Получаем хранимое значение из таблицы по ключу.
            Console.WriteLine("Аксаков: ");
            var text = hashTable.Search("Аксаков");
            Console.WriteLine(text);
            Console.ReadLine();
        }

        /// <summary>
        /// Вывод хеш-таблицы на экран.
        /// </summary>
        /// <param name="hashTable"> Хеш таблица. </param>
        /// <param name="title"> Заголовок перед выводом таблицы. </param>
        private static void ShowHashTable(Model.HashTable hashTable, string title)
        {
            // Проверяем входные аргументы.
            if (hashTable == null)
            {
                throw new ArgumentNullException(nameof(hashTable));
            }

            if (string.IsNullOrEmpty(title))
            {
                throw new ArgumentNullException(nameof(title));
            }

            // Выводим все имеющие пары хеш-значение
            Console.WriteLine(title);
            foreach (var item in hashTable.Items)
            {
                // Выводим хеш
                Console.WriteLine(item.Key);

                // Выводим все значения хранимые под этим хешем.
                foreach (var value in item.Value)
                {
                    Console.WriteLine($"\t{value.Key} - {value.Value}");
                }
            }
            Console.WriteLine();
        }
    }
}
