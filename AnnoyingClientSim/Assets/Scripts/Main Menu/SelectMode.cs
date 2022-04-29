using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class SelectMode : MonoBehaviour
{
    public Flowchart mainFlowchart;

    public void Casual()
    {
        Debug.Log("is this working");
        mainFlowchart.ExecuteBlock("Casual");
    }

    public void TryHard()
    {
        mainFlowchart.ExecuteBlock("TryHard");
    }

    public void Custom()
    {
        mainFlowchart.ExecuteBlock("Custom");
    }

    public void Back()
    {
        mainFlowchart.ExecuteBlock("Back");
    }

    public void StartCasual()
    {
        mainFlowchart.ExecuteBlock("StartCasual");
    }
}
