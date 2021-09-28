using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OpponentController : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private GameObject gameover;
    [SerializeField] Transform[] wayPoints;

    private Rigidbody2D rigidbody;
    private int currentPoint;
    private float t;
    private float step;

    private void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        Movement();
        t += Time.fixedDeltaTime;
        step = t * speed;
    }

    private void Movement()
    {
        transform.position = Vector3.MoveTowards(transform.position, wayPoints[currentPoint].position, step);
        rigidbody.MovePosition(transform.position);

        if(transform.position == wayPoints[currentPoint].position)
        {
            currentPoint++;
            t = 0f;
        }
        
        if(transform.position == wayPoints[35].position)
        {
            currentPoint = 1;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name == "Player")
        {
            Destroy(collision.gameObject);
            StartCoroutine(GameOver());
            StartCoroutine(Restart());
        }
    }

    IEnumerator GameOver()
    {
        while(true)
        {
            gameover.SetActive(true);
            yield return new WaitForSeconds(0.3f);
            gameover.SetActive(false);
            yield return new WaitForSeconds(0.3f);
        }
    }

    IEnumerator Restart()
    {
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene("SampleScene", LoadSceneMode.Single);
    }
}
