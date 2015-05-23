using System;

public class Door
{
    public string Question { get; set; }
    public string Answer { get; set; }
    public bool Unlocked { get; set; }

	public Door(string question, string answer, bool unlocked)
	{
        Question = question;
        Answer = answer;
        Unlocked = unlocked;
	}
}
