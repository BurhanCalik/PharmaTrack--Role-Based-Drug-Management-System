# PharmaTrack  

PharmaTrack is a role-based ASP.NET web application designed to streamline drug inventory management. This project enables the registration, updating, and role-specific access to drug records, providing a secure and efficient solution for pharmaceutical inventory management.  

## Features  

- **Role-Based Authorization**  
  - **Data Viewer**: Can only view the list of products.  
  - **Data Entry**: Can view products and add new products.  
  - **Admin**: Can view, add, update, and delete products.  

- **Authentication & Authorization**  
  - Secure login system implemented using Forms Authentication.  
  - Manual user registration system.  

- **Functional Pages**  
  1. **Login Page**: Allows users to log into the system securely.  
  2. **Product List Page**: Displays a list of products and supports filtering by product name.  
  3. **Product Add Page**: Features a user-friendly interface for adding new products.  
  4. **Product Update Page**: Allows editing of product details and deletion of products.  

## Technologies Used  

- **ASP.NET MVC**: For building the user interface and application logic.  
- **MSSQL**: For database management.  
- **Entity Framework**: For data access and interaction with the database.  
- **Forms Authentication**: For user authentication and authorization.  
- **4-Layered Architecture**:  
  - **Entity Layer**: Defines database entities.  
  - **Data Access Layer**: Handles CRUD operations with the database.  
  - **Business Layer**: Manages application logic.  
  - **UI Layer**: Provides the user interface and interactions.  

## Users Role  

The system incorporates a role-based access model with three distinct roles:  

- **Data Viewer**:  
  - **Access**: Can only access the **Product List Page**.  
  - **Permissions**:  
    - View the list of products.  
    - Filter products by name.  

- **Data Entry**:  
  - **Access**: Can access both the **Product List Page** and the **Product Add Page**.  
  - **Permissions**:  
    - View the list of products.  
    - Filter products by name.  
    - Add new products to the database through a user-friendly interface.  

- **Admin**:  
  - **Access**: Can access the **Product List Page**, **Product Add Page**, and the **Product Update Page**.  
  - **Permissions**:  
    - Full CRUD (Create, Read, Update, Delete) capabilities:  
      - View and filter products.  
      - Add new products.  
      - Update existing product details.  
      - Delete products from the database.  
