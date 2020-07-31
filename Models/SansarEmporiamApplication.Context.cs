﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SansarEmporiamApplication.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class SansarEmporiamApplicationEntities : DbContext
    {
        public SansarEmporiamApplicationEntities()
            : base("name=SansarEmporiamApplicationEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<tblCustomerDetail> tblCustomerDetails { get; set; }
        public virtual DbSet<tblShopDetail> tblShopDetails { get; set; }
        public virtual DbSet<tblStockDetail> tblStockDetails { get; set; }
        public virtual DbSet<tblWholeSellerDetail> tblWholeSellerDetails { get; set; }
        public virtual DbSet<Log> Logs { get; set; }
    
        public virtual ObjectResult<Nullable<decimal>> ProcedureToAddShopDetails(string shopName, string ownerName, string shopAddres, string registrationNumber, string mobileNumber)
        {
            var shopNameParameter = shopName != null ?
                new ObjectParameter("ShopName", shopName) :
                new ObjectParameter("ShopName", typeof(string));
    
            var ownerNameParameter = ownerName != null ?
                new ObjectParameter("OwnerName", ownerName) :
                new ObjectParameter("OwnerName", typeof(string));
    
            var shopAddresParameter = shopAddres != null ?
                new ObjectParameter("ShopAddres", shopAddres) :
                new ObjectParameter("ShopAddres", typeof(string));
    
            var registrationNumberParameter = registrationNumber != null ?
                new ObjectParameter("RegistrationNumber", registrationNumber) :
                new ObjectParameter("RegistrationNumber", typeof(string));
    
            var mobileNumberParameter = mobileNumber != null ?
                new ObjectParameter("MobileNumber", mobileNumber) :
                new ObjectParameter("MobileNumber", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<decimal>>("ProcedureToAddShopDetails", shopNameParameter, ownerNameParameter, shopAddresParameter, registrationNumberParameter, mobileNumberParameter);
        }
    
        public virtual int ProcedureToDeleteShopDetails(Nullable<int> shopID)
        {
            var shopIDParameter = shopID.HasValue ?
                new ObjectParameter("ShopID", shopID) :
                new ObjectParameter("ShopID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ProcedureToDeleteShopDetails", shopIDParameter);
        }
    
        public virtual ObjectResult<ProcedureToGetShopDetails_Result> ProcedureToGetShopDetails()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ProcedureToGetShopDetails_Result>("ProcedureToGetShopDetails");
        }
    
        public virtual ObjectResult<ProcedureToGetShopDetailsByID_Result> ProcedureToGetShopDetailsByID(Nullable<int> shopID)
        {
            var shopIDParameter = shopID.HasValue ?
                new ObjectParameter("ShopID", shopID) :
                new ObjectParameter("ShopID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ProcedureToGetShopDetailsByID_Result>("ProcedureToGetShopDetailsByID", shopIDParameter);
        }
    
        public virtual int ProcedureToUpdateShopDetails(Nullable<int> shopID, string shopName, string ownerName, string shopAddres, string registrationNumber, string mobileNumber)
        {
            var shopIDParameter = shopID.HasValue ?
                new ObjectParameter("ShopID", shopID) :
                new ObjectParameter("ShopID", typeof(int));
    
            var shopNameParameter = shopName != null ?
                new ObjectParameter("ShopName", shopName) :
                new ObjectParameter("ShopName", typeof(string));
    
            var ownerNameParameter = ownerName != null ?
                new ObjectParameter("OwnerName", ownerName) :
                new ObjectParameter("OwnerName", typeof(string));
    
            var shopAddresParameter = shopAddres != null ?
                new ObjectParameter("ShopAddres", shopAddres) :
                new ObjectParameter("ShopAddres", typeof(string));
    
            var registrationNumberParameter = registrationNumber != null ?
                new ObjectParameter("RegistrationNumber", registrationNumber) :
                new ObjectParameter("RegistrationNumber", typeof(string));
    
            var mobileNumberParameter = mobileNumber != null ?
                new ObjectParameter("MobileNumber", mobileNumber) :
                new ObjectParameter("MobileNumber", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ProcedureToUpdateShopDetails", shopIDParameter, shopNameParameter, ownerNameParameter, shopAddresParameter, registrationNumberParameter, mobileNumberParameter);
        }
    
        public virtual ObjectResult<Nullable<decimal>> ProcedureToAddCustomerDetails(string firstName, string lastName, string mobileNumber, string emailID, string city, string customerAddress, string purchaseItem, string purchaseDate, string totalAmount, string paidAmount, string balance, string dueDate, string remainderMessage)
        {
            var firstNameParameter = firstName != null ?
                new ObjectParameter("FirstName", firstName) :
                new ObjectParameter("FirstName", typeof(string));
    
            var lastNameParameter = lastName != null ?
                new ObjectParameter("LastName", lastName) :
                new ObjectParameter("LastName", typeof(string));
    
            var mobileNumberParameter = mobileNumber != null ?
                new ObjectParameter("MobileNumber", mobileNumber) :
                new ObjectParameter("MobileNumber", typeof(string));
    
            var emailIDParameter = emailID != null ?
                new ObjectParameter("EmailID", emailID) :
                new ObjectParameter("EmailID", typeof(string));
    
            var cityParameter = city != null ?
                new ObjectParameter("City", city) :
                new ObjectParameter("City", typeof(string));
    
            var customerAddressParameter = customerAddress != null ?
                new ObjectParameter("CustomerAddress", customerAddress) :
                new ObjectParameter("CustomerAddress", typeof(string));
    
            var purchaseItemParameter = purchaseItem != null ?
                new ObjectParameter("PurchaseItem", purchaseItem) :
                new ObjectParameter("PurchaseItem", typeof(string));
    
            var purchaseDateParameter = purchaseDate != null ?
                new ObjectParameter("PurchaseDate", purchaseDate) :
                new ObjectParameter("PurchaseDate", typeof(string));
    
            var totalAmountParameter = totalAmount != null ?
                new ObjectParameter("TotalAmount", totalAmount) :
                new ObjectParameter("TotalAmount", typeof(string));
    
            var paidAmountParameter = paidAmount != null ?
                new ObjectParameter("PaidAmount", paidAmount) :
                new ObjectParameter("PaidAmount", typeof(string));
    
            var balanceParameter = balance != null ?
                new ObjectParameter("Balance", balance) :
                new ObjectParameter("Balance", typeof(string));
    
            var dueDateParameter = dueDate != null ?
                new ObjectParameter("DueDate", dueDate) :
                new ObjectParameter("DueDate", typeof(string));
    
            var remainderMessageParameter = remainderMessage != null ?
                new ObjectParameter("RemainderMessage", remainderMessage) :
                new ObjectParameter("RemainderMessage", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<decimal>>("ProcedureToAddCustomerDetails", firstNameParameter, lastNameParameter, mobileNumberParameter, emailIDParameter, cityParameter, customerAddressParameter, purchaseItemParameter, purchaseDateParameter, totalAmountParameter, paidAmountParameter, balanceParameter, dueDateParameter, remainderMessageParameter);
        }
    
        public virtual ObjectResult<Nullable<decimal>> ProcedureToAddStockDetail(string itemName, string wholeSellPrice, string sellingPrice, string numberOfCount, string weight)
        {
            var itemNameParameter = itemName != null ?
                new ObjectParameter("ItemName", itemName) :
                new ObjectParameter("ItemName", typeof(string));
    
            var wholeSellPriceParameter = wholeSellPrice != null ?
                new ObjectParameter("WholeSellPrice", wholeSellPrice) :
                new ObjectParameter("WholeSellPrice", typeof(string));
    
            var sellingPriceParameter = sellingPrice != null ?
                new ObjectParameter("SellingPrice", sellingPrice) :
                new ObjectParameter("SellingPrice", typeof(string));
    
            var numberOfCountParameter = numberOfCount != null ?
                new ObjectParameter("NumberOfCount", numberOfCount) :
                new ObjectParameter("NumberOfCount", typeof(string));
    
            var weightParameter = weight != null ?
                new ObjectParameter("Weight", weight) :
                new ObjectParameter("Weight", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<decimal>>("ProcedureToAddStockDetail", itemNameParameter, wholeSellPriceParameter, sellingPriceParameter, numberOfCountParameter, weightParameter);
        }
    
        public virtual ObjectResult<Nullable<decimal>> ProcedureToAddWholeSellerDetail(string shopName, string ownerName, string shopAddres, string registrationNumber, string mobileNumber)
        {
            var shopNameParameter = shopName != null ?
                new ObjectParameter("ShopName", shopName) :
                new ObjectParameter("ShopName", typeof(string));
    
            var ownerNameParameter = ownerName != null ?
                new ObjectParameter("OwnerName", ownerName) :
                new ObjectParameter("OwnerName", typeof(string));
    
            var shopAddresParameter = shopAddres != null ?
                new ObjectParameter("ShopAddres", shopAddres) :
                new ObjectParameter("ShopAddres", typeof(string));
    
            var registrationNumberParameter = registrationNumber != null ?
                new ObjectParameter("RegistrationNumber", registrationNumber) :
                new ObjectParameter("RegistrationNumber", typeof(string));
    
            var mobileNumberParameter = mobileNumber != null ?
                new ObjectParameter("MobileNumber", mobileNumber) :
                new ObjectParameter("MobileNumber", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<decimal>>("ProcedureToAddWholeSellerDetail", shopNameParameter, ownerNameParameter, shopAddresParameter, registrationNumberParameter, mobileNumberParameter);
        }
    
        public virtual int ProcedureToDeleteCustmerDetail(Nullable<int> customerID)
        {
            var customerIDParameter = customerID.HasValue ?
                new ObjectParameter("CustomerID", customerID) :
                new ObjectParameter("CustomerID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ProcedureToDeleteCustmerDetail", customerIDParameter);
        }
    
        public virtual int ProcedureToDeleteStockDetails(Nullable<int> stockID)
        {
            var stockIDParameter = stockID.HasValue ?
                new ObjectParameter("StockID", stockID) :
                new ObjectParameter("StockID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ProcedureToDeleteStockDetails", stockIDParameter);
        }
    
        public virtual int ProcedureToDeleteWholeSellerDetails(Nullable<int> shopID)
        {
            var shopIDParameter = shopID.HasValue ?
                new ObjectParameter("ShopID", shopID) :
                new ObjectParameter("ShopID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ProcedureToDeleteWholeSellerDetails", shopIDParameter);
        }
    
        public virtual ObjectResult<ProcedureToGetCustomerByNameAndAddress_Result> ProcedureToGetCustomerByNameAndAddress(string firstNameOrAddress)
        {
            var firstNameOrAddressParameter = firstNameOrAddress != null ?
                new ObjectParameter("FirstNameOrAddress", firstNameOrAddress) :
                new ObjectParameter("FirstNameOrAddress", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ProcedureToGetCustomerByNameAndAddress_Result>("ProcedureToGetCustomerByNameAndAddress", firstNameOrAddressParameter);
        }
    
        public virtual ObjectResult<ProcedureToGetCustomerDetails_Result> ProcedureToGetCustomerDetails()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ProcedureToGetCustomerDetails_Result>("ProcedureToGetCustomerDetails");
        }
    
        public virtual ObjectResult<ProcedureToGetStockDetail_Result> ProcedureToGetStockDetail()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ProcedureToGetStockDetail_Result>("ProcedureToGetStockDetail");
        }
    
        public virtual ObjectResult<ProcedureToGetStockDetailByName_Result> ProcedureToGetStockDetailByName(string name)
        {
            var nameParameter = name != null ?
                new ObjectParameter("Name", name) :
                new ObjectParameter("Name", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ProcedureToGetStockDetailByName_Result>("ProcedureToGetStockDetailByName", nameParameter);
        }
    
        public virtual ObjectResult<ProcedureToGetWholeSellerByNameOrAddress_Result> ProcedureToGetWholeSellerByNameOrAddress(string firstNameOrAddress)
        {
            var firstNameOrAddressParameter = firstNameOrAddress != null ?
                new ObjectParameter("FirstNameOrAddress", firstNameOrAddress) :
                new ObjectParameter("FirstNameOrAddress", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ProcedureToGetWholeSellerByNameOrAddress_Result>("ProcedureToGetWholeSellerByNameOrAddress", firstNameOrAddressParameter);
        }
    
        public virtual ObjectResult<ProcedureToGetWholesellerDetail_Result> ProcedureToGetWholesellerDetail()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ProcedureToGetWholesellerDetail_Result>("ProcedureToGetWholesellerDetail");
        }
    
        public virtual int ProcedureToUpdateCustomerDetail(Nullable<int> customerID, string firstName, string lastName, string mobileNumber, string emailID, string city, string customerAddress, string purchaseItem, string purchaseDate, string totalAmount, string paidAmount, string balance, string dueDate, string remainderMessage)
        {
            var customerIDParameter = customerID.HasValue ?
                new ObjectParameter("CustomerID", customerID) :
                new ObjectParameter("CustomerID", typeof(int));
    
            var firstNameParameter = firstName != null ?
                new ObjectParameter("FirstName", firstName) :
                new ObjectParameter("FirstName", typeof(string));
    
            var lastNameParameter = lastName != null ?
                new ObjectParameter("LastName", lastName) :
                new ObjectParameter("LastName", typeof(string));
    
            var mobileNumberParameter = mobileNumber != null ?
                new ObjectParameter("MobileNumber", mobileNumber) :
                new ObjectParameter("MobileNumber", typeof(string));
    
            var emailIDParameter = emailID != null ?
                new ObjectParameter("EmailID", emailID) :
                new ObjectParameter("EmailID", typeof(string));
    
            var cityParameter = city != null ?
                new ObjectParameter("City", city) :
                new ObjectParameter("City", typeof(string));
    
            var customerAddressParameter = customerAddress != null ?
                new ObjectParameter("CustomerAddress", customerAddress) :
                new ObjectParameter("CustomerAddress", typeof(string));
    
            var purchaseItemParameter = purchaseItem != null ?
                new ObjectParameter("PurchaseItem", purchaseItem) :
                new ObjectParameter("PurchaseItem", typeof(string));
    
            var purchaseDateParameter = purchaseDate != null ?
                new ObjectParameter("PurchaseDate", purchaseDate) :
                new ObjectParameter("PurchaseDate", typeof(string));
    
            var totalAmountParameter = totalAmount != null ?
                new ObjectParameter("TotalAmount", totalAmount) :
                new ObjectParameter("TotalAmount", typeof(string));
    
            var paidAmountParameter = paidAmount != null ?
                new ObjectParameter("PaidAmount", paidAmount) :
                new ObjectParameter("PaidAmount", typeof(string));
    
            var balanceParameter = balance != null ?
                new ObjectParameter("Balance", balance) :
                new ObjectParameter("Balance", typeof(string));
    
            var dueDateParameter = dueDate != null ?
                new ObjectParameter("DueDate", dueDate) :
                new ObjectParameter("DueDate", typeof(string));
    
            var remainderMessageParameter = remainderMessage != null ?
                new ObjectParameter("RemainderMessage", remainderMessage) :
                new ObjectParameter("RemainderMessage", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ProcedureToUpdateCustomerDetail", customerIDParameter, firstNameParameter, lastNameParameter, mobileNumberParameter, emailIDParameter, cityParameter, customerAddressParameter, purchaseItemParameter, purchaseDateParameter, totalAmountParameter, paidAmountParameter, balanceParameter, dueDateParameter, remainderMessageParameter);
        }
    
        public virtual int ProcedureToUpdateStockDetail(Nullable<int> stockID, string wholeSellPrice, string sellingPrice, string numberOfCount, string weight, string itemName)
        {
            var stockIDParameter = stockID.HasValue ?
                new ObjectParameter("StockID", stockID) :
                new ObjectParameter("StockID", typeof(int));
    
            var wholeSellPriceParameter = wholeSellPrice != null ?
                new ObjectParameter("WholeSellPrice", wholeSellPrice) :
                new ObjectParameter("WholeSellPrice", typeof(string));
    
            var sellingPriceParameter = sellingPrice != null ?
                new ObjectParameter("SellingPrice", sellingPrice) :
                new ObjectParameter("SellingPrice", typeof(string));
    
            var numberOfCountParameter = numberOfCount != null ?
                new ObjectParameter("NumberOfCount", numberOfCount) :
                new ObjectParameter("NumberOfCount", typeof(string));
    
            var weightParameter = weight != null ?
                new ObjectParameter("Weight", weight) :
                new ObjectParameter("Weight", typeof(string));
    
            var itemNameParameter = itemName != null ?
                new ObjectParameter("ItemName", itemName) :
                new ObjectParameter("ItemName", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ProcedureToUpdateStockDetail", stockIDParameter, wholeSellPriceParameter, sellingPriceParameter, numberOfCountParameter, weightParameter, itemNameParameter);
        }
    
        public virtual int ProcedureToUpdateWholeSellerDetails(Nullable<int> shopID, string shopName, string ownerName, string shopAddres, string registrationNumber, string mobileNumber)
        {
            var shopIDParameter = shopID.HasValue ?
                new ObjectParameter("ShopID", shopID) :
                new ObjectParameter("ShopID", typeof(int));
    
            var shopNameParameter = shopName != null ?
                new ObjectParameter("ShopName", shopName) :
                new ObjectParameter("ShopName", typeof(string));
    
            var ownerNameParameter = ownerName != null ?
                new ObjectParameter("OwnerName", ownerName) :
                new ObjectParameter("OwnerName", typeof(string));
    
            var shopAddresParameter = shopAddres != null ?
                new ObjectParameter("ShopAddres", shopAddres) :
                new ObjectParameter("ShopAddres", typeof(string));
    
            var registrationNumberParameter = registrationNumber != null ?
                new ObjectParameter("RegistrationNumber", registrationNumber) :
                new ObjectParameter("RegistrationNumber", typeof(string));
    
            var mobileNumberParameter = mobileNumber != null ?
                new ObjectParameter("MobileNumber", mobileNumber) :
                new ObjectParameter("MobileNumber", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ProcedureToUpdateWholeSellerDetails", shopIDParameter, shopNameParameter, ownerNameParameter, shopAddresParameter, registrationNumberParameter, mobileNumberParameter);
        }
    }
}