using System;

namespace AutotaskNET.Entities
{
    /// <summary>
    /// When the Organizational Structure feature is enabled in Autotask, this entity describes an Autotask Resource association with an organizational structure pairing of BusinessDivision and BusinessSubdivision(BusinessDivisionSubdivision entity).
    /// </summary>
    /// <seealso cref="AutotaskNET.Entities.Entity" />
    public class BusinessDivisionSubdivisionResource : Entity
    {
        #region Properties

        public override bool CanCreate => false;
        public override bool CanUpdate => false;
        public override bool CanQuery => true;
        public override bool CanDelete => false;
        public override bool CanHaveUDFs => false;

        #endregion //Properties

        #region Constructors

        public BusinessDivisionSubdivisionResource() : base() { } //end BusinessDivisionSubdivisionResource()
        public BusinessDivisionSubdivisionResource(ATWS.BusinessDivisionSubdivisionResource entity) : base(entity)
        {

        } //end BusinessDivisionSubdivisionResource(ATWS.BusinessDivisionSubdivisionResource entity)

        public static implicit operator ATWS.BusinessDivisionSubdivisionResource(BusinessDivisionSubdivisionResource businessdivisionsubdivisionresource)
        {
            return new ATWS.BusinessDivisionSubdivisionResource()
            {
                id = businessdivisionsubdivisionresource.id,

            };

        } //end implicit operator ATWS.BusinessDivisionSubdivisionResource(BusinessDivisionSubdivisionResource businessdivisionsubdivisionresource)

        #endregion //Constructors

        #region Fields

        #region ReadOnly Required Fields

        public int BusinessDivisionSubdivisionID; //ReadOnly Required [BusinessDivisionSubdivision]
        public int ResourceID; //ReadOnly Required [Resource]

        #endregion //ReadOnly Required Fields

        #endregion //Fields

    } //end BusinessDivisionSubdivisionResource

}
