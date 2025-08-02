using System.ComponentModel.DataAnnotations;

namespace StudentMVCPractice.Models;

/// <summary>
/// Reperesents a student at a school.
/// </summary>
public class Student
{
    /// <summary>
    /// A unique identifier for the student (primary key).
    /// </summary>
    public int StudentId { get; set; }

    /// <summary>
    /// The first name of the student.
    /// </summary>
    public required string FirstName { get; set; }

    /// <summary>
    /// The last name of the student.
    /// </summary>
    public required string LastName { get; set; }

    /// <summary>
    /// The name the student prefers to be called. This should
    /// be optional to fill out and can be left empty, however,
    /// I couldn't figure out how to do this so an issue has been 
    /// created in GitHub to fix this later.
    /// </summary>
    public required string PreferredName { get; set; } = string.Empty;

    /// <summary>
    /// The student's date of birth.
    /// </summary>
    public required DateOnly DateOfBirth { get; set; }


}
