using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Name: Aaron Yap-Dumlao, Abeer Kashar, Anvita Akkineni, Haniya Kashif, Tuhina Ray
 * Date: Nov 1 - Nov 9
 * Assignment: Culminating
 * Purpose: Create a game.
 */

namespace Grandma_sAdventure
{
    class Program
    {
        private static int Luck = 0;
        static void Main(string[] args)
        {
            //reset luck 
            Luck = 0;
            //introduce player to concept of game, instructions, and storyline options
            Console.WriteLine("Welcome to Grandma’s Adventure! Your grandmother is very sick, and when you go to visit her, she reveals that she is in possession of a map that leads to five very valuable treasures, hidden in different locations. She is too old to go in search of them herself, and instead asks you to undertake the journey in her place, giving you the map.");
            Console.WriteLine("\nYour goal is to find the treasure and gather as much luck as possible, which will determine your outcome. To progress through the game, make choices by entering letters such as A and B associated with certain actions. Some actions will give you luck, while some will take luck away, so choose wisely! Enter X at any time to quit.");
            Console.WriteLine("\nSelect which area you would like to explore first.\nA: Cave\nB: Desert\nC: Jungle\nD: Mountain\nE: Sea\n");
            //goto if user inputs invalid option
            Begin:
            //initialize input
            string Input = Console.ReadLine();
            //send user to correct method depending on input
            if (Input == "A" || Input == "a")
            {
                FirstCaveChoice();
            }
            else if (Input == "B" || Input == "b")
            {
                Desert();
            }
            else if (Input == "C" || Input == "c")
            {
                Jungle();
            }
            else if (Input == "D" || Input == "d")
            {
                Mountain();
            }
            else if (Input == "E" || Input == "e")
            {
                Sea();
            }
            //close console
            else if (Input == "X" || Input == "x")
            {
                Environment.Exit(0);
            }
            //send to beginning of if statement if input is invalid
            else
            {
                Console.WriteLine("\nPlease enter a valid option.");
                goto Begin;
            }
        }

        //first cave choice method: learned from MrStormUMA on Youtube
        //cave storyline: written by Abeer
        public static void FirstCaveChoice()
        {
            //display luck
            Console.WriteLine("\nLUCK: " + Luck);
            //debug mode 
            Console.WriteLine("DEBUG NOTE: if you want to play the game without going through the story, type RPS to skip there, then type Y. However, the version of the game you will receive depends on when in the game you call the method, according to your Luck.\n");
            //storyline and options
            Console.WriteLine("You enter the cave. It smells damp and earthy, and water drips from the ceiling, echoing loudly. Flowstones cover the walls and floors in sheets, and you can see clusters of helictite covering the limestone like noodles. As you walk deeper, it gets darker and darker until you can barely see a foot in front of you. However, you remember you have the LIGHTER you stashed in your back pocket. Do you want to use your LIGHTER?\nA: light the lighter\nB: do nothing\n");
            //goto if user inputs invalid option
            Lighter:
            //initialize input
            string Input = Console.ReadLine();
            //lose luck, display story and luck, send to next choice
            if (Input == "A" || Input == "a")
            {
                Luck -= 30;
                Console.WriteLine("\nYou flick your lighter, and see a billion eyes on the ceiling staring back at you. The bats are startled by the light and fly past you in a rush, knocking you down and dislodging your lighter from your hand. You can’t find it again. -30 luck.");
                Console.WriteLine("LUCK: " + Luck);
                SecondCaveChoice();
            }
            //gain luck, display story and luck, send to next choice
            else if (Input == "B" || Input == "b")
            {
                Luck += 10;
                Console.WriteLine("\nYou continue to walk, feeling your way along. +10 luck.");
                Console.WriteLine("LUCK: " + Luck);
                SecondCaveChoice();
            }
            //send to game
            else if (Input == "RPS")
            {
                RPS();
            }
            //close console
            else if (Input == "X" || Input == "x")
            {
                Environment.Exit(0);
            }
            //send to beginning of if statement if input is invalid
            else
            {
                Console.WriteLine("\nPlease enter a valid option.");
                goto Lighter;
            }
        }

        //second cave choice
        public static void SecondCaveChoice()
        {
            Console.WriteLine("\nAfter a while, you find yourself in a hollow cavern, and light coming from the bright jewels covering the walls allows you to see better. You are amazed by the sheer number that coat the entire ceiling and walls. You feel like you’re inside a lamp. The jewels glow in an almost unearthly manner, and their smooth red surface looks like … candy …\nA: lick a jewel\nB: try and pry a jewel from the wall\nC: continue on\n");
            //goto if user inputs invalid option
            Jewel:
            //initialize input
            string Input = Console.ReadLine();
            //gain luck, display story and luck, send to next choice
            if (Input == "A" || Input == "a")
            {
                Luck += 80;
                Console.WriteLine("\nThe jewel tastes like a strawberry lollipop. You instantly feel rejuvenated. This cave truly has magical properties … Thanks, Grandma. +80 luck.");
                Console.WriteLine("LUCK: " + Luck);
                ThirdCaveChoice();
            }
            //lose luck, display story and luck, send to next choice
            else if (Input == "B" || Input == "b")
            {
                Luck -= 50;
                Console.WriteLine("\nThese jewels sure look valuable. You approach one, get a good grip, and pull, but the rock is firmly embedded in the cave wall. You put a foot on the wall and yank as hard as you can, but the rock glows angrily and heats to a searing level. You yelp and let go abruptly, finding your hands covered in burns. Clearly the jewel does not want to go with you. -50 luck.");
                Console.WriteLine("LUCK: " + Luck);
                ThirdCaveChoice();
            }
            //gain luck, display story and luck, send to next choice
            else if (Input == "C" || Input == "c")
            {
                Luck += 10;
                Console.WriteLine("\nThis can’t be the treasure your grandma was telling you about. You exit the cavern through the far tunnel. +10 luck.");
                Console.WriteLine("LUCK: " + Luck);
                ThirdCaveChoice();
            }
            //send to game
            else if (Input == "RPS")
            {
                RPS();
            }
            //close console
            else if (Input == "X" || Input == "x")
            {
                Environment.Exit(0);
            }
            //send to beginning of if statement if input is invalid
            else
            {
                Console.WriteLine("\nPlease enter a valid option.");
                goto Jewel;
            }
        }

        //third cave choice
        public static void ThirdCaveChoice()
        {
            Console.WriteLine("\nAfter a few more minutes of walking, you begin to hear what you think is the sound of rushing water. You come across a cave river that blocks your path. The crashing black water seems to extend as far as you can see in both directions, and you can see small creatures swimming around in it.\nA: try and catch a fish\nB: try and jump over the river\nC: try and walk around\n");
            //goto if user inputs invalid option
            River:
            //initialize input
            string Input = Console.ReadLine();
            //send to sideplot
            if (Input == "A" || Input == "a")
            {
                Console.WriteLine("\nWhy not, right? You kneel by the river and wait until one of the creatures comes close enough to scoop it out of the water. A completely white fish with no eyes flails in the palm of your hand.\nA: eat the fish\nB: watch the fish die\nC: throw the fish back in the water\n");
                FishChoice();
            }
            //lose luck, display story and luck, send to next choice
            else if (Input == "B" || Input == "b")
            {
                Luck -= 70;
                Console.WriteLine("\nNo other way around; you shake out your arms, bend at the knees and take a wild spring towards the other side of the river. Unfortunately, you did not make your school’s long jump team, and you only remember this once you’ve landed in the freezing cold water. The river carries you deep into the cave, and you hit many boulders and ingest much of the unsanitary water, until you are pushed into a shallower area where you can manage to clamber out. Now you are cold and bruised. -70 luck.");
                Console.WriteLine("LUCK: " + Luck);
                FourthCaveChoice();
            }
            //gain luck, display story and luck, send to next choice
            else if (Input == "C" || Input == "c")
            {
                Luck += 60;
                Console.WriteLine("\nYou decide your best bet is to find a way around the dangerous waters, and decide to walk downstream. The water grows calmer and calmer, and after only ten minutes, you discover a point where the river is low enough to simply step across. +60 luck.");
                Console.WriteLine("LUCK: " + Luck);
                FourthCaveChoice();
            }
            //send to game
            else if (Input == "RPS")
            {
                RPS();
            }
            //close console
            else if (Input == "X" || Input == "X")
            {
                Environment.Exit(0);
            }
            //send to beginning of if statement if input is invalid
            else
            {
                Console.WriteLine("\nPlease enter a valid option.");
                goto River;
            }
        }

        //fish sideplot
        public static void FishChoice()
        {
            //goto if user inputs invalid option
            Fish:
            //initialize input
            string Input = Console.ReadLine();
            //lose luck, display story and luck, send to next choice
            if (Input == "A" || Input == "a")
            {
                Luck -= 30;
                Console.WriteLine("\nWhy would you do that? You can feel the rubbery fish slide down your throat. Disgusting. You know you should cook it first, right? -30 luck.");
                Console.WriteLine("LUCK: " + Luck);
                FourthCaveChoice();
            }
            //lose luck, display story and luck, send to next choice
            else if (Input == "B" || Input == "b")
            {
                Luck -= 20;
                Console.WriteLine("\nThe fish flops around your hand until it runs out of air and dies. This causes you to think about the fleetingness of life, and you become depressed. -20 luck.");
                Console.WriteLine("LUCK: " + Luck);
                FourthCaveChoice();
            }
            //gain luck, display story and luck, send to next choice
            else if (Input == "C" || Input == "c")
            {
                Luck += 15;
                Console.WriteLine("\nYou throw the fish back in the water and it is soon back to swimming happily with its blind fish friends. Nice. +15 luck.");
                Console.WriteLine("LUCK: " + Luck);
                FourthCaveChoice();
            }
            //send to game
            else if (Input == "RPS")
            {
                RPS();
            }
            //close console
            else if (Input == "X" || Input == "x")
            {
                Environment.Exit(0);
            }
            //send to beginning of if statement if input is invalid
            else
            {
                Console.WriteLine("\nPlease enter a valid option.");
                goto Fish;
            }
        }

        //fourth cave choice
        public static void FourthCaveChoice()
        {
            Console.WriteLine("\nYou continue on your way. A cave salamander lies on a rock. Poke it?\nA: poke\nB: do not poke\nC: kick the rock\n");
            //goto if user inputs invalid option
            Rock:
            //initialize input
            string Input = Console.ReadLine();
            //lose luck, display story and luck, send to next choice
            if (Input == "A" || Input == "a")
            {
                Luck -= 25;
                Console.WriteLine("\nYou slowly extend a finger and poke the salamander on the back. Slimy. It raises its head slowly and turns to glare at you. “What did you do that for?” it grumbles. You try to apologize, but the salamander is not having it, and slithers away into the darkness. You feel kind of bad. -25 luck.");
                Console.WriteLine("LUCK: " + Luck);
                FifthCaveChoice();
            }
            //gain luck, display story and luck, send to next choice
            else if (Input == "B" || Input == "b")
            {
                Luck += 30;
                Console.WriteLine("\nYou decide to leave the salamander alone, and try to walk past. However, the creature wakes from the sound of your footsteps and angrily slithers past you, snapping at your ankles. That was scary, but at least it didn’t bite you. Consider yourself lucky. +30 luck.");
                Console.WriteLine("LUCK: " + Luck);
                FifthCaveChoice();
            }
            //gain luck, display story and luck, send to next choice
            else if (Input == "C" || Input == "c")
            {
                Luck += 70;
                Console.WriteLine("\nRocks are so kickable. You give the side of the rock a mighty kick and nearly feel the bone shatter inside your foot. You’re so busy hopping around in pain that you don’t notice the salamander waking from his slumber, and he is beside himself with laughter at your predicament. As a thanks for making him laugh so hard, he beckons you to give you a Healing Lick, which is exactly what it sounds like. The pain goes away instantly! +70 luck.");
                Console.WriteLine("LUCK: " + Luck);
                FifthCaveChoice();
            }
            //send to game
            else if (Input == "RPS")
            {
                RPS();
            }
            //close console
            else if (Input == "X" || Input == "x")
            {
                Environment.Exit(0);
            }
            //send to beginning of if statement if input is invalid
            else
            {
                Console.WriteLine("\nPlease enter a valid option.");
                goto Rock;
            }
        }

        //fifth cave choice
        public static void FifthCaveChoice()
        {
            StreamWriter sw = new StreamWriter("PoisonCaveEnd.txt"); //will write to poison cave ending file
            //display storyline
            Console.WriteLine("\nSome time passes before your path is blocked once again, this time by a giant green wall of … something. You don’t think plants should be growing so deep in a cave due to photosynthesis or whatever, but here is a thick wall of vine-seeming plants. There are no other paths around, and the wall is too thick to see the other side. What should you do?\nA: eat them\nB: go underneath\nC: walk through\nD: run through\n");
            //goto if user inputs invalid optiona
            Leaf:
            //initialize input
            string Input = Console.ReadLine();
            //die
            if (Input == "A" || Input == "a")
            {
                Console.WriteLine("\nThere’s no way you’re going to put your whole body in contact with those plants, not without knowing whether they’re non-toxic. Clearly, the best way to check for safety is a taste test! You grab the nearest coarse leaf and stuff it in your mouth. You die immediately.");
                //ask to replay or end game
                Console.WriteLine("\nGAME OVER\n\nPlay again?\nY: yes\nN: no");
                sw.WriteLine("GAME OVER, unfortunately the treasure will not be yours today. You finished with " + Luck + " Luck. Bad Cave Ending: Poison unlocked."); //save ending to poison cave ending file
                sw.Close(); //close streamwriter
                //goto if user inputs invalid option
                Replay:
                //let user input
                Console.ReadLine();
                //send to beginning of program
                if (Input == "Y" || Input == "y")
                {
                    Main(new[] { string.Empty });
                }
                //close console
                else if (Input == "N" || Input == "n")
                {
                    Environment.Exit(0);
                }
                //send to beginning of if statement if input is invalid
                else
                {
                    Console.WriteLine("Please enter a valid option.");
                    goto Replay;
                }
            }
            //gain luck, display story and luck, send to next choice
            else if (Input == "B" || Input == "b")
            {
                Luck += 50;
                Console.WriteLine("\nYou drop to the wet cave floor and decide to army-crawl beneath the plants. You keep your eyes tightly shut against the tentacles of green, and feel multiple bugs (at least you choose to believe they’re bugs) crawl over your hands and body, but keep going. Eventually, you feel the light against your eyelids, and you’re free. Your clothes are gross and the backs of your hands that made contact with the plants are covered in rashes, but at least you made it out. +50 luck.");
                Console.WriteLine("LUCK: " + Luck);
                SixthCaveChoice();
            }
            //lose luck, display story and luck, send to next choice
            else if (Input == "C" || Input == "c")
            {
                Luck -= 60;
                Console.WriteLine("\nThere’s no telling how long the wall goes on for, but there’s no way around it. You decide the best approach will be to carefully and cautiously make your way through. From the moment you step into the wall, you feel a burning sensation all over your body that doesn’t let up until you’re out the other side. The plants have caused hives to pop up on all your exposed skin, including your face and hands. Ouch. -60 luck.");
                Console.WriteLine("LUCK: " + Luck);
                SixthCaveChoice();
            }
            //gain luck, display story and luck, send to next choice
            else if (Input == "D" || Input == "d")
            {
                Luck += 30;
                Console.WriteLine("\nYou don’t want to be trapped within that wall for any longer than you have to be, so you get a running start and practically throw yourself through the wall. Any skin that brushed against the plant becomes red and irritated, but it’s better than prolonged exposure would have been. +30 luck.");
                Console.WriteLine("LUCK: " + Luck);
                SixthCaveChoice();
            }
            //send to game
            else if (Input == "RPS")
            {
                RPS();
            }
            //close console
            else if (Input == "X" || Input == "x")
            {
                Environment.Exit(0);
            }
            //send to beginning of if statement if input is invalid
            else
            {
                Console.WriteLine("\nPlease enter a valid option.");
                goto Leaf;
            }
        }

        //sixth cave choice
        public static void SixthCaveChoice()
        {
            Console.WriteLine("\nFor a long while, your only option is to walk straight down the seemingly endless tunnel. The rush of the river behind you disappears, you see no other living creatures or plants, and you are alone with your thoughts. You almost give up hope and think of turning back when you reach a fork in the road. To the left, the path seems dark and foreboding, like whatever goes in there will never come out. To the right, the path is covered with spiky, low-hanging soda straws, but you can see something glowing in the distance … something bright. What fork would you like to embark upon?\nA: go left\nB: go right\n");
            //goto if user inputs invalid option
            Fork:
            //initialize input
            string Input = Console.ReadLine();
            //display storyline, go to game
            if (Input == "A" || Input == "a")
            {
                Console.WriteLine("\nYou’re not keen on getting stabbed today, so you choose the left path. It’s pitch black, and you can’t see where you’re going, but eventually find yourself in a giant cavern with a ceiling so high that you can’t see the end even if you crane your neck all the way back. Across from you is an enormous stalagmite, as wide as a house. He opens his eyes.\n\n“My name is Stalagmight,” he booms. “I feel you are here for my treasure … you are not the first one.” It is then that you notice the scattered bones and skulls around you. “But the only way you will make it out of here alive … is to best me in a timeless, fast - paced game based on skill, luck, and talent.”\n\nPlay rock paper scissors?\nY: yes\n");
                RPS();
            }
            //go to death scenario
            else if (Input == "B" || Input == "b")
            {
                EarlyDeath();
            }
            //go to game
            else if (Input == "RPS")
            {
                RPS();
            }
            //close console
            else if (Input == "X" || Input == "x")
            {
                Environment.Exit(0);
            }
            //send to beginning of if statement if input is invalid
            else
            {
                Console.WriteLine("\nPlease enter a valid option.");
                goto Fork;
            }
        }

        //early death cave ending
        public static void EarlyDeath()
        {
            StreamWriter sw = new StreamWriter("ImpalementCaveEnding.txt"); //will write to impalement cave ending file
            //display storyline, die
            Console.WriteLine("\nYou grow excited, thinking the light must be the treasure, and duck carefully into the right tunnel to avoid being stabbed by a stalactite. You pick up the pace at the prospect of discovering the treasure and being able to bring it back to your grandma. However, there is a sudden slope, and because you weren’t paying attention, you find yourself knocked off your feet and rolling deeper into the cave at an uncontrollable speed. You are impaled on a stalagmite and die.");
            //ask to replay or end game
            Console.WriteLine("\nGAME OVER\n\nPlay again?\nY: yes\nN: no");
            sw.WriteLine("GAME OVER, unfortunately the treasure will not be yours today. You finished with " + Luck + " Luck. Bad Cave Ending: Impalement unlocked."); //save bad ending to cave impalement ending file
            sw.Close(); //close streamwriter
            //goto if user inputs invalid option
            Replay:
            //initialize input
            string Input = Console.ReadLine();
            //go to beginning of program
            if (Input == "Y" || Input == "y")
            {
                Main(new[] { string.Empty });
            }
            //close console
            else if (Input == "N" || Input == "n")
            {
                Environment.Exit(0);
            }
            //send to beginning of if statement if input is invalid
            else
            {
                Console.WriteLine("Please enter a valid option.");
                goto Replay;
            }
        }

        //rock paper scissors decision
        public static void RPS()
        {
            //goto if user inputs invalid option
            Play:
            //initialize input
            string Input = Console.ReadLine();
            //if yes, check luck
            if (Input == "Y" || Input == "y")
            {
                //go to easy game if luck equal to or higher than 100
                if (Luck >= 100)
                {
                    GoodLuckRPS();
                }
                //go to hard game if luck too low
                else if (Luck < 100)
                {
                    BadLuckRPS();
                }
            }
            //send to beginning of if statement if input is invalid
            else
            {
                Console.WriteLine("\nYou must play.");
                Console.WriteLine("\nPlay rock paper scissors?\nY: yes\n");
                goto Play;
            }
        }

        //easy rock paper scissors game
        public static void GoodLuckRPS()
        {
            Console.WriteLine("\nThe game will be best out of three, Stalagmight proclaims.");
            //ask for move
            Console.WriteLine("\nWhat would you like to play?\nA: rock\nB: paper\nC: scissors\n");
            //initialize points for both players
            int StaPoints = 0;
            int UserPoints = 0;
            do
            {
                //generate random number for Stalagmight's play between one and three
                Random Randmove = new Random();
                int StaMove = Randmove.Next(1, 4);
                //DEBUG MODE display Stalagmight move
                Console.WriteLine("DEBUG NOTE: the following number will reveal Stalagmight's move. 1 = rock, 2 = paper, 3 = scissors.\n" + StaMove);
                //goto if user inputs invalid option
                Begin2:
                //initialize input
                string Input = Console.ReadLine();
                //rock and rock, draw, no points
                if (Input == "A" && StaMove == 1 || Input == "a" && StaMove == 1)
                {
                    Console.WriteLine("\nStalagmight played Rock! That's a draw!\n");
                }
                //rock and paper, Stalagmight gets a point
                else if (Input == "A" && StaMove == 2 || Input == "a" && StaMove == 2)
                {
                    Console.WriteLine("\nStalagmight played Paper! That's a point to Stalagmight!\n");
                    StaPoints++;
                }
                //rock and scissors, user gets a point
                else if (Input == "A" && StaMove == 3 || Input == "a" && StaMove == 3)
                {
                    Console.WriteLine("\nStalagmight played Scissors! That's a point to you!\n");
                    UserPoints++;
                }
                //paper and rock, user gets a point
                else if (Input == "B" && StaMove == 1 || Input == "b" && StaMove == 1)
                {
                    Console.WriteLine("\nStalagmight played Rock! That's a point to you!\n");
                    UserPoints++;
                }
                //paper and paper, draw, no points
                else if (Input == "B" && StaMove == 2 || Input == "b" && StaMove == 2)
                {
                    Console.WriteLine("\nStalagmight played Paper! That's a draw!\n");
                }
                //paper and scissors, Stalagmight gets a point
                else if (Input == "B" && StaMove == 3 || Input == "b" && StaMove == 3)
                {
                    Console.WriteLine("\nStalagmight played Scissors! That's a point to Stalagmight!\n");
                    StaPoints++;
                }
                //scissors and rock, Stalagmight gets a point
                else if (Input == "C" && StaMove == 1 || Input == "c" && StaMove == 1)
                {
                    Console.WriteLine("\nStalagmight played Rock! That's a point to Stalagmight!\n");
                    StaPoints++;
                }
                //scissors and paper, user gets a point
                else if (Input == "C" && StaMove == 2 || Input == "c" && StaMove == 2)
                {
                    Console.WriteLine("\nStalagmight played Paper! That's a point to you!\n");
                    UserPoints++;
                }
                //scissors and scissors, draw, no points
                else if (Input == "C" && StaMove == 3 || Input == "c" && StaMove == 3)
                {
                    Console.WriteLine("\nStalagmight played Scissors! That's a draw!\n");
                }
                //send to beginning of if statement if input is invalid
                else
                {
                    Console.WriteLine("\nPlease enter a valid option.\n");
                    goto Begin2;
                }
                //end loop when one player reaches two points
            } while (StaPoints < 2 && UserPoints < 2);
            //if user wins, good end
            if (UserPoints == 2)
            {
                CaveGoodEnd();
            }
            //if user loses, bad end
            else if (StaPoints == 2)
            {
                CaveBadEnd();
            }
        }

        //difficult rock paper scissors game
        public static void BadLuckRPS()
        {
            Console.WriteLine("\nThe game will be only one round, Stalagmight proclaims. He smirks confidently.");
            //ask for move
            Console.WriteLine("\nWhat would you like to play?\nA: rock\nB: paper\nC: scissors\n");
            //initialize user and Stalagmight points
            int StaPoints = 0;
            int UserPoints = 0;
            do
            {
                //generate random number for Stalagmight's play between one and three
                Random Randmove = new Random();
                int StaMove = Randmove.Next(1, 4);
                //DEBUG MODE display Stalagmight move
                Console.WriteLine("DEBUG NOTE: the following number will reveal Stalagmight's move. 1 = rock, 2 = paper, 3 = scissors.\n" + StaMove);
                //goto if user inputs invalid option
                Begin1:
                //initialize input
                string Input = Console.ReadLine();
                //rock and rock, draw, no points
                if (Input == "A" && StaMove == 1 || Input == "a" && StaMove == 1)
                {
                    Console.WriteLine("\nStalagmight played Rock! That's a draw!\n");
                }
                //rock and paper, Stalagmight gets a point
                else if (Input == "A" && StaMove == 2 || Input == "a" && StaMove == 2)
                {
                    Console.WriteLine("\nStalagmight played Paper! That's a point to Stalagmight!\n");
                    StaPoints++;
                }
                //rock and scissors, user gets a point
                else if (Input == "A" && StaMove == 3 || Input == "a" && StaMove == 3)
                {
                    Console.WriteLine("\nStalagmight played Scissors! That's a point to you!\n");
                    UserPoints++;
                }
                //paper and rock, user gets a point
                else if (Input == "B" && StaMove == 1 || Input == "b" && StaMove == 1)
                {
                    Console.WriteLine("\nStalagmight played Rock! That's a point to you!\n");
                    UserPoints++;
                }
                //paper and paper, draw, no points
                else if (Input == "B" && StaMove == 2 || Input == "b" && StaMove == 2)
                {
                    Console.WriteLine("\nStalagmight played Paper! That's a draw!\n");
                }
                //paper and scissors, Stalagmight gets a point
                else if (Input == "B" && StaMove == 3 || Input == "b" && StaMove == 3)
                {
                    Console.WriteLine("\nStalagmight played Scissors! That's a point to Stalagmight!\n");
                    StaPoints++;
                }
                //scissors and rock, Stalagmight gets a point
                else if (Input == "C" && StaMove == 1 || Input == "c" && StaMove == 1)
                {
                    Console.WriteLine("\nStalagmight played Rock! That's a point to Stalagmight!\n");
                    StaPoints++;
                }
                //scissors and paper, user gets a point
                else if (Input == "C" && StaMove == 2 || Input == "c" && StaMove == 2)
                {
                    Console.WriteLine("\nStalagmight played Paper! That's a point to you!\n");
                    UserPoints++;
                }
                //scissors and scissors, draw, no points
                else if (Input == "C" && StaMove == 3 || Input == "c" && StaMove == 3)
                {
                    Console.WriteLine("\nStalagmight played Scissors! That's a draw!\n");
                }
                //send to beginning of if statement if input is invalid
                else
                {
                    Console.WriteLine("\nPlease enter a valid option.\n");
                    goto Begin1;
                }
            } while (StaPoints < 1 && UserPoints < 1);
            //send to good ending if user wins
            if (UserPoints == 1)
            {
                CaveGoodEnd();
            }
            //send to bad ending if Stalagmight wins
            else if (StaPoints == 1)
            {
                CaveBadEnd();
            }
        }

