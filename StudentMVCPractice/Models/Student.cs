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
    [StringLength(50)]
    [Required(ErrorMessage = "Please provide student's first name.")]
    public required string FirstName { get; set; }

    /// <summary>
    /// The last name of the student.
    /// </summary>
    [StringLength(50)]
    [Required(ErrorMessage = "Please provide student's last name.")]
    public required string LastName { get; set; }

    /// <summary>
    /// The name the student prefers to be called. This should
    /// be optional to fill out and can be left empty, however,
    /// I couldn't figure out how to do this so an issue has been 
    /// created in GitHub to fix this later.
    /// </summary>
    [StringLength(50)]
    [Required(ErrorMessage = "Please provide student's preferred name.")]
    public required string PreferredName { get; set; } = string.Empty;

    /// <summary>
    /// The student's date of birth. Switched from DateOnly to DateTime
    /// because DateOnly does not show the convinient date picker for the user.
    /// </summary>   
    [DataType(DataType.Date)]
    public required DateTime DateOfBirth { get; set; }


}
