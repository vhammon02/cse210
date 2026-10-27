public class ScriptureManager
{
    //attributes
    private List<(Reference, Scripture)> _scriptures;
    private Random _random;

    //constructor
    public ScriptureManager()
    {
        _scriptures = new List<(Reference, Scripture)>();
        _random = new Random();

        LoadScriptures();
    }

    public (Reference reference, Scripture scripture) GetRandomScripture()
    {
        int index = _random.Next(_scriptures.Count);
        return _scriptures[index];
    }
    private void LoadScriptures()
    {
        _scriptures.Add((
            new Reference("Alma", "5", 13, 14),
            new Scripture(new string[]
            {
                "13 And behold, he preached the word unto your fathers, and a mighty change was also wrought in their hearts, and they humbled themselves and put their trust in the true and living God. And behold, they were faithful until the end; therefore they were saved.",
                "14 And now behold, I ask of you, my brethren of the church, have ye spiritually been born of God? Have ye received his image in your countenances? Have ye experienced this mighty change in your hearts?"
            })
        ));
        _scriptures.Add((
            new Reference("Matthew", "22", 36, 39),
            new Scripture(new string[]
            {
                "36 Master, which is the great commandment in the law?",
                "37 Jesus said unto him, Thou shalt love the Lord thy God with all thy heart, and with all thy soul, and with all thy mind.",
                "38 This is the first and great commandment.",
                "39 And the second is like unto it, Thou shalt love thy neighbour as thyself."
            })
        ));
        _scriptures.Add((
            new Reference("Ether", "12", 6),
            new Scripture(new string[]
            {
                "6 And now, I, Moroni, would speak somewhat concerning these things; I would show unto the world that faith is things which are hoped for and not seen; wherefore, dispute not because ye see not, for ye receive no witness until after the trial of your faith."
            })
        ));
        _scriptures.Add((
            new Reference("Moses", "1", 39),
            new Scripture(new string[]
            {
                "39 For behold, this is my work and my glory—to bring to pass the immortality and eternal life of man."            })
        ));
    }
}