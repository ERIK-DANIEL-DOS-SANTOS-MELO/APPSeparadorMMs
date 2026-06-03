using AppSeparadorMMs.Models.Enums;
using AppSeparadorMMs.Models.Interfaces;

namespace AppSeparadorMMs.Models
{
    public record StatusMessage(ProtocolOwner ProtocolOwner, string Status, string? Details = null) : ISerialMessage
    {
        public ProtocolType ProtocolType => ProtocolType.Status;
    }
}
