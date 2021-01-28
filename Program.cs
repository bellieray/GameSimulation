using System;

namespace GameSimulation
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Please Read The Instructions");
            Console.WriteLine("If you want to select player operations press 1 \n  If you want to add campaign press 2 \n If you want to go order operations press 3");

            Console.WriteLine("Please enter the operation number");
            int operationNumber = Convert.ToInt32(Console.ReadLine());

            switch (operationNumber)
            {
                case 1:
                    //CASE1

                    Console.WriteLine("----------------Welcome to the  create, update and delete operation related to players---------------------------");
                    PlayerInfo player = new PlayerInfo();

                    Console.WriteLine("Please enter your Name : ");
                    player.Name = Console.ReadLine();

                    Console.WriteLine("Please enter your Surname : ");
                    player.Surname = Console.ReadLine();

                    Console.WriteLine("Your Username is : " + player.Username);

                    PlayerManager playerManager = new PlayerManager();
                    playerManager.UpdatePlayer(player);
                    playerManager.DeletePlayer(player);
                    playerManager.RegisterPlayer(player);

                    break;
                   
                    //CASE2
                case 2:
                    Console.WriteLine("------------------ Welcome To The Campaign Screen---------------------");

                    Campaign campaign = new Campaign();
                    CampaignManager campaignManager = new CampaignManager();
                    int wantedNumber;
                    int section = 1;
                    Console.WriteLine("If you want to just add campaign name please enter 0 ");
                    wantedNumber = Convert.ToInt32(Console.ReadLine());
                    if (wantedNumber == 0)
                    {
                        Console.WriteLine("Please Enter Campaign Name ");
                        campaign.CampaignName = Console.ReadLine();
                        section++;
                    }
                    else
                    {
                        Console.WriteLine("Please Enter Campaign Name ");
                        campaign.CampaignName = Console.ReadLine();

                        Console.WriteLine("Please Enter Campaign ID ");
                        campaign.CampaignId = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Please enter how long the campaign will last. ");
                        campaign.CampaignLong = Convert.ToInt32(Console.ReadLine());


                        section--;
                    }

                    if (section == 2)
                    {
                        campaignManager.AddCampaign(campaign);
                        campaignManager.DeleteCampaign(campaign);
                        campaignManager.UpdateCampaign(campaign);
                    }
                    else if (section == 0)
                    {
                        Console.WriteLine("Your Campaign Name : " + campaign.CampaignName + "       "   + " Your Campaign ID : " + campaign.CampaignId + "     " +  "Your Campaign Long : " +  campaign.CampaignLong);
                        campaignManager.AddCampaign(campaign);
                        campaignManager.DeleteCampaign(campaign);
                        campaignManager.UpdateCampaign(campaign);
                    }

                    break;

                case 3:
                    //CASE3
                    Console.WriteLine("----------------Welcome To  Order Screen-------------------");

                    Order order = new Order();

                    Console.WriteLine("Please Enter Game Name :");
                    order.gameName = Console.ReadLine();

                    Console.WriteLine("Please Enter Game Price ");
                    order.gamePrice = Convert.ToInt32(Console.ReadLine());

                    OrderManager orderManager = new OrderManager();
                    orderManager.AddGame(order);
                    orderManager.AddPrice(order);

                    break;
            }



            

            

        }
    }
}
