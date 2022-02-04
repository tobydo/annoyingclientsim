using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderScript : MonoBehaviour
{
    [SerializeField] private Slider slider;
    [SerializeField] public LineRenderer lr;

    // Start is called before the first frame update
    void Start()
    {
        slider.onValueChanged.AddListener((v) =>
        {
            lr.startWidth = v;
            lr.endWidth = v;
        });
    }

    // Update is called once per frame
    void Update()
    {


    }

}
