# Introduction
    Imagine you're an employee of a product retailer named FStore. Your manager
    has asked you to develop a Windows Forms application for member management:
    MemberID, MemberName, Email, Password, City, Country. The application has
    a default account whose email is “admin@fstore.com” and password is
    “admin@@” that stored in the appsettings.json.
    
    The application has to support adding, viewing, modifying, and removing
    products—a standardized usage action verbs better known as Create, Read,
    Update, Delete (CRUD). This assignment explores creating an application using
    Windows Forms with .NET Core, and C#. An "in-memory database" will be created
    to persist the member's data, so a collection is called List will be used for reading
    and managing data.

# Assignment Objectives
    In this assignment, you will:
    ▪ Use the Visual Studio.NET to create Windows Forms and Class Library (.dll)
    project.
    2 | P a g e
    ▪ Create a List of persisting members
    ▪ Using LinQ to Object to query data
    ▪ Apply passing data in WinForms application
    ▪ Apply 3-layers architecture to develop an application
    ▪ Apply MPV (Model-Presenter-View) pattern in Winforms application
    ▪ Apply Repository pattern and Singleton pattern in a project
    ▪ Add CRUD and searching actions to WinForms application.
    ▪ Apply to validate data type for all fields
    ▪ Run the project and test the WinForms actions.
    
# Main Functions
        ▪ Member management: Read, Create, Update and Delete actions. Creating
        and Updating member must be performed by popup dialog
        ▪ Search member by ID and Name
        ▪ Filter members by City and Country
        ▪ Sort member list descending order by MemberName
        ▪ Member authentication by Email and Password. If the user is “Admin” then
        allows to perform all actions, otherwise, the normal user allowed to view and
        update their pieces of information

