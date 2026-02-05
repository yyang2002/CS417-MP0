using UnityEngine;
using UnityEngine.InputSystem;

public class BreakOut : MonoBehaviour
{
    public Transform player;
    public Transform externalPoint;
    public InputActionReference action;

    public Vector3 playerPosition;
    private bool isOutside = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerPosition = player.position;
        action.action.Enable();
        action.action.performed += (ctx) =>
        {
            if (isOutside)
            {
                player.position = playerPosition;
            }
            else
            {
                player.position = externalPoint.position;
            }

            isOutside = !isOutside;
        };
    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.tabKey.wasPressedThisFrame) 
        {
            player.position = isOutside ? playerPosition : externalPoint.position;
            isOutside = !isOutside;
        }
    }
}
