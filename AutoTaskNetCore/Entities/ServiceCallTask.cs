using System;

namespace AutotaskNET.Entities
{
    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="AutotaskNET.Entities.Entity" />
    public class ServiceCallTask : Entity
    {
        #region Properties

        public override bool CanCreate => true;
        public override bool CanUpdate => false;
        public override bool CanQuery => true;
        public override bool CanDelete => true;
        public override bool CanHaveUDFs => false;

        #endregion //Properties

        #region Constructors

        public ServiceCallTask() : base() { } //end ServiceCallTask()
        public ServiceCallTask(ATWS.ServiceCallTask entity) : base(entity)
        {
            this.ServiceCallID = int.Parse(entity.ServiceCallID.ToString());
            this.TaskID = int.Parse(entity.TaskID.ToString());

        } //end ServiceCallTask(ATWS.ServiceCallTask entity)

        public static implicit operator ATWS.ServiceCallTask(ServiceCallTask servicecalltask)
        {
            return new ATWS.ServiceCallTask()
            {
                id = servicecalltask.id,

            };

        } //end implicit operator ATWS.ServiceCallTask(ServiceCallTask servicecalltask)

        #endregion //Constructors

        #region Fields

        #region Required Fields

        public int ServiceCallID; //Required [ServiceCall]
        public int TaskID; //Required [Task]

        #endregion //Required Fields

        #endregion //Fields

    } //end ServiceCallTask

}
