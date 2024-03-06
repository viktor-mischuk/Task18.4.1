using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Module18.Interfaces;

namespace Module18.Senders
{
    /// <summary>
    /// Отправитель команды
    /// </summary>
    class YouTubeVideoOperator
    {
        ICommand _command;

        public void SetCommand(ICommand command)
        {
            _command = command;
        }

        // Выполнить
        public void Run()
        {
            _command.Run();
        }

        // Отменить
        public void Cancel()
        {
            _command.Cancel();
        }
    }
}
