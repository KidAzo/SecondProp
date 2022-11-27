using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DronesFollowTarget : MonoBehaviour
{
    Vector3[] _followOffsets;
    public void DronesFollowPlayer(List<GameObject> dronePrefabs)
    {
        for (int i = 0; i < dronePrefabs.Count; i++)
        {
            const float followSharpnesss = 3f;
            Vector3 desiredPosition = PlayerController.Instance.transform.position + _followOffsets[i];

            desiredPosition.y = dronePrefabs[i].transform.position.y;

            Vector3 smoothedPos = Vector3.Lerp(dronePrefabs[i].transform.position, desiredPosition, followSharpnesss * Time.deltaTime);
            dronePrefabs[i].transform.position = smoothedPos;
        }     
    }

    public void SetFollowOffsets(List<GameObject> dronePrefabs)
    {
        _followOffsets = new Vector3[dronePrefabs.Count];
        for (int i = 0; i < dronePrefabs.Count; i++)
        {
            _followOffsets[i] = dronePrefabs[i].transform.position - PlayerController.Instance.transform.position;
        }
    }
}


