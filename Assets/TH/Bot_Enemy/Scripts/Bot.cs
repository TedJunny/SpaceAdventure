using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bot : MonoBehaviour
{
    public Animator anim;
    public float rb_range;
    public float speed = 10;
    public GameObject shootExpFactory;
    public GameObject dieExpFactory;
    public Transform firePosition;
    GameObject exp;

    public AudioSource shootAudio;
    // public AudioSource manAudio;
    public AudioSource expAudio;

    float currentT;
    public float createT = 1;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        shootAudio = GetComponent<AudioSource>();
        // manAudio = GetComponent<AudioSource>();
        // expAudio = GetComponent<AudioSource>();
    }

    bool isSoundPlay = false;
    // Update is called once per frame
    void Update()
    {
        GameObject target = GameObject.Find("Rock");
        Vector3 RockPoint = target.transform.position;
        Vector3 BotPoint = transform.position;

        float distance = Vector3.Distance(BotPoint, RockPoint);

        if (distance < rb_range)
        {
            currentT += Time.deltaTime;

            Vector3 relativePos = target.transform.position - transform.position;
            Quaternion targetRotation = Quaternion.LookRotation(relativePos);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, targetRotation, Time.deltaTime * speed);

            anim.SetBool("Shoot", true);
            // manAudio.Play();

            if (currentT > createT)
            {
                print("1111111111111111111111111111111111111111");
                if (shootAudio.isPlaying == false)
                {
                    shootAudio.Play();
                }
                exp = Instantiate(shootExpFactory);
                exp.transform.position = firePosition.position;
                Destroy(exp, 0.2f);
                isSoundPlay = true;
            }

        }
        //GameObject GameOverUI = GameObject.Find("GameOverUI");
        //if (GameOverUI == true)
        //{
        //    Destroy(shootAudio);
        //    Destroy(manAudio);
        //}
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name.Contains("Rock"))
        {
            speed = 0;
            if (shootAudio.isPlaying == false)
            {
                expAudio.Play();
            }
            isSoundPlay = true;
            anim.SetBool("Die", true);
            
            Destroy(exp);
            // exp.SetActive(false);
            Destroy(shootAudio);
            // Destroy(manAudio);

            GameObject exp2 = Instantiate(dieExpFactory);
            exp2.transform.position = transform.position;

        }

    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.name.Contains("Rock"))
        {
            exp.SetActive(false);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name.Contains("Rock"))
        {
            exp.SetActive(false);

            Destroy(gameObject, 2);

        }
    }

}
