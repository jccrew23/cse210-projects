public class Customer {
    private string _custName;
    private Address _custAddress;

    public double IntlAddress() {
        bool intlShip = _custAddress.IntlAddress();
        double shippingCost = 0;
        if (intlShip == true) {
             shippingCost = 35.00;
        }
        else {
             shippingCost = 5.00;
        }
        return shippingCost;
    }

    public void SetName(string name) {
        _custName = name;
    }

    public void SetAddress(Address addr) {
        _custAddress = addr;
    }

    public string GetName() {
        return _custName;
    }

    public string GetAddress() {
        string straddress = _custAddress.GetStrAddress();
        return straddress;
    }
}