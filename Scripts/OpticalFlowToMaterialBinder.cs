using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace OpticalFlow {
    public class OpticalFlowToMaterialBinder : MonoBehaviour
    {
        public OpticalFlow opticalFlow;
        public Material material;
        public string propertyName;

        private bool _binded = false;

        // Start is called before the first frame update
        void Start() {
            Bind();
        }

        // Update is called once per frame
        void Update() {

            if (!_binded)
                Bind();
        }

        void Bind() {

            if (opticalFlow.Flow == null)
                return;

            material.SetTexture(propertyName, opticalFlow.Flow);
            _binded = true;
        }
    }
}
