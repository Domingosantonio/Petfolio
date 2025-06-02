using Petfolio.Comunication.Responses;

namespace Petfolio.Application.Features.Pets.Queries;
public class GetByIdPetQuery
{
    public ResponsePetJson Execute(int id) {
        return new ResponsePetJson()
        {
            Id=1,
            Name="Milú"
        };
    
    }
}
