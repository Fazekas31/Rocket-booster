using UnityEngine;
using UnityEngine.InputSystem;

public class Movement : MonoBehaviour
{
    [SerializeField] InputActions thruster;

    private void OnEnable()
    {
        thruster.Enable();
    }
}
