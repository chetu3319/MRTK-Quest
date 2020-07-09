<<<<<<< HEAD
﻿//------------------------------------------------------------------------------ -
//MRTK - Quest
//https ://github.com/provencher/MRTK-Quest
//Contribution by: Chaitanya Shah (https://github.com/chetu3319)
//------------------------------------------------------------------------------ -
//
//MIT License
//
//Copyright(c) 2020 Chaitanya Shah
//
//Permission is hereby granted, free of charge, to any person obtaining a copy
//of this software and associated documentation files(the "Software"), to deal
//in the Software without restriction, including without limitation the rights
//to use, copy, modify, merge, publish, distribute, sublicense, and / or sell
//copies of the Software, and to permit persons to whom the Software is
//furnished to do so, subject to the following conditions :
//
//The above copyright notice and this permission notice shall be included in all
//copies or substantial portions of the Software.
//
//THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
//IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
//FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT.IN NO EVENT SHALL THE
//AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
//LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
//OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
//SOFTWARE.
//------------------------------------------------------------------------------ -

using UnityEngine;
using Microsoft.MixedReality.Toolkit.Utilities;

namespace prvncher.MixedReality.Toolkit.Utils
{
    public class FingerCurlExample : MonoBehaviour
    {
        [SerializeField]
        private Handedness handedness;

        [SerializeField]
        private GameObject indexFinger;

        [SerializeField]
        private GameObject middleFinger;

        [SerializeField]
        private GameObject ringFinger;

        [SerializeField]
        private GameObject pinkyFinger;

        [SerializeField]
        private GameObject thumbFinger;

        void Update()
        {
            if (indexFinger != null)
            {
                var indexCurl = HandPoseUtils.IndexFingerCurl(handedness);
                indexFinger.transform.localScale = new Vector3(1.0f, 1.0f - indexCurl, 1.0f);
            }

            if (middleFinger != null)
            {
                var middleCurl = HandPoseUtils.MiddleFingerCurl(handedness);
                middleFinger.transform.localScale = new Vector3(1.0f, 1.0f - middleCurl, 1.0f);
            }

            if (ringFinger != null)
            {
                var ringCurl = HandPoseUtils.RingFingerCurl(handedness);
                ringFinger.transform.localScale = new Vector3(1.0f, 1.0f - ringCurl, 1.0f);
            }

            if (pinkyFinger != null)
            {
                var pinkyCurl = HandPoseUtils.PinkyFingerCurl(handedness);
                pinkyFinger.transform.localScale = new Vector3(1.0f, 1.0f - pinkyCurl, 1.0f);
            }

            if (thumbFinger != null)
            {
                var thumbCurl = HandPoseUtils.ThumbFingerCurl(handedness);
                thumbFinger.transform.localScale = new Vector3(1.0f, 1.0f - thumbCurl, 1.0f);
            }
        }

=======
﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using prvncher.MixedReality.Toolkit.Utils;
using Microsoft.MixedReality.Toolkit.Utilities;

public class FingerCurlExample : MonoBehaviour
{
    public Handedness handedness;

    public GameObject indexFinger;
    public GameObject middleFinger;
    public GameObject ringFinger;
    public GameObject pinkyFinger;



    // Update is called once per frame
    void Update()
    {
        var fingerCurl = HandPoseUtils.IndexCurl(handedness);
        var scale = new Vector3(1.0f, 1.0f - fingerCurl, 1.0f);
        indexFinger.transform.localScale = scale;

        fingerCurl = HandPoseUtils.MiddleCurl(handedness);
        scale = new Vector3(1.0f, 1.0f - fingerCurl, 1.0f);
        middleFinger.transform.localScale = scale;

        fingerCurl = HandPoseUtils.RingCurl(handedness);
        scale = new Vector3(1.0f, 1.0f - fingerCurl, 1.0f);
        ringFinger.transform.localScale = scale;

        fingerCurl = HandPoseUtils.PinkyCurl(handedness);
        scale = new Vector3(1.0f, 1.0f - fingerCurl, 1.0f);
        pinkyFinger.transform.localScale = scale;
>>>>>>> Finger Curl Calculation
    }
}