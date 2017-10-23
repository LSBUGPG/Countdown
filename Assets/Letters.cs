using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Letters : MonoBehaviour
{
    List<char> vowels = new List<char>();
    List<char> consonants = new List<char>();
    int index = 0;
    int vowelCount = 0;
    int consonantCount = 0;

    void Start()
    {
        AddToList(vowels, 'A', 9);
        AddToList(vowels, 'E', 12);
        AddToList(vowels, 'I', 9);
        AddToList(vowels, 'O', 8);
        AddToList(vowels, 'U', 4);

        AddToList(consonants, 'B', 2);
        AddToList(consonants, 'C', 2);
        AddToList(consonants, 'D', 4);
        AddToList(consonants, 'F', 2);
        AddToList(consonants, 'G', 3);
        AddToList(consonants, 'H', 2);
        AddToList(consonants, 'J', 1);
        AddToList(consonants, 'K', 1);
        AddToList(consonants, 'L', 4);
        AddToList(consonants, 'M', 2);
        AddToList(consonants, 'N', 6);
        AddToList(consonants, 'P', 2);
        AddToList(consonants, 'Q', 1);
        AddToList(consonants, 'R', 6);
        AddToList(consonants, 'S', 4);
        AddToList(consonants, 'T', 6);
        AddToList(consonants, 'V', 2);
        AddToList(consonants, 'W', 2);
        AddToList(consonants, 'X', 1);
        AddToList(consonants, 'Y', 2);
        AddToList(consonants, 'Z', 1);
    }

    void AddToList(List<char> list, char letter, int frequency)
    {
        for (int i = 0; i < frequency; ++i)
        {
            list.Add(letter);
        }
    }

    public void AddVowel()
    {
        if (vowelCount < 5)
        {
            vowelCount++;
            int r = Random.Range(0, vowels.Count);
            AddLetter(vowels[r]);
            vowels.RemoveAt(r);
        }
    }

    public void AddConsonant()
    {
        if (consonantCount < 6)
        {
            consonantCount++;
            int r = Random.Range(0, consonants.Count);
            AddLetter(consonants[r]);
            consonants.RemoveAt(r);
        }
    }

    void AddLetter(char letter)
    {
        if (index < 9)
        {
            Text text = transform.GetChild(index).GetComponentInChildren<Text>();
            if (text != null)
            {
                text.text = letter.ToString();
            }
            index++;
        }
    }
}
