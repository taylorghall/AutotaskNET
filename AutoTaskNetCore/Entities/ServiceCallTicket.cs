﻿using System;

namespace AutotaskNET.Entities
{
    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="AutotaskNET.Entities.Entity" />
    public class ServiceCallTicket : Entity
    {
        #region Properties

        public override bool CanCreate => true;
        public override bool CanUpdate => false;
        public override bool CanQuery => true;
        public override bool CanDelete => true;
        public override bool CanHaveUDFs => false;

        #endregion //Properties

        #region Constructors

        public ServiceCallTicket() : base() { } //end ServiceCallTicket()
        public ServiceCallTicket(ATWS.ServiceCallTicket entity) : base(entity)
        {
            this.ServiceCallID = int.Parse(entity.ServiceCallID.ToString());
            this.TicketID = int.Parse(entity.TicketID.ToString());

        } //end ServiceCallTicket(ATWS.ServiceCallTicket entity)

        public static implicit operator ATWS.ServiceCallTicket(ServiceCallTicket servicecallticket)
        {
            return new ATWS.ServiceCallTicket()
            {
                id = servicecallticket.id,

            };

        } //end implicit operator ATWS.ServiceCallTicket(ServiceCallTicket servicecallticket)

        #endregion //Constructors

        #region Fields

        #region Required Fields

        public int ServiceCallID; //Required [ServiceCall]
        public int TicketID; //Required [Ticket]

        #endregion //Required Fields

        #endregion //Fields

    } //end ServiceCallTicket

}
