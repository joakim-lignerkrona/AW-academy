using JockanUI;

namespace Boolsk_Algebra {
    internal class Program {
        static void Main(string[] args) {
            Frukt[] frukter = new Frukt[8];
            Frukt frukt = new Frukt();
            frukt.FruktTyp = "Banan";
            frukt.FruktNamn = "Chiquita";
            frukt.PrisPerKg = 22;
            frukter[0] = frukt;
            frukt = new Frukt();
            frukt.FruktTyp = "Banan";
            frukt.FruktNamn = "Dole";
            frukt.PrisPerKg = 25;
            frukter[1] = frukt;
            frukt = new Frukt();
            frukt.FruktTyp = "Banan";
            frukt.FruktNamn = "Del monte";
            frukt.PrisPerKg = 30;
            frukter[2] = frukt;
            frukt = new Frukt();
            frukt.FruktTyp = "Apelsin";
            frukt.FruktNamn = "Valencia";
            frukt.PrisPerKg = 24;
            frukter[3] = frukt;
            frukt = new Frukt();
            frukt.FruktTyp = "Apelsin";
            frukt.FruktNamn = "Mandarin";
            frukt.PrisPerKg = 30;
            frukter[4] = frukt;
            frukt = new Frukt();
            frukt.FruktTyp = "Apelsin";
            frukt.FruktNamn = "Blod";
            frukt.PrisPerKg = 27;
            frukter[5] = frukt;
            frukt = new Frukt();
            frukt.FruktTyp = "Päron";
            frukt.FruktNamn = "Anjou";
            frukt.PrisPerKg = 19;
            frukter[6] = frukt;
            frukt = new Frukt();
            frukt.FruktTyp = "Päron";
            frukt.FruktNamn = "Bartlett";
            frukt.PrisPerKg = 32;
            frukter[7] = frukt;

            var cheaperFruits = CheaperFruits(30, frukter);
            var moreExpenciveFruits = MoreExpenciveFruits(25, frukter, "Apelsin");
            logFruits(cheaperFruits);
            Console.WriteLine("\t-------------------------------------------");
            logFruits(moreExpenciveFruits);
            Console.WriteLine("\t-------------------------------------------");
            logFruits(MoreExpenciveFruits(25, frukter, new string[] { "Banan", "päron" }));

        }

        #region
        private static Frukt[] MoreExpenciveFruits(int minPrice, Frukt[] frukter, string type) {
            return MoreExpenciveFruits(minPrice, frukter, new string[] { type });
        }

        private static Frukt[] MoreExpenciveFruits(int minPrice, Frukt[] frukter, string[] types) {
            var newFruits = new List<Frukt>();


            for(int i = 0; i < frukter.Length; i++) {
                if(frukter[i].PrisPerKg > minPrice) {
                    foreach(var type in types) {
                        if(type.ToLower() == frukter[i].FruktTyp.ToLower()) {
                            newFruits.Add(frukter[i]);
                        }
                    }
                }
            }
            return newFruits.ToArray();
        }

        private static Frukt[] MoreExpenciveFruits(int minPrice, Frukt[] frukter) {
            var newFruits = new List<Frukt>();
            for(int i = 0; i < frukter.Length; i++) {
                if(frukter[i].PrisPerKg > minPrice) {
                    newFruits.Add(frukter[i]);
                }
            }
            return newFruits.ToArray();
        }
        #endregion

        private static void logFruits(Frukt[] cheaperFruits) {
            foreach(var fruit in cheaperFruits) {
                Console.WriteLine("\t| {0,-14}| {1,-14}| {2,14} |", fruit.FruktTyp, fruit.FruktNamn, fruit.PrisPerKg);
            }
        }

        private static Frukt[] CheaperFruits(int maxPrice, Frukt[] frukter) {
            var newFruits = new List<Frukt>();
            for(int i = 0; i < frukter.Length; i++) {
                if(frukter[i].PrisPerKg < maxPrice) {
                    newFruits.Add(frukter[i]);
                }
            }
            return newFruits.ToArray();
        }
    }
}