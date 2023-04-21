namespace Hero.Service
{
    public class CarService
    {
        public string GetAction(string light)
        {
            if (light.ToLower().Equals("red"))
            {
                return "stop";
            }

            if (light.ToLower().Equals("yellow"))
            {
                return "slow";
            }

            if (light.ToLower().Equals("green"))
            {
                return "go";
            }

            return "i don't know";
        }
    }
}