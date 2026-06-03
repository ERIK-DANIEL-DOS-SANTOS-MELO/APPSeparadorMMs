using AppSeparadorMMs.Models.Enums;
using AppSeparadorMMs.Models.Interfaces;

namespace AppSeparadorMMs.Models
{
    public record CommandMessage(ProtocolOwner ProtocolOwner, string Command, string? Argument = null) : ISerialMessage
    {
        public ProtocolType ProtocolType => ProtocolType.Command;
    }
}
