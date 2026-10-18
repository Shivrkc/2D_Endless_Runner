using UnityEngine;

public class VirusMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float leftLimit = -12f;

    void Update()
    {
        transform.Translate(
            Vector2.left * moveSpeed * Time.deltaTime
        );

        if (transform.position.x < leftLimit)
        {
            Destroy(gameObject);
        }
    }
}