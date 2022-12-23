namespace BeautyShopApp.ViewControls;

public class ProductItemTemplateSelector : DataTemplateSelector
{
    public DataTemplate ProductItemTemplate { get; set; }
    public DataTemplate ResultItemTemplate { get; set; }   
    protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
    {
        var product = (Product)item;

        if (product.IsEmpty())
            return ResultItemTemplate;

        return ProductItemTemplate;
    }
}
