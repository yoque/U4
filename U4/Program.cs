using System;
using System.Collections;
using System.Collections.Generic;
namespace SkalProj_Datastrukturer_Minne
{
    class Program
    {
        /// <summary>
        /// The main method, vill handle the menues for the program
        /// </summary>
        /// <param name="args"></param>
        static void Main()
        {

            while (true)
            {
                Console.WriteLine("Please navigate through the menu by inputting the number \n(1, 2, 3 ,4, 0) of your choice"
                    + "\n1. Examine a List"
                    + "\n2. Examine a Queue"
                    + "\n3. Examine a Stack"
                    + "\n4. CheckParanthesis"
                    + "\n0. Exit the application");
                char input = ' '; //Creates the character input to be used with the switch-case below.
                try
                {
                    input = Console.ReadLine()[0]; //Tries to set input to the first char in an input line
                }
                catch (IndexOutOfRangeException) //If the input line is empty, we ask the users for some input.
                {
                    Console.Clear();
                    Console.WriteLine("Please enter some input!");
                }
                switch (input)
                {
                    case '1':
                        ExamineList();
                        break;
                    case '2':
                        ExamineQueue();
                        break;
                    case '3':
                        ExamineStack();
                        break;
                    case '4':
                        CheckParanthesis();
                        break;
                    /*
                     * Extend the menu to include the recursive 
                     * and iterative exercises.
                     */
                    case '0':
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Please enter some valid input (0, 1, 2, 3, 4)");
                        break;
                }
            }
        }

        /// <summary>
        /// Examines the datastructure List
        /// </summary>
        static void ExamineList()
        {
            /*
             * Loop this method untill the user inputs something to exit to main menue.
             * Create a switch statement with cases '+' and '-'
             * '+': Add the rest of the input to the list (The user could write +Adam and "Adam" would be added to the list)
             * '-': Remove the rest of the input from the list (The user could write -Adam and "Adam" would be removed from the list)
             * In both cases, look at the count and capacity of the list
             * As a default case, tell them to use only + or -
             * Below you can see some inspirational code to begin working.
            */

            List<string> lista = new List<string>();
            string inp;
            do
            {
                inp = Console.ReadLine();

                char nav = inp[0];
                //Console.WriteLine(nav);
                string value = inp.Substring(1);
                //Console.WriteLine(value);
                string navstring = nav.ToString();

                switch (navstring)
                {
                    case "+":
                        lista.Add(value);
                        break;
                    case "-":
                        lista.Remove(value);
                        break;

                    default:
                        Console.WriteLine("Please type only '+' or '-'");
                        break;
                }


                if (nav.Equals('+'))
                {
                    lista.Add(value);
                    Console.Write(lista.Capacity);
                    Console.Write(lista.Count);
                }
                else if (nav.Equals('-'))
                {
                    lista.Remove(value);
                    Console.Write(lista.Capacity);
                    Console.Write(lista.Count);
                }

            } while (inp != "q");

        }

        //1. Skriv klart implementationen av ExamineList-metoden så att undersökningen blir
        //genomförbar.
        //2. När ökar listans kapacitet? (Alltså den underliggande arrayens storlek)
        //-när ett nytt Item överskrider listans kapacitet
        //3. Med hur mycket ökar kapaciteten?
        //-med det dubbla

        //4. Varför ökar inte listans kapacitet i samma takt som element läggs till?
        //-jag tror det beror på att defaultsize för den underliggande arrayen är satt till 4
        //5. Minskar kapaciteten när element tas bort ur listan?
        //-nej
        //6. När är det då fördelaktigt att använda en egendefinierad array istället för en lista?
        ///-när man behöver en mer dynamisk minnes-allokering


        /// <summary>
        /// Examines the datastructure Queue
        /// </summary>
        static void ExamineQueue()
        {
            /*
             * Loop this method untill the user inputs something to exit to main menue.
             * Create a switch with cases to enqueue items or dequeue items
             * Make sure to look at the queue after Enqueueing and Dequeueing to see how it behaves
            */

            string ink;
            string inq;
            //bool item;
            var item2 = "";
            Queue<string> queue = new Queue<string>();
            do
            {
                //inq = Console.ReadLine();

                Console.WriteLine("To add something to the queue, type 'k'");
                Console.WriteLine("To remove something from the queue, type 'x'");

                //queue.Enqueue(inq = Console.ReadLine());
                ink = Console.ReadLine();
                //char nav2 = inq[0];
                //Console.WriteLine(nav);
                //string value = inq.Substring(1);
                //Console.WriteLine(value);
                //string navqueue = nav2.ToString();

                switch (ink)
                {
                    case "k":
                        queue.Enqueue(inq = Console.ReadLine());
                        break;
                    case "x":
                        Console.WriteLine(queue.Peek()); queue.Dequeue();  //var item = queue.TryDequeue(out item2);   // 
                        break;

                    default:
                        Console.WriteLine("Please type only 'k' or 'x'");
                        break;
                }

                Console.WriteLine("The queue right now: ");
                foreach (string number in queue)
                {
                    Console.WriteLine(number);
                }

            } while (ink != "q");

        }

