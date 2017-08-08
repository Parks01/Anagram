using System.Collections.Generic;
using System;
using AnagramBuilder.Models;

namespace AnagramBuilder.Models
{
  public class Anagram
  {
    private string _inputWord;
    private char[] _inputCharArray;
    private List<string> _possibleAnagrams;
    private List<string> _sortedAnagrams;

    public Anagram(string inputWord)
    {
      _inputWord = inputWord;
      _possibleAnagrams = new List<string>() {"eardb", "ardbe", "rdbea"};
      _sortedAnagrams = new List<string> {};
    }

    public char[] SortInput()
    {
      char[] input = _inputWord.ToCharArray();
      Array.Sort(input);
      _inputCharArray = input;
      return input;
    }

    public List<string> GetSortedAnagrams()
    {
      return _sortedAnagrams;
    }

    public void CompareAnagrams()
    {
      //Looping through all possible words
      foreach(string word in _possibleAnagrams)
      {
        //Converting words to character arrays and sorting them alphabetically
        char[] temp = word.ToCharArray();
        Array.Sort(temp);
        bool matches = true;

        //Looping through the character arrays and seeing if they match
        for(int i = 0; i < _inputCharArray.Length; i++)
        {
          if(_inputCharArray[i] != temp[i])
          {
            matches = false;
            break;
          }
        }
        if(matches)
        {
          string s = new string(temp);
          _sortedAnagrams.Add(s);
        }
      }
    }
  }
}
