using CS50.Harvard.Lessons.Lesson1.Models;

namespace CS50.Harvard.Lessons.Lesson1.BusinessLogic;

public class MessageBuilder
{
    public static string GetMessage(Person person)
    {
        return $"Hello, {person.GetName()}!";
    }
}