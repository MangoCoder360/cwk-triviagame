using System;
using System.Collections.Generic;
using System.Linq;

namespace triviagame
{
    class MainClass
    {
        private static void showQuestion(List<int> questionsDone,int score)
        {
            MainClass classInstance = new MainClass();
            Random random = new Random();
            if(questionsDone.Contains(1) && questionsDone.Contains(2) && questionsDone.Contains(3) && questionsDone.Contains(4))
            {
                Console.WriteLine("You finished!");
                Console.WriteLine("You got " + Convert.ToString(score) + " questions correct");
                System.Environment.Exit(1);
            }
            else {
                switch (random.Next(4))
                {
                    case 0:
                        if (!questionsDone.Contains(1))
                        {
                            if (classInstance.q1()) {
                                Console.WriteLine("adding 1 to score");
                                score = score + 1;
                            };
                            questionsDone.Add(1);
                        }
                        else
                        {
                            showQuestion(questionsDone,score);
                        }
                        break;
                    case 1:
                        if (!questionsDone.Contains(2))
                        {
                            if (classInstance.q2())
                            {
                                Console.WriteLine("adding 1 to score");
                                score++;
                            };
                            questionsDone.Add(2);
                        }
                        else
                        {
                            showQuestion(questionsDone,score);
                        }
                        break;
                    case 2:
                        if (!questionsDone.Contains(3))
                        {
                            if (classInstance.q3())
                            {
                                Console.WriteLine("adding 1 to score");
                                score++;
                            };
                            questionsDone.Add(3);
                        }
                        else
                        {
                            showQuestion(questionsDone,score);
                        }
                        break;
                    case 3:
                        if (!questionsDone.Contains(4))
                        {
                            if (classInstance.q4())
                            {
                                Console.WriteLine("adding 1 to score");
                                score++;
                            };
                            questionsDone.Add(4);
                        }
                        else
                        {jhgjhg
                            showQuestion(questionsDone,score);
                        }
                        break;
                }
            }
        }

        public static void Main(string[] args)
        {
            List<int> questionsDone = new List<int>();
            int score = 0;
            Console.WriteLine("Welcome to trivia game!");
            while (true)
            {
                showQuestion(questionsDone,score);
            }
        }
        public bool q1()
        {
            Console.WriteLine("What is the best-selling video game?");
            Console.WriteLine("1) Call of Duty: Modern Warfare");
            Console.WriteLine("2) Minecraft");
            Console.WriteLine("3) Rocket League");
            Console.WriteLine("4) macOS Chess");
            int answer = Convert.ToInt16(Console.ReadLine());
            if (answer == 2)
            {
                Console.WriteLine("CORRECT");
                return true;
            }
            else
            {
                Console.WriteLine("INCORRECT");
                return false;
            }
        }
        public bool q2()
        {
            Console.WriteLine("What is the name of macOS 11?");
            Console.WriteLine("1) MacOS X El Capitan");
            Console.WriteLine("2) macOS Ventura");
            Console.WriteLine("3) OSX Blue Cheese");
            Console.WriteLine("4) macOS Big Sur");
            int answer = Convert.ToInt16(Console.ReadLine());
            if (answer == 4)
            {
                Console.WriteLine("CORRECT");
                return true;
            }
            else
            {
                Console.WriteLine("INCORRECT");
                return false;
            }
        }
        public bool q3()
        {
            Console.WriteLine("Who is the impostor?");
            Console.WriteLine("1) Blue");
            Console.WriteLine("2) Red");
            Console.WriteLine("3) Green");
            Console.WriteLine("4) Purple");
            int answer = Convert.ToInt16(Console.ReadLine());
            if (answer == 2)
            {
                Console.WriteLine("CORRECT");
                return true;
            }
            else
            {
                Console.WriteLine("INCORRECT");
                return false;
            }
        }
        public bool q4()
        {
            Console.WriteLine("What is the best operating system?");
            Console.WriteLine("1) Ubuntu 22.04");
            Console.WriteLine("2) macOS");
            Console.WriteLine("3) Windows 10");
            Console.WriteLine("4) Windows 11");
            int answer = Convert.ToInt16(Console.ReadLine());
            if (answer == 2)
            {
                Console.WriteLine("CORRECT");
                return true;
            }
            else
            {
                Console.WriteLine("INCORRECT");
                return false;
            }
        }
    }
}
