namespace Chapter8.Starbuzz.TemplateMethodPattern;

public class Coffee: CaffeineBeverage
{
   protected override void Brew()
   {
      Console.WriteLine("Dripping Coffee Through Filter");
   }

   protected override void AddCondiments()
   {
      Console.WriteLine("Adding Sugar And Milk");
   }


}
