using CS50.Harvard.Lessons.Lesson2.Models;
using System.Text;

namespace CS50.Harvard.Lessons.Lesson2.BusinessLogic;

public class MessageBuilder
{
    public static string GetMessage(Pyramid pyramid)
    {
        var message = new StringBuilder();
        var height = pyramid.GetHeight();

        for (var i = 1; i <= height; i++)
        {
            message.Append(' ', height - i);
            message.Append('#', i);
            message.Append(' ');
            message.Append('#', i);
            message.AppendLine();
        }

        return message.ToString();
    }
}