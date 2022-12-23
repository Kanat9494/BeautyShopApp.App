namespace BeautyShopApp.ViewModels.Base;

public class BaseViewModel : BindableObject
{
    public virtual Task InitializeAsync(object navigationData) =>
        Task.FromResult(false);
}