        //cave good ending
        public static void CaveGoodEnd()
        {
            StreamWriter sw = new StreamWriter("CaveGoodEnd.txt"); //will write to cave good ending file
            //add 100 luck, display storyline and luck, ask to replay
            Luck += 100;
            Console.WriteLine("\nStalagmight roars in anger. “Year of academy training, wasted!” But he is powerless to stop you. He was powerless all along, actually, seeing as he’s attached to the ceiling. You decide not to think about it too hard, and dash around him to find an ornate chest, overflowing with glittering jewels of different colours. It’s too heavy to lift into your arms, and you resort to dragging it behind you as you exit the cavern. Now … How do you get out of here? +100 Luck.");
            Console.WriteLine("\nCongratulations! You retrieved the treasure and made it out with your life and " + Luck + " luck. Your grandma is very proud of you. However, there is still more treasure to be found. Would you like to play again?\nY: yes\nN: no");
            sw.WriteLine("Congratulations! You retrieved the treasure and made it out with your life and " + Luck + " luck. Your grandma is very proud of you. Good Cave Ending: Rock Paper Scissors Champion unlocked!"); //save ending to good cave ending file
            sw.Close(); //close streamwriter
            //goto if user inputs invalid option
            Replay:
            //initialize input
            string Input = Console.ReadLine();
            //send to beginning of program
            if (Input == "Y" || Input == "y")
            {
                Main(new[] { string.Empty });
            }
            //close console
            else if (Input == "N" || Input == "n")
            {
                Environment.Exit(0);
            }
            //send to beginning of if statement if input is invalid
            else
            {
                Console.WriteLine("Please enter a valid option.");
                goto Replay;
            }
        }

        //cave bad ending
        public static void CaveBadEnd()
        {
            StreamWriter sw = new StreamWriter("CaveBadEnd.txt"); //will write to cave bad ending file
            //die, ask user to replay
            Console.WriteLine("With a mad cackle, Stalagmight impales you. You die.");
            Console.WriteLine("\nGAME OVER\n\nPlay again?\nY: yes\nN: no\n");
            sw.WriteLine("GAME OVER, unfortunately the treasure will not be yours today. You finished with " + Luck + " Luck. Bad Cave Ending: Rock Paper Scissors Sucker unlocked."); //save ending to bad cave ending file
            sw.Close(); //close streamwriter
            //goto if user inputs invalid option
            Replay:
            //initialize input
            string Input = Console.ReadLine();
            //send to beginning of program
            if (Input == "Y" || Input == "y")
            {
                Main(new[] { string.Empty });
            }
            //close console
            else if (Input == "N" || Input == "n")
            {
                Environment.Exit(0);
            }
            //send to beginning of if statement if input is invalid
            else
            {
                Console.WriteLine("Please enter a valid option.");
                goto Replay;
            }
        }

