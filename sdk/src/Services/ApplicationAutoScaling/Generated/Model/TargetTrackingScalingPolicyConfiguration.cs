/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the application-autoscaling-2016-02-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ApplicationAutoScaling.Model
{
    /// <summary>
    /// Represents a target tracking scaling policy configuration to use with Application
    /// Auto Scaling.
    /// </summary>
    public partial class TargetTrackingScalingPolicyConfiguration
    {
        private CustomizedMetricSpecification _customizedMetricSpecification;
        private bool? _disableScaleIn;
        private PredefinedMetricSpecification _predefinedMetricSpecification;
        private int? _scaleInCooldown;
        private int? _scaleOutCooldown;
        private double? _targetValue;

        /// <summary>
        /// Gets and sets the property CustomizedMetricSpecification. 
        /// <para>
        /// A customized metric. You can specify either a predefined metric or a customized metric.
        /// </para>
        /// </summary>
        public CustomizedMetricSpecification CustomizedMetricSpecification
        {
            get { return this._customizedMetricSpecification; }
            set { this._customizedMetricSpecification = value; }
        }

        // Check to see if CustomizedMetricSpecification property is set
        internal bool IsSetCustomizedMetricSpecification()
        {
            return this._customizedMetricSpecification != null;
        }

        /// <summary>
        /// Gets and sets the property DisableScaleIn. 
        /// <para>
        /// Indicates whether scale in by the target tracking scaling policy is disabled. If the
        /// value is <code>true</code>, scale in is disabled and the target tracking scaling policy
        /// won't remove capacity from the scalable resource. Otherwise, scale in is enabled and
        /// the target tracking scaling policy can remove capacity from the scalable resource.
        /// The default value is <code>false</code>.
        /// </para>
        /// </summary>
        public bool DisableScaleIn
        {
            get { return this._disableScaleIn.GetValueOrDefault(); }
            set { this._disableScaleIn = value; }
        }

        // Check to see if DisableScaleIn property is set
        internal bool IsSetDisableScaleIn()
        {
            return this._disableScaleIn.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PredefinedMetricSpecification. 
        /// <para>
        /// A predefined metric. You can specify either a predefined metric or a customized metric.
        /// </para>
        /// </summary>
        public PredefinedMetricSpecification PredefinedMetricSpecification
        {
            get { return this._predefinedMetricSpecification; }
            set { this._predefinedMetricSpecification = value; }
        }

        // Check to see if PredefinedMetricSpecification property is set
        internal bool IsSetPredefinedMetricSpecification()
        {
            return this._predefinedMetricSpecification != null;
        }

        /// <summary>
        /// Gets and sets the property ScaleInCooldown. 
        /// <para>
        /// The amount of time, in seconds, after a scale-in activity completes before another
        /// scale in activity can start.
        /// </para>
        ///  
        /// <para>
        /// The cooldown period is used to block subsequent scale-in requests until it has expired.
        /// The intention is to scale in conservatively to protect your application's availability.
        /// However, if another alarm triggers a scale-out policy during the cooldown period after
        /// a scale-in, Application Auto Scaling scales out your scalable target immediately.
        /// </para>
        /// </summary>
        public int ScaleInCooldown
        {
            get { return this._scaleInCooldown.GetValueOrDefault(); }
            set { this._scaleInCooldown = value; }
        }

        // Check to see if ScaleInCooldown property is set
        internal bool IsSetScaleInCooldown()
        {
            return this._scaleInCooldown.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ScaleOutCooldown. 
        /// <para>
        /// The amount of time, in seconds, after a scale-out activity completes before another
        /// scale-out activity can start.
        /// </para>
        ///  
        /// <para>
        /// While the cooldown period is in effect, the capacity that has been added by the previous
        /// scale-out event that initiated the cooldown is calculated as part of the desired capacity
        /// for the next scale out. The intention is to continuously (but not excessively) scale
        /// out.
        /// </para>
        /// </summary>
        public int ScaleOutCooldown
        {
            get { return this._scaleOutCooldown.GetValueOrDefault(); }
            set { this._scaleOutCooldown = value; }
        }

        // Check to see if ScaleOutCooldown property is set
        internal bool IsSetScaleOutCooldown()
        {
            return this._scaleOutCooldown.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TargetValue. 
        /// <para>
        /// The target value for the metric. The range is 8.515920e-109 to 1.174271e+108 (Base
        /// 10) or 2e-360 to 2e360 (Base 2).
        /// </para>
        /// </summary>
        public double TargetValue
        {
            get { return this._targetValue.GetValueOrDefault(); }
            set { this._targetValue = value; }
        }

        // Check to see if TargetValue property is set
        internal bool IsSetTargetValue()
        {
            return this._targetValue.HasValue; 
        }

    }
}