using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;
public class Player : MonoBehaviour
{
    [SerializeField] float TimeLerp;
    [SerializeField] float x, z;
    bool Finish = false;
    bool outSide = false;
    bool AllowMove;
    [SerializeField] int moved = 0;

    public GameObject LoseMenu;
    public GameObject MainUi;
    public GameObject WinMenu;

    public GameObject KeyObject, CashdeskObject;

    bool Cashdesk = false;
    bool Key = false;

    public bool ThisKey;

    public AudioSource audioSource;
    public AudioClip MoveAudio;
    public AudioClip Victory;
    public AudioClip Death;
    public AudioClip keySound;
    public AudioClip LockSound;

    private void Start()
    {
        AllowMove = true;
    }
    public void RightRightUp(int number)
    {
        if (AllowMove)
        {
            StartCoroutine(rightRightUp(number));
        }
    }
    IEnumerator rightRightUp(int number)
    {
        AllowMove = false;
        moved = 0;
        bool wait = false;
        bool rightBool = false;
        bool rightTwoRight = false;
        while (moved < number)
        {
            if (wait == false)
            {
                if (outSide == true)
                {
                    break;
                }
                if (rightBool == false)
                {
                    StartCoroutine(right(TimeLerp, new Vector3(transform.position.x + 1, transform.position.y, transform.position.z)));
                    rightBool = true;

                }
                else if (rightTwoRight == false)
                {
                    StartCoroutine(right(TimeLerp, new Vector3(transform.position.x + 1, transform.position.y, transform.position.z)));
                    rightTwoRight = true;
                }
                else
                {
                    StartCoroutine(up(TimeLerp, new Vector3(transform.position.x, transform.position.y, transform.position.z + 1)));
                }
                wait = true;
            }
            if (Finish)
            {
                moved++;
                wait = false;
                Finish = false;
            }
            yield return null;
        }
        AllowMove = true;
    }
    public void RightDownDown(int number)
    {
        if (AllowMove)
        {
            StartCoroutine(rightDownDown(number));
        }
    }
    IEnumerator rightDownDown(int number)
    {
        AllowMove = false;
        moved = 0;
        bool wait = false;
        bool rightBool = false;
        bool rightDownDow = false;
        while (moved < number)
        {
            if (outSide == true)
            {
                break;
            }
            if (wait == false)
            {
                if (rightBool == false)
                {
                    StartCoroutine(right(TimeLerp, new Vector3(transform.position.x + 1, transform.position.y, transform.position.z)));
                    rightBool = true;
                }
                else if (rightDownDow == false)
                {
                    StartCoroutine(down(TimeLerp, new Vector3(transform.position.x, transform.position.y, transform.position.z - 1)));
                    rightDownDow = true;
                }
                else
                {
                    StartCoroutine(down(TimeLerp, new Vector3(transform.position.x, transform.position.y, transform.position.z - 1)));
                }
                wait = true;
            }
            if (Finish)
            {
                moved++;
                wait = false;
                Finish = false;
            }
            yield return null;
        }
        AllowMove = true;
    }
    public void RightDown(int number)
    {
        if (AllowMove)
        {
            StartCoroutine(rightDown(number));
        }
    }
    IEnumerator rightDown(int number)
    {
        AllowMove = false;
        moved = 0;
        bool wait = false;
        bool rightBool = false;
        while (moved < number)
        {
            if (outSide == true)
            {
                break;
            }
            if (wait == false)
            {
                if (rightBool == false)
                {
                    StartCoroutine(right(TimeLerp, new Vector3(transform.position.x + 1, transform.position.y, transform.position.z)));

                }
                else
                {
                    StartCoroutine(down(TimeLerp, new Vector3(transform.position.x, transform.position.y, transform.position.z - 1)));
                }
                rightBool = true;
                wait = true;
            }
            if (Finish)
            {
                moved++;
                wait = false;
                Finish = false;
            }
            yield return null;
        }
        AllowMove = true;
    }
    public void RightNumber(int RightNumber)
    {
        if (AllowMove)
        {
            StartCoroutine(Right(RightNumber));
        }
    }
    public void LeftNumber(int LeftNumber)
    {
        if (AllowMove)
        {
            StartCoroutine(Left(LeftNumber));
        }
    }
    public void UpNumber(int UpNumber)
    {
        if (AllowMove)
        {
            StartCoroutine(Up(UpNumber));
        }
    }
    public void DownNumber(int DownNumber)
    {
        if (AllowMove)
        {
            StartCoroutine(Down(DownNumber));
        }
    }

