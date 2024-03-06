namespace Module18
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            string uri = String.Empty;
            try
            {
                uri = args[0];
            }
            catch
            {
                Console.WriteLine("Не указан путь");
                Console.ReadKey();
                return;
            }

            
            // создадим отправителя
            var sender = new Senders.YouTubeVideoOperator();

            // создадим получателя
            var infoReceiver = new Receivers.YouTubeVideoInformation(uri);
            var videoReceiver = new Receivers.YouTubeVideo(uri);

            // создадим команду
            var commandOne = new Commands.YouTubeVideoCommand(infoReceiver);
            var commandTwo = new Commands.YouTubeVideoCommand(videoReceiver);


            // инициализация команды
            sender.SetCommand(commandOne);

            //  выполнение
            sender.Run();

            sender.SetCommand(commandTwo);

            //  выполнение
            sender.Run();

            Console.WriteLine("Для выхода нажмите любую клавишу");
            Console.ReadKey();
        }
    }
}
