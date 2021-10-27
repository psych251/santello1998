using Microsoft.MixedReality.Toolkit.Input;
using Microsoft.MixedReality.Toolkit.Utilities;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class logJointData : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (HandJointUtils.TryGetJointPose(TrackedHandJoint.IndexDistalJoint, Handedness.Right, out MixedRealityPose indexDistalJoint))
        {
            Debug.Log("IndexDistalJoint," + 100 * indexDistalJoint.Position.x + "," + 100 * indexDistalJoint.Position.y + "," + 100 * indexDistalJoint.Position.z);
        }
        if (HandJointUtils.TryGetJointPose(TrackedHandJoint.IndexKnuckle, Handedness.Right, out MixedRealityPose indexKnuckle))
        {
            Debug.Log("IndexKnuckle," + 100 * indexKnuckle.Position.x + "," + 100 * indexKnuckle.Position.y + "," + 100 * indexKnuckle.Position.z);
        }
        if (HandJointUtils.TryGetJointPose(TrackedHandJoint.IndexMetacarpal, Handedness.Right, out MixedRealityPose indexMetacarpal))
        {
            Debug.Log("IndexMetacarpal," + 100 * indexMetacarpal.Position.x + "," + 100 * indexMetacarpal.Position.y + "," + 100 * indexMetacarpal.Position.z);
        }
        if (HandJointUtils.TryGetJointPose(TrackedHandJoint.IndexMiddleJoint, Handedness.Right, out MixedRealityPose indexMiddleJoint))
        {
            Debug.Log("IndexMiddleJoint," + 100 * indexMiddleJoint.Position.x + "," + 100 * indexMiddleJoint.Position.y + "," + 100 * indexMiddleJoint.Position.z);
        }
        if (HandJointUtils.TryGetJointPose(TrackedHandJoint.IndexTip, Handedness.Right, out MixedRealityPose indexTip))
        {
            Debug.Log("IndexTip," + 100 * indexTip.Position.x + "," + 100 * indexTip.Position.y + "," + 100 * indexTip.Position.z);
        }
        if (HandJointUtils.TryGetJointPose(TrackedHandJoint.MiddleDistalJoint, Handedness.Right, out MixedRealityPose middleDistalJoint))
        {
            Debug.Log("MiddleDistalJoint," + 100 * middleDistalJoint.Position.x + "," + 100 * middleDistalJoint.Position.y + "," + 100 * middleDistalJoint.Position.z);
        }
        if (HandJointUtils.TryGetJointPose(TrackedHandJoint.MiddleKnuckle, Handedness.Right, out MixedRealityPose middleKnuckle))
        {
            Debug.Log("MiddleKnuckle," + 100 * middleKnuckle.Position.x + "," + 100 * middleKnuckle.Position.y + "," + 100 * middleKnuckle.Position.z);
        }
        if (HandJointUtils.TryGetJointPose(TrackedHandJoint.MiddleMetacarpal, Handedness.Right, out MixedRealityPose middleMetacarpal))
        {
            Debug.Log("MiddleMetacarpal," + 100 * middleMetacarpal.Position.x + "," + 100 * middleMetacarpal.Position.y + "," + 100 * middleMetacarpal.Position.z);
        }
        if (HandJointUtils.TryGetJointPose(TrackedHandJoint.MiddleMiddleJoint, Handedness.Right, out MixedRealityPose middleMiddleJoint))
        {
            Debug.Log("MiddleMiddleJoint," + 100 * middleMiddleJoint.Position.x + "," + 100 * middleMiddleJoint.Position.y + "," + 100 * middleMiddleJoint.Position.z);
        }
        if (HandJointUtils.TryGetJointPose(TrackedHandJoint.MiddleTip, Handedness.Right, out MixedRealityPose middleTip))
        {
            Debug.Log("MiddleTip," + 100 * middleTip.Position.x + "," + 100 * middleTip.Position.y + "," + 100 * middleTip.Position.z);
        }
        if (HandJointUtils.TryGetJointPose(TrackedHandJoint.Palm, Handedness.Right, out MixedRealityPose palm))
        {
            Debug.Log("Palm," + 100 * palm.Position.x + "," + 100 * palm.Position.y + "," + 100 * palm.Position.z);
        }
        if (HandJointUtils.TryGetJointPose(TrackedHandJoint.PinkyDistalJoint, Handedness.Right, out MixedRealityPose pinkyDistalJoint))
        {
            Debug.Log(" PinkyDistalJoint ," + 100 * pinkyDistalJoint.Position.x + "," + 100 * pinkyDistalJoint.Position.y + "," + 100 * pinkyDistalJoint.Position.z);
        }
        if (HandJointUtils.TryGetJointPose(TrackedHandJoint.PinkyKnuckle, Handedness.Right, out MixedRealityPose pinkyKnuckle))
        {
            Debug.Log("PinkyKnuckle," + 100 * pinkyKnuckle.Position.x + "," + 100 * pinkyKnuckle.Position.y + "," + 100 * pinkyKnuckle.Position.z);
        }
        if (HandJointUtils.TryGetJointPose(TrackedHandJoint.PinkyMetacarpal, Handedness.Right, out MixedRealityPose pinkyMetacarpal))
        {
            Debug.Log("PinkyMetacarpal," + 100 * pinkyMetacarpal.Position.x + "," + 100 * pinkyMetacarpal.Position.y + "," + 100 * pinkyMetacarpal.Position.z);
        }
        if (HandJointUtils.TryGetJointPose(TrackedHandJoint.PinkyMiddleJoint, Handedness.Right, out MixedRealityPose pinkyMiddleJoint))
        {
            Debug.Log("PinkyMiddleJoint," + 100 * pinkyMiddleJoint.Position.x + "," + 100 * pinkyMiddleJoint.Position.y + "," + 100 * pinkyMiddleJoint.Position.z);
        }
        if (HandJointUtils.TryGetJointPose(TrackedHandJoint.PinkyTip, Handedness.Right, out MixedRealityPose pinkyTip))
        {
            Debug.Log("PinkyTip," + 100 * pinkyTip.Position.x + "," + 100 * pinkyTip.Position.y + "," + 100 * pinkyTip.Position.z);
        }
        if (HandJointUtils.TryGetJointPose(TrackedHandJoint.RingDistalJoint, Handedness.Right, out MixedRealityPose ringDistalJoint))
        {
            Debug.Log("RingDistalJoint," + 100 * ringDistalJoint.Position.x + "," + 100 * ringDistalJoint.Position.y + "," + 100 * ringDistalJoint.Position.z);
        }
        if (HandJointUtils.TryGetJointPose(TrackedHandJoint.RingKnuckle, Handedness.Right, out MixedRealityPose ringKnuckle))
        {
            Debug.Log("RingKnuckle," + 100 * ringKnuckle.Position.x + "," + 100 * ringKnuckle.Position.y + "," + 100 * ringKnuckle.Position.z);
        }
        if (HandJointUtils.TryGetJointPose(TrackedHandJoint.RingMetacarpal, Handedness.Right, out MixedRealityPose ringMetacarpal))
        {
            Debug.Log("RingMetacarpal," + 100 * ringMetacarpal.Position.x + "," + 100 * ringMetacarpal.Position.y + "," + 100 * ringMetacarpal.Position.z);
        }
        if (HandJointUtils.TryGetJointPose(TrackedHandJoint.RingMiddleJoint, Handedness.Right, out MixedRealityPose ringMiddleJoint))
        {
            Debug.Log("RingMiddleJoint," + 100 * ringMiddleJoint.Position.x + "," + 100 * ringMiddleJoint.Position.y + "," + 100 * ringMiddleJoint.Position.z);
        }
        if (HandJointUtils.TryGetJointPose(TrackedHandJoint.RingTip, Handedness.Right, out MixedRealityPose ringTip))
        {
            Debug.Log("RingTip," + 100 * ringTip.Position.x + "," + 100 * ringTip.Position.y + "," + 100 * ringTip.Position.z);
        }
        if (HandJointUtils.TryGetJointPose(TrackedHandJoint.ThumbDistalJoint, Handedness.Right, out MixedRealityPose thumbDistalJoint))
        {
            Debug.Log("ThumbDistalJoint," + 100 * thumbDistalJoint.Position.x + "," + 100 * thumbDistalJoint.Position.y + "," + 100 * thumbDistalJoint.Position.z);
        }
        if (HandJointUtils.TryGetJointPose(TrackedHandJoint.ThumbMetacarpalJoint, Handedness.Right, out MixedRealityPose thumbMetacarpalJoint))
        {
            Debug.Log("ThumbMetacarpalJoint," + 100 * thumbMetacarpalJoint.Position.x + "," + 100 * thumbMetacarpalJoint.Position.y + "," + 100 * thumbMetacarpalJoint.Position.z);
        }
        if (HandJointUtils.TryGetJointPose(TrackedHandJoint.ThumbProximalJoint, Handedness.Right, out MixedRealityPose thumbProximalJoint))
        {
            Debug.Log("ThumbProximalJoint," + 100 * thumbProximalJoint.Position.x + "," + 100 * thumbProximalJoint.Position.y + "," + 100 * thumbProximalJoint.Position.z);
        }
        if (HandJointUtils.TryGetJointPose(TrackedHandJoint.ThumbTip, Handedness.Right, out MixedRealityPose thumbTip))
        {
            Debug.Log("ThumbTip," + 100 * thumbTip.Position.x + "," + 100 * thumbTip.Position.y + "," + 100 * thumbTip.Position.z);
        }
        if (HandJointUtils.TryGetJointPose(TrackedHandJoint.Wrist, Handedness.Right, out MixedRealityPose wrist))
        {
            Debug.Log("Wrist," + 100 * wrist.Position.x + "," + 100 * wrist.Position.y + "," + 100 * wrist.Position.z);
        }
    }
}
