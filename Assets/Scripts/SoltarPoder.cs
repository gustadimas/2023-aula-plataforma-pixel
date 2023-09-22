using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoltarPoder : MonoBehaviour
{
    [SerializeField] GameObject poder, origem;
    [SerializeField] Transform player;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.J))
        {
            Instantiate(poder, origem.transform.position, player.rotation);
        }
    }
}
