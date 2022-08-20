using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class HUDManager : MonoBehaviour
{
    public int lives;
    public TextMeshProUGUI livesText;


    // Start is called before the first frame update
    void Start()
    {
        livesText.text = "Lives: " + lives;
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void LoseLife()
    {
        lives -= 1;
        livesText.text = "Lives: " + lives;
        if (lives <= 0)
        {
            SceneManager.LoadScene("Level 1");
        }
    }

}
