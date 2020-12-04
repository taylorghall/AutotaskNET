using System;

namespace AutotaskNET.Entities
{
    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="AutotaskNET.Entities.Entity" />
    public class ServiceCallTaskResource : Entity
    {
        #region Properties

        public override bool CanCreate => true;
        public override bool CanUpdate => false;
        public override bool CanQuery => true;
        public override bool CanDelete => true;
        public override bool CanHaveUDFs => false;

        #endregion //Properties

        #region Constructors

        public ServiceCallTaskResource() : base() { } //end ServiceCallTaskResource()
        public ServiceCallTaskResource(ATWS.ServiceCallTaskResource entity) : base(entity)
        {
            this.ResourceID = int.Parse(entity.ResourceID.ToString());
            this.ServiceCallTaskID = int.Parse(entity.ServiceCallTaskID.ToString());

        } //end ServiceCallTaskResource(ATWS.ServiceCallTaskResource entity)

        public static implicit operator ATWS.ServiceCallTaskResource(ServiceCallTaskResource servicecalltaskresource)
        {
            return new ATWS.ServiceCallTaskResource()
            {
                id = servicecalltaskresource.id,

            };

        } //end implicit operator ATWS.ServiceCallTaskResource(ServiceCallTaskResource servicecalltaskresource)

        #endregion //Constructors

        #region Fields

        #region Required Fields

        public int ServiceCallTaskID; //Required [ServiceCallTask]
        public int ResourceID; //Required [Resource]

        #endregion //Required Fields

        #endregion //Fields

    } //end ServiceCallTaskResource

}
