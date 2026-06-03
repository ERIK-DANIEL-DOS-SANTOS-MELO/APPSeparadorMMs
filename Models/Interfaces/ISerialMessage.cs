using AppSeparadorMMs.Models.Enums;

namespace AppSeparadorMMs.Models.Interfaces
{
    public interface ISerialMessage
    {
        ProtocolType ProtocolType { get; }
        ProtocolOwner ProtocolOwner { get; }
    }
}
