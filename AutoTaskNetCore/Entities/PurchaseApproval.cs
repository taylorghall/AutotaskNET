using System;

/*
 * NEEDS TO BE REVIEWED
 */

namespace AutotaskNET.Entities
{
    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="AutotaskNET.Entities.Entity" />
    public class PurchaseApproval : Entity
    {
        #region Properties

        public override bool CanCreate => false;
        public override bool CanUpdate => true;
        public override bool CanQuery => true;
        public override bool CanDelete => false;
        public override bool CanHaveUDFs => false;

        #endregion //Properties

        #region Constructors

        public PurchaseApproval() : base() { } //end PurchaseApproval()
        public PurchaseApproval(ATWS.PurchaseApproval entity) : base(entity)
        {

        } //end Account(ATWS.Account entity)

        public static implicit operator ATWS.PurchaseApproval(PurchaseApproval purchaseapproval)
        {
            return new ATWS.PurchaseApproval()
            {
                id = purchaseapproval.id,

            };

        } //end implicit operator ATWS.PurchaseApproval(PurchaseApproval purchaseapproval)

        #endregion //Constructors

        #region Fields

        #region ReadOnly Fields



        #endregion //ReadOnly Fields

        #region ReadOnly Required Fields



        #endregion //ReadOnly Required Fields

        #region Required Fields



        #endregion //Required Fields

        #region Optional Fields



        #endregion //Optional Fields

        #endregion //Fields

    } //end PurchaseApproval

}
