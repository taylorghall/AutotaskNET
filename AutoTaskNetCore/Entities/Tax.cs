﻿using System;

namespace AutotaskNET.Entities
{
    /// <summary>
    /// The Tax entity describes the tax rate charged to a customer for specific goods or services purchased in a specified geographic area.<br />
    /// The goods and services are represented by a TaxCategory.<br />
    /// The geographic area is represented by the a TaxRegion.<br />
    /// There can be multiple TaxCategories per TaxRegion.
    /// </summary>
    /// <seealso cref="AutotaskNET.Entities.Entity" />
    public class Tax : Entity
    {
        #region Properties

        public override bool CanCreate => true;
        public override bool CanUpdate => true;
        public override bool CanQuery => true;
        public override bool CanDelete => false;
        public override bool CanHaveUDFs => false;

        #endregion //Properties

        #region Constructors

        public Tax() : base() { } //end Tax()
        public Tax(ATWS.Tax entity) : base(entity)
        {

        } //end Tax(ATWS.Tax entity)

        public static implicit operator ATWS.Tax(Tax tax)
        {
            return new ATWS.Tax()
            {
                id = tax.id,

            };

        } //end implicit operator ATWS.Tax(Tax tax)

        #endregion //Constructors

        #region Fields

        #region ReadOnly Required Fields

        public int TaxRegionID; //ReadOnly Required [TaxRegion]
        public int TaxCategoryID; //ReadOnly Required [TaxCategory]

        #endregion //ReadOnly Required Fields

        #region Required Fields

        public string TaxName; //Required Length:100
        public double TaxRate; //Required

        #endregion //Required Fields

        #region Optional Fields

        public bool? IsCompounded;

        #endregion //Optional Fields

        #endregion //Fields

    } //end Tax

}
