namespace DevHabits.Api.Entities;

public class Habit
{
    public string Id { get; init; }
    public string Name { get; init; } = string.Empty;
    public string? Description { get; init; }
    public HabitType Type { get; init; }
    public Frequency Frequency { get; init; }
    public Target Target { get; init; }
    public HabitStatus Status { get; init; }
    public bool IsArchived { get; init; }
    public DateOnly? EndDate { get; init; }
    public Milestone? Milestone { get; init; }
    public DateTime CreatedOnUtc { get; init; }
    public DateTime? UpdatedOnUtc { get; init; }
    public DateTime? LastCompletedOnUtc { get; init; }
}

public enum HabitType
{
    None = 0,
    Binary = 1,
    Measurable = 2,
}

public class Frequency
{
    public FrequencyType Type { get; set; }
    public int TimesPerPeriod { get; set; }
}

public enum FrequencyType
{
    None = 0,
    Daily = 1,
    Weekly = 2,
    Monthly = 3,
}

public class Target
{
    public int Value { get; init; }
    public string Unit { get; init; } = string.Empty;
}

public enum HabitStatus
{
    None = 0,
    Ongoing = 1,
    Completed = 2,
}

public class Milestone
{
    public int Target { get; set; }
    public int Current { get; set; }
}
