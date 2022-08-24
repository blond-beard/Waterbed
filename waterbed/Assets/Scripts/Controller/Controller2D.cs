using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Scripts.Controller
{
    [RequireComponent(typeof(Animator))]
    [RequireComponent(typeof(Rigidbody2D))]
    public class Controller2D : MonoBehaviour
    {
        [Header("Value")]
        [SerializeField] public float WalkSpeed = 10f;

        // public Animator animator;
        public Rigidbody2D rigidBody;
        public SpriteRenderer spriteRenderer;

        private bool facingRight = true;

        private void Start()
        {
            // this.animator = this.GetComponent<Animator>();
            this.spriteRenderer = GetComponent<SpriteRenderer>();

        }

        public void Move(float horizontal) {
            float move = horizontal * WalkSpeed;

            this.rigidBody.velocity = new Vector2(horizontal * this.WalkSpeed * Time.deltaTime, this.rigidBody.velocity.y);

            if (move > 0 && !facingRight)
			{
				Flip();
			}
			else if (move < 0 && facingRight)
			{
				Flip();
			}
        }

        public void Flip()
        {
            Vector3 scale = this.transform.localScale;
            scale.x *= -1;

            this.transform.localScale = scale;
            this.facingRight = !facingRight;
        }
    }
}