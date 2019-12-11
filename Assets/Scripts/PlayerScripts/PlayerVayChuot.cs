using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerVayChuot : MonoBehaviour
{

    [SerializeField]
    private Transform playerObject, lookObject;

    [SerializeField]
    private float sensivity = 5f;
    
    private Vector2 default_Look_Limits = new Vector2(-70f, 80f);

    private Vector2 look_Angles;

    private Vector2 currentMouse;
    private Vector2 smooth_Move;

    private float current_Roll_Angle;

    private int last_Look_Frame;

    // Use this for initialization
    void Start()
    {
        // 
        Cursor.lockState = CursorLockMode.Locked;

    }

    // Update is called once per frame
    void Update()
    {
        LockAndUnlockCursor();
        if (Cursor.lockState == CursorLockMode.Locked)
        {
            LookAround();
        }
    }

    void LockAndUnlockCursor()
    {

        if (Input.GetKeyDown(KeyCode.Escape))
        {

            if (Cursor.lockState == CursorLockMode.Locked)
            {
                Cursor.lockState = CursorLockMode.None;
            }
            else
            {
                Cursor.lockState = CursorLockMode.Locked;
                Cursor.visible = false;
            }

        }

    }

    void LookAround()
    {

        currentMouse = new Vector2(
            Input.GetAxis(MouseAxis.MOUSE_Y), Input.GetAxis(MouseAxis.MOUSE_X));
        look_Angles.x -= currentMouse.x * sensivity;
        look_Angles.y += currentMouse.y * sensivity;
        look_Angles.x = Mathf.Clamp(look_Angles.x, default_Look_Limits.x, default_Look_Limits.y);

        lookObject.localRotation = Quaternion.Euler(look_Angles.x, 0f, 0f);
        playerObject.localRotation = Quaternion.Euler(0f, look_Angles.y, 0f);


    }


}













































