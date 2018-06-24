using System;
using System.Text.RegularExpressions;

public static class Bob
{
    public static string Response(string statement)
    {
        if(string.IsNullOrWhiteSpace(statement))
        {
            return "Fine. Be that way!";
        }
        string str = statement.TrimEnd();
        string characters = str.Substring(0, str.Length - 1);
        string last =  str.Substring(str.Length - 1);
        bool hasLetter = Regex.IsMatch(characters, "[A-Z]");
        if(characters.ToUpper() == characters && last == "?" && hasLetter == true){
          return "Calm down, I know what I'm doing!";
        }
        else if(last == "?")
        {
            return "Sure.";
        }
        else if(characters.ToUpper() == characters && hasLetter == true)
        {
            return "Whoa, chill out!";
        }

        return "Whatever.";
    }
}