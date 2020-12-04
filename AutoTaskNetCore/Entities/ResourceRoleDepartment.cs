using System;

namespace AutotaskNET.Entities
{
    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="AutotaskNET.Entities.Entity" />
    public class ResourceRoleDepartment : Entity
    {
        #region Properties

        public override bool CanCreate => true;
        public override bool CanUpdate => true;
        public override bool CanQuery => true;
        public override bool CanDelete => false;
        public override bool CanHaveUDFs => false;

        #endregion //Properties

        #region Constructors

        public ResourceRoleDepartment() : base() { } //end ResourceRoleDepartment()
        public ResourceRoleDepartment(ATWS.ResourceRoleDepartment entity) : base(entity)
        {

        } //end ResourceRoleDepartment(ATWS.ResourceRoleDepartment entity)

        public static implicit operator ATWS.ResourceRoleDepartment(ResourceRoleDepartment resourceroledepartment)
        {
            return new ATWS.ResourceRoleDepartment()
            {
                id = resourceroledepartment.id,

            };

        } //end implicit operator ATWS.ResourceRoleDepartment(ResourceRoleDepartment resourceroledepartment)

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

        public int DepartmentID; //Required [Department]
        public int ResourceID; //ReadOnly Required [Resource]
        public int RoleID; //Required [Role]
        public bool Active; //Required
        public bool Default; //Required
        public bool DepartmentLead; //Required

    } //end ResourceRoleDepartment

}
