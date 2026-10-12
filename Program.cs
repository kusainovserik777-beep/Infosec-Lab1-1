using System;
using System.Collections.Generic;

namespace InformationSecurityLab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            
            Console.WriteLine("==================================================");
            Console.WriteLine(" НАО «Казахский агротехнический исследовательский »");
            Console.WriteLine(" Лабораторно-практическое занятие №1: Основы ИБ");
            Console.WriteLine(" Выполнил: Кусаинов Серик");
            Console.WriteLine("==================================================\n");

            // Задание 1. Демонстрация принципов CIA
            RunTask1();

            // Задание 2. Классификация активов и угроз
            RunTask2();

            // Задание 3. Модель угроз и расчет рисков
            RunTask3();

            Console.WriteLine("\nВсе задания лабораторной работы успешно выполнены!");
        }

        static void RunTask1()
        {
            Console.WriteLine("--- ЗАДАНИЕ 1: Нарушение триады CIA ---");
            var situations = new[]
            {
                (Desc: "Сотрудник банка случайно отправил выписку на чужой e-mail", CIA: "C (Конфиденциальность)", Reason: "Утечка персональных данных постороннему лицу."),
                (Desc: "Вирус-шифровальщик заблокировал базу данных больницы", CIA: "A (Доступность) / I (Целостность)", Reason: "Данные заблокированы и изменены."),
                (Desc: "Злоумышленник изменил номер счёта в платёжном поручении", CIA: "I (Целостность)", Reason: "Несанкционированная модификация данных."),
                (Desc: "Сайт интернет-магазина упал из-за DDoS-атаки", CIA: "A (Доступность)", Reason: "Сервис недоступен для легитимных пользователей.")
            };

            foreach (var s in situations)
            {
                Console.WriteLine($"[Ситуация]: {s.Desc}");
                Console.WriteLine($" Нарушен принцип: {s.CIA}");
                Console.WriteLine($" Обоснование: {s.Reason}\n");
            }
        }

        static void RunTask2()
        {
            Console.WriteLine("--- ЗАДАНИЕ 2: Классификация активов и угроз вуза ---");
            Console.WriteLine("Актив: Электронный журнал оценок (Данные)");
            Console.WriteLine("Угроза: Подмена оценок перед сессией (Внутренняя, преднамеренная)\n");
        }

        static void RunTask3()
        {
            Console.WriteLine("--- ЗАДАНИЕ 3: Модель угроз (Личный кабинет студента) ---");
            Console.WriteLine(string.Format("{0,-20} | {1,-25} | {2,-15}", "Актив", "Угроза", "Уровень риска"));
            Console.WriteLine(new string('-', 65));
            Console.WriteLine(string.Format("{0,-20} | {1,-25} | {2,-15}", "Пароль студента", "Подбор/кража пароля", "Высокий"));
            Console.WriteLine(string.Format("{0,-20} | {1,-25} | {2,-15}", "База данных оценок", "Изменение ведомостей", "Высокий"));
            Console.WriteLine(string.Format("{0,-20} | {1,-25} | {2,-15}", "Сервер портала", "DDoS-атака", "Высокий"));
            Console.WriteLine("==================================================\n");
        }
    }
}