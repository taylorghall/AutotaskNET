using System;

namespace AutotaskNET.Entities
{
    /// <summary>
    /// This entity describes an Autotask project Phase.<br />
    /// Phases allow users to break projects into sub-groups of project tasks.<br />
    /// They can be a sub-phase to a Parent phase.Users manage phases through the Project's Schedule view in the Projects module.
    /// </summary>
    /// <seealso cref="AutotaskNET.Entities.Entity" />
    public class Phase : Entity
    {
        #region Properties

        public override bool CanCreate => true;
        public override bool CanUpdate => true;
        public override bool CanQuery => true;
        public override bool CanDelete => false;
        public override bool CanHaveUDFs => false;

        #endregion //Properties

        #region Constructors

        public Phase() : base() { } //end Phase()
        public Phase(ATWS.Phase entity) : base(entity)
        {

        } //end Phase(ATWS.Phase entity)

        public static implicit operator ATWS.Phase(Phase phase)
        {
            return new ATWS.Phase()
            {
                id = phase.id,

            };

        } //end implicit operator ATWS.Phase(Phase phase)

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

        public DateTime? CreateDate; //ReadOnly
        public int? CreatorResourceID; //ReadOnly [Resource]
        public string Description; //Length:8000
        public DateTime? DueDate;
        public float EstimatedHours; //ReadOnly
        public string ExternalID; //Length:50
        public DateTime? LastActivityDateTime; //ReadOnly
        public int? ParentPhaseID; //[Phase]
        public string PhaseNumber; //ReadOnly Length:50
        public int ProjectID; //ReadOnly Required [Project]
        public bool? Scheduled; //ReadOnly
        public DateTime? StartDate;
        public string Title; //Required Length:255

    } //end Phase

}
