using System;
using Unity.VisualScripting;
using UnityEngine;

namespace Custom_Assets
{
    [Serializable]
    public struct ROKVector3
    {
        public float x;
        public float y;
        public float z;

        public ROKVector3(float x,float y, float z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public static implicit operator Vector3(ROKVector3 rokVector3)
        {
            return new Vector3(rokVector3.x, rokVector3.y, rokVector3.z);
        }
        
        public static implicit operator ROKVector3(Vector3 vector3)
        {
            return new ROKVector3(vector3.x, vector3.y, vector3.z);
        }

        public static ROKVector3 operator *(ROKVector3 rokA,ROKVector3 rokB)
        {
            return new ROKVector3(rokA.x * rokB.x, rokA.y * rokB.y, rokA.z * rokB.z);
        }
        
        public static ROKVector3 operator *(ROKVector3 rokA,float rokB)
        {
            return new ROKVector3(rokA.x * rokB, rokA.y * rokB, rokA.z * rokB);
        }
        
        public static ROKVector3 operator +(ROKVector3 rokA,float rokB)
        {
            return new ROKVector3(rokA.x + rokB, rokA.y + rokB, rokA.z + rokB);
        }
        
        public static ROKVector3 operator +(ROKVector3 rokA,ROKVector3 rokB)
        {
            return new ROKVector3(rokA.x + rokB.x, rokA.y + rokB.y, rokA.z + rokB.z);
        }
        
        public static ROKVector3 operator -(ROKVector3 rokA,float rokB)
        {
            return new ROKVector3(rokA.x - rokB, rokA.y - rokB, rokA.z - rokB);
        }
        
        public static ROKVector3 operator -(ROKVector3 rokA,ROKVector3 rokB)
        {
            return new ROKVector3(rokA.x - rokB.x, rokA.y - rokB.y, rokA.z - rokB.z);
        }

    }
}