using System;
using System.Collections.Generic;

public class Selection
{
    private Dictionary<string, List<(Ref reference, string scripture)>> _scriptureData;

    public Selection()
    {
        _scriptureData = new Dictionary<string, List<(Ref, string)>>
        {
            { "The Book of Mormon", new List<(Ref, string)>
                {
                    (new Ref("1 Nephi", 3, 7), "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them."),
                    (new Ref("2 Nephi", 2, 25), "Adam fell that men might be; and men are, that they might have joy."),
                    (new Ref("Alma", 32, 21), "And now as I said concerning faith—faith is not to have a perfect knowledge of things; therefore if ye have faith ye hope for things which are not seen, which are true."),
                    (new Ref("Mosiah", 2, 17), "And behold, I tell you these things that ye may learn wisdom; that ye may learn that when ye are in the service of your fellow beings ye are only in the service of your God."),
                    (new Ref("Ether", 12, 6), "And now, I, Moroni, would speak somewhat concerning these things; I would show unto the world that faith is things which are hoped for and not seen; wherefore, dispute not because ye see not, for ye receive no witness until after the trial of your faith.")
                }
            },
            { "The Doctrine and Covenants", new List<(Ref, string)>
                {
                    (new Ref("Doctrine and Covenants", 1, 37), "Search these commandments, for they are true and faithful, and the prophecies and promises which are in them shall all be fulfilled."),
                    (new Ref("Doctrine and Covenants", 8, 2), "Yea, behold, I will tell you in your mind and in your heart, by the Holy Ghost, which shall come upon you and which shall dwell in your heart."),
                    (new Ref("Doctrine and Covenants", 18, 10), "Remember the worth of souls is great in the sight of God."),
                    (new Ref("Doctrine and Covenants", 19, 23), "Learn of me, and listen to my words; walk in the meekness of my Spirit, and you shall have peace in me."),
                    (new Ref("Doctrine and Covenants", 58, 42), "Behold, he who has repented of his sins, the same is forgiven, and I, the Lord, remember them no more.")
                }
            },
            { "The Old Testament", new List<(Ref, string)>
                {
                    (new Ref("Genesis", 1, 1), "In the beginning, God created the heavens and the earth."),
                    (new Ref("Exodus", 20, 3), "Thou shalt have no other gods before me."),
                    (new Ref("Isaiah", 1, 18), "Come now, and let us reason together, saith the Lord: though your sins be as scarlet, they shall be as white as snow; though they be red like crimson, they shall be as wool."),
                    (new Ref("Proverbs", 3, 5), "Trust in the Lord with all thine heart; and lean not unto thine own understanding."),
                    (new Ref("Psalms", 23, 1), "The Lord is my shepherd; I shall not want.")
                }
            },
            { "The New Testament", new List<(Ref, string)>
                {
                    (new Ref("John", 3, 16), "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life."),
                    (new Ref("Matthew", 5, 14), "Ye are the light of the world. A city that is set on a hill cannot be hid."),
                    (new Ref("Romans", 8, 28), "And we know that all things work together for good to them that love God, to them who are the called according to his purpose."),
                    (new Ref("Philippians", 4, 13), "I can do all things through Christ which strengtheneth me."),
                    (new Ref("1 Corinthians", 13, 4), "Charity suffereth long, and is kind; charity envieth not; charity vaunteth not itself, is not puffed up.")
                }
            }
        };
    }

    public Dictionary<string, List<(Ref reference, string scripture)>> GetScriptureData()
    {
        return _scriptureData;
    }
}
