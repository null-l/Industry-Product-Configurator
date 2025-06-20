using UnityEngine;

namespace IndustryCSE.Tool.ProductConfigurator.ScriptableObjects
{
    public class VariantSetAsset : AssetBase
    {
        public float blendingFactor = 1.0f;
        public string VariantSetName => variantSetName;
        [SerializeField]
        private string variantSetName;
        
        #if UNITY_EDITOR
        
        [HideInInspector]
        public bool hasStoreCameraPositionAndRotation;
        [HideInInspector]
        public Vector3 storeCameraPosition;
        [HideInInspector]
        public Quaternion storeCameraRotation;

        [HideInInspector]
        public float storeCameraDistance;
        
        #endif
        
#if UNITY_EDITOR
        public override void SetName(string value)
        {
            variantSetName = value;
        }
#endif
    }
}
