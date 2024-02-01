using UnityEngine;

[RequireComponent(typeof(BallMovement))]
public class BallMovement : MonoBehaviour
{
    [Header("Fall")]
    [SerializeField] private float fallHeight;
    [SerializeField] private float fallSpeedDefault;
    [SerializeField] private float fallSpeedMax;
    [SerializeField] private float fallSpeedAcceleration;

    private Animator animator;

    private float fallSpeed;
    private float floorY;

    private void Start()
    {
        enabled = false;

        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        if (transform.position.y > floorY)
        {
            // -=������� �������=-

            // ������� 1:
            // transform.Translate(0, -fallSpeed * Time.deltaTime, 0);

            // ������� 2:
            // transform.position += Vector3.down * fallSpeed * Time.deltaTime);

            transform.Translate(0, -fallSpeed * Time.deltaTime, 0);

            if (fallSpeed < fallSpeedMax)
            {
                fallSpeed += fallSpeedAcceleration * Time.deltaTime;
            }
        }
        else
        {
            transform.position = new Vector3(transform.position.x, floorY, transform.position.z);
            enabled = false;
        }
    }

    public void Jump()
    {
        animator.speed = 1;
        fallSpeed = fallSpeedDefault;
    }

    public void Fall(float startFloorY)
    {
        animator.speed = 0;
        enabled = true;
        floorY = startFloorY - fallHeight;
    }

    public void Stop()
    {
        animator.speed = 0;
    }
}
