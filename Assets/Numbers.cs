using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Numbers : MonoBehaviour {

    List<int> bigNumbers = new List<int>();
    List<int> smallNumbers = new List<int>();
    int index = 0;
    int bigCount = 0;
    int smallNumber = 0;

    void Start()
    {
        AddToList(bigNumbers, 25, 1);
        AddToList(bigNumbers, 50, 1);
        AddToList(bigNumbers, 75, 1);
        AddToList(bigNumbers, 100, 1);

        AddToList(smallNumbers, 1, 1);
        AddToList(smallNumbers, 2, 1);
        AddToList(smallNumbers, 3, 1);
        AddToList(smallNumbers, 4, 1);
        AddToList(smallNumbers, 5, 1);
        AddToList(smallNumbers, 6, 1);
        AddToList(smallNumbers, 7, 1);
        AddToList(smallNumbers, 8, 1);
        AddToList(smallNumbers, 9, 1);
        AddToList(smallNumbers, 10, 1);
    }

    void AddToList(List<int> list, int number, int frequency)
    {
        for (int i = 0; i < frequency; ++i)
        {
            list.Add(number);
        }
    }

    public void AddBigNumber()
    {
        if (bigCount < 4)
        {
            bigCount++;
            int r = Random.Range(0, bigNumbers.Count);
            AddNumber(bigNumbers[r]);
            bigNumbers.RemoveAt(r);
        }
    }

    public void AddSmallNumber()
    {
        if (smallNumber < 6)
        {
            smallNumber++;
            int r = Random.Range(0, smallNumbers.Count);
            AddNumber(smallNumbers[r]);
            smallNumbers.RemoveAt(r);
        }
    }

    void AddNumber(int number)
    {
        if (index < 6)
        {
            Text text = transform.GetChild(index).GetComponentInChildren<Text>();
            if (text != null)
            {
                text.text = number.ToString();
            }
            index++;
        }
    }
}
