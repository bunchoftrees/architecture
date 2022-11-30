using System;
using Newtonsoft.Json;

internal class Program
{
    private static void Main(string[] args)
    {
        
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