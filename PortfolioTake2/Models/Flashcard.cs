using MessagePack.Resolvers;
using System.Drawing;

namespace PortfolioTake2.Models
{
    public class Flashcard
    {
        /// <summary>
        /// Each flashcard in a given set has these parameters. Database will be created with these parameters
        /// </summary>
        public int ID { get; set; }

        public string EnglishWord { get; set; }
        public string SpanishWord { get; set; }

        public string ImagePromptLink { get; set; } //backup idea
        public string VideoPromptLink { get; set; } //Youtube link

        public int CardLevel{ get; set; }
        public int NumberOfReviews { get; set; }
        public DateTime LastReviewTimestamp {get; set; }
        public Flashcard()
        {

        }
    }
}
