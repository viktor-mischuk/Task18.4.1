using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Module18.Interfaces;

namespace Module18.Commands
{
    internal class YouTubeVideoCommand : ICommand
    {
        IReceiver receiver;

        public YouTubeVideoCommand(IReceiver receiver)
        {
            this.receiver = receiver;
        }

        public void Cancel()
        {
            throw new NotImplementedException();
        }

        public void Run()
        {
            receiver.Operation();
        }
    }
}
