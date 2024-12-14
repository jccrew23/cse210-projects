using System.Configuration.Assemblies;
using System.Security.Authentication;

public class Address {
    private string _strAddress;
    private string _city;
    private string _state;
    private string _country;
    public bool IntlAddress() {
        if (_country != "United States") {
            return true;
        }
        else {
            return false;
        }
    }

    public void SetAddress(string street, string city, string state, string country) {
        _strAddress = street;
        _city = city;
        _state = state;
        _country = country;
    }

    public string GetStrAddress() {
        return _strAddress;
    }
     

}