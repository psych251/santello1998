using Microsoft.MixedReality.Toolkit.Input;
using Microsoft.MixedReality.Toolkit.Utilities;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class logJointData : MonoBehaviour
{
    private int i = 0;
    private Vector3 vec1;
    private Vector3 vec2;
    private Vector3 indexvec;
    private Vector3 middlevec;
    private Vector3 thumbproj;
    private Vector3 thumbvec;
    private double angle;
    private Vector3 palmNormal;

    private double findThumbRot(MixedRealityPose tmc, MixedRealityPose imc, MixedRealityPose mmc, MixedRealityPose tpj, MixedRealityPose ik, MixedRealityPose mk)
    {
        indexvec = new Vector3(ik.Position.x - imc.Position.x, ik.Position.y - imc.Position.y, ik.Position.z - imc.Position.z);
        middlevec = new Vector3(mk.Position.x - mmc.Position.x, mk.Position.y - mmc.Position.y, mk.Position.z - mmc.Position.z);
        palmNormal = Vector3.Cross(middlevec, indexvec); //Unity system is left-handed, this vector points ventrally
        thumbvec = new Vector3(tpj.Position.x - tmc.Position.x, tpj.Position.y - tmc.Position.y, tpj.Position.z - tmc.Position.z);
        //thumbproj = Vector3.ProjectOnPlane(thumbvec, palmNormal);
        angle = 90d -Vector3.Angle(thumbvec, palmNormal);
        return angle;
    }

    private double findThumbAbd(MixedRealityPose tmc, MixedRealityPose imc, MixedRealityPose mmc, MixedRealityPose tpj, MixedRealityPose ik, MixedRealityPose mk)
    {
        indexvec = new Vector3(ik.Position.x - imc.Position.x, ik.Position.y - imc.Position.y, ik.Position.z - imc.Position.z);
        middlevec = new Vector3(mk.Position.x - mmc.Position.x, mk.Position.y - mmc.Position.y, mk.Position.z - mmc.Position.z);
        palmNormal = Vector3.Cross(middlevec, indexvec); //Unity system is left-handed, this vector points ventrally
        thumbvec = new Vector3(tpj.Position.x - tmc.Position.x, tpj.Position.y - tmc.Position.y, tpj.Position.z - tmc.Position.z);
        thumbproj = Vector3.ProjectOnPlane(thumbvec, palmNormal);
        angle = Vector3.Angle(indexvec, thumbproj);
        return angle;
    }

    private double findJointAngle1(MixedRealityPose j1, MixedRealityPose j2, MixedRealityPose j3)
    {
        //find angle bw j1-j2 and j2-j3
        vec1 = new Vector3(j2.Position.x-j1.Position.x, j2.Position.y - j1.Position.y, j2.Position.z - j1.Position.z);
        vec2 = new Vector3(j3.Position.x - j2.Position.x, j3.Position.y - j2.Position.y, j3.Position.z - j2.Position.z);
        angle = Vector3.Angle(vec1, vec2);
        return angle;
    }

    private double findJointAngle2(MixedRealityPose j1, MixedRealityPose j2, MixedRealityPose j3, MixedRealityPose j4)
    {
        //find angle bw j1-j2 and j3-j4
        vec1 = new Vector3(j2.Position.x - j1.Position.x, j2.Position.y - j1.Position.y, j2.Position.z - j1.Position.z);
        vec2 = new Vector3(j4.Position.x - j3.Position.x, j4.Position.y - j3.Position.y, j4.Position.z - j3.Position.z);
        angle = Vector3.Angle(vec1, vec2);
        return angle;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            i++;
            if (HandJointUtils.TryGetJointPose(TrackedHandJoint.IndexDistalJoint, Handedness.Right, out MixedRealityPose indexDistalJoint))
            {
                //Debug.Log(i+"IndexDistalJoint," + Time.time + "," + 100 * indexDistalJoint.Position.x + "," + 100 * indexDistalJoint.Position.y + "," + 100 * indexDistalJoint.Position.z);
            }
            if (HandJointUtils.TryGetJointPose(TrackedHandJoint.IndexKnuckle, Handedness.Right, out MixedRealityPose indexKnuckle))
            {
                //Debug.Log(i+"IndexKnuckle," + Time.time + "," + 100 * indexKnuckle.Position.x + "," + 100 * indexKnuckle.Position.y + "," + 100 * indexKnuckle.Position.z);
            }
            if (HandJointUtils.TryGetJointPose(TrackedHandJoint.IndexMetacarpal, Handedness.Right, out MixedRealityPose indexMetacarpal))
            {
                //Debug.Log(i+"IndexMetacarpal," + Time.time + "," + 100 * indexMetacarpal.Position.x + "," + 100 * indexMetacarpal.Position.y + "," + 100 * indexMetacarpal.Position.z);
            }
            if (HandJointUtils.TryGetJointPose(TrackedHandJoint.IndexMiddleJoint, Handedness.Right, out MixedRealityPose indexMiddleJoint))
            {
                //Debug.Log(i+"IndexMiddleJoint," + Time.time + "," + 100 * indexMiddleJoint.Position.x + "," + 100 * indexMiddleJoint.Position.y + "," + 100 * indexMiddleJoint.Position.z);
            }
            if (HandJointUtils.TryGetJointPose(TrackedHandJoint.IndexTip, Handedness.Right, out MixedRealityPose indexTip))
            {
                //Debug.Log(i+"IndexTip," + Time.time + "," + 100 * indexTip.Position.x + "," + 100 * indexTip.Position.y + "," + 100 * indexTip.Position.z);
            }
            if (HandJointUtils.TryGetJointPose(TrackedHandJoint.MiddleDistalJoint, Handedness.Right, out MixedRealityPose middleDistalJoint))
            {
                //Debug.Log(i+"MiddleDistalJoint," + Time.time + "," + 100 * middleDistalJoint.Position.x + "," + 100 * middleDistalJoint.Position.y + "," + 100 * middleDistalJoint.Position.z);
            }
            if (HandJointUtils.TryGetJointPose(TrackedHandJoint.MiddleKnuckle, Handedness.Right, out MixedRealityPose middleKnuckle))
            {
                //Debug.Log(i+"MiddleKnuckle," + Time.time + "," + 100 * middleKnuckle.Position.x + "," + 100 * middleKnuckle.Position.y + "," + 100 * middleKnuckle.Position.z);
            }
            if (HandJointUtils.TryGetJointPose(TrackedHandJoint.MiddleMetacarpal, Handedness.Right, out MixedRealityPose middleMetacarpal))
            {
                //Debug.Log(i+"MiddleMetacarpal," + Time.time + "," + 100 * middleMetacarpal.Position.x + "," + 100 * middleMetacarpal.Position.y + "," + 100 * middleMetacarpal.Position.z);
            }
            if (HandJointUtils.TryGetJointPose(TrackedHandJoint.MiddleMiddleJoint, Handedness.Right, out MixedRealityPose middleMiddleJoint))
            {
                //Debug.Log(i+"MiddleMiddleJoint," + Time.time + "," + 100 * middleMiddleJoint.Position.x + "," + 100 * middleMiddleJoint.Position.y + "," + 100 * middleMiddleJoint.Position.z);
            }
            if (HandJointUtils.TryGetJointPose(TrackedHandJoint.MiddleTip, Handedness.Right, out MixedRealityPose middleTip))
            {
                //Debug.Log(i+"MiddleTip," + Time.time + "," + 100 * middleTip.Position.x + "," + 100 * middleTip.Position.y + "," + 100 * middleTip.Position.z);
            }
            if (HandJointUtils.TryGetJointPose(TrackedHandJoint.Palm, Handedness.Right, out MixedRealityPose palm))
            {
                //Debug.Log(i+"Palm," + Time.time + "," + 100 * palm.Position.x + "," + 100 * palm.Position.y + "," + 100 * palm.Position.z);
            }
            if (HandJointUtils.TryGetJointPose(TrackedHandJoint.PinkyDistalJoint, Handedness.Right, out MixedRealityPose pinkyDistalJoint))
            {
                //Debug.Log(i+"PinkyDistalJoint ," + Time.time + "," + 100 * pinkyDistalJoint.Position.x + "," + 100 * pinkyDistalJoint.Position.y + "," + 100 * pinkyDistalJoint.Position.z);
            }
            if (HandJointUtils.TryGetJointPose(TrackedHandJoint.PinkyKnuckle, Handedness.Right, out MixedRealityPose pinkyKnuckle))
            {
                //Debug.Log(i+"PinkyKnuckle," + Time.time + "," + 100 * pinkyKnuckle.Position.x + "," + 100 * pinkyKnuckle.Position.y + "," + 100 * pinkyKnuckle.Position.z);
            }
            if (HandJointUtils.TryGetJointPose(TrackedHandJoint.PinkyMetacarpal, Handedness.Right, out MixedRealityPose pinkyMetacarpal))
            {
                //Debug.Log(i+"PinkyMetacarpal," + Time.time + "," + 100 * pinkyMetacarpal.Position.x + "," + 100 * pinkyMetacarpal.Position.y + "," + 100 * pinkyMetacarpal.Position.z);
            }
            if (HandJointUtils.TryGetJointPose(TrackedHandJoint.PinkyMiddleJoint, Handedness.Right, out MixedRealityPose pinkyMiddleJoint))
            {
                //Debug.Log(i+"PinkyMiddleJoint," + Time.time + "," + 100 * pinkyMiddleJoint.Position.x + "," + 100 * pinkyMiddleJoint.Position.y + "," + 100 * pinkyMiddleJoint.Position.z);
            }
            if (HandJointUtils.TryGetJointPose(TrackedHandJoint.PinkyTip, Handedness.Right, out MixedRealityPose pinkyTip))
            {
                //Debug.Log(i+"PinkyTip," + Time.time + "," + 100 * pinkyTip.Position.x + "," + 100 * pinkyTip.Position.y + "," + 100 * pinkyTip.Position.z);
            }
            if (HandJointUtils.TryGetJointPose(TrackedHandJoint.RingDistalJoint, Handedness.Right, out MixedRealityPose ringDistalJoint))
            {
                //Debug.Log(i+"RingDistalJoint," + Time.time + "," + 100 * ringDistalJoint.Position.x + "," + 100 * ringDistalJoint.Position.y + "," + 100 * ringDistalJoint.Position.z);
            }
            if (HandJointUtils.TryGetJointPose(TrackedHandJoint.RingKnuckle, Handedness.Right, out MixedRealityPose ringKnuckle))
            {
                //Debug.Log(i+"RingKnuckle," + Time.time + "," + 100 * ringKnuckle.Position.x + "," + 100 * ringKnuckle.Position.y + "," + 100 * ringKnuckle.Position.z);
            }
            if (HandJointUtils.TryGetJointPose(TrackedHandJoint.RingMetacarpal, Handedness.Right, out MixedRealityPose ringMetacarpal))
            {
                //Debug.Log(i+"RingMetacarpal," + Time.time + "," + 100 * ringMetacarpal.Position.x + "," + 100 * ringMetacarpal.Position.y + "," + 100 * ringMetacarpal.Position.z);
            }
            if (HandJointUtils.TryGetJointPose(TrackedHandJoint.RingMiddleJoint, Handedness.Right, out MixedRealityPose ringMiddleJoint))
            {
                //Debug.Log(i+"RingMiddleJoint," + Time.time + "," + 100 * ringMiddleJoint.Position.x + "," + 100 * ringMiddleJoint.Position.y + "," + 100 * ringMiddleJoint.Position.z);
            }
            if (HandJointUtils.TryGetJointPose(TrackedHandJoint.RingTip, Handedness.Right, out MixedRealityPose ringTip))
            {
                //Debug.Log(i+"RingTip," + Time.time + "," + 100 * ringTip.Position.x + "," + 100 * ringTip.Position.y + "," + 100 * ringTip.Position.z);
            }
            if (HandJointUtils.TryGetJointPose(TrackedHandJoint.ThumbDistalJoint, Handedness.Right, out MixedRealityPose thumbDistalJoint))
            {
                //Debug.Log(i+"ThumbDistalJoint," + Time.time + "," + 100 * thumbDistalJoint.Position.x + "," + 100 * thumbDistalJoint.Position.y + "," + 100 * thumbDistalJoint.Position.z);
            }
            if (HandJointUtils.TryGetJointPose(TrackedHandJoint.ThumbMetacarpalJoint, Handedness.Right, out MixedRealityPose thumbMetacarpalJoint))
            {
                //Debug.Log(i+"ThumbMetacarpalJoint," + Time.time + "," + 100 * thumbMetacarpalJoint.Position.x + "," + 100 * thumbMetacarpalJoint.Position.y + "," + 100 * thumbMetacarpalJoint.Position.z);
            }
            if (HandJointUtils.TryGetJointPose(TrackedHandJoint.ThumbProximalJoint, Handedness.Right, out MixedRealityPose thumbProximalJoint))
            {
                //Debug.Log(i+"ThumbProximalJoint," + Time.time + "," + 100 * thumbProximalJoint.Position.x + "," + 100 * thumbProximalJoint.Position.y + "," + 100 * thumbProximalJoint.Position.z);
            }
            if (HandJointUtils.TryGetJointPose(TrackedHandJoint.ThumbTip, Handedness.Right, out MixedRealityPose thumbTip))
            {
                //Debug.Log(i+"ThumbTip," + Time.time + "," + 100 * thumbTip.Position.x + "," + 100 * thumbTip.Position.y + "," + 100 * thumbTip.Position.z);
            }
            if (HandJointUtils.TryGetJointPose(TrackedHandJoint.Wrist, Handedness.Right, out MixedRealityPose wrist))
            {
                //Debug.Log(i+"Wrist," + Time.time + "," + 100 * wrist.Position.x + "," + 100 * wrist.Position.y + "," + 100 * wrist.Position.z);
            }
            Debug.Log(i + "," + "IndexMCP" +","+ Time.time + "," + findJointAngle1(indexMetacarpal, indexKnuckle, indexMiddleJoint));
            Debug.Log(i + "," + "MiddleMCP" +","+ Time.time + "," + findJointAngle1(middleMetacarpal, middleKnuckle, middleMiddleJoint));
            Debug.Log(i + "," + "RingMCP" +","+ Time.time + "," + findJointAngle1(ringMetacarpal, ringKnuckle, ringMiddleJoint));
            Debug.Log(i + "," + "PinkyMCP" +","+ Time.time + "," + findJointAngle1(pinkyMetacarpal, pinkyKnuckle, pinkyMiddleJoint));
            Debug.Log(i + "," + "ThumbMCP" +","+ Time.time + "," + findJointAngle1(thumbMetacarpalJoint, thumbProximalJoint, thumbDistalJoint));
            Debug.Log(i + "," + "IndexPIP" +","+ Time.time + "," + findJointAngle1(indexKnuckle, indexMiddleJoint, indexDistalJoint));
            Debug.Log(i + "," + "MiddlePIP" +","+ Time.time + "," + findJointAngle1(middleKnuckle, middleMiddleJoint, middleDistalJoint));
            Debug.Log(i + "," + "RingPIP" +","+ Time.time + "," + findJointAngle1(ringKnuckle, ringMiddleJoint, ringDistalJoint));
            Debug.Log(i + "," + "PinkyPIP" +","+ Time.time + "," + findJointAngle1(pinkyKnuckle, pinkyMiddleJoint, pinkyDistalJoint));
            Debug.Log(i + "," + "ThumbIP" +","+ Time.time + "," + findJointAngle1(thumbProximalJoint, thumbDistalJoint, thumbTip));
            Debug.Log(i + "," + "IndexMiddleABD" +","+ Time.time + "," + findJointAngle2(indexKnuckle, indexMiddleJoint, middleKnuckle, middleMiddleJoint));
            Debug.Log(i + "," + "MiddleRingABD" +","+ Time.time + "," + findJointAngle2(middleKnuckle, middleMiddleJoint, ringKnuckle, ringMiddleJoint));
            Debug.Log(i + "," + "RingPinkyABD" +","+ Time.time + "," + findJointAngle2(ringKnuckle, ringMiddleJoint, pinkyKnuckle, pinkyMiddleJoint));
            Debug.Log(i + "," + "ThumbABD" +","+ Time.time + "," + findThumbAbd(thumbMetacarpalJoint, indexMetacarpal, middleMetacarpal, thumbProximalJoint, indexKnuckle, middleKnuckle));
            Debug.Log(i + "," + "ThumbROT" +","+ Time.time + "," + findThumbRot(thumbMetacarpalJoint, indexMetacarpal, middleMetacarpal,thumbProximalJoint, indexKnuckle, middleKnuckle));

        }
    }
}
