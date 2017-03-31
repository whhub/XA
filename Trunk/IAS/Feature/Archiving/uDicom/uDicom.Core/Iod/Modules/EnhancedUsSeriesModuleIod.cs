/////////////////////////////////////////////////////////////////////////
//// Copyright, (c) Shanghai United Imaging Healthcare Inc
//// All rights reserved. 
//// 
//// author: qiuyang.cao@united-imaging.com
////
//// File: EnhancedUsSeriesModuleIod.cs
////
//// Summary:
////
////
//// Date: 2014/08/18
//////////////////////////////////////////////////////////////////////////
#region License

// Copyright (c) 2011 - 2013, United-Imaging Inc.
// All rights reserved.
// http://www.united-imaging.com

#endregion

using System;
using System.Collections.Generic;
using UIH.Dicom.Iod.Macros;
using UIH.Dicom.Iod.Macros.PerformedProcedureStepSummary;

namespace UIH.Dicom.Iod.Modules
{
	/// <summary>
	/// Enhanced US Series Module
	/// </summary>
	/// <remarks>As defined in the DICOM Standard 2011, Part 3, Section C.8.24.1 (Table C.8.24.1-1)</remarks>
	public class EnhancedUsSeriesModuleIod : IodBase
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="EnhancedUsSeriesModuleIod"/> class.
		/// </summary>	
		public EnhancedUsSeriesModuleIod() {}

		/// <summary>
		/// Initializes a new instance of the <see cref="EnhancedUsSeriesModuleIod"/> class.
		/// </summary>
		/// <param name="dicomElementProvider">The DICOM attribute collection.</param>
		public EnhancedUsSeriesModuleIod(IDicomElementProvider dicomElementProvider)
			: base(dicomElementProvider) {}

		/// <summary>
		/// Gets an enumeration of <see cref="DicomTag"/>s used by this module.
		/// </summary>
		public static IEnumerable<uint> DefinedTags
		{
			get
			{
				yield return DicomTags.Modality;
				yield return DicomTags.ReferencedPerformedProcedureStepSequence;
				yield return DicomTags.PerformedProtocolCodeSequence;
				yield return DicomTags.PerformedProtocolType;
			}
		}

		/// <summary>
		/// Initializes the underlying collection to implement the module or sequence using default values.
		/// </summary>
		public void InitializeAttributes()
		{
			Modality = " ";
			ReferencedPerformedProcedureStepSequence = null;
			PerformedProtocolCodeSequence = null;
			PerformedProtocolType = null;
		}

		/// <summary>
		/// Checks if this module appears to be non-empty.
		/// </summary>
		/// <returns>True if the module appears to be non-empty; False otherwise.</returns>
		public bool HasValues()
		{
			return !(IsNullOrEmpty(Modality)
			         && IsNullOrEmpty(ReferencedPerformedProcedureStepSequence)
			         && IsNullOrEmpty(PerformedProtocolCodeSequence)
			         && IsNullOrEmpty(PerformedProtocolType));
		}

		/// <summary>
		/// Gets or sets the value of Modality in the underlying collection. Type 1.
		/// </summary>
		public string Modality
		{
			get { return DicomElementProvider[DicomTags.Modality].GetString(0, string.Empty); }
			set
			{
				if (string.IsNullOrEmpty(value))
					throw new ArgumentNullException("value", "Modality is Type 1 Required.");
				DicomElementProvider[DicomTags.Modality].SetString(0, value);
			}
		}

		/// <summary>
		/// Gets or sets the value of ReferencedPerformedProcedureStepSequence in the underlying collection. Type 1C.
		/// </summary>
		public ISopInstanceReferenceMacro ReferencedPerformedProcedureStepSequence
		{
			get
			{
				var dicomAttribute = DicomElementProvider[DicomTags.ReferencedPerformedProcedureStepSequence];
				if (dicomAttribute.IsNull || dicomAttribute.IsEmpty)
				{
					return null;
				}
				return new SopInstanceReferenceMacro(((DicomSequenceItem[]) dicomAttribute.Values)[0]);
			}
			set
			{
				var dicomAttribute = DicomElementProvider[DicomTags.ReferencedPerformedProcedureStepSequence];
				if (value == null)
				{
					DicomElementProvider[DicomTags.ReferencedPerformedProcedureStepSequence] = null;
					return;
				}
				dicomAttribute.Values = new[] {value.DicomSequenceItem};
			}
		}

		/// <summary>
		/// Creates the ReferencedPerformedProcedureStepSequence in the underlying collection. Type 1C.
		/// </summary>
		public ISopInstanceReferenceMacro CreateReferencedPerformedProcedureStepSequence()
		{
			var dicomAttribute = DicomElementProvider[DicomTags.ReferencedPerformedProcedureStepSequence];
			if (dicomAttribute.IsNull || dicomAttribute.IsEmpty)
			{
				var dicomSequenceItem = new DicomSequenceItem();
				dicomAttribute.Values = new[] {dicomSequenceItem};
				var sequenceType = new SopInstanceReferenceMacro(dicomSequenceItem);
				sequenceType.InitializeAttributes();
				return sequenceType;
			}
			return new SopInstanceReferenceMacro(((DicomSequenceItem[]) dicomAttribute.Values)[0]);
		}

		/// <summary>
		/// Gets or sets the value of PerformedProtocolCodeSequence in the underlying collection. Type 1C.
		/// </summary>
		public IPerformedProtocolCodeSequence PerformedProtocolCodeSequence
		{
			get
			{
				var dicomAttribute = DicomElementProvider[DicomTags.PerformedProtocolCodeSequence];
				if (dicomAttribute.IsNull || dicomAttribute.IsEmpty)
				{
					return null;
				}
				return new GeneralSeriesModuleIod.PerformedProtocolCodeSequenceClass(((DicomSequenceItem[]) dicomAttribute.Values)[0]);
			}
			set
			{
				var dicomAttribute = DicomElementProvider[DicomTags.PerformedProtocolCodeSequence];
				if (value == null)
				{
					DicomElementProvider[DicomTags.PerformedProtocolCodeSequence] = null;
					return;
				}
				dicomAttribute.Values = new[] {value.DicomSequenceItem};
			}
		}

		/// <summary>
		/// Creates the PerformedProtocolCodeSequence in the underlying collection. Type 1C.
		/// </summary>
		public IPerformedProtocolCodeSequence CreatePerformedProtocolCodeSequence()
		{
			var dicomAttribute = DicomElementProvider[DicomTags.PerformedProtocolCodeSequence];
			if (dicomAttribute.IsNull || dicomAttribute.IsEmpty)
			{
				var dicomSequenceItem = new DicomSequenceItem();
				dicomAttribute.Values = new[] {dicomSequenceItem};
				var sequenceType = new GeneralSeriesModuleIod.PerformedProtocolCodeSequenceClass(dicomSequenceItem);
				sequenceType.InitializeAttributes();
				return sequenceType;
			}
			return new GeneralSeriesModuleIod.PerformedProtocolCodeSequenceClass(((DicomSequenceItem[]) dicomAttribute.Values)[0]);
		}

		/// <summary>
		/// Gets or sets the value of PerformedProtocolType in the underlying collection. Type 1C.
		/// </summary>
		public string PerformedProtocolType
		{
			get { return DicomElementProvider[DicomTags.PerformedProtocolType].GetString(0, string.Empty); }
			set
			{
				if (string.IsNullOrEmpty(value))
				{
					DicomElementProvider[DicomTags.PerformedProtocolType] = null;
					return;
				}
				DicomElementProvider[DicomTags.PerformedProtocolType].SetString(0, value);
			}
		}
	}
}
