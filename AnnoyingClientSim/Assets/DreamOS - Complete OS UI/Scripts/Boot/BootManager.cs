using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using TMPro;

namespace Michsky.DreamOS
{
    public class BootManager : MonoBehaviour
    {
        // Events
        public UnityEvent onBootStart;
        public UnityEvent eventsAfterBoot;


        // Resources
        public Animator bootAnimator;
        public TextMeshProUGUI bootingTextObject;

        // Settings
        public float bootTime = 3f;
        public string bootingText = "Booting Up";

        //public GameObject loadingScreen;
        //public GameObject chooseSetting;
        //public int mouseClickCount = 0;

        void Start()
        {
            StartCoroutine("BootEventStart");
        }

        private void Update()
        {
            /*if(Input.GetKeyDown(KeyCode.Mouse0))
            {
                mouseClickCount++;
            }
            
            if (bootAnimator.gameObject.activeSelf == true && mouseClickCount == 1)
            {
                loadingScreen.SetActive(false);
                chooseSetting.SetActive(true);

                if(mouseClickCount == 2)
                {
                    bootAnimator.Play("Boot Out");
                    StopCoroutine("BootEventStart");
                    eventsAfterBoot.Invoke();
                    
                }
                */
            if (bootAnimator.gameObject.activeSelf == Input.GetKeyDown(KeyCode.Mouse0))
            {
                bootAnimator.Play("Boot Out");
                StopCoroutine("BootEventStart");
                eventsAfterBoot.Invoke();
            }


                //bootAnimator.Play("Boot Out");
                //StopCoroutine("BootEventStart");
                //eventsAfterBoot.Invoke();
        }
            

        public void InvokeEvents()
        {
            bootAnimator.gameObject.SetActive(true);
            bootAnimator.Play("Boot Start");
            StartCoroutine("BootEventStart");
        }

        public void UpdateUI()
        {
            if (bootingTextObject != null)
                bootingTextObject.text = bootingText;
        }

        IEnumerator BootEventStart()
        {
            yield return new WaitForSeconds(bootTime);

            if (bootAnimator.gameObject.activeSelf == true)
            {
                    //bootAnimator.Play("Boot Out");
            } 
            
        }
    }
}