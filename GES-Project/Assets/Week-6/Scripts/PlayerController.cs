using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Week6
{
    public class PlayerController : MonoBehaviour
    {
        [SerializeField] float speed; 
        public InputAction move;

        private void OnEnable()
        {
            move.Enable();    
        }

        private void OnDisable()
        {
            move.Disable();    
        }

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            Vector2 input = move.ReadValue<Vector2>();
            

            float x = (input.x * speed) + transform.position.x;
            float y = transform.position.y;
            float z = (input.y * speed) + transform.position.z;

            transform.position = new Vector3(x,y,z);
        }
    }
}
