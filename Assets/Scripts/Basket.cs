using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Basket : MonoBehaviour
{
    [Header("Set Dynamically")]
    public Text scoreText;

    // Start is called before the first frame update
    void Start()
    {
        GameObject scoreObject = GameObject.Find("ScoreCounter");
        scoreText = scoreObject.GetComponent<Text>();
        scoreText.text = "0";
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mousePos2D = Input.mousePosition;
        mousePos2D.z = -Camera.main.transform.position.z;
        Vector3 mousePos3D = Camera.main.ScreenToWorldPoint(mousePos2D);
        Vector3 pos = transform.position;
        pos.x = mousePos3D.x;
        transform.position = pos;
    }

    private void OnCollisionEnter(Collision collision)
    {
        GameObject collidedWith = collision.gameObject;
        if(collidedWith.tag == "Apple") Destroy(collidedWith);

        int score = int.Parse(scoreText.text) + 1;
        scoreText.text = score.ToString();
    }
}
