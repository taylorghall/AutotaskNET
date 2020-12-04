﻿using System;

namespace AutotaskNET.Entities
{
    /// <summary>
    /// The AllocationCode entity describes an Autotask Allocation Code. An allocation code represents a billing item category.<br />
    /// There are six types of allocation codes: Work Types, Material, Internal Time, Expense Categories, Recurring Contract Service, and Milestone.<br />
    /// Administrators add and manage allocation codes through the Admin module(Admin >Site Setup > Billing Codes).
    /// </summary>
    /// <seealso cref="AutotaskNET.Entities.Entity" />
    public class AllocationCode : Entity
    {
        #region Properties

        public override bool CanCreate => false;
        public override bool CanUpdate => false;
        public override bool CanQuery => true;
        public override bool CanDelete => false;
        public override bool CanHaveUDFs => false;

        #endregion //Properties

        #region Constructors

        public AllocationCode() : base() { } //end AllocationCode()
        public AllocationCode(ATWS.AllocationCode entity) : base(entity)
        {

        } //end AllocationCode(ATWS.AllocationCode entity)

        public static implicit operator ATWS.AllocationCode(AllocationCode allocationcode)
        {
            return new ATWS.AllocationCode()
            {
                id = allocationcode.id,

            };

        } //end implicit operator ATWS.AllocationCode(AllocationCode allocationcode)

        #endregion //Constructors

        #region Fields

        #region ReadOnly Fields

        public double MarkupRate; //ReadOnly

        #endregion //ReadOnly Fields

        #region Required Fields

        public bool Active; //Required
        public double UnitCost; //Required
        public double UnitPrice; //Required

        #endregion //Required Fields

        #region Optional Fields

        public int? GeneralLedgerCode; //PickList
        public int? Department;
        public string Name; //Length:200
        public string ExternalNumber; //Length:100
        public int? Type; //PickList
        public int? UseType; //PickList
        public string Description; //Length:500
        public int? AllocationCodeType; //PickList
        public bool? Taxable;
        public int? TaxCategoryID; //[TaxCategory]
        public bool? IsExcludedFromNewContracts;

        #endregion //Optional Fields

        #endregion //Fields

    } //end AllocationCode

}
