using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Scripts.Controller;


namespace Scripts
{
    public class PlayerController : MonoBehaviour
    {
        [Header("Property")]
        public Controller2D controller2d;

        [Header("Value")]
        [SerializeField] public int MaxHealth = 100;
        [SerializeField] public int MP = 100;

        public int CurrentHealth { get; private set; }
        public bool IsDead { get { return this.CurrentHealth <= 0; } }

        private float horizontal;

        private void Start()
        {
            this.CurrentHealth = this.MaxHealth;
        }

        private void Update()
        {
            if (IsDead)
            {
                return;
            }

            horizontal = Input.GetAxisRaw("Horizontal");
            controller2d.Move(horizontal);
        }

        private void FixedUpdate() {
            controller2d.Move(horizontal);
        }
    }
}
