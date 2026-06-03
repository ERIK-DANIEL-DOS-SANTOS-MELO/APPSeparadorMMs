using AppSeparadorMMs.Models;
using AppSeparadorMMs.Models.Enums;
using AppSeparadorMMs.Models.Interfaces;

namespace AppSeparadorMMs.Serial
{
    public static class ProtocolReader
    {
        public static ISerialMessage? Parse(string raw)
        {
            if (string.IsNullOrWhiteSpace(raw)) return null;
            raw = raw.Trim();

            ProtocolOwner? owner = ParseOwner(ref raw);
            if (owner is null) return null;

            ProtocolType? protocol = ParseProtocol(ref raw);
            if (protocol is null) return null;

            return protocol switch
            {
                ProtocolType.Data => ParseData(owner.Value, raw),
                ProtocolType.Command => ParseCommand(owner.Value, raw),
                ProtocolType.Status => ParseStatus(owner.Value, raw),
                _ => null
            };
        }

        private static ProtocolOwner? ParseOwner(ref string raw)
        {
            foreach (ProtocolOwner owner in Enum.GetValues<ProtocolOwner>())
            {
                string ownerText = owner.ToString();

                if (raw.StartsWith(ownerText))
                {
                    raw = raw.Remove(0, ownerText.Length).Trim();
                    return owner;
                }
            }

            return null;
        }

        private static ProtocolType? ParseProtocol(ref string raw)
        {
            foreach (ProtocolType protocol in Enum.GetValues<ProtocolType>())
            {
                string protocolText = protocol + ":";

                if (raw.StartsWith(protocolText))
                {
                    raw = raw.Remove(0, protocolText.Length).Trim();
                    return protocol;
                }
            }

            return null;
        }

        private static DataMessage? ParseData(ProtocolOwner owner, string raw)
        {
            string[] parts = raw.Split('=', 2);

            if (parts.Length != 2) return null;

            string data = parts[0].Trim();
            string value = parts[1].Trim();

            if (string.IsNullOrWhiteSpace(data)) return null;

            return DataMessage.Create(owner, data, value);
        }

        private static CommandMessage? ParseCommand(ProtocolOwner owner, string raw)
        {
            string[] parts = raw.Split('=', 2);

            string command = parts[0].Trim();

            if (string.IsNullOrWhiteSpace(command)) return null;

            string? argument = parts.Length == 2 ? parts[1].Trim() : null;

            return new CommandMessage(owner, command, argument);
        }

        private static StatusMessage? ParseStatus(ProtocolOwner owner, string raw)
        {
            string[] parts = raw.Split('=', 2);

            string status = parts[0].Trim();

            if (string.IsNullOrWhiteSpace(status)) return null;

            string? details = parts.Length == 2 ? parts[1].Trim() : null;

            return new StatusMessage(owner, status, details);
        }
    }
}
