using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToolbarScript : MonoBehaviour
{
    public GameObject pencilText;

    public GameObject eraserText;

    public void PencilChange()
    {
        pencilText.SetActive(true);
        eraserText.SetActive(false);

    }

    public void EraserChange()
    {
        pencilText.SetActive(false);
        eraserText.SetActive(true);
    }
}
