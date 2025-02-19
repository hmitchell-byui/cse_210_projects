public class Levels
{
    private int _level;
    private int _experiencePoints;
    private int _xpForNextLevel;
    private double _pointMultiplier;

    public int Level => _level;
    public int ExperiencePoints => _experiencePoints;
    public int XPForNextLevel => _xpForNextLevel;
    public double PointMultiplier => _pointMultiplier;

    public Levels()
    {
        _level = 1;
        _experiencePoints = 0;
        _xpForNextLevel = 100; // XP required for the first level up
        _pointMultiplier = 1.0;
    }

    public void AddExperience(int points)
    {
        _experiencePoints += points;
        CheckLevelUp();
    }

    private void CheckLevelUp()
    {
        while (_experiencePoints >= _xpForNextLevel)
        {
            _experiencePoints -= _xpForNextLevel;
            _level++;
            _xpForNextLevel = (int)(_xpForNextLevel * 1.5); // Increase XP requirement for next level
            _pointMultiplier += 0.1; // Increase point multiplier
            Console.WriteLine($"Congratulations! You've leveled up to Level {_level}! Point multiplier is now {_pointMultiplier}x.");
            Console.WriteLine($"You gained bonus XP for leveling up. Total XP: {_experiencePoints}");
        }
    }

    public void SetLevel(int level)
    {
        _level = level;
    }

    public void SetExperiencePoints(int experiencePoints)
    {
        _experiencePoints = experiencePoints;
    }

    public void SetXPForNextLevel(int xpForNextLevel)
    {
        _xpForNextLevel = xpForNextLevel;
    }
}
