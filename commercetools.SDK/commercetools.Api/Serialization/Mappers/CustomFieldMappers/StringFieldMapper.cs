using commercetools.Api.Models.Types;
using commercetools.Base.Serialization.Mappers;

namespace commercetools.Api.Serialization.Mappers.CustomFieldMappers
{
    class StringFieldMapper : StringConverter<FieldContainer, string>, ICustomJsonMapper<FieldContainer>
    {
    }
}