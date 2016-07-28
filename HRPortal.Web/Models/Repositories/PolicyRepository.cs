using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HRPortal.Web.Models.Data;

namespace HRPortal.Web.Models.Repositories
{
    public class PolicyRepository
    {
        private static List<Policy> _policies;

        #region Ipsum Content

        private static string futurama = "With a warning label this big, you know they " +
                                          "gotta be fun! Hi, I'm a naughty nurse, and I " +
                                          "really need someone to talk to. $9.95 a minute. " +
                                          "Yep, I remember. They came in last at the " +
                                          "Olympics, then retired to promote alcoholic " +
                                          "beverages! Oh, all right, I am. But if anything " +
                                          "happens to me, tell them I died robbing some " +
                                          "old man. You're going back for the Countess, " +
                                          "aren't you? Does anybody else feel jealous and " +
                                          "aroused and worried? Tell her she looks thin.";
        private static string arrestedDevelopment = "Did you enjoy your meal, Mom? You drank it fast " +
                                          "enough. I'm half machine. I'm a monster. That's " +
                                          "what it said on 'Ask Jeeves.' I hear the jury's " +
                                          "still out on science.  Michael! No, I did not " +
                                          "kill Kitty. However, I am going to oblige and " +
                                          "answer the nice officer's questions because I am " +
                                          "an honest man with no secrets to hide. Army had " +
                                          "half a day. Really? Did nothing cancel? Say goodbye " +
                                          "to these, because it's the last time! I'm a monster. " +
                                          "It's called 'taking advantage.' It's what gets you " +
                                          "ahead in life. Michael!";
        private static string simpsons = "Dad didn't leave… When he comes back from the store, " +
                                          "he's going to wave those pop-tarts right in your face! " +
                                          "I can't go to juvie. They use guys like me as " +
                                          "currency. Kids, you tried your best and you failed " +
                                          "miserably. The lesson is, never try. \"Thank the " +
                                          "Lord\"? That sounded like a prayer. A prayer in a " +
                                          "public school. God has no place within these walls, " +
                                          "just like facts don't have a place within an " +
                                          "organized religion. He didn't give you gay, did he? " +
                                          "Did he?!  Inflammable means flammable? What a country. " +
                                          "Whoa, slow down there, maestro. There's a *New* " +
                                          "Mexico? I'm going to the back seat of my car, with " +
                                          "the woman I love, and I won't be back for ten minutes! D'oh.";
        private static string lizLemon = "You didn't realize emotion could be a weapon? Have you " +
                                          "not read the poetry of Jewel? I want to go to there. " +
                                          "Ugh, Julia Roberts in a movie about eating? Give me " +
                                          "Kirstie Alley, somebody who knows what she's doing. I " +
                                          "was going to take this class called Cooking for One, " +
                                          "but the teacher killed himself. You wanna party? It’s " +
                                          "$500 for kissing and $10,000 for snuggling; end of " +
                                          "list. If I have learned anything from my Sims family: " +
                                          "When a child doesn’t see his father enough he starts " +
                                          "to jump up and down, then his mood level will drop until " +
                                          "he pees himself. This better be important Jack, I was in " +
                                          "the middle of buying a bag of bras on eBay. I'm not the " +
                                          "one you call when you want to go clubbing on the town " +
                                          "and party-dance all night. Tracy took advantage of my " +
                                          "white guilt, which is supposed to be used only for good, " +
                                          "like overtipping and supporting Barack Obama. So I am " +
                                          "making my graceful transition into spinsterhood. I " +
                                          "have adopted this cat, named her Emily Dickinson.";
        private static string adventureTime = "Whatya building? Uhm, its just a little stick fort. " +
                                          "Oh, rad! Look. Its just my size. Hey, get away from my " +
                                          "fort, you big stinky monster! I like it when you get " +
                                          "small, Jake. Yeah, me too. Whoa, whoa! Whoa, " +
                                          "Peppermint butler! Finn, Jake. The Princess wants to " +
                                          "see you. As princess of Candy Kingdom, Im in charge " +
                                          "of a lot of candy people. They rely on me. I can't " +
                                          "imagine what might happen to them if I was gone. And " +
                                          "after my brush with death, at the hands of the Lich, " +
                                          "I realized something. Im not gonna live forever Finn. " +
                                          "I would if I could.";
        private static string itCrowd = "OK. Moss, what did you have for breakfast this morning? " +
                                          "Smarties cereal. How long have you been disabled? Ten " +
                                          "years? Ten years, and how did it happen? If that's not " +
                                          "a rude question. How long have you been disabled? " +
                                          "Ten years? Ten years, and how did it happen? If that's " +
                                          "not a rude question. Acid? You're not comfortable with " +
                                          "your sexuality? Oh, I'm very comfortable with my " +
                                          "sexuality, I just don't want to be slapped in the face " +
                                          "with their sexuality. I'm going to murder you... You " +
                                          "bloody woman! Yes! Yesterday's jam. That is what we are " +
                                          "to them!... Actually, that doesn't work, as a thing, " +
                                          "because, you know, jam lasts for ages.";
        private static string breakingBad = "That is seventeen five - your half of the thirty-five " +
                                          "thousand. Plus there's an extra fifteen in there, it's " +
                                          "all yours, you've earned it. We made a deal. That's " +
                                          "right. Because I think that we can do business together " +
                                          "- we came to an understanding. Take a look at the money " +
                                          "in your hand. Now just imagine making that every week. " +
                                          "That's right. Two pounds a week, thirty-five thousand " +
                                          "a pound. Look... I feel like I'm running out of ways " +
                                          "to explain this to you but once more, I shall try. " +
                                          "This fly is a major problem for us. It will " +
                                          "ruin our batch. And we need to destroy it and " +
                                          "every trace of it, so we can cook. Failing " +
                                          "that, we're dead. There's no more room for " +
                                          "error. Not with these people.";
        
