namespace QuizApp.Models;

public enum QuestionType
{
    SingleChoice,
    MultipleChoice,
    Text
}

public class QuizQuestion
{
    public int Id { get; set; }
    public string Title { get; set; } = "";
    public string Prompt { get; set; } = "";
    public QuestionType Type { get; set; }
    public int Points { get; set; }

    public List<QuizOption> Options { get; set; } = new();
    public List<string> AcceptedAnswers { get; set; } = new();

    public List<string> Keywords { get; set; } = new();
    public int RequiredKeywordMatches { get; set; } = 1;
}

public class QuizOption
{
    public string Text { get; set; } = "";
    public bool IsCorrect { get; set; }
}