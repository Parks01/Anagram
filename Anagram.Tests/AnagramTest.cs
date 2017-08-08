using AnagramBuilder.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;

namespace AnagramBuilder.Test
{
  [TestClass]
  public class AnagramTest
  {
    [TestMethod]
    public void SortInput_SortedInput_True()
    {
      Anagram test = new Anagram("beard");

      char[] expected = {'a', 'b', 'd', 'e', 'r'};
      char[] result =  test.SortInput();

      CollectionAssert.AreEqual(expected, result);
    }
    [TestMethod]
    public void CompareAnagrams_CheckSubmittedWordAnagram_True()
    {
      Anagram test = new Anagram("beard");
      List<string> expected = new List<string>() {"abder", "abder", "abder"};

      test.SortInput();
      test.CompareAnagrams();
      List<string> result = test.GetSortedAnagrams();

      // Console.WriteLine("Sorted word: " + test)
      CollectionAssert.AreEqual(expected, result);
    }
  }
}

// grab input word
// convert it to character array and sort it
//
