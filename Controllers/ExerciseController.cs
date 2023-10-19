using CodingExercises.Services;
using Microsoft.AspNetCore.Mvc;

namespace CodingExercises.Controllers;

[ApiController]
[Route("[controller]")]
public class ExerciseController : ControllerBase
{
    public ExerciseController()
    {
        
    }

    [HttpPost()]
    [Route("MergeAlternately")]
    public ActionResult<string> MergeAlternately(string word1, string word2)
    {
        return ExerciseSerivce.MergeAlternately(word1, word2);
    }

    [HttpPost()]
    [Route("KidsWithCandies")]
    public ActionResult<List<bool>> KidsWithCandies(int[] candies, int extraCandies)
    {
        return ExerciseSerivce.KidsWithCandies(candies, extraCandies);
    }
}