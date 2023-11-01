class Program
{
    static void Main()
    {
        int playerCoins = 6000;
        
        int shirtPrice = 2500;
        int helmetPrice = 3000;
        int foodPrice = 500;
        int presentPrice = 1000;
        int jacketPrice=3200;

        Console.WriteLine("------------------------------");
        Console.WriteLine("Welcome to the general store!");
        Console.WriteLine("------------------------------");

        Console.WriteLine("");
     
    
       
   
   
while(playerCoins>0)
{
        Console.WriteLine("What would you like to purchase?");
         Console.WriteLine("");

        Console.WriteLine("A: A nice shirt.");
        Console.WriteLine("B: A protective helmet.");
        Console.WriteLine("C: Some food.");
        Console.WriteLine("D: A present.");
        Console.WriteLine("E: A Jacket.");

        Console.WriteLine("");

        Console.WriteLine("Enter the letter for your purchase: ");
        string purchaseLetter = Console.ReadLine();

        Console.WriteLine("");

 
 
        switch (purchaseLetter) 
        {
            case "A":
                 
                playerCoins = playerCoins - shirtPrice;
                
                
           if(playerCoins>0)
        {
          Console.WriteLine($"Thanks for your purchase! You have {playerCoins} coins remaining.");
                       
                }
                else {Console.WriteLine($"Thanks for your purchase! you have no Coins remaining.") ;}
             
                break;
                
            
           
            case "B":
              
                playerCoins = playerCoins - helmetPrice;
                if(playerCoins>0){
                Console.WriteLine($"Thanks for your purchase! You have {playerCoins} coins remaining.");
                }
                else {Console.WriteLine($"Thanks for your purchase! you have no Coins remaining.") ;}
                break;

            case "C":
                playerCoins = playerCoins - foodPrice;

                 if(playerCoins>0){
                Console.WriteLine($"Thanks for your purchase! You have {playerCoins} coins remaining.");
                }
                else {Console.WriteLine($"Thanks for your purchase! you have no Coins remaining.") ;}
                break;
            case "D":
                playerCoins = playerCoins - presentPrice;
                 if(playerCoins>0){
                Console.WriteLine($"Thanks for your purchase! You have {playerCoins} coins remaining.");
                }
                else {Console.WriteLine($"Thanks for your purchase! you have no Coins remaining.") ;}
                break;
            case "E":
               playerCoins = playerCoins -jacketPrice;
               if(playerCoins>0){
                Console.WriteLine($"Thanks for your purchase! You have {playerCoins} coins remaining.");
                }
                else {Console.WriteLine($"Thanks for your purchase! you have no Coins remaining.") ;}
                break; 
            default:
            Console.WriteLine("letter doesn't recognize.Enter again");
            break;
         
            
        
 }
}  
    
    
    
    }
}

