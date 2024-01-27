using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLook : MonoBehaviour
{
    [SerializeField] private Transform playerCamera;
    [SerializeField] private bool lockCursor = true;
    [SerializeField] private float mouseSensitivityX = 35f;
    [SerializeField] private float mouseSensitivityY = 25f;

    public bool canLook;

    private float _cameraPitch;
    private InputActionsController _input;
    // Start is called before the first frame update
    void Start()
    {
        _input = GetComponent<InputActionsController>();
        canLook = true;
        if (lockCursor)
        {
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (!canLook) return;
        
        _cameraPitch -= _input.LookVector.y * mouseSensitivityY * Time.deltaTime;
        _cameraPitch = Mathf.Clamp(_cameraPitch, -90, 90);
        playerCamera.localEulerAngles = Vector3.right * _cameraPitch;
        transform.Rotate(Vector3.up * (_input.LookVector.x * mouseSensitivityX * Time.deltaTime));
    }
}
