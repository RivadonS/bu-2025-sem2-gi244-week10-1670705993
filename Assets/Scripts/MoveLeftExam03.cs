using UnityEngine;

public class MoveLeftExam03 : MonoBehaviour
{
    public float speed = 10f;

    private float leftBound = -15;

    private PlayerControllerExam03 playerController;

    void Start()
    {
        playerController = GameObject.Find("Player").GetComponent<PlayerControllerExam03>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!playerController.gameOver)
        {
            if (playerController.isDashing)
            {
                transform.Translate(Vector3.left * Time.deltaTime * (speed * 2));
            }
            else
            {
                transform.Translate(Vector3.left * Time.deltaTime * speed);
            }

        }

        if (transform.position.x < leftBound && gameObject.CompareTag("Obstacle"))
        {
            Destroy(gameObject);
        }
    }
}
