using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class ClickToStart : MonoBehaviour
{
    public Flowchart mainFlowchart;
    public bool selectMode;

    // Update is called once per frame
    private void Update()
    {
        if(selectMode == false && Input.GetMouseButtonDown(0))
        {
            selectMode = true;
            CallFungusBlock();
        }
    }

    private void CallFungusBlock()
    {
        if(selectMode == true)
        {
            Debug.Log("why won't you work");
            mainFlowchart.ExecuteBlock("Difficulty");
        }

    }
}