        //desert storyline: written by Haniya
        public static void Desert()
        {
            StreamWriter sw = new StreamWriter("DesertEndings.txt"); //will write to desert endings file
            Console.Clear();//when they want to replay, it clears all their previous chocies and story text and restarts 
            //Luck point system
            int luck = 0; //every player starts off with 0 luck points and will play to gain/lose points. At the end it determines which ending they get, good bad or medium

            // choice #1: What will they use to travel to the desert
            Console.WriteLine("Throughout the game, Enter \"X\" to close the program."); //this tells them to enter x to close the game while playing
            //story text for choice 1, how do they want to travel
            Console.WriteLine("\nYou decide to travel to the desert. The desert you want to go to is really far away. It is also very hot! \nYou can either walk to the desert, go in a dune buggy, or hop on a plane and fly there. \nYou choose to go to the desert via _________ (insert the letter of your choice - A,B,or C).");
            //chocies they can pick from
            Console.WriteLine("A. legs\nB. Dune Buggy\nC. Plane");

            Console.WriteLine("\nDebugging: A. legs -50 points\nB. Dune Buggy +25 points\nC. Plane +75 points");

            while (true)//loops because if they enter in an invalid input it needs to loop and allow them to input again
            {
                Console.Write("\nOption: ");//this is what it will say and where they will input beside because it is write and not writeline so the input will be inputted beside it and not under
                string Choice1 = Console.ReadLine(); //Their first chocie is getting save into the variable Choice1 so whatever they input gets saved into it
                if (Choice1 == "A" || Choice1 == "a")//the if statemnet here runs whatever is in it IF the user chooses option a and inputs that into the Chocie1 variable
                {
                    luck -= 50;//choosing option 1 minuses 50 points from their luck points because it was not the right option
                    //story text, basically saying that that was a bad idea and why
                    Console.WriteLine("\nWalking there was a terrible idea! It took you weeks to arrive. You lost so much energy for \nyour journey already because of the long walk and the heat shining directly at you.\n-50 Luck Points.\nLuck = " + luck);
                    break; //this breaks the loop so that the program moves onto the next story text and options
                }
                else if (Choice1 == "B" || Choice1 == "b") //the is the else if statement part of the connecting if statemnet which runs whatever is in it IF the user chooses option b instead of a and inputs that into the Chocie1 variable, so the program skips the first if and reads this one instead
                {
                    luck += 25; //choosing option 2 (this option) adds 25 points to their luck points (to the luck variable) because it was a decent choice
                    //story text, basically saying that this was a decent idea and why
                    Console.WriteLine("\nRiding the dune buggy took you days to get to the desert! At least it was not as bad as walking there. \nHowever, the whole time you were losing patience of adventuring at the desert and finding the tresure. Now you're in a bad mood.\n+25 Luck Points.\nLuck = " + luck);
                    break; //this breaks the loop so that the program moves onto the next story text and options
                }
                else if (Choice1 == "C" || Choice1 == "c") //the is the else if statement part of the connecting if statemnet which runs whatever is in it IF the user chooses option c instead of a and b and inputs that into the Chocie1 variable, so the program skips the first if and the next else if and reads this one instead
                {
                    luck += 75; //choosing option 3 (this option) adds 75 points to their luck points (to the luck variable) because it was the best choice
                    //story text, basically saying that this was a good idea and why
                    Console.WriteLine("\nBy taking the plane, you got to the desert in a matter of just a few hours! \nNow you are fresh and ready to go on your adventure and maybe find some treasure at the end!\n+75 Luck Points.\nLuck = " + luck);
                    break; //this breaks the loop so that the program moves onto the next story text and options
                }
                else if (Choice1 == "x" || Choice1 == "X")
                {
                    //the is the else if statement part of the connecting if statemnet which runs whatever is in it (in this case the code is to exit out of the program) IF the user chooses none of the options and instead inputs x into the variable because they do not want to play anymore, so the program skips the first ifs and else ifs and reads this one instead
                    Environment.Exit(0);
                }
                else //if none of the else statment statments match the input it comes to this else statment and writes that it is an invalid input so they need to try again, and since there is a loop it loops up and lets them try again
                {
                    Console.WriteLine("Invalid input, try again");
                }
            }

            //to continue the game or to close the game if the user does not want to continue with the game.
            Console.WriteLine("\nEnter \"next\" to continue or \"X\" to close the game."); //just tells the user that they can either continue by entering next or close the game by entering x
            while (true) //a loop just incase they input a invalid input, it needs to loop and give them another try
            {
                string next1 = Console.ReadLine(); //this variable next1 will save what the user inputs in it and will be used to determine if it they want to continue, exit or if it is an invalid input
                if (next1 == "next" || next1 == "Next" || next1 == "NEXT")//this if stament will break the loop and continue on with the game, so it will move onto the code after the loop if the person inputs "next"
                {
                    break;//breaks the loop and help the program keep going
                }
                else if (next1 == "x" || next1 == "X") //this statement will run if they type "x" instead of "next" and the code in it will exit out of the console program so this helps user stop playing
                {
                    //the is the else if statement part of the connecting if statemnet which runs whatever is in it (in this case the code is to exit out of the program) IF the user chooses none of the options and instead inputs x into the variable because they do not want to play anymore, so the program skips the first ifs and else ifs and reads this one instead
                    Environment.Exit(0);//exits the console program (closes console screen)
                }
                else //if none of the else statment statments match the input it comes to this else statment and writes that it is an invalid input so they need to try again, and since there is a loop it loops up and lets them try again
                {
                    Console.WriteLine("Invalid input, try again"); //prints invalid input on the console screen for the user to see and try again
                }
            }//loop ends here

            Console.WriteLine("\nWhile you were travelling, you look over the map your grandma gave you, again and at the top it says \n“On your way, you will encounter 3 important numbers with ** on them, make sure to keep an eye out for \nthem and keep note of them in order of when you encounter them. You will need them if you reach the treasure.");

            //to continue the game or to close the game if the user does not want to continue with the game.
            Console.WriteLine("\nEnter \"next\" to continue or \"X\" to close the game."); //just tells the user that they can either continue by entering next or close the game by entering x
            while (true) //a loop just incase they input a invalid input, it needs to loop and give them another try
            {
                string next1 = Console.ReadLine(); //this variable next1 will save what the user inputs in it and will be used to determine if it they want to continue, exit or if it is an invalid input
                if (next1 == "next" || next1 == "Next" || next1 == "NEXT")//this if stament will break the loop and continue on with the game, so it will move onto the code after the loop if the person inputs "next"
                {
                    break;//breaks the loop and help the program keep going
                }
                else if (next1 == "x" || next1 == "X") //this statement will run if they type "x" instead of "next" and the code in it will exit out of the console program so this helps user stop playing
                {
                    //the is the else if statement part of the connecting if statemnet which runs whatever is in it (in this case the code is to exit out of the program) IF the user chooses none of the options and instead inputs x into the variable because they do not want to play anymore, so the program skips the first ifs and else ifs and reads this one instead
                    Environment.Exit(0);//exits the console program (closes console screen)
                }
                else //if none of the else statment statments match the input it comes to this else statment and writes that it is an invalid input so they need to try again, and since there is a loop it loops up and lets them try again
                {
                    Console.WriteLine("Invalid input, try again"); //prints invalid input on the console screen for the user to see and try again
                }
            }//loop ends here

            //story text: new input decision. Arrive at street market, what will they buy
            Console.WriteLine("\nSome bandits had stolen your bag with all your supplies you thought you needed as well as all your food! So before you start on your journey to the desert, you go to a street market to grab some things you think might be useful. You can buy four items with your luck points. What *4* or less items do you buy? Enter in the letter (A,B,C,D,E, and F).\n\nThe cost in points for each item is listed below:\nA. Rope - 10 luck\nB. Tent - 10 luck\nC. Bread - 5 luck\nD. Shoes - 5 luck\nE. Blanket - 5 luck\nF. Sunglasses - 10 luck");
            Console.WriteLine("\nIf you want to buy less than four items, enter \"none\" in replacement of inputting the letter of your item.");

            Console.WriteLine("\nDebugging: You should buy a,b, and c (rope, tent, bread)");

            string[] items = new string[4]; //stores what they want to buy in an array named items which will be used later
            ItemsReplay: //this helps the program let the users input the items again if they make a mistake in their inputs and enter an invalid input
            for (int i = 0; i < items.Length; i++)//this loops for 4 times allowing usser to enter in items 4 times.
            {
                Console.Write("\nItem #" + (i + 1) + ":"); //they will input their item chosen beside this text that will come up on console screen
                items[i] = Console.ReadLine();//reads their input and saves into the array (saving each input into a different items array element everytime it loops
                if (items[i] == "a" || items[i] == "A" || items[i] == "B" || items[i] == "b" || items[i] == "F" || items[i] == "f")
                {
                    //since specific items cost a specicfic amount, I grouped all the ones that cost 10 into this one, so that if the user inputs the letter for any of those options, 10 will be subtracted from their luck
                    luck -= 10; //subtracting the 10 luck
                    Console.WriteLine(items[i] + ": -10 luck"); //telling them how much they lost for that item
                }
                else if (items[i] == "c" || items[i] == "C" || items[i] == "D" || items[i] == "d" || items[i] == "E" || items[i] == "e")
                {
                    //since specific items cost a specicfic amount, I grouped all the ones that cost 5 into this one, so that if the user inputs the letter for any of these options instead of the other ones in this loop round, 5 will be subtracted from their luck
                    luck -= 5; //sutracting 5 from the luck variable
                    Console.WriteLine(items[i] + ": -5 luck"); //telling them how much they lost for buying that item
                }
                else if (items[i] == "none" || items[i] == "None" || items[i] == "NONE" || items[i] == "NOne" || items[i] == "NONe" || items[i] == "nOne" || items[i] == "nONe" || items[i] == "nONE" || items[i] == "noNE" || items[i] == "nonE")
                {
                    //since they have a choice of not buying, they have to input "none" instad so this else if statment will catch that and the other ones will be skipped 
                    luck = luck; //if they do not buy anything their luck points will stay the same 
                }
                else if (items[i] == "x" || items[i] == "X")
                {
                    //the is the else if statement part of the connecting if statemnet which runs whatever is in it (in this case the code is to exit out of the program) IF the user chooses none of the options and instead inputs x into the variable because they do not want to play anymore, so the program skips the first ifs and else ifs and reads this one instead
                    Environment.Exit(0);
                }
                else //if none of the else statment statments match the input it comes to this else statment and writes that it is an invalid input so they need to try again, and since there is a loop it loops up and lets them try again
                {
                    Console.WriteLine("Invalid input, try inputting your items again. Make sure to input the letters of the options, or \"none\".");
                    goto ItemsReplay; //this connects back up allowing user to reinput the items again because they put a wrong type of input in one
                }
            }

            Console.WriteLine("Total Luck = " + luck);

            //to continue the game or to close the game if the user does not want to continue with the game.
            Console.WriteLine("\nEnter \"next\" to continue or \"X\" to close the game."); //just tells the user that they can either continue by entering next or close the game by entering x
            while (true) //a loop just incase they input a invalid input, it needs to loop and give them another try
            {
                string next1 = Console.ReadLine(); //this variable next1 will save what the user inputs in it and will be used to determine if it they want to continue, exit or if it is an invalid input
                if (next1 == "next" || next1 == "Next" || next1 == "NEXT")//this if stament will break the loop and continue on with the game, so it will move onto the code after the loop if the person inputs "next"
                {
                    break;//breaks the loop and help the program keep going
                }
                else if (next1 == "x" || next1 == "X") //this statement will run if they type "x" instead of "next" and the code in it will exit out of the console program so this helps user stop playing
                {
                    //the is the else if statement part of the connecting if statemnet which runs whatever is in it (in this case the code is to exit out of the program) IF the user chooses none of the options and instead inputs x into the variable because they do not want to play anymore, so the program skips the first ifs and else ifs and reads this one instead
                    Environment.Exit(0);//exits the console program (closes console screen)
                }
                else //if none of the else statment statments match the input it comes to this else statment and writes that it is an invalid input so they need to try again, and since there is a loop it loops up and lets them try again
                {
                    Console.WriteLine("Invalid input, try again"); //prints invalid input on the console screen for the user to see and try again
                }
            }//loop ends here

            //story text: explaining and then riddle about egypt
            Console.WriteLine("\nYou arrive at the desert in Egypt. You don’t know what to do now. However, you suddenly see that the map is glowing and there are new words on it that weren’t there before. The words read as the following:");
            Console.WriteLine("\n\"I reach towards the heavens\nWith my base flat, and my top pointy\nI hold the treasure within\nI've watched as nations rise and fall\nThroughout many ages\nSturdy, rock, through it all\"");
            Console.WriteLine("\nThe text is giving you the answer of where to head in riddle form! So, where are you heading next?");

            Console.WriteLine("\nDebugging: answer is \"pyramids\"");

            //riddle answering part of the story
            string ans = null; //declaring variable before the loop so it can be used outside if needed too
            do//using do while loop to show that I do know how to use it. I used do while here because I know the loop has to check it once either way so it has to go in which reaching the security check first
            { //the loop is so that they can keep trying to get the right answer until they do and then it will break because that code is under that if statemnt
                ans = Console.ReadLine(); //their input saves into variable ans
                if (ans.Equals("pyramids") || ans.Equals("Pyramids") || ans.Equals("pyramid") || ans.Equals("Pyramid") || ans.Equals("PYRAMIDS") || ans.Equals("PYRAMID"))
                { //if they input the right answer, which is pyramids the code under this if statment will run 
                    Console.WriteLine("You Got it! Let's start our journey towards the Pyramids."); // it will tell them they got it
                    break; //and then it will break out of the loop because they already got it right so no need to keep guessing.
                }
                else if (ans == "x" || ans == "X")
                {
                    //the is the else if statement part of the connecting if statemnet which runs whatever is in it (in this case the code is to exit out of the program) IF the user chooses none of the options and instead inputs x into the variable because they do not want to play anymore, so the program skips the first ifs and else ifs and reads this one instead
                    Environment.Exit(0);//exits out of the console program, closes screen
                }
                else //if none of the else statment statments match the input it comes to this else statment (so if input is wrong answer to the riddle) and writes that that is not the right answer so they need to try again, and since there is a loop it loops up and lets them try again
                {
                    luck = luck - 5; //every time they get it wrong, 5 luck points are subtracted from their luck variable (luck score)
                    Console.WriteLine("-5 Luck"); //telling them they lost points
                    //telling them that its the wrong answer, and to try again
                    Console.WriteLine("That is not the right answer, try again. Hint: The answer to the riddle is a location that Egypt is widely known for.");
                }
            }
            while (true); //end of the do while loop. The statement inside it is whever it is true which it always is in this case so it loops on forever until there is a break or something else in the code to stop that. 

            Console.WriteLine("\nTotal Luck = " + luck); //displaying total luck they have so far

            //choice #2
            //story text: about a log
            Console.WriteLine("\nOn your way to the Pyramids, you trip over a log with *5* thorns on it. Do you:\nA. Pick it up because it might be useful later on or\nB. Do you think it’ll weigh you down for your long journey so you leave it?");

            Console.WriteLine("\nDebugging: A. Pick it up +50 points\nB. Leave it -50 points");

            while (true)//loops because if they enter in an invalid input it needs to loop and allow them to input again
            {
                Console.Write("\nOption: "); //they will input their choice beside this text (thats why it is write and not writeline so that their input can come beside and not on the next line)
                string Choice2 = Console.ReadLine(); //this reads the users input for their second choice and stores it into the Choice2 variable
                if (Choice2 == "A" || Choice2 == "a")
                {
                    //the if statemnet here runs whatever is in it IF the user chooses option a and inputs that into the Chocie2 variable
                    luck += 50; //choosing option 1 adds 50 points to their luck points because it was the better option of the two
                    //story text, basically saying that it was a good idea and why
                    Console.WriteLine("\nGood Choice because soon after you decided to pick up the log, a snake had come and tried to attack you. At first you were worried but then you remembered you had picked up the log. So you take it and throw it at the snake, disableing the snake for enough time for you to run away.\n+50 Luck points\n\nLuck = " + luck);
                    break; //this breaks the loop so that the program moves onto the next story text and options
                }
                else if (Choice2 == "B" || Choice2 == "b")
                {
                    //this else if statemnet here runs whatever is in it IF the user chooses option b instead of a and inputs that into the Chocie2 variable, so it skips the previous if statemnt code and reads what is in this one
                    luck -= 50; //choosing option 2 (this option) subtracts 50 points from their luck points because it was the wrong option between the two
                    //story text, basically saying that it was a bad idea and why
                    Console.WriteLine("\nOh no! Soon after you tripped on the log and decided to leave it, a snake had come and tried to attack you. You had no weapon to hit it with. The log would've been really helpful in this case. The snake bit your ankle and you only have 24 hours to get to a hospital or else you will die. You better hurry up on your journey!\n-50 Luck Points\n\nLuck = " + luck);
                    break; //this breaks the loop so that the program moves onto the next story text and options
                }
                else if (Choice2 == "x" || Choice2 == "X")
                {
                    //the is the else if statement part of the connecting if statemnet which runs whatever is in it (in this case the code is to exit out of the program) IF the user chooses none of the options and instead inputs x into the variable because they do not want to play anymore, so the program skips the first ifs and else ifs and reads this one instead
                    Environment.Exit(0); //closes console screen
                }
                else //if none of the else statment statments match the input it comes to this else statment and writes that it is an invalid input so they need to try again, and since there is a loop it loops up and lets them try again
                {
                    Console.WriteLine("Invalid input, try again");
                }
            }//end of loop

            //to continue the game or to close the game if the user does not want to continue with the game.
            Console.WriteLine("\nEnter \"next\" to continue or \"X\" to close the game."); //just tells the user that they can either continue by entering next or close the game by entering x
            while (true) //a loop just incase they input a invalid input, it needs to loop and give them another try
            {
                string next1 = Console.ReadLine(); //this variable next1 will save what the user inputs in it and will be used to determine if it they want to continue, exit or if it is an invalid input
                if (next1 == "next" || next1 == "Next" || next1 == "NEXT")//this if stament will break the loop and continue on with the game, so it will move onto the code after the loop if the person inputs "next"
                {
                    break;//breaks the loop and help the program keep going
                }
                else if (next1 == "x" || next1 == "X") //this statement will run if they type "x" instead of "next" and the code in it will exit out of the console program so this helps user stop playing
                {
                    //the is the else if statement part of the connecting if statemnet which runs whatever is in it (in this case the code is to exit out of the program) IF the user chooses none of the options and instead inputs x into the variable because they do not want to play anymore, so the program skips the first ifs and else ifs and reads this one instead
                    Environment.Exit(0);//exits the console program (closes console screen)
                }
                else //if none of the else statment statments match the input it comes to this else statment and writes that it is an invalid input so they need to try again, and since there is a loop it loops up and lets them try again
                {
                    Console.WriteLine("Invalid input, try again"); //prints invalid input on the console screen for the user to see and try again
                }
            }//loop ends here

            //story text: camel herd decision and listing options
            Console.WriteLine("\nWhat's that rumbling sound!? There's a camel herd stampeding by. Do you...\nA. get on one of the camels so that you can ride it to your destination and make it easier for yourself or\nB. Wait for the herd to pass by completely and then keep walking or\nC. Do you run towards them and try to get through the herd because they are taking too long to pass by.");

            Console.WriteLine("\nDebugging: A. get on camel -25 points\nB. wait +25 points\nC. run at them (game ends, you die)");

            //choice #3: camel herd
            while (true) //loops because if they enter in an invalid input it needs to loop and allow them to input again
            {
                Console.Write("\nOption: "); //they will input their choice beside this text (thats why it is write and not writeline so that their input can come beside and not on the next line)
                string Choice3 = Console.ReadLine(); //this reads the users input for their third choice and stores it into the Choice3 variable
                if (Choice3 == "A" || Choice3 == "a")
                {
                    //the if statemnet here runs whatever is in it IF the user chooses option a and inputs that into the Chocie3 variable
                    luck -= 25; //choosing option 1 subtracts 25 points from their luck points because they chose the bad option of the three
                    //story text, basically saying that it was a bad idea and why
                    Console.WriteLine("\nThat's now good. The camel you got on kept going with its herd in the wrong direction and away from the pyramids. You realized after a while but by that time you were so far away. It takes you very long to get back in the right way and you're running out of time!\n-25 Luck Points.\n\nLuck = " + luck);
                    break; //this breaks the loop so that the program moves onto the next story text and options
                }
                else if (Choice3 == "B" || Choice3 == "b")
                {
                    //the else if statemnet here runs whatever is in it IF the user chooses option b instead of a and inputs that into the Chocie3 variable so it skips previos if and runs whatever is under this one
                    luck += 25; //choosing option 2 adds 25 points to their luck points because they chose the best option of the three
                    //story text, basically saying that it was a good idea and why
                    Console.WriteLine("\nThat was the best choice, because the camels were all going in the wrong direction, away from the pyramids so if you had gotten on one, you would be going furnther from the pyramids. You also dont know how to control/ride a camel so you would've fallen!\n+25 Luck Points.\n\nLuck = " + luck);
                    break; //this breaks the loop so that the program moves onto the next story text and options
                }
                else if (Choice3 == "C" || Choice3 == "c")
                {
                    //the else if statemnet here runs whatever is in it IF the user chooses option c instead of a and b and inputs that into the Chocie3 variable so it skips previos ifs and runs whatever is under this one
                    Console.WriteLine("YOU DIED\n\nEND GAME"); //tells them that by choosing option c, they already died in the game.
                    sw.WriteLine("GAME OVER, unfortunately the treasure will not be yours today. You finished with " + luck + " Luck. Bad Desert Ending: Camelprint unlocked."); //save bad ending to desert endings file
                    sw.Close(); //close streamwriter
                    goto EndGame; //this takes them to the connecting EndGame: at the bottom which asks them if they want to replay or not basically
                }
                else if (Choice3 == "x" || Choice3 == "X")
                {
                    //the is the else if statement part of the connecting if statemnet which runs whatever is in it (in this case the code is to exit out of the program) IF the user chooses none of the options and instead inputs x into the variable because they do not want to play anymore, so the program skips the first ifs and else ifs and reads this one instead
                    Environment.Exit(0);//closes console screen
                }
                else //if none of the else statment statments match the input it comes to this else statment and writes that it is an invalid input so they need to try again, and since there is a loop it loops up and lets them try again
                {
                    Console.WriteLine("Invalid input, try again");
                }
            }

            //to continue the game or to close the game if the user does not want to continue with the game.
            Console.WriteLine("\nEnter \"next\" to continue or \"X\" to close the game."); //just tells the user that they can either continue by entering next or close the game by entering x
            while (true) //a loop just incase they input a invalid input, it needs to loop and give them another try
            {
                string next1 = Console.ReadLine(); //this variable next1 will save what the user inputs in it and will be used to determine if it they want to continue, exit or if it is an invalid input
                if (next1 == "next" || next1 == "Next" || next1 == "NEXT")//this if stament will break the loop and continue on with the game, so it will move onto the code after the loop if the person inputs "next"
                {
                    break;//breaks the loop and help the program keep going
                }
                else if (next1 == "x" || next1 == "X") //this statement will run if they type "x" instead of "next" and the code in it will exit out of the console program so this helps user stop playing
                {
                    //the is the else if statement part of the connecting if statemnet which runs whatever is in it (in this case the code is to exit out of the program) IF the user chooses none of the options and instead inputs x into the variable because they do not want to play anymore, so the program skips the first ifs and else ifs and reads this one instead
                    Environment.Exit(0);//exits the console program (closes console screen)
                }
                else //if none of the else statment statments match the input it comes to this else statment and writes that it is an invalid input so they need to try again, and since there is a loop it loops up and lets them try again
                {
                    Console.WriteLine("Invalid input, try again"); //prints invalid input on the console screen for the user to see and try again
                }
            }//loop ends here

            //story text: stuck in sandstorm
            Console.Write("\nIt's been hours now and suddenly you're stuck in sandstorm! Oh no!");
            //this brings back the items array we made when they bought a few items 
            //it is recalling if in the array, option b is there (meanign if they bought what was in option b or not which was the tent) because they need the tent for the sand storm
            if (items[0] == "b" || items[0] == "B" || items[1] == "b" || items[1] == "B" || items[2] == "b" || items[2] == "B" || items[3] == "b" || items[3] == "B")
            {   //this if stament is checking if b is in any of the 4 elements of the items array, and if there is, it runs this code.
                luck = luck + 50; //they get 50 points added because they safely get through the storm due to the tend
                //story text just saying why buying the tent was good for them
                Console.Write("Thankgod you had bought the tent in the beginning before starting on your journey. It was very helpful and you get through it with no harm.\n+50 Luck points\n\nLuck = " + luck);
            }
            else
            {
                //this else stament runs this code when b is not in the array.
                luck = luck - 25; //25 points subtracted from their luck points because they got sick from sand storm and did not buy a tent
                //story text just saying why not buying the tent was bad for them
                Console.Write("You had no where to hide from the storm so you got sick from all the sand.\n-25 Luck points\n\nLuck = " + luck);
            }
            //story text
            Console.WriteLine("\nThat sandstorm really tuckered you out so you take a quick nap there after the sandstorm to refresh.");

            //to continue the game or to close the game if the user does not want to continue with the game.
            Console.WriteLine("\nEnter \"next\" to continue or \"X\" to close the game."); //just tells the user that they can either continue by entering next or close the game by entering x
            while (true) //a loop just incase they input a invalid input, it needs to loop and give them another try
            {
                string next1 = Console.ReadLine(); //this variable next1 will save what the user inputs in it and will be used to determine if it they want to continue, exit or if it is an invalid input
                if (next1 == "next" || next1 == "Next" || next1 == "NEXT")//this if stament will break the loop and continue on with the game, so it will move onto the code after the loop if the person inputs "next"
                {
                    break;//breaks the loop and help the program keep going
                }
                else if (next1 == "x" || next1 == "X") //this statement will run if they type "x" instead of "next" and the code in it will exit out of the console program so this helps user stop playing
                {
                    //the is the else if statement part of the connecting if statemnet which runs whatever is in it (in this case the code is to exit out of the program) IF the user chooses none of the options and instead inputs x into the variable because they do not want to play anymore, so the program skips the first ifs and else ifs and reads this one instead
                    Environment.Exit(0);//exits the console program (closes console screen)
                }
                else //if none of the else statment statments match the input it comes to this else statment and writes that it is an invalid input so they need to try again, and since there is a loop it loops up and lets them try again
                {
                    Console.WriteLine("Invalid input, try again"); //prints invalid input on the console screen for the user to see and try again
                }
            }//loop ends here

            //story text: user is hungry now
            Console.Write("\nIts been quite a journey, especially with the unexpected sandstorm. You wake up really hungry.");
            //this brings back the items array we made when they bought a few items 
            //it is recalling if in the array, option c is there (meanign if they bought what was in option c or not which was the bread) because they need something to eat since they are hungry
            if (items[0] == "c" || items[0] == "C" || items[1] == "c" || items[1] == "C" || items[2] == "c" || items[2] == "C" || items[3] == "c" || items[3] == "C")
            {
                //this if stament is checking if c is in any of the 4 elements of the items array, and if there is, it runs this code.
                luck = luck + 25; //they get 25 points added because they have some bread and will not be very hungry anymore
                //story text just saying why buying the bread was good for them
                Console.WriteLine("You have the bread you had bought at the marketplace in the beginning as well! You devour the whole loaf because that's all you had to eat. At least now you can start up on your journey again with some energy, however, the bread made you thristy.\n+25 Luck points\n\nLuck = " + luck);
            }
            else
            {
                //this else stament runs this code when c is not in the array.
                luck = luck - 25; //25 points subtracted from their luck points because they got sick from not eating anything in so long
                //story text just saying why not buying the bread was bad for them
                Console.WriteLine("Unfortunately, your bag with all your food had gotten stolen before you had even started. You also did not buy anything to eat from the street market.\n-25 Luck points\nYou look around to see if you can find anything to drink.\n\nLuck = " + luck);
            }

            //to continue the game or to close the game if the user does not want to continue with the game.
            Console.WriteLine("\nEnter \"next\" to continue or \"X\" to close the game."); //just tells the user that they can either continue by entering next or close the game by entering x
            while (true) //a loop just incase they input a invalid input, it needs to loop and give them another try
            {
                string next1 = Console.ReadLine(); //this variable next1 will save what the user inputs in it and will be used to determine if it they want to continue, exit or if it is an invalid input
                if (next1 == "next" || next1 == "Next" || next1 == "NEXT")//this if stament will break the loop and continue on with the game, so it will move onto the code after the loop if the person inputs "next"
                {
                    break;//breaks the loop and help the program keep going
                }
                else if (next1 == "x" || next1 == "X") //this statement will run if they type "x" instead of "next" and the code in it will exit out of the console program so this helps user stop playing
                {
                    //the is the else if statement part of the connecting if statemnet which runs whatever is in it (in this case the code is to exit out of the program) IF the user chooses none of the options and instead inputs x into the variable because they do not want to play anymore, so the program skips the first ifs and else ifs and reads this one instead
                    Environment.Exit(0);//exits the console program (closes console screen)
                }
                else //if none of the else statment statments match the input it comes to this else statment and writes that it is an invalid input so they need to try again, and since there is a loop it loops up and lets them try again
                {
                    Console.WriteLine("Invalid input, try again"); //prints invalid input on the console screen for the user to see and try again
                }
            }//loop ends here

            //choice #4
            //story text: water well
            Console.WriteLine("Through some miracle, there is a Water well close by. Do you want to...\nA. go to it and get some water or\nB. do you want to keep going and not waste anymore time.");

            Console.WriteLine("\nDebugging: A. go to water well +25 points\nB. leave -25 points");

            while (true) //loops because if they enter in an invalid input it needs to loop and allow them to input again
            {
                Console.Write("\nOption: "); //they will input their choice beside this text (thats why it is write and not writeline so that their input can come beside and not on the next line)
                string Choice4 = Console.ReadLine(); //this reads the users input for their fourth choice and stores it into the Choice4 variable
                if (Choice4 == "A" || Choice4 == "a")
                {
                    //the if statemnet here runs whatever is in it IF the user chooses option a and inputs that into the Chocie4 variable
                    luck += 25; //choosing option 1 adds 25 points to their luck points because they chose the right option
                    Console.WriteLine("\n+25 Luck points\n\nLuck = " + luck); //telling user how much they gained and what total luck is now
                    //story text, basically saying that it was a good idea and why
                    Console.Write("\nYou run towards the well. But OH NO! Theres no rope on the bucket that you send down to get the water!");

                    //this is a nested if statement in the other if statement
                    // this brings back the items array we made when they bought a few items
                    //it is recalling if in the array, option a is there (meaning if they bought what was in option a or not which was the rope) because they need it to get the bucket in and get water out
                    if (items[0] == "a" || items[0] == "A" || items[1] == "a" || items[1] == "A" || items[2] == "a" || items[2] == "A" || items[3] == "a" || items[3] == "A")
                    {
                        //this if stament is checking if c is in any of the 4 elements of the items array, and if there is, it runs this code.
                        luck = luck + 25; //they get 25 points added because they havea a rope and can get the water from the well to refresh themselves
                        //story text just saying why buying the rope was good for them
                        Console.WriteLine("Luckily you had bought rope at the marketplace just incase you needed it on the adventure. Turns out, you did need it after all. So you grab the rope and tie it to the bucket and get some water!\n+25 Luck points\n\nLuck = " + luck);
                    }
                    else
                    {
                        //this else stament runs this code when a is not in the array.
                        luck = luck - 25; //25 points subtracted from their luck points because they are very dehydrated now
                        //story text just saying why not buying the rope was bad for them
                        Console.WriteLine("That's too bad. You can't have any water.\n-25 Luck points\n\nLuck = " + luck);
                    }
                    break; //this breaks the loop so that the program moves onto the next story text and options
                }
                else if (Choice4 == "B" || Choice4 == "b")
                {
                    //the else if statemnet here runs whatever is in it IF the user chooses option b instead of a and inputs that into the Chocie4 variable
                    luck -= 25; //choosing option 2 subtracts 25 points from their luck points because they chose the wrong option
                    //story text, basically saying that it was a bad idea and why
                    Console.WriteLine("\n You keep going, not even trying to see if there was water in there you could've had, even though you were really thirsty.\n-25 Luck Points\n\nLuck = " + luck);
                    break; //this breaks the loop so that the program moves onto the next story text and options
                }
                else if (Choice4 == "x" || Choice4 == "X")
                {
                    //the is the else if statement part of the connecting if statemnet which runs whatever is in it (in this case the code is to exit out of the program) IF the user chooses none of the options and instead inputs x into the variable because they do not want to play anymore, so the program skips the first ifs and else ifs and reads this one instead
                    Environment.Exit(0); //closes console screen
                }
                else //if none of the else statment statments match the input it comes to this else statment and writes that it is an invalid input so they need to try again, and since there is a loop it loops up and lets them try again
                {
                    Console.WriteLine("Invalid input, try again");
                }
            } //loop ends

            //to continue the game or to close the game if the user does not want to continue with the game.
            Console.WriteLine("\nEnter \"next\" to continue or \"X\" to close the game."); //just tells the user that they can either continue by entering next or close the game by entering x
            while (true) //a loop just incase they input a invalid input, it needs to loop and give them another try
            {
                string next1 = Console.ReadLine(); //this variable next1 will save what the user inputs in it and will be used to determine if it they want to continue, exit or if it is an invalid input
                if (next1 == "next" || next1 == "Next" || next1 == "NEXT")//this if stament will break the loop and continue on with the game, so it will move onto the code after the loop if the person inputs "next"
                {
                    break;//breaks the loop and help the program keep going
                }
                else if (next1 == "x" || next1 == "X") //this statement will run if they type "x" instead of "next" and the code in it will exit out of the console program so this helps user stop playing
                {
                    //the is the else if statement part of the connecting if statemnet which runs whatever is in it (in this case the code is to exit out of the program) IF the user chooses none of the options and instead inputs x into the variable because they do not want to play anymore, so the program skips the first ifs and else ifs and reads this one instead
                    Environment.Exit(0);//exits the console program (closes console screen)
                }
                else //if none of the else statment statments match the input it comes to this else statment and writes that it is an invalid input so they need to try again, and since there is a loop it loops up and lets them try again
                {
                    Console.WriteLine("Invalid input, try again"); //prints invalid input on the console screen for the user to see and try again
                }
            }//loop ends here

            //choice #5
            //story text: there are three pyramids to choose from
            Console.WriteLine("\nThere are *3* pyramids where the treasure could be, one, two, or three. Which pyramid are you going into? (Type in the number you choose as a word)");

            Console.WriteLine("\nDebugging: one (takes you to play a math game)\n two (takes you to play a pattern game)\n three (takes you to play an unscrambling game)");

            while (true) //loops because if they enter in an invalid input it needs to loop and allow them to input again
            {
                Console.Write("\nNumber: "); //they will input their choice beside this text (thats why it is write and not writeline so that their input can come beside and not on the next line)
                //this reads the users input for their next choice and stores it into the Choice4 variable
                string Choice4 = Console.ReadLine();
                if (Choice4 == "one" || Choice4 == "One" || Choice4 == "ONE")
                {
                    //the if statemnet here runs whatever is in it IF the user chooses pyramid one and inputs that into the Chocie4 variable
                    Console.WriteLine("\n\n");
                    //this makes the shape that will be needed for this final game for pyramid 1 (makes a right angle triangle with two side values and one missing)
                    Console.WriteLine("          | *\n          |    *\n          |       *\n       3.5|          *  5\n          |             *\n          |__              *\n          |__|________________*_\n                     b");
                    //giving them the 3 equations options they can choose from
                    Console.WriteLine("Equation #1: c ^ 2 = a ^ 2 + b ^ 2\nEquation #2: c = SquareRoot(a ^ 2 + b ^ 2 - 2abcos(0.79))\nEquation #3: c = ½(ba)");
                    //story text explaining the game
                    Console.WriteLine("\nWhen you aproach the entrance of the pyramid, there is this triangle on the entrance door with 2 numbers carved into the door but one is missing (b). If you can input the right value for the missing number (b), the entrance gate will open. However, if you cannot get the right value in 2 tries, the trap door opens beneath you and you die. You are given three equations above. Only one of those equations is the right one to get the right value for the missing number. You will also have to input the right numbers into the right variables.");

                    Console.WriteLine("\nWhat Equation do you think you are supposed to use with the values given to find the missing value? (enter in the number of the equation in word form)");

                    Console.WriteLine("\nDebugging: Equation 1 (pythagorean therom) is right");

                    for (int i = 0; i < 2; i++) //since they only have 2 tries to get it right, this is a loop that will only run two times
                    {
                        Equations: //this is the line of code it comes back to if said goto Equations;
                                   //this is needed because we need to come back here and ask them to input again if the user inputs an invalid input and the for loop was not working because it only let them try again twice and then even if it was wrong it would still continue with the game which was wrong
                        Console.Write("\nEquation Number: "); //they will input their choice beside this text (thats why it is write and not writeline so that their input can come beside and not on the next line)
                        string Choice5 = Console.ReadLine(); //this reads the users input for their next choice and stores it into the Choice5 variable
                                                             //choice of which equation to choose
                        if (Choice5 == "one" || Choice5 == "One" || Choice5 == "ONE")
                        {
                            //if they choose equation one and input that into the input, the code in this if statement will run
                            //if they type in equation one on the first try the code in this if statement will run
                            if (i == 0)
                            {
                                luck += 75; //get 75 more points
                                Console.WriteLine("\nYES! You got it right!\n+75 Luck Points"); //telling them they got it right and telling them how much points they got
                                Console.WriteLine("Luck = " + luck); //displaying they total luck points right now
                                break; //break the loop so that they can continue on with what is next and not loop again and not ask them to input again when they already got it right
                            }
                            //if they type in equation one on the second try, the code in this else if statement will run
                            else if (i == 1)
                            {
                                luck += 50; //get 50 more points
                                Console.WriteLine("\nYES! You got it right!\n+50 Luck Points"); //telling them they got it right and telling them how much points they got
                                Console.WriteLine("Luck = " + luck); //displaying their total luck points right now
                                break; //break the loop so that they can continue on with what is next and not loop again and not ask them to input again when they already got it right
                            }
                        }
                        else if (Choice5 == "two" || Choice5 == "TWO" || Choice5 == "Two")
                        {
                            //if they choose equation two and input that into the input, the code in this if statement will run and not the previous one
                            //if they type in equation two on the first try the code in this if statement will run, since two is the wrong answer it will let them retry for the first time they get it wrong
                            if (i == 0)
                            {
                                luck -= 50; //lose 50 luck points
                                Console.WriteLine("\n-50 Luck Points\nThat was the wrong equation, last try."); //since two is the wrong answer it will let them retry for the first time they get it wrong
                                Console.WriteLine("Luck = " + luck); //displaying their total luck points right now
                            }
                            //if they type in equation two on the second try, the code in this else if statement will run and it will end the game because they lost their 2 lives
                            else if (i == 1)
                            {
                                //story text
                                Console.WriteLine("\nYOU DIED\nThe trap door opened instantly and you fell into the ground never to be heard from again\n\nEND GAME");
                                sw.WriteLine("GAME OVER, unfortunately the treasure will not be yours today. You finished with " + luck + " Luck. Bad Desert Ending: Equation't unlocked."); //save bad ending to desert endings file
                                sw.Close(); //close streamwriter
                                goto EndGame; //this takes them to the connecting EndGame: at the bottom which asks them if they want to replay or not basically
                            }
                        }
                        else if (Choice5 == "three" || Choice5 == "Three" || Choice5 == "THREE")
                        {
                            //if they choose equation three and input that into the input, the code in this if statement will run and not the previous ones
                            //if they type in equation three on the first try the code in this if statement will run, since three is the wrong answer it will let them retry for the first time they get it wrong
                            if (i == 0)
                            {
                                luck -= 50; //lose 50 luck points
                                Console.WriteLine("\n-50 Luck Points\nThat was the wrong equation, last try."); //since three is the wrong answer it will let them retry for the first time they get it wrong
                                Console.WriteLine("Luck = " + luck); //displaying their total luck points right now

                            }
                            //if they type in equation three on the second try, the code in this else if statement will run and it will end the game because they lost their 2 lives
                            else if (i == 1)
                            {
                                //story text
                                Console.WriteLine("\nYOU DIED\nThe trap door opened instantly and you fell into the ground never to be heard from again\n\nEND GAME");
                                sw.WriteLine("GAME OVER, unfortunately the treasure will not be yours today. You finished with " + luck + " Luck. Bad Desert Ending: Equation't Pt 2 unlocked."); //save bad ending to desert endings file
                                sw.Close(); //close streamwriter
                                goto EndGame; //this takes them to the connecting EndGame: at the bottom which asks them if they want to replay or not basically
                            }
                        }
                        else if (Choice5 == "x" || Choice5 == "X")
                        {
                            //the is the else if statement part of the connecting if statemnet which runs whatever is in it (in this case the code is to exit out of the program) IF the user chooses none of the options and instead inputs x into the variable because they do not want to play anymore, so the program skips the first ifs and else ifs and reads this one instead
                            Environment.Exit(0);
                        }
                        else //if none of the else statment statments match the input it comes to this else statment and writes that it is an invalid input so they need to try again, and since there is a loop it loops up and lets them try again
                        {
                            Console.WriteLine("Invalid input, try again");
                            goto Equations; //connects with the Equations: at the top of this if statment and goes back to it
                        }
                    }//for loop ends

                    //story text
                    Console.WriteLine("Now You have to determine which values from above go into which variable.");

                    Console.WriteLine("\nDebugging: input for variable a = 3.5 and input for variable c = 5 so missing value should be 3.57");

                    while (true) //loop for the try catch so if it catches an error it comes back and tells them to do it again
                    {
                        try //holds the code that we are looking for errors in
                        {
                            //making of the variable for variable a
                            Console.Write("Variable \"a\" = "); //this shows "Variable "a" = " on the console screen directing the users to enter in their first value (value a) of their chosen triangle. The next line of code allows them to input their value right next to this line of text because I used Write instead of WriteLine
                            string varA1 = Console.ReadLine(); //this allows the user to input their first value (var a which should be 3.5) right next to the line saying "Variable "a" = " and then it stores that value into the string variable named varA1 which can be used in the program representing the A variable. 
                            double varA = double.Parse(varA1); //this converts the inputted string value into a double (decimal) value so that the value can be properly used as numbers in the formula and so the calculation will perform properly. We also need to make it a decimal value because the answers can be in decimal and integer which is why double is the best data type 
                                                               //so now the input value for variable A which was stored into a variable named varA1 is now saved into a variable named varA

                            //making of the variable for variable c
                            Console.Write("Variable \"c\" = ");//this shows "Variable "c" = " on the console screen directing the users to enter in their second value. The next line of code allows them to input their value right next to this line of text because I used Write instead of WriteLine like I did for the previous input.
                            string varC1 = Console.ReadLine(); //this allows the user to input their second value right next to the line saying "Variable c = " (which should be 5) and then it stores that value into the string variable named varC1 which can be used in the program representing the variable c value.
                            double varC = double.Parse(varC1); //this converts the inputted string value into a double (decimal) value so that the value can be properly used as numbers in the formulas and so the calculation will perform properly. We also need to make it a decimal value because the answer can be in decimal and integer which is why double is the best data type 
                                                               //so now the input value for variable C which was stored into a variable named varC1 is now saved into a variable named varC

                            double pyth = Math.Round(Math.Sqrt(Math.Pow(varC, 2) - Math.Pow(varA, 2)), 2); //once they input their variables, those values are put into this equation (pythagorean therom) and b is calculated
                            //rounds the value of b to 2 decimal places using math.round
                            //squaroots the whole equation using math.sqrt
                            //squares the value of c using math.pow
                            //squares the value of a using math.pow
                            //equation in normal format is SquareRoot(c^2 - a^2) = b

                            Console.Write("\n");
                            Console.WriteLine("b value = " + pyth);

                            Console.WriteLine("So, what is the missing value then?");
                            double MValue = double.Parse(Console.ReadLine());
                            if (MValue == 3.57) //if they input the missing value of b as 3.57, it will be right and the code in this if statment will run
                            {
                                Console.WriteLine("Correct! You may enter\n\nLuck = " + luck);
                                goto Final; //connects to the Final: that comes at the bottom, which basically means you got it right os you move ontot he final step
                            }
                            else //if the input is anything other than 3.57, that is wrong and so it will run whatever is in this else statement instead of the previous if statement
                            {
                                Console.WriteLine("\nYOU DIED\nThe trap door opened instantly and you fell into the ground never to be heard from again\n\nEND GAME");
                                goto EndGame; //this takes them to the connecting EndGame: at the bottom which asks them if they want to replay or not basically
                            }

                        }
                        catch //catches error, once caught or if caught, it tells them its an invalid input and to try again
                        {
                            Console.WriteLine("Invalid Input, try again");
                        }
                    }
                }
                else if (Choice4 == "two" || Choice4 == "Two" || Choice4 == "TWO") //if they chose gate 2 and not gate 1, it skips everything else in the previous if statment and comes to this else if statment and runs the code within it
                {
                    //story text
                    Console.WriteLine("\nOn the gate of the pyramid 2 entrance there is a puzzle. You have to solve this puzzle to enter! You are given 4 numbers, try to find what is the pattern is in those numbers, then enter what the next 3 numbers would be if you follow the pattern. If you do not get the correct input in two tries, you will be killed by arrows coming out of the walls.");

                    int[] pattern = new int[4]; //declaring array with array length of 4
                    //inserting values into the pattern array
                    for (int i = 0; i < pattern.Length; i++)
                    {
                        pattern[i] = (9 * (i + 10));
                    }
                    //displaying the pattern array for the users to see what the pattern's first 4 numbers are
                    Console.WriteLine("\nThe 4 numbers are:");
                    for (int i = 0; i < pattern.Length; i++)
                    {
                        Console.Write(pattern[i] + ", ");
                    }

                    Console.WriteLine("\nDebugging: the three next values of the pattern are 126, 135, 144");
                    //resizing the pattern array
                    //first you copy the pattern array values into a temporary array
                    int[] tempPattern = new int[pattern.Length]; //declaring temporary array 

                    for (int i = 0; i < pattern.Length; i++)
                    {
                        tempPattern[i] = pattern[i];
                    }
                    //looping the try catch so if there is an error that catch catches, it says invalid, try again and then it LETS them try again witht he loop
                    while (true)
                    {
                        try //hold the code we are finding the errors in
                        {
                            pattern = new int[7];//using already declared array and changing its array length
                            //coppying the origninal 4 values that were temporarily stored in an array back into the pattern array
                            for (int i = 0; i < tempPattern.Length; i++)
                            {
                                pattern[i] = tempPattern[i];
                            }
                            //for loop because they have 2 tries to get the values right so the for loop only runs 2 times
                            for (int j = 0; j < 2; j++)
                            {
                                Pattern://connects to the goto Pattern; whenever thhat is seen in the code, it brings the program back to this line of code
                                Console.WriteLine("\n\nInput the pattern's next 3 numbers");

                                //saving the new 3 values into the pattern array too using the inputs they input in
                                int PatternC = 0;
                                for (int i = pattern.Length - 3; i < pattern.Length;)
                                {
                                    Console.Write("Number #" + (i + 1) + ": ");
                                    PatternC = int.Parse(Console.ReadLine());

                                    if (PatternC > 0 || PatternC < 0 || PatternC == 0) //this is to make sure they can only input numbers for this if statment to run
                                    {
                                        //saving inputs into the resized array
                                        pattern[i] = PatternC;
                                        i++;
                                    }
                                    else //if none of the else statment statments match the input it comes to this else statment and writes that it is an invalid input so they need to try again, and since there is a loop it loops up and lets them try again
                                    {
                                        Console.WriteLine("Invalid input, Try Again");
                                        goto Pattern; //takes the program back to Pattern: and asks user to input their values again, properly this time
                                    }
                                }//end of for loop

                                // stating resized array's old and new element values together 
                                Console.WriteLine("\n");
                                Console.WriteLine("Here is the pattern with new inputs");
                                for (int i = 0; i < pattern.Length; i++)
                                {
                                    Console.Write(pattern[i] + ", ");
                                }
                                //if they get the numbers right, (126, 135, 144) then this if statment will run
                                if (pattern[4] == 126 && pattern[5] == 135 && pattern[6] == 144)
                                {
                                    //if they got the numbers right in their first try run this if statement
                                    if (j == 0)
                                    {
                                        luck += 75;
                                        Console.WriteLine("You got it! Good job. The door slowly opens and you enter.\n+75 Luck Points");
                                        Console.WriteLine("Luck = " + luck);
                                        goto Final; //they got it and so it will send them to the next and final part of the game
                                    }
                                    //if they got the numbers right in their second try, run this else if statement instead
                                    else if (j == 1)
                                    {
                                        luck += 50;
                                        Console.WriteLine("You got it! Good job. The door slowly opens and you enter.\n+50 Luck Points");
                                        Console.WriteLine("Luck = " + luck);
                                        goto Final; //they got it and so it will send them to the next and final part of the game
                                    }
                                    //this else if stament will run the code inside of it if they get any of the 3 numbers wrong or all of them too
                                }
                                else if (pattern[4] != 126 || pattern[5] != 135 || pattern[6] != 144)
                                {
                                    //if they got the numbers wrong in their first try run this if statement and it will let them try again once
                                    if (j == 0)
                                    {
                                        luck -= 50;
                                        Console.WriteLine("Oh no, it's wrong, last try.\n-50 Luck Points");
                                        Console.WriteLine("Luck = " + luck);

                                    }
                                    //if they got the numbers wrong in their second try, run this else if statement instead and it will end the game for them
                                    else if (j == 1)
                                    {
                                        Console.WriteLine("\nYOU DIED\nThe arrows shot out from the wall and impaled you everywhere\n\nEND GAME");
                                        sw.WriteLine("GAME OVER, unfortunately the treasure will not be yours today. You finished with " + luck + " Luck. Bad Desert Ending: Arrowed unlocked."); //save bad ending to desert endings file
                                        sw.Close(); //close streamwriter
                                        goto EndGame; //this takes them to the connecting EndGame: at the bottom which asks them if they want to replay or not basically
                                    }
                                }
                            }
                        }
                        catch //if there is some error in the inputs or outputs, this catch catches the error of the code that is in the try, so when there is an error it catches, it comes here and writes that it is an invalid input so they need to try again, and since there is a loop it loops up and lets them try again
                        {
                            Console.WriteLine("invalid input, try again");
                        }
                    }
                }
                //if they want to go into pyramid three, they will input three in the input area and then this else if statment will run instad of the preveous ones for pyramid one and two.
                else if (Choice4 == "three" || Choice4 == "Three" || Choice4 == "THREE")
                {
                    //story text
                    Console.WriteLine("So you go towards pyramid three, but on it's entrance theres jumbled up words. You try to open the door but it doesn't open. You have to solve this puzzle to get through. Those jumbled up letters make up a sentence when put together. If you can decipher it and enter what each word of that sentence is, the entrance will open for you. If you do not find the right words in 3 tries for each word, spikes from below and above you will come out and jab you.");
                    //scrambled sentence
                    string sentence = "het kys ttohnig si brtghi";
                    //unscrambled sentence
                    string Ssentence = "the sky tonight is bright";

                    //seperating each word in the scrambled sentence to its own variable to use
                    string Word1 = sentence.Substring(0, sentence.IndexOf(' ')); //het
                    string Word2 = sentence.Substring(sentence.IndexOf('k'), 3); //kys
                    string Word3 = sentence.Substring(8, 7); //ttohnig
                    string Word4 = sentence.Substring(16, 2); //si
                    string Word5 = sentence.Substring(19, 6); //brtghi

                    //seperating each word in the unscrambled sentence to its own variable to use
                    string word1 = Ssentence.Substring(0, sentence.IndexOf(' ')); //the
                    string word2 = Ssentence.Substring(4, 3); //sky
                    string word3 = Ssentence.Substring(8, 7); //tonight
                    string word4 = Ssentence.Substring(16, 2); //is
                    string word5 = Ssentence.Substring(19, 6); //bright

                    Console.WriteLine("\n What are each of these scrambled words in this sentence?");
                    Console.WriteLine("\n" + sentence);

                    Console.WriteLine("\nDebugging: the unscrambled sentence is...\n\n" + Ssentence);
                    Console.WriteLine("\nDebugging: " + word1);
                    Console.WriteLine("Debugging: " + word2);
                    Console.WriteLine("Debugging: " + word3);
                    Console.WriteLine("Debugging: " + word4);
                    Console.WriteLine("Debugging: " + word5);

                    //The next lines, the multiple if statments, are very repetitive (I have bordered them off if the slashes) and included a description of what is happening just below this.
                    //first it starts off with a for loop that will only loop 3 times unless broken in the middle because I am giving them three tries for each word (so this is for each word seperately)
                    //then it states the word which they will have to unscramble and they have to enter the unscrambled form beside it
                    //then the first if statment checks if the word they input is the same as the word it is supposed to be when unscrambled, and if it is then it runs the nested if statment
                    ////if they get the answer correct in the first try they get 15 points and then it breaks the loop and moves on to the next word (for word 5, when it breaks, it goes to Final:)
                    ////if they get the answer correct in the second try they get 10 points and then it breaks the loop and moves on to the next word (for word 5, when it breaks, it goes to Final:)
                    ////if they get the answer correct in the third try they get 5 points and then it breaks the loop and moves on to the next word(for word 5, when it breaks, it goes to Final:)
                    //else, if it is anything other than the correct word that it should be, the program runs this else statment and the code inside of it instead
                    ////if they get the answer wrong the first try they lose 5 points and then it lets them retry and input again
                    ////if they get the answer wrong the second try as well they lose 10 points and then it lets them retry and input again
                    ////if they get the answer wrong the third try AS WELL, they lose, the game ends, and it takes us to the code where it asks if they want to replay (goto EndGame;)

                    ////////////////////////////////////////////////////////////////////////////////////
                    //for word 1
                    for (int i = 0; i < 3; i++)
                    {
                        Console.Write(Word1 + " : ");
                        string words1 = Console.ReadLine();
                        if (words1 == word1)
                        {
                            if (i == 0)
                            {
                                luck += 15;
                                Console.WriteLine("\nYou got it! Onto the next! \n+15 Luck Points");
                                Console.WriteLine("\nLuck = " + luck);
                                break;
                            }
                            else if (i == 1)
                            {
                                luck += 10;
                                Console.WriteLine("\nYou got it! Onto the next! \n+10 Luck Points");
                                Console.WriteLine("\nLuck = " + luck);
                                break;
                            }
                            else if (i == 2)
                            {
                                luck += 5;
                                Console.WriteLine("\nYou got it! Onto the next! \n+5 Luck Points");
                                Console.WriteLine("\nLuck = " + luck);
                                break;
                            }
                        }
                        else if (words1 == "x" || words1 == "X")
                        {
                            //the is the else if statement part of the connecting if statemnet which runs whatever is in it (in this case the code is to exit out of the program) IF the user chooses none of the options and instead inputs x into the variable because they do not want to play anymore, so the program skips the first ifs and else ifs and reads this one instead
                            Environment.Exit(0);
                        }
                        else //if none of the else statment statments match the input it comes to this else statment and writes that they inputted the wrong answer and can have another try at it, and since there is a loop it loops up and lets them try again only for two tries
                        {
                            if (i == 0)
                            {
                                luck -= 5;
                                Console.WriteLine("\nTry again\n-5 Luck Points");
                                Console.WriteLine("\nLuck = " + luck);
                            }
                            else if (i == 1)
                            {
                                luck -= 10;
                                Console.WriteLine("\nTry again, last try\n-10 Luck Points");
                                Console.WriteLine("\nLuck = " + luck);
                            }
                            else if (i == 2)
                            {
                                Console.WriteLine("\nOh dear, you got it wrong again and the spikes killed you.\n\nEND GAME");
                                sw.WriteLine("GAME OVER, unfortunately the treasure will not be yours today. You finished with " + luck + " Luck. Bad Desert Ending: Pig on a Stick unlocked."); //save bad ending to desert endings file
                                sw.Close(); //close streamwriter
                                goto EndGame; //this takes them to the connecting EndGame: at the bottom which asks them if they want to replay or not basically
                            }
                        }
                    }
                    //for word 2
                    for (int i = 0; i < 3; i++)
                    {
                        Console.Write(Word2 + " : ");
                        string words2 = Console.ReadLine();
                        if (words2 == word2)
                        {
                            if (i == 0)
                            {
                                luck += 15;
                                Console.WriteLine("\nYou got it! Onto the next! \n+15 Luck Points");
                                Console.WriteLine("\nLuck = " + luck);
                                break;
                            }
                            else if (i == 1)
                            {
                                luck += 10;
                                Console.WriteLine("\nYou got it! Onto the next! \n+10 Luck Points");
                                Console.WriteLine("\nLuck = " + luck);
                                break;
                            }
                            else if (i == 2)
                            {
                                luck += 5;
                                Console.WriteLine("\nYou got it! Onto the next! \n+5 Luck Points");
                                Console.WriteLine("\nLuck = " + luck);
                                break;
                            }
                        }
                        else if (words2 == "x" || words2 == "X")
                        {
                            //the is the else if statement part of the connecting if statemnet which runs whatever is in it (in this case the code is to exit out of the program) IF the user chooses none of the options and instead inputs x into the variable because they do not want to play anymore, so the program skips the first ifs and else ifs and reads this one instead
                            Environment.Exit(0);
                        }
                        else //if none of the else statment statments match the input it comes to this else statment and writes that they inputted the wrong answer and can have another try at it, and since there is a loop it loops up and lets them try again only for two tries
                        {
                            if (i == 0)
                            {
                                luck -= 5;
                                Console.WriteLine("\nTry again\n-5 Luck Points");
                                Console.WriteLine("\nLuck = " + luck);
                            }
                            else if (i == 1)
                            {
                                luck -= 10;
                                Console.WriteLine("\nTry again, last try\n-10 Luck Points");
                                Console.WriteLine("\nLuck = " + luck);
                            }
                            else if (i == 2)
                            {
                                Console.WriteLine("\nOh dear, you got it wrong again and the spikes killed you.\n\nEND GAME");
                                sw.WriteLine("GAME OVER, unfortunately the treasure will not be yours today. You finished with " + luck + " Luck. Bad Desert Ending: Pig on a Stick Pt 2 unlocked."); //save bad ending to desert endings file
                                sw.Close(); //close streamwriter
                                goto EndGame; //this takes them to the connecting EndGame: at the bottom which asks them if they want to replay or not basically
                            }
                        }
                    }
                    //for word 3
                    for (int i = 0; i < 3; i++)
                    {
                        Console.Write(Word3 + " : ");
                        string words3 = Console.ReadLine();
                        if (words3 == word3)
                        {
                            if (i == 0)
                            {
                                luck += 15;
                                Console.WriteLine("\nYou got it! Onto the next! \n+15 Luck Points");
                                Console.WriteLine("\nLuck = " + luck);
                                break;
                            }
                            else if (i == 1)
                            {
                                luck += 10;
                                Console.WriteLine("\nYou got it! Onto the next! \n+10 Luck Points");
                                Console.WriteLine("\nLuck = " + luck);
                                break;
                            }
                            else if (i == 2)
                            {
                                luck += 5;
                                Console.WriteLine("\nYou got it! Onto the next! \n+5 Luck Points");
                                Console.WriteLine("\nLuck = " + luck);
                                break;
                            }
                        }
                        else if (words3 == "x" || words3 == "X")
                        {
                            //the is the else if statement part of the connecting if statemnet which runs whatever is in it (in this case the code is to exit out of the program) IF the user chooses none of the options and instead inputs x into the variable because they do not want to play anymore, so the program skips the first ifs and else ifs and reads this one instead
                            Environment.Exit(0);
                        }
                        else //if none of the else statment statments match the input it comes to this else statment and writes that they inputted the wrong answer and can have another try at it, and since there is a loop it loops up and lets them try again only for two tries
                        {
                            if (i == 0)
                            {
                                luck -= 5;
                                Console.WriteLine("\nTry again\n-5 Luck Points");
                                Console.WriteLine("\nLuck = " + luck);
                            }
                            else if (i == 1)
                            {
                                luck -= 10;
                                Console.WriteLine("\nTry again, last try\n-10 Luck Points");
                                Console.WriteLine("\nLuck = " + luck);
                            }
                            else if (i == 2)
                            {
                                Console.WriteLine("\nOh dear, you got it wrong again and the spikes killed you.\n\nEND GAME");
                                sw.WriteLine("GAME OVER, unfortunately the treasure will not be yours today. You finished with " + luck + " Luck. Bad Desert Ending: Pig on a Stick Pt 3 unlocked."); //save bad ending to desert endings file
                                sw.Close(); //close streamwriter
                                goto EndGame; //this takes them to the connecting EndGame: at the bottom which asks them if they want to replay or not basically
                            }
                        }
                    }
                    //for word 4
                    for (int i = 0; i < 3; i++)
                    {
                        Console.Write(Word4 + " : ");
                        string words4 = Console.ReadLine();
                        if (words4 == word4)
                        {
                            if (i == 0)
                            {
                                luck += 15;
                                Console.WriteLine("\nYou got it! Onto the next! \n+15 Luck Points");
                                Console.WriteLine("\nLuck = " + luck);
                                break;
                            }
                            else if (i == 1)
                            {
                                luck += 10;
                                Console.WriteLine("\nYou got it! Onto the next! \n+10 Luck Points");
                                Console.WriteLine("\nLuck = " + luck);
                                break;
                            }
                            else if (i == 2)
                            {
                                luck += 5;
                                Console.WriteLine("\nYou got it! Onto the next! \n+5 Luck Points");
                                Console.WriteLine("\nLuck = " + luck);
                                break;
                            }
                        }
                        else if (words4 == "x" || words4 == "X")
                        {
                            //the is the else if statement part of the connecting if statemnet which runs whatever is in it (in this case the code is to exit out of the program) IF the user chooses none of the options and instead inputs x into the variable because they do not want to play anymore, so the program skips the first ifs and else ifs and reads this one instead
                            Environment.Exit(0);
                        }
                        else //if none of the else statment statments match the input it comes to this else statment and writes that they inputted the wrong answer and can have another try at it, and since there is a loop it loops up and lets them try again only for two tries
                        {
                            if (i == 0)
                            {
                                luck -= 5;
                                Console.WriteLine("\nTry again\n-5 Luck Points");
                                Console.WriteLine("\nLuck = " + luck);
                            }
                            else if (i == 1)
                            {
                                luck -= 10;
                                Console.WriteLine("\nTry again, last try\n-10 Luck Points");
                                Console.WriteLine("\nLuck = " + luck);
                            }
                            else if (i == 2)
                            {
                                Console.WriteLine("\nOh dear, you got it wrong again and the spikes killed you.\n\nEND GAME");
                                sw.WriteLine("GAME OVER, unfortunately the treasure will not be yours today. You finished with " + luck + " Luck. Bad Desert Ending: Pig on a Stick Pt 4 unlocked."); //save bad ending to desert endings file
                                sw.Close(); //close streamwriter
                                goto EndGame; //this takes them to the connecting EndGame: at the bottom which asks them if they want to replay or not basically
                            }
                        }
                    }
                    //for word 5
                    for (int i = 0; i < 3; i++)
                    {
                        Console.Write(Word5 + " : ");
                        string words5 = Console.ReadLine();
                        if (words5 == word5)
                        {
                            if (i == 0)
                            {
                                luck += 15;
                                Console.WriteLine("\nYou got it! The door slowly opens and you enter.\n+15 Luck Points");
                                Console.WriteLine("\nLuck = " + luck);
                                Console.WriteLine("The Complete sentence is:\n" + Ssentence);
                                goto Final;
                            }
                            else if (i == 1)
                            {
                                luck += 10;
                                Console.WriteLine("\nYou got it! The door slowly opens and you enter.\n+10 Luck Points");
                                Console.WriteLine("\nLuck = " + luck);
                                Console.WriteLine("The Complete sentence is:\n" + Ssentence);
                                goto Final;
                            }
                            else if (i == 2)
                            {
                                luck += 5;
                                Console.WriteLine("\nYou got it! The door slowly opens and you enter.\n+5 Luck Points");
                                Console.WriteLine("\nLuck = " + luck);
                                Console.WriteLine("The Complete sentence is:\n" + Ssentence);
                                goto Final;
                            }
                        }
                        else if (words5 == "x" || words5 == "X")
                        {
                            //the is the else if statement part of the connecting if statemnet which runs whatever is in it (in this case the code is to exit out of the program) IF the user chooses none of the options and instead inputs x into the variable because they do not want to play anymore, so the program skips the first ifs and else ifs and reads this one instead
                            Environment.Exit(0);
                        }
                        else //if none of the else statment statments match the input it comes to this else statment and writes that they inputted the wrong answer and can have another try at it, and since there is a loop it loops up and lets them try again only for two tries
                        {
                            if (i == 0)
                            {
                                luck -= 5;
                                Console.WriteLine("\nTry again\n-5 Luck Points");
                                Console.WriteLine("\nLuck = " + luck);
                            }
                            else if (i == 1)
                            {
                                luck -= 10;
                                Console.WriteLine("\nTry again, last try\n-10 Luck Points");
                                Console.WriteLine("\nLuck = " + luck);
                            }
                            else if (i == 2)
                            {
                                Console.WriteLine("\nOh dear, you got it wrong again and the spikes killed you.\n\nEND GAME");
                                sw.WriteLine("GAME OVER, unfortunately the treasure will not be yours today. You finished with " + luck + " Luck. Bad Desert Ending: Pig on a Stick Pt 5 unlocked."); //save bad ending to desert endings file
                                sw.Close(); //close streamwriter
                                goto EndGame; //this takes them to the connecting EndGame: at the bottom which asks them if they want to replay or not basically
                            }
                        }
                    }
                }
                ////////////////////////////////////////////////////////////////////////////////////////////////////////
                else if (Choice4 == "x" || Choice4 == "X")
                {
                    //the is the else if statement part of the connecting if statemnet which runs whatever is in it (in this case the code is to exit out of the program) IF the user chooses none of the options and instead inputs x into the variable because they do not want to play anymore, so the program skips the first ifs and else ifs and reads this one instead
                    Environment.Exit(0);
                }
                else //if none of the else statment statments match the input it comes to this else statment and writes that it is an invalid input so they need to try again, and since there is a loop it loops up and lets them try again
                {
                    Console.WriteLine("\nInvalid input, try again");
                }
            } //loop ends

            Final: //all the lines of code that say goto Final: when reached bring us down here and then the program continues on from this (Final:)
            //story text
            Console.WriteLine("\n\nThere are 3 doors infront of you now, 1 only lets in people with 200 luck points or more.\nThe second only lets people in with 100 luck points to 200 luck points.\nThe third only lets in people with 100 luck points or less.");

            //to continue the game or to close the game if the user does not want to continue with the game.
            Console.WriteLine("\nEnter \"next\" to continue or \"X\" to close the game."); //just tells the user that they can either continue by entering next or close the game by entering x
            while (true) //a loop just incase they input a invalid input, it needs to loop and give them another try
            {
                string next1 = Console.ReadLine(); //this variable next1 will save what the user inputs in it and will be used to determine if it they want to continue, exit or if it is an invalid input
                if (next1 == "next" || next1 == "Next" || next1 == "NEXT")//this if stament will break the loop and continue on with the game, so it will move onto the code after the loop if the person inputs "next"
                {
                    break;//breaks the loop and help the program keep going
                }
                else if (next1 == "x" || next1 == "X") //this statement will run if they type "x" instead of "next" and the code in it will exit out of the console program so this helps user stop playing
                {
                    //the is the else if statement part of the connecting if statemnet which runs whatever is in it (in this case the code is to exit out of the program) IF the user chooses none of the options and instead inputs x into the variable because they do not want to play anymore, so the program skips the first ifs and else ifs and reads this one instead
                    Environment.Exit(0);//exits the console program (closes console screen)
                }
                else //if none of the else statment statments match the input it comes to this else statment and writes that it is an invalid input so they need to try again, and since there is a loop it loops up and lets them try again
                {
                    Console.WriteLine("Invalid input, try again"); //prints invalid input on the console screen for the user to see and try again
                }
            }//loop ends here

            //debuggin start
            Console.WriteLine("Final Total luck points = " + luck);
            Again:
            Console.WriteLine("Debugging: do you want to edit your Final Total luck points? (Y/N)");
            string debug = Console.ReadLine();

            if (debug == "y" || debug == "Y" || debug == "yes" || debug == "Yes" || debug == "YES")
            {
                again:
                try
                {

                    Console.Write("enter what you want to change your points to: ");
                    int debugging = int.Parse(Console.ReadLine());
                    luck = debugging;
                    goto debug;
                }
                catch
                {
                    Console.WriteLine("Invalid input, try again");
                    goto again;
                }
            }
            else if (debug == "n" || debug == "N" || debug == "No" || debug == "no" || debug == "NO")
            {
                goto debug;
            }
            else
            {
                Console.WriteLine("Invalid input, try again");
                goto Again;
            }
            //debugging end


            //if by the end the total luck is greater than 200, it will run the code inside this if statement (this holds two of the many endings)
            debug:
            if (luck > 200)
            {
                //they make it to the treasure but need a code to open the lock
                Console.WriteLine("You enter through door one. Yes! You made it into the room with the treasure! However, the treasure chest has a lock on it. To unlock it, you need the three numbers you noted with ** on them throughout your journey.\nPlease input in order of when you encountered them.");

                Console.WriteLine("\nDebugging: The code is 453");

                int code = int.Parse(Console.ReadLine()); //input read here
                                                          //if they input the correct code which is 453 then it runs the code inside this if statement and they win the treasure! (one of the many endings)
                if (code == 453)
                {
                    Console.WriteLine("\nCongratulations! You win, with the treasure! However, there is still more treasure to be discovered.");
                    sw.WriteLine("Congratulations! You retrieved the treasure and made it out with your life and " + luck + " luck. Your grandma is very proud of you. Good Desert Ending: Code Geass unlocked!"); //save good desert ending
                    sw.Close(); //close streamwriter
                    Console.WriteLine("\nScore = " + luck);
                }
                //if they input the wrong code or anything other than 453, the program will run the code inside this else statement which is that they made it so far but did not get the trasure (one of the many endings)
                else
                {
                    Console.WriteLine("\nYou made it so far, but you do not know the code to the treasure chest, so no treasure for you. Atleast you survived and had a good adventure!\nEND GAME");
                    Console.WriteLine("\nScore = " + luck);
                    sw.WriteLine("GAME OVER, unfortunately the treasure will not be yours today. You finished with " + luck + " Luck. Neutral Desert Ending: Locked Out unlocked."); //save neutral ending to desert endings file
                    sw.Close(); //close streamwriter
                }
            }
            //if by the end the total luck is between 200 and 100 or equal to either, it will run the code inside this else if statement (this is also one of the many endings)
            else if (luck <= 200 && luck >= 100)
            {
                Console.WriteLine("\nYou enter through door 2. Aww. You made it to a room that only has another map and No Treasure. Atleast you can go on another adventure using that map!\nEND GAME");
                Console.WriteLine("\nScore = " + luck);
                sw.WriteLine("GAME OVER, unfortunately the treasure will not be yours today. You finished with " + luck + " Luck. Neutral Desert Ending: The Real Treasure Was The Maps We Made Along The Way unlocked."); //save neutral ending to desert endings file
                sw.Close(); //close streamwriter
            }
            //if by the end the total luck is less than 80, it will run the code inside this else if statement (this is also one of the many endings)
            else if (luck < 100)
            {
                Console.WriteLine("\nYou enter through door 3. Oh no! There was a trap door right as you enter the room! You stepped on it and fell through.\nYou lose\nEND GAME");
                Console.WriteLine("\nScore = " + luck);
                sw.WriteLine("GAME OVER, unfortunately the treasure will not be yours today. You finished with " + luck + " Luck. Bad Desert Ending: Hole in One unlocked."); //save bad ending to desert endings file
                sw.Close(); //close streamwriter
            }

            EndGame: //this connects all the goto EndGame; here, so where ever you see that, you come directly to this line of code and it plays from here
            while (true)//loop start
            {
                //this whole code under EndGame is if people would like to keep playing (replay) or stop playing
                Console.Write("\nWould you like to play again?(Y/N):  ");
                string replay = Console.ReadLine();
                //if the person wants to replay they will enter y or yes and then the code in this statment will run
                if (replay == "y" || replay == "Y" || replay == "yes" || replay == "Yes" || replay == "YES")
                {
                    Main(new[] { string.Empty }); //this goes all the way back up and restarts the game
                }
                //if the person does not what to replay  they will enter n or no and the code in this else if statment will run instead 
                else if (replay == "n" || replay == "N" || replay == "No" || replay == "no" || replay == "NO")
                {
                    Environment.Exit(0); //exits the console program, closes the console screen
                }
                else//if none of the else statment statments match the input it comes to this else statment and writes that it is an invalid input so they need to try again, and since there is a loop it loops up and lets them try again
                {
                    Console.WriteLine("Invalid input, try again");
                }
            } //end of loop
        }

