namespace AppSeparadorMMs.Models
{
    using AppSeparadorMMs.Models.Enums;
    using AppSeparadorMMs.Models.Interfaces;
    using System.Globalization;

    public record DataMessage(ProtocolOwner ProtocolOwner, string Data, double Value) : ISerialMessage
    {
        public ProtocolType ProtocolType => ProtocolType.Data;

        public static DataMessage? Create(ProtocolOwner owner, string data, string value)
        {
            if (!double.TryParse(value, NumberStyles.Float, CultureInfo.InvariantCulture, out double parsedValue))
            {
                return null;
            }

            return new DataMessage(owner, data, parsedValue);
        }
    }
}
