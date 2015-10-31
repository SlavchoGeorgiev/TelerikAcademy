using System;

public class ExamResult
{
    public ExamResult(int grade, int minGrade, int maxGrade, string comments)
    {
        if (grade < 0)
        {
            throw new ArgumentOutOfRangeException("Grade must be positive or zero");
        }

        if (minGrade < 0)
        {
            throw new ArgumentOutOfRangeException("Minimal grade must be positive or zero");
        }

        if (maxGrade <= minGrade)
        {
            throw new ArgumentException("Maximal grade must be greater than minimal grade.");
        }

        if (string.IsNullOrEmpty(comments))
        {
            throw new ArgumentException("Comments must be non empty string.");
        }

        this.Grade = grade;
        this.MinGrade = minGrade;
        this.MaxGrade = maxGrade;
        this.Comments = comments;
    }


    public int Grade { get; private set; }

    public int MinGrade { get; private set; }

    public int MaxGrade { get; private set; }

    public string Comments { get; private set; }
}
