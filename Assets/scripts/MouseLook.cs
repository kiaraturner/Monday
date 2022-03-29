using UnityEngine;

public class MouseLook : MonoBehaviour
{
    public float sensitivity = 2.5f; // mouse sensitive
    public float drag = 1.5f; // continued mouse movement whatever the fuck idk bro

    private Transform character;
    private Vector2 mouseDirection; // curser cor5ds
    private Vector2 smoothing; // smoothed cursor movement
    private Vector2 result; // ressultion cursor posiiton

    private void Awake()
    {
        character = transform.parent; // refs to parent control
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }


    // Update is called once per frame
    void Update()
    {
        mouseDirection = new Vector2(Input.GetAxisRaw("Mouse X") * sensitivity, Input.GetAxisRaw("Mouse Y") * sensitivity);
        smoothing = Vector2.Lerp(smoothing, mouseDirection, 1 / drag);
        result += smoothing;
        result.y = Mathf.Clamp(result.y, -70, 80);

        transform.localRotation = Quaternion.AngleAxis(-result.y, Vector3.right);
        character.rotation = Quaternion.AngleAxis(result.x, character.up);
    }
}
