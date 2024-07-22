using System;
using System.ComponentModel.Design;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Channels;
namespace RockPaperScissorsGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write the name with which you will compete:");
            string playerName = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine($"Hello,{playerName}!");
            Console.WriteLine("");
            Console.WriteLine("Are you ready to engage in a tough battle with other rock,scissors,paper opponents to win tickets to all the matches of the 2026 FIFA World Cup in America?");
            Console.WriteLine("");
            Console.WriteLine("Write yes or no!");
            int health = 100;
            string answer = Console.ReadLine();
            string rock = "";
            string scissors = "";
            string paper = "";
            Console.WriteLine("");
            while (health >= 0 )
            {


                if (answer == "yes")
                {
                    Console.WriteLine("The game begins,but before that,the rules:");
                    Console.WriteLine("There are 20 rounds,if you win a round you get 20 points and if you lose you lose 20 life points.You win the game if you last until the 20th round and you are above 0 life points!Good luck!");
                    Console.WriteLine("");
                    Console.WriteLine("=========");
                    Console.WriteLine("|Round 1|");
                    Console.WriteLine("=========");
                    Console.WriteLine("In the first round you are facing the best Bulgarian tennis player - Grigor Dimitrov!");
                    Console.WriteLine("");
                    Console.WriteLine("What do you choose :rock,scissors or paper?");
                    Console.WriteLine("");
                    string secondAsnwer = Console.ReadLine();
                    Console.WriteLine($"You chose {secondAsnwer}!");

                    if (secondAsnwer == "rock")
                    {
                        int type = new Random().Next(1, 3);

                        switch (type)
                        {
                            case 1:
                                Console.WriteLine("");
                                Console.WriteLine("Grigor Dimitrov chose:scissors!You win!You gain 20 life points and proceed to the 2nd round!Good luck!");
                                Console.WriteLine("");
                                health = health + 20;
                                Console.WriteLine($"Your health is {health}!");
                                break;
                            case 2:
                                Console.WriteLine("");
                                Console.WriteLine("Grigor Dimitrov chose:paper!You lose!You lose 20 life points,but don't despair,you continue to the 2nd round!Good luck!");
                                Console.WriteLine("");
                                health = health - 20;
                                Console.WriteLine($"Your health is {health}!");
                                break;
                        }

                    }
                    else if (secondAsnwer == "scissors")
                    {
                        int type = new Random().Next(1, 3);

                        switch (type)
                        {
                            case 1:
                                Console.WriteLine("");
                                Console.WriteLine("Grigor Dimitrov chose:paper!You win!You gain 20 life points and proceed to the 2nd round!Good luck!");
                                Console.WriteLine("");
                                health = health + 20;
                                Console.WriteLine($"Your health is {health}!");
                                break;
                            case 2:
                                Console.WriteLine("");
                                Console.WriteLine("Grigor Dimitrov chose:rock!You lose!You lose 20 life points,but don't despair,you continue to the 2nd round!Good luck!");
                                Console.WriteLine("");
                                health = health - 20;
                                Console.WriteLine($"Your health is {health}!");
                                break;
                        }
                    }
                    else if (secondAsnwer == "paper")
                    {
                        int type = new Random().Next(1, 3);

                        switch (type)
                        {
                            case 1:
                                Console.WriteLine("");
                                Console.WriteLine("Grigor Dimitrov chose:rock!You win!You gain 20 life points and proceed to the 2nd round!Good luck!");
                                Console.WriteLine("");
                                health = health + 20;
                                Console.WriteLine($"Your health is {health}!");
                                break;
                            case 2:
                                Console.WriteLine("");
                                Console.WriteLine("Grigor Dimitrov chose:scissors!You lose!You lose 20 life points,but don't despair,you continue to the 2nd round!Good luck!");
                                Console.WriteLine("");
                                health = health - 20;
                                Console.WriteLine($"Your health is {health}!");
                                break;
                        }
                    }

                    Console.WriteLine("");
                    Console.WriteLine("=========");
                    Console.WriteLine("|Round 2|");
                    Console.WriteLine("=========");
                    Console.WriteLine("In the second round you are facing the best Bulgarian boxer - Kubrat Pulev!");
                    Console.WriteLine("");
                    Console.WriteLine("What do you choose :rock,scissors or paper?");
                    Console.WriteLine("");
                    string thirdAsnwer = Console.ReadLine();
                    Console.WriteLine($"You chose {thirdAsnwer}!");
                    if (thirdAsnwer == "rock")
                    {
                        int type = new Random().Next(1, 3);

                        switch (type)
                        {
                            case 1:
                                Console.WriteLine("");
                                Console.WriteLine("Kubrat Pulev chose:scissors!You win!You gain 20 life points and proceed to the 2nd round!Good luck!");
                                Console.WriteLine("");
                                health = health + 20;
                                Console.WriteLine($"Your health is {health}!");
                                break;
                            case 2:
                                Console.WriteLine("");
                                Console.WriteLine("Kubrat Pulev chose:paper!You lose!You lose 20 life points,but don't despair,you continue to the 3rd round!Good luck!");
                                Console.WriteLine("");
                                health = health - 20;
                                Console.WriteLine($"Your health is {health}!");
                                break;
                        }

                    }
                    else if (thirdAsnwer == "scissors")
                    {
                        int type = new Random().Next(1, 3);

                        switch (type)
                        {
                            case 1:
                                Console.WriteLine("");
                                Console.WriteLine("Kubrat Pulev chose:paper!You win!You gain 20 life points and proceed to the 2nd round!Good luck!");
                                Console.WriteLine("");
                                health = health + 20;
                                Console.WriteLine($"Your health is {health}!");
                                break;
                            case 2:
                                Console.WriteLine("");
                                Console.WriteLine("Kubrat Pulev chose:rock!You lose!You lose 20 life points,but don't despair,you continue to the 3rd round!Good luck!");
                                Console.WriteLine("");
                                health = health - 20;
                                Console.WriteLine($"Your health is {health}!");
                                break;
                        }
                    }
                    else if (thirdAsnwer == "paper")
                    {
                        int type = new Random().Next(1, 3);

                        switch (type)
                        {
                            case 1:
                                Console.WriteLine("");
                                Console.WriteLine("Kubrat Pulev chose:rock!You win!You gain 20 life points and proceed to the 2nd round!Good luck!");
                                Console.WriteLine("");
                                health = health + 20;
                                Console.WriteLine($"Your health is {health}!");
                                break;
                            case 2:
                                Console.WriteLine("");
                                Console.WriteLine("Kubrat Pulev chose:scissors!You lose!You lose 20 life points,but don't despair,you continue to the 3rd round!Good luck!");
                                Console.WriteLine("");
                                health = health - 20;
                                Console.WriteLine($"Your health is {health}!");
                                break;
                        }
                    }
                    Console.WriteLine("");
                    Console.WriteLine("=========");
                    Console.WriteLine("|Round 3|");
                    Console.WriteLine("=========");
                    Console.WriteLine("In the third round you are facing Ivet Lalova - Athlete, one of the fastest women at 100 and 200 meters.!");
                    Console.WriteLine("");
                    Console.WriteLine("What do you choose :rock,scissors or paper?");
                    Console.WriteLine("");
                    string fourthAsnwer = Console.ReadLine();
                    Console.WriteLine($"You chose {fourthAsnwer}!");
                    if (fourthAsnwer == "rock")
                    {
                        int type = new Random().Next(1, 3);

                        switch (type)
                        {
                            case 1:
                                Console.WriteLine("");
                                Console.WriteLine("Ivet Lalova chose:scissors!You win!You gain 20 life points and proceed to the 4th round!Good luck!");
                                Console.WriteLine("");
                                health = health + 20;
                                Console.WriteLine($"Your health is {health}!");
                                break;
                            case 2:
                                Console.WriteLine("");
                                Console.WriteLine("Ivet Lalova chose:paper!You lose!You lose 20 life points,but don't despair,you continue to the 4th round!Good luck!");
                                Console.WriteLine("");
                                health = health - 20;
                                Console.WriteLine($"Your health is {health}!");
                                break;
                        }

                    }
                    else if (fourthAsnwer == "scissors")
                    {
                        int type = new Random().Next(1, 3);

                        switch (type)
                        {
                            case 1:
                                Console.WriteLine("");
                                Console.WriteLine("Ivet Lalova chose:paper!You win!You gain 20 life points and proceed to the 4th round!Good luck!");
                                Console.WriteLine("");
                                health = health + 20;
                                Console.WriteLine($"Your health is {health}!");
                                break;
                            case 2:
                                Console.WriteLine("");
                                Console.WriteLine("Ivet Lalova chose:rock!You lose!You lose 20 life points,but don't despair,you continue to the 4th round!Good luck!");
                                Console.WriteLine("");
                                health = health - 20;
                                Console.WriteLine($"Your health is {health}!");
                                break;
                        }
                    }
                    else if (fourthAsnwer == "paper")
                    {
                        int type = new Random().Next(1, 3);

                        switch (type)
                        {
                            case 1:
                                Console.WriteLine("");
                                Console.WriteLine("Ivet Lalova chose:rock!You win!You gain 20 life points and proceed to the 4th round!Good luck!");
                                Console.WriteLine("");
                                health = health + 20;
                                Console.WriteLine($"Your health is {health}!");
                                break;
                            case 2:
                                Console.WriteLine("");
                                Console.WriteLine("Ivet Lalova chose:scissors!You lose!You lose 20 life points,but don't despair,you continue to the 4th round!Good luck!");
                                Console.WriteLine("");
                                health = health - 20;
                                Console.WriteLine($"Your health is {health}!");
                                break;
                        }
                    }
                    Console.WriteLine("");
                    Console.WriteLine("=========");
                    Console.WriteLine("|Round 4|");
                    Console.WriteLine("=========");
                    Console.WriteLine("In the fourth round you are facing Dimitar Berbatov - Footballer, one of the most successful Bulgarian footballers!");
                    Console.WriteLine("");
                    Console.WriteLine("What do you choose :rock,scissors or paper?");
                    Console.WriteLine("");
                    string fifthAsnwer = Console.ReadLine();
                    Console.WriteLine($"You chose {fifthAsnwer}!");
                    if (fifthAsnwer == "rock")
                    {
                        int type = new Random().Next(1, 3);

                        switch (type)
                        {
                            case 1:
                                Console.WriteLine("");
                                Console.WriteLine("Dimitar Berbatov chose:scissors!You win!You gain 20 life points and proceed to the 5th round!Good luck!");
                                Console.WriteLine("");
                                health = health + 20;
                                Console.WriteLine($"Your health is {health}!");
                                break;
                            case 2:
                                Console.WriteLine("");
                                Console.WriteLine("Dimitar Berbatov chose:paper!You lose!You lose 20 life points,but don't despair,you continue to the 5th round!Good luck!");
                                Console.WriteLine("");
                                health = health - 20;
                                Console.WriteLine($"Your health is {health}!");
                                break;
                        }

                    }
                    else if (fifthAsnwer == "scissors")
                    {
                        int type = new Random().Next(1, 3);

                        switch (type)
                        {
                            case 1:
                                Console.WriteLine("");
                                Console.WriteLine("Dimitar Berbatov chose:paper!You win!You gain 20 life points and proceed to the 5th round!Good luck!");
                                Console.WriteLine("");
                                health = health + 20;
                                Console.WriteLine($"Your health is {health}!");
                                break;
                            case 2:
                                Console.WriteLine("");
                                Console.WriteLine("Dimitar Berbatov chose:rock!You lose!You lose 20 life points,but don't despair,you continue to the 5th round!Good luck!");
                                Console.WriteLine("");
                                health = health - 20;
                                Console.WriteLine($"Your health is {health}!");
                                break;
                        }
                    }
                    else if (fifthAsnwer == "paper")
                    {
                        int type = new Random().Next(1, 3);

                        switch (type)
                        {
                            case 1:
                                Console.WriteLine("");
                                Console.WriteLine("Dimitar Berbatov chose:rock!You win!You gain 20 life points and proceed to the 5th round!Good luck!");
                                Console.WriteLine("");
                                health = health + 20;
                                Console.WriteLine($"Your health is {health}!");
                                break;
                            case 2:
                                Console.WriteLine("");
                                Console.WriteLine("Dimitar Berbatov chose:scissors!You lose!You lose 20 life points,but don't despair,you continue to the 5th round!Good luck!");
                                Console.WriteLine("");
                                health = health - 20;
                                Console.WriteLine($"Your health is {health}!");
                                break;
                        }
                    }
                    Console.WriteLine("");
                    Console.WriteLine("=========");
                    Console.WriteLine("|Round 5|");
                    Console.WriteLine("=========");
                    Console.WriteLine("In the fifth round you are facing Vasil Bozhkov - Businessman and collector!");
                    Console.WriteLine("");
                    Console.WriteLine("What do you choose :rock,scissors or paper?");
                    Console.WriteLine("");
                    string sixthAsnwer = Console.ReadLine();
                    Console.WriteLine($"You chose {sixthAsnwer}!");
                    if (sixthAsnwer == "rock")
                    {
                        int type = new Random().Next(1, 3);

                        switch (type)
                        {
                            case 1:
                                Console.WriteLine("");
                                Console.WriteLine("Vasil Bozhkov chose:scissors!You win!You gain 20 life points and proceed to the 6th round!Good luck!");
                                Console.WriteLine("");
                                health = health + 20;
                                Console.WriteLine($"Your health is {health}!");
                                break;
                            case 2:
                                Console.WriteLine("");
                                Console.WriteLine("Vasil Bozhkov chose:paper!You lose!You lose 20 life points,but don't despair,you continue to the 6th round!Good luck!");
                                Console.WriteLine("");
                                health = health - 20;
                                Console.WriteLine($"Your health is {health}!");
                                break;
                        }

                    }
                    else if (sixthAsnwer == "scissors")
                    {
                        int type = new Random().Next(1, 3);

                        switch (type)
                        {
                            case 1:
                                Console.WriteLine("");
                                Console.WriteLine("Vasil Bozhkov chose:paper!You win!You gain 20 life points and proceed to the 6th round!Good luck!");
                                Console.WriteLine("");
                                health = health + 20;
                                Console.WriteLine($"Your health is {health}!");
                                break;
                            case 2:
                                Console.WriteLine("");
                                Console.WriteLine("Vasil Bozhkov chose:rock!You lose!You lose 20 life points,but don't despair,you continue to the 6th round!Good luck!");
                                Console.WriteLine("");
                                health = health - 20;
                                Console.WriteLine($"Your health is {health}!");
                                break;
                        }
                    }
                    else if (sixthAsnwer == "paper")
                    {
                        int type = new Random().Next(1, 3);

                        switch (type)
                        {
                            case 1:
                                Console.WriteLine("");
                                Console.WriteLine("Vasil Bozhkov chose:rock!You win!You gain 20 life points and proceed to the 6th round!Good luck!");
                                Console.WriteLine("");
                                health = health + 20;
                                Console.WriteLine($"Your health is {health}!");
                                break;
                            case 2:
                                Console.WriteLine("");
                                Console.WriteLine("Vasil Bozhkov chose:scissors!You lose!You lose 20 life points,but don't despair,you continue to the 6th round!Good luck!");
                                Console.WriteLine("");
                                health = health - 20;
                                Console.WriteLine($"Your health is {health}!");
                                break;

                        }
                    }
                    if (health < 0)
                    {
                        Console.WriteLine("Game Over!");
                        Console.WriteLine("You loose!");
                    }
                    Console.WriteLine("");
                    Console.WriteLine("=========");
                    Console.WriteLine("|Round 6|");
                    Console.WriteLine("=========");
                    Console.WriteLine("In the sixth round you are facing Antoaneta Stefanova - Chess grandmaster, former women's world champion!");
                    Console.WriteLine("");
                    Console.WriteLine("What do you choose :rock,scissors or paper?");
                    Console.WriteLine("");
                    string seventhAsnwer = Console.ReadLine();
                    Console.WriteLine($"You chose {seventhAsnwer}!");
                    if (seventhAsnwer == "rock")
                    {
                        int type = new Random().Next(1, 3);

                        switch (type)
                        {
                            case 1:
                                Console.WriteLine("");
                                Console.WriteLine("Antoaneta Stefanova chose:scissors!You win!You gain 20 life points and proceed to the 7th round!Good luck!");
                                Console.WriteLine("");
                                health = health + 20;
                                Console.WriteLine($"Your health is {health}!");
                                break;
                            case 2:
                                Console.WriteLine("");
                                Console.WriteLine("Antoaneta Stefanova chose:paper!You lose!You lose 20 life points,but don't despair,you continue to the 7th round!Good luck!");
                                Console.WriteLine("");
                                health = health - 20;
                                Console.WriteLine($"Your health is {health}!");
                                break;
                        }

                    }
                    else if (seventhAsnwer == "scissors")
                    {
                        int type = new Random().Next(1, 3);

                        switch (type)
                        {
                            case 1:
                                Console.WriteLine("");
                                Console.WriteLine("Antoaneta Stefanova chose:paper!You win!You gain 20 life points and proceed to the 7th round!Good luck!");
                                Console.WriteLine("");
                                health = health + 20;
                                Console.WriteLine($"Your health is {health}!");
                                break;
                            case 2:
                                Console.WriteLine("");
                                Console.WriteLine("Antoaneta Stefanova chose:rock!You lose!You lose 20 life points,but don't despair,you continue to the 7th round!Good luck!");
                                Console.WriteLine("");
                                health = health - 20;
                                Console.WriteLine($"Your health is {health}!");
                                break;
                        }
                    }
                    else if (seventhAsnwer == "paper")
                    {
                        int type = new Random().Next(1, 3);

                        switch (type)
                        {
                            case 1:
                                Console.WriteLine("");
                                Console.WriteLine("Antoaneta Stefanova chose:rock!You win!You gain 20 life points and proceed to the 7th round!Good luck!");
                                Console.WriteLine("");
                                health = health + 20;
                                Console.WriteLine($"Your health is {health}!");
                                break;
                            case 2:
                                Console.WriteLine("");
                                Console.WriteLine("Antoaneta Stefanova chose:scissors!You lose!You lose 20 life points,but don't despair,you continue to the 7th round!Good luck!");
                                Console.WriteLine("");
                                health = health - 20;
                                Console.WriteLine($"Your health is {health}!");
                                break;
                        }

                    }
                    if (health <= 0)
                    {
                        Console.WriteLine("Game Over!");
                        Console.WriteLine("You loose!");
                    }
                    Console.WriteLine("");
                    Console.WriteLine("=========");
                    Console.WriteLine("|Round 7|");
                    Console.WriteLine("=========");
                    Console.WriteLine("In the seventh round you are facing Mirela Demireva - Athlete, competitor in the high jump!");
                    Console.WriteLine("");
                    Console.WriteLine("What do you choose :rock,scissors or paper?");
                    Console.WriteLine("");
                    string eighthAsnwer = Console.ReadLine();
                    Console.WriteLine($"You chose {eighthAsnwer}!");
                    if (eighthAsnwer == "rock")
                    {
                        int type = new Random().Next(1, 3);

                        switch (type)
                        {
                            case 1:
                                Console.WriteLine("");
                                Console.WriteLine("Mirela Demireva chose:scissors!You win!You gain 20 life points and proceed to the 8th round!Good luck!");
                                Console.WriteLine("");
                                health = health + 20;
                                Console.WriteLine($"Your health is {health}!");
                                break;
                            case 2:
                                Console.WriteLine("");
                                Console.WriteLine("Mirela Demireva chose:paper!You lose!You lose 20 life points,but don't despair,you continue to the 8th round!Good luck!");
                                Console.WriteLine("");
                                health = health - 20;
                                Console.WriteLine($"Your health is {health}!");
                                break;
                        }

                    }
                    else if (eighthAsnwer == "scissors")
                    {
                        int type = new Random().Next(1, 3);

                        switch (type)
                        {

                            case 1:
                                Console.WriteLine("");
                                Console.WriteLine("Mirela Demireva chose:paper!You win!You gain 20 life points and proceed to the 8th round!Good luck!");
                                Console.WriteLine("");
                                health = health + 20;
                                Console.WriteLine($"Your health is {health}!");
                                break;
                            case 2:
                                Console.WriteLine("");
                                Console.WriteLine("Mirela Demireva chose:rock!You lose!You lose 20 life points,but don't despair,you continue to the 8th round!Good luck!");
                                Console.WriteLine("");
                                health = health - 20;
                                Console.WriteLine($"Your health is {health}!");
                                break;
                        }
                    }
                    else if (eighthAsnwer == "paper")
                    {
                        int type = new Random().Next(1, 3);

                        switch (type)
                        {
                            case 1:
                                Console.WriteLine("");
                                Console.WriteLine("Mirela Demireva chose:rock!You win!You gain 20 life points and proceed to the 8th round!Good luck!");
                                Console.WriteLine("");
                                health = health + 20;
                                Console.WriteLine($"Your health is {health}!");
                                break;
                            case 2:
                                Console.WriteLine("");
                                Console.WriteLine("Mirela Demireva chose:scissors!You lose!You lose 20 life points,but don't despair,you continue to the 8th round!Good luck!");
                                Console.WriteLine("");
                                health = health - 20;
                                Console.WriteLine($"Your health is {health}!");
                                break;
                        }

                    }
                    if (health <= 0)
                    {
                        Console.WriteLine("Game Over!");
                        Console.WriteLine("You loose!");
                    }
                    Console.WriteLine("");
                    Console.WriteLine("=========");
                    Console.WriteLine("|Round 8|");
                    Console.WriteLine("=========");
                    Console.WriteLine("In the eight round you are facing Yordan Yovchev - Athlete in sports gymnastics!");
                    Console.WriteLine("");
                    Console.WriteLine("What do you choose :rock,scissors or paper?");
                    Console.WriteLine("");
                    string ninthAsnwer = Console.ReadLine();
                    Console.WriteLine($"You chose {ninthAsnwer}!");
                    if (ninthAsnwer == "rock")
                    {
                        int type = new Random().Next(1, 3);

                        switch (type)
                        {
                            case 1:
                                Console.WriteLine("");
                                Console.WriteLine("Yordan Yovchev chose:scissors!You win!You gain 20 life points and proceed to the 9th round!Good luck!");
                                Console.WriteLine("");
                                health = health + 20;
                                Console.WriteLine($"Your health is {health}!");
                                break;
                            case 2:
                                Console.WriteLine("");
                                Console.WriteLine("Yordan Yovchev chose:paper!You lose!You lose 20 life points,but don't despair,you continue to the 9th round!Good luck!");
                                Console.WriteLine("");
                                health = health - 20;
                                Console.WriteLine($"Your health is {health}!");
                                break;
                        }

                    }
                    else if (ninthAsnwer == "scissors")
                    {
                        int type = new Random().Next(1, 3);

                        switch (type)
                        {
                            case 1:
                                Console.WriteLine("");
                                Console.WriteLine("Yordan Yovchev chose:paper!You win!You gain 20 life points and proceed to the 9th round!Good luck!");
                                Console.WriteLine("");
                                health = health + 20;
                                Console.WriteLine($"Your health is {health}!");
                                break;
                            case 2:
                                Console.WriteLine("");
                                Console.WriteLine("Yordan Yovchev chose:rock!You lose!You lose 20 life points,but don't despair,you continue to the 9th round!Good luck!");
                                Console.WriteLine("");
                                health = health - 20;
                                Console.WriteLine($"Your health is {health}!");
                                break;
                        }
                    }
                    else if (ninthAsnwer == "paper")
                    {
                        int type = new Random().Next(1, 3);

                        switch (type)
                        {
                            case 1:
                                Console.WriteLine("");
                                Console.WriteLine("Yordan Yovchev chose:rock!You win!You gain 20 life points and proceed to the 9th round!Good luck!");
                                Console.WriteLine("");
                                health = health + 20;
                                Console.WriteLine($"Your health is {health}!");
                                break;
                            case 2:
                                Console.WriteLine("");
                                Console.WriteLine("Yordan Yovchev chose:scissors!You lose!You lose 20 life points,but don't despair,you continue to the 9th round!Good luck!");
                                Console.WriteLine("");
                                health = health - 20;
                                Console.WriteLine($"Your health is {health}!");
                                break;
                        }

                    }
                    if (health <= 0)
                    {
                        Console.WriteLine("Game Over!");
                        Console.WriteLine("You loose!");
                    }
                    Console.WriteLine("");
                    Console.WriteLine("=========");
                    Console.WriteLine("|Round 9|");
                    Console.WriteLine("=========");
                    Console.WriteLine("In the ninth round you are facing Tsvetana Pironkova - Tennis player!");
                    Console.WriteLine("");
                    Console.WriteLine("What do you choose :rock,scissors or paper?");
                    Console.WriteLine("");
                    string tenthAsnwer = Console.ReadLine();
                    Console.WriteLine($"You chose {tenthAsnwer}!");
                    if (tenthAsnwer == "rock")
                    {
                        int type = new Random().Next(1, 3);

                        switch (type)
                        {
                            case 1:
                                Console.WriteLine("");
                                Console.WriteLine("Tsvetana Pironkova chose:scissors!You win!You gain 20 life points and proceed to the 10th round!Good luck!");
                                Console.WriteLine("");
                                health = health + 20;
                                Console.WriteLine($"Your health is {health}!");
                                break;
                            case 2:
                                Console.WriteLine("");
                                Console.WriteLine("Tsvetana Pironkova chose:paper!You lose!You lose 20 life points,but don't despair,you continue to the 10th round!Good luck!");
                                Console.WriteLine("");
                                health = health - 20;
                                Console.WriteLine($"Your health is {health}!");
                                break;
                        }

                    }
                    else if (tenthAsnwer == "scissors")
                    {
                        int type = new Random().Next(1, 3);

                        switch (type)
                        {
                            case 1:
                                Console.WriteLine("");
                                Console.WriteLine("Tsvetana Pironkova chose:paper!You win!You gain 20 life points and proceed to the 10th round!Good luck!");
                                Console.WriteLine("");
                                health = health + 20;
                                Console.WriteLine($"Your health is {health}!");
                                break;
                            case 2:
                                Console.WriteLine("");
                                Console.WriteLine("Tsvetana Pironkova chose:rock!You lose!You lose 20 life points,but don't despair,you continue to the 10th round!Good luck!");
                                Console.WriteLine("");
                                health = health - 20;
                                Console.WriteLine($"Your health is {health}!");
                                break;
                        }
                    }
                    else if (tenthAsnwer == "paper")
                    {
                        int type = new Random().Next(1, 3);

                        switch (type)
                        {
                            case 1:
                                Console.WriteLine("");
                                Console.WriteLine("Tsvetana Pironkova chose:rock!You win!You gain 20 life points and proceed to the 10th round!Good luck!");
                                Console.WriteLine("");
                                health = health + 20;
                                Console.WriteLine($"Your health is {health}!");
                                break;
                            case 2:
                                Console.WriteLine("");
                                Console.WriteLine("Tsvetana Pironkova chose:scissors!You lose!You lose 20 life points,but don't despair,you continue to the 10th round!Good luck!");
                                Console.WriteLine("");
                                health = health - 20;
                                Console.WriteLine($"Your health is {health}!");
                                break;
                        }

                    }
                    if (health <= 0)
                    {
                        Console.WriteLine("Game Over!");
                        Console.WriteLine("You loose!");
                    }
                    Console.WriteLine("");
                    Console.WriteLine("=========");
                    Console.WriteLine("|Round 10|");
                    Console.WriteLine("=========");
                    Console.WriteLine("In the tenth round you are facing Hristo Stoichkov - the best Bulgarian football player!");
                    Console.WriteLine("");
                    Console.WriteLine("What do you choose :rock,scissors or paper?");
                    Console.WriteLine("");
                    string eleventhAsnwer = Console.ReadLine();
                    Console.WriteLine($"You chose {eleventhAsnwer}!");
                    if (eleventhAsnwer == "rock")
                    {
                        int type = new Random().Next(1, 3);

                        switch (type)
                        {
                            case 1:
                                Console.WriteLine("");
                                Console.WriteLine("Hristo Stoichkov chose:scissors!You win!You gain 20 life points and proceed to the 11th round!Good luck!");
                                Console.WriteLine("");
                                health = health + 20;
                                Console.WriteLine($"Your health is {health}!");
                                break;
                            case 2:
                                Console.WriteLine("");
                                Console.WriteLine("Hristo Stoichkov chose:paper!You lose!You lose 20 life points,but don't despair,you continue to the 11th round!Good luck!");
                                Console.WriteLine("");
                                health = health - 20;
                                Console.WriteLine($"Your health is {health}!");
                                break;
                        }

                    }
                    else if (eleventhAsnwer == "scissors")
                    {
                        int type = new Random().Next(1, 3);

                        switch (type)
                        {
                            case 1:
                                Console.WriteLine("");
                                Console.WriteLine("Hristo Stoichkov chose:paper!You win!You gain 20 life points and proceed to the 11th round!Good luck!");
                                Console.WriteLine("");
                                health = health + 20;
                                Console.WriteLine($"Your health is {health}!");
                                break;
                            case 2:
                                Console.WriteLine("");
                                Console.WriteLine("Hristo Stoichkov chose:rock!You lose!You lose 20 life points,but don't despair,you continue to the 11th round!Good luck!");
                                Console.WriteLine("");
                                health = health - 20;
                                Console.WriteLine($"Your health is {health}!");
                                break;
                        }
                    }
                    else if (eleventhAsnwer == "paper")
                    {
                        int type = new Random().Next(1, 3);

                        switch (type)
                        {
                            case 1:
                                Console.WriteLine("");
                                Console.WriteLine("Hristo Stoichkov chose:rock!You win!You gain 20 life points and proceed to the 11th round!Good luck!");
                                Console.WriteLine("");
                                health = health + 20;
                                Console.WriteLine($"Your health is {health}!");
                                break;
                            case 2:
                                Console.WriteLine("");
                                Console.WriteLine("Hristo Stoichkov chose:scissors!You lose!You lose 20 life points,but don't despair,you continue to the 11th round!Good luck!");
                                Console.WriteLine("");
                                health = health - 20;
                                Console.WriteLine($"Your health is {health}!");
                                break;
                        }

                    }
                    if (health <= 0)
                    {
                        Console.WriteLine("Game Over!");
                        Console.WriteLine("You loose!");
                    }
                    Console.WriteLine("");
                    Console.WriteLine("=========");
                    Console.WriteLine("|Round 11|");
                    Console.WriteLine("=========");
                    Console.WriteLine("In the eleventh round you are facing Bill Gates - Co-founder of Microsoft!");
                    Console.WriteLine("");
                    Console.WriteLine("What do you choose :rock,scissors or paper?");
                    Console.WriteLine("");
                    string twelfthAsnwer = Console.ReadLine();
                    Console.WriteLine($"You chose {twelfthAsnwer}!");
                    if (twelfthAsnwer == "rock")
                    {
                        int type = new Random().Next(1, 3);

                        switch (type)
                        {
                            case 1:
                                Console.WriteLine("");
                                Console.WriteLine("Bill Gates chose:scissors!You win!You gain 20 life points and proceed to the 12th round!Good luck!");
                                Console.WriteLine("");
                                health = health + 20;
                                Console.WriteLine($"Your health is {health}!");
                                break;
                            case 2:
                                Console.WriteLine("");
                                Console.WriteLine("Bill Gates chose:paper!You lose!You lose 20 life points,but don't despair,you continue to the 12th round!Good luck!");
                                Console.WriteLine("");
                                health = health - 20;
                                Console.WriteLine($"Your health is {health}!");
                                break;
                        }

                    }
                    else if (twelfthAsnwer == "scissors")
                    {
                        int type = new Random().Next(1, 3);

                        switch (type)
                        {
                            case 1:
                                Console.WriteLine("");
                                Console.WriteLine("Bill Gates chose:paper!You win!You gain 20 life points and proceed to the 12th round!Good luck!");
                                Console.WriteLine("");
                                health = health + 20;
                                Console.WriteLine($"Your health is {health}!");
                                break;
                            case 2:
                                Console.WriteLine("");
                                Console.WriteLine("Bill Gates chose:rock!You lose!You lose 20 life points,but don't despair,you continue to the 12th round!Good luck!");
                                Console.WriteLine("");
                                health = health - 20;
                                Console.WriteLine($"Your health is {health}!");
                                break;
                        }
                    }
                    else if (twelfthAsnwer == "paper")
                    {
                        int type = new Random().Next(1, 3);

                        switch (type)
                        {
                            case 1:
                                Console.WriteLine("");
                                Console.WriteLine("Bill Gates chose:rock!You win!You gain 20 life points and proceed to the 12th round!Good luck!");
                                Console.WriteLine("");
                                health = health + 20;
                                Console.WriteLine($"Your health is {health}!");
                                break;
                            case 2:
                                Console.WriteLine("");
                                Console.WriteLine("Bill Gates chose:scissors!You lose!You lose 20 life points,but don't despair,you continue to the 12th round!Good luck!");
                                Console.WriteLine("");
                                health = health - 20;
                                Console.WriteLine($"Your health is {health}!");
                                break;
                        }

                    }
                    if (health <= 0)
                    {
                        Console.WriteLine("Game Over!");
                        Console.WriteLine("You loose!");
                    }
                    Console.WriteLine("");
                    Console.WriteLine("=========");
                    Console.WriteLine("|Round 12|");
                    Console.WriteLine("=========");
                    Console.WriteLine("In the twelfth round you are facing Oprah Winfrey - Television host, producer and philanthropist!");
                    Console.WriteLine("");
                    Console.WriteLine("What do you choose :rock,scissors or paper?");
                    Console.WriteLine("");
                    string thirteenthAsnwer = Console.ReadLine();
                    Console.WriteLine($"You chose {thirteenthAsnwer}!");
                    if (thirteenthAsnwer == "rock")
                    {
                        int type = new Random().Next(1, 3);

                        switch (type)
                        {
                            case 1:
                                Console.WriteLine("");
                                Console.WriteLine("Oprah Winfrey chose:scissors!You win!You gain 20 life points and proceed to the 13th round!Good luck!");
                                Console.WriteLine("");
                                health = health + 20;
                                Console.WriteLine($"Your health is {health}!");
                                break;
                            case 2:
                                Console.WriteLine("");
                                Console.WriteLine("Oprah Winfrey chose:paper!You lose!You lose 20 life points,but don't despair,you continue to the 13th round!Good luck!");
                                Console.WriteLine("");
                                health = health - 20;
                                Console.WriteLine($"Your health is {health}!");
                                break;
                        }

                    }
                    else if (thirteenthAsnwer == "scissors")
                    {
                        int type = new Random().Next(1, 3);

                        switch (type)
                        {
                            case 1:
                                Console.WriteLine("");
                                Console.WriteLine("Oprah Winfrey chose:paper!You win!You gain 20 life points and proceed to the 13th round!Good luck!");
                                Console.WriteLine("");
                                health = health + 20;
                                Console.WriteLine($"Your health is {health}!");
                                break;
                            case 2:
                                Console.WriteLine("");
                                Console.WriteLine("Oprah Winfrey chose:rock!You lose!You lose 20 life points,but don't despair,you continue to the 13th round!Good luck!");
                                Console.WriteLine("");
                                health = health - 20;
                                Console.WriteLine($"Your health is {health}!");
                                break;
                        }
                    }
                    else if (thirteenthAsnwer == "paper")
                    {
                        int type = new Random().Next(1, 3);

                        switch (type)
                        {
                            case 1:
                                Console.WriteLine("");
                                Console.WriteLine("Oprah Winfrey chose:rock!You win!You gain 20 life points and proceed to the 13th round!Good luck!");
                                Console.WriteLine("");
                                health = health + 20;
                                Console.WriteLine($"Your health is {health}!");
                                break;
                            case 2:
                                Console.WriteLine("");
                                Console.WriteLine("Oprah Winfrey chose:scissors!You lose!You lose 20 life points,but don't despair,you continue to the 13th round!Good luck!");
                                Console.WriteLine("");
                                health = health - 20;
                                Console.WriteLine($"Your health is {health}!");
                                break;
                        }

                    }
                    if (health <= 0)
                    {
                        Console.WriteLine("Game Over!");
                        Console.WriteLine("You loose!");
                    }
                    Console.WriteLine("");
                    Console.WriteLine("=========");
                    Console.WriteLine("|Round 13|");
                    Console.WriteLine("=========");
                    Console.WriteLine("In the thirteenth round you are facing Leonardo DiCaprio - Actor and climate activist!");
                    Console.WriteLine("");
                    Console.WriteLine("What do you choose :rock,scissors or paper?");
                    Console.WriteLine("");
                    string fourteenthAsnwer = Console.ReadLine();
                    Console.WriteLine($"You chose {fourteenthAsnwer}!");
                    if (fourteenthAsnwer == "rock")
                    {
                        int type = new Random().Next(1, 3);

                        switch (type)
                        {
                            case 1:
                                Console.WriteLine("");
                                Console.WriteLine("Leonardo DiCaprio chose:scissors!You win!You gain 20 life points and proceed to the 14th round!Good luck!");
                                Console.WriteLine("");
                                health = health + 20;
                                Console.WriteLine($"Your health is {health}!");
                                break;
                            case 2:
                                Console.WriteLine("");
                                Console.WriteLine("Leonardo DiCaprio chose:paper!You lose!You lose 20 life points,but don't despair,you continue to the 14th round!Good luck!");
                                Console.WriteLine("");
                                health = health - 20;
                                Console.WriteLine($"Your health is {health}!");
                                break;
                        }

                    }
                    else if (fourteenthAsnwer == "scissors")
                    {
                        int type = new Random().Next(1, 3);

                        switch (type)
                        {
                            case 1:
                                Console.WriteLine("");
                                Console.WriteLine("Leonardo DiCaprio chose:paper!You win!You gain 20 life points and proceed to the 14th round!Good luck!");
                                Console.WriteLine("");
                                health = health + 20;
                                Console.WriteLine($"Your health is {health}!");
                                break;
                            case 2:
                                Console.WriteLine("");
                                Console.WriteLine("Leonardo DiCaprio chose:rock!You lose!You lose 20 life points,but don't despair,you continue to the 14th round!Good luck!");
                                Console.WriteLine("");
                                health = health - 20;
                                Console.WriteLine($"Your health is {health}!");
                                break;
                        }
                    }
                    else if (fourteenthAsnwer == "paper")
                    {
                        int type = new Random().Next(1, 3);

                        switch (type)
                        {
                            case 1:
                                Console.WriteLine("");
                                Console.WriteLine("Leonardo DiCaprio chose:rock!You win!You gain 20 life points and proceed to the 14th round!Good luck!");
                                Console.WriteLine("");
                                health = health + 20;
                                Console.WriteLine($"Your health is {health}!");
                                break;
                            case 2:
                                Console.WriteLine("");
                                Console.WriteLine("Leonardo DiCaprio chose:scissors!You lose!You lose 20 life points,but don't despair,you continue to the 14th round!Good luck!");
                                Console.WriteLine("");
                                health = health - 20;
                                Console.WriteLine($"Your health is {health}!");
                                break;
                        }



                    }
                    if (health <= 0)
                    {
                        Console.WriteLine("Game Over!");
                        Console.WriteLine("You loose!");
                    }
                    Console.WriteLine("");
                    Console.WriteLine("=========");
                    Console.WriteLine("|Round 14|");
                    Console.WriteLine("=========");
                    Console.WriteLine("In the fourteenth round you are facing Kim Kardashian - Media personality and entrepreneur!");
                    Console.WriteLine("");
                    Console.WriteLine("What do you choose :rock,scissors or paper?");
                    Console.WriteLine("");
                    string fifteenthAsnwer = Console.ReadLine();
                    Console.WriteLine($"You chose {fifteenthAsnwer}!");
                    if (fifteenthAsnwer == "rock")
                    {
                        int type = new Random().Next(1, 3);

                        switch (type)
                        {
                            case 1:
                                Console.WriteLine("");
                                Console.WriteLine("Kim Kardashian chose:scissors!You win!You gain 20 life points and proceed to the 15th round!Good luck!");
                                Console.WriteLine("");
                                health = health + 20;
                                Console.WriteLine($"Your health is {health}!");
                                break;
                            case 2:
                                Console.WriteLine("");
                                Console.WriteLine("Kim Kardashian chose:paper!You lose!You lose 20 life points,but don't despair,you continue to the 15th round!Good luck!");
                                Console.WriteLine("");
                                health = health - 20;
                                Console.WriteLine($"Your health is {health}!");
                                break;
                        }

                    }
                    else if (fifteenthAsnwer == "scissors")
                    {
                        int type = new Random().Next(1, 3);

                        switch (type)
                        {
                            case 1:
                                Console.WriteLine("");
                                Console.WriteLine("Kim Kardashian chose:paper!You win!You gain 20 life points and proceed to the 15th round!Good luck!");
                                Console.WriteLine("");
                                health = health + 20;
                                Console.WriteLine($"Your health is {health}!");
                                break;
                            case 2:
                                Console.WriteLine("");
                                Console.WriteLine("Kim Kardashian chose:rock!You lose!You lose 20 life points,but don't despair,you continue to the 15th round!Good luck!");
                                Console.WriteLine("");
                                health = health - 20;
                                Console.WriteLine($"Your health is {health}!");
                                break;
                        }
                    }
                    else if (fifteenthAsnwer == "paper")
                    {
                        int type = new Random().Next(1, 3);

                        switch (type)
                        {
                            case 1:
                                Console.WriteLine("");
                                Console.WriteLine("Kim Kardashian chose:rock!You win!You gain 20 life points and proceed to the 15th round!Good luck!");
                                Console.WriteLine("");
                                health = health + 20;
                                Console.WriteLine($"Your health is {health}!");
                                break;
                            case 2:
                                Console.WriteLine("");
                                Console.WriteLine("Kim Kardashian chose:scissors!You lose!You lose 20 life points,but don't despair,you continue to the 15th round!Good luck!");
                                Console.WriteLine("");
                                health = health - 20;
                                Console.WriteLine($"Your health is {health}!");
                                break;
                        }



                    }
                    if (health <= 0)
                    {
                        Console.WriteLine("Game Over!");
                        Console.WriteLine("You loose!");
                    }
                    Console.WriteLine("");
                    Console.WriteLine("=========");
                    Console.WriteLine("|Round 15|");
                    Console.WriteLine("=========");
                    Console.WriteLine("In the fivteenth round you are facing Jeff Bezos - Founder of Amazon!");
                    Console.WriteLine("");
                    Console.WriteLine("What do you choose :rock,scissors or paper?");
                    Console.WriteLine("");
                    string sixteenthAsnwer = Console.ReadLine();
                    Console.WriteLine($"You chose {sixteenthAsnwer}!");
                    if (sixteenthAsnwer == "rock")
                    {
                        int type = new Random().Next(1, 3);

                        switch (type)
                        {
                            case 1:
                                Console.WriteLine("");
                                Console.WriteLine("Jeff Bezos chose:scissors!You win!You gain 20 life points and proceed to the 16th round!Good luck!");
                                Console.WriteLine("");
                                health = health + 20;
                                Console.WriteLine($"Your health is {health}!");
                                break;
                            case 2:
                                Console.WriteLine("");
                                Console.WriteLine("Jeff Bezos chose:paper!You lose!You lose 20 life points,but don't despair,you continue to the 16th round!Good luck!");
                                Console.WriteLine("");
                                health = health - 20;
                                Console.WriteLine($"Your health is {health}!");
                                break;
                        }

                    }
                    else if (sixteenthAsnwer == "scissors")
                    {
                        int type = new Random().Next(1, 3);

                        switch (type)
                        {
                            case 1:
                                Console.WriteLine("");
                                Console.WriteLine("Jeff Bezos chose:paper!You win!You gain 20 life points and proceed to the 16th round!Good luck!");
                                Console.WriteLine("");
                                health = health + 20;
                                Console.WriteLine($"Your health is {health}!");
                                break;
                            case 2:
                                Console.WriteLine("");
                                Console.WriteLine("Jeff Bezos chose:rock!You lose!You lose 20 life points,but don't despair,you continue to the 16th round!Good luck!");
                                Console.WriteLine("");
                                health = health - 20;
                                Console.WriteLine($"Your health is {health}!");
                                break;
                        }
                    }
                    else if (sixteenthAsnwer == "paper")
                    {
                        int type = new Random().Next(1, 3);

                        switch (type)
                        {
                            case 1:
                                Console.WriteLine("");
                                Console.WriteLine("Jeff Bezos chose:rock!You win!You gain 20 life points and proceed to the 16th round!Good luck!");
                                Console.WriteLine("");
                                health = health + 20;
                                Console.WriteLine($"Your health is {health}!");
                                break;
                            case 2:
                                Console.WriteLine("");
                                Console.WriteLine("Jeff Bezos chose:scissors!You lose!You lose 20 life points,but don't despair,you continue to the 16th round!Good luck!");
                                Console.WriteLine("");
                                health = health - 20;
                                Console.WriteLine($"Your health is {health}!");
                                break;
                        }



                    }
                    if (health <= 0)
                    {
                        Console.WriteLine("Game Over!");
                        Console.WriteLine("You loose!");
                    }
                    Console.WriteLine("");
                    Console.WriteLine("=========");
                    Console.WriteLine("|Round 16|");
                    Console.WriteLine("=========");
                    Console.WriteLine("In the sixteenth round you are facing Zuckerberg - Founder of Facebook!");
                    Console.WriteLine("");
                    Console.WriteLine("What do you choose :rock,scissors or paper?");
                    Console.WriteLine("");
                    string seventeenthAsnwer = Console.ReadLine();
                    Console.WriteLine($"You chose {seventeenthAsnwer}!");
                    if (seventeenthAsnwer == "rock")
                    {
                        int type = new Random().Next(1, 3);

                        switch (type)
                        {
                            case 1:
                                Console.WriteLine("");
                                Console.WriteLine("Zuckerberg chose:scissors!You win!You gain 20 life points and proceed to the 17th round!Good luck!");
                                Console.WriteLine("");
                                health = health + 20;
                                Console.WriteLine($"Your health is {health}!");
                                break;
                            case 2:
                                Console.WriteLine("");
                                Console.WriteLine("Zuckerberg chose:paper!You lose!You lose 20 life points,but don't despair,you continue to the 17th round!Good luck!");
                                Console.WriteLine("");
                                health = health - 20;
                                Console.WriteLine($"Your health is {health}!");
                                break;
                        }

                    }
                    else if (seventeenthAsnwer == "scissors")
                    {
                        int type = new Random().Next(1, 3);

                        switch (type)
                        {

                            case 1:
                                Console.WriteLine("");
                                Console.WriteLine("Zuckerberg chose:paper!You win!You gain 20 life points and proceed to the 17th round!Good luck!");
                                Console.WriteLine("");
                                health = health + 20;
                                Console.WriteLine($"Your health is {health}!");
                                break;
                            case 2:
                                Console.WriteLine("");
                                Console.WriteLine("Zuckerberg chose:rock!You lose!You lose 20 life points,but don't despair,you continue to the 17th round!Good luck!");
                                Console.WriteLine("");
                                health = health - 20;
                                Console.WriteLine($"Your health is {health}!");
                                break;
                        }
                    }
                    else if (seventeenthAsnwer == "paper")
                    {
                        int type = new Random().Next(1, 3);

                        switch (type)
                        {
                            case 1:
                                Console.WriteLine("");
                                Console.WriteLine("Zuckerberg chose:rock!You win!You gain 20 life points and proceed to the 17th round!Good luck!");
                                Console.WriteLine("");
                                health = health + 20;
                                Console.WriteLine($"Your health is {health}!");
                                break;
                            case 2:
                                Console.WriteLine("");
                                Console.WriteLine("Zuckerberg chose:scissors!You lose!You lose 20 life points,but don't despair,you continue to the 17th round!Good luck!");
                                Console.WriteLine("");
                                health = health - 20;
                                Console.WriteLine($"Your health is {health}!");
                                break;
                        }



                    }
                    if (health <= 0)
                    {
                        Console.WriteLine("Game Over!");
                        Console.WriteLine("You loose!");
                    }
                    Console.WriteLine("");
                    Console.WriteLine("=========");
                    Console.WriteLine("|Round 17|");
                    Console.WriteLine("=========");
                    Console.WriteLine("In the seventeenth round you are facing Shakira - Singer, dancer and philanthropist!");
                    Console.WriteLine("");
                    Console.WriteLine("What do you choose :rock,scissors or paper?");
                    Console.WriteLine("");
                    string eighteenthAsnwer = Console.ReadLine();
                    Console.WriteLine($"You chose {eighteenthAsnwer}!");
                    if (eighteenthAsnwer == "rock")
                    {
                        int type = new Random().Next(1, 3);

                        switch (type)
                        {
                            case 1:
                                Console.WriteLine("");
                                Console.WriteLine("Shakira chose:scissors!You win!You gain 20 life points and proceed to the 18th round!Good luck!");
                                Console.WriteLine("");
                                health = health + 20;
                                Console.WriteLine($"Your health is {health}!");
                                break;
                            case 2:
                                Console.WriteLine("");
                                Console.WriteLine("Shakira chose:paper!You lose!You lose 20 life points,but don't despair,you continue to the 18th round!Good luck!");
                                Console.WriteLine("");
                                health = health - 20;
                                Console.WriteLine($"Your health is {health}!");
                                break;
                        }

                    }
                    else if (eighteenthAsnwer == "scissors")
                    {
                        int type = new Random().Next(1, 3);

                        switch (type)
                        {
                            case 1:
                                Console.WriteLine("");
                                Console.WriteLine("Shakira chose:paper!You win!You gain 20 life points and proceed to the 18th round!Good luck!");
                                Console.WriteLine("");
                                health = health + 20;
                                Console.WriteLine($"Your health is {health}!");
                                break;
                            case 2:
                                Console.WriteLine("");
                                Console.WriteLine("Shakira chose:rock!You lose!You lose 20 life points,but don't despair,you continue to the 18th round!Good luck!");
                                Console.WriteLine("");
                                health = health - 20;
                                Console.WriteLine($"Your health is {health}!");
                                break;
                        }
                    }
                    else if (eighteenthAsnwer == "paper")
                    {
                        int type = new Random().Next(1, 3);

                        switch (type)
                        {
                            case 1:
                                Console.WriteLine("");
                                Console.WriteLine("Shakira chose:rock!You win!You gain 20 life points and proceed to the 18th round!Good luck!");
                                Console.WriteLine("");
                                health = health + 20;
                                Console.WriteLine($"Your health is {health}!");
                                break;
                            case 2:
                                Console.WriteLine("");
                                Console.WriteLine("Shakira chose:scissors!You lose!You lose 20 life points,but don't despair,you continue to the 18th round!Good luck!");
                                Console.WriteLine("");
                                health = health - 20;
                                Console.WriteLine($"Your health is {health}!");
                                break;
                        }




                    }
                    if (health <= 0)
                    {
                        Console.WriteLine("Game Over!");
                        Console.WriteLine("You loose!");
                    }
                    Console.WriteLine("");
                    Console.WriteLine("=========");
                    Console.WriteLine("|Round 18|");
                    Console.WriteLine("=========");
                    Console.WriteLine("In the eighteenth round you are facing Malala Yousafzai - Activist for girls' right to education!");
                    Console.WriteLine("");
                    Console.WriteLine("What do you choose :rock,scissors or paper?");
                    Console.WriteLine("");
                    string ninteenthAsnwer = Console.ReadLine();
                    Console.WriteLine($"You chose {ninteenthAsnwer}!");
                    if (ninteenthAsnwer == "rock")
                    {
                        int type = new Random().Next(1, 3);

                        switch (type)
                        {
                            case 1:
                                Console.WriteLine("");
                                Console.WriteLine("Malala Yousafzai chose:scissors!You win!You gain 20 life points and proceed to the 19th round!Good luck!");
                                Console.WriteLine("");
                                health = health + 20;
                                Console.WriteLine($"Your health is {health}!");
                                break;
                            case 2:
                                Console.WriteLine("");
                                Console.WriteLine("Malala Yousafzai chose:paper!You lose!You lose 20 life points,but don't despair,you continue to the 19th round!Good luck!");
                                Console.WriteLine("");
                                health = health - 20;
                                Console.WriteLine($"Your health is {health}!");
                                break;
                        }

                    }
                    else if (ninteenthAsnwer == "scissors")
                    {
                        int type = new Random().Next(1, 3);

                        switch (type)
                        {
                            case 1:
                                Console.WriteLine("");
                                Console.WriteLine("Malala Yousafzai chose:paper!You win!You gain 20 life points and proceed to the 19th round!Good luck!");
                                Console.WriteLine("");
                                health = health + 20;
                                Console.WriteLine($"Your health is {health}!");
                                break;
                            case 2:
                                Console.WriteLine("");
                                Console.WriteLine("Malala Yousafzai chose:rock!You lose!You lose 20 life points,but don't despair,you continue to the 19th round!Good luck!");
                                Console.WriteLine("");
                                health = health - 20;
                                Console.WriteLine($"Your health is {health}!");
                                break;
                        }
                    }
                    else if (ninteenthAsnwer == "paper")
                    {
                        int type = new Random().Next(1, 3);

                        switch (type)
                        {
                            case 1:
                                Console.WriteLine("");
                                Console.WriteLine("Malala Yousafzai chose:rock!You win!You gain 20 life points and proceed to the 19th round!Good luck!");
                                Console.WriteLine("");
                                health = health + 20;
                                Console.WriteLine($"Your health is {health}!");
                                break;
                            case 2:
                                Console.WriteLine("");
                                Console.WriteLine("Malala Yousafzai chose:scissors!You lose!You lose 20 life points,but don't despair,you continue to the 19th round!Good luck!");
                                Console.WriteLine("");
                                health = health - 20;
                                Console.WriteLine($"Your health is {health}!");
                                break;
                        }



                    }
                    if (health <= 0)
                    {
                        Console.WriteLine("Game Over!");
                        Console.WriteLine("You loose!");
                    }
                    Console.WriteLine("");
                    Console.WriteLine("=========");
                    Console.WriteLine("|Round 19|");
                    Console.WriteLine("=========");
                    Console.WriteLine("In the ninteenth round you are facing Leo Messi - Argentine football player, considered one of the best football players in the world!");
                    Console.WriteLine("");
                    Console.WriteLine("What do you choose :rock,scissors or paper?");
                    Console.WriteLine("");
                    string twentiethAsnwer = Console.ReadLine();
                    Console.WriteLine($"You chose {twentiethAsnwer}!");
                    if (twentiethAsnwer == "rock")
                    {
                        int type = new Random().Next(1, 3);

                        switch (type)
                        {
                            case 1:
                                Console.WriteLine("");
                                Console.WriteLine("Leo Messi chose:scissors!You win!You gain 20 life points and proceed to the last 20th round!Good luck!");
                                Console.WriteLine("");
                                health = health + 20;
                                Console.WriteLine($"Your health is {health}!");
                                break;
                            case 2:
                                Console.WriteLine("");
                                Console.WriteLine("Leo Messi chose:paper!You lose!You lose 20 life points,but don't despair,you continue to the last 20th round!Good luck!");
                                Console.WriteLine("");
                                health = health - 20;
                                Console.WriteLine($"Your health is {health}!");
                                break;
                        }

                    }
                    else if (twentiethAsnwer == "scissors")
                    {
                        int type = new Random().Next(1, 3);

                        switch (type)
                        {
                            case 1:
                                Console.WriteLine("");
                                Console.WriteLine("Leo Messi chose:paper!You win!You gain 20 life points and proceed to the last 20th round!Good luck!");
                                Console.WriteLine("");
                                health = health + 20;
                                Console.WriteLine($"Your health is {health}!");
                                break;
                            case 2:
                                Console.WriteLine("");
                                Console.WriteLine("Leo Messi chose:rock!You lose!You lose 20 life points,but don't despair,you continue to the last 20th round!Good luck!");
                                Console.WriteLine("");
                                health = health - 20;
                                Console.WriteLine($"Your health is {health}!");
                                break;
                        }
                    }
                    else if (twentiethAsnwer == "paper")
                    {
                        int type = new Random().Next(1, 3);

                        switch (type)
                        {
                            case 1:
                                Console.WriteLine("");
                                Console.WriteLine("Leo Messi chose:rock!You win!You gain 20 life points and proceed to the last 20th round!Good luck!");
                                Console.WriteLine("");
                                health = health + 20;
                                Console.WriteLine($"Your health is {health}!");
                                break;
                            case 2:
                                Console.WriteLine("");
                                Console.WriteLine("Leo Messi chose:scissors!You lose!You lose 20 life points,but don't despair,you continue to the last 20th round!Good luck!");
                                Console.WriteLine("");
                                health = health - 20;
                                Console.WriteLine($"Your health is {health}!");
                                break;
                        }


                    }
                    if (health <= 0)
                    {
                        Console.WriteLine("Game Over!");
                        Console.WriteLine("You loose!");
                    }
                    Console.WriteLine("");
                    Console.WriteLine("=========");
                    Console.WriteLine("|Round 20|");
                    Console.WriteLine("=========");
                    Console.WriteLine("Congratulations, you've made it to the final round!Good luck!");
                    Console.WriteLine("");
                    Console.WriteLine("In the final round you are facing Elon Musk - Entrepreneur and innovator, founder of Tesla, SpaceX and Neuralink!");
                    Console.WriteLine("");
                    Console.WriteLine("What do you choose :rock,scissors or paper?");
                    Console.WriteLine("");
                    string twentiethOneAsnwer = Console.ReadLine();
                    Console.WriteLine($"You chose {twentiethOneAsnwer}!");
                    if (twentiethOneAsnwer == "rock")
                    {
                        int type = new Random().Next(1, 3);

                        switch (type)
                        {
                            case 1:

                                health = health + 20;
                                Console.WriteLine("");
                                Console.WriteLine("Elon Musk chose:scissors!You win the game tickets to all the matches of the 2026 FIFA World Cup in America!");
                                Console.WriteLine("");
                                Console.WriteLine($"Your health is {health}!");
                                break;
                            case 2:

                                health = health - 20;
                                Console.WriteLine("");
                                Console.WriteLine("Elon Musk chose:paper!You lose,but you win win tickets to all the matches of the 2026 FIFA World Cup in America!");
                                Console.WriteLine("");
                                Console.WriteLine($"Your health is {health}!");
                                break;
                        }

                    }
                    else if (twentiethOneAsnwer == "scissors")
                    {
                        int type = new Random().Next(1, 3);

                        switch (type)
                        {
                            case 1:
                                health = health + 20;
                                Console.WriteLine("");
                                Console.WriteLine("Elon Musk chose:paper!You win the game and tickets to all the matches of the 2026 FIFA World Cup in America!");
                                Console.WriteLine("");
                                Console.WriteLine($"Your health is {health}!");

                                break;
                            case 2:
                                health = health - 20;
                                Console.WriteLine("");
                                Console.WriteLine("Elon Musk chose:rock!You lose,but you win win tickets to all the matches of the 2026 FIFA World Cup in America!");
                                Console.WriteLine("");
                                Console.WriteLine($"Your health is {health}!");
                                break;
                        }
                    }
                    else if (twentiethOneAsnwer == "paper")
                    {
                        int type = new Random().Next(1, 3);

                        switch (type)
                        {
                            case 1:

                                health = health + 20;
                                Console.WriteLine("");
                                Console.WriteLine("Elon Musk chose:rock!You win the game and tickets to all the matches of the 2026 FIFA World Cup in America!");
                                Console.WriteLine("");
                                Console.WriteLine($"Your health is {health}!");
                                break;
                            case 2:

                                health = health - 20;
                                Console.WriteLine("");
                                Console.WriteLine("Elon Musk chose:scissors!You lose,but you win win tickets to all the matches of the 2026 FIFA World Cup in America!");
                                Console.WriteLine("");
                                Console.WriteLine($"Your health is {health}!");
                                break;
                        }

                        if (health <= 0)
                        {
                            Console.WriteLine("Game Over!");
                        }

                    }
                }
                else
                {
                    Console.WriteLine("You are a coward :D!Boo Boo Boo!!!");

                }
                

            }
            Console.WriteLine("Game Over!");
        }
    }
}


