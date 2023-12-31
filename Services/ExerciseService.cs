using System.Text;

namespace CodingExercises.Services;

public static class ExerciseSerivce
{
    static ExerciseSerivce()
    {

    }

    public static string MergeAlternately(string word1, string word2)
    {
        if (word1 == null || word2 == null)
        {
            return string.Empty;
        }

        int index = 0;
        int maxIndexWord1 = word1.Length - 1;
        int maxIndexWord2 = word2.Length - 1;

        StringBuilder mergedWord = new StringBuilder();

        while (true)
        {
            mergedWord.Append(index > maxIndexWord1 ? string.Empty : word1[index]);
            mergedWord.Append(index > maxIndexWord2 ? string.Empty : word2[index]);

            index++;

            if (index > maxIndexWord1 && index > maxIndexWord2)
            {
                break;
            }
        }

        return mergedWord.ToString();
    }

    public static List<bool> KidsWithCandies(int[] candies, int extraCandies)
    {
        if (candies == null)
        {
            return null;
        }

        if (extraCandies <= 0)
        {
            return null;
        }

        int maxIndex = candies.Length;
        bool willHaveMaxCandies = true;

        List<bool> returnValue = new List<bool>(maxIndex);

        for (int i = 0; i < maxIndex; i++)
        {
            for (int j = 0; j < maxIndex; j++)
            {
                if (candies[i] + extraCandies < candies[j])
                {
                    willHaveMaxCandies = false;

                    break;
                }
            }

            if (willHaveMaxCandies)
            {
                returnValue.Add(true);
            }
            else
            {
                returnValue.Add(false);
            }

            willHaveMaxCandies = true;
        }

        return returnValue;
    }
}