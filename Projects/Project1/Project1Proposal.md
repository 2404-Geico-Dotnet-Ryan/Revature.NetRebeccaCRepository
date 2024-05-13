Create an Application to manage tickets

Ticket 
        - should have an ID number to call 
        Requestor
        Date/Time Requested 
        Location of Requestor
        Job Title of Requestor
        Urgency 
        Problem
        Assigned To (user id)
        Where at in process 

People using system 
    Requestors
    Administrators 
    Example 
            User Class 
                -id to identify the user
                -username
                -userpassword
                -(pull access level from this) 
                

Methods
    Open Ticket
    Close Ticket
    Note Ticket
    Update Ticket
    View Ticket with Status
    -Service Layer Make a method: GetAllUserTickets(int userID)
    



    My project needs to have 1-to-many relationship (or should it be many to many relationship- try to avoid this- this is very complex) where (need to be able to call up tickets owned by each user)