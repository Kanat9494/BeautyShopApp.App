using BeautyShopApp.Services;

namespace BeautyShopApp.ViewModels;

public class HomeViewModel : BaseViewModel
{
    ObservableCollection<Product> _products;

    public HomeViewModel()
    {
        LoadData();
    }

    public ObservableCollection<Product> Products
    {
        get => _products;
        set
        {
            _products = value;
            OnPropertyChanged();
        }
    }

    private void LoadData()
    {
        Products = new ObservableCollection<Product>();

        Products.Add(new Product());

        foreach (var product in ProductService.Instance.GetProducts())
            Products.Add(product);
    }
}
