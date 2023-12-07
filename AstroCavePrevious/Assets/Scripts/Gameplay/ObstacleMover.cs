using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMover : MonoBehaviour
{
    public Vector3 StartPosition;
    public Vector3 EndPosition;

    public float LerpTime;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("MoveCoroutine");
    }

    IEnumerator MoveCoroutine()
    {
        while (true)
        {
            yield return MoveBetweenPositions(StartPosition, EndPosition, LerpTime);

            yield return MoveBetweenPositions(EndPosition, StartPosition, LerpTime);
        }
    }

    IEnumerator MoveBetweenPositions(Vector3 pointA, Vector3 pointB, float time)
    {
        float progressTime = 0;

        while (progressTime < time && time > 0)
        {
            transform.position = Vector3.Lerp(pointA, pointB, progressTime / time);

            progressTime += Time.fixedDeltaTime;
            yield return new WaitForFixedUpdate();
        }
    }
}
