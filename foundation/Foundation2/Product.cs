public class Product {
    private string _prodName;
    private int _prodId;
    private double _prodPrice;
    private int _prodQuantity;

    public double ProductTotal() {
       double ptotal = _prodPrice * _prodQuantity;
       return ptotal;
    }

    public void SetProduct(string pName, int pId, double pPrice, int pQuant) {
        _prodName = pName;
        _prodId = pId;
        _prodPrice = pPrice;
    _prodQuantity = pQuant;
    }

    public double GetPrice() {
        return _prodPrice;
    }

    public string GetPName() {
        return _prodName;
    }

    public int GetPID() {
        return _prodId;
    }
}