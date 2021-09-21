using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerController : MonoBehaviour
{
    public Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetTouch(0).phase==TouchPhase.Began) {
            anim.SetBool("pass", true);
        }
        else
        {
            anim.SetBool("pass", false);
        }
    }
}
