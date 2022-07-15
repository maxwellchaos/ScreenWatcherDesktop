using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenWatcherDesktop.Messages
{
    class ComputerWork
    {

        /// <summary>
        /// Идентификатор компьютера по оборудованию
        /// </summary>
        public string ComputerId { get; set; }

        /// <summary>
        /// Название компьютера, указанное в десктопной программе
        /// </summary>
        public string ComputerName { get; set; }

        /// <summary>
        /// Видео работает
        /// </summary>
        public bool IsRunning { get; set; }

        /// <summary>
        /// Таймаут проверок на зависание, установленный на компьютере
        /// </summary>
        public int Timeout { get; set; }
    }
}
