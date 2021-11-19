﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Astroid : MonoBehaviour
{
    [SerializeField]
    private float _rotateSpeed = 20.0f;
    [SerializeField]
    private GameObject _explosionPrefab;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.forward * _rotateSpeed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Laser")
        {
          Instantiate(_explosionPrefab, transform.position, Quaternion.identity);
          Destroy(this.gameObject, 0.25f);
          Destroy(other.gameObject);
        }
    }
}
