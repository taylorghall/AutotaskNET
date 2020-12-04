using System;

namespace AutotaskNET.Entities
{
    /// <summary>
    /// This entity describes a Resource - Queue relationship.
    /// </summary>
    /// <seealso cref="AutotaskNET.Entities.Entity" />
    public class ResourceRoleQueue : Entity
    {
        #region Properties

        public override bool CanCreate => true;
        public override bool CanUpdate => true;
        public override bool CanQuery => true;
        public override bool CanDelete => false;
        public override bool CanHaveUDFs => false;

        #endregion //Properties

        #region Constructors

        public ResourceRoleQueue() : base() { } //end ResourceRoleQueue()
        public ResourceRoleQueue(ATWS.ResourceRoleQueue entity) : base(entity)
        {

        } //end ResourceRoleQueue(ATWS.ResourceRoleQueue entity)

        public static implicit operator ATWS.ResourceRoleQueue(ResourceRoleQueue resourcerolequeue)
        {
            return new ATWS.ResourceRoleQueue()
            {
                id = resourcerolequeue.id,

            };

        } //end implicit operator ATWS.ResourceRoleQueue(ResourceRoleQueue resourcerolequeue)

        #endregion //Constructors

        #region Fields

        #region ReadOnly Required Fields

        public int ResourceID; //ReadOnly Required [Resource]

        #endregion //ReadOnly Required Fields

        #region Required Fields

        public int QueueID; //Required PickList

        #endregion //Required Fields

        #region Obsolete Fields

        public bool? Active; //ReadOnly (Obsolete)
        public bool? Default; //ReadOnly (Obsolete)
        public int? RoleID; //ReadOnly [Role] (Obsolete)

        #endregion //Obsolete Fields

        #endregion //Fields

    } //end ResourceRoleQueue

}
