using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HerediaJ_MC_5_EightToTen.Services
{
    public class Magic8BallService
    {
        
        Random rng = new Random();

        public string Magic8Ball(string userQuestion)
        {
            string answer = ""; 

            switch (rng.Next(9))
            {

                case 1:
                    answer = $"Your question was: {userQuestion} \nYour answer: Perchance.";
                break;
                case 2:
                    answer = $"Your question was: {userQuestion} \nYour answer: Ask again. ";
                break;
                 case 3:
                    answer = $"Your question was: {userQuestion} \nYour answer: Sources say: True!";
                break;
                case 4:
                    answer = $"Your question was: {userQuestion} \nYour answer: Probabilty of succes: 100%!";
                break;
                 case 5:
                    answer = $"Your question was: {userQuestion} \nYour answer: Not gonna happen bro";
                break;
                case 6:
                    answer = $"Your question was: {userQuestion} \nYour answer: Not likely";
                break;
                 case 7:
                    answer = $"Your question was: {userQuestion} \nYour answer: ...What? sorry I wasn't paying attention";
                break;
                case 8:
                    answer = $"Your question was: {userQuestion} \nYour answer: Just give up";
                break;

            }

            return answer;

        }


    }
}