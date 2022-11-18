using Microsoft.IdentityModel.Tokens;
using Millionaires.Models;
using System.Diagnostics;

namespace Millionaires.Data
{
    public class DbInitializer
    {
        public static void Initialize(MillionairesContext context)
        {
            context.Database.EnsureCreated();       
          
            if (context.Levels.Any())
            {
                return;
            }

            var levels = new Level[]
            {
                new Level{Prize=500,DifficultyLevel=1,Guaranteed=false},
                new Level{Prize=1000,DifficultyLevel=1,Guaranteed=true},
                new Level{Prize=2000,DifficultyLevel=2,Guaranteed=false},
                new Level{Prize=5000,DifficultyLevel=2,Guaranteed=false},
                new Level{Prize=10000,DifficultyLevel=2,Guaranteed=false},
                new Level{Prize=20000,DifficultyLevel=3,Guaranteed=false},
                new Level{Prize=40000,DifficultyLevel=3,Guaranteed=true},
                new Level{Prize=75000,DifficultyLevel=3,Guaranteed=false},
                new Level{Prize=125000,DifficultyLevel=4,Guaranteed=false},
                new Level{Prize=250000,DifficultyLevel=4,Guaranteed=false},
                new Level{Prize=500000,DifficultyLevel=4,Guaranteed=false},
                new Level{Prize=1000000,DifficultyLevel=5,Guaranteed=true}
            };
            foreach (Level l in levels)
            {
                context.Levels.Add(l);
            }
            context.SaveChanges();

            var questions = new Question[]
            {
                new Question{QuestionContents="What is the largest country in the world?",AnswerA="China",AnswerB="USA",AnswerC="Russia",AnswerD="Canada",CorrectAnswer=CorrectAnswer.C,DifficultyLevel=1},
                new Question{QuestionContents="What continent is Romania on?",AnswerA="Europe",AnswerB="North America",AnswerC="Asia",AnswerD="Africa",CorrectAnswer=CorrectAnswer.A,DifficultyLevel=1},
                new Question{QuestionContents="Which of these words is often used to describe a very successful movie?",AnswerA="Flamethrower",AnswerB="Smashmouth",AnswerC="Waterworld",AnswerD="Blockbuster",CorrectAnswer=CorrectAnswer.D,DifficultyLevel=1},
                new Question{QuestionContents="In which of these games do players use a paddle to hit the ball?",AnswerA="Water polo",AnswerB="Ping-Pong",AnswerC="Foosball",AnswerD="Shuffleboard",CorrectAnswer=CorrectAnswer.B,DifficultyLevel=1},
                new Question{QuestionContents="A magnet would most likely attract which of the following?",AnswerA="Metal",AnswerB="Plastic",AnswerC="Wood",AnswerD="All answers are correct",CorrectAnswer=CorrectAnswer.A,DifficultyLevel=1},
                new Question{QuestionContents="Where did Scotch whisky originate?",AnswerA="Ireland",AnswerB="Wales",AnswerC="The United States",AnswerD="Scotland",CorrectAnswer=CorrectAnswer.D,DifficultyLevel=1},
                new Question{QuestionContents="In the United States, what is traditionally the proper way to address a judge?",AnswerA="Your holiness",AnswerB="Your honor",AnswerC="Your eminence",AnswerD="Ey buddy",CorrectAnswer=CorrectAnswer.B,DifficultyLevel=1},
                new Question{QuestionContents="According to a common phrase, a person who takes chances is \"going out on a\" what?",AnswerA="Limb",AnswerB="Horse",AnswerC="Skateboard",AnswerD="Nude beach",CorrectAnswer=CorrectAnswer.A,DifficultyLevel=2},
                new Question{QuestionContents="According to the old saying, \"love of\" what \"is the root of all evil\"?",AnswerA="Food",AnswerB="Money",AnswerC="Clothing",AnswerD="Television",CorrectAnswer=CorrectAnswer.B,DifficultyLevel=2},
                new Question{QuestionContents="Trigonometry is a branch of which subject?",AnswerA="Biology",AnswerB="Economics",AnswerC="Psychology",AnswerD="Mathematics",CorrectAnswer=CorrectAnswer.D,DifficultyLevel=2},
                new Question{QuestionContents="Which tool was used as a weapon by the Norse god Thor?",AnswerA="Pliers",AnswerB="Hammer",AnswerC="Screwdriver",AnswerD="Saw",CorrectAnswer=CorrectAnswer.B,DifficultyLevel=2},
                new Question{QuestionContents="Which of these means a speech in a play where a character talks to themselves rather than to other characters?",AnswerA="Interlude",AnswerB="Revue",AnswerC="Soliloquy",AnswerD="Chorus",CorrectAnswer=CorrectAnswer.C,DifficultyLevel=2},
                new Question{QuestionContents="Lily Savage was a persona of which TV personality?",AnswerA="Paul O'Grady",AnswerB="Barry Humphries",AnswerC="Les Dawson",AnswerD="Brendan O'Carroll",CorrectAnswer=CorrectAnswer.A,DifficultyLevel=2},
                new Question{QuestionContents="Where is Conan the Barbarian from?",AnswerA="From Rivia",AnswerB="From Oz",AnswerC="From Mordor",AnswerD="From Cimmeria",CorrectAnswer=CorrectAnswer.D,DifficultyLevel=3},
                new Question{QuestionContents="Who is the master of the same weapon that the mythological Artemis specialized in?",AnswerA="Zorro",AnswerB="Legolas",AnswerC="Don Quixote",AnswerD="Leonidas I",CorrectAnswer=CorrectAnswer.B,DifficultyLevel=3},
                new Question{QuestionContents="Who composed \"Rhapsody in Blue\"?",AnswerA="Irving Berlin",AnswerB="George Gershwin",AnswerC="Aaron Copland",AnswerD="Cole Porter",CorrectAnswer=CorrectAnswer.B,DifficultyLevel=3},
                new Question{QuestionContents="What is the Celsius equivalent of 77 degrees Fahrenheit?",AnswerA="15",AnswerB="20",AnswerC="25",AnswerD="30",CorrectAnswer=CorrectAnswer.C,DifficultyLevel=3},
                new Question{QuestionContents="Which is the largest city in the USA's largest state?",AnswerA="Dallas",AnswerB="Los Angeles",AnswerC="New York",AnswerD="Anchorage",CorrectAnswer=CorrectAnswer.D,DifficultyLevel=3},
                new Question{QuestionContents="Which Shakespeare play features the line \"Neither a borrower nor a lender be\"?",AnswerA="Hamlet",AnswerB="Macbeth",AnswerC="Othello",AnswerD="The Merchant of Venice",CorrectAnswer=CorrectAnswer.A,DifficultyLevel=3},
                new Question{QuestionContents="In which palace was Queen Elizabeth I born?",AnswerA="Greenwich",AnswerB="Richmond",AnswerC="Hampton Court",AnswerD="Kensington",CorrectAnswer=CorrectAnswer.A,DifficultyLevel=4},
                new Question{QuestionContents="Which of these islands was ruled by Britain from 1815 until 1864?",AnswerA="Crete",AnswerB="Cyprus",AnswerC="Corsica",AnswerD="Corfu",CorrectAnswer=CorrectAnswer.D,DifficultyLevel=4},
                new Question{QuestionContents="Which toxic substance is obtained from the pressed seeds of the castor oil plant?",AnswerA="Sarin",AnswerB="Strychnine",AnswerC="Ricin",AnswerD="Cyanide",CorrectAnswer=CorrectAnswer.C,DifficultyLevel=4},
                new Question{QuestionContents="The Twelve Apostles is a series of peaks connected to which mountain?",AnswerA="Aoraki Mount Cook",AnswerB="K2",AnswerC="Table Mountain",AnswerD="Mont Blanc",CorrectAnswer=CorrectAnswer.C,DifficultyLevel=4},
                new Question{QuestionContents="Suffolk Punch and Hackney are types of what?",AnswerA="Carriage",AnswerB="Wrestling style",AnswerC="Cocktail",AnswerD="Horse",CorrectAnswer=CorrectAnswer.D,DifficultyLevel=4},
                new Question{QuestionContents="Which of the following people has experienced serious mental health problems?",AnswerA="J.K. Rowling",AnswerB="Catherine Tate",AnswerC="Robbie Williams",AnswerD="All of above",CorrectAnswer=CorrectAnswer.D,DifficultyLevel=4},
                new Question{QuestionContents="Which king was married to Eleanor of Aquitaine?",AnswerA="Henry I",AnswerB="Henry II",AnswerC="Richard I",AnswerD="Henry V",CorrectAnswer=CorrectAnswer.B,DifficultyLevel=5},
                new Question{QuestionContents="Oberon is the satellite of which planet?",AnswerA="Mercury",AnswerB="Neptune",AnswerC="Uranus",AnswerD="Mars",CorrectAnswer=CorrectAnswer.C,DifficultyLevel=5},
                new Question{QuestionContents="In 1912, former US President Theodore Roosevelt was a candidate for which political party?",AnswerA="Bull Moose",AnswerB="Bull Dog",AnswerC="Bull Elephant",AnswerD="Bull Frog",CorrectAnswer=CorrectAnswer.A,DifficultyLevel=5},
                new Question{QuestionContents="Tomas Masaryk was the first president of which country?",AnswerA="Czechoslovakia",AnswerB="Poland",AnswerC="Hungary",AnswerD="Yugoslavia",CorrectAnswer=CorrectAnswer.A,DifficultyLevel=5},
                new Question{QuestionContents="Which of these is a butterfly, not a moth?",AnswerA="Mother Shipton",AnswerB="Red Underwing",AnswerC="Burnished Brass",AnswerD="Speckled Wood",CorrectAnswer=CorrectAnswer.D,DifficultyLevel=5},
                new Question{QuestionContents="Who was the first man to travel into space twice?",AnswerA="Vladimir Titov",AnswerB="Michael Collins",AnswerC="Gus Grissom",AnswerD="Yuri Gagarin",CorrectAnswer=CorrectAnswer.C,DifficultyLevel=5},
                new Question{QuestionContents="In the history of motor sport, which of these iconic races was held first?",AnswerA="Le Mans 24 Hours",AnswerB="Monaco Grand Prix",AnswerC="Indy 500",AnswerD="Isle of Man TT",CorrectAnswer=CorrectAnswer.D,DifficultyLevel=5},
                new Question{QuestionContents="In 1718, which pirate died in battle off the coast of what is now North Carolina?",AnswerA="Calico Jack",AnswerB="Blackbeard",AnswerC="Bartholomew Roberts",AnswerD="Captain Kidd",CorrectAnswer=CorrectAnswer.B,DifficultyLevel=5}

            };

            foreach (Question q in questions)
            {
                if (context.Questions.Any())
                {
                    var _q = context.Questions.Single(qq => qq.QuestionContents == q.QuestionContents);
                }
                else
                {
                    context.Questions.Add(q);
                }
            }
            context.SaveChanges();
        }
    }
}