        //jungle storyline: written by Aaron
        public static void Jungle()
        {
            StreamWriter sw = new StreamWriter("JungleEndings.txt"); //will write to jungle endings file
            begin:

            int Luck = 0; //Luck set to 0

            //story plot below
            Console.WriteLine("As you decide to pack up for a very long flight to find the long lost Belizean temple, you come across a problem… the limited space in your pink backpack!You have packed everything for the long awaited adventure but you can only bring one item out of the two items.");
            Console.WriteLine("\nWhat do you pick?");
            Console.WriteLine("\n*ATTENTION* This will determine your fate later on in the game");
            Console.WriteLine("\nA. Snorkel Gear");
            Console.WriteLine("B. Rope");
            Console.WriteLine("Current Luck: " + Luck); // displaying luck level
            Console.WriteLine("If any point in time, you do not feel like playing the game enter 'x'");

            //DEBUG STUFF
            Console.WriteLine("\nDEBUG: To quickly pass through the game enter choices b for neutral consequences");
            Console.WriteLine("The correct answers for the final game are: b, c, n");
            Console.WriteLine("Enter dl (low luck) or dL (high Luck) to skip the story and move to the final game");

            //user inputs which choice they want to follow
            string SGear = (Console.ReadLine());

            //Path if user picks A (Gear)
            if (SGear == "A" || SGear == "a")
            {
                Console.WriteLine("You picked the snorkel gear. Now off to the airport");
            }
            else if (SGear == "b" || SGear == "B")
            {
                goto Rope; //Skips the gear choice and skips the code under until it hits the Rope mark. From there the user will go through the same code but under the same code under the Rope mark, as the code for the rope option differs from the rope option
            }
            else if (SGear == "dl" || SGear == "Dl") //part of debug mode, user can skip the story part with low luck. Type letter D and lowercase L to enter game with low luck
            {
                Luck += 5;
                goto Game2;
            }
            else if (SGear == "dL" || SGear == "DL") //part of debug mode, user can skip the story part with high luck. Type letter D and uppercase L to enter game with high luck
            {
                Luck += 200;
                goto Game2;
            }
            else if (SGear == "x" || SGear == "X")
            {
                Environment.Exit(0); //code to exit the game
            }
            else
            {
                Console.WriteLine("Thats not an option.");
                Console.WriteLine("Please enter either choice A or B");
                goto begin; //if user does not input the correct choices it will bring it back up to the start
            }

            //Choices 2. Introduces the different paths to the jungles
            Console.WriteLine("\nAfter a painful flight with screaming babies you make your way to the Jaguar jungle. You use the map to navigate and bushwack through the overgrown bushes until you stumble upon the path diverging to three different pathways. The map is unclear as to which path is supposed to take you to the lost temple. ");
            Console.WriteLine("\nWill you go through:");
            Console.WriteLine("\nA. Middle \nB.Left \nC.Right");

            Pathway:
            string Pathway = (Console.ReadLine());

            if (Pathway == "a" || Pathway == "A") //1st ending
            {
                Console.WriteLine("\nYou decided to disregard the different pathways and ventured through the middle pathway.");
                Console.WriteLine("As you chopped and whistled through the thick leafage, you fell into a hole covered hidden with a pile of leaves and plummeted to your death in a pool of crocodiles.");
                Console.WriteLine("\nGAME OVER\nWould you like to play again?");
                Console.WriteLine("Enter Y or N");

                sw.WriteLine("GAME OVER, unfortunately the treasure will not be yours today. You finished with " + Luck + " Luck. Bad Jungle Ending: Crunched by Crocs unlocked."); //save bad jungle ending
                sw.Close(); //close streamwriter

                PathwaySub://go to code that brings user back up to the code to re enter a valid option
                string GameOverPathway = (Console.ReadLine()); //user will input whether they want to play again after the GAME OVER
                if (GameOverPathway == "y" || GameOverPathway == "Y")
                {
                    Main(new[] { string.Empty }); //sends user back to the beginning of the game
                }
                else if (GameOverPathway == "n" || GameOverPathway == "N")
                {
                    Environment.Exit(0); //user exits out of the game
                }
                else
                {
                    Console.WriteLine("Please enter a valid option.");
                    goto PathwaySub;//if user reaches to this point due to inputting a wrong option it will send it to the PathwaysSub:
                }
            }
            else if (Pathway == "b" || Pathway == "B")
            {
                Luck += 50; //users luck increases by 50
                Console.WriteLine("\nYou diverged to the left side of the pathway and bushwacked through with your sore arm. Gradually, the air felt a tad lighter and less humid and you took a glimpse of the bushes in front of you. You can make out a big mossy structure which happens to be the long lost Belizean temple!! Grandma would be so proud of you!! +50 luck");
                Console.WriteLine("Current luck: " + Luck); // displays users luck level. will determine the version of the final game
            }
            else if (Pathway == "x" || Pathway == "X")
            {
                Environment.Exit(0); //user exits if they want to
            }
            else if (Pathway == "c" || Pathway == "C")
            {
                Luck -= 20; //user luck decreases by 20
                Console.WriteLine("\nYou diverged to the right side of the pathway and heard loud growls from behind you. As you steadily turned to see what the commotion was about, there was a hungry looking Jaguar. You hastily rushed to the nearest tree and climbed up. Before you could look down, you felt the hungry creature crawling up to you. Just in time you turned to the nearest vine and swept your way to the other tree. As you observe your surroundings you make out a tall stone structure ahead of you which happens to be the temple. Phew! You made it... just barely. - 20 Luck");
                Console.WriteLine("Current luck: " + Luck);
            }
            else
            {
                Console.WriteLine("Please enter a valid option.");
                goto Pathway;
            }
            Console.WriteLine("\nWith sore arms and scratches from the sharp branches you enter the temple. It is cool and damp inside. Out of your pink backpack you pull out a flashlight to seek for the temple's treasures. You reached the very middle of the temple, dimly lit by the small crevices of sunlight. In awe you take in the bewildering emptiness of the temple, each step echoes through it. You come across a room filled with books which appear to be in an ancient language. What do you do?");
            Console.WriteLine("A. Steal a book \nB. Walk Out \nC. Read a Book");

            Book:
            string Book = (Console.ReadLine());

            if (Book == "c" || Book == "C")
            {
                Console.WriteLine("\nOut of curiosity, you pull a book out and start skimming through it. As you are perplexed by the interesting images in the book the temple starts to rumble and the book case in front of you opens up. It reveals a dark and empty stairwell. Do you want to enter?");
                Console.WriteLine("\nA. Yes! I want to go \nB. No. Thats scary!");
                Console.WriteLine("Current Luck: " + Luck);
                BookSub:
                string BookSub = (Console.ReadLine());
                if (BookSub == "a" || BookSub == "A")
                {
                    //because user has initially picked the snorkel gear the user survives this choice. Results will be different for rope users.
                    Luck += 100;
                    Console.WriteLine("\nYou decided to be brave and venture off into the unknown. As you reached the bottom of the stairwell, you accidentally triggered a pressure plate that closed the stairwell behind you and it dispensed water that quickly floods the room. ");
                    Console.WriteLine("You remembered that you packed snorkel gear and so you quickly equipped the gear to avoid drowning. You found a button in the room which drains all of the water from the room. But while finding the button you found a Sapphire gem. You managed to find your way back up to the ancient library. + 100 Luck");
                    Console.WriteLine("Current Luck: " + Luck);
                }
                else if (BookSub == "b" || BookSub == "B")
                {
                    Luck += 5;
                    Console.WriteLine("\nAs tempting as it looks, you decided not to go. Who knows what could be lurking in the dark? + 5 Luck");
                    Console.WriteLine("Current Luck: " + Luck);
                }
                else
                {
                    Console.WriteLine("Please enter a valid option..");
                    goto BookSub;
                }
            }
            else if (Book == "a" || Book == "A")
            {
                Luck -= 15;
                Console.WriteLine("\nAs you steal a book from the library and walk out of the library, the temple starts to rumble and crumble. You quickly put the book back in its rightful place and the temple began to settle down. You look at the guide your grandma gave you and you read a note that says “Beware, the temple has severe attachment issues with its books, do not steal them! -15 Luck");
                Console.WriteLine("Current Luck: " + Luck);
            }
            else if (Book == "b" || Book == "B")
            {
                Luck += 15;
                Console.WriteLine("\nYou walk out of the room unimpressed. It's a bunch of old dusty books that have no apparent use. Why even bother?");
                Console.WriteLine("Current Luck: " + Luck);
            }
            else if (Book == "x" || Book == "X")
            {
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("Please enter a valid option.");
                goto Book;
            }

            Console.WriteLine("\nYou wander through the temple for hours on end, but you don't give up. You found a room with a throne and a dining table. The room is lit up with torches? Hmm… someone must have been here not too long ago. What are you going to do?");
            Console.WriteLine("\nA. Leave the Room\nB. Sit at the dining table\nC. Sit on the throne");

            Room:
            string Room = (Console.ReadLine());
            if (Room == "c" || Room == "C")
            {
                Console.WriteLine("\nYou decided to sit on the throne and pretended to be royalty. You always wanted to become a King! As you get yourself comfortable, the throne collapses and slides down into a room full of snakes! What do you do?");
                Console.WriteLine("\nA. Attempt to escape");
                string RoomSub = (Console.ReadLine());
                if (RoomSub == "a" || RoomSub == "A")
                {
                    //because user has initially picked the snorkel gear the user dies in this choice.
                    Console.WriteLine("\nFull of adrenaline, you start to panic! You have no other way to escape other than to die in a pit of snakes. At least your old grandma outlived you.");
                    Console.WriteLine("GAME OVER");
                    Console.WriteLine("\nWould you like to play again?");
                    Console.WriteLine("Enter Y or N");
                    sw.WriteLine("GAME OVER, unfortunately the treasure will not be yours today. You finished with " + Luck + " Luck. Bad Jungle Ending: Snake Pit unlocked."); //save bad ending to jungle endings file
                    sw.Close(); //close streamwriter
                }
                RoomSub:
                string GameOverRoom = (Console.ReadLine());
                if (GameOverRoom == "y" || GameOverRoom == "Y")
                {
                    Main(new[] { string.Empty });
                }
                else if (GameOverRoom == "n" || GameOverRoom == "N")
                {
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("Please enter a valid option.");
                    goto RoomSub;
                }
            }
            else if (Room == "a" || Room == "A")
            {
                Luck += 15;
                Console.WriteLine("\nYou are not a risk taker so you decided to leave the room! +15 Luck");
                Console.WriteLine("Current Luck: " + Luck);
            }
            else if (Room == "b" || Room == "B")
            {
                Luck += 20;
                Console.WriteLine("You decided to sit at the dining table wishing you could eat a delicious meal. In the blink of an eye food magically appeared out of thin air. You gobble up all the food and now you feel refreshed and powered up! +20 Luck");
                Console.WriteLine("Current Luck: " + Luck);
            }
            else if (Room == "x" || Room == "X")
            {
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("Please enter a valid option.");
                goto Room;
            }
            Console.WriteLine("\nAs you wander more into the temple, you come across two doors. The first door is a blue door covered entirely with sparkling gems, which almost looks like rhinestones. The second door is an old battered wooden door. Which door do you enter?");
            Console.WriteLine("\nA. Blue Door\nB.Wooden Door");
            Console.ReadKey();

            Door:
            string Door = (Console.ReadLine());
            if (Door == "a" || Door == "A") //ending
            {
                Console.WriteLine("\nYou enter the blue door, hoping to find the treasure but you end up falling into a pit of lava. You were so close to the treasure.");
                Console.WriteLine("GAME OVER");
                Console.WriteLine("\nWould you like to play again?");
                Console.WriteLine("Enter Y or N");
                sw.WriteLine("GAME OVER, unfortunately the treasure will not be yours today. You finished with " + Luck + " Luck. Bad Jungle Ending: Lalalava"); //save bad jungle ending
                sw.Close(); //close streamwriter
                DoorsSub:
                string GameOverDoor = (Console.ReadLine());
                if (GameOverDoor == "y" || GameOverDoor == "Y")
                {
                    Main(new[] { string.Empty });
                }
                else if (GameOverDoor == "n" || GameOverDoor == "N")
                {
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("Please enter a valid option..");
                    goto DoorsSub;
                }
            }
            else if (Door == "b" || Door == "B")
            {
                Luck += 50;
                Console.WriteLine("\nYou enter the wooden door, perhaps it's the door to the treasure? You enter and you see a small monkey, his name is “Monk”. But he hates people ransacking his temple!! If you win a game of hangman you will receive his treasure and earn back your freedom. Otherwise, you are stuck in Monks temple and you will forever serve him bananas!!");
                Console.WriteLine("Current luck: " + Luck);
                goto Game2;
            }
            else if (Door == "x" || Door == "X")
            {
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("Please enter a valid option..");
                goto Door;
            }

            //Path if user picks B (Rope)
            Rope:
            Console.WriteLine("You picked the Rope. Now off to the airport");
            Console.WriteLine("\nAfter a painful flight with screaming babies you make your way to the Jaguar jungle. You use the map to navigate and bushwack through the overgrown bushes until you stumble upon the path diverging to three different pathways. The map is unclear as to which path is supposed to take you to the lost temple. ");
            Console.WriteLine("\nWill you go through:");
            Console.WriteLine("A. Middle \nB.Left \nC.Right");

            Pathway2:
            string Pathway2 = (Console.ReadLine());

            if (Pathway2 == "a" || Pathway2 == "A")
            {
                Console.WriteLine("\nYou decided to disregard the different pathways and ventured through the middle pathway.");
                Console.WriteLine("As you chopped and whistled through the thick leafage, you fell into a whole covered hidden with a pile of leaves and plummeted to your death in a pool of crocodiles.");
                Console.WriteLine("\nWould you like to play again?");
                Console.WriteLine("Enter Y or N");
                sw.WriteLine("GAME OVER, unfortunately the treasure will not be yours today. You finished with " + Luck + " Luck. Bad Jungle Ending: Crunched by Crocs Pt 2 unlocked."); //save bad sea ending
                sw.Close(); //close streamwriter
                PathwaySub2:
                string GameOverPathway2 = (Console.ReadLine());
                if (GameOverPathway2 == "y" || GameOverPathway2 == "Y")
                {
                    Main(new[] { string.Empty });
                }
                else if (GameOverPathway2 == "n" || GameOverPathway2 == "N")
                {
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("Please enter a valid option.");
                    goto PathwaySub2;
                }
            }
            else if (Pathway2 == "b" || Pathway2 == "B")
            {
                Luck += 45;
                Console.WriteLine("\nYou diverged to the left side of the pathway and bushwacked through with your sore arm. Gradually, the air felt a tad lighter and less humid and you took a glimpse of the bushes in front of you. You can make out a big mossy structure which happens to be the long lost Belizean temple!! Grandma would be so proud of you!! +50 luck");
                Console.WriteLine("Current luck: " + Luck);
            }
            else if (Pathway2 == "x" || Pathway2 == "X")
            {
                Environment.Exit(0);
            }
            else if (Pathway2 == "c" || Pathway2 == "C")
            {
                Luck += 5;
                Console.WriteLine("\nYou diverged to the right side of the pathway and heard loud growls from behind you. As you steadily turned to see what the commotion was about, there was a hungry looking Jaguar. You hastily rushed to the nearest tree and climbed up. Before you could look down, you felt the hungry creature crawling up to you. Just in time you turned to the nearest vine and swept your way to the other tree. As you observe your surroundings you make out a tall stone structure ahead of you which happens to be the temple. Phew! You made it... just barely. - 20 Luck");
                Console.WriteLine("Current luck: " + Luck);
            }
            else
            {
                Console.WriteLine("Please enter a valid option.");
                goto Pathway2;
            }
            Console.WriteLine("\nWith sore arms and scratches from the sharp branches you enter the temple. It is cool and damp inside. Out of your pink backpack you pull out a flashlight to seek for the temple's treasures. You reached the very middle of the temple, dimly lit by the small crevices of sunlight. In awe you take in the bewildering emptiness of the temple, each step echoes through it. You come across a room filled with books which appear to be in an ancient language. What do you do?");
            Console.WriteLine("A. Steal a book \nB. Walk Out \nC. Read a Book");

            Book2:
            string Book2 = (Console.ReadLine());

            if (Book2 == "c" || Book2 == "C")
            {
                Luck += 15;
                Console.WriteLine("\nOut of curiosity, you pull a book out and start skimming through it. As you are perplexed by the interesting images in the book the temple starts to rumble and the book case in front of you opens up. It reveals a dark and empty stairwell. Do you want to enter? + 15 Luck");
                Console.WriteLine("\nA. Yes! I want to go \nB. No. Thats scary!");
                Console.WriteLine("Current Luck:" + Luck);
                BookSub2:
                string BookSub2 = (Console.ReadLine());
                if (BookSub2 == "a" || BookSub2 == "A")
                {
                    //because user has initially picked the rope the user dies in this choice.
                    Console.WriteLine("\nYou decided to be brave and venture off into the unknown. As you reached the bottom of the stairwell, you accidentally triggered a pressure plate that closed the stairwell behind you and it dispensed water that quickly floods the room.");
                    Console.WriteLine("You panicked trying to escape but it was no use. You accepted a painful long death as you drowned in the flooded room.");
                    Console.WriteLine("GAME OVER");
                    Console.WriteLine("\nWould you like to play again?");
                    Console.WriteLine("Enter Y or N");
                    sw.WriteLine("GAME OVER, unfortunately the treasure will not be yours today. You finished with " + Luck + " Luck. Bad Jungle Ending: GLUGLJFGKFGLUFGL unlocked."); //save bad jungle ending
                    sw.Close(); //close streamwriter
                    GameOverBookSub:
                    string GameOverBook2 = (Console.ReadLine());
                    if (GameOverBook2 == "y" || GameOverBook2 == "Y")
                    {
                        Main(new[] { string.Empty });
                    }
                    else if (GameOverBook2 == "n" || GameOverBook2 == "N")
                    {
                        Environment.Exit(0);
                    }
                    else
                    {
                        Console.WriteLine("Please enter a valid option.");
                        goto GameOverBookSub;
                    }
                }
                else if (BookSub2 == "b" || BookSub2 == "B")
                {
                    Luck += 20;
                    Console.WriteLine("As tempting as it looks, you decided not to go. Who knows what could be lurking in the dark? + 20 Luck");
                    Console.WriteLine("Current Luck" + Luck);
                }
                else
                {
                    Console.WriteLine("Please enter a valid option.");
                    goto BookSub2;
                }
            }
            else if (Book2 == "a" || Book2 == "A")
            {
                Luck += 15;
                Console.WriteLine("As you steal a book from the library and walk out of the library, the temple starts to rumble and crumble. You quickly put the book back in its rightful place and the temple began to settle down. You look at the guide your grandma gave you and you read a note that says “Beware, the temple has severe attachment issues with its books, do not steal them!");
                Console.WriteLine("Current Luck: " + Luck);
            }
            else if (Book2 == "b" || Book2 == "B")
            {
                Luck += 15;
                Console.WriteLine("You walk out of the room unimpressed. It's a bunch of old dusty books that have no apparent use. Why even bother?");
                Console.WriteLine("Current Luck: " + Luck);
            }
            else if (Book2 == "x" || Book2 == "X")
            {
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("Please enter a valid option.");
                goto Book2;
            }

            Console.WriteLine("You wander through the temple for hours on end, but you don't give up. You found a room with a throne and a dining table. The room is lit up with torches? Hmm… someone must have been here not too long ago. What are you going to do?");
            Console.WriteLine("\nA. Leave the Room\nB. Sit at the dining table\nC. Sit on the throne");

            Room2:
            string Room2 = (Console.ReadLine());
            if (Room2 == "c" || Room2 == "C")
            {
                Console.WriteLine("You decided to sit on the throne and pretended to be royalty. You always wanted to become a King! As you get yourself comfortable, the throne collapses and slides down into a room full of snakes! What do you do?");
                Console.WriteLine("\nA. Attempt to escape");

                RoomSub2:
                string RoomSub = (Console.ReadLine());
                if (RoomSub == "a" || RoomSub == "A")
                {
                    Luck += 100;
                    //because user has initially picked the rope so the user survives this choice
                    Console.WriteLine("\nFull of adrenaline, you start to panic! You remembered that you had packed a rope with you, so you used it to get yourself out. To your surprise, at the very top of the hole you came out of, a Ruby gem appeared on the floor. You picked it up and stuffed it into your pink backpack +100 Luck");
                    Console.WriteLine("Current Luck: " + Luck);
                }
                else
                {
                    Console.WriteLine("Please enter a valid option.");
                    goto RoomSub2;
                }
            }
            else if (Room2 == "a" || Room2 == "A")
            {
                Luck += 10;
                Console.WriteLine("\nYou are not a risk taker so you decided to leave the room! +15 Luck");
                Console.WriteLine("Current Luck: " + Luck);
            }
            else if (Room2 == "b" || Room2 == "B")
            {
                Luck += 20;
                Console.WriteLine("You decided to sit at the dining table wishing you could eat a delicious meal. In the blink of an eye food magically appeared out of thin air. You gobble up all the food and now you feel refreshed and powered up! +20 Luck");
                Console.WriteLine("Current Luck: " + Luck);
            }
            else if (Book2 == "x" || Book2 == "X")
            {
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("Please enter a valid option.");
                goto Room2;
            }
            Console.WriteLine("\nAs you wander more into the temple, you come across two doors. The first door is a blue door covered entirely with sparkling gems, which almost looks like rhinestones. The second door is an old battered wooden door. Which door do you enter?");
            Console.WriteLine("\nA. Blue Door\nB.Wooden Door");

            Door2:
            string Door2 = (Console.ReadLine());
            if (Door2 == "a" || Door2 == "A")
            {
                Console.WriteLine("\nYou enter the blue door, hoping to find the treasure but you end up falling into a pit of lava. You were so close to the treasure.");
                Console.WriteLine("GAME OVER");
                Console.WriteLine("\nWould you like to play again?");
                Console.WriteLine("Enter Y or N");
                sw.WriteLine("GAME OVER, unfortunately the treasure will not be yours today. You finished with " + Luck + " Luck. Bad Jungle Ending: Lalalalalalalava unlocked."); //save bad jungle ending
                sw.Close(); //close streamwriter
                DoorsSub2:
                string GameOverDoor2 = (Console.ReadLine());
                if (GameOverDoor2 == "y" || GameOverDoor2 == "Y")
                {
                    Main(new[] { string.Empty });
                }
                else if (GameOverDoor2 == "n" || GameOverDoor2 == "N")
                {
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("Please enter a valid option.");
                    goto DoorsSub2;
                }
            }
            else if (Door2 == "b" || Door2 == "B")
            {
                Luck += 5;
                Console.WriteLine("\nYou enter the wooden door, perhaps it's the door to the treasure? You enter and you see a small monkey, his name is “Monk”. But he hates people ransacking his temple!! If you win a game of hangman you will receive his treasure and earn back your freedom. Otherwise, you are stuck in Monks temple and you will forever serve him bananas!!");
                Console.WriteLine("Current luck: " + Luck);
            }
            else if (Door2 == "x" || Door2 == "X")
            {
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("Please enter a valid option.");
                goto Door2;
            }

            Game2:
            Console.WriteLine("\nWelcome to Monks Math games MWAHAHA!!!!");
            if (Luck < 100) //if user has luck less than 100 it will run a harder version of the game
            {
                Console.WriteLine("\nBecause you have a small amount of luck, you need to solve 3 math equations AHAHA!!!");
                Console.WriteLine("Instead of solving for the answer, you will be asked to pick which set of code is correct for the equation");
                Console.WriteLine("Get the answer wrong and you will be in my temple for FOREVER!!");

                //First Equation
                Console.WriteLine("\nHow would you code the volume formula for a sphere?");
                Console.WriteLine("Be sure that the code rounds the answer to the second decimal!");
                Console.WriteLine("Formula: V = 4/3 * π*r^3");
                Console.WriteLine("Let r represent 4");

                //choice a
                Console.WriteLine("\nTo code this equation is it:");
                Console.WriteLine("A.");
                Console.WriteLine("//INPUT (variables)");
                Console.WriteLine("double Answer;\nint Radius = 4;");
                Console.WriteLine("\n//PROCESSING");
                Console.WriteLine("\nAnswer = (0.25 * (Math.Sqrt(π*Radius),2)");
                Console.WriteLine("RoundedAnswer = Math.Round(Answer, 2);");
                //choice b
                Console.WriteLine("\nB.");
                Console.WriteLine("//INPUT (variables)");
                Console.WriteLine("double Answer;\nint Radius = 4;");
                Console.WriteLine("double Pi = Math.Pi;");
                Console.WriteLine("\n//PROCESSING");
                Console.WriteLine("\nRadiusPow = Math.Pow(Radius, 3);");
                Console.WriteLine("\nPiRadius = (Pi * RadiusPow);");
                Console.WriteLine("\nAnswer = (0.25 * PiRadius);");

                //choice c
                Console.WriteLine("\nC.");
                Console.WriteLine("\n//PROCESSING");
                Console.WriteLine("\nRadiusPow = Math.Sqrt(Radius, 3);");
                Console.WriteLine("\nPiRadius = (Pi * RadiusPow);");
                Console.WriteLine("\nAnswer = (3*4 * PiRadius);");

                string Spherel = (Console.ReadLine());
                if (Spherel == "a" || Spherel == "A")
                {
                    Console.WriteLine("\nHAHAHA! You failed to complete the task, therefore you must feed me bananas till the day you die HAHAHA!!");
                    Console.WriteLine("GAME OVER");
                    Console.WriteLine("\nWould you like to play again?");
                    Console.WriteLine("Enter Y or N");
                    sw.WriteLine("GAME OVER, unfortunately the treasure will not be yours today. You finished with " + Luck + " Luck. Bad Jungle Ending: Math Class Flunker unlocked."); //save bad jungle ending
                    sw.Close(); //close streamwriter

                    GameOverSpherel:
                    string GameOverSpherel = (Console.ReadLine());
                    if (GameOverSpherel == "y" || GameOverSpherel == "Y")
                    {
                        Main(new[] { string.Empty });
                    }
                    else if (GameOverSpherel == "n" || GameOverSpherel == "N")
                    {
                        Environment.Exit(0);
                    }
                    else
                    {
                        Console.WriteLine("Please enter a valid option.");
                        goto GameOverSpherel;
                    }
                }
                else if (Spherel == "b" || Spherel == "B")
                {
                    Console.WriteLine("\nMonk was very surprised that you passed his test.");
                }
                else if (Spherel == "c" || Spherel == "C")
                {
                    Console.WriteLine("\nHAHAHA! You failed to complete the task, therefore you must feed me bananas till the day you die HAHAHA!!");
                    Console.WriteLine("GAME OVER");
                    Console.WriteLine("\nWould you like to play again?");
                    Console.WriteLine("Enter Y or N");
                    sw.WriteLine("GAME OVER, unfortunately the treasure will not be yours today. You finished with " + Luck + " Luck. Bad Jungle Ending: Math Class Flunker unlocked."); //save bad jungle ending
                    sw.Close(); //close streamwriter

                    GameOverSpherel3:
                    string GameOverSpherel3 = (Console.ReadLine());
                    if (GameOverSpherel3 == "y" || GameOverSpherel3 == "Y")
                    {
                        Main(new[] { string.Empty });
                    }
                    else if (GameOverSpherel3 == "n" || GameOverSpherel3 == "N")
                    {
                        Environment.Exit(0);
                    }
                    else
                    {
                        Console.WriteLine("Please enter a valid option.");
                        goto GameOverSpherel3;
                    }
                }
                //Second Equation
                Console.WriteLine("\nHmm... you passed the first one. Here is the second equation:");
                Console.WriteLine("What is the code for the Pythagorean Theorem");
                Console.WriteLine("Formula: a^2 + b^2 = c^2");
                Console.WriteLine("Do not round to the nearest hundredth, round to the nearest tenth");
                Console.WriteLine("Input a user input system");

                //Choice A
                Console.WriteLine("\nA.");
                Console.WriteLine("\n//INPUT");
                Console.WriteLine("\nConsole.WriteLine(\"Please enter a value\")");
                Console.WriteLine("string avalue = Console.ReadLine();");
                Console.WriteLine("double pavalue = double.Parse(avalue);");
                Console.WriteLine("\nConsole.WriteLine(\"\nPlease enter the 'b' value: \");");
                Console.WriteLine("string bvalue = Console.ReadLine();");
                Console.WriteLine("double pbvalue = double.Parse(bvalue);");

                Console.WriteLine("\n//PROCESSING and OUTPUT");
                Console.WriteLine("double cpowervalue = (Math.Pow(pavalue, 2)) + (Math.Pow(pbvalue, 4));");
                Console.WriteLine("\"\nThe Value of 'c' is : \" + (Math.Round(Math.Sqrt(cpowervalue), 2)));");

                //Choice B
                Console.WriteLine("\nB.");
                Console.WriteLine("\n//INPUT");
                Console.WriteLine("\nConsole.WriteLine(\"Please enter a value\")");
                Console.WriteLine("string avalue = Console.ReadLine();");
                Console.WriteLine("double pavalue = double.Parse(avalue);");
                Console.WriteLine("\nConsole.WriteLine(\"\nPlease enter the 'b' value: \")");
                Console.WriteLine("string bvalue = Console.ReadLine();");
                Console.WriteLine("double pbvalue = double.Parse(bvalue);");

                Console.WriteLine("\n//PROCESSING and OUTPUT");
                Console.WriteLine("double cpowervalue = (Math.Pow(pavalue, 2)) + (Math.Pow(pbvalue, 4));");
                Console.WriteLine("\"\nThe Value of 'c' is : \" + (Math.Round(Math.Sqrt(cpowervalue), 2)));");

                //Choice C
                Console.WriteLine("\nC.");
                Console.WriteLine("\n//INPUT");
                Console.WriteLine("\nConsole.WriteLine(\"Please enter a value\")");
                Console.WriteLine("string avalue = Console.ReadLine();");
                Console.WriteLine("double pavalue = double.Parse(avalue);");
                Console.WriteLine("\nConsole.WriteLine(\"\nPlease enter the 'b' value: \");");
                Console.WriteLine("string bvalue = Console.ReadLine();");
                Console.WriteLine("double pbvalue = double.Parse(bvalue);");

                Console.WriteLine("\n//PROCESSING and OUTPUT");
                Console.WriteLine("double cpowervalue = (Math.Pow(pavalue, 2)) + (Math.Pow(pbvalue, 4));");
                Console.WriteLine("\"\nThe Value of 'c' is : \" + (Math.Round(Math.Sqrt(cpowervalue), 1)));");

                string Theorem = (Console.ReadLine());
                if (Theorem == "a" || Theorem == "A")
                {
                    Console.WriteLine("\nHAHAHA! You failed to complete the task, therefore you must feed me bananas till the day you die HAHAHA!!");
                    Console.WriteLine("GAME OVER");
                    Console.WriteLine("\nWould you like to play again?");
                    Console.WriteLine("Enter Y or N");
                    sw.WriteLine("GAME OVER, unfortunately the treasure will not be yours today. You finished with " + Luck + " Luck. Bad Jungle Ending: Math Class Flunker unlocked."); //save bad jungle ending
                    sw.Close(); //close streamwriter

                    GameOverTheoreml1:
                    string GameOverTheoreml1 = (Console.ReadLine());
                    if (GameOverTheoreml1 == "y" || GameOverTheoreml1 == "Y")
                    {
                        Main(new[] { string.Empty });
                    }
                    else if (GameOverTheoreml1 == "n" || GameOverTheoreml1 == "N")
                    {
                        Environment.Exit(0);
                    }
                    else
                    {
                        Console.WriteLine("Please enter a valid option.");
                        goto GameOverTheoreml1;
                    }
                }
                else if (Theorem == "c" || Theorem == "C")
                {
                    Console.WriteLine("\nMonk was very surprised that you passed his test.");
                }
                else if (Theorem == "b" || Theorem == "B")
                {
                    Console.WriteLine("\nHAHAHA! You failed to complete the task, therefore you must feed me bananas till the day you die HAHAHA!!");
                    Console.WriteLine("GAME OVER");
                    Console.WriteLine("\nWould you like to play again?");
                    Console.WriteLine("Enter Y or N");
                    sw.WriteLine("GAME OVER, unfortunately the treasure will not be yours today. You finished with " + Luck + " Luck. Bad Jungle Ending: Math Class Flunker unlocked."); //save bad jungle ending
                    sw.Close(); //close streamwriter

                    GameOverTheoreml3:
                    string GameOverTheoreml3 = (Console.ReadLine());
                    if (GameOverTheoreml3 == "y" || GameOverTheoreml3 == "Y")
                    {
                        Main(new[] { string.Empty });
                    }
                    else if (GameOverTheoreml3 == "n" || GameOverTheoreml3 == "N")
                    {
                        Environment.Exit(0);
                    }
                    else
                    {
                        Console.WriteLine("Please enter a valid option.");
                        goto GameOverTheoreml3;
                    }
                }
                //Equation 3
                Console.WriteLine("\nUGHH NOOO! Thats supposed to be a tricky question. I guess you have one more question left!");
                Console.WriteLine("For the following code below does it match with the presented equation?");
                Console.WriteLine("\nCode: double EquationForSides = Math.Pow(SideA, 2) + Math.Pow(SideB, 2) - (2 * SideA * SideB * Math.Cos(SideC));");
                Console.WriteLine("E = A^2 + B^2 - 2 * A * CosC");
                Console.WriteLine("\nDo they match?");
                Console.WriteLine("Y or N?");

                string Equation3 = (Console.ReadLine());
                if (Equation3 == "y" || Equation3 == "Y")
                {
                    Console.WriteLine("\nHAHAHA! You failed to complete the task, therefore you must feed me bananas till the day you die HAHAHA!!");
                    Console.WriteLine("GAME OVER");
                    Console.WriteLine("\nWould you like to play again?");
                    Console.WriteLine("Enter Y or N");
                    sw.WriteLine("GAME OVER, unfortunately the treasure will not be yours today. You finished with " + Luck + " Luck. Bad Jungle Ending: Math Class Flunker unlocked."); //save bad jungle ending
                    sw.Close(); //close streamwriter

                    Equation3:
                    string Equationl3 = (Console.ReadLine());
                    if (Equationl3 == "y" || Equationl3 == "Y")
                    {
                        Main(new[] { string.Empty });
                    }
                    else if (Equationl3 == "n" || Equationl3 == "N")
                    {
                        Environment.Exit(0);
                    }
                    else
                    {
                        Console.WriteLine("Please enter a valid option.");
                        goto Equation3;
                    }
                }
                else if (Equation3 == "n" || Equation3 == "N")
                {
                    Console.WriteLine("Monk was very surprised that you passed his test. He rewarded you the treasure and fresh bananas for you and your grandma.");
                    Console.WriteLine("Congrats! You successfully passed the temple level with a " + Luck + " Luck level. However, there is still more treasure to be discovered.");

                    Console.WriteLine("\nWould you like to play again?");
                    Console.WriteLine("Enter Y or N");
                    sw.WriteLine("Congratulations! You retrieved the treasure and made it out with your life and " + Luck + " luck. Your grandma is very proud of you. Good Jungle Ending: Mathemagician unlocked!"); //save good jungle ending
                    sw.Close(); //close streamwriter
                    GameOverEquation3:
                    string GameOverEquation3 = (Console.ReadLine());
                    if (GameOverEquation3 == "y" || GameOverEquation3 == "Y")
                    {
                        Main(new[] { string.Empty });
                    }
                    else if (GameOverEquation3 == "n" || GameOverEquation3 == "N")
                    {
                        Environment.Exit(0);
                    }
                    else
                    {
                        Console.WriteLine("Please enter a valid option.");
                        goto GameOverEquation3;
                    }
                }
            }
            else if (Luck > 120) //if users luck is above 120 it will run the easier version of the game
            {
                Console.WriteLine("\nBecause you have a great amount of luck, you need to solve 1 math equations AHAHA!!!");
                Console.WriteLine("Instead of solving for the answer, you will be asked to pick which set of code is correct for the equation");
                Console.WriteLine("Get the answer wrong and you will be in my temple for FOREVER!!");

                //Sphere equation
                Console.WriteLine("\nHow would you code the volume formula for a sphere?");
                Console.WriteLine("Be sure that the code rounds the answer!");
                Console.WriteLine("Formula: V = 4/3 * π*r^3");
                Console.WriteLine("Let r represent 4");

                //choice a
                Console.WriteLine("\nTo code this equation is it:");
                Console.WriteLine("A.");
                Console.WriteLine("//INPUT (variables)");
                Console.WriteLine("double Answer;\nint Radius = 4;");
                Console.WriteLine("\n//PROCESSING");
                Console.WriteLine("\nAnswer = (0.25 * (Math.Sqrt(π*Radius),2)");
                //choice b
                Console.WriteLine("\nB.");
                Console.WriteLine("//INPUT (variables)");
                Console.WriteLine("double Answer;\nint Radius = 4;");
                Console.WriteLine("double Pi = Math.Pi;");
                Console.WriteLine("\n//PROCESSING");
                Console.WriteLine("\nRadiusPow = Math.Pow(Radius, 3);");
                Console.WriteLine("\nPiRadius = (Pi * RadiusPow);");
                Console.WriteLine("\nAnswer = (0.25 * PiRadius);");

                //choice c
                Console.WriteLine("\nC.");
                Console.WriteLine("\n//PROCESSING");
                Console.WriteLine("\nRadiusPow = Math.Sqrt(Radius, 3);");
                Console.WriteLine("\nPiRadius = (Pi * RadiusPow);");
                Console.WriteLine("\nAnswer = (3*4 * PiRadius);");

                string SphereL = (Console.ReadLine());
                if (SphereL == "a" || SphereL == "A")
                {
                    Console.WriteLine("HAHAHA! You failed to complete the task, therefore you must feed me bananas till the day you die HAHAHA!!");
                    Console.WriteLine("GAME OVER");
                    Console.WriteLine("\nWould you like to play again?");
                    Console.WriteLine("Enter Y or N");
                    sw.WriteLine("GAME OVER, unfortunately the treasure will not be yours today. You finished with " + Luck + " Luck. Bad Jungle Ending: Math Class Flunker unlocked."); //save bad jungle ending
                    sw.Close(); //close streamwriter

                    GameOverSphereL:
                    string GameOverSphereL = (Console.ReadLine());
                    if (GameOverSphereL == "y" || GameOverSphereL == "Y")
                    {
                        Main(new[] { string.Empty });
                    }
                    else if (GameOverSphereL == "n" || GameOverSphereL == "N")
                    {
                        Environment.Exit(0);
                    }
                    else
                    {
                        Console.WriteLine("Please enter a valid option.");
                        goto GameOverSphereL;
                    }
                }
                else if (SphereL == "b" || SphereL == "B")
                {
                    Console.WriteLine("Monk was very surprised that you passed his test. He rewarded you the treasure and fresh bananas for you and your grandma.");
                    Console.WriteLine("Congrats! You successfully passed the temple level with a" + Luck + " Luck level. However, there is still more treasure to be discovered.");

                    Console.WriteLine("\nWould you like to play again?");
                    Console.WriteLine("Enter Y or N");
                    sw.WriteLine("Congratulations! You retrieved the treasure and made it out with your life and " + Luck + " luck. Your grandma is very proud of you. Good Jungle Ending: Mathemagician unlocked!"); //save good jungle ending
                    sw.Close(); //close streamwriter
                    GameOverSphereL2:
                    string GameOverSphereL2 = (Console.ReadLine());
                    if (GameOverSphereL2 == "y" || GameOverSphereL2 == "Y")
                    {
                        Main(new[] { string.Empty });
                    }
                    else if (GameOverSphereL2 == "n" || GameOverSphereL2 == "N")
                    {
                        Environment.Exit(0);
                    }
                    else
                    {
                        Console.WriteLine("Please enter a valid option.");
                        goto GameOverSphereL2;
                    }
                }
                else if (SphereL == "c" || SphereL == "C")
                {
                    Console.WriteLine("HAHAHA! You failed to complete the task, therefore you must feed me bananas till the day you die HAHAHA!!");
                    Console.WriteLine("GAME OVER");
                    Console.WriteLine("\nWould you like to play again?");
                    Console.WriteLine("Enter Y or N");
                    sw.WriteLine("GAME OVER, unfortunately the treasure will not be yours today. You finished with " + Luck + " Luck. Bad Jungle Ending: Math Class Flunker unlocked."); //save bad jungle ending
                    sw.Close(); //close streamwriter

                    GameOverSphereL3:
                    string GameOverSphereL3 = (Console.ReadLine());
                    if (GameOverSphereL3 == "y" || GameOverSphereL3 == "Y")
                    {
                        Main(new[] { string.Empty });
                    }
                    else if (GameOverSphereL3 == "n" || GameOverSphereL3 == "N")
                    {
                        Environment.Exit(0);
                    }
                    else
                    {
                        Console.WriteLine("Please enter a valid option.");
                        goto GameOverSphereL3;
                    }
                }
            }
            Console.ReadKey();
        }

