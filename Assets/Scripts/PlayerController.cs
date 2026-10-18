using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float minY = -3.5f;
    public float maxY = 3.5f;

    public static bool gameOver = false;

    void Update()
    {
        if (gameOver)
            return;

        float vertical = 0f;

        if (Input.GetKey(KeyCode.UpArrow) ||
            Input.GetKey(KeyCode.W))
        {
            vertical = 1f;
        }
        else if (Input.GetKey(KeyCode.DownArrow) ||
                 Input.GetKey(KeyCode.S))
        {
            vertical = -1f;
        }

        Vector3 movement = Vector3.up * vertical *
                           moveSpeed * Time.deltaTime;

        transform.Translate(movement);

        Vector3 position = transform.position;
        position.y = Mathf.Clamp(position.y, minY, maxY);
        transform.position = position;
    }
}