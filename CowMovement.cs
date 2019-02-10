using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CowMovement : MonoBehaviour
{
    public float horizontalSpeed = 5f;//moveSpeed
    public float frequency = 20f;
    //public float verticalSpeed;
    public float amplitude = 0.5f; //magnitude
    public Vector3 pos, localScale;
    bool facingRight = true;
    bool facingFront = true;

    // Start is called before the first frame update
    void Start()
    {
        pos = transform.position;
        localScale = transform.localScale;
    }

    // Update is called once per frame
    void Update()
    {

        CheckWhereToFace();

        if (facingRight)
            MoveRight();
        else
            MoveLeft();

        if (facingFront)
            MoveForward();
        else
            MoveBack();

        //tempPosition.x += horizontalSpeed;
        //tempPosition.y = Mathf.Sin(Time.realtimeSinceStartup * verticalSpeed) * amplitude;
    }

    void CheckWhereToFace()
    {
        if (pos.x < -7f)
            facingRight = true;
        else if (pos.x > 7f)
            facingRight = false;

        if (pos.z < -7f)
            facingFront = true;
        else if (pos.z > 7f)
            facingFront = false;

        if (((facingRight) && (localScale.x < 0)) || ((!facingRight) && (localScale.x > 0)))
            localScale.x *= -1;

        transform.localScale = localScale;
    }

    void MoveRight()
    {
        pos += transform.right * Time.deltaTime * horizontalSpeed;
        transform.position = pos;

    }

    void MoveLeft()
    {
        pos -= transform.right * Time.deltaTime * horizontalSpeed;
        transform.position = pos;
    }
        void MoveBack()
        {
            pos += Vector3.back * Time.deltaTime * horizontalSpeed;
            transform.position = pos;
        }


        void MoveForward()
        {
            pos -= Vector3.back * Time.deltaTime * horizontalSpeed;
            transform.position = pos;
        }

}