        //mountain storyline: written by Anvita
        public static void Mountain()
        {
            StreamWriter sw = new StreamWriter("MountainEndings.txt"); //will write to mountain endings file
            Console.SetWindowSize(125, 30);

            int Luck = 0; // set luck count to 0 at the start

            Console.WriteLine("You decide to travel to the mountain. It is windy and snowing, making it hard to see and even harder to travel. You can either walk to the mountain, ride a mountain goat, or steal your grandmother’s Camaro to get there. How do you want to travel?");
            Console.WriteLine("A. Walk\nB. Ride the mountain goat\nC. Drive Grandma’s sports car"); // display options
            Console.WriteLine("ANSWER FOR GOOD END: A"); //debug answers

            MountainTravel: // checkpoint to come back if user inputs invalid option
            string MntInput1 = Console.ReadLine(); // for user to input answer
            string MntUpperInput1 = MntInput1.ToUpper(); // converts user input to all capitals

            try
            {
                if (MntUpperInput1 == "A")
                {
                    Console.WriteLine("\nYou decide to walk to the mountain. It takes a long time, but you find a cabin on the way. Inside, you find a backpack containing a lighter, a knife, food rations, and warm clothing.");
                    Console.WriteLine("LUCK +30");
                    Luck += 30; // add 30 luck to total
                }
                else if (MntUpperInput1 == "B")
                {
                    Console.WriteLine("\nWhy would you try riding a mountain goat? As soon as you touch it, it kicks you and beats you up. You end up walking with your injuries.");
                    Console.WriteLine("LUCK -20");
                    Luck -= 20; // subtract 20 luck from total
                }
                else if (MntUpperInput1 == "C")
                {
                    Console.WriteLine("\nSports cars are not built for inclement weather, but you drive it anyways. You crash the car because it doesn’t have winter tires, and get injured by the airbags. You abandon the car and walk the rest of the way.");
                    Console.WriteLine("LUCK -10");
                    Luck -= 10; // subtract 10 luck from total
                }
                else if (MntUpperInput1 == "X")
                {
                    Environment.Exit(0); // exits the application
                }
                else
                {
                    Console.WriteLine("Enter valid option");
                    goto MountainTravel; // goes back to gameplay checkpoint if user inputs invalid answer
                }
            }
            catch // catches errors and displays "Enter valid option" instead of crashing
            {
                Console.WriteLine("Enter valid option");
                goto MountainTravel; // goes back to gameplay checkpoint if user inputs invalid answer
            }


            Console.WriteLine("\nYou reach the base of the mountain, where you find a path leading to the top. The treasure is supposed to be at the peak of this mountain, but every person that went looking for this treasure before went missing. You find an old man sitting on a bench near the path, and he looks very wise. Should you ask him if this is the right mountain, or continue on your journey?");
            Console.WriteLine("A. Ask him\nB. Don’t ask, start hiking up the mountain\nC. Abandon your mission"); // display options
            Console.WriteLine("ANSWER FOR GOOD END: B"); //debug answers

            MountainOldMan: // checkpoint to come back if user inputs invalid option
            string MntInput2 = Console.ReadLine(); // for user to input answer
            string MntUpperInput2 = MntInput2.ToUpper(); // converts user input to all capitals

            try
            {
                if (MntUpperInput2 == "A")
                {
                    Console.WriteLine("\nHe says this is the wrong mountain, and that the treasure is at the top of a different mountain. You travel to the other mountain, but realize you’re at the wrong place. The old man had dementia and led you to the wrong place, and now you have to travel all the way back.");
                    Console.WriteLine("LUCK -15");
                    Luck -= 15; // subtract 15 luck from total
                }
                else if (MntUpperInput2 == "B")
                {
                    Console.WriteLine("\nYou find a landmark that matches up with your map, which means you’re going the right way.");
                    Console.WriteLine("LUCK +20");
                    Luck += 20; // add 20 luck to total
                }
                else if (MntUpperInput2 == "C")
                {
                    Console.WriteLine("\nAll the stories of the missing travelers freak you out, so you turn around and go home. Your grandmother is not happy and you get a 2 hour lecture, but she tells you that you went to the right mountain. Now you have to travel all the way back, but at least you know it was the right place?");
                    Console.WriteLine("LUCK -5");
                    Luck -= 5; // subtract 5 luck from total
                }
                else if (MntUpperInput2 == "X")
                {
                    Environment.Exit(0); // exits the application
                }
                else
                {
                    Console.WriteLine("Enter valid option");
                    goto MountainOldMan; // goes back to gameplay checkpoint if user inputs invalid answer
                }
            }
            catch // catches errors and displays "Enter valid option" instead of crashing
            {
                Console.WriteLine("Enter valid option");
                goto MountainOldMan; // goes back to gameplay checkpoint if user inputs invalid answer
            }


            Console.WriteLine("\nYou’re now on the path up the mountain. You find an old axe lodged into what looks like a rock. An axe would be very useful, you could use it to collect wood and hunt animals. Will you take it?");
            Console.WriteLine("A. Don’t take the axe\nB. Take the axe"); // display options
            Console.WriteLine("ANSWER FOR GOOD END: A"); //debug answers

            MountainAxe: // checkpoint to come back if user inputs invalid option
            string MntInput3 = Console.ReadLine(); // for user to input answer
            string MntUpperInput3 = MntInput3.ToUpper(); // converts user input to all capitals

            try
            {
                if (MntUpperInput3 == "A")
                {
                    Console.WriteLine("\nYou decide it’s not right to take things that aren’t yours. You keep walking.");
                    Console.WriteLine("LUCK +5");
                    Luck += 5; // add 5 luck to total
                }
                else if (MntUpperInput3 == "B")
                {
                    Console.WriteLine("\nYou grab the axe and pull it out of the rock, using all of your strength. It takes a while, but as soon as you do, you realize the rock is actually a giant boulder, and it’s way bigger than you expected. The boulder splits in half, causing an avalanche on the mountain. Luckily, you escape.");
                    Console.WriteLine("LUCK -30");
                    Luck -= 30; // subtract 30 luck from total
                }
                else if (MntUpperInput2 == "X")
                {
                    Environment.Exit(0); // exits the application
                }
                else
                {
                    Console.WriteLine("Enter valid option");
                    goto MountainAxe; // goes back to gameplay checkpoint if user inputs invalid answer
                }
            }
            catch // catches errors and displays "Enter valid option" instead of crashing
            {
                Console.WriteLine("Enter valid option");
                goto MountainAxe; // goes back to gameplay checkpoint if user inputs invalid answer
            }


            Console.WriteLine("\nYou continue on your journey to the top, but the path splits into two, with a rocky wall in the middle. There is a sign with arrows that point both ways. The arrow pointing to the left has a painting of a sun on it, while the arrow pointing to the right has a painting of a moon.");
            Console.WriteLine("A. Go Left\nB. Go Right"); // display options
            Console.WriteLine("ANSWER FOR GOOD END: any"); //debug answers

            MountainSunMoon: // checkpoint to come back if user inputs invalid option
            string MntInput4 = Console.ReadLine(); // for user to input answer
            string MntUpperInput4 = MntInput4.ToUpper(); // converts user input to all capitals

            try
            {
                if (MntUpperInput4 == "A") // pathway splits
                {
                    Console.WriteLine("\nYou follow the sun path and go left. The sun is shining brightly, and it reflects against the snow, blinding you. If you have 10 or more luck points, you can find sunglasses in your backpack. You have " + Luck + " luck points.");

                    if (Luck >= 10)
                    {
                        Console.WriteLine("A. Wear the sunglasses\nB. Don’t wear sunglasses"); // display options
                        Console.WriteLine("ANSWER FOR GOOD END: A"); //debug answers

                        MountainSunglasses: // checkpoint to come back if user inputs invalid option
                        string MntInput4A = Console.ReadLine(); // for user to input answer
                        string MntUpperInput4A = MntInput4A.ToUpper(); // converts user input to all capitals

                        if (MntUpperInput4A == "A")
                        {
                            Console.WriteLine("\nYou wear your sunglasses, and instantly feel better. You can see clearly and the snow doesn’t fly into your eyes.");
                            Console.WriteLine("LUCK +10");
                            Luck += 10; // add 10 luck to total
                        }
                        else if (MntUpperInput4A == "B")
                        {
                            Console.WriteLine("\nYou decide that since it’s not hot, you don’t need sunglasses. You are wrong. You can’t see where you’re going and trip over every rock you pass.");
                            Console.WriteLine("LUCK -10");
                            Luck -= 10; // subtract 10 luck from total
                        }
                        else if (MntUpperInput4A == "X")
                        {
                            Environment.Exit(0); // exits the application
                        }
                        else
                        {
                            Console.WriteLine("Enter valid option");
                            goto MountainSunglasses; // goes back to gameplay checkpoint if user inputs invalid answer
                        }
                    }
                    else
                    {
                        Console.WriteLine("\nYou don’t have any sunglasses to wear, and your eyes start to hurt.");
                        Console.WriteLine("LUCK -5");
                        Luck -= 5; // subtract 5 luck from total
                    }

                    Console.WriteLine("\nYou encounter an aggressive black bear. How will you escape?");
                    Console.WriteLine("A. Play dead\nB. Fight it\nC. Give it your food"); // display options
                    Console.WriteLine("ANSWER FOR GOOD END: C"); //debug answers

                    MountainBear: // checkpoint to come back if user inputs invalid option
                    string MntInput4B = Console.ReadLine(); // for user to input answer
                    string MntUpperInput4B = MntInput4B.ToUpper(); // converts user input to all capitals

                    if (MntUpperInput4B == "A")
                    {
                        Console.WriteLine("\nYou decide to lay on the ground and play dead. It doesn’t work. This trick only works on grizzly bears, so the black bear attacks you. You escape by throwing the food in your backpack.");
                        Console.WriteLine("LUCK -10");
                        Luck -= 10; // subtract 10 luck from total
                    }
                    else if (MntUpperInput4B == "B")
                    {
                        Console.WriteLine("\nYou decide to fight the bear, even though it’s twice your size. Obviously, you lose, and your arm gets badly injured. Even the bear looks disappointed in you. You escape by throwing your backpack and running away.");
                        Console.WriteLine("LUCK -25");
                        Luck -= 25; // subtract 25 luck from total
                    }
                    else if (MntUpperInput4B == "C")
                    {
                        Console.WriteLine("\nYou throw your food at the bear, and it leaves you alone. You might be hungry, but you are safe.");
                        Console.WriteLine("LUCK +20");
                        Luck += 20; // add 20 luck to total
                    }
                    else if (MntUpperInput4B == "X")
                    {
                        Environment.Exit(0); // exits the application
                    }
                    else
                    {
                        Console.WriteLine("Enter valid option");
                        goto MountainBear; // goes back to gameplay checkpoint if user inputs invalid answer
                    }

                }
                else if (MntUpperInput4 == "B") // pathway splits
                {
                    Console.WriteLine("\nYou follow the moon path and go right. This path is dark, and the sun is blocked by the wall. You are freezing. If you have 10 or more luck points, you can find a thicker jacket in your backpack. You have " + Luck + " luck points.");

                    if (Luck >= 10)
                    {
                        Console.WriteLine("A. Wear the jacket\nB. Don’t wear the jacket"); // display options
                        Console.WriteLine("ANSWER FOR GOOD END: A"); //debug answers

                        MountainJacket: // checkpoint to come back if user inputs invalid option
                        string MntInput4C = Console.ReadLine(); // for user to input answer
                        string MntUpperInput4C = MntInput4C.ToUpper(); // converts user input to all capitals

                        if (MntUpperInput4C == "A")
                        {
                            Console.WriteLine("\nYou wear the thicker jacket, and instantly feel better. You are warmer and stop shivering.");
                            Console.WriteLine("LUCK +10");
                            Luck += 10; // add 10 luck to total
                        }
                        else if (MntUpperInput4C == "B")
                        {
                            Console.WriteLine("\nYou decide that since you’re already wearing a jacket, you don’t need the thicker one. You are wrong. You get cold and your shivering makes you walk slower. It will take you twice as long to reach the top of the mountain.");
                            Console.WriteLine("LUCK -10");
                            Luck -= 10; // subtract 10 luck from total
                        }
                        else if (MntUpperInput4C == "X")
                        {
                            Environment.Exit(0); // exits the application
                        }
                        else
                        {
                            Console.WriteLine("Enter valid option");
                            goto MountainJacket; // goes back to gameplay checkpoint if user inputs invalid answer
                        }
                    }
                    else
                    {
                        Console.WriteLine("\nYou don’t have a thicker jacket, so you run in circles to warm yourself up. It’s not efficient, but at least it works.");
                        Console.WriteLine("LUCK -5");
                        Luck -= 5; // subtract 5 luck from total
                    }

                    Console.WriteLine("\nYou encounter a hungry snow leopard. How will you escape?");
                    Console.WriteLine("A. Run away\nB. Yell at it\nC. Slowly back away and leave it alone"); // display options
                    Console.WriteLine("ANSWER FOR GOOD END: C"); //debug answers

                    MountainLeopard: // checkpoint to come back if user inputs invalid option
                    string MntInput4D = Console.ReadLine(); // for user to input answer
                    string MntUpperInput4D = MntInput4D.ToUpper(); // converts user input to all capitals

                    if (MntUpperInput4D == "A")
                    {
                        Console.WriteLine("\nYou thought you were going to be faster than a snow leopard? It catches you and you almost die. You escape by throwing your backpack at it.");
                        Console.WriteLine("LUCK -10");
                        Luck -= 10; // subtract 10 luck from total
                    }
                    else if (MntUpperInput4D == "B")
                    {
                        Console.WriteLine("\nYou yell loudly and try to scare it, which is a horrible idea. It attacks you, thinking you’re a threat.");
                        Console.WriteLine("LUCK -20");
                        Luck -= 20; // subtract 20 luck from total
                    }
                    else if (MntUpperInput4D == "C")
                    {
                        Console.WriteLine("\nYou decide to leave the snow leopard alone, which is a good idea, since snow leopards don’t attack people unless they need to defend themselves.");
                        Console.WriteLine("LUCK +20");
                        Luck += 20; // add 20 luck to total
                    }
                    else if (MntUpperInput4D == "X")
                    {
                        Environment.Exit(0); // exits the application
                    }
                    else
                    {
                        Console.WriteLine("Enter valid option");
                        goto MountainLeopard; // goes back to gameplay checkpoint if user inputs invalid answer
                    }
                }
                else if (MntUpperInput4 == "X")
                {
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("Enter valid option");
                    goto MountainSunMoon; // goes back to gameplay checkpoint if user inputs invalid answer
                }
            }
            catch // catches errors and displays "Enter valid option" instead of crashing
            {
                Console.WriteLine("Enter valid option");
                goto MountainSunMoon; // goes back to gameplay checkpoint if user inputs invalid answer
            }

            // pathway reconnects
            Console.WriteLine("\nAfter what feels like hours, you pass the giant wall, and notice that you’re halfway to the top. The sun is going down, and you need to set up camp somewhere. Where do you want to put your tent?");
            Console.WriteLine("A. Hanging over a cliff with rope\nB. Under an overhang\nC. Flat ground with no rocks"); // display options
            Console.WriteLine("ANSWER FOR GOOD END: B"); //debug answers

            MountainTent: // checkpoint to come back if user inputs invalid option
            string MntInput5 = Console.ReadLine(); // for user to input answer
            string MntUpperInput5 = MntInput5.ToUpper(); // converts user input to all capitals

            try
            {
                if (MntUpperInput5 == "A")
                {
                    Console.WriteLine("\nIt might look fun when you see pictures of hanging tents, but it was a lot more dangerous than you thought. The wind blows your tent away and down the mountain, but luckily you aren’t inside when this happens.");
                    Console.WriteLine("LUCK -15");
                    Luck -= 15; // subtract 15 luck from total
                }
                else if (MntUpperInput5 == "B")
                {
                    Console.WriteLine("\nYou set up your tent under a rocky overhang, which protects you from heavy snow.");
                    Console.WriteLine("LUCK +30");
                    Luck += 30; // add 30 luck to total
                }
                else if (MntUpperInput5 == "C")
                {
                    Console.WriteLine("\nYou pick a good spot, away from danger. There is a lot of wind and snow piling up, but you are safe from other threats");
                    Console.WriteLine("LUCK +20");
                    Luck += 20; // add 20 luck to total
                }
                else if (MntUpperInput5 == "X")
                {
                    Environment.Exit(0); // exits the application
                }
                else
                {
                    Console.WriteLine("Enter valid option");
                    goto MountainTent; // goes back to gameplay checkpoint if user inputs invalid answer
                }
            }
            catch // catches errors and displays "Enter valid option" instead of crashing
            {
                Console.WriteLine("Enter valid option");
                goto MountainTent; // goes back to gameplay checkpoint if user inputs invalid answer
            }


            Console.WriteLine("\nYour stomach growls and you remember that you need to eat dinner. You search your backpack for something to eat, and find a box of microwave dinner. There’s no microwave on the mountain, so you would have to eat it cold, or try heating it up with your lighter. There are also bushes with multi-coloured berries. What should you eat?");
            Console.WriteLine("A. Cold microwave dinner\nB. Hot microwave dinner\nC. Dark Berries\nD. Red Berries"); // display options
            Console.WriteLine("ANSWER FOR GOOD END: C"); //debug answers

            MountainDinner: // checkpoint to come back if user inputs invalid option
            string MntInput6 = Console.ReadLine(); // for user to input answer
            string MntUpperInput6 = MntInput6.ToUpper(); // converts user input to all capitals

            try
            {
                if (MntUpperInput6 == "A")
                {
                    Console.WriteLine("\nYou eat the microwave dinner without heating it up. It’s cold and makes your throat sore.");
                    Console.WriteLine("LUCK -5");
                    Luck -= 5; // subtract 5 luck from total
                }
                else if (MntUpperInput6 == "B")
                {
                    Console.WriteLine("\nYou heat up the box using a lighter. It takes an hour to get slightly warm, but it’s better than cold food. You accidently drop your lighter and it makes your tent catch on fire. Now you have to sleep in a tent with burn holes.");
                    Console.WriteLine("LUCK -30");
                    Luck -= 30; // subtract 30 luck from total
                }
                else if (MntUpperInput6 == "C")
                {
                    Console.WriteLine("\nYou find berries that look black, and they end up being black berries. They’re a little bitter and not filling, but it’s healthy.");
                    Console.WriteLine("LUCK +20");
                    Luck += 20; // add 20 luck to total
                }
                else if (MntUpperInput6 == "D")
                {
                    Console.WriteLine("\nYou eat bright red berries without thinking about the consequences. You realize that they are baneberries, which are very poisonous. You are forced to rush back down the mountain to seek medical attention. This trip will cost you time, and you will have to hike all the way back to the campsite you abandoned.");
                    Console.WriteLine("LUCK -30");
                    Luck -= 30; // subtract 30 luck from total
                }
                else if (MntUpperInput6 == "X")
                {
                    Environment.Exit(0); // exits the application
                }
                else
                {
                    Console.WriteLine("Enter valid option");
                    goto MountainDinner; // goes back to gameplay checkpoint if user inputs invalid answer
                }
            }
            catch // catches errors and displays "Enter valid option" instead of crashing
            {
                Console.WriteLine("Enter valid option");
                goto MountainDinner; // goes back to gameplay checkpoint if user inputs invalid answer
            }


            Console.WriteLine("\nYou wake up the next morning, still hungry from last night. You have two choices. You can either pack up your tent now and hike a little further before stopping for food, or you can look for food now and hike later.");
            Console.WriteLine("A. Hike now, eat later\nB. Eat now, hike later"); // display options
            Console.WriteLine("ANSWER FOR GOOD END: any"); //debug answers

            MountainBreakfast: // checkpoint to come back if user inputs invalid option
            string MntInput7 = Console.ReadLine(); // for user to input answer
            string MntUpperInput7 = MntInput7.ToUpper(); // converts user input to all capitals

            try
            {
                if (MntUpperInput7 == "A") // pathway splits
                {
                    Console.WriteLine("\nYou decide to walk further before having breakfast. You pack up all of your belongings and continue your trek up the mountain. You get tired pretty quickly, and you need a way to energize yourself until you reach the next rest stop. What should you do?");
                    Console.WriteLine("A. Yell\nB. Have an energy drink"); // display options
                    Console.WriteLine("ANSWER FOR GOOD END: A"); //debug answers

                    MountainHike: // checkpoint to come back if user inputs invalid option
                    string MntInput7A = Console.ReadLine(); // for user to input answer
                    string MntUpperInput7A = MntInput7A.ToUpper(); // converts user input to all capitals

                    if (MntUpperInput7A == "A")
                    {
                        Console.WriteLine("\nYou decide to wake yourself up by screaming as loud as you can. It doesn’t really work and makes your throat hurt, but it scares away nearby predators.");
                        Console.WriteLine("LUCK +20");
                        Luck += 20; // add 20 luck to total
                    }
                    else if (MntUpperInput7A == "B")
                    {
                        Console.WriteLine("\nYou decide to drink a can of redbull. You probably shouldn’t do that on an empty stomach, because it makes you nauseous. You feel sick but much more awake.");
                        Console.WriteLine("LUCK +10");
                        Luck += 10; // add 10 luck to total
                    }
                    else if (MntUpperInput7A == "X")
                    {
                        Environment.Exit(0); // exits the application
                    }
                    else
                    {
                        Console.WriteLine("Enter valid option");
                        goto MountainHike; // goes back to gameplay checkpoint if user inputs invalid answer
                    }

                    Console.WriteLine("\nYou stop near a tree to rest. You find an old backpack with food rations, and realize that this is the backpack of a previous traveller. You eat and continue your journey.");
                }
                else if (MntUpperInput7 == "B") // pathway splits
                {
                    Console.WriteLine("\nYou decide that you can’t walk on an empty stomach, so you leave your tent to look for food. You can hunt a small animal and boil it, or eat leaves and pines from trees. What will you do?");
                    Console.WriteLine("A. Hunt a rabbit\nB. Eat tree leaves"); // display options
                    Console.WriteLine("ANSWER FOR GOOD END: B"); //debug answers

                    MountainEat: // checkpoint to come back if user inputs invalid option
                    string MntInput7B = Console.ReadLine(); // for user to input answer
                    string MntUpperInput7B = MntInput7B.ToUpper(); // converts user input to all capitals

                    if (MntUpperInput7B == "A")
                    {
                        Console.WriteLine("\nYou hunt the rabbit and cook it. It’s filling, but you feel guilty and it ruins your mood for the rest of the day.");
                        Console.WriteLine("LUCK +5");
                        Luck += 5; // add 5 luck to total
                    }
                    else if (MntUpperInput7B == "B")
                    {
                        Console.WriteLine("\nYou decide to forage random leaves and pines. During your foraging, you scare away a squirrel that drops a small bag. You pick it up and find a protein bar, trail mix, and crackers.");
                        Console.WriteLine("LUCK +30");
                        Luck += 30; // add 30 luck to total
                    }
                    else if (MntUpperInput7B == "X")
                    {
                        Environment.Exit(0); // exits the application
                    }
                    else
                    {
                        Console.WriteLine("Enter valid option");
                        goto MountainEat; // goes back to gameplay checkpoint if user inputs invalid answer
                    }

                    Console.WriteLine("You finish eating and pack up your things to continue your journey.");
                }
                else if (MntUpperInput7 == "X")
                {
                    Environment.Exit(0); // exits the application
                }
                else
                {
                    Console.WriteLine("Enter valid option");
                    goto MountainBreakfast; // goes back to gameplay checkpoint if user inputs invalid answer
                }
            }
            catch // catches errors and displays "Enter valid option" instead of crashing
            {
                Console.WriteLine("Enter valid option");
                goto MountainBreakfast; // goes back to gameplay checkpoint if user inputs invalid answer
            }

            //pathway reconnects
            Console.WriteLine("\nYou are almost at the top of the mountain. The air is getting thinner and it’s hard to breathe. You need to find a way to save yourself before you pass out and freeze to death on this mountain. What will you do?");
            Console.WriteLine("A. Go back down the mountain\nB. Take a nap"); // display options
            Console.WriteLine("ANSWER FOR GOOD END: A"); //debug answers

            MountainTop: // checkpoint to come back if user inputs invalid option
            string MntInput8 = Console.ReadLine(); // for user to input answer
            string MntUpperInput8 = MntInput8.ToUpper(); // converts user input to all capitals

            try
            {
                if (MntUpperInput8 == "A")
                {
                    Console.WriteLine("\nYou decide to go back a little to catch your breath. It works and your body adapts to the altitude, so you can continue your journey.");
                    Console.WriteLine("LUCK +20");
                    Luck += 20; // add 20 luck to total
                }
                else if (MntUpperInput8 == "B")
                {
                    Console.WriteLine("\nYou decide that it doesn’t count as fainting if you make yourself fall asleep before passing out. That’s a terrible idea, and you don’t wake up for hours. You suddenly feel yourself wake up, but there’s no one around. You don’t understand what woke you up, but you’re glad you didn’t stay asleep, because you would have frozen to death.");
                    Console.WriteLine("LUCK -10");
                    Luck -= 10; // subtract 10 luck to total
                }
                else if (MntUpperInput8 == "X")
                {
                    Environment.Exit(0); // exits the application
                }
                else
                {
                    Console.WriteLine("Enter valid option");
                    goto MountainTop; // goes back to gameplay checkpoint if user inputs invalid answer
                }
            }
            catch // catches errors and displays "Enter valid option" instead of crashing
            {
                Console.WriteLine("Enter valid option");
                goto MountainTop; // goes back to gameplay checkpoint if user inputs invalid answer
            }


            Console.WriteLine("\n\nYour score is: " + Luck + " Luck points"); // display total luck points

            if (Luck < -10) // if luck is less than -10, user gets bad ending
            {
                Console.WriteLine("You received: BAD ENDING"); // display ending result
                Console.WriteLine("\nYou reach the peak of the mountain. You see the old man from the base of the mountain, and ask him what he’s doing and how he got here. He tells you that he has been looking for the treasure for over 50 years, but couldn’t find it until you showed up. Holding up a map that looks similar to yours, he explains that he followed you up the mountain. You realize that he stole your map while you were sleeping last night, but you were lucky enough to reach the top without it. The treasure can’t be split, meaning you will have to fight the old man to get the treasure. You get into a fist fight without knowing that the old man has a black belt in every martial art you can think of. He shoves you off the mountain and you fall to your death. Your grandma will never know what happened to you, but she dies of guilt shortly after, regretting her decision to send you to the mountain.");

                Console.WriteLine("\nPlay Again? (y/n)");

                MountainPlayAgain: // checkpoint to come back if user inputs invalid option
                string MntPlayAgain = Console.ReadLine();
                string MntUpperPlayAgain = MntPlayAgain.ToUpper(); // converts user input to all capitals

                if (MntUpperPlayAgain == "Y")
                {
                    Main(new[] { string.Empty });  // goes back to the start of the game
                }
                else if (MntUpperPlayAgain == "N")
                {
                    Environment.Exit(0); // exits the application
                }
                else if (MntUpperPlayAgain == "X")
                {
                    Environment.Exit(0); // exits the application
                }
                else
                {
                    Console.WriteLine("Enter valid option");
                    goto MountainPlayAgain; // goes back to gameplay checkpoint if user inputs invalid answer
                }
            }
            else if (Luck >= -10 && Luck <= 10) // if luck is more than or equal to -10 but less than or equal to 10, user gets neutral ending
            {
                Console.WriteLine("You received: NEUTRAL ENDING"); // display ending result
                Console.WriteLine("\nYou reach the peak of the mountain. You look around for the treasure, but you can’t find anything. You open your backpack to check your map, but you can’t find it. You know you were holding it last night, but realize you haven’t seen it since then. Did something take it from you? What type of animal eats maps? Anyways, you decide that you’re probably on the wrong part of the mountain, so you head back down to try again next year. Your grandmother is not happy and scolds you. Whatever, old people will always find something to complain about, so it doesn’t matter if you get the treasure or not.");

                Console.WriteLine("\nPlay Again?  (y/n)");

                sw.WriteLine("GAME OVER, unfortunately the treasure will not be yours today. You finished with " + Luck + " Luck. Neutral Mountain Ending: Grandma's Disappointment unlocked."); //save neutral ending
                sw.Close(); //close streamwriter

                MountainPlayAgain: // checkpoint to come back if user inputs invalid option
                string MntPlayAgain = Console.ReadLine();
                string MntUpperPlayAgain = MntPlayAgain.ToUpper(); // converts user input to all capitals

                if (MntUpperPlayAgain == "Y")
                {
                    Main(new[] { string.Empty }); // goes back to the start of the game
                }
                else if (MntUpperPlayAgain == "N")
                {
                    Environment.Exit(0); // exits the application
                }
                else if (MntUpperPlayAgain == "X")
                {
                    Environment.Exit(0); // exits the application
                }
                else
                {
                    Console.WriteLine("Enter valid option");
                    goto MountainPlayAgain; // goes back to gameplay checkpoint if user inputs invalid answer
                }

            }
            else if (Luck > 10) // if luck is more than 10, user gets good ending
            {
                Console.WriteLine("You received: GOOD ENDING"); // display ending result
                Console.WriteLine("\nYou reach the peak of the mountain. You see the old man from the base of the mountain, and ask him what he’s doing and how he got here. He tells you that he has been looking for the treasure for over 50 years, but couldn’t find it until you showed up. Holding up a map that looks similar to yours, he explains that he followed you up the mountain. You realize that he stole your map while you were sleeping last night, but you were lucky enough to reach the top without it. The treasure can’t be split, meaning you will have to fight the old man to get the treasure. You decide that it wouldn’t be morally responsible to fight the old man physically, so you try to negotiate with him. He tells you that he is undefeated in his stone matching game. If you can win the game, he’ll forfeit the treasure. If you lose, he will decide your fate.");

                Console.WriteLine("\n\nEnter START to display game");

                MntStoneStart: // checkpoint to come back if user inputs invalid option
                string MntStoneStart = Console.ReadLine();
                string MntUpperStoneStart = MntStoneStart.ToUpper(); // converts user input to all capitals

                if (MntUpperStoneStart == "START")
                {
                    Console.Clear(); // clears previous lines of text to start game
                }
                else if (MntUpperStoneStart == "X")
                {
                    Environment.Exit(0); // exits the application
                }
                else
                {
                    Console.WriteLine("Enter valid option");
                    goto MntStoneStart; // goes back to gameplay checkpoint if user inputs invalid answer
                }

                /*
				MATCHING GAME ANSWERS
				Red = A6
				Yellow = B3
				Green = C8
				White = D1
				Dark Gray = E5
				Magenta = F4
				Blue = G2
				Cyan = H7
				*/

                // gameboard display
                Console.WriteLine("\n      MATCHING GAME"); // title

                Console.ForegroundColor = ConsoleColor.Blue; // G is displayed in blue
                Console.Write("G\t");
                Console.ForegroundColor = ConsoleColor.White; // 1 is displayed in white
                Console.Write("1\t");
                Console.ForegroundColor = ConsoleColor.Green; // C is displayed in green
                Console.Write("C\t");
                Console.ForegroundColor = ConsoleColor.Yellow; // 3 is displayed in yellow
                Console.Write("3\n\n");
                Console.ForegroundColor = ConsoleColor.DarkGray; // 5 is displayed in gray
                Console.Write("5\t");
                Console.ForegroundColor = ConsoleColor.Magenta; // F is displayed in magenta
                Console.Write("F\t");
                Console.ForegroundColor = ConsoleColor.Red; // A is displayed in red
                Console.Write("A\t");
                Console.ForegroundColor = ConsoleColor.Magenta; // 4 is displayed in magenta
                Console.Write("4\n\n");
                Console.ForegroundColor = ConsoleColor.Green; // 8 is displayed in green
                Console.Write("8\t");
                Console.ForegroundColor = ConsoleColor.Cyan; // H is displayed in cyan
                Console.Write("H\t");
                Console.ForegroundColor = ConsoleColor.Blue; // 2 is displayed in blue
                Console.Write("2\t");
                Console.ForegroundColor = ConsoleColor.DarkGray; // E is displayed in gray
                Console.Write("E\n\n");
                Console.ForegroundColor = ConsoleColor.Red; // 6 is displayed in red
                Console.Write("6\t");
                Console.ForegroundColor = ConsoleColor.White; // D is displayed in white
                Console.Write("D\t");
                Console.ForegroundColor = ConsoleColor.Yellow; // B is displayed in yellow
                Console.Write("B\t");
                Console.ForegroundColor = ConsoleColor.Cyan; // 7 is displayed in cyan
                Console.Write("7\n\n");

                Console.ForegroundColor = ConsoleColor.Gray; // reset other text to normal colour

                // instructions
                Console.WriteLine("\nFor this game, you will have to memorize the colour of each number and each letter, displayed above. The answers of the stones will be displayed on the screen until you press a key to continue. The screen will ask you to input the numbers for stones A-H. You must input the number that had the same colour as the letter displayed. For example, if both K and 9 are a match, they will be the same colour. To win the game, guess at least 5 matches correctly. \n");

                Console.WriteLine("Press any key to start the game");
                Console.ReadKey(); // user can start the game whenever they are ready
                Console.SetCursorPosition(0, 2); // sets the cursor to the start of the gameboard display
                Console.WriteLine("■\t■\t■\t■\t\n\n■\t■\t■\t■\n\n■\t■\t■\t■\n\n■\t■\t■\t■\n\n\n\n\n\n\n\n\n\n\n\n\n"); // used to cover up gameboard 

                gameplay: // checkpoint to come back if user inputs invalid option
                          // setting matches
                char[] StoneLetter = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', }; // values for letter
                int[] StoneNumber = { 6, 3, 8, 1, 5, 4, 2, 7 }; // matching values for numbers
                int[] InputStoneNumber = new int[8]; // new array for user to input values as answers
                int Match = 0;

                try
                {
                    // gameplay
                    for (int i = 0; i < StoneLetter.Length; i++) // loops 8 times since there are 8 matches
                    {
                        Console.WriteLine("MATCHING STONE ANSWERS: " + StoneLetter[i] + StoneNumber[i]); //debug answers
                        Console.WriteLine("Enter number for stone " + StoneLetter[i] + ": "); // display stone letters
                        InputStoneNumber[i] = int.Parse(Console.ReadLine()); // stores user input into "InputStoneNumber" array

                        if (InputStoneNumber[i] == StoneNumber[i])
                        {
                            Match += 1; // add 1 point if user guesses a match correctly, doesn't do anything if it is incorrect
                        }

                    }

                    // processing results
                    Console.WriteLine("\nStone:\tYour Answer:\tCorrect Answer:");

                    for (int i = 0; i < StoneLetter.Length; i++)
                    {
                        Console.WriteLine(StoneLetter[i] + "\t" + InputStoneNumber[i] + "\t\t" + StoneNumber[i]); // compares user answers with correct answers
                    }

                    if (Match >= 5) // user wins if they score 5 or more correct guesses
                    {
                        Console.WriteLine("\nScore: " + Match + " point(s)");
                        Console.WriteLine("You Win!");
                        Console.WriteLine("\nYou win the game of matching stones, which surprises the old man. He is so surprised that he dies of shock. You didn’t travel all this way to mourn a random stranger, so you collect your treasure and go home. Your grandmother is so proud of you. However, there is still more treasure to be discovered.");
                        sw.WriteLine("Congratulations! You retrieved the treasure and made it out with your life and " + Luck + " luck. Your grandma is very proud of you. Good Mountain Ending: Master Stone Matcher Unlocked!"); //save good mountain ending
                        sw.Close(); //close streamwriter
                    }
                    else if (Match < 5) // user loses if they score less than 5 correct guesses
                    {
                        Console.WriteLine("\nScore: " + Match + " point(s)");
                        Console.WriteLine("You Lose!");
                        Console.WriteLine("\nYou lose the game of matching stones, as expected by the old man. You are unable to cope with your defeat so you get into a fist fight with him. What you don’t know is that the old man has a black belt in every martial art you can think of. He shoves you off the mountain and you fall to your death. Your grandma will never know what happened to you, but she dies of guilt shortly after, regretting her decision to send you to the mountain.");
                        sw.WriteLine("GAME OVER, unfortunately the treasure will not be yours today. You finished with " + Luck + " Luck. Bad Mountain Ending: You Killed Your Grandma, Scotty unlocked."); //save bad mountain ending
                        sw.Close(); //close streamwriter 
                    }
                }
                catch // catches errors/invalid inputs
                {
                    Console.WriteLine("The old man smacks you in the face and tells you to play the game properly. Start from A and only enter numbers. (Hint: The numbers are 1-8)\n"); // tells user to only enter numbers
                    goto gameplay; // goes back to gameplay checkpoint if user inputs invalid answer
                }


                Console.WriteLine("\nPlay Again? (y/n)");
                MountainPlayAgain:
                string MntPlayAgain = Console.ReadLine();
                string MntUpperPlayAgain = MntPlayAgain.ToUpper(); // converts user input to all capitals

                if (MntUpperPlayAgain == "Y")
                {
                    Main(new[] { string.Empty }); // goes back to the start of the game
                }
                else if (MntUpperPlayAgain == "N")
                {
                    Environment.Exit(0); // exits the application
                }
                else if (MntUpperPlayAgain == "X")
                {
                    Environment.Exit(0); // exits the application
                }
                else
                {
                    Console.WriteLine("Enter valid option");
                    goto MountainPlayAgain; // goes back to gameplay checkpoint if user inputs invalid answer
                }

            }

            Console.ReadKey(); // stops code from running by itself
        }

