using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Numbers : MonoBehaviour
{
    public Text target;
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

        for (int i = 1; i <= 10; ++i)
        {
            AddToList(smallNumbers, i, 2);
        }
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

        if (index == 6)
        {
            StartCoroutine(RandomTarget());
        }
    }

    IEnumerator RandomTarget()
    {
        for (int i = 0; i < 100; ++i)
        {
            target.text = Random.Range(100, 1000).ToString();
            yield return null;
        }
    }
}
