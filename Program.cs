static int SansaXor(List<int> numbersArray)
{
	if (numbersArray.Count % 2 == 0)
	{
		return 0;
	}

	int result = 0;		

	for (int index = 0; index < numbersArray.Count; index += 2)
	{
		result ^= numbersArray[index];
	}

	return result;
}