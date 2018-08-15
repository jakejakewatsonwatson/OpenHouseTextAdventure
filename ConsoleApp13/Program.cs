using System;

namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to our open house!");
            Console.WriteLine();
            Console.WriteLine("Please follow the route in the pamphlet. Refreshments are available at the end of the tour!");
            Console.ReadLine();

            Console.WriteLine("Would you like to visit the living room?");
            string userResponse = Console.ReadLine();

               if (userResponse.ToLower() == "y" || userResponse.ToLower() == "yes")
               {
                    Console.WriteLine("You look around and notice that the wooden floor has been freshly waxed, all except one corner.");
                    Console.WriteLine();
                    Console.WriteLine("Would you like to inspect the unwaxed corner?");
                    userResponse = Console.ReadLine();
                    
                        if (userResponse.ToLower() == "y" || userResponse.ToLower() == "yes")
                        {
                            Console.WriteLine("The Real Estate Agent quickly jumps in front of you before you can inspect the corner closely.");
                            Console.WriteLine();
                            Console.WriteLine("She clearly does not want you to see it");
                            Console.WriteLine();
                        }

                        else if (userResponse.ToLower() == "n" || userResponse.ToLower() == "no")
                        {
                            Console.WriteLine("It's not your problem. You're only here for the refreshments, after all.");
                            Console.WriteLine();
                        }
               }

            Console.WriteLine("Would you like to visit the office?");
            userResponse = Console.ReadLine();
                
                if (userResponse.ToLower() == "y" || userResponse.ToLower() == "yes")
                {
                    Console.WriteLine("Upon entering the office you notice an open bag of doritos hiddden behind the desk.");
                    Console.WriteLine();
                    Console.WriteLine("Would you like to inspect the bag of doritos?");
                    userResponse = Console.ReadLine();
                    
                        if (userResponse.ToLower() == "y" || userResponse.ToLower() == "yes")
                        {
                            Console.WriteLine("As you pick up the bag a chip falls out onto the desk, practically inviting you to eat it.");
                            Console.WriteLine();
                            Console.WriteLine("Do you take a bite of the dorito?");
                            userResponse = Console.ReadLine();

                                if (userResponse.ToLower() == "y" || userResponse.ToLower() == "yes")
                                {
                                    Console.WriteLine("You attempt to take a bite of the chip, but it has aged so finely that it as hard as a rock.");
                                    Console.WriteLine();
                                    Console.WriteLine("Perhaps there will be a better selection at the refreshment table.");
                                    Console.WriteLine();
                                }

                                else if (userResponse.ToLower() == "n" || userResponse.ToLower() == "no")
                                {
                                    Console.WriteLine("Yeah, that's probably not the best idea. The refreshment table should have a better selection.");
                                    Console.WriteLine();
                                }
                        }
                }

            Console.WriteLine("Would you like to visit the guest bathroom?");
            userResponse = Console.ReadLine();

                if (userResponse.ToLower() == "y" || userResponse.ToLower() == "yes")
                {
                    Console.WriteLine("You squeeze into the guest bathroom, barely fitting in betweeen the toilet, sink, and bathtub");
                    Console.WriteLine("As much as you inspect the room, you can find nothing wrong in here."); 
                    Console.WriteLine("Apart from the tightly cramped design of the bathroom");
                    Console.WriteLine();
                }

            Console.WriteLine("Would you like to visit the master bedroom?");
            userResponse = Console.ReadLine();

                if (userResponse.ToLower() == "y" || userResponse.ToLower() == "yes")
                {
                    Console.WriteLine("You walk into the master bedroom, impressed with how spacious it is");
                    Console.WriteLine("As you look around the room, you notice an old movie poster.");
                    Console.WriteLine("It strikes you as out of place for some reason. Not really matching the rest of the decor.");
                    Console.WriteLine();
                    Console.WriteLine("Inspect the movie poster?");
                    userResponse = Console.ReadLine();
                    
                        if (userResponse.ToLower() == "y" || userResponse.ToLower() == "yes")
                        {
                            Console.WriteLine("You slowly peel back the movie poster.");
                            Console.WriteLine("Your inner adventurer becomes giddy with excitement about what could be behind the poster.");
                            Console.WriteLine();
                            Console.WriteLine("As you begin to make sense of what lies behind the poster, you realize it is just a circuit breaker box.");
                            Console.WriteLine("How anti-climactic.");
                            Console.WriteLine();
                        }

                        else if (userResponse.ToLower() == "n" || userResponse.ToLower() == "no")
                        {
                            Console.WriteLine("It's probably not a good idea to tear down someone elses poster, no matter how weird it is.");
                            Console.WriteLine();
                        }
                }

            Console.WriteLine("Would you like to visit the master bathroom?");
            userResponse = Console.ReadLine();
                
                if (userResponse.ToLower() == "y" || userResponse.ToLower() == "yes")
                {
                    Console.WriteLine("You walk into the bathroom and your eyes are immediately assaulted by the bright pink wallpaper that surrounds you");
                    Console.WriteLine("Barely able to keep your eyes open due to the brightness of the wallpaper, you notice something odd about the shower.");
                    Console.WriteLine("The shower has no showerhead.");
                    Console.WriteLine();
                    Console.WriteLine("Would you like to inspect the shower?");
                    userResponse = Console.ReadLine();

                        if (userResponse.ToLower() == "y" || userResponse.ToLower() == "yes")
                        {
                            Console.WriteLine("You turn the shower knob on to the hottest setting and immediately become drenched with hot water coming from the ceiling.");
                            Console.WriteLine();
                            Console.WriteLine("As you recover from the scalding water, you look up and notice the small holes in the ceiling where the shower water is coming from");
                            Console.WriteLine("\"That's a cool feature\", you think to yourself");
                        }

                        else if (userResponse.ToLower() == "n" || userResponse.ToLower() == "no")
                        {
                            Console.WriteLine("You took a few plumbing courses in college, but not enough for youy to justify tampering with the shower.");
                            Console.WriteLine();
                        }
                }

            Console.WriteLine("Would you like to visit the kitchen?");
            userResponse = Console.ReadLine();

                if (userResponse.ToLower() == "y" || userResponse.ToLower() == "yes")
                {
                    Console.WriteLine("You make your way into the kitchen, and are immediately interested in the sink for some reason");
                    Console.WriteLine();
                    Console.WriteLine("Would you like to inspect the sink?");
                    userResponse = Console.ReadLine();

                        if (userResponse.ToLower() == "y" || userResponse.ToLower() == "yes")
                        {
                            Console.WriteLine("You gaze upon the sight of an empty sink. A sight you haven't seen in a few weeks.");
                            Console.WriteLine();
                            Console.WriteLine("You begin feeling a little impulsive. Would you like to turn on the garbage disposal?");
                            userResponse = Console.ReadLine();

                                if (userResponse.ToLower() == "y" || userResponse.ToLower() == "yes")
                                {
                                    Console.WriteLine("You flip the switch and turn on the garbage disposal");
                                    Console.WriteLine("The harsh grinding sound of the garbage disposal echoes throughout the house.");
                                    Console.WriteLine();
                                    Console.WriteLine("Your little stunt has garnered the attention of all of the other guests. Are you happy now?");
                                    Console.WriteLine();
                                }

                                else if (userResponse.ToLower() == "n" || userResponse.ToLower() == "no")
                                {
                                    Console.WriteLine("Probably not the best idea. You don't want anyone to notice that you're the guy going around to all of the open houses for free refreshments.");
                                    Console.WriteLine();
                                }
                        }
                }

            Console.WriteLine("You've made it all the way through the tour, would you like to view the refreshments?");
            userResponse = Console.ReadLine();

                if (userResponse.ToLower() == "y" || userResponse.ToLower() == "yes")
                {
                    Console.WriteLine("You make your way back into the main hall and see the refreshment table.");
                    Console.WriteLine("The only refreshment still on the table is a platter of donuts.");
                    Console.WriteLine();
                    Console.WriteLine("You recently began a low-carb diet, would you like give up on your diet?");
                    userResponse = Console.ReadLine();
                        if (userResponse.ToLower() == "y" || userResponse.ToLower() == "yes")
                        {
                            Console.WriteLine("\"A moment of weakness\", you call it. \"It's my cheat day\", you convince yourself as you bite into the donut.");
                            Console.WriteLine();
                        }

                        else if (userResponse.ToLower() == "n" || userResponse.ToLower() == "no")
                        {
                            Console.WriteLine("You remained strong and resisted the sugary-glazed temptation of the donuts.");
                        }

                }

            Console.WriteLine("You survived the open house with only minimal injuries, and it's not so bad of a place");
            Console.WriteLine();
            Console.WriteLine("You make your way to the next open house in your pursuit of free food.");

            Console.ReadLine();
        }
    }
}