        //sea storyline: written by Tuhina
        public static void Sea()
        {
            StreamWriter sw = new StreamWriter("SeaEndings.txt"); //will write to sea endings file
            //CHOICE 1: SHIP
            Console.WriteLine("Look’s like you’ve decided to head for the sea. As you reach the docks you notice two ships. There is a big ship that looks like there is enough space to fit a full crew.");//Displays Story Line Text
            Console.WriteLine("That’ll be good for storing food and materials. Right beside is a small wooden ship. It looks like it can fit one days’ worth of materials.");//Displays Story Line Text
            Console.WriteLine("Which ship do you choose?");//Displays Story Line Text
            Ship: //marker for goto statments used below 
            Console.WriteLine("A: Large Ship"); //Display choices for user 
            Console.WriteLine("B: Small Ship");//Display choices for user
            string Ship = Console.ReadLine().ToUpper(); //this line reads the user input, converts the string to uppercase so I don't have to manually type out all the possible valid inputs
            int Luck = 0; //declares a variable for luck

            if (Ship == "A")//sets the condition so that if user enters option A the following instructions will be executed 
            {
                Console.WriteLine("You chose the Large ship. It’s good to be prepared, good choice! +20 Luck!"); //displays the output for the users' specific choice
                Luck = Luck + 20; //adds a certain amount to the user luck 
                Console.WriteLine("Your current Luck: " + Luck); //displays the user's cumulative luck 
                Console.WriteLine("");// for spacing/formatting 
            }
            else if (Ship == "B")//sets the condition so that if user enters option B the following instructions will be executed
            {
                Console.WriteLine("You chose the Small ship. Looks like you’ll have to be resourceful on your trip. +10 Luck.");//displays the output for the users' specific choice
                Luck = Luck + 10; //adds a certain amount to the user luck 
                Console.WriteLine("Your current Luck: " + Luck);//displays the user's cumulative luck 
                Console.WriteLine("");// for spacing/formatting
            }
            else if (Ship == "X")//sets the condition so that is user ever enters X it will allow them to quit the game 
            {
                Environment.Exit(0); //closes the program 
            }
            else //catches any other input (invalid inputs)
            {
                Console.WriteLine("Please enter valid option. Remember your options are either 'A' or 'B'."); //tells user that their input is invalid and reminds them the valid options
                goto Ship; //goes to Ship marker 
            }

            //CHOICE 2: DIRECTION
            Console.WriteLine("You’ve chosen your ship and packed whatever you could.It’s time to set sail!You raise the anchors and release the sails.");//Displays Story Line Text
            Console.WriteLine("Your ship starts to move and you are off to find your grandma’s treasure hidden on the Long Lost Island. You check your map and see that you need to head east to get to the long-lost island the quickest.");//Displays Story Line Text
            Console.WriteLine("There are two paths you can take, either head North East or North West. Do you want to head East and get to the treasure as soon as possible or do you want to head West and take your time??");//Displays Story Line Text
            Direction: //marker for goto statments used below 
            Console.WriteLine("A: Head North-East ");//Display choices for user
            Console.WriteLine("B: Head North-West ");//Display choices for user
            string Direction = Console.ReadLine().ToUpper();//this line reads the user input, converts the string to uppercase

            if (Direction == "A")//sets the condition so that if user enters option A the following instructions will be executed
            {
                Console.WriteLine("You chose to head North-East. This path is faster, at this rate you’ll reach the treasure in no time! +10 Luck");//displays the output for the users' specific choice
                Luck = Luck + 10;//adds a certain amount to the user luck 
                Console.WriteLine("Your current Luck: " + Luck);//displays the user's cumulative luck 
                Console.WriteLine("");// for spacing/formatting
            }

            else if (Direction == "B")//sets the condition so that if user enters option B the following instructions will be executed
            {
                Console.WriteLine("You chose to head North-West. This path takes too long. You detour and go North-East instead.-10 Luck.");//displays the output for the users' specific choice
                Luck = Luck - 10;//takes away a certain amount to the user luck 
                Console.WriteLine("Your current Luck: " + Luck);//displays the user's cumulative luck 
                Console.WriteLine("");// for spacing/formatting
            }
            else if (Direction == "X") //sets the condition so that is user ever enters X it will allow them to quit the game  
            {
                Environment.Exit(0);//closes the program 
            }
            else//catches any other input (invalid inputs)
            {
                Console.WriteLine("Please enter valid option. Remember your options are either 'A' or 'B'.");//tells user that their input is invalid and reminds them the valid options
                goto Direction; // goes to direction marker 
            }

            //CHOICE 3: EAT
            Console.WriteLine("You continue down the sea. As you take in the blue scenery you suddenly hear your stomach growl.");//Displays Story Line Text
            Console.WriteLine("It’s time to eat. You head over to your food stash and see a wide variety of foods to eat. Do you want to have a feast or do you eat a small portion??");//Displays Story Line Text
            Eat://marker for goto statments used below 
            Console.WriteLine("A: Have a Feast ");//Display choices for user
            Console.WriteLine("B: Eat a Small Portion");//Display choices for user
            string Eat = Console.ReadLine().ToUpper();//this line reads the user input, converts the string to uppercase

            if (Eat == "A")//sets the condition so that if user enters option A the following instructions will be executed
            {
                Console.WriteLine("You chose to have a feast. Phew, that was some delicious food! You’re stuffed, but you look at your food stash and there are only two pieces of bread left :/ ");//displays the output for the users' specific choice
                Console.WriteLine("Hopefully, your adventure ends soon or you may starve! +5 Luck");//displays the output for the users' specific choice
                Luck = Luck + 5;//adds a certain amount to the user luck 
                Console.WriteLine("Your current Luck: " + Luck);//displays the user's cumulative luck 
                Console.WriteLine("");// for spacing/formatting
            }

            else if (Eat == "B")//sets the condition so that if user enters option B the following instructions will be executed
            {
                Console.WriteLine("You chose to portion your food. That was a pretty good lunch and there are loads more to spare in case of an emergency! +15 luck!");//displays the output for the users' specific choice
                Luck = Luck + 15;//adds a certain amount to the user luck 
                Console.WriteLine("Your current Luck: " + Luck);//displays the user's cumulative luck 
                Console.WriteLine("");// for spacing/formatting

            }
            else if (Eat == "X")//sets the condition so that is user ever enters X it will allow them to quit the game 
            {
                Environment.Exit(0);//closes the program 
            }
            else//catches any other input (invalid inputs)
            {
                Console.WriteLine("Please enter valid option. Remember your options are either 'A' or 'B'.");//tells user that their input is invalid and reminds them the valid options
                goto Eat; // goes to the eat marker 
            }

            //CHOICE 4: COURAGE
            Console.WriteLine("You’ve made it quite far in your journey. Up ahead you notice some problems. "); //Displays Story Line Text
            Console.WriteLine("To your left, you see a never-ending fog that covers the journey ahead, and to your right, you see stormy seas and harsh winds.");//Displays Story Line Text
            Console.WriteLine("Do you choose to sail down the eerie fogs or courageously journey across the stormy seas?");//Displays Story Line Text
            Courage: //marker for goto statments used below 
            Console.WriteLine("A: Stormy Seas");//Display choices for user
            Console.WriteLine("B: Eerie Fogs ");//Display choices for user
            string Courage = Console.ReadLine().ToUpper();//this line reads the user input, converts the string to uppercase

            if (Courage == "A") //sets the condition so that if user enters option A the following instructions will be executed
            {
                Console.WriteLine("You chose to venture down the stormy seas. You truly are a brave adventurer. +20 luck!");//displays the output for the users' specific choice
                Luck = Luck + 20;//adds a certain amount to the user luck 
                Console.WriteLine("Your current Luck: " + Luck);//displays the user's cumulative luck 
                Console.WriteLine("");// for spacing/formatting
            }
            else if (Courage == "B")//sets the condition so that if user enters option B the following instructions will be executed
            {
                Console.WriteLine("You chose to journey down the eerie fog. The further you sail, the harder it becomes to see. You pray that the fog clears up soon otherwise you’ll get lost.+10 Luck.");//displays the output for the users' specific choice
                Luck = Luck + 10;//adds a certain amount to the user luck 
                Console.WriteLine("Your current Luck: " + Luck);//displays the user's cumulative luck 
                Console.WriteLine("");// for spacing/formatting
            }
            else if (Courage == "X")//sets the condition so that is user ever enters X it will allow them to quit the game 
            {
                Environment.Exit(0);//closes the program 
            }
            else//catches any other input (invalid inputs)
            {
                Console.WriteLine("Please enter valid option. Remember your options are either 'A' or 'B'.");//tells user that their input is invalid and reminds them the valid options
                goto Courage; //goes to the courage marker 
            }

            //CHOICE 5: ATTACK
            Console.WriteLine("After braving the perils of the sea you finally are able to enjoy clear skies.You check your map and you see that you’re getting closer to the long-lost island.");//Displays Story Line Text
            Console.WriteLine("You’ll be able to obtain your grandma’s treasure soon! Before you get to finish your thought you hear a loud noise. ");//Displays Story Line Text
            Console.WriteLine("OH NO!! You are being attacked by ships passing by. You see One big ship firing large cannons at you and beside it are two small ships firing smaller cannons at you. Your rush over to your cannons.");//Displays Story Line Text
            Console.WriteLine("Quick! Which ships do you fire at ?? Enter Big to fire at the big ships or Tiny to fire at the 2 tiny ships.");//Displays Story Line Text
            Attack: //marker for goto statments used below 
            Console.WriteLine("A: Big Ship");//Display choices for user
            Console.WriteLine("B: 2 Tiny ships");//Display choices for user

            string Attack = Console.ReadLine().ToUpper();//this line reads the user input, converts the string to uppercase

            if (Attack == "A")//sets the condition so that if user enters option A the following instructions will be executed
            {
                Console.WriteLine("You chose to fire at the big ship. The big ship gets destroyed taking the two tiny ships along with it. That was close, good thinking! +30 luck"); //displays the output for the users' specific choice
                Luck = Luck + 30;//adds a certain amount to the user luck 
                Console.WriteLine("Your current Luck: " + Luck);//displays the user's cumulative luck 
                Console.WriteLine("");// for spacing/formatting
            }
            else if (Attack == "B")//sets the condition so that if user enters option B the following instructions will be executed
            {
                Console.WriteLine("You chose to fire at the tiny ships. You manage to take them down however the big ship is still floating. Luckily taking down the small ships distracted the big ship giving you just enough time to escape. ");//displays the output for the users' specific choice
                Console.WriteLine("Next time be more careful. - 10 luck");//displays the output for the users' specific choice
                Luck = Luck - 10;//takes away a certain amount to the user luck 
                Console.WriteLine("Your current Luck: " + Luck);//displays the user's cumulative luck 
                Console.WriteLine("");// for spacing/formatting
            }
            else if (Attack == "X")//sets the condition so that is user ever enters X it will allow them to quit the game 
            {
                Environment.Exit(0);//closes the program 
            }
            else//catches any other input (invalid inputs)
            {
                Console.WriteLine("Please enter valid option. Remember your options are either 'A' or 'B'.");//tells user that their input is invalid and reminds them the valid options
                goto Attack; // goes to the attack marker 
            }

            //CHOICE 6 REST
            Console.WriteLine("You manage to get out of trouble once again. Who knew there would be hostile ships in the middle of the sea??");//Displays Story Line Text
            Console.WriteLine("You check your map and you’re at the home stretch of your journey, but you’re feeling awfully tired. Do you want to take a nap or drink coffee?");//Displays Story Line Text
            Rest: //marker for goto statments used below 
            Console.WriteLine("A: Take A Nap ");//Display choices for user
            Console.WriteLine("B: Drink Coffee");//Display choices for user


            string Rest = Console.ReadLine().ToUpper();//this line reads the user input, converts the string to uppercase

            if (Rest == "A")//sets the condition so that if user enters option A the following instructions will be executed
            {
                Console.WriteLine("You chose to take a nap. Oops, there’s no one on board to wake you up so you overslept. Now you sailed off course, luckily you were able to steer yourself back on course.");//displays the output for the users' specific choice
                Console.WriteLine("That was a waste of time, but at least you’re energized. -10 luck");//displays the output for the users' specific choice
                Luck = Luck - 10;//takes away a certain amount to the user luck 
                Console.WriteLine("Your current Luck: " + Luck);//displays the user's cumulative luck 
                Console.WriteLine("");// for spacing/formatting
            }
            else if (Rest == "B")//sets the condition so that if user enters option B the following instructions will be executed
            {
                Console.WriteLine("You chose to drink coffee. That coffee was quite strong. Your tiredness is gone and you’re ready to face whatever your journey brings next. +10 Luck!");//displays the output for the users' specific choice
                Luck = Luck + 10;//adds a certain amount to the user luck 
                Console.WriteLine("Your current Luck: " + Luck);//displays the user's cumulative luck 
                Console.WriteLine("");// for spacing/formatting
            }
            else if (Rest == "X")//sets the condition so that is user ever enters X it will allow them to quit the game 
            {
                Environment.Exit(0);//closes the program 
            }
            else//catches any other input (invalid inputs)
            {
                Console.WriteLine("Please enter valid option. Remember your options are either 'A' or 'B'.");//tells user that their input is invalid and reminds them the valid options
                goto Rest; // goes to the rest marker 
            }

            //MEET SEA COW BOSS STORY
            Console.WriteLine("After energizing you notice an island in front of you. You check your map and realize It’s The long-lost island!!");//Displays Story Line Text
            Console.WriteLine("Before you can progress any further your ship starts to shake. In front of you is a large whale with skin that resembles….. a cow??? ");//Displays Story Line Text
            Console.WriteLine("“BEHOLD I AM SEA COW THE PROTECTOR OF THE LONG LOST ISLAND, IF YOU WANT TO GET TO THE ISLAND YOU MUST GUESS THE NUMBER THAT I AM THINKING OF.");//Displays Story Line Text
            Console.WriteLine("IF YOU ARE LUCKY I’LL BE NICE AND MAKE THIS GAME EASY. IF YOU‘RE UNLUCKY THIS GAME WON’T BE EASY.");//Displays Story Line Text
            Console.WriteLine("You stare in disbelief and wonder how your grandma went through all this trouble to hide the treasure, a cheque would’ve been much easier….");//Displays Story Line Text
            Console.WriteLine(" Regardless, you decide to test your luck. Press the enter key to test your luck");//Displays Story Line Text
            Console.WriteLine("");// for spacing/formatting
            Console.WriteLine("Your current Luck: " + Luck);//displays the user's cumulative luck 
            Console.ReadLine(); //adds a pause in bewteen story texts, hitting enter continues tha story 

            //SEA COW GEUSS GAME EASY MODE
            if (Luck >= 70) //sets the condition so that if the user luck is high enough they will get the easy version game 
            {
                Console.WriteLine("Sea cow begins to speak.");//Displays Story Line Text
                Console.WriteLine("“LOOKS LIKE YOU GOT LUCKY TODAY. TO GET TO THE ISLAND YOU MUST GUESS THE NUMBER I AM THINKING OF BETWEEN 1 AND 100.");//Displays Story Line Text
                Console.WriteLine("YOU HAVE AN UNLIMITED AMOUNT OF GUESSES  UNTIL YOU GUESS CORRECTLY!”");//Displays Story Line Text
                Console.WriteLine("Gosh, this sea cow yells a lot… guess it’s boss battle time.");//Displays Story Line Text

                //GAME START
                Console.WriteLine("");// for spacing/formatting
                Console.WriteLine("BOSS BATTLE");
                //EASY MODE
                Random rnd = new Random(); //creates a random number 
                int CowNum = rnd.Next(0, 101); //sets a variable and a range of numbers for the random number 
                int PlayerGuess = 0; //declares a variable for the players guess 
                int CloseLow = CowNum - 5; //sets a variable for numbers that are close to the correct number 
                int CloseHigh = CowNum + 5;//sets a variable for numbers that are close to the correct number

                Console.WriteLine("I HAVE PICKED MY NUMBER START GUESSING, I WILL GIVE YOU HINTS ON THE WAY. IF YOU WANT TO QUIT GAME ENTER THIS CODE: 12345");//Displays Story Line Text\
                //DEBUG MODE :
                Console.WriteLine("Debug Mode, Answer is: " + CowNum); //This line is for debug/programming purposes, will be disabled later 
                do//starts a do while loop to have the game repeat 
                {
                    MarkerEasy: //marker for goto statments used below 
                    Console.WriteLine("Enter your guess in Numbers only, There won't be any decimals.");//displays game instructions to user 
                    try //checks for correct input 
                    {
                        PlayerGuess = int.Parse(Console.ReadLine()); //reads user input and converts it from string data type to integer data type 
                    }
                    catch //catches exceptions 
                    {
                        Console.WriteLine("ADVENTURER ARE YOU PAYING ATTENTION?? GUESS USING WHOLE NUMBERS :|");//tells user that their input is invalid and reminds them the valid options
                        goto MarkerEasy; // goes to MarkerEasy marker 
                    }
                    if (PlayerGuess == 12345)//sets the condition so that if the user enters this code they will be able to exit the program. 
                    {
                        Environment.Exit(0);//closes the program 
                    }
                    else if (PlayerGuess >= CloseLow & PlayerGuess < CowNum) //sets the condition so that if the user guess is close but low it'll display certain text 
                    {
                        Console.WriteLine("YOUR GETTING CLOSER BUT YOUR GUESS IS LOW"); // let's the user know their guess was incorrect and gives them hints 
                    }
                    else if (PlayerGuess <= CloseHigh & PlayerGuess > CowNum)//sets the condition so that if the user guess is close but high it'll display certain text 
                    {
                        Console.WriteLine("YOUR GETTING CLOSER BUT YOUR GUESS IS HIGH");// let's the user know their guess was incorrect and gives them hints 
                    }
                    else if (PlayerGuess < CowNum & PlayerGuess > 0) //sets the condition so that if the user's guess is to low it tels the user 
                    {
                        Console.WriteLine("YOUR GUESS IS TOO LOW ");// let's the user know their guess was incorrect and gives them hints 
                    }
                    else if (PlayerGuess > CowNum & PlayerGuess < 101)//sets the condition so that if the user's guess is to high it tels the user
                    {
                        Console.WriteLine("YOUR GUESS IS TOO HIGH");// let's the user know their guess was incorrect and gives them hints 
                    }
                    else if (PlayerGuess < 0 || PlayerGuess > 100) //catches any guesses that are outside the range 
                    {
                        Console.WriteLine("ADVENTURER YOUR GUESS IS WAY OFF :/ REMEMBER YOUR RANGE IS WITHIN 1 AND 100"); //reminds the user the range that their guess has to be in 
                    }
                    else if (PlayerGuess == CowNum) //sets the condition so that if the user's guess it correct it let's them know 
                    {
                        Console.WriteLine("CONGRATULATIONS ADVENTURER YOU GUESSED THE NUMBER CORRECTLY"); //congratulates the user for their correct guess 

                    }
                } while (PlayerGuess != CowNum); //sets the condtion so that the game will continue until the user guesses correctly 

                //END 1 GOOD ENDING:
                Console.WriteLine("");// for spacing/formatting
                Console.WriteLine("Good Sea Ending Reached:");//Displays Story Line Text
                Console.WriteLine("");// for spacing/formatting
                Console.WriteLine("LOOKS LIKE YOU WON MY GAME ADVENTURER!! YOU MAY CROSS TO THE LONG-LOST ISLAND! ");//Displays Story Line Text
                Console.WriteLine("You cross over to the long-lost island. You head to the center of the island and just as the map promised there lies grandma's treasure. ");//Displays Story Line Text
                Console.WriteLine("Finally, after such a long journey grandma’s treasure is all yours to enjoy! Good work Adventurer! Luck +50");//Displays Story Line Text
                Console.WriteLine("");// for spacing/formatting
                Luck = Luck + 50;//adds a certain amount to the user luck 
                Console.WriteLine("\nCongratulations! You retrieved the treasure and made it out with your life and " + Luck + " luck. Your grandma is very proud of you.Your ending has been saved. However, there is still more treasure to be found. Would you like to play again?\nY: yes\nN: no");
                sw.WriteLine("Congratulations! You retrieved the treasure and made it out with your life and " + Luck + " luck. Your grandma is very proud of you. Good Sea Ending: Sea Cow Slayer Unlocked!"); //save good sea ending
                sw.Close(); //close streamwriter
                //goto if user inputs invalid option
                Replay:
                //initialize input
                string Input = Console.ReadLine();
                //send to beginning of program
                if (Input == "Y" || Input == "y")
                {
                    Main(new[] { string.Empty });
                }
                //close console
                else if (Input == "N" || Input == "n")
                {
                    Environment.Exit(0);
                }
                //send to beginning of if statement if input is invalid
                else
                {
                    Console.WriteLine("Please enter a valid option.");
                    goto Replay;
                }
                Console.WriteLine("");// for spacing/formatting

            }

            //SEA COW GUESS GAME HARD MODE
            else if (Luck < 70) // sets the condition so that if the user luck is too low they will get the hard version of the game 
            {
                Console.WriteLine("Sea cow begins to speak.");
                Console.WriteLine("”HAHAHA YOU FOOL, LOOKS LIKE YOUR OUT OF LUCK TODAY!! THIS GAME WON’T BE EASY. ");//Displays Story Line Text
                Console.WriteLine("I WILL PICK A NUMBER BETWEEN 1 AND 1000. YOU HAVE 10 CHANCES TO GUESS CORRECTLY. GET READY FOR YOUR DEATH!!”");//Displays Story Line Text
                Console.WriteLine("Gosh, this sea cow yells a lot… things aren’t looking too good but you’ve travelled this far, there’s no point in giving up now. ");//Displays Story Line Text
                Console.WriteLine("Guess it’s boss battle time. Press the enter Key to start guessing.");//Displays Story Line Text

                //GAME START
                Console.WriteLine("");// for spacing/formatting
                Console.WriteLine("BOSS BATTLE");//Displays Story Line Text
                //HARD MODE:
                Random rnd = new Random();//creates a random number
                int CowNum = rnd.Next(1, 1000);//sets a variable and a range of numbers for the random number
                int PlayerGuess = 0; //Sets a variable for the users guess 

                Console.WriteLine("I HAVE PICKED MY NUMBER START GUESSING. NO HINTS FOR YOU :). IF YOU WANT TO QUIT GAME ENTER THIS CODE: 12345");//Displays Story Line Text
                //DEBUG MODE:
                Console.WriteLine("Debug Mode, Answer is: " + CowNum); //this line is development/debugging purposes, will be disabled later 

                int Guess = 0; //sets a variable for the amount of guesses the user has
                int GuesLeft = 0;//sets a variable for the amount of guesses the user has

                for (Guess = 0; Guess < 10; Guess++) //creates a loop that will allow user to have only ten guess (loops ten times )
                {
                    GuesLeft = 9 - Guess; // calcutlates the amount of guesses the user has left using the amount of guesses were used
                    MarkerHard://marker for goto statments used below 
                    Console.WriteLine("Enter your guess in Numbers only, There won't be any decimals.");//displays game instructions to user 

                    try//checks for correct input 
                    {
                        PlayerGuess = int.Parse(Console.ReadLine());//reads user input and converts it from string data type to integer data type
                    }
                    catch //catches exceptions 
                    {
                        Console.WriteLine("ADVENTURER ARE YOU PAYING ATTENTION?? GUESS USING WHOLE NUMBERS :|");//tells user that their input is invalid and reminds them the valid options
                        goto MarkerHard; //goes to the MarkerHard marker 
                    }

                    if (PlayerGuess == 12345)//sets the condition so that if the user enters this code they will be able to exit the program.
                    {
                        Environment.Exit(0);//closes the program 
                    }

                    else if (PlayerGuess != CowNum & PlayerGuess > 0 & PlayerGuess < 1001) //sets the conditions so that if the user's guess is incorrect it executes the following instructions 
                    {
                        Console.WriteLine("YOUR GUESS IS INCORRECT ADVENTURER"); //tells the user that their guess is wrong 
                        Console.WriteLine("Guesses left: " + GuesLeft);//tells the user how many guesses they have left 
                    }
                    else if (PlayerGuess < 0 || PlayerGuess > 1000)//catches any guesses that are outside the range 
                    {
                        Console.WriteLine("ADVENTURER YOUR GUESS IS WAY OFF :/ REMEMBER YOUR RANGE IS WITHIN 1 AND 1000");//reminds the user the range that their guess has to be in
                        Console.WriteLine("Guesses left: " + GuesLeft); //tells the user how many guesses they have left 
                    }
                    else if (PlayerGuess == CowNum)//sets the condition so that if the user's guess it correct it let's them know
                    {
                        Console.WriteLine("CONGRATULATIONS ADVENTURER YOU GUESSED THE NUMBER CORRECTLY");//congratulates the user for their correct guess 
                        break; //exits the loop 
                    }
                }
                if (GuesLeft <= 0) //sets the condtion so that if the user runs out of guesses they lose and get the bad ending 
                {
                    // END 2: BAD ENDING:
                    Console.WriteLine("Bad Sea Ending Reached:");//Displays Story Line Text
                    Console.WriteLine("HAHAHA LOOKS LIKE YOU’VE FAILED MISERABLY!!! HAVE FUN BEING MY MID-DAY SNACK !!");//Displays Story Line Text
                    Console.WriteLine("Before you have a chance to escape, the sea cow swallows your ship whole. Hope you enjoy stomach acid because that’s your next destination…");//Displays Story Line Text
                    Console.WriteLine("looks like you’re never seeing that treasure or grandma ever again. :( -50 Luck");//Displays Story Line Text
                    Console.WriteLine("");// for spacing/formatting
                    Luck = Luck - 50;//Takes away a certain amount to the user luck 
                    Console.WriteLine("\nGAME OVER. Your ending has been saved.\n\nPlay again?\nY: yes\nN: no");
                    sw.WriteLine("GAME OVER, unfortunately the treasure will not be yours today. You finished with " + Luck + " Luck. Bad Sea Ending: Sea Cow Snack unlocked."); //save bad sea ending
                    sw.Close(); //close streamwriter
                    //goto if user inputs invalid option
                    Replay:
                    //initialize input
                    string Input = Console.ReadLine();
                    //send to beginning of program
                    if (Input == "Y" || Input == "y")
                    {
                        Main(new[] { string.Empty });
                    }
                    //close console
                    else if (Input == "N" || Input == "n")
                    {
                        Environment.Exit(0);
                    }
                    //send to beginning of if statement if input is invalid
                    else
                    {
                        Console.WriteLine("Please enter a valid option.");
                        goto Replay;
                    }
                    Console.WriteLine("");// for spacing/formatting
                }
                else if (GuesLeft > 0 & PlayerGuess == CowNum)// sets the condtion so that if the user guesses the number correctly and they have guesses left they've won and get the good ending
                {
                    //END 1 GOOD ENDING:
                    Console.WriteLine("");// for spacing/formatting
                    Console.WriteLine("Good Sea Ending Reached:");// Displays Story Line Text
                    Console.WriteLine("");// for spacing/formatting
                    Console.WriteLine("LOOKS LIKE YOU WON MY GAME ADVENTURER!! YOU MAY CROSS TO THE LONG-LOST ISLAND! ");//Displays Story Line Text
                    Console.WriteLine("You cross over to the long-lost island. You head to the center of the island and just as the map promised there lies grandma's treasure. Luck +50");//Displays Story Line Text
                    Console.WriteLine("");// for spacing/formatting
                    Luck = Luck + 50;//adds a certain amount to the user luck 
                    Console.WriteLine("\nCongratulations! You retrieved the treasure and made it out with your life and " + Luck + " luck. Your grandma is very proud of you. However, there is still more treasure to be found. Would you like to play again?\nY: yes\nN: no");//displays storyline
                    sw.WriteLine("Congratulations! You retrieved the treasure and made it out with your life and " + Luck + " luck. Your grandma is very proud of you. Good Sea Ending: Sea Cow Slayer Unlocked!");
                    sw.Close();
                    //goto if user inputs invalid option
                    Replay:
                    //initialize input
                    string Input = Console.ReadLine();
                    //send to beginning of program
                    if (Input == "Y" || Input == "y")
                    {
                        Main(new[] { string.Empty });
                    }
                    //close console
                    else if (Input == "N" || Input == "n")
                    {
                        Environment.Exit(0);
                    }
                    //send to beginning of if statement if input is invalid
                    else
                    {
                        Console.WriteLine("Please enter a valid option.");
                        goto Replay;
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
