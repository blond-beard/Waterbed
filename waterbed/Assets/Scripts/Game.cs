using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Scripts.Controller;


namespace Scripts
{
    public class Game : MonoBehaviour
    {
        [SerializeField] public GameObject SkillWindow;

        private void Start()
        {
            
        }

        private void OpenClose() {
            SkillWindow.SetActive(!SkillWindow.activeSelf);
        }
 
        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.M))
            {
                OpenClose();
            } 
        }
    }
}
