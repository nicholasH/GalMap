using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera_movements : MonoBehaviour
{
    public float base_speed;
    public float sensitivity = 2000f;
    public float minZoom = 100f;
    public float maxZoom = 1500f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        updateKeyBoardMovement();
        updateMouseMovement();

    }

    private void updateKeyBoardMovement()
    {
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            transform.Translate(new Vector3(base_speed * Time.deltaTime, 0, 0));
        }
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            transform.Translate(new Vector3(-base_speed * Time.deltaTime, 0, 0));
        }
        if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
        {
            transform.Translate(new Vector3(0, -base_speed * Time.deltaTime, 0));
        }
        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
        {
            transform.Translate(new Vector3(0, base_speed * Time.deltaTime, 0));
        }
    }

    private void updateMouseMovement()
    {
        float ScrollWheelChange = Input.GetAxis("Mouse ScrollWheel");

        if (ScrollWheelChange > 0)
        {
            Camera.main.orthographicSize =  Mathf.MoveTowards(Camera.main.orthographicSize, minZoom, sensitivity * Time.deltaTime);
        }
        else if(ScrollWheelChange < 0)
        {
            Camera.main.orthographicSize = Mathf.MoveTowards(Camera.main.orthographicSize, maxZoom, sensitivity * Time.deltaTime);
        }
    }
}
