using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Paging : MonoBehaviour
{
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
        if (currentPage == 1)
        {
            objs[0].enabled = false;
        }
        else if (currentPage == 3)
        {
            objs[2].enabled = false;
        }

        if (currentPage == 2)
        {
            objs[0].enabled = true;
            objs[2].enabled = true;
        }

        objs[1].text = currentPage + "/3";
    }

    public void PageNext()
    {
        if (currentPage < 3)
        {
            currentPage++;

        }
    }

    public void PagePrevious()
    {
        if (currentPage > 1)
        {
            currentPage--;

        }
    }
}
