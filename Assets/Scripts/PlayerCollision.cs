using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public GameObject gameOverImage;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Virus"))
        {
            PlayerController.gameOver = true;

            if (gameOverImage != null)
            {
                gameOverImage.SetActive(true);
            }

            Debug.Log("GAME OVER!");
        }
    }
}