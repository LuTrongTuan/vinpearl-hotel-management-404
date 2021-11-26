using HotelManagement.UI.Utilities;

namespace HotelManagement.UI.Contracts
{
    public interface IValidate
    {
        IValidate Add(ValidateModel model);
        IValidate Run(bool name = false);
        bool Accept();
    }
}