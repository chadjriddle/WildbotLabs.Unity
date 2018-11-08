﻿using UnityEngine;
using WildbotLabs.Scriptables.References;

namespace WildbotLabs.Scriptables.Components
{
    public class TrackRotation: MonoBehaviour
    {
        [SerializeField] private QuaternionReference _value;

        // Use this for initialization
        void Start()
        {
            UpdateValue();
        }

        // Update is called once per frame
        void Update()
        {
            UpdateValue();
        }

        private void UpdateValue()
        {
            _value?.SetValue(transform.rotation);
        }
    }
}