using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Leadify.Persistence.UlidProperty;

public class UlidToStringConverter : ValueConverter<Ulid, string>
{
    private static readonly ConverterMappingHints _defaultHints = new(26);

    public UlidToStringConverter()
        : this(null)
    {
    }

    public UlidToStringConverter(ConverterMappingHints? mappingHints = null)
        : base(
            x => x.ToString(),
            x => Ulid.Parse(x),
            _defaultHints.With(mappingHints)
        )
    {
    }
}