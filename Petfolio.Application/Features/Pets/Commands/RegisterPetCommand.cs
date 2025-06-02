using Petfolio.Comunication.Requests;
using Petfolio.Comunication.Responses;

namespace Petfolio.Application.Features.Pets.Commands;
public class RegisterPetCommand
{
    public ResponsePetJson Execute(RequestPetJson request)
    {
        return new ResponsePetJson()
        {
            Id=2,
            Name=request.Name,   
        };
    }
}
