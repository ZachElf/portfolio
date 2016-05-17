using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Paging : MonoBehaviour
{
    public Text[] textArray;

    // Prev button - 0, Page number section - 1, Next button - 2
    private Text[] objs;
    private int currentPage = 1;

    // Use this for initialization
    void Start()
    {
        objs = GetComponentsInChildren<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        objs[1].text = currentPage + "/" + textArray.Length;
    }

    public void PageNext()
    {
        if (currentPage < textArray.Length)
        {
            textArray[currentPage - 1].enabled = false;
            textArray[currentPage].enabled = true;
            currentPage++;

            //objs[2].enabled = true;

            //// If there is no more next page, the next button disappears
            //if (currentPage == textArray.Length)
            //    objs[2].enabled = false;
        }
    }

    public void PagePrevious()
    {
        if (currentPage > 1)
        {
            textArray[currentPage - 1].enabled = false;
            textArray[currentPage - 2].enabled = true;
            currentPage--;

            //objs[0].enabled = true;

            //// If there is no more next page, the next button disappears
            //if (currentPage == textArray.Length)
            //    objs[0].enabled = false;
        }
    }
}
