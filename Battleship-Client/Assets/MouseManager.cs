using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

namespace BattleshipGame
{
    public class MouseManager : MonoBehaviour
    {
        GameObject cursor;
        bool active;
        // Start is called before the first frame update
        void Start()
        {
           cursor = GameObject.Find("Cursor");
            active = true;
        }

        // Update is called once per frame
        void Update()
        {
            checkGamepad();
            
        }
        
        public void checkGamepad()
        {
            var gamepad = Gamepad.current;

            if (gamepad != null && !active)
            {
                cursor.SetActive(true);
                active = true;
                Debug.Log("Gamepad on");
            }
            else if (gamepad == null && active)
            {
                Debug.Log("Gamepad off before");
                cursor.SetActive(false);
                active = false;
                Debug.Log("Gamepad off");
            }
                
            
        }
    }
}
