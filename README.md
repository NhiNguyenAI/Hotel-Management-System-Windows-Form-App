# Hotel Management System

A desktop application for managing hotel operations, built using **.NET 6** and **Windows Forms App**. This system provides an easy-to-use interface for handling bookings, guest management, room availability, billing, and reports.

---

## Features

- **User Authentication**: Secure login system with user roles.
- **Guest Management**: Add, update, and delete guest information.
- **Room Management**: View room availability, categories, and pricing.
- **Booking System**: Manage reservations and bookings efficiently.
- **Billing and Invoicing**: Generate and print bills for guests.
- **Reports**: Generate reports for revenue, room occupancy, and guest data.
- **Modern UI**: A clean and intuitive Windows Forms interface.

---

## Technologies Used

- **.NET 6**: Provides a high-performance, cross-platform framework for application development.
- **Windows Forms**: UI framework for desktop applications.
- **SQL Server**: Relational database for storing and managing data.
- **Microsoft.Data.SqlClient**: Library for database connectivity.

---

## Prerequisites

- **Windows OS**: Required for running Windows Forms applications.
- **.NET 6 SDK**: [Download here](https://dotnet.microsoft.com/download/dotnet/6.0).
- **SQL Server**: Ensure SQL Server is installed and running.
- **Visual Studio 2022 or later**: For development and debugging.

---

## Installation

1. **Clone the Repository**:
   ```bash
   git clone https://github.com/yourusername/HotelManagementSystem.git
   ```

2. **Open the Project**:
   - Open the solution file `HotelManagementSystem.sln` in Visual Studio.

3. **Set Up the Database**:
   - Create a database in SQL Server named `Hotel_Management_System`.
   - Run the SQL scripts provided in the `Database` folder to set up the schema and initial data.

4. **Update the Connection String**:
   - Navigate to the `App.config` file in the project.
   - Update the connection string to match your SQL Server instance:
     ```xml
     <connectionStrings>
         <add name="HotelManagementDB" connectionString="Server=localhost;Database=Hotel_Management_System;Trusted_Connection=True;" providerName="System.Data.SqlClient" />
     </connectionStrings>
     ```

5. **Build and Run**:
   - Press `F5` in Visual Studio to build and launch the application.

---

## Usage

1. **Login**:
   - Use your username and password to access the system.
2. **Manage Guests**:
   - Navigate to the guest management section to add or update guest details.
3. **Manage Rooms**:
   - View room availability and categories.
4. **Book Rooms**:
   - Create new reservations for guests.
5. **Generate Bills**:
   - Process payments and generate invoices.
6. **View Reports**:
   - Analyze performance with reports on bookings, revenue, and guests.

---


