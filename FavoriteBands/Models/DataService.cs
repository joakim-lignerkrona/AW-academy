namespace FavoriteBands.Models
{
    public class DataService
    {
        // a singleton of sample data from bands
        static DataService service;
        // a list of bands
        List<Band> bands = new List<Band>();
        // a counter for the ID
        static int ID = 1;
        // a constructor for the data service
        DataService()
        {
            // add some sample data
            bands.Add(
                new Band
                {
                    ID = ID++,
                    Name = "Black Pink",
                    Description = "The band consists of four members: Jisoo, Jennie, Rosé, and Lisa. They debuted in 2016 under YG Entertainment. They have won several awards, including four Mnet Asian Music Awards, four Melon Music Awards, and four Golden Disc Awards. They have sold over 20 million albums and 75 million digital singles as of 2019. They have broken several Guinness World Records, including the 'Most Twitter engagements by a celebrity in 24 hours' and the 'Most viewed music video on YouTube in 24 hours'. They were named by Time as one of the 100 most influential people in the world in 2019.",
                    ImgPath = "/assets/images/blackpink.webp"
                });
            bands.Add(
                new Band
                {
                    ID = ID++,
                    Name = "5 seconds of summer",
                    Description = "Australian Pop group from Sydney, Australia. The band formed in 2011 with the members Luke Hemmings, Michael Clifford, Calum Hood, and Ashton Irwin.",
                    ImgPath = "/assets/images/5sos.jpg"
                });
            bands.Add(
                new Band
                {
                    ID = ID++,
                    Name = "BTS",
                    Description = "Korean Pop group from Seoul, South Korea. The band consists of seven members: RM, Jin, Suga, J-Hope, Jimin, V, and Jungkook. They were formed in 2010 and debuted in 2013 under Big Hit Entertainment. They are the first K-pop group to top the Billboard 200 and the first Korean act to win a Billboard Music Award. They have also won several other awards, including four Mnet Asian Music Awards, four Melon Music Awards, and four Golden Disc Awards. They have sold over 20 million albums and 75 million digital singles as of 2019. They have broken several Guinness World Records, including the 'Most Twitter engagements by a celebrity in 24 hours' and the 'Most viewed music video on YouTube in 24 hours'. They were named by Time as one of the 100 most influential people in the world in 2019.",
                    ImgPath = "/assets/images/bts.jpg"
                });




        }
        // a method to get the instance of the data service
        public static DataService GetInstance()
        {
            if(service == null)
            {
                service = new DataService();
            }
            return service;
        }
        public Band[] GetAllBands()
        {
            return bands.OrderBy(b => b.Name).ToArray();
        }
        public Band GetBand(int id)
        {
            return bands.FirstOrDefault(b => b.ID == id);
        }

    }
}
