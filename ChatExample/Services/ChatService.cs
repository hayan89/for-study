using ChatExample.Models;

namespace ChatExample.Services
{
    public class ChatService
    {
        private readonly List<ChatMessage> _messages = new List<ChatMessage>();

        public IEnumerable<ChatMessage> GetMessages()
        {
            return _messages;
        }

        public void AddMessage(string username, string message)
        {
            _messages.Add(new ChatMessage
            {
                Username = username,
                Message = message,
                Time = DateTime.Now.ToString("HH:mm:ss")
            });

            // 메시지 수가 많아지면 오래된 메시지 삭제
            if (_messages.Count > 50)
            {
                _messages.RemoveAt(0);
            }
        }
    }
}
