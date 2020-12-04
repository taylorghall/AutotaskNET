using System;

namespace AutotaskNET.Entities
{
    /// <summary>
    /// This entity describes Price List information associated with a ServiceBundle entity.<br />
    /// <br />
    /// Price List information for Products, Services, Materials, and Labor(Work Types and Roles) is set up and managed in Autotask on the Price List page: from the Autotask menu select Admin > Features & Settings > Finance, Accounting, & Invoicing > Price List.
    /// </summary>
    /// <seealso cref="AutotaskNET.Entities.Entity" />
    public class PriceListServiceBundle : Entity
    {
        #region Properties

        public override bool CanCreate => false;
        public override bool CanUpdate => true;
        public override bool CanQuery => true;
        public override bool CanDelete => false;
        public override bool CanHaveUDFs => false;

        #endregion //Properties

        #region Constructors

        public PriceListServiceBundle() : base() { } //end PriceListServiceBundle()
        public PriceListServiceBundle(ATWS.PriceListServiceBundle entity) : base(entity)
        {

        } //end PriceListServiceBundle(ATWS.PriceListServiceBundle entity)

        public static implicit operator ATWS.PriceListServiceBundle(PriceListServiceBundle pricelistservicebundle)
        {
            return new ATWS.PriceListServiceBundle()
            {
                id = pricelistservicebundle.id,

            };

        } //end implicit operator ATWS.PriceListServiceBundle(PriceListServiceBundle pricelistservicebundle)

        #endregion //Constructors

        #region Fields

        #region ReadOnly Required Fields

        public int ServiceBundleID; //ReadOnly Required [ServiceBundle]
        public int CurrencyID; //ReadOnly Required [Currency]

        #endregion //ReadOnly Required Fields

        #region Required Fields

        public bool UsesInternalCurrencyPrice; //Required

        #endregion //Required Fields

        #region Optional Fields

        public decimal UnitPrice;

        #endregion //Optional Fields

        #endregion //Fields

    } //end PriceListServiceBundle

}