    IEnumerator Right(int number)
    {
        AllowMove = false;
        moved = 0;
        bool wait = false;
        while (moved < number)
        {
            if (wait == false)
            {
                StartCoroutine(right(TimeLerp, new Vector3(transform.position.x + 1, transform.position.y, transform.position.z)));
                wait = true;
            }
            if (Finish)
            {
                moved++;
                wait = false;
                Finish = false;
            }
            yield return null;
        }
        AllowMove = true;
    }
    IEnumerator Left(int number)
    {
        AllowMove = false;
        moved = 0;
        bool wait = false;
        while (moved < number)
        {
            if (wait == false)
            {
                StartCoroutine(left(TimeLerp, new Vector3(transform.position.x - 1, transform.position.y, transform.position.z)));
                wait = true;
            }
            if (Finish)
            {
                moved++;
                wait = false;
                Finish = false;
            }
            yield return null;
        }
        AllowMove = true;
    }

    IEnumerator Up(int number)
    {
        AllowMove = false;
        moved = 0;
        bool wait = false;
        while (moved < number)
        {
            if (wait == false)
            {
                StartCoroutine(up(TimeLerp, new Vector3(transform.position.x, transform.position.y, transform.position.z + 1)));
                wait = true;
            }
            if (Finish)
            {
                moved++;
                wait = false;
                Finish = false;
            }
            yield return null;
        }
        AllowMove = true;
    }
    IEnumerator Down(int number)
    {

        AllowMove = false;
        moved = 0;
        bool wait = false;
        while (moved < number)
        {
            if (outSide == true)
            {
                break;
            }
            if (wait == false)
            {
                StartCoroutine(down(TimeLerp, new Vector3(transform.position.x, transform.position.y, transform.position.z - 1)));
                wait = true;
            }
            if (Finish)
            {
                moved++;
                wait = false;
                Finish = false;
            }

            yield return null;
        }
        AllowMove = true;
    }
    IEnumerator right(float timeLerp, Vector3 TargetPos)
    {
        float time = 0;
        audioSource.PlayOneShot(MoveAudio);
        Vector3 StartPos = transform.position;
        while (time < timeLerp)
        {
            transform.position = Vector3.Lerp(StartPos, TargetPos, time / timeLerp);
            time += Time.deltaTime;
            if (outSide == true)
            {
                break;
            }
            yield return null;
        }
        Finish = true;
        if (outSide == false)
        {
            transform.position = TargetPos;
        }
    }
    IEnumerator left(float timeLerp, Vector3 TargetPos)
    {
        float time = 0;
        audioSource.PlayOneShot(MoveAudio);
        Vector3 StartPos = transform.position;
        while (time < timeLerp)
        {
            transform.position = Vector3.Lerp(StartPos, TargetPos, time / timeLerp);
            time += Time.deltaTime;
            if (outSide == true)
            {
                break;
            }
            yield return null;
        }
        Finish = true;
        if (outSide == false)
        {
            transform.position = TargetPos;
        }
    }
    IEnumerator up(float timeLerp, Vector3 TargetPos)
    {
        float time = 0;
        audioSource.PlayOneShot(MoveAudio);
        Vector3 StartPos = transform.position;
        while (time < timeLerp)
        {
            transform.position = Vector3.Lerp(StartPos, TargetPos, time / timeLerp);
            time += Time.deltaTime;
            if (outSide == true)
            {
                break;
            }
            yield return null;
        }

        Finish = true;
        if (outSide == false)
        {
            transform.position = TargetPos;
        }
    }
    IEnumerator down(float timeLerp, Vector3 TargetPos)
    {
        float time = 0;
        audioSource.PlayOneShot(MoveAudio);
        Vector3 StartPos = transform.position;
        while (time < timeLerp)
        {
            transform.position = Vector3.Lerp(StartPos, TargetPos, time / timeLerp);
            time += Time.deltaTime;
            if (outSide == true)
            {
                break;
            }
            yield return null;
        }
        Finish = true;
        if (outSide == false)
        {
            transform.position = TargetPos;
        }
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Win")
        {
            if (ThisKey)
            {
                if (Cashdesk == true)
                {
                    MainUi.SetActive(false);
                    WinMenu.SetActive(true);
                    AllowMove = false;
                    moved = 10;
                    audioSource.PlayOneShot(Victory);
                }
            }
            else
            {
                MainUi.SetActive(false);
                WinMenu.SetActive(true);
                AllowMove = false;
                moved = 10;
                audioSource.PlayOneShot(Victory);

            }

        }
        if (other.gameObject.tag == "Lose")
        {
            MainUi.SetActive(false);
            LoseMenu.SetActive(true);
            audioSource.PlayOneShot(Death);

        }
        if (other.gameObject.tag == "OutSide")
        {
            outSide = true;
        }
        if (other.gameObject.tag == "Key")
        {
            if (ThisKey == true)
            {
                Key = true;
                KeyObject.SetActive(false);
                audioSource.PlayOneShot(keySound);
            }

        }
        if (other.gameObject.tag == "Cashdesk")
        {
            if (ThisKey == true)
            {
                if (Key == true)
                {
                    Cashdesk = true;
                    CashdeskObject.SetActive(false);
                    audioSource.PlayOneShot(LockSound);
                }
            }
        }
    }
}
