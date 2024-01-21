using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PatternLessons.TraderTask
{
    public class Character : MonoBehaviour
    {
        private float _experience;
        private float _speed;

        public float Experience => _experience;

        public void Initialize(float speed,float experience)
        {
            _speed = speed;
            _experience = experience;
        }

        private void Update()
        {
            Move();           
        }

        private void LateUpdate()
        {
            IncreaseExperience(100);
            DecreaceExperience(100);
        }

        private void DecreaceExperience(float value)
        {
            if (Input.GetKeyDown(KeyCode.R))
            {
                _experience -= value;
                Debug.Log($"Remove exp. Current exp: {_experience}");
            }            
        }

        private void IncreaseExperience(float value)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                _experience += value;
                Debug.Log($"Add exp. Current exp: {_experience}");
            }            
        }

        private void Move()
        {
            float horizontalInput = Input.GetAxis("Horizontal");
            float verticalInput = Input.GetAxis("Vertical");

            Vector3 movement = new Vector3(horizontalInput, 0f, verticalInput) * _speed * Time.deltaTime;
            transform.Translate(movement, Space.Self);
        }
    }
}

