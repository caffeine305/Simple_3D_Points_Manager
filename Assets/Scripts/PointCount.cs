using UnityEngine;

public class PointCount : MonoBehaviour
{
    private int collisionPoints = 0;
    public PointsManager pointsManager;

    private void Start()
    {
        GameObject PointsMaganerLoaderobject = GameObject.FindWithTag("ScoreManagerInside");
        if(PointsMaganerLoaderobject !=  null)
        {
            pointsManager = PointsMaganerLoaderobject.GetComponent<PointsManager>();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
       
        if (other.CompareTag("Player"))
        {
            // Increase collision point count
            collisionPoints++;

            // Print the collision point count
            Debug.Log("Collision Points: " + collisionPoints);

            pointsManager.UpdatePoints(collisionPoints);
            Destroy(this.gameObject);
        }

        if (other.CompareTag("Ground"))
        {
            // Stop collectible's movement
            Rigidbody rb = GetComponent<Rigidbody>();
            rb.velocity = Vector3.zero;
            rb.angularVelocity = Vector3.zero;

            // Optionally, you can disable the Rigidbody to prevent further movement
            rb.isKinematic = true;
        }
    } 

}
