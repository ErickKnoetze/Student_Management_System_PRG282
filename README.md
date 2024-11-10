# **Student Management System**

This is a C# Windows Forms application designed to manage student records efficiently. The application uses a text file (`students.txt`) for storage and integrates Git and GitHub for version control. 

## **Features**
1. **Add New Student**
   - Input student details: `Student ID`, `Name`, `Age`, and `Course`.
   - Save details to a file (`students.txt`) with validation.
   
2. **View All Students**
   - Display all student records from the file in a `DataGridView`.
   - Refresh the view automatically after updates.

3. **Update Student Information**
   - Select a student from the `DataGridView`, edit details, and save back to the file.

4. **Delete a Student**
   - Delete selected student records with a confirmation prompt.

5. **Generate Summary Report**
   - Calculate and display:
     - Total number of students.
     - Average age of students.
   - Save the summary in a file (`summary.txt`).

6. **Version Control with Git**
   - The project includes Git integration for efficient version tracking and collaboration.

## **Technologies Used**
- **Programming Language**: C#  
- **Framework**: .NET Windows Forms  
- **Storage**: Plain text files (`students.txt`, `summary.txt`)  
- **Version Control**: Git & GitHub  

## **File Structure**
- `Form1.cs`: Handles the application logic and user interactions.  
- `Form1.Designer.cs`: Contains the design layout and UI elements.  
- `Program.cs`: Entry point of the application.  
- `DataHandler.cs`: Manages file operations such as adding, updating, and deleting records.  
- `Student.cs`: Defines the `Student` class for representing student data.  

## **Installation Instructions**
1. **Clone the Repository**
   ```bash
   git clone <repository-url>
   cd Student-Management-System
