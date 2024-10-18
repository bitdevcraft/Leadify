using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Leadify.Persistence.UlidProperty;

public class UlidToBytesConverter : ValueConverter<Ulid, byte[]>
{
    private static readonly ConverterMappingHints _defaultHints = new(
        16
    );

    public UlidToBytesConverter()
        : this(null)
    {
    }

    public UlidToBytesConverter(ConverterMappingHints? mappingHints = null)
        : base(
            x => x.ToByteArray(),
            x => new Ulid(x),
            _defaultHints.With(mappingHints)
        )
    {
    }
}