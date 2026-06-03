using AppSeparadorMMs.Models;
using AppSeparadorMMs.Models.Interfaces;
using System.Globalization;

namespace AppSeparadorMMs.Serial
{
    public static class ProtocolWriter
    {
        public static string Serialize(ISerialMessage message)
        {
            return message switch
            {
                DataMessage data => SerializeData(data),
                CommandMessage command => SerializeCommand(command),
                StatusMessage status => SerializeStatus(status),

                _ => throw new NotSupportedException($"Unsupported message type: {message.GetType().Name}")
            };
        }

        private static string SerializeData(DataMessage message)
        {
            string value = message.Value.ToString(CultureInfo.InvariantCulture);

            return $"{message.ProtocolOwner} {message.ProtocolType}: {message.Data} = {value}";
        }

        private static string SerializeCommand(CommandMessage message)
        {
            if (string.IsNullOrWhiteSpace(message.Argument))
            {
                return $"{message.ProtocolOwner} {message.ProtocolType}: {message.Command}";
            }

            return $"{message.ProtocolOwner} {message.ProtocolType}: {message.Command} = {message.Argument}";
        }

        private static string SerializeStatus(StatusMessage message)
        {
            if (string.IsNullOrWhiteSpace(message.Details))
            {
                return $"{message.ProtocolOwner} {message.ProtocolType}: {message.Status}";
            }

            return $"{message.ProtocolOwner} {message.ProtocolType}: {message.Status} = {message.Details}";
        }
    }
}
