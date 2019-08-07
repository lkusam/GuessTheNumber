using System;
using GuessTheNumber.Models;

namespace GuessTheNumber.ApplicationLayer
{
    /// <summary>
    /// Provides the result Message. 
    /// </summary>
    public  class Result
    {

        /// <summary>
        /// Gets the proper Result value based on values entereed
        /// </summary>
        /// <param name="_myModel"></param>
        /// <returns></returns>
   public  string GetResult(ref MyModel _myModel)
        {
            try
            {

                string ResultStr =null , rsltsubstr = null;
             
            int difference = _myModel.MyNumber - _myModel.EnteredNum;
                if (difference != 0)
                {
                    rsltsubstr = GetHotorCold(difference);

                    ResultStr = HowFar(difference);
                    return $"{ResultStr}  {rsltsubstr}";
                }
                else
                {
                    _myModel.Success = true;
                    return "You are Awesome";
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        private string GetHotorCold(int diffrence)
        {
            string hotorcold = (diffrence > 0 ? "Cold" : "Hot");
            return hotorcold;
        }

        private string HowFar(int diffrence)
        {
            string Ishowfar = null;
            int moddiff = Math.Abs(diffrence);

             if (moddiff > 40)
                Ishowfar = "Unbeliveable";

            else if (moddiff > 30)
                Ishowfar = "Too";
            else if (moddiff > 20)
                Ishowfar = "Moderate";

            else if (moddiff > 10)
                Ishowfar = "Little";
           
            else if(moddiff <= 10)
                Ishowfar = "Very Less";

            return Ishowfar;
        }
    }
}
