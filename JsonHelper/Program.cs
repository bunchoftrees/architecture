using System;
using System.Text.Json;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        var incoming = new List<Product>();
        using (StreamReader r = new StreamReader("Products_Course_Mapping_b2c.json"))
        {
            string json = r.ReadToEnd();
            incoming = JsonSerializer.Deserialize<List<Product>>(json);
        }

        if (incoming != null && incoming.Count > 0)
        {
            foreach (var product in incoming)
            {
                Console.WriteLine($"{product.ProductName}");
            }
        }
    }
}

public record struct Product(
    string salsifyid,
    DateTime salsifycreated_at,
    DateTime salsifyupdated_at,
    int salsifyversion,
    string salsifyprofile_asset_id,
    string salsifysystem_id,
    string SKU,
    string ProductName,
    bool Purchasable,
    string AvaTaxCode,
    string SystemLongDescription,
    string SystemShortDescription,
    bool IsActive,
    string NetsuiteIncomeAccount,
    List<string> Courses,
    string ProductType,
    string NetSuiteDepartment,
    string NetSuiteID,
    string NetsuiteLocation,
    string NetSuiteClass,
    string NetsuiteSubsidiary,
    string NetsuiteRevenueRecognitionRule,
    string Brand,
    string LeadProductManager,
    bool ShowPrice,
    string eCommerceStatus,
    string RetailPrice,
    List<string> Keywords,
    string Product_Type_Computed,
    string Table_Example
    );