using UnityEngine;
using UnityEngine.SceneManagement;

public class Brick : MonoBehaviour
{
    static int remainingBricks;

    private void Awake()
    {
        remainingBricks++;
        Debug.Log(remainingBricks);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
        remainingBricks--;
        Debug.Log(remainingBricks);

        if (remainingBricks == 0)
        {
            SceneManager.LoadScene(0);
        }
    }

}
