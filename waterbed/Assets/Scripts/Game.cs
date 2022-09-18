using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Scripts.Controller;


namespace Scripts
{
    public class Game : MonoBehaviour
    {
        [SerializeField] public GameObject SkillWindow;
        [SerializeField] public GameObject MapWindow;

        private void Start()
        {

        }

        private void toggleWindow(GameObject window)
        {
            window.SetActive(!window.activeSelf);
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.K))
            {
                this.toggleWindow(this.SkillWindow);
            }
            else if (Input.GetKeyDown(KeyCode.M))
            {
                this.toggleWindow(this.MapWindow);
            }
        }
    }
}
