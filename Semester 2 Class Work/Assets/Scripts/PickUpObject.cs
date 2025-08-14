using UnityEngine;

public class PickUpObject : MonoBehaviour
{
    private RigidBody rb;

    void Awake()
    {
        rb = GetComponent<RigidBody>;
    }

    public void PickUp(Transform holdPoint)
    {
        rb.UseGravity = false;
        rb.linearVelocity = Vector3.zero;
        rb.angularVelocity = Vector3.zero;

        transform.SetParent(holdPoint);
        transform.localPosition = Vector3.zero;
    }

    public void Drop()
    {
        rb.useGravity = true;
        transform.SetParent(null);
    }
    
    public void MoveToHoldPoint(Vector3 targetPosition)
    {
        rb.MovePosition(targetPosition);
    }
}
