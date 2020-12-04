﻿using System;

namespace AutotaskNET.Entities
{
    /// <summary>
    /// This entity describes one or more account contacts assigned to a Ticket, other than the Ticket Contact (Ticket.ContactID).<br />
    /// Contacts must be associated with the ticket's Account (Ticket.AccountID).<br />
    /// A ticket can have additional contacts even if there is no Ticket Contact.
    /// </summary>
    /// <seealso cref="AutotaskNET.Entities.Entity" />
    public class TicketAdditionalContact : Entity
    {
        #region Properties

        public override bool CanCreate => true;
        public override bool CanUpdate => false;
        public override bool CanQuery => true;
        public override bool CanDelete => true;
        public override bool CanHaveUDFs => false;

        #endregion //Properties

        #region Constructors

        public TicketAdditionalContact() : base() { } //end TicketAdditionalContact()
        public TicketAdditionalContact(ATWS.TicketAdditionalContact entity) : base(entity)
        {

        } //end TicketAdditionalContact(ATWS.TicketAdditionalContact entity)

        public static implicit operator ATWS.TicketAdditionalContact(TicketAdditionalContact ticketadditionalcontact)
        {
            return new ATWS.TicketAdditionalContact()
            {
                id = ticketadditionalcontact.id,

            };

        } //end implicit operator ATWS.TicketAdditionalContact(TicketAdditionalContact ticketadditionalcontact)

        #endregion //Constructors

        #region Fields

        #region Required Fields

        public int TicketID; //Required [Ticket]
        public int ContactID; //Required [Contact]

        #endregion //Required Fields

        #endregion //Fields

    } //end TicketAdditionalContact

}
