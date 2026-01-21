# AIUB Lost & Found System

A Windows-based application developed using **C# (WinForms)** and **MS SQL Server** to manage lost and found items within the AIUB campus. The system provides secure access, smart matching, advanced search, and proper record management for administrators and staff.

---

## 📌 Project Overview

Losing personal belongings such as mobile phones, ID cards, books, or bags is common in university environments. Traditional lost and found systems rely on manual processes, which are slow, inefficient, and unreliable. The **AIUB Lost & Found System** digitizes this entire process by providing a centralized, searchable, and intelligent platform.

This system allows users to submit lost and found reports, search for items, and receive possible match suggestions. Administrators can manage users, verify matches, and view match history. The application improves transparency, accuracy, and the chances of recovering lost items.

---

## 🚀 Key Features

1. Secure login with role-based access (Admin, Staff)
2. Lost and found report creation, editing, and deletion
3. Smart possible match suggestion system
4. Manual match confirmation for accuracy
5. Status tracking (Pending / Matched)
6. Advanced multi-field search and filtering
7. Match history management
8. Admin dashboard with full system control
9. Clean and user-friendly Windows interface
10. Secure database storage using MS SQL Server

---

## 🛠️ Technology Stack

* **Programming Language:** C#
* **Framework:** .NET (Windows Forms)
* **Database:** Microsoft SQL Server
* **IDE:** Visual Studio
* **Architecture:** Layered (UI + Data Access)

---

## 🧑‍💻 User Roles

### Admin

* Manage users
* View all reports
* Confirm matches
* View match history
* Monitor system activities

### Staff

* Create lost/found reports
* Edit reports
* Delete reports
* Search reports
* View possible matches

---

## 🗂️ Database Structure

## ER Diagram Link: https://excalidraw.com/#json=AqaJsTaUPB3mGtdSzzDTk,JtzU_eVDK7BxdkxPNCibhQ

### Users

* UserID (PK)
* FullName
* Email
* Password
* Role
* Gender

### Reports

* ReportID (PK)
* ReportType (Lost / Found)
* ReporterName
* ReporterStudentID
* ReporterPhone
* ItemName
* ItemCategory
* Brand
* Color
* UniqueMark
* Location
* Status (Pending / Matched)
* AddedBy (FK)

### MatchHistories

* MatchID (PK)
* LostReportID (FK)
* FoundReportID (FK)
* MatchScore
* MatchDate
* ConfirmedBy (FK)

---

## ⚙️ Installation Guide

### Requirements

* Windows OS
* Visual Studio
* SQL Server Management Studio (SSMS)
* .NET Framework

### Steps

1. Clone or download the project
2. Open the project in Visual Studio
3. Restore NuGet packages (if required)
4. Create a database named: `AIUB_LOST_FOUND`
5. Run the SQL scripts to create tables
6. Update connection string in `DBConnect.cs`
7. Build and run the project

---

## 🔍 Search & Filtering System

Users can filter reports using:

* Reporter Name
* Student ID
* Phone Number
* Item Category

Search results update automatically as the user types.

---

## 🤖 Smart Matching Logic

The system compares lost and found reports based on:

* Item category
* Brand
* Color
* Unique marks
* Item name similarity

Each match is given a score, and users manually confirm the best match.

---

## 📊 Match History

All confirmed matches are stored permanently in the database. Admins can view:

* Lost item
* Found item
* Match score
* Confirmation date
* Confirmed by

---

## 🔐 Security Features

* Role-based access control
* Secure login system
* Controlled permissions
* SQL Server-based data storage

---

## 📁 Project Structure

* Forms (UI)
* DBConnect.cs (Database Layer)
* AdminDashboard
* ManageReportsForm
* AddEditReportForm
* MatchConfirmForm

---

## 🎯 Objectives

* Digitize lost and found management
* Reduce manual workload
* Improve search accuracy
* Ensure faster recovery of items
* Maintain transparency and records

---

## 🔮 Future Enhancements

* Mobile application support
* Image-based searching
* AI-powered matching
* QR code scanning
* SMS/Email notifications
* Public user portal

---

## 📄 License

This project is developed for academic purposes under AIUB guidelines.

---

## 🙌 Acknowledgement

Special thanks to our instructors and mentors for their guidance and support in developing this system.

---

## 📬 Contact

For any queries or suggestions, feel free to contact the project team.

---

**End of README**