        #endregion


        static PolicyRepository()
        {
            _policies = new List<Policy>
            {
                new Policy {PolicyId = 1, Name = "Delivery Procedure", Category = new Category {CategoryId = 1, Name = "Cat1"}, Content = futurama },
                new Policy {PolicyId = 2, Name = "That's Why You Always Leave A Note", Category = new Category {CategoryId = 1, Name = "Cat1"}, Content = arrestedDevelopment },
                new Policy {PolicyId = 3, Name = "Embiggenment Strategy", Category = new Category {CategoryId = 2, Name = "Cat2"}, Content = simpsons },
                new Policy {PolicyId = 4, Name = "Corporate Relationship Guidelines", Category = new Category {CategoryId = 3, Name = "Cat3"}, Content = lizLemon },
                new Policy {PolicyId = 5, Name = "Employee Stress Relief Protocol", Category = new Category {CategoryId = 3, Name = "Cat3"}, Content = adventureTime },
                new Policy {PolicyId = 6, Name = "Technology Usage Agreement", Category = new Category {CategoryId = 3, Name = "Cat3"}, Content = itCrowd },
                new Policy {PolicyId = 7, Name = "Drug Guidelines", Category = new Category {CategoryId = 3, Name = "Cat3"}, Content = breakingBad }
            };
        }

        public static IEnumerable<Policy> GetAll()
        {
            return _policies;
        }

        public static Policy Get(int id)
        {
            return _policies.FirstOrDefault(p => p.PolicyId == id);
        }

        public static IEnumerable<Policy> GetByCategory(int id)
        {
            return _policies.Where(p => p.Category.CategoryId == id);
        }

        public static int GetNextPolicyId()
        {
            if (_policies.Count == 0) return 1;
            return _policies.Max(p => p.PolicyId) + 1;
        }

        public static void AddPolicy(Policy policy)
        {
            _policies.Add(policy);
        }

        public static void DeletePolicy(int id)
        {
            _policies.RemoveAll(p => p.PolicyId == id);
        }
    }
}