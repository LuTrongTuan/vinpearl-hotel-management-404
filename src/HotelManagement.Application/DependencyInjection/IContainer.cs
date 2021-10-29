namespace HotelManagement.Application.DependencyInjection
{
    public interface IContainer
    {
        void Register<TInterface, TImplementation>() where TImplementation : TInterface;
	    void Register<TObject>() where TObject : class;
        TObject GetInstance<TObject>();
    }
}