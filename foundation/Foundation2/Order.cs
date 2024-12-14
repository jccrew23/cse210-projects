public class Order {
    public List<Product> _orderProducts = new List<Product>();
    private Customer _customer;
    public double TotalCost() {

        double subtotal = 0;
        foreach (Product prod in _orderProducts) {
            double price = prod.ProductTotal();
            subtotal += price;
        }
       double shipping =  _customer.IntlAddress();
       double total = subtotal + shipping;
       return total;
    }
    public string ProvidePackingLabel() {
        string pLabel = "";
        foreach (Product prod in _orderProducts) {
            string proName = prod.GetPName();
            int proID = prod.GetPID();
            pLabel += $"{proName}{proID}";
        }
        pLabel = pLabel.Replace(" ","");
        return pLabel;
    }
    public string ProvideShippingLabel() {
        string name = _customer.GetName();
        string address = _customer.GetAddress();
        string sLabel = $"{name}{address}";
        sLabel = sLabel.Replace(" ","");
        return sLabel;
    }

    public void SetCustomer(Customer cust) {
        _customer = cust;
    }
}