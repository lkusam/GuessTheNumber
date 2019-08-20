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
                _myModel.TryCounter +=1;
                if (_myModel.TryCounter
                    <= 10)
                {
                    string ResultStr = null, rsltsubstr = null;

                    int difference = _myModel.MyNumber - _myModel.EnteredNum;
                    if (difference != 0)
                    {
                        rsltsubstr = GetHotorCold(difference);

                        ResultStr = HowFar(difference);
                        return $"{ResultStr}; {rsltsubstr}";
                    }
                    else
                    {
                        _myModel.Success = true;
                        return "You are Awesome";
                    }
                }
                else
                    return "Sorry you loose";
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        private string GetHotorCold(int diffrence)
        {
            string hotorcold = $"The Number enter is {(diffrence > 0 ? "Low" : "High")}";
            return hotorcold;
        }

        private string HowFar(int diffrence)
        {
            string Ishowfar = null;
            int moddiff = Math.Abs(diffrence);

             if (moddiff > 40)
                Ishowfar = "There is more than 40 numbers difference";

            else if (moddiff > 30)
                Ishowfar = "There is more than 30 numbers difference";
            else if (moddiff > 20)
                Ishowfar = "There is more than 20 numbers difference";

            else if (moddiff > 10)
                Ishowfar = "There is more than 10 numbers difference";
           
            else if(moddiff <= 10)
                Ishowfar = "There is less than 10 numbers difference";

            return Ishowfar;
        }
    }
}
