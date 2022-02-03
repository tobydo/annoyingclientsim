using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MouseOverSpriteAppear : MonoBehaviour
{
    public GameObject spriteAppear;

    private void OnMouseOver()
    {
        Debug.Log("mouse over works");
         spriteAppear.SetActive(true);
    }

    private void OnMouseExit()
    {
        spriteAppear.SetActive(false);
    }

}
