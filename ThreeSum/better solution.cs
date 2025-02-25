public IList<IList<int>> ThreeSum(int[] numbers) {
        Array.Sort(numbers);

        var result = new List<IList<int>>();

        for(int i = 0; i < numbers.Length - 2; i++)
        {
            if (i > 0 && numbers[i] == numbers[i - 1])
                continue;

            var left = i + 1;
            var right = numbers.Length - 1;

            while (left < right)
            {
                var currentSum = numbers[i] + numbers[left] + numbers[right];

                if (currentSum < 0)
                {
                    left++;
                }
                else if (currentSum > 0)
                {
                    right--;
                }
                else
                {
                    var triplets = new List<int> { numbers[i], numbers[left], numbers[right]};
                    result.Add(triplets);
                    left++;
                    while (left < right && numbers[left] == numbers[left - 1])
                        left++;
                        

                    right--;
                    while (left < right && numbers[right] == numbers[right + 1])
                        right--;
                }
            }
        }

        return result;
    }