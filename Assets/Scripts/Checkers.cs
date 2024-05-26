using UnityEngine;
using UnityEngine.PlayerLoop;

public class Checkers : MonoBehaviour
{
    [SerializeField] private float power = 10f;
    [SerializeField] private Rigidbody2D rb;

    [SerializeField] private Vector2 minPower;
    [SerializeField] private Vector2 maxPower;

    private Camera cam;
    private Vector2 force;
    private Vector3 startPoint;
    private Vector3 endPoint;

    private void Start()
    {
        cam = Camera.main;
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            print("sdsd");
        }
    }

}