        /// <summary>
        /// Examines the datastructure Stack
        /// </summary>
        static void ExamineStack()
        {
            /*
             * Loop this method until the user inputs something to exit to main menue.
             * Create a switch with cases to push or pop items
             * Make sure to look at the stack after pushing and and poping to see how it behaves
            */

            //  1.Simulera ännu en gång ICA-kön på papper. Denna gång med en stack.Varför är det
            //    inte så smart att använda en stack i det här fallet?
            // --- pga FILO, First In First Out funkar bättre för ett kösystem


            Stack myStack = new Stack();

            //**************************************************************************************
            string ink;
            string inq;
            //bool item;
            var item2 = "";

            do
            {
                //inq = Console.ReadLine();

                Console.WriteLine("To push something to the stack, type 'k'");
                Console.WriteLine("To pop something from the stack, type 'x'");

                //queue.Enqueue(inq = Console.ReadLine());
                ink = Console.ReadLine();
                //char nav2 = inq[0];
                //Console.WriteLine(nav);
                //string value = inq.Substring(1);
                //Console.WriteLine(value);
                //string navqueue = nav2.ToString();

                switch (ink)
                {
                    case "k":
                        myStack.Push(inq = Console.ReadLine());
                        break;
                    case "x":
                        if (myStack.Count > 0)
                            Console.Write(myStack.Pop() + ",");
                        break;

                    default:
                        Console.WriteLine("Please type only 'k' or 'x'");
                        break;
                }

                Console.WriteLine("The stack right now: ");

                foreach (var item in myStack)
                {
                    Console.Write(item + ",");
                }





                //string[] myArray;

                // myStack.ToArray(myArray,6);
                //Console.WriteLine(myArray);

            } while (ink != "q");
            //********************************************************************************************






        }




        //Stack myreverseStack = new Stack();
        //inrev = Console.ReadLine();
        //char nav3 = inrev[0];



        static void CheckParanthesis()
        {
            string par;

            //int i=0;

            Console.WriteLine("Please type a sequence of parenthesis '(' or ')' or '{' or '}' or '[' or ']");
            par = Console.ReadLine();
            checkparenthesis(par);

            static void checkparenthesis(string par)
            {
                //string inpar = par;
                var j = 0;
                Stack p1Stack = new Stack();
                Stack p2Stack = new Stack();
                Stack p3Stack = new Stack();

                bool p1mismatch;
                bool p2mismatch;
                bool p3mismatch;

                foreach (var item in par)
                {
                    char parchar = par[j];
                    string parstring = parchar.ToString();
                    var p = par[j];
                    j++;
                    switch (parstring)
                    {
                        case "(":
                            p1Stack.Push(p);
                            break;
                        case ")":
                            if (p1Stack.Count > 0)
                                p1Stack.Pop();
                            else if (p1Stack.Count < 1) p1mismatch = true;
                            break;
                        case "[":
                            p2Stack.Push(p);
                            break;
                        case "]":
                            if (p2Stack.Count > 0)
                                p2Stack.Pop();
                            else if (p2Stack.Count < 1) p2mismatch = true;
                            break;

                        case "{":
                            p3Stack.Push(p);
                            break;
                        case "}":
                            if (p3Stack.Count > 0)
                                p3Stack.Pop();
                            else if (p3Stack.Count < 1) p3mismatch = true;
                            break;

                        default:
                            break;
                    }

                }

                foreach (var p1 in p1Stack)
                { Console.Write(p1 + ","); }
                Console.Write("\n");
                foreach (var p2 in p1Stack)
                { Console.Write(p2 + ","); }
                Console.Write("\n");
                foreach (var p3 in p1Stack)
                { Console.Write(p3 + ","); }

                if (p1Stack.Count > 0 || p2Stack.Count > 0 || p3Stack.Count > 0)
                    Console.WriteLine("Parenthesis mismatch!!!");
                else Console.WriteLine("Parenthesis match!!!");
            }

            /*
             * Use this method to check if the paranthesis in a string is Correct or incorrect.
             * Example of correct: (()), {}, [({})],  List<int> list = new List<int>() { 1, 2, 3, 4 };
             * Example of incorrect: (()]), [), {[()}],  List<int> list = new List<int>() { 1, 2, 3, 4 );
             */

        }

    }
}


