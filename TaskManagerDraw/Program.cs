using System;
using System.Drawing;
using System.Runtime.InteropServices;

namespace TaskManagerDraw
{
    class Program
    {
        [DllImport("user32.dll")]
        private static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        static void Main(string[] args)
        {
            // Получаем дескриптор окна 'Диспетчер задач'. 
            var handle = FindWindow(null, "Диспетчер задач");

            // Создаем экземпляр класса Graphics, передавая дескриптор окна.
            using (var gr = Graphics.FromHwnd(handle))
            {
                Rectangle rect = new Rectangle(44, 4, 530, 53);
                // Рисуем прямоугольник в окне Диспетчера задач.
                gr.DrawRectangle(new Pen(Color.Red, 10), rect);
            }

        }
    }
}
