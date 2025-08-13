using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class ShowTitle : MonoBehaviour
{

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y <= 0)
            {
            transform.position += new Vector3(0, 0.02f, 0);
        }

        if (Input.anyKeyDown)
        {
            SceneManager.LoadScene("Level1");
        }
    }
}
