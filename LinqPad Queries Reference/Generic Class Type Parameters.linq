<Query Kind="Program">
  <Namespace>static UserQuery</Namespace>
</Query>

//Generic Class Type Arguments (constructor requirements)
void Main()
{
	var name = new Name();
	var skill = new Skill();

	var brian = new Brian<Name, Skill>(name, skill);

	Console.WriteLine($"{brian.BrianName.FName} has this skill: {brian.BrianSkill.SkillName}");
	brian.DisplayBriansStats();
}

//Generic Class Type Arguments (constructor requirements)
public class Brian<Name, Skill>
{
	public Name BrianName { get; }
	public Skill BrianSkill { get; }

	public Brian(Name brianName, Skill brianSkill)
	{
		BrianName = brianName;
		BrianSkill = brianSkill;
	}
	
	public void DisplayBriansStats(){
		Console.WriteLine($"{BrianName.FName} has this skill: {BrianSkill.SkillName}");
	}
}

public class Name
{
	public string FName {get;} = "Brian";
	public string LName {get;} = "Lee";
}

public class Skill
{
	public string SkillName {get;} = "KungFu";
}




