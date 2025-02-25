public IList<IList<int>> ThreeSum(int[] numbers)
{
    var result = new List<IList<int>>();

    for (int i = 0; i < numbers.Length - 2; i++)
    {
        for (int j = i + 1; j < numbers.Length - 1; j++)
        {
            for (int k = j + 1; k < numbers.Length; k++)
            {
                var sum = numbers[i] + numbers[j] + numbers[k];
                if (sum == 0)
                {
                    var triplets = new List<int> { numbers[i], numbers[j], numbers[k] };
                    if (AreTripletsUnique(result, triplets))
                    {
                        result.Add(triplets);
                    }
                    break;
                }
            }
        }
    }

    return result;
}

private bool AreTripletsUnique(IList<IList<int>> result, IList<int> triplets)
{
    foreach (IList<int> res in result)
    {
        var num1 = triplets[0];
        var num2 = triplets[1];
        var num3 = triplets[2];

        if (res.Contains(num1) && res.Contains(num2) && res.Contains(num3))
        {
            if (num1 == num2 && num2 == num3)
            {
                var count = res.Where(num => num == num1).Count();
                if (count != 3)
                {
                    continue;
                }
            }
            return false;
        }
    }

    return true;
}