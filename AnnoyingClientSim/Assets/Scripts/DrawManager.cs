using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawManager : MonoBehaviour
{
    private Camera _cam;
    [SerializeField] private DrawLine _linePrefab;

    public const float RESOLUTION = 0.01f;

    private DrawLine _currentLine;

    void Start()
    {
        _cam = Camera.main;
    }


    void Update()
    {
        //Debug.Log("Mouse is over GameObject.");

        Vector2 mousePos = _cam.ScreenToWorldPoint(Input.mousePosition);

        if (Input.GetMouseButtonDown(0))
        {
            _currentLine = Instantiate(_linePrefab, mousePos, Quaternion.identity);
        }

        if (Input.GetMouseButton(0))
        {
            _currentLine.SetPosition(mousePos);

           
        }

        if (Input.GetKeyDown("space"))
        {
        }
    }

}

