﻿

// Copyright (c) 2012-2016 fo-dicom contributors.
// Licensed under the Microsoft Public License (MS-PL).

namespace UIH.Dicom
{
    public struct DicomTags
    {
			///<summary>
		///<para> (0000,0000) Command Group Length </para>
		///<para> VR: UL VM=1 </para>
		///</summary>
        public const uint CommandGroupLength = 0;

		///<summary>
		///<para> (0000,0002) Affected SOP Class UID </para>
		///<para> VR: UI VM=1 </para>
		///</summary>
        public const uint AffectedSopClassUid = 2;

		///<summary>
		///<para> (0000,0003) Requested SOP Class UID </para>
		///<para> VR: UI VM=1 </para>
		///</summary>
        public const uint RequestedSopClassUid = 3;

		///<summary>
		///<para> (0000,0100) Command Field </para>
		///<para> VR: US VM=1 </para>
		///</summary>
        public const uint CommandField = 256;

		///<summary>
		///<para> (0000,0110) Message ID </para>
		///<para> VR: US VM=1 </para>
		///</summary>
        public const uint MessageId = 272;

		///<summary>
		///<para> (0000,0120) Message ID Being Responded To </para>
		///<para> VR: US VM=1 </para>
		///</summary>
        public const uint MessageIdBeingRespondedTo = 288;

		///<summary>
		///<para> (0000,0600) Move Destination </para>
		///<para> VR: AE VM=1 </para>
		///</summary>
        public const uint MoveDestination = 1536;

		///<summary>
		///<para> (0000,0700) Priority </para>
		///<para> VR: US VM=1 </para>
		///</summary>
        public const uint Priority = 1792;

		///<summary>
		///<para> (0000,0800) Command Data Set Type </para>
		///<para> VR: US VM=1 </para>
		///</summary>
        public const uint CommandDataSetType = 2048;

		///<summary>
		///<para> (0000,0900) Status </para>
		///<para> VR: US VM=1 </para>
		///</summary>
        public const uint Status = 2304;

		///<summary>
		///<para> (0000,0901) Offending Element </para>
		///<para> VR: AT VM=1-n </para>
		///</summary>
        public const uint OffendingElement = 2305;

		///<summary>
		///<para> (0000,0902) Error Comment </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint ErrorComment = 2306;

		///<summary>
		///<para> (0000,0903) Error ID </para>
		///<para> VR: US VM=1 </para>
		///</summary>
        public const uint ErrorId = 2307;

		///<summary>
		///<para> (0000,1000) Affected SOP Instance UID </para>
		///<para> VR: UI VM=1 </para>
		///</summary>
        public const uint AffectedSopInstanceUid = 4096;

		///<summary>
		///<para> (0000,1001) Requested SOP Instance UID </para>
		///<para> VR: UI VM=1 </para>
		///</summary>
        public const uint RequestedSopInstanceUid = 4097;

		///<summary>
		///<para> (0000,1002) Event Type ID </para>
		///<para> VR: US VM=1 </para>
		///</summary>
        public const uint EventTypeId = 4098;

		///<summary>
		///<para> (0000,1005) Attribute Identifier List </para>
		///<para> VR: AT VM=1-n </para>
		///</summary>
        public const uint AttributeIdentifierList = 4101;

		///<summary>
		///<para> (0000,1008) Action Type ID </para>
		///<para> VR: US VM=1 </para>
		///</summary>
        public const uint ActionTypeId = 4104;

		///<summary>
		///<para> (0000,1020) Number of Remaining Sub-operations </para>
		///<para> VR: US VM=1 </para>
		///</summary>
        public const uint NumberOfRemainingSubOperations = 4128;

		///<summary>
		///<para> (0000,1021) Number of Completed Sub-operations </para>
		///<para> VR: US VM=1 </para>
		///</summary>
        public const uint NumberOfCompletedSubOperations = 4129;

		///<summary>
		///<para> (0000,1022) Number of Failed Sub-operations </para>
		///<para> VR: US VM=1 </para>
		///</summary>
        public const uint NumberOfFailedSubOperations = 4130;

		///<summary>
		///<para> (0000,1023) Number of Warning Sub-operations </para>
		///<para> VR: US VM=1 </para>
		///</summary>
        public const uint NumberOfWarningSubOperations = 4131;

		///<summary>
		///<para> (0000,1030) Move Originator Application Entity Title </para>
		///<para> VR: AE VM=1 </para>
		///</summary>
        public const uint MoveOriginatorApplicationEntityTitle = 4144;

		///<summary>
		///<para> (0000,1031) Move Originator Message ID </para>
		///<para> VR: US VM=1 </para>
		///</summary>
        public const uint MoveOriginatorMessageId = 4145;

		///<summary>
		///<para> (0000,0001) Command Length to End (RETIRED) </para>
		///<para> VR: UL VM=1 </para>
		///</summary>
        public const uint CommandLengthToEndRetired = 1;

		///<summary>
		///<para> (0000,0010) Command Recognition Code (RETIRED) </para>
		///<para> VR: SH VM=1 </para>
		///</summary>
        public const uint CommandRecognitionCodeRetired = 16;

		///<summary>
		///<para> (0000,0200) Initiator (RETIRED) </para>
		///<para> VR: AE VM=1 </para>
		///</summary>
        public const uint InitiatorRetired = 512;

		///<summary>
		///<para> (0000,0300) Receiver (RETIRED) </para>
		///<para> VR: AE VM=1 </para>
		///</summary>
        public const uint ReceiverRetired = 768;

		///<summary>
		///<para> (0000,0400) Find Location (RETIRED) </para>
		///<para> VR: AE VM=1 </para>
		///</summary>
        public const uint FindLocationRetired = 1024;

		///<summary>
		///<para> (0000,0850) Number of Matches (RETIRED) </para>
		///<para> VR: US VM=1 </para>
		///</summary>
        public const uint NumberOfMatchesRetired = 2128;

		///<summary>
		///<para> (0000,0860) Response Sequence Number (RETIRED) </para>
		///<para> VR: US VM=1 </para>
		///</summary>
        public const uint ResponseSequenceNumberRetired = 2144;

		///<summary>
		///<para> (0000,4000) Dialog Receiver (RETIRED) </para>
		///<para> VR: LT VM=1 </para>
		///</summary>
        public const uint DialogReceiverRetired = 16384;

		///<summary>
		///<para> (0000,4010) Terminal Type (RETIRED) </para>
		///<para> VR: LT VM=1 </para>
		///</summary>
        public const uint TerminalTypeRetired = 16400;

		///<summary>
		///<para> (0000,5010) Message Set ID (RETIRED) </para>
		///<para> VR: SH VM=1 </para>
		///</summary>
        public const uint MessageSetIdRetired = 20496;

		///<summary>
		///<para> (0000,5020) End Message ID (RETIRED) </para>
		///<para> VR: SH VM=1 </para>
		///</summary>
        public const uint EndMessageIdRetired = 20512;

		///<summary>
		///<para> (0000,5110) Display Format (RETIRED) </para>
		///<para> VR: LT VM=1 </para>
		///</summary>
        public const uint DisplayFormatRetired = 20752;

		///<summary>
		///<para> (0000,5120) Page Position ID (RETIRED) </para>
		///<para> VR: LT VM=1 </para>
		///</summary>
        public const uint PagePositionIdRetired = 20768;

		///<summary>
		///<para> (0000,5130) Text Format ID (RETIRED) </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint TextFormatIdRetired = 20784;

		///<summary>
		///<para> (0000,5140) Normal/Reverse (RETIRED) </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint NormalReverseRetired = 20800;

		///<summary>
		///<para> (0000,5150) Add Gray Scale (RETIRED) </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint AddGrayScaleRetired = 20816;

		///<summary>
		///<para> (0000,5160) Borders (RETIRED) </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint BordersRetired = 20832;

		///<summary>
		///<para> (0000,5170) Copies (RETIRED) </para>
		///<para> VR: IS VM=1 </para>
		///</summary>
        public const uint CopiesRetired = 20848;

		///<summary>
		///<para> (0000,5180) Command Magnification Type (RETIRED) </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint CommandMagnificationTypeRetired = 20864;

		///<summary>
		///<para> (0000,5190) Erase (RETIRED) </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint EraseRetired = 20880;

		///<summary>
		///<para> (0000,51A0) Print (RETIRED) </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint PrintRetired = 20896;

		///<summary>
		///<para> (0000,51B0) Overlays (RETIRED) </para>
		///<para> VR: US VM=1-n </para>
		///</summary>
        public const uint OverlaysRetired = 20912;

		///<summary>
		///<para> (0002,0000) File Meta Information Group Length </para>
		///<para> VR: UL VM=1 </para>
		///</summary>
        public const uint FileMetaInformationGroupLength = 131072;

		///<summary>
		///<para> (0002,0001) File Meta Information Version </para>
		///<para> VR: OB VM=1 </para>
		///</summary>
        public const uint FileMetaInformationVersion = 131073;

		///<summary>
		///<para> (0002,0002) Media Storage SOP Class UID </para>
		///<para> VR: UI VM=1 </para>
		///</summary>
        public const uint MediaStorageSopClassUid = 131074;

		///<summary>
		///<para> (0002,0003) Media Storage SOP Instance UID </para>
		///<para> VR: UI VM=1 </para>
		///</summary>
        public const uint MediaStorageSopInstanceUid = 131075;

		///<summary>
		///<para> (0002,0010) Transfer Syntax UID </para>
		///<para> VR: UI VM=1 </para>
		///</summary>
        public const uint TransferSyntaxUid = 131088;

		///<summary>
		///<para> (0002,0012) Implementation Class UID </para>
		///<para> VR: UI VM=1 </para>
		///</summary>
        public const uint ImplementationClassUid = 131090;

		///<summary>
		///<para> (0002,0013) Implementation Version Name </para>
		///<para> VR: SH VM=1 </para>
		///</summary>
        public const uint ImplementationVersionName = 131091;

		///<summary>
		///<para> (0002,0016) Source Application Entity Title </para>
		///<para> VR: AE VM=1 </para>
		///</summary>
        public const uint SourceApplicationEntityTitle = 131094;

		///<summary>
		///<para> (0002,0017) Sending Application Entity Title </para>
		///<para> VR: AE VM=1 </para>
		///</summary>
        public const uint SendingApplicationEntityTitle = 131095;

		///<summary>
		///<para> (0002,0018) Receiving Application Entity Title </para>
		///<para> VR: AE VM=1 </para>
		///</summary>
        public const uint ReceivingApplicationEntityTitle = 131096;

		///<summary>
		///<para> (0002,0100) Private Information Creator UID </para>
		///<para> VR: UI VM=1 </para>
		///</summary>
        public const uint PrivateInformationCreatorUid = 131328;

		///<summary>
		///<para> (0002,0102) Private Information </para>
		///<para> VR: OB VM=1 </para>
		///</summary>
        public const uint PrivateInformation = 131330;

		///<summary>
		///<para> (0004,1130) File-set ID </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint FileSetId = 266544;

		///<summary>
		///<para> (0004,1141) File-set Descriptor File ID </para>
		///<para> VR: CS VM=1-8 </para>
		///</summary>
        public const uint FileSetDescriptorFileId = 266561;

		///<summary>
		///<para> (0004,1142) Specific Character Set of File-set Descriptor File </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint SpecificCharacterSetOfFileSetDescriptorFile = 266562;

		///<summary>
		///<para> (0004,1200) Offset of the First Directory Record of the Root Directory Entity </para>
		///<para> VR: UL VM=1 </para>
		///</summary>
        public const uint OffsetOfTheFirstDirectoryRecordOfTheRootDirectoryEntity = 266752;

		///<summary>
		///<para> (0004,1202) Offset of the Last Directory Record of the Root Directory Entity </para>
		///<para> VR: UL VM=1 </para>
		///</summary>
        public const uint OffsetOfTheLastDirectoryRecordOfTheRootDirectoryEntity = 266754;

		///<summary>
		///<para> (0004,1212) File-set Consistency Flag </para>
		///<para> VR: US VM=1 </para>
		///</summary>
        public const uint FileSetConsistencyFlag = 266770;

		///<summary>
		///<para> (0004,1220) Directory Record Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint DirectoryRecordSequence = 266784;

		///<summary>
		///<para> (0004,1400) Offset of the Next Directory Record </para>
		///<para> VR: UL VM=1 </para>
		///</summary>
        public const uint OffsetOfTheNextDirectoryRecord = 267264;

		///<summary>
		///<para> (0004,1410) Record In-use Flag </para>
		///<para> VR: US VM=1 </para>
		///</summary>
        public const uint RecordInUseFlag = 267280;

		///<summary>
		///<para> (0004,1420) Offset of Referenced Lower-Level Directory Entity </para>
		///<para> VR: UL VM=1 </para>
		///</summary>
        public const uint OffsetOfReferencedLowerLevelDirectoryEntity = 267296;

		///<summary>
		///<para> (0004,1430) Directory Record Type </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint DirectoryRecordType = 267312;

		///<summary>
		///<para> (0004,1432) Private Record UID </para>
		///<para> VR: UI VM=1 </para>
		///</summary>
        public const uint PrivateRecordUid = 267314;

		///<summary>
		///<para> (0004,1500) Referenced File ID </para>
		///<para> VR: CS VM=1-8 </para>
		///</summary>
        public const uint ReferencedFileId = 267520;

		///<summary>
		///<para> (0004,1504) MRDR Directory Record Offset (RETIRED) </para>
		///<para> VR: UL VM=1 </para>
		///</summary>
        public const uint MrdrDirectoryRecordOffsetRetired = 267524;

		///<summary>
		///<para> (0004,1510) Referenced SOP Class UID in File </para>
		///<para> VR: UI VM=1 </para>
		///</summary>
        public const uint ReferencedSopClassUidInFile = 267536;

		///<summary>
		///<para> (0004,1511) Referenced SOP Instance UID in File </para>
		///<para> VR: UI VM=1 </para>
		///</summary>
        public const uint ReferencedSopInstanceUidInFile = 267537;

		///<summary>
		///<para> (0004,1512) Referenced Transfer Syntax UID in File </para>
		///<para> VR: UI VM=1 </para>
		///</summary>
        public const uint ReferencedTransferSyntaxUidInFile = 267538;

		///<summary>
		///<para> (0004,151A) Referenced Related General SOP Class UID in File </para>
		///<para> VR: UI VM=1-n </para>
		///</summary>
        public const uint ReferencedRelatedGeneralSopClassUidInFile = 267546;

		///<summary>
		///<para> (0004,1600) Number of References (RETIRED) </para>
		///<para> VR: UL VM=1 </para>
		///</summary>
        public const uint NumberOfReferencesRetired = 267776;

		///<summary>
		///<para> (0008,0001) Length to End (RETIRED) </para>
		///<para> VR: UL VM=1 </para>
		///</summary>
        public const uint LengthToEndRetired = 524289;

		///<summary>
		///<para> (0008,0005) Specific Character Set </para>
		///<para> VR: CS VM=1-n </para>
		///</summary>
        public const uint SpecificCharacterSet = 524293;

		///<summary>
		///<para> (0008,0006) Language Code Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint LanguageCodeSequence = 524294;

		///<summary>
		///<para> (0008,0008) Image Type </para>
		///<para> VR: CS VM=2-n </para>
		///</summary>
        public const uint ImageType = 524296;

		///<summary>
		///<para> (0008,0010) Recognition Code (RETIRED) </para>
		///<para> VR: SH VM=1 </para>
		///</summary>
        public const uint RecognitionCodeRetired = 524304;

		///<summary>
		///<para> (0008,0012) Instance Creation Date </para>
		///<para> VR: DA VM=1 </para>
		///</summary>
        public const uint InstanceCreationDate = 524306;

		///<summary>
		///<para> (0008,0013) Instance Creation Time </para>
		///<para> VR: TM VM=1 </para>
		///</summary>
        public const uint InstanceCreationTime = 524307;

		///<summary>
		///<para> (0008,0014) Instance Creator UID </para>
		///<para> VR: UI VM=1 </para>
		///</summary>
        public const uint InstanceCreatorUid = 524308;

		///<summary>
		///<para> (0008,0015) Instance Coercion DateTime </para>
		///<para> VR: DT VM=1 </para>
		///</summary>
        public const uint InstanceCoercionDatetime = 524309;

		///<summary>
		///<para> (0008,0016) SOP Class UID </para>
		///<para> VR: UI VM=1 </para>
		///</summary>
        public const uint SopClassUid = 524310;

		///<summary>
		///<para> (0008,0018) SOP Instance UID </para>
		///<para> VR: UI VM=1 </para>
		///</summary>
        public const uint SopInstanceUid = 524312;

		///<summary>
		///<para> (0008,001A) Related General SOP Class UID </para>
		///<para> VR: UI VM=1-n </para>
		///</summary>
        public const uint RelatedGeneralSopClassUid = 524314;

		///<summary>
		///<para> (0008,001B) Original Specialized SOP Class UID </para>
		///<para> VR: UI VM=1 </para>
		///</summary>
        public const uint OriginalSpecializedSopClassUid = 524315;

		///<summary>
		///<para> (0008,0020) Study Date </para>
		///<para> VR: DA VM=1 </para>
		///</summary>
        public const uint StudyDate = 524320;

		///<summary>
		///<para> (0008,0021) Series Date </para>
		///<para> VR: DA VM=1 </para>
		///</summary>
        public const uint SeriesDate = 524321;

		///<summary>
		///<para> (0008,0022) Acquisition Date </para>
		///<para> VR: DA VM=1 </para>
		///</summary>
        public const uint AcquisitionDate = 524322;

		///<summary>
		///<para> (0008,0023) Content Date </para>
		///<para> VR: DA VM=1 </para>
		///</summary>
        public const uint ContentDate = 524323;

		///<summary>
		///<para> (0008,0024) Overlay Date (RETIRED) </para>
		///<para> VR: DA VM=1 </para>
		///</summary>
        public const uint OverlayDateRetired = 524324;

		///<summary>
		///<para> (0008,0025) Curve Date (RETIRED) </para>
		///<para> VR: DA VM=1 </para>
		///</summary>
        public const uint CurveDateRetired = 524325;

		///<summary>
		///<para> (0008,002A) Acquisition DateTime </para>
		///<para> VR: DT VM=1 </para>
		///</summary>
        public const uint AcquisitionDatetime = 524330;

		///<summary>
		///<para> (0008,0030) Study Time </para>
		///<para> VR: TM VM=1 </para>
		///</summary>
        public const uint StudyTime = 524336;

		///<summary>
		///<para> (0008,0031) Series Time </para>
		///<para> VR: TM VM=1 </para>
		///</summary>
        public const uint SeriesTime = 524337;

		///<summary>
		///<para> (0008,0032) Acquisition Time </para>
		///<para> VR: TM VM=1 </para>
		///</summary>
        public const uint AcquisitionTime = 524338;

		///<summary>
		///<para> (0008,0033) Content Time </para>
		///<para> VR: TM VM=1 </para>
		///</summary>
        public const uint ContentTime = 524339;

		///<summary>
		///<para> (0008,0034) Overlay Time (RETIRED) </para>
		///<para> VR: TM VM=1 </para>
		///</summary>
        public const uint OverlayTimeRetired = 524340;

		///<summary>
		///<para> (0008,0035) Curve Time (RETIRED) </para>
		///<para> VR: TM VM=1 </para>
		///</summary>
        public const uint CurveTimeRetired = 524341;

		///<summary>
		///<para> (0008,0040) Data Set Type (RETIRED) </para>
		///<para> VR: US VM=1 </para>
		///</summary>
        public const uint DataSetTypeRetired = 524352;

		///<summary>
		///<para> (0008,0041) Data Set Subtype (RETIRED) </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint DataSetSubtypeRetired = 524353;

		///<summary>
		///<para> (0008,0042) Nuclear Medicine Series Type (RETIRED) </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint NuclearMedicineSeriesTypeRetired = 524354;

		///<summary>
		///<para> (0008,0050) Accession Number </para>
		///<para> VR: SH VM=1 </para>
		///</summary>
        public const uint AccessionNumber = 524368;

		///<summary>
		///<para> (0008,0051) Issuer of Accession Number Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint IssuerOfAccessionNumberSequence = 524369;

		///<summary>
		///<para> (0008,0052) Query/Retrieve Level </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint QueryRetrieveLevel = 524370;

		///<summary>
		///<para> (0008,0053) Query/Retrieve View </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint QueryRetrieveView = 524371;

		///<summary>
		///<para> (0008,0054) Retrieve AE Title </para>
		///<para> VR: AE VM=1-n </para>
		///</summary>
        public const uint RetrieveAeTitle = 524372;

		///<summary>
		///<para> (0008,0055) Station  AE Title </para>
		///<para> VR: AE VM=1 </para>
		///</summary>
        public const uint StationAeTitle = 524373;

		///<summary>
		///<para> (0008,0056) Instance Availability </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint InstanceAvailability = 524374;

		///<summary>
		///<para> (0008,0058) Failed SOP Instance UID List </para>
		///<para> VR: UI VM=1-n </para>
		///</summary>
        public const uint FailedSopInstanceUidList = 524376;

		///<summary>
		///<para> (0008,0060) Modality </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint Modality = 524384;

		///<summary>
		///<para> (0008,0061) Modalities in Study </para>
		///<para> VR: CS VM=1-n </para>
		///</summary>
        public const uint ModalitiesInStudy = 524385;

		///<summary>
		///<para> (0008,0062) SOP Classes in Study </para>
		///<para> VR: UI VM=1-n </para>
		///</summary>
        public const uint SopClassesInStudy = 524386;

		///<summary>
		///<para> (0008,0064) Conversion Type </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint ConversionType = 524388;

		///<summary>
		///<para> (0008,0068) Presentation Intent Type </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint PresentationIntentType = 524392;

		///<summary>
		///<para> (0008,0070) Manufacturer </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint Manufacturer = 524400;

		///<summary>
		///<para> (0008,0080) Institution Name </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint InstitutionName = 524416;

		///<summary>
		///<para> (0008,0081) Institution Address </para>
		///<para> VR: ST VM=1 </para>
		///</summary>
        public const uint InstitutionAddress = 524417;

		///<summary>
		///<para> (0008,0082) Institution Code Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint InstitutionCodeSequence = 524418;

		///<summary>
		///<para> (0008,0090) Referring Physician's Name </para>
		///<para> VR: PN VM=1 </para>
		///</summary>
        public const uint ReferringPhysiciansName = 524432;

		///<summary>
		///<para> (0008,0092) Referring Physician's Address </para>
		///<para> VR: ST VM=1 </para>
		///</summary>
        public const uint ReferringPhysiciansAddress = 524434;

		///<summary>
		///<para> (0008,0094) Referring Physician's Telephone Numbers </para>
		///<para> VR: SH VM=1-n </para>
		///</summary>
        public const uint ReferringPhysiciansTelephoneNumbers = 524436;

		///<summary>
		///<para> (0008,0096) Referring Physician Identification Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint ReferringPhysicianIdentificationSequence = 524438;

		///<summary>
		///<para> (0008,009C) Consulting Physician's Name </para>
		///<para> VR: PN VM=1-n </para>
		///</summary>
        public const uint ConsultingPhysiciansName = 524444;

		///<summary>
		///<para> (0008,009D) Consulting Physician Identification Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint ConsultingPhysicianIdentificationSequence = 524445;

		///<summary>
		///<para> (0008,0100) Code Value </para>
		///<para> VR: SH VM=1 </para>
		///</summary>
        public const uint CodeValue = 524544;

		///<summary>
		///<para> (0008,0101) Extended Code Value </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint ExtendedCodeValue = 524545;

		///<summary>
		///<para> (0008,0102) Coding Scheme Designator </para>
		///<para> VR: SH VM=1 </para>
		///</summary>
        public const uint CodingSchemeDesignator = 524546;

		///<summary>
		///<para> (0008,0103) Coding Scheme Version </para>
		///<para> VR: SH VM=1 </para>
		///</summary>
        public const uint CodingSchemeVersion = 524547;

		///<summary>
		///<para> (0008,0104) Code Meaning </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint CodeMeaning = 524548;

		///<summary>
		///<para> (0008,0105) Mapping Resource </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint MappingResource = 524549;

		///<summary>
		///<para> (0008,0106) Context Group Version </para>
		///<para> VR: DT VM=1 </para>
		///</summary>
        public const uint ContextGroupVersion = 524550;

		///<summary>
		///<para> (0008,0107) Context Group Local Version </para>
		///<para> VR: DT VM=1 </para>
		///</summary>
        public const uint ContextGroupLocalVersion = 524551;

		///<summary>
		///<para> (0008,0108) Extended Code Meaning </para>
		///<para> VR: LT VM=1 </para>
		///</summary>
        public const uint ExtendedCodeMeaning = 524552;

		///<summary>
		///<para> (0008,010B) Context Group Extension Flag </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint ContextGroupExtensionFlag = 524555;

		///<summary>
		///<para> (0008,010C) Coding Scheme UID </para>
		///<para> VR: UI VM=1 </para>
		///</summary>
        public const uint CodingSchemeUid = 524556;

		///<summary>
		///<para> (0008,010D) Context Group Extension Creator UID </para>
		///<para> VR: UI VM=1 </para>
		///</summary>
        public const uint ContextGroupExtensionCreatorUid = 524557;

		///<summary>
		///<para> (0008,010F) Context Identifier </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint ContextIdentifier = 524559;

		///<summary>
		///<para> (0008,0110) Coding Scheme Identification Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint CodingSchemeIdentificationSequence = 524560;

		///<summary>
		///<para> (0008,0112) Coding Scheme Registry </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint CodingSchemeRegistry = 524562;

		///<summary>
		///<para> (0008,0114) Coding Scheme External ID </para>
		///<para> VR: ST VM=1 </para>
		///</summary>
        public const uint CodingSchemeExternalId = 524564;

		///<summary>
		///<para> (0008,0115) Coding Scheme Name </para>
		///<para> VR: ST VM=1 </para>
		///</summary>
        public const uint CodingSchemeName = 524565;

		///<summary>
		///<para> (0008,0116) Coding Scheme Responsible Organization </para>
		///<para> VR: ST VM=1 </para>
		///</summary>
        public const uint CodingSchemeResponsibleOrganization = 524566;

		///<summary>
		///<para> (0008,0117) Context UID </para>
		///<para> VR: UI VM=1 </para>
		///</summary>
        public const uint ContextUid = 524567;

		///<summary>
		///<para> (0008,0118) Mapping Resource UID </para>
		///<para> VR: UI VM=1 </para>
		///</summary>
        public const uint MappingResourceUid = 524568;

		///<summary>
		///<para> (0008,0119) Long Code Value </para>
		///<para> VR: UC VM=1 </para>
		///</summary>
        public const uint LongCodeValue = 524569;

		///<summary>
		///<para> (0008,0120) URN Code Value </para>
		///<para> VR: UR VM=1 </para>
		///</summary>
        public const uint UrnCodeValue = 524576;

		///<summary>
		///<para> (0008,0121) Equivalent Code Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint EquivalentCodeSequence = 524577;

		///<summary>
		///<para> (0008,0122) Mapping Resource Name </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint MappingResourceName = 524578;

		///<summary>
		///<para> (0008,0123) Context Group Identification Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint ContextGroupIdentificationSequence = 524579;

		///<summary>
		///<para> (0008,0124) Mapping Resource Identification Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint MappingResourceIdentificationSequence = 524580;

		///<summary>
		///<para> (0008,0201) Timezone Offset From UTC </para>
		///<para> VR: SH VM=1 </para>
		///</summary>
        public const uint TimezoneOffsetFromUtc = 524801;

		///<summary>
		///<para> (0008,0220) Responsible Group Code Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint ResponsibleGroupCodeSequence = 524832;

		///<summary>
		///<para> (0008,0221) Equipment Modality </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint EquipmentModality = 524833;

		///<summary>
		///<para> (0008,0222) Manufacturer's Related Model Group </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint ManufacturersRelatedModelGroup = 524834;

		///<summary>
		///<para> (0008,0300) Private Data Element Characteristics Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint PrivateDataElementCharacteristicsSequence = 525056;

		///<summary>
		///<para> (0008,0301) Private Group Reference </para>
		///<para> VR: US VM=1 </para>
		///</summary>
        public const uint PrivateGroupReference = 525057;

		///<summary>
		///<para> (0008,0302) Private Creator Reference </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint PrivateCreatorReference = 525058;

		///<summary>
		///<para> (0008,0303) Block Identifying Information Status </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint BlockIdentifyingInformationStatus = 525059;

		///<summary>
		///<para> (0008,0304) Nonidentifying Private Elements </para>
		///<para> VR: US VM=1-n </para>
		///</summary>
        public const uint NonidentifyingPrivateElements = 525060;

		///<summary>
		///<para> (0008,0306) Identifying Private Elements </para>
		///<para> VR: US VM=1-n </para>
		///</summary>
        public const uint IdentifyingPrivateElements = 525062;

		///<summary>
		///<para> (0008,0305) Deidentification Action Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint DeidentificationActionSequence = 525061;

		///<summary>
		///<para> (0008,0307) Deidentification Action </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint DeidentificationAction = 525063;

		///<summary>
		///<para> (0008,0308) Private Data Element </para>
		///<para> VR: US VM=1 </para>
		///</summary>
        public const uint PrivateDataElement = 525064;

		///<summary>
		///<para> (0008,0309) Private Data Element Value Multiplicity </para>
		///<para> VR: UL VM=1-3 </para>
		///</summary>
        public const uint PrivateDataElementValueMultiplicity = 525065;

		///<summary>
		///<para> (0008,030A) Private Data Element Value Representation </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint PrivateDataElementValueRepresentation = 525066;

		///<summary>
		///<para> (0008,030B) Private Data Element Number of Items </para>
		///<para> VR: UL VM=1-2 </para>
		///</summary>
        public const uint PrivateDataElementNumberOfItems = 525067;

		///<summary>
		///<para> (0008,030C) Private Data Element Name </para>
		///<para> VR: UC VM=1 </para>
		///</summary>
        public const uint PrivateDataElementName = 525068;

		///<summary>
		///<para> (0008,030D) Private Data Element Keyword </para>
		///<para> VR: UC VM=1 </para>
		///</summary>
        public const uint PrivateDataElementKeyword = 525069;

		///<summary>
		///<para> (0008,030E) Private Data Element Description </para>
		///<para> VR: UT VM=1 </para>
		///</summary>
        public const uint PrivateDataElementDescription = 525070;

		///<summary>
		///<para> (0008,030F) Private Data Element Encoding </para>
		///<para> VR: UT VM=1 </para>
		///</summary>
        public const uint PrivateDataElementEncoding = 525071;

		///<summary>
		///<para> (0008,0310) Private Data Element Definition Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint PrivateDataElementDefinitionSequence = 525072;

		///<summary>
		///<para> (0008,1000) Network ID (RETIRED) </para>
		///<para> VR: AE VM=1 </para>
		///</summary>
        public const uint NetworkIdRetired = 528384;

		///<summary>
		///<para> (0008,1010) Station Name </para>
		///<para> VR: SH VM=1 </para>
		///</summary>
        public const uint StationName = 528400;

		///<summary>
		///<para> (0008,1030) Study Description </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint StudyDescription = 528432;

		///<summary>
		///<para> (0008,1032) Procedure Code Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint ProcedureCodeSequence = 528434;

		///<summary>
		///<para> (0008,103E) Series Description </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint SeriesDescription = 528446;

		///<summary>
		///<para> (0008,103F) Series Description Code Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint SeriesDescriptionCodeSequence = 528447;

		///<summary>
		///<para> (0008,1040) Institutional Department Name </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint InstitutionalDepartmentName = 528448;

		///<summary>
		///<para> (0008,1048) Physician(s) of Record </para>
		///<para> VR: PN VM=1-n </para>
		///</summary>
        public const uint PhysiciansOfRecord = 528456;

		///<summary>
		///<para> (0008,1049) Physician(s) of Record Identification Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint PhysiciansOfRecordIdentificationSequence = 528457;

		///<summary>
		///<para> (0008,1050) Performing Physician's Name </para>
		///<para> VR: PN VM=1-n </para>
		///</summary>
        public const uint PerformingPhysiciansName = 528464;

		///<summary>
		///<para> (0008,1052) Performing Physician Identification Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint PerformingPhysicianIdentificationSequence = 528466;

		///<summary>
		///<para> (0008,1060) Name of Physician(s) Reading Study </para>
		///<para> VR: PN VM=1-n </para>
		///</summary>
        public const uint NameOfPhysiciansReadingStudy = 528480;

		///<summary>
		///<para> (0008,1062) Physician(s) Reading Study Identification Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint PhysiciansReadingStudyIdentificationSequence = 528482;

		///<summary>
		///<para> (0008,1070) Operators' Name </para>
		///<para> VR: PN VM=1-n </para>
		///</summary>
        public const uint OperatorsName = 528496;

		///<summary>
		///<para> (0008,1072) Operator Identification Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint OperatorIdentificationSequence = 528498;

		///<summary>
		///<para> (0008,1080) Admitting Diagnoses Description </para>
		///<para> VR: LO VM=1-n </para>
		///</summary>
        public const uint AdmittingDiagnosesDescription = 528512;

		///<summary>
		///<para> (0008,1084) Admitting Diagnoses Code Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint AdmittingDiagnosesCodeSequence = 528516;

		///<summary>
		///<para> (0008,1090) Manufacturer's Model Name </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint ManufacturersModelName = 528528;

		///<summary>
		///<para> (0008,1100) Referenced Results Sequence (RETIRED) </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint ReferencedResultsSequenceRetired = 528640;

		///<summary>
		///<para> (0008,1110) Referenced Study Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint ReferencedStudySequence = 528656;

		///<summary>
		///<para> (0008,1111) Referenced Performed Procedure Step Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint ReferencedPerformedProcedureStepSequence = 528657;

		///<summary>
		///<para> (0008,1115) Referenced Series Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint ReferencedSeriesSequence = 528661;

		///<summary>
		///<para> (0008,1120) Referenced Patient Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint ReferencedPatientSequence = 528672;

		///<summary>
		///<para> (0008,1125) Referenced Visit Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint ReferencedVisitSequence = 528677;

		///<summary>
		///<para> (0008,1130) Referenced Overlay Sequence (RETIRED) </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint ReferencedOverlaySequenceRetired = 528688;

		///<summary>
		///<para> (0008,1134) Referenced Stereometric Instance Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint ReferencedStereometricInstanceSequence = 528692;

		///<summary>
		///<para> (0008,113A) Referenced Waveform Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint ReferencedWaveformSequence = 528698;

		///<summary>
		///<para> (0008,1140) Referenced Image Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint ReferencedImageSequence = 528704;

		///<summary>
		///<para> (0008,1145) Referenced Curve Sequence (RETIRED) </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint ReferencedCurveSequenceRetired = 528709;

		///<summary>
		///<para> (0008,114A) Referenced Instance Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint ReferencedInstanceSequence = 528714;

		///<summary>
		///<para> (0008,114B) Referenced Real World Value Mapping Instance Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint ReferencedRealWorldValueMappingInstanceSequence = 528715;

		///<summary>
		///<para> (0008,1150) Referenced SOP Class UID </para>
		///<para> VR: UI VM=1 </para>
		///</summary>
        public const uint ReferencedSopClassUid = 528720;

		///<summary>
		///<para> (0008,1155) Referenced SOP Instance UID </para>
		///<para> VR: UI VM=1 </para>
		///</summary>
        public const uint ReferencedSopInstanceUid = 528725;

		///<summary>
		///<para> (0008,115A) SOP Classes Supported </para>
		///<para> VR: UI VM=1-n </para>
		///</summary>
        public const uint SopClassesSupported = 528730;

		///<summary>
		///<para> (0008,1160) Referenced Frame Number </para>
		///<para> VR: IS VM=1-n </para>
		///</summary>
        public const uint ReferencedFrameNumber = 528736;

		///<summary>
		///<para> (0008,1161) Simple Frame List </para>
		///<para> VR: UL VM=1-n </para>
		///</summary>
        public const uint SimpleFrameList = 528737;

		///<summary>
		///<para> (0008,1162) Calculated Frame List </para>
		///<para> VR: UL VM=3-3n </para>
		///</summary>
        public const uint CalculatedFrameList = 528738;

		///<summary>
		///<para> (0008,1163) Time Range </para>
		///<para> VR: FD VM=2 </para>
		///</summary>
        public const uint TimeRange = 528739;

		///<summary>
		///<para> (0008,1164) Frame Extraction Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint FrameExtractionSequence = 528740;

		///<summary>
		///<para> (0008,1167) Multi-frame Source SOP Instance UID </para>
		///<para> VR: UI VM=1 </para>
		///</summary>
        public const uint MultiFrameSourceSopInstanceUid = 528743;

		///<summary>
		///<para> (0008,1190) Retrieve URL </para>
		///<para> VR: UR VM=1 </para>
		///</summary>
        public const uint RetrieveUrl = 528784;

		///<summary>
		///<para> (0008,1195) Transaction UID </para>
		///<para> VR: UI VM=1 </para>
		///</summary>
        public const uint TransactionUid = 528789;

		///<summary>
		///<para> (0008,1196) Warning Reason </para>
		///<para> VR: US VM=1 </para>
		///</summary>
        public const uint WarningReason = 528790;

		///<summary>
		///<para> (0008,1197) Failure Reason </para>
		///<para> VR: US VM=1 </para>
		///</summary>
        public const uint FailureReason = 528791;

		///<summary>
		///<para> (0008,1198) Failed SOP Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint FailedSopSequence = 528792;

		///<summary>
		///<para> (0008,1199) Referenced SOP Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint ReferencedSopSequence = 528793;

		///<summary>
		///<para> (0008,119A) Other Failures Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint OtherFailuresSequence = 528794;

		///<summary>
		///<para> (0008,1200) Studies Containing Other Referenced Instances Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint StudiesContainingOtherReferencedInstancesSequence = 528896;

		///<summary>
		///<para> (0008,1250) Related Series Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint RelatedSeriesSequence = 528976;

		///<summary>
		///<para> (0008,2110) Lossy Image Compression (Retired) (RETIRED) </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint LossyImageCompressionRetiredRetired = 532752;

		///<summary>
		///<para> (0008,2111) Derivation Description </para>
		///<para> VR: ST VM=1 </para>
		///</summary>
        public const uint DerivationDescription = 532753;

		///<summary>
		///<para> (0008,2112) Source Image Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint SourceImageSequence = 532754;

		///<summary>
		///<para> (0008,2120) Stage Name </para>
		///<para> VR: SH VM=1 </para>
		///</summary>
        public const uint StageName = 532768;

		///<summary>
		///<para> (0008,2122) Stage Number </para>
		///<para> VR: IS VM=1 </para>
		///</summary>
        public const uint StageNumber = 532770;

		///<summary>
		///<para> (0008,2124) Number of Stages </para>
		///<para> VR: IS VM=1 </para>
		///</summary>
        public const uint NumberOfStages = 532772;

		///<summary>
		///<para> (0008,2127) View Name </para>
		///<para> VR: SH VM=1 </para>
		///</summary>
        public const uint ViewName = 532775;

		///<summary>
		///<para> (0008,2128) View Number </para>
		///<para> VR: IS VM=1 </para>
		///</summary>
        public const uint ViewNumber = 532776;

		///<summary>
		///<para> (0008,2129) Number of Event Timers </para>
		///<para> VR: IS VM=1 </para>
		///</summary>
        public const uint NumberOfEventTimers = 532777;

		///<summary>
		///<para> (0008,212A) Number of Views in Stage </para>
		///<para> VR: IS VM=1 </para>
		///</summary>
        public const uint NumberOfViewsInStage = 532778;

		///<summary>
		///<para> (0008,2130) Event Elapsed Time(s) </para>
		///<para> VR: DS VM=1-n </para>
		///</summary>
        public const uint EventElapsedTimes = 532784;

		///<summary>
		///<para> (0008,2132) Event Timer Name(s) </para>
		///<para> VR: LO VM=1-n </para>
		///</summary>
        public const uint EventTimerNames = 532786;

		///<summary>
		///<para> (0008,2133) Event Timer Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint EventTimerSequence = 532787;

		///<summary>
		///<para> (0008,2134) Event Time Offset </para>
		///<para> VR: FD VM=1 </para>
		///</summary>
        public const uint EventTimeOffset = 532788;

		///<summary>
		///<para> (0008,2135) Event Code Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint EventCodeSequence = 532789;

		///<summary>
		///<para> (0008,2142) Start Trim </para>
		///<para> VR: IS VM=1 </para>
		///</summary>
        public const uint StartTrim = 532802;

		///<summary>
		///<para> (0008,2143) Stop Trim </para>
		///<para> VR: IS VM=1 </para>
		///</summary>
        public const uint StopTrim = 532803;

		///<summary>
		///<para> (0008,2144) Recommended Display Frame Rate </para>
		///<para> VR: IS VM=1 </para>
		///</summary>
        public const uint RecommendedDisplayFrameRate = 532804;

		///<summary>
		///<para> (0008,2200) Transducer Position (RETIRED) </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint TransducerPositionRetired = 532992;

		///<summary>
		///<para> (0008,2204) Transducer Orientation (RETIRED) </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint TransducerOrientationRetired = 532996;

		///<summary>
		///<para> (0008,2208) Anatomic Structure (RETIRED) </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint AnatomicStructureRetired = 533000;

		///<summary>
		///<para> (0008,2218) Anatomic Region Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint AnatomicRegionSequence = 533016;

		///<summary>
		///<para> (0008,2220) Anatomic Region Modifier Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint AnatomicRegionModifierSequence = 533024;

		///<summary>
		///<para> (0008,2228) Primary Anatomic Structure Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint PrimaryAnatomicStructureSequence = 533032;

		///<summary>
		///<para> (0008,2229) Anatomic Structure, Space or Region Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint AnatomicStructureSpaceOrRegionSequence = 533033;

		///<summary>
		///<para> (0008,2230) Primary Anatomic Structure Modifier Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint PrimaryAnatomicStructureModifierSequence = 533040;

		///<summary>
		///<para> (0008,2240) Transducer Position Sequence (RETIRED) </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint TransducerPositionSequenceRetired = 533056;

		///<summary>
		///<para> (0008,2242) Transducer Position Modifier Sequence (RETIRED) </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint TransducerPositionModifierSequenceRetired = 533058;

		///<summary>
		///<para> (0008,2244) Transducer Orientation Sequence (RETIRED) </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint TransducerOrientationSequenceRetired = 533060;

		///<summary>
		///<para> (0008,2246) Transducer Orientation Modifier Sequence (RETIRED) </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint TransducerOrientationModifierSequenceRetired = 533062;

		///<summary>
		///<para> (0008,2251) Anatomic Structure Space Or Region Code Sequence (Trial) (RETIRED) </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint AnatomicStructureSpaceOrRegionCodeSequenceTrialRetired = 533073;

		///<summary>
		///<para> (0008,2253) Anatomic Portal Of Entrance Code Sequence (Trial) (RETIRED) </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint AnatomicPortalOfEntranceCodeSequenceTrialRetired = 533075;

		///<summary>
		///<para> (0008,2255) Anatomic Approach Direction Code Sequence (Trial) (RETIRED) </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint AnatomicApproachDirectionCodeSequenceTrialRetired = 533077;

		///<summary>
		///<para> (0008,2256) Anatomic Perspective Description (Trial) (RETIRED) </para>
		///<para> VR: ST VM=1 </para>
		///</summary>
        public const uint AnatomicPerspectiveDescriptionTrialRetired = 533078;

		///<summary>
		///<para> (0008,2257) Anatomic Perspective Code Sequence (Trial) (RETIRED) </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint AnatomicPerspectiveCodeSequenceTrialRetired = 533079;

		///<summary>
		///<para> (0008,2258) Anatomic Location Of Examining Instrument Description (Trial) (RETIRED) </para>
		///<para> VR: ST VM=1 </para>
		///</summary>
        public const uint AnatomicLocationOfExaminingInstrumentDescriptionTrialRetired = 533080;

		///<summary>
		///<para> (0008,2259) Anatomic Location Of Examining Instrument Code Sequence (Trial) (RETIRED) </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint AnatomicLocationOfExaminingInstrumentCodeSequenceTrialRetired = 533081;

		///<summary>
		///<para> (0008,225A) Anatomic Structure Space Or Region Modifier Code Sequence (Trial) (RETIRED) </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint AnatomicStructureSpaceOrRegionModifierCodeSequenceTrialRetired = 533082;

		///<summary>
		///<para> (0008,225C) On Axis Background Anatomic Structure Code Sequence (Trial) (RETIRED) </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint OnAxisBackgroundAnatomicStructureCodeSequenceTrialRetired = 533084;

		///<summary>
		///<para> (0008,3001) Alternate Representation Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint AlternateRepresentationSequence = 536577;

		///<summary>
		///<para> (0008,3010) Irradiation Event UID </para>
		///<para> VR: UI VM=1-n </para>
		///</summary>
        public const uint IrradiationEventUid = 536592;

		///<summary>
		///<para> (0008,3011) Source Irradiation Event Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint SourceIrradiationEventSequence = 536593;

		///<summary>
		///<para> (0008,3012) Radiopharmaceutical Administration Event UID </para>
		///<para> VR: UI VM=1 </para>
		///</summary>
        public const uint RadiopharmaceuticalAdministrationEventUid = 536594;

		///<summary>
		///<para> (0008,4000) Identifying Comments (RETIRED) </para>
		///<para> VR: LT VM=1 </para>
		///</summary>
        public const uint IdentifyingCommentsRetired = 540672;

		///<summary>
		///<para> (0008,9007) Frame Type </para>
		///<para> VR: CS VM=4 </para>
		///</summary>
        public const uint FrameType = 561159;

		///<summary>
		///<para> (0008,9092) Referenced Image Evidence Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint ReferencedImageEvidenceSequence = 561298;

		///<summary>
		///<para> (0008,9121) Referenced Raw Data Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint ReferencedRawDataSequence = 561441;

		///<summary>
		///<para> (0008,9123) Creator-Version UID </para>
		///<para> VR: UI VM=1 </para>
		///</summary>
        public const uint CreatorVersionUid = 561443;

		///<summary>
		///<para> (0008,9124) Derivation Image Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint DerivationImageSequence = 561444;

		///<summary>
		///<para> (0008,9154) Source Image Evidence Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint SourceImageEvidenceSequence = 561492;

		///<summary>
		///<para> (0008,9205) Pixel Presentation </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint PixelPresentation = 561669;

		///<summary>
		///<para> (0008,9206) Volumetric Properties </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint VolumetricProperties = 561670;

		///<summary>
		///<para> (0008,9207) Volume Based Calculation Technique </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint VolumeBasedCalculationTechnique = 561671;

		///<summary>
		///<para> (0008,9208) Complex Image Component </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint ComplexImageComponent = 561672;

		///<summary>
		///<para> (0008,9209) Acquisition Contrast </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint AcquisitionContrast = 561673;

		///<summary>
		///<para> (0008,9215) Derivation Code Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint DerivationCodeSequence = 561685;

		///<summary>
		///<para> (0008,9237) Referenced Presentation State Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint ReferencedPresentationStateSequence = 561719;

		///<summary>
		///<para> (0008,9410) Referenced Other Plane Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint ReferencedOtherPlaneSequence = 562192;

		///<summary>
		///<para> (0008,9458) Frame Display Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint FrameDisplaySequence = 562264;

		///<summary>
		///<para> (0008,9459) Recommended Display Frame Rate in Float </para>
		///<para> VR: FL VM=1 </para>
		///</summary>
        public const uint RecommendedDisplayFrameRateInFloat = 562265;

		///<summary>
		///<para> (0008,9460) Skip Frame Range Flag </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint SkipFrameRangeFlag = 562272;

		///<summary>
		///<para> (0010,0010) Patient's Name </para>
		///<para> VR: PN VM=1 </para>
		///</summary>
        public const uint PatientsName = 1048592;

		///<summary>
		///<para> (0010,0020) Patient ID </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint PatientId = 1048608;

		///<summary>
		///<para> (0010,0021) Issuer of Patient ID </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint IssuerOfPatientId = 1048609;

		///<summary>
		///<para> (0010,0022) Type of Patient ID </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint TypeOfPatientId = 1048610;

		///<summary>
		///<para> (0010,0024) Issuer of Patient ID Qualifiers Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint IssuerOfPatientIdQualifiersSequence = 1048612;

		///<summary>
		///<para> (0010,0026) Source Patient Group Identification Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint SourcePatientGroupIdentificationSequence = 1048614;

		///<summary>
		///<para> (0010,0027) Group of Patients Identification Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint GroupOfPatientsIdentificationSequence = 1048615;

		///<summary>
		///<para> (0010,0028) Subject Relative Position in Image </para>
		///<para> VR: US VM=3 </para>
		///</summary>
        public const uint SubjectRelativePositionInImage = 1048616;

		///<summary>
		///<para> (0010,0030) Patient's Birth Date </para>
		///<para> VR: DA VM=1 </para>
		///</summary>
        public const uint PatientsBirthDate = 1048624;

		///<summary>
		///<para> (0010,0032) Patient's Birth Time </para>
		///<para> VR: TM VM=1 </para>
		///</summary>
        public const uint PatientsBirthTime = 1048626;

		///<summary>
		///<para> (0010,0033) Patient's Birth Date in Alternative Calendar </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint PatientsBirthDateInAlternativeCalendar = 1048627;

		///<summary>
		///<para> (0010,0034) Patient's Death Date in Alternative Calendar </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint PatientsDeathDateInAlternativeCalendar = 1048628;

		///<summary>
		///<para> (0010,0035) Patient's Alternative Calendar </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint PatientsAlternativeCalendar = 1048629;

		///<summary>
		///<para> (0010,0040) Patient's Sex </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint PatientsSex = 1048640;

		///<summary>
		///<para> (0010,0050) Patient's Insurance Plan Code Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint PatientsInsurancePlanCodeSequence = 1048656;

		///<summary>
		///<para> (0010,0101) Patient's Primary Language Code Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint PatientsPrimaryLanguageCodeSequence = 1048833;

		///<summary>
		///<para> (0010,0102) Patient's Primary Language Modifier Code Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint PatientsPrimaryLanguageModifierCodeSequence = 1048834;

		///<summary>
		///<para> (0010,0200) Quality Control Subject </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint QualityControlSubject = 1049088;

		///<summary>
		///<para> (0010,0201) Quality Control Subject Type Code Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint QualityControlSubjectTypeCodeSequence = 1049089;

		///<summary>
		///<para> (0010,0212) Strain Description </para>
		///<para> VR: UC VM=1 </para>
		///</summary>
        public const uint StrainDescription = 1049106;

		///<summary>
		///<para> (0010,0213) Strain Nomenclature </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint StrainNomenclature = 1049107;

		///<summary>
		///<para> (0010,0214) Strain Stock Number </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint StrainStockNumber = 1049108;

		///<summary>
		///<para> (0010,0215) Strain Source Registry Code Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint StrainSourceRegistryCodeSequence = 1049109;

		///<summary>
		///<para> (0010,0216) Strain Stock Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint StrainStockSequence = 1049110;

		///<summary>
		///<para> (0010,0217) Strain Source </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint StrainSource = 1049111;

		///<summary>
		///<para> (0010,0218) Strain Additional Information </para>
		///<para> VR: UT VM=1 </para>
		///</summary>
        public const uint StrainAdditionalInformation = 1049112;

		///<summary>
		///<para> (0010,0219) Strain Code Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint StrainCodeSequence = 1049113;

		///<summary>
		///<para> (0010,1000) Other Patient IDs </para>
		///<para> VR: LO VM=1-n </para>
		///</summary>
        public const uint OtherPatientIds = 1052672;

		///<summary>
		///<para> (0010,1001) Other Patient Names </para>
		///<para> VR: PN VM=1-n </para>
		///</summary>
        public const uint OtherPatientNames = 1052673;

		///<summary>
		///<para> (0010,1002) Other Patient IDs Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint OtherPatientIdsSequence = 1052674;

		///<summary>
		///<para> (0010,1005) Patient's Birth Name </para>
		///<para> VR: PN VM=1 </para>
		///</summary>
        public const uint PatientsBirthName = 1052677;

		///<summary>
		///<para> (0010,1010) Patient's Age </para>
		///<para> VR: AS VM=1 </para>
		///</summary>
        public const uint PatientsAge = 1052688;

		///<summary>
		///<para> (0010,1020) Patient's Size </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint PatientsSize = 1052704;

		///<summary>
		///<para> (0010,1021) Patient's Size Code Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint PatientsSizeCodeSequence = 1052705;

		///<summary>
		///<para> (0010,1022) Patient's Body Mass Index </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint PatientsBodyMassIndex = 1052706;

		///<summary>
		///<para> (0010,1023) Measured AP Dimension </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint MeasuredApDimension = 1052707;

		///<summary>
		///<para> (0010,1024) Measured Lateral Dimension </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint MeasuredLateralDimension = 1052708;

		///<summary>
		///<para> (0010,1030) Patient's Weight </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint PatientsWeight = 1052720;

		///<summary>
		///<para> (0010,1040) Patient's Address </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint PatientsAddress = 1052736;

		///<summary>
		///<para> (0010,1050) Insurance Plan Identification (RETIRED) </para>
		///<para> VR: LO VM=1-n </para>
		///</summary>
        public const uint InsurancePlanIdentificationRetired = 1052752;

		///<summary>
		///<para> (0010,1060) Patient's Mother's Birth Name </para>
		///<para> VR: PN VM=1 </para>
		///</summary>
        public const uint PatientsMothersBirthName = 1052768;

		///<summary>
		///<para> (0010,1080) Military Rank </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint MilitaryRank = 1052800;

		///<summary>
		///<para> (0010,1081) Branch of Service </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint BranchOfService = 1052801;

		///<summary>
		///<para> (0010,1090) Medical Record Locator </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint MedicalRecordLocator = 1052816;

		///<summary>
		///<para> (0010,1100) Referenced Patient Photo Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint ReferencedPatientPhotoSequence = 1052928;

		///<summary>
		///<para> (0010,2000) Medical Alerts </para>
		///<para> VR: LO VM=1-n </para>
		///</summary>
        public const uint MedicalAlerts = 1056768;

		///<summary>
		///<para> (0010,2110) Allergies </para>
		///<para> VR: LO VM=1-n </para>
		///</summary>
        public const uint Allergies = 1057040;

		///<summary>
		///<para> (0010,2150) Country of Residence </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint CountryOfResidence = 1057104;

		///<summary>
		///<para> (0010,2152) Region of Residence </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint RegionOfResidence = 1057106;

		///<summary>
		///<para> (0010,2154) Patient's Telephone Numbers </para>
		///<para> VR: SH VM=1-n </para>
		///</summary>
        public const uint PatientsTelephoneNumbers = 1057108;

		///<summary>
		///<para> (0010,2155) Patient's Telecom Information </para>
		///<para> VR: LT VM=1 </para>
		///</summary>
        public const uint PatientsTelecomInformation = 1057109;

		///<summary>
		///<para> (0010,2160) Ethnic Group </para>
		///<para> VR: SH VM=1 </para>
		///</summary>
        public const uint EthnicGroup = 1057120;

		///<summary>
		///<para> (0010,2180) Occupation </para>
		///<para> VR: SH VM=1 </para>
		///</summary>
        public const uint Occupation = 1057152;

		///<summary>
		///<para> (0010,21A0) Smoking Status </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint SmokingStatus = 1057184;

		///<summary>
		///<para> (0010,21B0) Additional Patient History </para>
		///<para> VR: LT VM=1 </para>
		///</summary>
        public const uint AdditionalPatientHistory = 1057200;

		///<summary>
		///<para> (0010,21C0) Pregnancy Status </para>
		///<para> VR: US VM=1 </para>
		///</summary>
        public const uint PregnancyStatus = 1057216;

		///<summary>
		///<para> (0010,21D0) Last Menstrual Date </para>
		///<para> VR: DA VM=1 </para>
		///</summary>
        public const uint LastMenstrualDate = 1057232;

		///<summary>
		///<para> (0010,21F0) Patient's Religious Preference </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint PatientsReligiousPreference = 1057264;

		///<summary>
		///<para> (0010,2201) Patient Species Description </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint PatientSpeciesDescription = 1057281;

		///<summary>
		///<para> (0010,2202) Patient Species Code Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint PatientSpeciesCodeSequence = 1057282;

		///<summary>
		///<para> (0010,2203) Patient's Sex Neutered </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint PatientsSexNeutered = 1057283;

		///<summary>
		///<para> (0010,2210) Anatomical Orientation Type </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint AnatomicalOrientationType = 1057296;

		///<summary>
		///<para> (0010,2292) Patient Breed Description </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint PatientBreedDescription = 1057426;

		///<summary>
		///<para> (0010,2293) Patient Breed Code Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint PatientBreedCodeSequence = 1057427;

		///<summary>
		///<para> (0010,2294) Breed Registration Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint BreedRegistrationSequence = 1057428;

		///<summary>
		///<para> (0010,2295) Breed Registration Number </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint BreedRegistrationNumber = 1057429;

		///<summary>
		///<para> (0010,2296) Breed Registry Code Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint BreedRegistryCodeSequence = 1057430;

		///<summary>
		///<para> (0010,2297) Responsible Person </para>
		///<para> VR: PN VM=1 </para>
		///</summary>
        public const uint ResponsiblePerson = 1057431;

		///<summary>
		///<para> (0010,2298) Responsible Person Role </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint ResponsiblePersonRole = 1057432;

		///<summary>
		///<para> (0010,2299) Responsible Organization </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint ResponsibleOrganization = 1057433;

		///<summary>
		///<para> (0010,4000) Patient Comments </para>
		///<para> VR: LT VM=1 </para>
		///</summary>
        public const uint PatientComments = 1064960;

		///<summary>
		///<para> (0010,9431) Examined Body Thickness </para>
		///<para> VR: FL VM=1 </para>
		///</summary>
        public const uint ExaminedBodyThickness = 1086513;

		///<summary>
		///<para> (0012,0010) Clinical Trial Sponsor Name </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint ClinicalTrialSponsorName = 1179664;

		///<summary>
		///<para> (0012,0020) Clinical Trial Protocol ID </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint ClinicalTrialProtocolId = 1179680;

		///<summary>
		///<para> (0012,0021) Clinical Trial Protocol Name </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint ClinicalTrialProtocolName = 1179681;

		///<summary>
		///<para> (0012,0030) Clinical Trial Site ID </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint ClinicalTrialSiteId = 1179696;

		///<summary>
		///<para> (0012,0031) Clinical Trial Site Name </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint ClinicalTrialSiteName = 1179697;

		///<summary>
		///<para> (0012,0040) Clinical Trial Subject ID </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint ClinicalTrialSubjectId = 1179712;

		///<summary>
		///<para> (0012,0042) Clinical Trial Subject Reading ID </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint ClinicalTrialSubjectReadingId = 1179714;

		///<summary>
		///<para> (0012,0050) Clinical Trial Time Point ID </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint ClinicalTrialTimePointId = 1179728;

		///<summary>
		///<para> (0012,0051) Clinical Trial Time Point Description </para>
		///<para> VR: ST VM=1 </para>
		///</summary>
        public const uint ClinicalTrialTimePointDescription = 1179729;

		///<summary>
		///<para> (0012,0060) Clinical Trial Coordinating Center Name </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint ClinicalTrialCoordinatingCenterName = 1179744;

		///<summary>
		///<para> (0012,0062) Patient Identity Removed </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint PatientIdentityRemoved = 1179746;

		///<summary>
		///<para> (0012,0063) De-identification Method </para>
		///<para> VR: LO VM=1-n </para>
		///</summary>
        public const uint DeIdentificationMethod = 1179747;

		///<summary>
		///<para> (0012,0064) De-identification Method Code Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint DeIdentificationMethodCodeSequence = 1179748;

		///<summary>
		///<para> (0012,0071) Clinical Trial Series ID </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint ClinicalTrialSeriesId = 1179761;

		///<summary>
		///<para> (0012,0072) Clinical Trial Series Description </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint ClinicalTrialSeriesDescription = 1179762;

		///<summary>
		///<para> (0012,0081) Clinical Trial Protocol Ethics Committee Name </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint ClinicalTrialProtocolEthicsCommitteeName = 1179777;

		///<summary>
		///<para> (0012,0082) Clinical Trial Protocol Ethics Committee Approval Number </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint ClinicalTrialProtocolEthicsCommitteeApprovalNumber = 1179778;

		///<summary>
		///<para> (0012,0083) Consent for Clinical Trial Use Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint ConsentForClinicalTrialUseSequence = 1179779;

		///<summary>
		///<para> (0012,0084) Distribution Type </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint DistributionType = 1179780;

		///<summary>
		///<para> (0012,0085) Consent for Distribution Flag </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint ConsentForDistributionFlag = 1179781;

		///<summary>
		///<para> (0012,0086) Ethics Committee Approval Effectiveness Start Date </para>
		///<para> VR: DA VM=1 </para>
		///</summary>
        public const uint EthicsCommitteeApprovalEffectivenessStartDate = 1179782;

		///<summary>
		///<para> (0012,0087) Ethics Committee Approval Effectiveness End Date </para>
		///<para> VR: DA VM=1 </para>
		///</summary>
        public const uint EthicsCommitteeApprovalEffectivenessEndDate = 1179783;

		///<summary>
		///<para> (0014,0023) CAD File Format (RETIRED) </para>
		///<para> VR: ST VM=1 </para>
		///</summary>
        public const uint CadFileFormatRetired = 1310755;

		///<summary>
		///<para> (0014,0024) Component Reference System (RETIRED) </para>
		///<para> VR: ST VM=1 </para>
		///</summary>
        public const uint ComponentReferenceSystemRetired = 1310756;

		///<summary>
		///<para> (0014,0025) Component Manufacturing Procedure </para>
		///<para> VR: ST VM=1 </para>
		///</summary>
        public const uint ComponentManufacturingProcedure = 1310757;

		///<summary>
		///<para> (0014,0028) Component Manufacturer </para>
		///<para> VR: ST VM=1 </para>
		///</summary>
        public const uint ComponentManufacturer = 1310760;

		///<summary>
		///<para> (0014,0030) Material Thickness </para>
		///<para> VR: DS VM=1-n </para>
		///</summary>
        public const uint MaterialThickness = 1310768;

		///<summary>
		///<para> (0014,0032) Material Pipe Diameter </para>
		///<para> VR: DS VM=1-n </para>
		///</summary>
        public const uint MaterialPipeDiameter = 1310770;

		///<summary>
		///<para> (0014,0034) Material Isolation Diameter </para>
		///<para> VR: DS VM=1-n </para>
		///</summary>
        public const uint MaterialIsolationDiameter = 1310772;

		///<summary>
		///<para> (0014,0042) Material Grade </para>
		///<para> VR: ST VM=1 </para>
		///</summary>
        public const uint MaterialGrade = 1310786;

		///<summary>
		///<para> (0014,0044) Material Properties Description </para>
		///<para> VR: ST VM=1 </para>
		///</summary>
        public const uint MaterialPropertiesDescription = 1310788;

		///<summary>
		///<para> (0014,0045) Material Properties File Format (Retired) (RETIRED) </para>
		///<para> VR: ST VM=1 </para>
		///</summary>
        public const uint MaterialPropertiesFileFormatRetiredRetired = 1310789;

		///<summary>
		///<para> (0014,0046) Material Notes </para>
		///<para> VR: LT VM=1 </para>
		///</summary>
        public const uint MaterialNotes = 1310790;

		///<summary>
		///<para> (0014,0050) Component Shape </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint ComponentShape = 1310800;

		///<summary>
		///<para> (0014,0052) Curvature Type </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint CurvatureType = 1310802;

		///<summary>
		///<para> (0014,0054) Outer Diameter </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint OuterDiameter = 1310804;

		///<summary>
		///<para> (0014,0056) Inner Diameter </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint InnerDiameter = 1310806;

		///<summary>
		///<para> (0014,0100) Component Welder IDs </para>
		///<para> VR: LO VM=1-n </para>
		///</summary>
        public const uint ComponentWelderIds = 1310976;

		///<summary>
		///<para> (0014,0101) Secondary Approval Status </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint SecondaryApprovalStatus = 1310977;

		///<summary>
		///<para> (0014,0102) Secondary Review Date </para>
		///<para> VR: DA VM=1 </para>
		///</summary>
        public const uint SecondaryReviewDate = 1310978;

		///<summary>
		///<para> (0014,0103) Secondary Review Time </para>
		///<para> VR: TM VM=1 </para>
		///</summary>
        public const uint SecondaryReviewTime = 1310979;

		///<summary>
		///<para> (0014,0104) Secondary Reviewer Name </para>
		///<para> VR: PN VM=1 </para>
		///</summary>
        public const uint SecondaryReviewerName = 1310980;

		///<summary>
		///<para> (0014,0105) Repair ID </para>
		///<para> VR: ST VM=1 </para>
		///</summary>
        public const uint RepairId = 1310981;

		///<summary>
		///<para> (0014,0106) Multiple Component Approval Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint MultipleComponentApprovalSequence = 1310982;

		///<summary>
		///<para> (0014,0107) Other Approval Status </para>
		///<para> VR: CS VM=1-n </para>
		///</summary>
        public const uint OtherApprovalStatus = 1310983;

		///<summary>
		///<para> (0014,0108) Other Secondary Approval Status </para>
		///<para> VR: CS VM=1-n </para>
		///</summary>
        public const uint OtherSecondaryApprovalStatus = 1310984;

		///<summary>
		///<para> (0014,1010) Actual Environmental Conditions </para>
		///<para> VR: ST VM=1 </para>
		///</summary>
        public const uint ActualEnvironmentalConditions = 1314832;

		///<summary>
		///<para> (0014,1020) Expiry Date </para>
		///<para> VR: DA VM=1 </para>
		///</summary>
        public const uint ExpiryDate = 1314848;

		///<summary>
		///<para> (0014,1040) Environmental Conditions </para>
		///<para> VR: ST VM=1 </para>
		///</summary>
        public const uint EnvironmentalConditions = 1314880;

		///<summary>
		///<para> (0014,2002) Evaluator Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint EvaluatorSequence = 1318914;

		///<summary>
		///<para> (0014,2004) Evaluator Number </para>
		///<para> VR: IS VM=1 </para>
		///</summary>
        public const uint EvaluatorNumber = 1318916;

		///<summary>
		///<para> (0014,2006) Evaluator Name </para>
		///<para> VR: PN VM=1 </para>
		///</summary>
        public const uint EvaluatorName = 1318918;

		///<summary>
		///<para> (0014,2008) Evaluation Attempt </para>
		///<para> VR: IS VM=1 </para>
		///</summary>
        public const uint EvaluationAttempt = 1318920;

		///<summary>
		///<para> (0014,2012) Indication Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint IndicationSequence = 1318930;

		///<summary>
		///<para> (0014,2014) Indication Number </para>
		///<para> VR: IS VM=1 </para>
		///</summary>
        public const uint IndicationNumber = 1318932;

		///<summary>
		///<para> (0014,2016) Indication Label </para>
		///<para> VR: SH VM=1 </para>
		///</summary>
        public const uint IndicationLabel = 1318934;

		///<summary>
		///<para> (0014,2018) Indication Description </para>
		///<para> VR: ST VM=1 </para>
		///</summary>
        public const uint IndicationDescription = 1318936;

		///<summary>
		///<para> (0014,201A) Indication Type </para>
		///<para> VR: CS VM=1-n </para>
		///</summary>
        public const uint IndicationType = 1318938;

		///<summary>
		///<para> (0014,201C) Indication Disposition </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint IndicationDisposition = 1318940;

		///<summary>
		///<para> (0014,201E) Indication ROI Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint IndicationRoiSequence = 1318942;

		///<summary>
		///<para> (0014,2030) Indication Physical Property Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint IndicationPhysicalPropertySequence = 1318960;

		///<summary>
		///<para> (0014,2032) Property Label </para>
		///<para> VR: SH VM=1 </para>
		///</summary>
        public const uint PropertyLabel = 1318962;

		///<summary>
		///<para> (0014,2202) Coordinate System Number of Axes </para>
		///<para> VR: IS VM=1 </para>
		///</summary>
        public const uint CoordinateSystemNumberOfAxes = 1319426;

		///<summary>
		///<para> (0014,2204) Coordinate System Axes Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint CoordinateSystemAxesSequence = 1319428;

		///<summary>
		///<para> (0014,2206) Coordinate System Axis Description </para>
		///<para> VR: ST VM=1 </para>
		///</summary>
        public const uint CoordinateSystemAxisDescription = 1319430;

		///<summary>
		///<para> (0014,2208) Coordinate System Data Set Mapping </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint CoordinateSystemDataSetMapping = 1319432;

		///<summary>
		///<para> (0014,220A) Coordinate System Axis Number </para>
		///<para> VR: IS VM=1 </para>
		///</summary>
        public const uint CoordinateSystemAxisNumber = 1319434;

		///<summary>
		///<para> (0014,220C) Coordinate System Axis Type </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint CoordinateSystemAxisType = 1319436;

		///<summary>
		///<para> (0014,220E) Coordinate System Axis Units </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint CoordinateSystemAxisUnits = 1319438;

		///<summary>
		///<para> (0014,2210) Coordinate System Axis Values </para>
		///<para> VR: OB VM=1 </para>
		///</summary>
        public const uint CoordinateSystemAxisValues = 1319440;

		///<summary>
		///<para> (0014,2220) Coordinate System Transform Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint CoordinateSystemTransformSequence = 1319456;

		///<summary>
		///<para> (0014,2222) Transform Description </para>
		///<para> VR: ST VM=1 </para>
		///</summary>
        public const uint TransformDescription = 1319458;

		///<summary>
		///<para> (0014,2224) Transform Number of Axes </para>
		///<para> VR: IS VM=1 </para>
		///</summary>
        public const uint TransformNumberOfAxes = 1319460;

		///<summary>
		///<para> (0014,2226) Transform Order of Axes </para>
		///<para> VR: IS VM=1-n </para>
		///</summary>
        public const uint TransformOrderOfAxes = 1319462;

		///<summary>
		///<para> (0014,2228) Transformed Axis Units </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint TransformedAxisUnits = 1319464;

		///<summary>
		///<para> (0014,222A) Coordinate System Transform Rotation and Scale Matrix </para>
		///<para> VR: DS VM=1-n </para>
		///</summary>
        public const uint CoordinateSystemTransformRotationAndScaleMatrix = 1319466;

		///<summary>
		///<para> (0014,222C) Coordinate System Transform Translation Matrix </para>
		///<para> VR: DS VM=1-n </para>
		///</summary>
        public const uint CoordinateSystemTransformTranslationMatrix = 1319468;

		///<summary>
		///<para> (0014,3011) Internal Detector Frame Time </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint InternalDetectorFrameTime = 1323025;

		///<summary>
		///<para> (0014,3012) Number of Frames Integrated </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint NumberOfFramesIntegrated = 1323026;

		///<summary>
		///<para> (0014,3020) Detector Temperature Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint DetectorTemperatureSequence = 1323040;

		///<summary>
		///<para> (0014,3022) Sensor Name </para>
		///<para> VR: ST VM=1 </para>
		///</summary>
        public const uint SensorName = 1323042;

		///<summary>
		///<para> (0014,3024) Horizontal Offset of Sensor </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint HorizontalOffsetOfSensor = 1323044;

		///<summary>
		///<para> (0014,3026) Vertical Offset of Sensor </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint VerticalOffsetOfSensor = 1323046;

		///<summary>
		///<para> (0014,3028) Sensor Temperature </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint SensorTemperature = 1323048;

		///<summary>
		///<para> (0014,3040) Dark Current Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint DarkCurrentSequence = 1323072;

		///<summary>
		///<para> (0014,3050) Dark Current Counts </para>
		///<para> VR: OB/OW VM=1 </para>
		///</summary>
        public const uint DarkCurrentCounts = 1323088;

		///<summary>
		///<para> (0014,3060) Gain Correction Reference Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint GainCorrectionReferenceSequence = 1323104;

		///<summary>
		///<para> (0014,3070) Air Counts </para>
		///<para> VR: OB/OW VM=1 </para>
		///</summary>
        public const uint AirCounts = 1323120;

		///<summary>
		///<para> (0014,3071) KV Used in Gain Calibration </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint KvUsedInGainCalibration = 1323121;

		///<summary>
		///<para> (0014,3072) MA Used in Gain Calibration </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint MaUsedInGainCalibration = 1323122;

		///<summary>
		///<para> (0014,3073) Number of Frames Used for Integration </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint NumberOfFramesUsedForIntegration = 1323123;

		///<summary>
		///<para> (0014,3074) Filter Material Used in Gain Calibration </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint FilterMaterialUsedInGainCalibration = 1323124;

		///<summary>
		///<para> (0014,3075) Filter Thickness Used in Gain Calibration </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint FilterThicknessUsedInGainCalibration = 1323125;

		///<summary>
		///<para> (0014,3076) Date of Gain Calibration </para>
		///<para> VR: DA VM=1 </para>
		///</summary>
        public const uint DateOfGainCalibration = 1323126;

		///<summary>
		///<para> (0014,3077) Time of Gain Calibration </para>
		///<para> VR: TM VM=1 </para>
		///</summary>
        public const uint TimeOfGainCalibration = 1323127;

		///<summary>
		///<para> (0014,3080) Bad Pixel Image </para>
		///<para> VR: OB VM=1 </para>
		///</summary>
        public const uint BadPixelImage = 1323136;

		///<summary>
		///<para> (0014,3099) Calibration Notes </para>
		///<para> VR: LT VM=1 </para>
		///</summary>
        public const uint CalibrationNotes = 1323161;

		///<summary>
		///<para> (0014,4002) Pulser Equipment Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint PulserEquipmentSequence = 1327106;

		///<summary>
		///<para> (0014,4004) Pulser Type </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint PulserType = 1327108;

		///<summary>
		///<para> (0014,4006) Pulser Notes </para>
		///<para> VR: LT VM=1 </para>
		///</summary>
        public const uint PulserNotes = 1327110;

		///<summary>
		///<para> (0014,4008) Receiver Equipment Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint ReceiverEquipmentSequence = 1327112;

		///<summary>
		///<para> (0014,400A) Amplifier Type </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint AmplifierType = 1327114;

		///<summary>
		///<para> (0014,400C) Receiver Notes </para>
		///<para> VR: LT VM=1 </para>
		///</summary>
        public const uint ReceiverNotes = 1327116;

		///<summary>
		///<para> (0014,400E) Pre-Amplifier Equipment Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint PreAmplifierEquipmentSequence = 1327118;

		///<summary>
		///<para> (0014,400F) Pre-Amplifier Notes </para>
		///<para> VR: LT VM=1 </para>
		///</summary>
        public const uint PreAmplifierNotes = 1327119;

		///<summary>
		///<para> (0014,4010) Transmit Transducer Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint TransmitTransducerSequence = 1327120;

		///<summary>
		///<para> (0014,4011) Receive Transducer Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint ReceiveTransducerSequence = 1327121;

		///<summary>
		///<para> (0014,4012) Number of Elements </para>
		///<para> VR: US VM=1 </para>
		///</summary>
        public const uint NumberOfElements = 1327122;

		///<summary>
		///<para> (0014,4013) Element Shape </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint ElementShape = 1327123;

		///<summary>
		///<para> (0014,4014) Element Dimension A </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint ElementDimensionA = 1327124;

		///<summary>
		///<para> (0014,4015) Element Dimension B </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint ElementDimensionB = 1327125;

		///<summary>
		///<para> (0014,4016) Element Pitch A </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint ElementPitchA = 1327126;

		///<summary>
		///<para> (0014,4017) Measured Beam Dimension A </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint MeasuredBeamDimensionA = 1327127;

		///<summary>
		///<para> (0014,4018) Measured Beam Dimension B </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint MeasuredBeamDimensionB = 1327128;

		///<summary>
		///<para> (0014,4019) Location of Measured Beam Diameter </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint LocationOfMeasuredBeamDiameter = 1327129;

		///<summary>
		///<para> (0014,401A) Nominal Frequency </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint NominalFrequency = 1327130;

		///<summary>
		///<para> (0014,401B) Measured Center Frequency </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint MeasuredCenterFrequency = 1327131;

		///<summary>
		///<para> (0014,401C) Measured Bandwidth </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint MeasuredBandwidth = 1327132;

		///<summary>
		///<para> (0014,401D) Element Pitch B </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint ElementPitchB = 1327133;

		///<summary>
		///<para> (0014,4020) Pulser Settings Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint PulserSettingsSequence = 1327136;

		///<summary>
		///<para> (0014,4022) Pulse Width </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint PulseWidth = 1327138;

		///<summary>
		///<para> (0014,4024) Excitation Frequency </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint ExcitationFrequency = 1327140;

		///<summary>
		///<para> (0014,4026) Modulation Type </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint ModulationType = 1327142;

		///<summary>
		///<para> (0014,4028) Damping </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint Damping = 1327144;

		///<summary>
		///<para> (0014,4030) Receiver Settings Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint ReceiverSettingsSequence = 1327152;

		///<summary>
		///<para> (0014,4031) Acquired Soundpath Length </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint AcquiredSoundpathLength = 1327153;

		///<summary>
		///<para> (0014,4032) Acquisition Compression Type </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint AcquisitionCompressionType = 1327154;

		///<summary>
		///<para> (0014,4033) Acquisition Sample Size </para>
		///<para> VR: IS VM=1 </para>
		///</summary>
        public const uint AcquisitionSampleSize = 1327155;

		///<summary>
		///<para> (0014,4034) Rectifier Smoothing </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint RectifierSmoothing = 1327156;

		///<summary>
		///<para> (0014,4035) DAC Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint DacSequence = 1327157;

		///<summary>
		///<para> (0014,4036) DAC Type </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint DacType = 1327158;

		///<summary>
		///<para> (0014,4038) DAC Gain Points </para>
		///<para> VR: DS VM=1-n </para>
		///</summary>
        public const uint DacGainPoints = 1327160;

		///<summary>
		///<para> (0014,403A) DAC Time Points </para>
		///<para> VR: DS VM=1-n </para>
		///</summary>
        public const uint DacTimePoints = 1327162;

		///<summary>
		///<para> (0014,403C) DAC Amplitude </para>
		///<para> VR: DS VM=1-n </para>
		///</summary>
        public const uint DacAmplitude = 1327164;

		///<summary>
		///<para> (0014,4040) Pre-Amplifier Settings Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint PreAmplifierSettingsSequence = 1327168;

		///<summary>
		///<para> (0014,4050) Transmit Transducer Settings Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint TransmitTransducerSettingsSequence = 1327184;

		///<summary>
		///<para> (0014,4051) Receive Transducer Settings Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint ReceiveTransducerSettingsSequence = 1327185;

		///<summary>
		///<para> (0014,4052) Incident Angle </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint IncidentAngle = 1327186;

		///<summary>
		///<para> (0014,4054) Coupling Technique </para>
		///<para> VR: ST VM=1 </para>
		///</summary>
        public const uint CouplingTechnique = 1327188;

		///<summary>
		///<para> (0014,4056) Coupling Medium </para>
		///<para> VR: ST VM=1 </para>
		///</summary>
        public const uint CouplingMedium = 1327190;

		///<summary>
		///<para> (0014,4057) Coupling Velocity </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint CouplingVelocity = 1327191;

		///<summary>
		///<para> (0014,4058) Probe Center Location X </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint ProbeCenterLocationX = 1327192;

		///<summary>
		///<para> (0014,4059) Probe Center Location Z </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint ProbeCenterLocationZ = 1327193;

		///<summary>
		///<para> (0014,405A) Sound Path Length </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint SoundPathLength = 1327194;

		///<summary>
		///<para> (0014,405C) Delay Law Identifier </para>
		///<para> VR: ST VM=1 </para>
		///</summary>
        public const uint DelayLawIdentifier = 1327196;

		///<summary>
		///<para> (0014,4060) Gate Settings Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint GateSettingsSequence = 1327200;

		///<summary>
		///<para> (0014,4062) Gate Threshold </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint GateThreshold = 1327202;

		///<summary>
		///<para> (0014,4064) Velocity of Sound </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint VelocityOfSound = 1327204;

		///<summary>
		///<para> (0014,4070) Calibration Settings Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint CalibrationSettingsSequence = 1327216;

		///<summary>
		///<para> (0014,4072) Calibration Procedure </para>
		///<para> VR: ST VM=1 </para>
		///</summary>
        public const uint CalibrationProcedure = 1327218;

		///<summary>
		///<para> (0014,4074) Procedure Version </para>
		///<para> VR: SH VM=1 </para>
		///</summary>
        public const uint ProcedureVersion = 1327220;

		///<summary>
		///<para> (0014,4076) Procedure Creation Date </para>
		///<para> VR: DA VM=1 </para>
		///</summary>
        public const uint ProcedureCreationDate = 1327222;

		///<summary>
		///<para> (0014,4078) Procedure Expiration Date </para>
		///<para> VR: DA VM=1 </para>
		///</summary>
        public const uint ProcedureExpirationDate = 1327224;

		///<summary>
		///<para> (0014,407A) Procedure Last Modified Date </para>
		///<para> VR: DA VM=1 </para>
		///</summary>
        public const uint ProcedureLastModifiedDate = 1327226;

		///<summary>
		///<para> (0014,407C) Calibration Time </para>
		///<para> VR: TM VM=1-n </para>
		///</summary>
        public const uint CalibrationTime = 1327228;

		///<summary>
		///<para> (0014,407E) Calibration Date </para>
		///<para> VR: DA VM=1-n </para>
		///</summary>
        public const uint CalibrationDate = 1327230;

		///<summary>
		///<para> (0014,4080) Probe Drive Equipment Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint ProbeDriveEquipmentSequence = 1327232;

		///<summary>
		///<para> (0014,4081) Drive Type </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint DriveType = 1327233;

		///<summary>
		///<para> (0014,4082) Probe Drive Notes </para>
		///<para> VR: LT VM=1 </para>
		///</summary>
        public const uint ProbeDriveNotes = 1327234;

		///<summary>
		///<para> (0014,4083) Drive Probe Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint DriveProbeSequence = 1327235;

		///<summary>
		///<para> (0014,4084) Probe Inductance </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint ProbeInductance = 1327236;

		///<summary>
		///<para> (0014,4085) Probe Resistance </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint ProbeResistance = 1327237;

		///<summary>
		///<para> (0014,4086) Receive Probe Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint ReceiveProbeSequence = 1327238;

		///<summary>
		///<para> (0014,4087) Probe Drive Settings Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint ProbeDriveSettingsSequence = 1327239;

		///<summary>
		///<para> (0014,4088) Bridge Resistors </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint BridgeResistors = 1327240;

		///<summary>
		///<para> (0014,4089) Probe Orientation Angle </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint ProbeOrientationAngle = 1327241;

		///<summary>
		///<para> (0014,408B) User Selected Gain Y </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint UserSelectedGainY = 1327243;

		///<summary>
		///<para> (0014,408C) User Selected Phase </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint UserSelectedPhase = 1327244;

		///<summary>
		///<para> (0014,408D) User Selected Offset X </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint UserSelectedOffsetX = 1327245;

		///<summary>
		///<para> (0014,408E) User Selected Offset Y </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint UserSelectedOffsetY = 1327246;

		///<summary>
		///<para> (0014,4091) Channel Settings Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint ChannelSettingsSequence = 1327249;

		///<summary>
		///<para> (0014,4092) Channel Threshold </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint ChannelThreshold = 1327250;

		///<summary>
		///<para> (0014,409A) Scanner Settings Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint ScannerSettingsSequence = 1327258;

		///<summary>
		///<para> (0014,409B) Scan Procedure </para>
		///<para> VR: ST VM=1 </para>
		///</summary>
        public const uint ScanProcedure = 1327259;

		///<summary>
		///<para> (0014,409C) Translation Rate X </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint TranslationRateX = 1327260;

		///<summary>
		///<para> (0014,409D) Translation Rate Y </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint TranslationRateY = 1327261;

		///<summary>
		///<para> (0014,409F) Channel Overlap </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint ChannelOverlap = 1327263;

		///<summary>
		///<para> (0014,40A0) Image Quality Indicator Type </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint ImageQualityIndicatorType = 1327264;

		///<summary>
		///<para> (0014,40A1) Image Quality Indicator Material </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint ImageQualityIndicatorMaterial = 1327265;

		///<summary>
		///<para> (0014,40A2) Image Quality Indicator Size </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint ImageQualityIndicatorSize = 1327266;

		///<summary>
		///<para> (0014,5002) LINAC Energy </para>
		///<para> VR: IS VM=1 </para>
		///</summary>
        public const uint LinacEnergy = 1331202;

		///<summary>
		///<para> (0014,5004) LINAC Output </para>
		///<para> VR: IS VM=1 </para>
		///</summary>
        public const uint LinacOutput = 1331204;

		///<summary>
		///<para> (0014,5100) Active Aperture </para>
		///<para> VR: US VM=1 </para>
		///</summary>
        public const uint ActiveAperture = 1331456;

		///<summary>
		///<para> (0014,5101) Total Aperture </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint TotalAperture = 1331457;

		///<summary>
		///<para> (0014,5102) Aperture Elevation </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint ApertureElevation = 1331458;

		///<summary>
		///<para> (0014,5103) Main Lobe Angle </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint MainLobeAngle = 1331459;

		///<summary>
		///<para> (0014,5104) Main Roof Angle </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint MainRoofAngle = 1331460;

		///<summary>
		///<para> (0014,5105) Connector Type </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint ConnectorType = 1331461;

		///<summary>
		///<para> (0014,5106) Wedge Model Number </para>
		///<para> VR: SH VM=1 </para>
		///</summary>
        public const uint WedgeModelNumber = 1331462;

		///<summary>
		///<para> (0014,5107) Wedge Angle Float </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint WedgeAngleFloat = 1331463;

		///<summary>
		///<para> (0014,5108) Wedge Roof Angle </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint WedgeRoofAngle = 1331464;

		///<summary>
		///<para> (0014,5109) Wedge Element 1 Position </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint WedgeElement1Position = 1331465;

		///<summary>
		///<para> (0014,510A) Wedge Material Velocity </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint WedgeMaterialVelocity = 1331466;

		///<summary>
		///<para> (0014,510B) Wedge Material </para>
		///<para> VR: SH VM=1 </para>
		///</summary>
        public const uint WedgeMaterial = 1331467;

		///<summary>
		///<para> (0014,510C) Wedge Offset Z </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint WedgeOffsetZ = 1331468;

		///<summary>
		///<para> (0014,510D) Wedge Origin Offset X </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint WedgeOriginOffsetX = 1331469;

		///<summary>
		///<para> (0014,510E) Wedge Time Delay </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint WedgeTimeDelay = 1331470;

		///<summary>
		///<para> (0014,510F) Wedge Name </para>
		///<para> VR: SH VM=1 </para>
		///</summary>
        public const uint WedgeName = 1331471;

		///<summary>
		///<para> (0014,5110) Wedge Manufacturer Name </para>
		///<para> VR: SH VM=1 </para>
		///</summary>
        public const uint WedgeManufacturerName = 1331472;

		///<summary>
		///<para> (0014,5111) Wedge Description </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint WedgeDescription = 1331473;

		///<summary>
		///<para> (0014,5112) Nominal Beam Angle </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint NominalBeamAngle = 1331474;

		///<summary>
		///<para> (0014,5113) Wedge Offset X </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint WedgeOffsetX = 1331475;

		///<summary>
		///<para> (0014,5114) Wedge Offset Y </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint WedgeOffsetY = 1331476;

		///<summary>
		///<para> (0014,5115) Wedge Total Length </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint WedgeTotalLength = 1331477;

		///<summary>
		///<para> (0014,5116) Wedge In Contact Length </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint WedgeInContactLength = 1331478;

		///<summary>
		///<para> (0014,5117) Wedge Front Gap </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint WedgeFrontGap = 1331479;

		///<summary>
		///<para> (0014,5118) Wedge Total Height </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint WedgeTotalHeight = 1331480;

		///<summary>
		///<para> (0014,5119) Wedge Front Height </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint WedgeFrontHeight = 1331481;

		///<summary>
		///<para> (0014,511A) Wedge Rear Height </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint WedgeRearHeight = 1331482;

		///<summary>
		///<para> (0014,511B) Wedge Total Width </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint WedgeTotalWidth = 1331483;

		///<summary>
		///<para> (0014,511C) Wedge In Contact Width </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint WedgeInContactWidth = 1331484;

		///<summary>
		///<para> (0014,511D) Wedge Chamfer Height </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint WedgeChamferHeight = 1331485;

		///<summary>
		///<para> (0014,511E) Wedge Curve </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint WedgeCurve = 1331486;

		///<summary>
		///<para> (0014,511F) Radius Along the Wedge </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint RadiusAlongTheWedge = 1331487;

		///<summary>
		///<para> (0018,0010) Contrast/Bolus Agent </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint ContrastBolusAgent = 1572880;

		///<summary>
		///<para> (0018,0012) Contrast/Bolus Agent Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint ContrastBolusAgentSequence = 1572882;

		///<summary>
		///<para> (0018,0013) Contrast/Bolus T1 Relaxivity </para>
		///<para> VR: FL VM=1 </para>
		///</summary>
        public const uint ContrastBolusT1Relaxivity = 1572883;

		///<summary>
		///<para> (0018,0014) Contrast/Bolus Administration Route Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint ContrastBolusAdministrationRouteSequence = 1572884;

		///<summary>
		///<para> (0018,0015) Body Part Examined </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint BodyPartExamined = 1572885;

		///<summary>
		///<para> (0018,0020) Scanning Sequence </para>
		///<para> VR: CS VM=1-n </para>
		///</summary>
        public const uint ScanningSequence = 1572896;

		///<summary>
		///<para> (0018,0021) Sequence Variant </para>
		///<para> VR: CS VM=1-n </para>
		///</summary>
        public const uint SequenceVariant = 1572897;

		///<summary>
		///<para> (0018,0022) Scan Options </para>
		///<para> VR: CS VM=1-n </para>
		///</summary>
        public const uint ScanOptions = 1572898;

		///<summary>
		///<para> (0018,0023) MR Acquisition Type </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint MrAcquisitionType = 1572899;

		///<summary>
		///<para> (0018,0024) Sequence Name </para>
		///<para> VR: SH VM=1 </para>
		///</summary>
        public const uint SequenceName = 1572900;

		///<summary>
		///<para> (0018,0025) Angio Flag </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint AngioFlag = 1572901;

		///<summary>
		///<para> (0018,0026) Intervention Drug Information Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint InterventionDrugInformationSequence = 1572902;

		///<summary>
		///<para> (0018,0027) Intervention Drug Stop Time </para>
		///<para> VR: TM VM=1 </para>
		///</summary>
        public const uint InterventionDrugStopTime = 1572903;

		///<summary>
		///<para> (0018,0028) Intervention Drug Dose </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint InterventionDrugDose = 1572904;

		///<summary>
		///<para> (0018,0029) Intervention Drug Code Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint InterventionDrugCodeSequence = 1572905;

		///<summary>
		///<para> (0018,002A) Additional Drug Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint AdditionalDrugSequence = 1572906;

		///<summary>
		///<para> (0018,0030) Radionuclide (RETIRED) </para>
		///<para> VR: LO VM=1-n </para>
		///</summary>
        public const uint RadionuclideRetired = 1572912;

		///<summary>
		///<para> (0018,0031) Radiopharmaceutical </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint Radiopharmaceutical = 1572913;

		///<summary>
		///<para> (0018,0032) Energy Window Centerline (RETIRED) </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint EnergyWindowCenterlineRetired = 1572914;

		///<summary>
		///<para> (0018,0033) Energy Window Total Width (RETIRED) </para>
		///<para> VR: DS VM=1-n </para>
		///</summary>
        public const uint EnergyWindowTotalWidthRetired = 1572915;

		///<summary>
		///<para> (0018,0034) Intervention Drug Name </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint InterventionDrugName = 1572916;

		///<summary>
		///<para> (0018,0035) Intervention Drug Start Time </para>
		///<para> VR: TM VM=1 </para>
		///</summary>
        public const uint InterventionDrugStartTime = 1572917;

		///<summary>
		///<para> (0018,0036) Intervention Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint InterventionSequence = 1572918;

		///<summary>
		///<para> (0018,0037) Therapy Type (RETIRED) </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint TherapyTypeRetired = 1572919;

		///<summary>
		///<para> (0018,0038) Intervention Status </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint InterventionStatus = 1572920;

		///<summary>
		///<para> (0018,0039) Therapy Description (RETIRED) </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint TherapyDescriptionRetired = 1572921;

		///<summary>
		///<para> (0018,003A) Intervention Description </para>
		///<para> VR: ST VM=1 </para>
		///</summary>
        public const uint InterventionDescription = 1572922;

		///<summary>
		///<para> (0018,0040) Cine Rate </para>
		///<para> VR: IS VM=1 </para>
		///</summary>
        public const uint CineRate = 1572928;

		///<summary>
		///<para> (0018,0042) Initial Cine Run State </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint InitialCineRunState = 1572930;

		///<summary>
		///<para> (0018,0050) Slice Thickness </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint SliceThickness = 1572944;

		///<summary>
		///<para> (0018,0060) KVP </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint Kvp = 1572960;

		///<summary>
		///<para> (0018,0070) Counts Accumulated </para>
		///<para> VR: IS VM=1 </para>
		///</summary>
        public const uint CountsAccumulated = 1572976;

		///<summary>
		///<para> (0018,0071) Acquisition Termination Condition </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint AcquisitionTerminationCondition = 1572977;

		///<summary>
		///<para> (0018,0072) Effective Duration </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint EffectiveDuration = 1572978;

		///<summary>
		///<para> (0018,0073) Acquisition Start Condition </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint AcquisitionStartCondition = 1572979;

		///<summary>
		///<para> (0018,0074) Acquisition Start Condition Data </para>
		///<para> VR: IS VM=1 </para>
		///</summary>
        public const uint AcquisitionStartConditionData = 1572980;

		///<summary>
		///<para> (0018,0075) Acquisition Termination Condition Data </para>
		///<para> VR: IS VM=1 </para>
		///</summary>
        public const uint AcquisitionTerminationConditionData = 1572981;

		///<summary>
		///<para> (0018,0080) Repetition Time </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint RepetitionTime = 1572992;

		///<summary>
		///<para> (0018,0081) Echo Time </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint EchoTime = 1572993;

		///<summary>
		///<para> (0018,0082) Inversion Time </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint InversionTime = 1572994;

		///<summary>
		///<para> (0018,0083) Number of Averages </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint NumberOfAverages = 1572995;

		///<summary>
		///<para> (0018,0084) Imaging Frequency </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint ImagingFrequency = 1572996;

		///<summary>
		///<para> (0018,0085) Imaged Nucleus </para>
		///<para> VR: SH VM=1 </para>
		///</summary>
        public const uint ImagedNucleus = 1572997;

		///<summary>
		///<para> (0018,0086) Echo Number(s) </para>
		///<para> VR: IS VM=1-n </para>
		///</summary>
        public const uint EchoNumbers = 1572998;

		///<summary>
		///<para> (0018,0087) Magnetic Field Strength </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint MagneticFieldStrength = 1572999;

		///<summary>
		///<para> (0018,0088) Spacing Between Slices </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint SpacingBetweenSlices = 1573000;

		///<summary>
		///<para> (0018,0089) Number of Phase Encoding Steps </para>
		///<para> VR: IS VM=1 </para>
		///</summary>
        public const uint NumberOfPhaseEncodingSteps = 1573001;

		///<summary>
		///<para> (0018,0090) Data Collection Diameter </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint DataCollectionDiameter = 1573008;

		///<summary>
		///<para> (0018,0091) Echo Train Length </para>
		///<para> VR: IS VM=1 </para>
		///</summary>
        public const uint EchoTrainLength = 1573009;

		///<summary>
		///<para> (0018,0093) Percent Sampling </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint PercentSampling = 1573011;

		///<summary>
		///<para> (0018,0094) Percent Phase Field of View </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint PercentPhaseFieldOfView = 1573012;

		///<summary>
		///<para> (0018,0095) Pixel Bandwidth </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint PixelBandwidth = 1573013;

		///<summary>
		///<para> (0018,1000) Device Serial Number </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint DeviceSerialNumber = 1576960;

		///<summary>
		///<para> (0018,1002) Device UID </para>
		///<para> VR: UI VM=1 </para>
		///</summary>
        public const uint DeviceUid = 1576962;

		///<summary>
		///<para> (0018,1003) Device ID </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint DeviceId = 1576963;

		///<summary>
		///<para> (0018,1004) Plate ID </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint PlateId = 1576964;

		///<summary>
		///<para> (0018,1005) Generator ID </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint GeneratorId = 1576965;

		///<summary>
		///<para> (0018,1006) Grid ID </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint GridId = 1576966;

		///<summary>
		///<para> (0018,1007) Cassette ID </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint CassetteId = 1576967;

		///<summary>
		///<para> (0018,1008) Gantry ID </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint GantryId = 1576968;

		///<summary>
		///<para> (0018,1009) Unique Device Identifier </para>
		///<para> VR: UT VM=1 </para>
		///</summary>
        public const uint UniqueDeviceIdentifier = 1576969;

		///<summary>
		///<para> (0018,100A) UDI Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint UdiSequence = 1576970;

		///<summary>
		///<para> (0018,1010) Secondary Capture Device ID </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint SecondaryCaptureDeviceId = 1576976;

		///<summary>
		///<para> (0018,1011) Hardcopy Creation Device ID (RETIRED) </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint HardcopyCreationDeviceIdRetired = 1576977;

		///<summary>
		///<para> (0018,1012) Date of Secondary Capture </para>
		///<para> VR: DA VM=1 </para>
		///</summary>
        public const uint DateOfSecondaryCapture = 1576978;

		///<summary>
		///<para> (0018,1014) Time of Secondary Capture </para>
		///<para> VR: TM VM=1 </para>
		///</summary>
        public const uint TimeOfSecondaryCapture = 1576980;

		///<summary>
		///<para> (0018,1016) Secondary Capture Device Manufacturer </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint SecondaryCaptureDeviceManufacturer = 1576982;

		///<summary>
		///<para> (0018,1017) Hardcopy Device Manufacturer (RETIRED) </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint HardcopyDeviceManufacturerRetired = 1576983;

		///<summary>
		///<para> (0018,1018) Secondary Capture Device Manufacturer's Model Name </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint SecondaryCaptureDeviceManufacturersModelName = 1576984;

		///<summary>
		///<para> (0018,1019) Secondary Capture Device Software Versions </para>
		///<para> VR: LO VM=1-n </para>
		///</summary>
        public const uint SecondaryCaptureDeviceSoftwareVersions = 1576985;

		///<summary>
		///<para> (0018,101A) Hardcopy Device Software Version (RETIRED) </para>
		///<para> VR: LO VM=1-n </para>
		///</summary>
        public const uint HardcopyDeviceSoftwareVersionRetired = 1576986;

		///<summary>
		///<para> (0018,101B) Hardcopy Device Manufacturer's Model Name (RETIRED) </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint HardcopyDeviceManufacturersModelNameRetired = 1576987;

		///<summary>
		///<para> (0018,1020) Software Version(s) </para>
		///<para> VR: LO VM=1-n </para>
		///</summary>
        public const uint SoftwareVersions = 1576992;

		///<summary>
		///<para> (0018,1022) Video Image Format Acquired </para>
		///<para> VR: SH VM=1 </para>
		///</summary>
        public const uint VideoImageFormatAcquired = 1576994;

		///<summary>
		///<para> (0018,1023) Digital Image Format Acquired </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint DigitalImageFormatAcquired = 1576995;

		///<summary>
		///<para> (0018,1030) Protocol Name </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint ProtocolName = 1577008;

		///<summary>
		///<para> (0018,1040) Contrast/Bolus Route </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint ContrastBolusRoute = 1577024;

		///<summary>
		///<para> (0018,1041) Contrast/Bolus Volume </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint ContrastBolusVolume = 1577025;

		///<summary>
		///<para> (0018,1042) Contrast/Bolus Start Time </para>
		///<para> VR: TM VM=1 </para>
		///</summary>
        public const uint ContrastBolusStartTime = 1577026;

		///<summary>
		///<para> (0018,1043) Contrast/Bolus Stop Time </para>
		///<para> VR: TM VM=1 </para>
		///</summary>
        public const uint ContrastBolusStopTime = 1577027;

		///<summary>
		///<para> (0018,1044) Contrast/Bolus Total Dose </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint ContrastBolusTotalDose = 1577028;

		///<summary>
		///<para> (0018,1045) Syringe Counts </para>
		///<para> VR: IS VM=1 </para>
		///</summary>
        public const uint SyringeCounts = 1577029;

		///<summary>
		///<para> (0018,1046) Contrast Flow Rate </para>
		///<para> VR: DS VM=1-n </para>
		///</summary>
        public const uint ContrastFlowRate = 1577030;

		///<summary>
		///<para> (0018,1047) Contrast Flow Duration </para>
		///<para> VR: DS VM=1-n </para>
		///</summary>
        public const uint ContrastFlowDuration = 1577031;

		///<summary>
		///<para> (0018,1048) Contrast/Bolus Ingredient </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint ContrastBolusIngredient = 1577032;

		///<summary>
		///<para> (0018,1049) Contrast/Bolus Ingredient Concentration </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint ContrastBolusIngredientConcentration = 1577033;

		///<summary>
		///<para> (0018,1050) Spatial Resolution </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint SpatialResolution = 1577040;

		///<summary>
		///<para> (0018,1060) Trigger Time </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint TriggerTime = 1577056;

		///<summary>
		///<para> (0018,1061) Trigger Source or Type </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint TriggerSourceOrType = 1577057;

		///<summary>
		///<para> (0018,1062) Nominal Interval </para>
		///<para> VR: IS VM=1 </para>
		///</summary>
        public const uint NominalInterval = 1577058;

		///<summary>
		///<para> (0018,1063) Frame Time </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint FrameTime = 1577059;

		///<summary>
		///<para> (0018,1064) Cardiac Framing Type </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint CardiacFramingType = 1577060;

		///<summary>
		///<para> (0018,1065) Frame Time Vector </para>
		///<para> VR: DS VM=1-n </para>
		///</summary>
        public const uint FrameTimeVector = 1577061;

		///<summary>
		///<para> (0018,1066) Frame Delay </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint FrameDelay = 1577062;

		///<summary>
		///<para> (0018,1067) Image Trigger Delay </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint ImageTriggerDelay = 1577063;

		///<summary>
		///<para> (0018,1068) Multiplex Group Time Offset </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint MultiplexGroupTimeOffset = 1577064;

		///<summary>
		///<para> (0018,1069) Trigger Time Offset </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint TriggerTimeOffset = 1577065;

		///<summary>
		///<para> (0018,106A) Synchronization Trigger </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint SynchronizationTrigger = 1577066;

		///<summary>
		///<para> (0018,106C) Synchronization Channel </para>
		///<para> VR: US VM=2 </para>
		///</summary>
        public const uint SynchronizationChannel = 1577068;

		///<summary>
		///<para> (0018,106E) Trigger Sample Position </para>
		///<para> VR: UL VM=1 </para>
		///</summary>
        public const uint TriggerSamplePosition = 1577070;

		///<summary>
		///<para> (0018,1070) Radiopharmaceutical Route </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint RadiopharmaceuticalRoute = 1577072;

		///<summary>
		///<para> (0018,1071) Radiopharmaceutical Volume </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint RadiopharmaceuticalVolume = 1577073;

		///<summary>
		///<para> (0018,1072) Radiopharmaceutical Start Time </para>
		///<para> VR: TM VM=1 </para>
		///</summary>
        public const uint RadiopharmaceuticalStartTime = 1577074;

		///<summary>
		///<para> (0018,1073) Radiopharmaceutical Stop Time </para>
		///<para> VR: TM VM=1 </para>
		///</summary>
        public const uint RadiopharmaceuticalStopTime = 1577075;

		///<summary>
		///<para> (0018,1074) Radionuclide Total Dose </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint RadionuclideTotalDose = 1577076;

		///<summary>
		///<para> (0018,1075) Radionuclide Half Life </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint RadionuclideHalfLife = 1577077;

		///<summary>
		///<para> (0018,1076) Radionuclide Positron Fraction </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint RadionuclidePositronFraction = 1577078;

		///<summary>
		///<para> (0018,1077) Radiopharmaceutical Specific Activity </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint RadiopharmaceuticalSpecificActivity = 1577079;

		///<summary>
		///<para> (0018,1078) Radiopharmaceutical Start DateTime </para>
		///<para> VR: DT VM=1 </para>
		///</summary>
        public const uint RadiopharmaceuticalStartDatetime = 1577080;

		///<summary>
		///<para> (0018,1079) Radiopharmaceutical Stop DateTime </para>
		///<para> VR: DT VM=1 </para>
		///</summary>
        public const uint RadiopharmaceuticalStopDatetime = 1577081;

		///<summary>
		///<para> (0018,1080) Beat Rejection Flag </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint BeatRejectionFlag = 1577088;

		///<summary>
		///<para> (0018,1081) Low R-R Value </para>
		///<para> VR: IS VM=1 </para>
		///</summary>
        public const uint LowRRValue = 1577089;

		///<summary>
		///<para> (0018,1082) High R-R Value </para>
		///<para> VR: IS VM=1 </para>
		///</summary>
        public const uint HighRRValue = 1577090;

		///<summary>
		///<para> (0018,1083) Intervals Acquired </para>
		///<para> VR: IS VM=1 </para>
		///</summary>
        public const uint IntervalsAcquired = 1577091;

		///<summary>
		///<para> (0018,1084) Intervals Rejected </para>
		///<para> VR: IS VM=1 </para>
		///</summary>
        public const uint IntervalsRejected = 1577092;

		///<summary>
		///<para> (0018,1085) PVC Rejection </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint PvcRejection = 1577093;

		///<summary>
		///<para> (0018,1086) Skip Beats </para>
		///<para> VR: IS VM=1 </para>
		///</summary>
        public const uint SkipBeats = 1577094;

		///<summary>
		///<para> (0018,1088) Heart Rate </para>
		///<para> VR: IS VM=1 </para>
		///</summary>
        public const uint HeartRate = 1577096;

		///<summary>
		///<para> (0018,1090) Cardiac Number of Images </para>
		///<para> VR: IS VM=1 </para>
		///</summary>
        public const uint CardiacNumberOfImages = 1577104;

		///<summary>
		///<para> (0018,1094) Trigger Window </para>
		///<para> VR: IS VM=1 </para>
		///</summary>
        public const uint TriggerWindow = 1577108;

		///<summary>
		///<para> (0018,1100) Reconstruction Diameter </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint ReconstructionDiameter = 1577216;

		///<summary>
		///<para> (0018,1110) Distance Source to Detector </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint DistanceSourceToDetector = 1577232;

		///<summary>
		///<para> (0018,1111) Distance Source to Patient </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint DistanceSourceToPatient = 1577233;

		///<summary>
		///<para> (0018,1114) Estimated Radiographic Magnification Factor </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint EstimatedRadiographicMagnificationFactor = 1577236;

		///<summary>
		///<para> (0018,1120) Gantry/Detector Tilt </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint GantryDetectorTilt = 1577248;

		///<summary>
		///<para> (0018,1121) Gantry/Detector Slew </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint GantryDetectorSlew = 1577249;

		///<summary>
		///<para> (0018,1130) Table Height </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint TableHeight = 1577264;

		///<summary>
		///<para> (0018,1131) Table Traverse </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint TableTraverse = 1577265;

		///<summary>
		///<para> (0018,1134) Table Motion </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint TableMotion = 1577268;

		///<summary>
		///<para> (0018,1135) Table Vertical Increment </para>
		///<para> VR: DS VM=1-n </para>
		///</summary>
        public const uint TableVerticalIncrement = 1577269;

		///<summary>
		///<para> (0018,1136) Table Lateral Increment </para>
		///<para> VR: DS VM=1-n </para>
		///</summary>
        public const uint TableLateralIncrement = 1577270;

		///<summary>
		///<para> (0018,1137) Table Longitudinal Increment </para>
		///<para> VR: DS VM=1-n </para>
		///</summary>
        public const uint TableLongitudinalIncrement = 1577271;

		///<summary>
		///<para> (0018,1138) Table Angle </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint TableAngle = 1577272;

		///<summary>
		///<para> (0018,113A) Table Type </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint TableType = 1577274;

		///<summary>
		///<para> (0018,1140) Rotation Direction </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint RotationDirection = 1577280;

		///<summary>
		///<para> (0018,1141) Angular Position (RETIRED) </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint AngularPositionRetired = 1577281;

		///<summary>
		///<para> (0018,1142) Radial Position </para>
		///<para> VR: DS VM=1-n </para>
		///</summary>
        public const uint RadialPosition = 1577282;

		///<summary>
		///<para> (0018,1143) Scan Arc </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint ScanArc = 1577283;

		///<summary>
		///<para> (0018,1144) Angular Step </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint AngularStep = 1577284;

		///<summary>
		///<para> (0018,1145) Center of Rotation Offset </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint CenterOfRotationOffset = 1577285;

		///<summary>
		///<para> (0018,1146) Rotation Offset (RETIRED) </para>
		///<para> VR: DS VM=1-n </para>
		///</summary>
        public const uint RotationOffsetRetired = 1577286;

		///<summary>
		///<para> (0018,1147) Field of View Shape </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint FieldOfViewShape = 1577287;

		///<summary>
		///<para> (0018,1149) Field of View Dimension(s) </para>
		///<para> VR: IS VM=1-2 </para>
		///</summary>
        public const uint FieldOfViewDimensions = 1577289;

		///<summary>
		///<para> (0018,1150) Exposure Time </para>
		///<para> VR: IS VM=1 </para>
		///</summary>
        public const uint ExposureTime = 1577296;

		///<summary>
		///<para> (0018,1151) X-Ray Tube Current </para>
		///<para> VR: IS VM=1 </para>
		///</summary>
        public const uint XRayTubeCurrent = 1577297;

		///<summary>
		///<para> (0018,1152) Exposure </para>
		///<para> VR: IS VM=1 </para>
		///</summary>
        public const uint Exposure = 1577298;

		///<summary>
		///<para> (0018,1153) Exposure in µAs </para>
		///<para> VR: IS VM=1 </para>
		///</summary>
        public const uint ExposureInUas = 1577299;

		///<summary>
		///<para> (0018,1154) Average Pulse Width </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint AveragePulseWidth = 1577300;

		///<summary>
		///<para> (0018,1155) Radiation Setting </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint RadiationSetting = 1577301;

		///<summary>
		///<para> (0018,1156) Rectification Type </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint RectificationType = 1577302;

		///<summary>
		///<para> (0018,115A) Radiation Mode </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint RadiationMode = 1577306;

		///<summary>
		///<para> (0018,115E) Image and Fluoroscopy Area Dose Product </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint ImageAndFluoroscopyAreaDoseProduct = 1577310;

		///<summary>
		///<para> (0018,1160) Filter Type </para>
		///<para> VR: SH VM=1 </para>
		///</summary>
        public const uint FilterType = 1577312;

		///<summary>
		///<para> (0018,1161) Type of Filters </para>
		///<para> VR: LO VM=1-n </para>
		///</summary>
        public const uint TypeOfFilters = 1577313;

		///<summary>
		///<para> (0018,1162) Intensifier Size </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint IntensifierSize = 1577314;

		///<summary>
		///<para> (0018,1164) Imager Pixel Spacing </para>
		///<para> VR: DS VM=2 </para>
		///</summary>
        public const uint ImagerPixelSpacing = 1577316;

		///<summary>
		///<para> (0018,1166) Grid </para>
		///<para> VR: CS VM=1-n </para>
		///</summary>
        public const uint Grid = 1577318;

		///<summary>
		///<para> (0018,1170) Generator Power </para>
		///<para> VR: IS VM=1 </para>
		///</summary>
        public const uint GeneratorPower = 1577328;

		///<summary>
		///<para> (0018,1180) Collimator/grid Name </para>
		///<para> VR: SH VM=1 </para>
		///</summary>
        public const uint CollimatorGridName = 1577344;

		///<summary>
		///<para> (0018,1181) Collimator Type </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint CollimatorType = 1577345;

		///<summary>
		///<para> (0018,1182) Focal Distance </para>
		///<para> VR: IS VM=1-2 </para>
		///</summary>
        public const uint FocalDistance = 1577346;

		///<summary>
		///<para> (0018,1183) X Focus Center </para>
		///<para> VR: DS VM=1-2 </para>
		///</summary>
        public const uint XFocusCenter = 1577347;

		///<summary>
		///<para> (0018,1184) Y Focus Center </para>
		///<para> VR: DS VM=1-2 </para>
		///</summary>
        public const uint YFocusCenter = 1577348;

		///<summary>
		///<para> (0018,1190) Focal Spot(s) </para>
		///<para> VR: DS VM=1-n </para>
		///</summary>
        public const uint FocalSpots = 1577360;

		///<summary>
		///<para> (0018,1191) Anode Target Material </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint AnodeTargetMaterial = 1577361;

		///<summary>
		///<para> (0018,11A0) Body Part Thickness </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint BodyPartThickness = 1577376;

		///<summary>
		///<para> (0018,11A2) Compression Force </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint CompressionForce = 1577378;

		///<summary>
		///<para> (0018,11A4) Paddle Description </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint PaddleDescription = 1577380;

		///<summary>
		///<para> (0018,1200) Date of Last Calibration </para>
		///<para> VR: DA VM=1-n </para>
		///</summary>
        public const uint DateOfLastCalibration = 1577472;

		///<summary>
		///<para> (0018,1201) Time of Last Calibration </para>
		///<para> VR: TM VM=1-n </para>
		///</summary>
        public const uint TimeOfLastCalibration = 1577473;

		///<summary>
		///<para> (0018,1202) DateTime of Last Calibration </para>
		///<para> VR: DT VM=1 </para>
		///</summary>
        public const uint DatetimeOfLastCalibration = 1577474;

		///<summary>
		///<para> (0018,1210) Convolution Kernel </para>
		///<para> VR: SH VM=1-n </para>
		///</summary>
        public const uint ConvolutionKernel = 1577488;

		///<summary>
		///<para> (0018,1240) Upper/Lower Pixel Values (RETIRED) </para>
		///<para> VR: IS VM=1-n </para>
		///</summary>
        public const uint UpperLowerPixelValuesRetired = 1577536;

		///<summary>
		///<para> (0018,1242) Actual Frame Duration </para>
		///<para> VR: IS VM=1 </para>
		///</summary>
        public const uint ActualFrameDuration = 1577538;

		///<summary>
		///<para> (0018,1243) Count Rate </para>
		///<para> VR: IS VM=1 </para>
		///</summary>
        public const uint CountRate = 1577539;

		///<summary>
		///<para> (0018,1244) Preferred Playback Sequencing </para>
		///<para> VR: US VM=1 </para>
		///</summary>
        public const uint PreferredPlaybackSequencing = 1577540;

		///<summary>
		///<para> (0018,1250) Receive Coil Name </para>
		///<para> VR: SH VM=1 </para>
		///</summary>
        public const uint ReceiveCoilName = 1577552;

		///<summary>
		///<para> (0018,1251) Transmit Coil Name </para>
		///<para> VR: SH VM=1 </para>
		///</summary>
        public const uint TransmitCoilName = 1577553;

		///<summary>
		///<para> (0018,1260) Plate Type </para>
		///<para> VR: SH VM=1 </para>
		///</summary>
        public const uint PlateType = 1577568;

		///<summary>
		///<para> (0018,1261) Phosphor Type </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint PhosphorType = 1577569;

		///<summary>
		///<para> (0018,1271) Water Equivalent Diameter </para>
		///<para> VR: FD VM=1 </para>
		///</summary>
        public const uint WaterEquivalentDiameter = 1577585;

		///<summary>
		///<para> (0018,1272) Water Equivalent Diameter Calculation Method Code Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint WaterEquivalentDiameterCalculationMethodCodeSequence = 1577586;

		///<summary>
		///<para> (0018,1300) Scan Velocity </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint ScanVelocity = 1577728;

		///<summary>
		///<para> (0018,1301) Whole Body Technique </para>
		///<para> VR: CS VM=1-n </para>
		///</summary>
        public const uint WholeBodyTechnique = 1577729;

		///<summary>
		///<para> (0018,1302) Scan Length </para>
		///<para> VR: IS VM=1 </para>
		///</summary>
        public const uint ScanLength = 1577730;

		///<summary>
		///<para> (0018,1310) Acquisition Matrix </para>
		///<para> VR: US VM=4 </para>
		///</summary>
        public const uint AcquisitionMatrix = 1577744;

		///<summary>
		///<para> (0018,1312) In-plane Phase Encoding Direction </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint InPlanePhaseEncodingDirection = 1577746;

		///<summary>
		///<para> (0018,1314) Flip Angle </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint FlipAngle = 1577748;

		///<summary>
		///<para> (0018,1315) Variable Flip Angle Flag </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint VariableFlipAngleFlag = 1577749;

		///<summary>
		///<para> (0018,1316) SAR </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint Sar = 1577750;

		///<summary>
		///<para> (0018,1318) dB/dt </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint DbDt = 1577752;

		///<summary>
		///<para> (0018,1320) B1rms </para>
		///<para> VR: FL VM=1 </para>
		///</summary>
        public const uint B1rms = 1577760;

		///<summary>
		///<para> (0018,1400) Acquisition Device Processing Description </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint AcquisitionDeviceProcessingDescription = 1577984;

		///<summary>
		///<para> (0018,1401) Acquisition Device Processing Code </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint AcquisitionDeviceProcessingCode = 1577985;

		///<summary>
		///<para> (0018,1402) Cassette Orientation </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint CassetteOrientation = 1577986;

		///<summary>
		///<para> (0018,1403) Cassette Size </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint CassetteSize = 1577987;

		///<summary>
		///<para> (0018,1404) Exposures on Plate </para>
		///<para> VR: US VM=1 </para>
		///</summary>
        public const uint ExposuresOnPlate = 1577988;

		///<summary>
		///<para> (0018,1405) Relative X-Ray Exposure </para>
		///<para> VR: IS VM=1 </para>
		///</summary>
        public const uint RelativeXRayExposure = 1577989;

		///<summary>
		///<para> (0018,1411) Exposure Index </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint ExposureIndex = 1578001;

		///<summary>
		///<para> (0018,1412) Target Exposure Index </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint TargetExposureIndex = 1578002;

		///<summary>
		///<para> (0018,1413) Deviation Index </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint DeviationIndex = 1578003;

		///<summary>
		///<para> (0018,1450) Column Angulation </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint ColumnAngulation = 1578064;

		///<summary>
		///<para> (0018,1460) Tomo Layer Height </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint TomoLayerHeight = 1578080;

		///<summary>
		///<para> (0018,1470) Tomo Angle </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint TomoAngle = 1578096;

		///<summary>
		///<para> (0018,1480) Tomo Time </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint TomoTime = 1578112;

		///<summary>
		///<para> (0018,1490) Tomo Type </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint TomoType = 1578128;

		///<summary>
		///<para> (0018,1491) Tomo Class </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint TomoClass = 1578129;

		///<summary>
		///<para> (0018,1495) Number of Tomosynthesis Source Images </para>
		///<para> VR: IS VM=1 </para>
		///</summary>
        public const uint NumberOfTomosynthesisSourceImages = 1578133;

		///<summary>
		///<para> (0018,1500) Positioner Motion </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint PositionerMotion = 1578240;

		///<summary>
		///<para> (0018,1508) Positioner Type </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint PositionerType = 1578248;

		///<summary>
		///<para> (0018,1510) Positioner Primary Angle </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint PositionerPrimaryAngle = 1578256;

		///<summary>
		///<para> (0018,1511) Positioner Secondary Angle </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint PositionerSecondaryAngle = 1578257;

		///<summary>
		///<para> (0018,1520) Positioner Primary Angle Increment </para>
		///<para> VR: DS VM=1-n </para>
		///</summary>
        public const uint PositionerPrimaryAngleIncrement = 1578272;

		///<summary>
		///<para> (0018,1521) Positioner Secondary Angle Increment </para>
		///<para> VR: DS VM=1-n </para>
		///</summary>
        public const uint PositionerSecondaryAngleIncrement = 1578273;

		///<summary>
		///<para> (0018,1530) Detector Primary Angle </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint DetectorPrimaryAngle = 1578288;

		///<summary>
		///<para> (0018,1531) Detector Secondary Angle </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint DetectorSecondaryAngle = 1578289;

		///<summary>
		///<para> (0018,1600) Shutter Shape </para>
		///<para> VR: CS VM=1-3 </para>
		///</summary>
        public const uint ShutterShape = 1578496;

		///<summary>
		///<para> (0018,1602) Shutter Left Vertical Edge </para>
		///<para> VR: IS VM=1 </para>
		///</summary>
        public const uint ShutterLeftVerticalEdge = 1578498;

		///<summary>
		///<para> (0018,1604) Shutter Right Vertical Edge </para>
		///<para> VR: IS VM=1 </para>
		///</summary>
        public const uint ShutterRightVerticalEdge = 1578500;

		///<summary>
		///<para> (0018,1606) Shutter Upper Horizontal Edge </para>
		///<para> VR: IS VM=1 </para>
		///</summary>
        public const uint ShutterUpperHorizontalEdge = 1578502;

		///<summary>
		///<para> (0018,1608) Shutter Lower Horizontal Edge </para>
		///<para> VR: IS VM=1 </para>
		///</summary>
        public const uint ShutterLowerHorizontalEdge = 1578504;

		///<summary>
		///<para> (0018,1610) Center of Circular Shutter </para>
		///<para> VR: IS VM=2 </para>
		///</summary>
        public const uint CenterOfCircularShutter = 1578512;

		///<summary>
		///<para> (0018,1612) Radius of Circular Shutter </para>
		///<para> VR: IS VM=1 </para>
		///</summary>
        public const uint RadiusOfCircularShutter = 1578514;

		///<summary>
		///<para> (0018,1620) Vertices of the Polygonal Shutter </para>
		///<para> VR: IS VM=2-2n </para>
		///</summary>
        public const uint VerticesOfThePolygonalShutter = 1578528;

		///<summary>
		///<para> (0018,1622) Shutter Presentation Value </para>
		///<para> VR: US VM=1 </para>
		///</summary>
        public const uint ShutterPresentationValue = 1578530;

		///<summary>
		///<para> (0018,1623) Shutter Overlay Group </para>
		///<para> VR: US VM=1 </para>
		///</summary>
        public const uint ShutterOverlayGroup = 1578531;

		///<summary>
		///<para> (0018,1624) Shutter Presentation Color CIELab Value </para>
		///<para> VR: US VM=3 </para>
		///</summary>
        public const uint ShutterPresentationColorCielabValue = 1578532;

		///<summary>
		///<para> (0018,1700) Collimator Shape </para>
		///<para> VR: CS VM=1-3 </para>
		///</summary>
        public const uint CollimatorShape = 1578752;

		///<summary>
		///<para> (0018,1702) Collimator Left Vertical Edge </para>
		///<para> VR: IS VM=1 </para>
		///</summary>
        public const uint CollimatorLeftVerticalEdge = 1578754;

		///<summary>
		///<para> (0018,1704) Collimator Right Vertical Edge </para>
		///<para> VR: IS VM=1 </para>
		///</summary>
        public const uint CollimatorRightVerticalEdge = 1578756;

		///<summary>
		///<para> (0018,1706) Collimator Upper Horizontal Edge </para>
		///<para> VR: IS VM=1 </para>
		///</summary>
        public const uint CollimatorUpperHorizontalEdge = 1578758;

		///<summary>
		///<para> (0018,1708) Collimator Lower Horizontal Edge </para>
		///<para> VR: IS VM=1 </para>
		///</summary>
        public const uint CollimatorLowerHorizontalEdge = 1578760;

		///<summary>
		///<para> (0018,1710) Center of Circular Collimator </para>
		///<para> VR: IS VM=2 </para>
		///</summary>
        public const uint CenterOfCircularCollimator = 1578768;

		///<summary>
		///<para> (0018,1712) Radius of Circular Collimator </para>
		///<para> VR: IS VM=1 </para>
		///</summary>
        public const uint RadiusOfCircularCollimator = 1578770;

		///<summary>
		///<para> (0018,1720) Vertices of the Polygonal Collimator </para>
		///<para> VR: IS VM=2-2n </para>
		///</summary>
        public const uint VerticesOfThePolygonalCollimator = 1578784;

		///<summary>
		///<para> (0018,1800) Acquisition Time Synchronized </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint AcquisitionTimeSynchronized = 1579008;

		///<summary>
		///<para> (0018,1801) Time Source </para>
		///<para> VR: SH VM=1 </para>
		///</summary>
        public const uint TimeSource = 1579009;

		///<summary>
		///<para> (0018,1802) Time Distribution Protocol </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint TimeDistributionProtocol = 1579010;

		///<summary>
		///<para> (0018,1803) NTP Source Address </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint NtpSourceAddress = 1579011;

		///<summary>
		///<para> (0018,2001) Page Number Vector </para>
		///<para> VR: IS VM=1-n </para>
		///</summary>
        public const uint PageNumberVector = 1581057;

		///<summary>
		///<para> (0018,2002) Frame Label Vector </para>
		///<para> VR: SH VM=1-n </para>
		///</summary>
        public const uint FrameLabelVector = 1581058;

		///<summary>
		///<para> (0018,2003) Frame Primary Angle Vector </para>
		///<para> VR: DS VM=1-n </para>
		///</summary>
        public const uint FramePrimaryAngleVector = 1581059;

		///<summary>
		///<para> (0018,2004) Frame Secondary Angle Vector </para>
		///<para> VR: DS VM=1-n </para>
		///</summary>
        public const uint FrameSecondaryAngleVector = 1581060;

		///<summary>
		///<para> (0018,2005) Slice Location Vector </para>
		///<para> VR: DS VM=1-n </para>
		///</summary>
        public const uint SliceLocationVector = 1581061;

		///<summary>
		///<para> (0018,2006) Display Window Label Vector </para>
		///<para> VR: SH VM=1-n </para>
		///</summary>
        public const uint DisplayWindowLabelVector = 1581062;

		///<summary>
		///<para> (0018,2010) Nominal Scanned Pixel Spacing </para>
		///<para> VR: DS VM=2 </para>
		///</summary>
        public const uint NominalScannedPixelSpacing = 1581072;

		///<summary>
		///<para> (0018,2020) Digitizing Device Transport Direction </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint DigitizingDeviceTransportDirection = 1581088;

		///<summary>
		///<para> (0018,2030) Rotation of Scanned Film </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint RotationOfScannedFilm = 1581104;

		///<summary>
		///<para> (0018,2041) Biopsy Target Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint BiopsyTargetSequence = 1581121;

		///<summary>
		///<para> (0018,2042) Target UID </para>
		///<para> VR: UI VM=1 </para>
		///</summary>
        public const uint TargetUid = 1581122;

		///<summary>
		///<para> (0018,2043) Localizing Cursor Position </para>
		///<para> VR: FL VM=2 </para>
		///</summary>
        public const uint LocalizingCursorPosition = 1581123;

		///<summary>
		///<para> (0018,2044) Calculated Target Position </para>
		///<para> VR: FL VM=3 </para>
		///</summary>
        public const uint CalculatedTargetPosition = 1581124;

		///<summary>
		///<para> (0018,2045) Target Label </para>
		///<para> VR: SH VM=1 </para>
		///</summary>
        public const uint TargetLabel = 1581125;

		///<summary>
		///<para> (0018,2046) Displayed Z Value </para>
		///<para> VR: FL VM=1 </para>
		///</summary>
        public const uint DisplayedZValue = 1581126;

		///<summary>
		///<para> (0018,3100) IVUS Acquisition </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint IvusAcquisition = 1585408;

		///<summary>
		///<para> (0018,3101) IVUS Pullback Rate </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint IvusPullbackRate = 1585409;

		///<summary>
		///<para> (0018,3102) IVUS Gated Rate </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint IvusGatedRate = 1585410;

		///<summary>
		///<para> (0018,3103) IVUS Pullback Start Frame Number </para>
		///<para> VR: IS VM=1 </para>
		///</summary>
        public const uint IvusPullbackStartFrameNumber = 1585411;

		///<summary>
		///<para> (0018,3104) IVUS Pullback Stop Frame Number </para>
		///<para> VR: IS VM=1 </para>
		///</summary>
        public const uint IvusPullbackStopFrameNumber = 1585412;

		///<summary>
		///<para> (0018,3105) Lesion Number </para>
		///<para> VR: IS VM=1-n </para>
		///</summary>
        public const uint LesionNumber = 1585413;

		///<summary>
		///<para> (0018,4000) Acquisition Comments (RETIRED) </para>
		///<para> VR: LT VM=1 </para>
		///</summary>
        public const uint AcquisitionCommentsRetired = 1589248;

		///<summary>
		///<para> (0018,5000) Output Power </para>
		///<para> VR: SH VM=1-n </para>
		///</summary>
        public const uint OutputPower = 1593344;

		///<summary>
		///<para> (0018,5010) Transducer Data </para>
		///<para> VR: LO VM=1-n </para>
		///</summary>
        public const uint TransducerData = 1593360;

		///<summary>
		///<para> (0018,5012) Focus Depth </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint FocusDepth = 1593362;

		///<summary>
		///<para> (0018,5020) Processing Function </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint ProcessingFunction = 1593376;

		///<summary>
		///<para> (0018,5021) Postprocessing Function (RETIRED) </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint PostprocessingFunctionRetired = 1593377;

		///<summary>
		///<para> (0018,5022) Mechanical Index </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint MechanicalIndex = 1593378;

		///<summary>
		///<para> (0018,5024) Bone Thermal Index </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint BoneThermalIndex = 1593380;

		///<summary>
		///<para> (0018,5026) Cranial Thermal Index </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint CranialThermalIndex = 1593382;

		///<summary>
		///<para> (0018,5027) Soft Tissue Thermal Index </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint SoftTissueThermalIndex = 1593383;

		///<summary>
		///<para> (0018,5028) Soft Tissue-focus Thermal Index </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint SoftTissueFocusThermalIndex = 1593384;

		///<summary>
		///<para> (0018,5029) Soft Tissue-surface Thermal Index </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint SoftTissueSurfaceThermalIndex = 1593385;

		///<summary>
		///<para> (0018,5030) Dynamic Range (RETIRED) </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint DynamicRangeRetired = 1593392;

		///<summary>
		///<para> (0018,5040) Total Gain (RETIRED) </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint TotalGainRetired = 1593408;

		///<summary>
		///<para> (0018,5050) Depth of Scan Field </para>
		///<para> VR: IS VM=1 </para>
		///</summary>
        public const uint DepthOfScanField = 1593424;

		///<summary>
		///<para> (0018,5100) Patient Position </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint PatientPosition = 1593600;

		///<summary>
		///<para> (0018,5101) View Position </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint ViewPosition = 1593601;

		///<summary>
		///<para> (0018,5104) Projection Eponymous Name Code Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint ProjectionEponymousNameCodeSequence = 1593604;

		///<summary>
		///<para> (0018,5210) Image Transformation Matrix (RETIRED) </para>
		///<para> VR: DS VM=6 </para>
		///</summary>
        public const uint ImageTransformationMatrixRetired = 1593872;

		///<summary>
		///<para> (0018,5212) Image Translation Vector (RETIRED) </para>
		///<para> VR: DS VM=3 </para>
		///</summary>
        public const uint ImageTranslationVectorRetired = 1593874;

		///<summary>
		///<para> (0018,6000) Sensitivity </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint Sensitivity = 1597440;

		///<summary>
		///<para> (0018,6011) Sequence of Ultrasound Regions </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint SequenceOfUltrasoundRegions = 1597457;

		///<summary>
		///<para> (0018,6012) Region Spatial Format </para>
		///<para> VR: US VM=1 </para>
		///</summary>
        public const uint RegionSpatialFormat = 1597458;

		///<summary>
		///<para> (0018,6014) Region Data Type </para>
		///<para> VR: US VM=1 </para>
		///</summary>
        public const uint RegionDataType = 1597460;

		///<summary>
		///<para> (0018,6016) Region Flags </para>
		///<para> VR: UL VM=1 </para>
		///</summary>
        public const uint RegionFlags = 1597462;

		///<summary>
		///<para> (0018,6018) Region Location Min X0 </para>
		///<para> VR: UL VM=1 </para>
		///</summary>
        public const uint RegionLocationMinX0 = 1597464;

		///<summary>
		///<para> (0018,601A) Region Location Min Y0 </para>
		///<para> VR: UL VM=1 </para>
		///</summary>
        public const uint RegionLocationMinY0 = 1597466;

		///<summary>
		///<para> (0018,601C) Region Location Max X1 </para>
		///<para> VR: UL VM=1 </para>
		///</summary>
        public const uint RegionLocationMaxX1 = 1597468;

		///<summary>
		///<para> (0018,601E) Region Location Max Y1 </para>
		///<para> VR: UL VM=1 </para>
		///</summary>
        public const uint RegionLocationMaxY1 = 1597470;

		///<summary>
		///<para> (0018,6020) Reference Pixel X0 </para>
		///<para> VR: SL VM=1 </para>
		///</summary>
        public const uint ReferencePixelX0 = 1597472;

		///<summary>
		///<para> (0018,6022) Reference Pixel Y0 </para>
		///<para> VR: SL VM=1 </para>
		///</summary>
        public const uint ReferencePixelY0 = 1597474;

		///<summary>
		///<para> (0018,6024) Physical Units X Direction </para>
		///<para> VR: US VM=1 </para>
		///</summary>
        public const uint PhysicalUnitsXDirection = 1597476;

		///<summary>
		///<para> (0018,6026) Physical Units Y Direction </para>
		///<para> VR: US VM=1 </para>
		///</summary>
        public const uint PhysicalUnitsYDirection = 1597478;

		///<summary>
		///<para> (0018,6028) Reference Pixel Physical Value X </para>
		///<para> VR: FD VM=1 </para>
		///</summary>
        public const uint ReferencePixelPhysicalValueX = 1597480;

		///<summary>
		///<para> (0018,602A) Reference Pixel Physical Value Y </para>
		///<para> VR: FD VM=1 </para>
		///</summary>
        public const uint ReferencePixelPhysicalValueY = 1597482;

		///<summary>
		///<para> (0018,602C) Physical Delta X </para>
		///<para> VR: FD VM=1 </para>
		///</summary>
        public const uint PhysicalDeltaX = 1597484;

		///<summary>
		///<para> (0018,602E) Physical Delta Y </para>
		///<para> VR: FD VM=1 </para>
		///</summary>
        public const uint PhysicalDeltaY = 1597486;

		///<summary>
		///<para> (0018,6030) Transducer Frequency </para>
		///<para> VR: UL VM=1 </para>
		///</summary>
        public const uint TransducerFrequency = 1597488;

		///<summary>
		///<para> (0018,6031) Transducer Type </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint TransducerType = 1597489;

		///<summary>
		///<para> (0018,6032) Pulse Repetition Frequency </para>
		///<para> VR: UL VM=1 </para>
		///</summary>
        public const uint PulseRepetitionFrequency = 1597490;

		///<summary>
		///<para> (0018,6034) Doppler Correction Angle </para>
		///<para> VR: FD VM=1 </para>
		///</summary>
        public const uint DopplerCorrectionAngle = 1597492;

		///<summary>
		///<para> (0018,6036) Steering Angle </para>
		///<para> VR: FD VM=1 </para>
		///</summary>
        public const uint SteeringAngle = 1597494;

		///<summary>
		///<para> (0018,6038) Doppler Sample Volume X Position (Retired) (RETIRED) </para>
		///<para> VR: UL VM=1 </para>
		///</summary>
        public const uint DopplerSampleVolumeXPositionRetiredRetired = 1597496;

		///<summary>
		///<para> (0018,6039) Doppler Sample Volume X Position </para>
		///<para> VR: SL VM=1 </para>
		///</summary>
        public const uint DopplerSampleVolumeXPosition = 1597497;

		///<summary>
		///<para> (0018,603A) Doppler Sample Volume Y Position (Retired) (RETIRED) </para>
		///<para> VR: UL VM=1 </para>
		///</summary>
        public const uint DopplerSampleVolumeYPositionRetiredRetired = 1597498;

		///<summary>
		///<para> (0018,603B) Doppler Sample Volume Y Position </para>
		///<para> VR: SL VM=1 </para>
		///</summary>
        public const uint DopplerSampleVolumeYPosition = 1597499;

		///<summary>
		///<para> (0018,603C) TM-Line Position X0 (Retired) (RETIRED) </para>
		///<para> VR: UL VM=1 </para>
		///</summary>
        public const uint TmLinePositionX0RetiredRetired = 1597500;

		///<summary>
		///<para> (0018,603D) TM-Line Position X0 </para>
		///<para> VR: SL VM=1 </para>
		///</summary>
        public const uint TmLinePositionX0 = 1597501;

		///<summary>
		///<para> (0018,603E) TM-Line Position Y0 (Retired) (RETIRED) </para>
		///<para> VR: UL VM=1 </para>
		///</summary>
        public const uint TmLinePositionY0RetiredRetired = 1597502;

		///<summary>
		///<para> (0018,603F) TM-Line Position Y0 </para>
		///<para> VR: SL VM=1 </para>
		///</summary>
        public const uint TmLinePositionY0 = 1597503;

		///<summary>
		///<para> (0018,6040) TM-Line Position X1 (Retired) (RETIRED) </para>
		///<para> VR: UL VM=1 </para>
		///</summary>
        public const uint TmLinePositionX1RetiredRetired = 1597504;

		///<summary>
		///<para> (0018,6041) TM-Line Position X1 </para>
		///<para> VR: SL VM=1 </para>
		///</summary>
        public const uint TmLinePositionX1 = 1597505;

		///<summary>
		///<para> (0018,6042) TM-Line Position Y1 (Retired) (RETIRED) </para>
		///<para> VR: UL VM=1 </para>
		///</summary>
        public const uint TmLinePositionY1RetiredRetired = 1597506;

		///<summary>
		///<para> (0018,6043) TM-Line Position Y1 </para>
		///<para> VR: SL VM=1 </para>
		///</summary>
        public const uint TmLinePositionY1 = 1597507;

		///<summary>
		///<para> (0018,6044) Pixel Component Organization </para>
		///<para> VR: US VM=1 </para>
		///</summary>
        public const uint PixelComponentOrganization = 1597508;

		///<summary>
		///<para> (0018,6046) Pixel Component Mask </para>
		///<para> VR: UL VM=1 </para>
		///</summary>
        public const uint PixelComponentMask = 1597510;

		///<summary>
		///<para> (0018,6048) Pixel Component Range Start </para>
		///<para> VR: UL VM=1 </para>
		///</summary>
        public const uint PixelComponentRangeStart = 1597512;

		///<summary>
		///<para> (0018,604A) Pixel Component Range Stop </para>
		///<para> VR: UL VM=1 </para>
		///</summary>
        public const uint PixelComponentRangeStop = 1597514;

		///<summary>
		///<para> (0018,604C) Pixel Component Physical Units </para>
		///<para> VR: US VM=1 </para>
		///</summary>
        public const uint PixelComponentPhysicalUnits = 1597516;

		///<summary>
		///<para> (0018,604E) Pixel Component Data Type </para>
		///<para> VR: US VM=1 </para>
		///</summary>
        public const uint PixelComponentDataType = 1597518;

		///<summary>
		///<para> (0018,6050) Number of Table Break Points </para>
		///<para> VR: UL VM=1 </para>
		///</summary>
        public const uint NumberOfTableBreakPoints = 1597520;

		///<summary>
		///<para> (0018,6052) Table of X Break Points </para>
		///<para> VR: UL VM=1-n </para>
		///</summary>
        public const uint TableOfXBreakPoints = 1597522;

		///<summary>
		///<para> (0018,6054) Table of Y Break Points </para>
		///<para> VR: FD VM=1-n </para>
		///</summary>
        public const uint TableOfYBreakPoints = 1597524;

		///<summary>
		///<para> (0018,6056) Number of Table Entries </para>
		///<para> VR: UL VM=1 </para>
		///</summary>
        public const uint NumberOfTableEntries = 1597526;

		///<summary>
		///<para> (0018,6058) Table of Pixel Values </para>
		///<para> VR: UL VM=1-n </para>
		///</summary>
        public const uint TableOfPixelValues = 1597528;

		///<summary>
		///<para> (0018,605A) Table of Parameter Values </para>
		///<para> VR: FL VM=1-n </para>
		///</summary>
        public const uint TableOfParameterValues = 1597530;

		///<summary>
		///<para> (0018,6060) R Wave Time Vector </para>
		///<para> VR: FL VM=1-n </para>
		///</summary>
        public const uint RWaveTimeVector = 1597536;

		///<summary>
		///<para> (0018,7000) Detector Conditions Nominal Flag </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint DetectorConditionsNominalFlag = 1601536;

		///<summary>
		///<para> (0018,7001) Detector Temperature </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint DetectorTemperature = 1601537;

		///<summary>
		///<para> (0018,7004) Detector Type </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint DetectorType = 1601540;

		///<summary>
		///<para> (0018,7005) Detector Configuration </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint DetectorConfiguration = 1601541;

		///<summary>
		///<para> (0018,7006) Detector Description </para>
		///<para> VR: LT VM=1 </para>
		///</summary>
        public const uint DetectorDescription = 1601542;

		///<summary>
		///<para> (0018,7008) Detector Mode </para>
		///<para> VR: LT VM=1 </para>
		///</summary>
        public const uint DetectorMode = 1601544;

		///<summary>
		///<para> (0018,700A) Detector ID </para>
		///<para> VR: SH VM=1 </para>
		///</summary>
        public const uint DetectorId = 1601546;

		///<summary>
		///<para> (0018,700C) Date of Last Detector Calibration </para>
		///<para> VR: DA VM=1 </para>
		///</summary>
        public const uint DateOfLastDetectorCalibration = 1601548;

		///<summary>
		///<para> (0018,700E) Time of Last Detector Calibration </para>
		///<para> VR: TM VM=1 </para>
		///</summary>
        public const uint TimeOfLastDetectorCalibration = 1601550;

		///<summary>
		///<para> (0018,7010) Exposures on Detector Since Last Calibration </para>
		///<para> VR: IS VM=1 </para>
		///</summary>
        public const uint ExposuresOnDetectorSinceLastCalibration = 1601552;

		///<summary>
		///<para> (0018,7011) Exposures on Detector Since Manufactured </para>
		///<para> VR: IS VM=1 </para>
		///</summary>
        public const uint ExposuresOnDetectorSinceManufactured = 1601553;

		///<summary>
		///<para> (0018,7012) Detector Time Since Last Exposure </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint DetectorTimeSinceLastExposure = 1601554;

		///<summary>
		///<para> (0018,7014) Detector Active Time </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint DetectorActiveTime = 1601556;

		///<summary>
		///<para> (0018,7016) Detector Activation Offset From Exposure </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint DetectorActivationOffsetFromExposure = 1601558;

		///<summary>
		///<para> (0018,701A) Detector Binning </para>
		///<para> VR: DS VM=2 </para>
		///</summary>
        public const uint DetectorBinning = 1601562;

		///<summary>
		///<para> (0018,7020) Detector Element Physical Size </para>
		///<para> VR: DS VM=2 </para>
		///</summary>
        public const uint DetectorElementPhysicalSize = 1601568;

		///<summary>
		///<para> (0018,7022) Detector Element Spacing </para>
		///<para> VR: DS VM=2 </para>
		///</summary>
        public const uint DetectorElementSpacing = 1601570;

		///<summary>
		///<para> (0018,7024) Detector Active Shape </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint DetectorActiveShape = 1601572;

		///<summary>
		///<para> (0018,7026) Detector Active Dimension(s) </para>
		///<para> VR: DS VM=1-2 </para>
		///</summary>
        public const uint DetectorActiveDimensions = 1601574;

		///<summary>
		///<para> (0018,7028) Detector Active Origin </para>
		///<para> VR: DS VM=2 </para>
		///</summary>
        public const uint DetectorActiveOrigin = 1601576;

		///<summary>
		///<para> (0018,702A) Detector Manufacturer Name </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint DetectorManufacturerName = 1601578;

		///<summary>
		///<para> (0018,702B) Detector Manufacturer's Model Name </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint DetectorManufacturersModelName = 1601579;

		///<summary>
		///<para> (0018,7030) Field of View Origin </para>
		///<para> VR: DS VM=2 </para>
		///</summary>
        public const uint FieldOfViewOrigin = 1601584;

		///<summary>
		///<para> (0018,7032) Field of View Rotation </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint FieldOfViewRotation = 1601586;

		///<summary>
		///<para> (0018,7034) Field of View Horizontal Flip </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint FieldOfViewHorizontalFlip = 1601588;

		///<summary>
		///<para> (0018,7036) Pixel Data Area Origin Relative To FOV </para>
		///<para> VR: FL VM=2 </para>
		///</summary>
        public const uint PixelDataAreaOriginRelativeToFov = 1601590;

		///<summary>
		///<para> (0018,7038) Pixel Data Area Rotation Angle Relative To FOV </para>
		///<para> VR: FL VM=1 </para>
		///</summary>
        public const uint PixelDataAreaRotationAngleRelativeToFov = 1601592;

		///<summary>
		///<para> (0018,7040) Grid Absorbing Material </para>
		///<para> VR: LT VM=1 </para>
		///</summary>
        public const uint GridAbsorbingMaterial = 1601600;

		///<summary>
		///<para> (0018,7041) Grid Spacing Material </para>
		///<para> VR: LT VM=1 </para>
		///</summary>
        public const uint GridSpacingMaterial = 1601601;

		///<summary>
		///<para> (0018,7042) Grid Thickness </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint GridThickness = 1601602;

		///<summary>
		///<para> (0018,7044) Grid Pitch </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint GridPitch = 1601604;

		///<summary>
		///<para> (0018,7046) Grid Aspect Ratio </para>
		///<para> VR: IS VM=2 </para>
		///</summary>
        public const uint GridAspectRatio = 1601606;

		///<summary>
		///<para> (0018,7048) Grid Period </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint GridPeriod = 1601608;

		///<summary>
		///<para> (0018,704C) Grid Focal Distance </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint GridFocalDistance = 1601612;

		///<summary>
		///<para> (0018,7050) Filter Material </para>
		///<para> VR: CS VM=1-n </para>
		///</summary>
        public const uint FilterMaterial = 1601616;

		///<summary>
		///<para> (0018,7052) Filter Thickness Minimum </para>
		///<para> VR: DS VM=1-n </para>
		///</summary>
        public const uint FilterThicknessMinimum = 1601618;

		///<summary>
		///<para> (0018,7054) Filter Thickness Maximum </para>
		///<para> VR: DS VM=1-n </para>
		///</summary>
        public const uint FilterThicknessMaximum = 1601620;

		///<summary>
		///<para> (0018,7056) Filter Beam Path Length Minimum </para>
		///<para> VR: FL VM=1-n </para>
		///</summary>
        public const uint FilterBeamPathLengthMinimum = 1601622;

		///<summary>
		///<para> (0018,7058) Filter Beam Path Length Maximum </para>
		///<para> VR: FL VM=1-n </para>
		///</summary>
        public const uint FilterBeamPathLengthMaximum = 1601624;

		///<summary>
		///<para> (0018,7060) Exposure Control Mode </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint ExposureControlMode = 1601632;

		///<summary>
		///<para> (0018,7062) Exposure Control Mode Description </para>
		///<para> VR: LT VM=1 </para>
		///</summary>
        public const uint ExposureControlModeDescription = 1601634;

		///<summary>
		///<para> (0018,7064) Exposure Status </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint ExposureStatus = 1601636;

		///<summary>
		///<para> (0018,7065) Phototimer Setting </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint PhototimerSetting = 1601637;

		///<summary>
		///<para> (0018,8150) Exposure Time in µS </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint ExposureTimeInUs = 1605968;

		///<summary>
		///<para> (0018,8151) X-Ray Tube Current in µA </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint XRayTubeCurrentInUa = 1605969;

		///<summary>
		///<para> (0018,9004) Content Qualification </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint ContentQualification = 1609732;

		///<summary>
		///<para> (0018,9005) Pulse Sequence Name </para>
		///<para> VR: SH VM=1 </para>
		///</summary>
        public const uint PulseSequenceName = 1609733;

		///<summary>
		///<para> (0018,9006) MR Imaging Modifier Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint MrImagingModifierSequence = 1609734;

		///<summary>
		///<para> (0018,9008) Echo Pulse Sequence </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint EchoPulseSequence = 1609736;

		///<summary>
		///<para> (0018,9009) Inversion Recovery </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint InversionRecovery = 1609737;

		///<summary>
		///<para> (0018,9010) Flow Compensation </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint FlowCompensation = 1609744;

		///<summary>
		///<para> (0018,9011) Multiple Spin Echo </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint MultipleSpinEcho = 1609745;

		///<summary>
		///<para> (0018,9012) Multi-planar Excitation </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint MultiPlanarExcitation = 1609746;

		///<summary>
		///<para> (0018,9014) Phase Contrast </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint PhaseContrast = 1609748;

		///<summary>
		///<para> (0018,9015) Time of Flight Contrast </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint TimeOfFlightContrast = 1609749;

		///<summary>
		///<para> (0018,9016) Spoiling </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint Spoiling = 1609750;

		///<summary>
		///<para> (0018,9017) Steady State Pulse Sequence </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint SteadyStatePulseSequence = 1609751;

		///<summary>
		///<para> (0018,9018) Echo Planar Pulse Sequence </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint EchoPlanarPulseSequence = 1609752;

		///<summary>
		///<para> (0018,9019) Tag Angle First Axis </para>
		///<para> VR: FD VM=1 </para>
		///</summary>
        public const uint TagAngleFirstAxis = 1609753;

		///<summary>
		///<para> (0018,9020) Magnetization Transfer </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint MagnetizationTransfer = 1609760;

		///<summary>
		///<para> (0018,9021) T2 Preparation </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint T2Preparation = 1609761;

		///<summary>
		///<para> (0018,9022) Blood Signal Nulling </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint BloodSignalNulling = 1609762;

		///<summary>
		///<para> (0018,9024) Saturation Recovery </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint SaturationRecovery = 1609764;

		///<summary>
		///<para> (0018,9025) Spectrally Selected Suppression </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint SpectrallySelectedSuppression = 1609765;

		///<summary>
		///<para> (0018,9026) Spectrally Selected Excitation </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint SpectrallySelectedExcitation = 1609766;

		///<summary>
		///<para> (0018,9027) Spatial Pre-saturation </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint SpatialPreSaturation = 1609767;

		///<summary>
		///<para> (0018,9028) Tagging </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint Tagging = 1609768;

		///<summary>
		///<para> (0018,9029) Oversampling Phase </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint OversamplingPhase = 1609769;

		///<summary>
		///<para> (0018,9030) Tag Spacing First Dimension </para>
		///<para> VR: FD VM=1 </para>
		///</summary>
        public const uint TagSpacingFirstDimension = 1609776;

		///<summary>
		///<para> (0018,9032) Geometry of k-Space Traversal </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint GeometryOfKSpaceTraversal = 1609778;

		///<summary>
		///<para> (0018,9033) Segmented k-Space Traversal </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint SegmentedKSpaceTraversal = 1609779;

		///<summary>
		///<para> (0018,9034) Rectilinear Phase Encode Reordering </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint RectilinearPhaseEncodeReordering = 1609780;

		///<summary>
		///<para> (0018,9035) Tag Thickness </para>
		///<para> VR: FD VM=1 </para>
		///</summary>
        public const uint TagThickness = 1609781;

		///<summary>
		///<para> (0018,9036) Partial Fourier Direction </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint PartialFourierDirection = 1609782;

		///<summary>
		///<para> (0018,9037) Cardiac Synchronization Technique </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint CardiacSynchronizationTechnique = 1609783;

		///<summary>
		///<para> (0018,9041) Receive Coil Manufacturer Name </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint ReceiveCoilManufacturerName = 1609793;

		///<summary>
		///<para> (0018,9042) MR Receive Coil Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint MrReceiveCoilSequence = 1609794;

		///<summary>
		///<para> (0018,9043) Receive Coil Type </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint ReceiveCoilType = 1609795;

		///<summary>
		///<para> (0018,9044) Quadrature Receive Coil </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint QuadratureReceiveCoil = 1609796;

		///<summary>
		///<para> (0018,9045) Multi-Coil Definition Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint MultiCoilDefinitionSequence = 1609797;

		///<summary>
		///<para> (0018,9046) Multi-Coil Configuration </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint MultiCoilConfiguration = 1609798;

		///<summary>
		///<para> (0018,9047) Multi-Coil Element Name </para>
		///<para> VR: SH VM=1 </para>
		///</summary>
        public const uint MultiCoilElementName = 1609799;

		///<summary>
		///<para> (0018,9048) Multi-Coil Element Used </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint MultiCoilElementUsed = 1609800;

		///<summary>
		///<para> (0018,9049) MR Transmit Coil Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint MrTransmitCoilSequence = 1609801;

		///<summary>
		///<para> (0018,9050) Transmit Coil Manufacturer Name </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint TransmitCoilManufacturerName = 1609808;

		///<summary>
		///<para> (0018,9051) Transmit Coil Type </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint TransmitCoilType = 1609809;

		///<summary>
		///<para> (0018,9052) Spectral Width </para>
		///<para> VR: FD VM=1-2 </para>
		///</summary>
        public const uint SpectralWidth = 1609810;

		///<summary>
		///<para> (0018,9053) Chemical Shift Reference </para>
		///<para> VR: FD VM=1-2 </para>
		///</summary>
        public const uint ChemicalShiftReference = 1609811;

		///<summary>
		///<para> (0018,9054) Volume Localization Technique </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint VolumeLocalizationTechnique = 1609812;

		///<summary>
		///<para> (0018,9058) MR Acquisition Frequency Encoding Steps </para>
		///<para> VR: US VM=1 </para>
		///</summary>
        public const uint MrAcquisitionFrequencyEncodingSteps = 1609816;

		///<summary>
		///<para> (0018,9059) De-coupling </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint DeCoupling = 1609817;

		///<summary>
		///<para> (0018,9060) De-coupled Nucleus </para>
		///<para> VR: CS VM=1-2 </para>
		///</summary>
        public const uint DeCoupledNucleus = 1609824;

		///<summary>
		///<para> (0018,9061) De-coupling Frequency </para>
		///<para> VR: FD VM=1-2 </para>
		///</summary>
        public const uint DeCouplingFrequency = 1609825;

		///<summary>
		///<para> (0018,9062) De-coupling Method </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint DeCouplingMethod = 1609826;

		///<summary>
		///<para> (0018,9063) De-coupling Chemical Shift Reference </para>
		///<para> VR: FD VM=1-2 </para>
		///</summary>
        public const uint DeCouplingChemicalShiftReference = 1609827;

		///<summary>
		///<para> (0018,9064) k-space Filtering </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint KSpaceFiltering = 1609828;

		///<summary>
		///<para> (0018,9065) Time Domain Filtering </para>
		///<para> VR: CS VM=1-2 </para>
		///</summary>
        public const uint TimeDomainFiltering = 1609829;

		///<summary>
		///<para> (0018,9066) Number of Zero Fills </para>
		///<para> VR: US VM=1-2 </para>
		///</summary>
        public const uint NumberOfZeroFills = 1609830;

		///<summary>
		///<para> (0018,9067) Baseline Correction </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint BaselineCorrection = 1609831;

		///<summary>
		///<para> (0018,9069) Parallel Reduction Factor In-plane </para>
		///<para> VR: FD VM=1 </para>
		///</summary>
        public const uint ParallelReductionFactorInPlane = 1609833;

		///<summary>
		///<para> (0018,9070) Cardiac R-R Interval Specified </para>
		///<para> VR: FD VM=1 </para>
		///</summary>
        public const uint CardiacRRIntervalSpecified = 1609840;

		///<summary>
		///<para> (0018,9073) Acquisition Duration </para>
		///<para> VR: FD VM=1 </para>
		///</summary>
        public const uint AcquisitionDuration = 1609843;

		///<summary>
		///<para> (0018,9074) Frame Acquisition DateTime </para>
		///<para> VR: DT VM=1 </para>
		///</summary>
        public const uint FrameAcquisitionDatetime = 1609844;

		///<summary>
		///<para> (0018,9075) Diffusion Directionality </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint DiffusionDirectionality = 1609845;

		///<summary>
		///<para> (0018,9076) Diffusion Gradient Direction Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint DiffusionGradientDirectionSequence = 1609846;

		///<summary>
		///<para> (0018,9077) Parallel Acquisition </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint ParallelAcquisition = 1609847;

		///<summary>
		///<para> (0018,9078) Parallel Acquisition Technique </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint ParallelAcquisitionTechnique = 1609848;

		///<summary>
		///<para> (0018,9079) Inversion Times </para>
		///<para> VR: FD VM=1-n </para>
		///</summary>
        public const uint InversionTimes = 1609849;

		///<summary>
		///<para> (0018,9080) Metabolite Map Description </para>
		///<para> VR: ST VM=1 </para>
		///</summary>
        public const uint MetaboliteMapDescription = 1609856;

		///<summary>
		///<para> (0018,9081) Partial Fourier </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint PartialFourier = 1609857;

		///<summary>
		///<para> (0018,9082) Effective Echo Time </para>
		///<para> VR: FD VM=1 </para>
		///</summary>
        public const uint EffectiveEchoTime = 1609858;

		///<summary>
		///<para> (0018,9083) Metabolite Map Code Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint MetaboliteMapCodeSequence = 1609859;

		///<summary>
		///<para> (0018,9084) Chemical Shift Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint ChemicalShiftSequence = 1609860;

		///<summary>
		///<para> (0018,9085) Cardiac Signal Source </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint CardiacSignalSource = 1609861;

		///<summary>
		///<para> (0018,9087) Diffusion b-value </para>
		///<para> VR: FD VM=1 </para>
		///</summary>
        public const uint DiffusionBValue = 1609863;

		///<summary>
		///<para> (0018,9089) Diffusion Gradient Orientation </para>
		///<para> VR: FD VM=3 </para>
		///</summary>
        public const uint DiffusionGradientOrientation = 1609865;

		///<summary>
		///<para> (0018,9090) Velocity Encoding Direction </para>
		///<para> VR: FD VM=3 </para>
		///</summary>
        public const uint VelocityEncodingDirection = 1609872;

		///<summary>
		///<para> (0018,9091) Velocity Encoding Minimum Value </para>
		///<para> VR: FD VM=1 </para>
		///</summary>
        public const uint VelocityEncodingMinimumValue = 1609873;

		///<summary>
		///<para> (0018,9092) Velocity Encoding Acquisition Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint VelocityEncodingAcquisitionSequence = 1609874;

		///<summary>
		///<para> (0018,9093) Number of k-Space Trajectories </para>
		///<para> VR: US VM=1 </para>
		///</summary>
        public const uint NumberOfKSpaceTrajectories = 1609875;

		///<summary>
		///<para> (0018,9094) Coverage of k-Space </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint CoverageOfKSpace = 1609876;

		///<summary>
		///<para> (0018,9095) Spectroscopy Acquisition Phase Rows </para>
		///<para> VR: UL VM=1 </para>
		///</summary>
        public const uint SpectroscopyAcquisitionPhaseRows = 1609877;

		///<summary>
		///<para> (0018,9096) Parallel Reduction Factor In-plane (Retired) (RETIRED) </para>
		///<para> VR: FD VM=1 </para>
		///</summary>
        public const uint ParallelReductionFactorInPlaneRetiredRetired = 1609878;

		///<summary>
		///<para> (0018,9098) Transmitter Frequency </para>
		///<para> VR: FD VM=1-2 </para>
		///</summary>
        public const uint TransmitterFrequency = 1609880;

		///<summary>
		///<para> (0018,9100) Resonant Nucleus </para>
		///<para> VR: CS VM=1-2 </para>
		///</summary>
        public const uint ResonantNucleus = 1609984;

		///<summary>
		///<para> (0018,9101) Frequency Correction </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint FrequencyCorrection = 1609985;

		///<summary>
		///<para> (0018,9103) MR Spectroscopy FOV/Geometry Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint MrSpectroscopyFovGeometrySequence = 1609987;

		///<summary>
		///<para> (0018,9104) Slab Thickness </para>
		///<para> VR: FD VM=1 </para>
		///</summary>
        public const uint SlabThickness = 1609988;

		///<summary>
		///<para> (0018,9105) Slab Orientation </para>
		///<para> VR: FD VM=3 </para>
		///</summary>
        public const uint SlabOrientation = 1609989;

		///<summary>
		///<para> (0018,9106) Mid Slab Position </para>
		///<para> VR: FD VM=3 </para>
		///</summary>
        public const uint MidSlabPosition = 1609990;

		///<summary>
		///<para> (0018,9107) MR Spatial Saturation Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint MrSpatialSaturationSequence = 1609991;

		///<summary>
		///<para> (0018,9112) MR Timing and Related Parameters Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint MrTimingAndRelatedParametersSequence = 1610002;

		///<summary>
		///<para> (0018,9114) MR Echo Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint MrEchoSequence = 1610004;

		///<summary>
		///<para> (0018,9115) MR Modifier Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint MrModifierSequence = 1610005;

		///<summary>
		///<para> (0018,9117) MR Diffusion Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint MrDiffusionSequence = 1610007;

		///<summary>
		///<para> (0018,9118) Cardiac Synchronization Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint CardiacSynchronizationSequence = 1610008;

		///<summary>
		///<para> (0018,9119) MR Averages Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint MrAveragesSequence = 1610009;

		///<summary>
		///<para> (0018,9125) MR FOV/Geometry Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint MrFovGeometrySequence = 1610021;

		///<summary>
		///<para> (0018,9126) Volume Localization Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint VolumeLocalizationSequence = 1610022;

		///<summary>
		///<para> (0018,9127) Spectroscopy Acquisition Data Columns </para>
		///<para> VR: UL VM=1 </para>
		///</summary>
        public const uint SpectroscopyAcquisitionDataColumns = 1610023;

		///<summary>
		///<para> (0018,9147) Diffusion Anisotropy Type </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint DiffusionAnisotropyType = 1610055;

		///<summary>
		///<para> (0018,9151) Frame Reference DateTime </para>
		///<para> VR: DT VM=1 </para>
		///</summary>
        public const uint FrameReferenceDatetime = 1610065;

		///<summary>
		///<para> (0018,9152) MR Metabolite Map Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint MrMetaboliteMapSequence = 1610066;

		///<summary>
		///<para> (0018,9155) Parallel Reduction Factor out-of-plane </para>
		///<para> VR: FD VM=1 </para>
		///</summary>
        public const uint ParallelReductionFactorOutOfPlane = 1610069;

		///<summary>
		///<para> (0018,9159) Spectroscopy Acquisition Out-of-plane Phase Steps </para>
		///<para> VR: UL VM=1 </para>
		///</summary>
        public const uint SpectroscopyAcquisitionOutOfPlanePhaseSteps = 1610073;

		///<summary>
		///<para> (0018,9166) Bulk Motion Status (RETIRED) </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint BulkMotionStatusRetired = 1610086;

		///<summary>
		///<para> (0018,9168) Parallel Reduction Factor Second In-plane </para>
		///<para> VR: FD VM=1 </para>
		///</summary>
        public const uint ParallelReductionFactorSecondInPlane = 1610088;

		///<summary>
		///<para> (0018,9169) Cardiac Beat Rejection Technique </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint CardiacBeatRejectionTechnique = 1610089;

		///<summary>
		///<para> (0018,9170) Respiratory Motion Compensation Technique </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint RespiratoryMotionCompensationTechnique = 1610096;

		///<summary>
		///<para> (0018,9171) Respiratory Signal Source </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint RespiratorySignalSource = 1610097;

		///<summary>
		///<para> (0018,9172) Bulk Motion Compensation Technique </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint BulkMotionCompensationTechnique = 1610098;

		///<summary>
		///<para> (0018,9173) Bulk Motion Signal Source </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint BulkMotionSignalSource = 1610099;

		///<summary>
		///<para> (0018,9174) Applicable Safety Standard Agency </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint ApplicableSafetyStandardAgency = 1610100;

		///<summary>
		///<para> (0018,9175) Applicable Safety Standard Description </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint ApplicableSafetyStandardDescription = 1610101;

		///<summary>
		///<para> (0018,9176) Operating Mode Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint OperatingModeSequence = 1610102;

		///<summary>
		///<para> (0018,9177) Operating Mode Type </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint OperatingModeType = 1610103;

		///<summary>
		///<para> (0018,9178) Operating Mode </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint OperatingMode = 1610104;

		///<summary>
		///<para> (0018,9179) Specific Absorption Rate Definition </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint SpecificAbsorptionRateDefinition = 1610105;

		///<summary>
		///<para> (0018,9180) Gradient Output Type </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint GradientOutputType = 1610112;

		///<summary>
		///<para> (0018,9181) Specific Absorption Rate Value </para>
		///<para> VR: FD VM=1 </para>
		///</summary>
        public const uint SpecificAbsorptionRateValue = 1610113;

		///<summary>
		///<para> (0018,9182) Gradient Output </para>
		///<para> VR: FD VM=1 </para>
		///</summary>
        public const uint GradientOutput = 1610114;

		///<summary>
		///<para> (0018,9183) Flow Compensation Direction </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint FlowCompensationDirection = 1610115;

		///<summary>
		///<para> (0018,9184) Tagging Delay </para>
		///<para> VR: FD VM=1 </para>
		///</summary>
        public const uint TaggingDelay = 1610116;

		///<summary>
		///<para> (0018,9185) Respiratory Motion Compensation Technique Description </para>
		///<para> VR: ST VM=1 </para>
		///</summary>
        public const uint RespiratoryMotionCompensationTechniqueDescription = 1610117;

		///<summary>
		///<para> (0018,9186) Respiratory Signal Source ID </para>
		///<para> VR: SH VM=1 </para>
		///</summary>
        public const uint RespiratorySignalSourceId = 1610118;

		///<summary>
		///<para> (0018,9195) Chemical Shift Minimum Integration Limit in Hz (RETIRED) </para>
		///<para> VR: FD VM=1 </para>
		///</summary>
        public const uint ChemicalShiftMinimumIntegrationLimitInHzRetired = 1610133;

		///<summary>
		///<para> (0018,9196) Chemical Shift Maximum Integration Limit in Hz (RETIRED) </para>
		///<para> VR: FD VM=1 </para>
		///</summary>
        public const uint ChemicalShiftMaximumIntegrationLimitInHzRetired = 1610134;

		///<summary>
		///<para> (0018,9197) MR Velocity Encoding Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint MrVelocityEncodingSequence = 1610135;

		///<summary>
		///<para> (0018,9198) First Order Phase Correction </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint FirstOrderPhaseCorrection = 1610136;

		///<summary>
		///<para> (0018,9199) Water Referenced Phase Correction </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint WaterReferencedPhaseCorrection = 1610137;

		///<summary>
		///<para> (0018,9200) MR Spectroscopy Acquisition Type </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint MrSpectroscopyAcquisitionType = 1610240;

		///<summary>
		///<para> (0018,9214) Respiratory Cycle Position </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint RespiratoryCyclePosition = 1610260;

		///<summary>
		///<para> (0018,9217) Velocity Encoding Maximum Value </para>
		///<para> VR: FD VM=1 </para>
		///</summary>
        public const uint VelocityEncodingMaximumValue = 1610263;

		///<summary>
		///<para> (0018,9218) Tag Spacing Second Dimension </para>
		///<para> VR: FD VM=1 </para>
		///</summary>
        public const uint TagSpacingSecondDimension = 1610264;

		///<summary>
		///<para> (0018,9219) Tag Angle Second Axis </para>
		///<para> VR: SS VM=1 </para>
		///</summary>
        public const uint TagAngleSecondAxis = 1610265;

		///<summary>
		///<para> (0018,9220) Frame Acquisition Duration </para>
		///<para> VR: FD VM=1 </para>
		///</summary>
        public const uint FrameAcquisitionDuration = 1610272;

		///<summary>
		///<para> (0018,9226) MR Image Frame Type Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint MrImageFrameTypeSequence = 1610278;

		///<summary>
		///<para> (0018,9227) MR Spectroscopy Frame Type Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint MrSpectroscopyFrameTypeSequence = 1610279;

		///<summary>
		///<para> (0018,9231) MR Acquisition Phase Encoding Steps in-plane </para>
		///<para> VR: US VM=1 </para>
		///</summary>
        public const uint MrAcquisitionPhaseEncodingStepsInPlane = 1610289;

		///<summary>
		///<para> (0018,9232) MR Acquisition Phase Encoding Steps out-of-plane </para>
		///<para> VR: US VM=1 </para>
		///</summary>
        public const uint MrAcquisitionPhaseEncodingStepsOutOfPlane = 1610290;

		///<summary>
		///<para> (0018,9234) Spectroscopy Acquisition Phase Columns </para>
		///<para> VR: UL VM=1 </para>
		///</summary>
        public const uint SpectroscopyAcquisitionPhaseColumns = 1610292;

		///<summary>
		///<para> (0018,9236) Cardiac Cycle Position </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint CardiacCyclePosition = 1610294;

		///<summary>
		///<para> (0018,9239) Specific Absorption Rate Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint SpecificAbsorptionRateSequence = 1610297;

		///<summary>
		///<para> (0018,9240) RF Echo Train Length </para>
		///<para> VR: US VM=1 </para>
		///</summary>
        public const uint RfEchoTrainLength = 1610304;

		///<summary>
		///<para> (0018,9241) Gradient Echo Train Length </para>
		///<para> VR: US VM=1 </para>
		///</summary>
        public const uint GradientEchoTrainLength = 1610305;

		///<summary>
		///<para> (0018,9250) Arterial Spin Labeling Contrast </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint ArterialSpinLabelingContrast = 1610320;

		///<summary>
		///<para> (0018,9251) MR Arterial Spin Labeling Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint MrArterialSpinLabelingSequence = 1610321;

		///<summary>
		///<para> (0018,9252) ASL Technique Description </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint AslTechniqueDescription = 1610322;

		///<summary>
		///<para> (0018,9253) ASL Slab Number </para>
		///<para> VR: US VM=1 </para>
		///</summary>
        public const uint AslSlabNumber = 1610323;

		///<summary>
		///<para> (0018,9254) ASL Slab Thickness </para>
		///<para> VR: FD VM=1 </para>
		///</summary>
        public const uint AslSlabThickness = 1610324;

		///<summary>
		///<para> (0018,9255) ASL Slab Orientation </para>
		///<para> VR: FD VM=3 </para>
		///</summary>
        public const uint AslSlabOrientation = 1610325;

		///<summary>
		///<para> (0018,9256) ASL Mid Slab Position </para>
		///<para> VR: FD VM=3 </para>
		///</summary>
        public const uint AslMidSlabPosition = 1610326;

		///<summary>
		///<para> (0018,9257) ASL Context </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint AslContext = 1610327;

		///<summary>
		///<para> (0018,9258) ASL Pulse Train Duration </para>
		///<para> VR: UL VM=1 </para>
		///</summary>
        public const uint AslPulseTrainDuration = 1610328;

		///<summary>
		///<para> (0018,9259) ASL Crusher Flag </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint AslCrusherFlag = 1610329;

		///<summary>
		///<para> (0018,925A) ASL Crusher Flow Limit </para>
		///<para> VR: FD VM=1 </para>
		///</summary>
        public const uint AslCrusherFlowLimit = 1610330;

		///<summary>
		///<para> (0018,925B) ASL Crusher Description </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint AslCrusherDescription = 1610331;

		///<summary>
		///<para> (0018,925C) ASL Bolus Cut-off Flag </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint AslBolusCutOffFlag = 1610332;

		///<summary>
		///<para> (0018,925D) ASL Bolus Cut-off Timing Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint AslBolusCutOffTimingSequence = 1610333;

		///<summary>
		///<para> (0018,925E) ASL Bolus Cut-off Technique </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint AslBolusCutOffTechnique = 1610334;

		///<summary>
		///<para> (0018,925F) ASL Bolus Cut-off Delay Time </para>
		///<para> VR: UL VM=1 </para>
		///</summary>
        public const uint AslBolusCutOffDelayTime = 1610335;

		///<summary>
		///<para> (0018,9260) ASL Slab Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint AslSlabSequence = 1610336;

		///<summary>
		///<para> (0018,9295) Chemical Shift Minimum Integration Limit in ppm </para>
		///<para> VR: FD VM=1 </para>
		///</summary>
        public const uint ChemicalShiftMinimumIntegrationLimitInPpm = 1610389;

		///<summary>
		///<para> (0018,9296) Chemical Shift Maximum Integration Limit in ppm </para>
		///<para> VR: FD VM=1 </para>
		///</summary>
        public const uint ChemicalShiftMaximumIntegrationLimitInPpm = 1610390;

		///<summary>
		///<para> (0018,9297) Water Reference Acquisition </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint WaterReferenceAcquisition = 1610391;

		///<summary>
		///<para> (0018,9298) Echo Peak Position </para>
		///<para> VR: IS VM=1 </para>
		///</summary>
        public const uint EchoPeakPosition = 1610392;

		///<summary>
		///<para> (0018,9301) CT Acquisition Type Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint CtAcquisitionTypeSequence = 1610497;

		///<summary>
		///<para> (0018,9302) Acquisition Type </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint AcquisitionType = 1610498;

		///<summary>
		///<para> (0018,9303) Tube Angle </para>
		///<para> VR: FD VM=1 </para>
		///</summary>
        public const uint TubeAngle = 1610499;

		///<summary>
		///<para> (0018,9304) CT Acquisition Details Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint CtAcquisitionDetailsSequence = 1610500;

		///<summary>
		///<para> (0018,9305) Revolution Time </para>
		///<para> VR: FD VM=1 </para>
		///</summary>
        public const uint RevolutionTime = 1610501;

		///<summary>
		///<para> (0018,9306) Single Collimation Width </para>
		///<para> VR: FD VM=1 </para>
		///</summary>
        public const uint SingleCollimationWidth = 1610502;

		///<summary>
		///<para> (0018,9307) Total Collimation Width </para>
		///<para> VR: FD VM=1 </para>
		///</summary>
        public const uint TotalCollimationWidth = 1610503;

		///<summary>
		///<para> (0018,9308) CT Table Dynamics Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint CtTableDynamicsSequence = 1610504;

		///<summary>
		///<para> (0018,9309) Table Speed </para>
		///<para> VR: FD VM=1 </para>
		///</summary>
        public const uint TableSpeed = 1610505;

		///<summary>
		///<para> (0018,9310) Table Feed per Rotation </para>
		///<para> VR: FD VM=1 </para>
		///</summary>
        public const uint TableFeedPerRotation = 1610512;

		///<summary>
		///<para> (0018,9311) Spiral Pitch Factor </para>
		///<para> VR: FD VM=1 </para>
		///</summary>
        public const uint SpiralPitchFactor = 1610513;

		///<summary>
		///<para> (0018,9312) CT Geometry Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint CtGeometrySequence = 1610514;

		///<summary>
		///<para> (0018,9313) Data Collection Center (Patient) </para>
		///<para> VR: FD VM=3 </para>
		///</summary>
        public const uint DataCollectionCenterPatient = 1610515;

		///<summary>
		///<para> (0018,9314) CT Reconstruction Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint CtReconstructionSequence = 1610516;

		///<summary>
		///<para> (0018,9315) Reconstruction Algorithm </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint ReconstructionAlgorithm = 1610517;

		///<summary>
		///<para> (0018,9316) Convolution Kernel Group </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint ConvolutionKernelGroup = 1610518;

		///<summary>
		///<para> (0018,9317) Reconstruction Field of View </para>
		///<para> VR: FD VM=2 </para>
		///</summary>
        public const uint ReconstructionFieldOfView = 1610519;

		///<summary>
		///<para> (0018,9318) Reconstruction Target Center (Patient) </para>
		///<para> VR: FD VM=3 </para>
		///</summary>
        public const uint ReconstructionTargetCenterPatient = 1610520;

		///<summary>
		///<para> (0018,9319) Reconstruction Angle </para>
		///<para> VR: FD VM=1 </para>
		///</summary>
        public const uint ReconstructionAngle = 1610521;

		///<summary>
		///<para> (0018,9320) Image Filter </para>
		///<para> VR: SH VM=1 </para>
		///</summary>
        public const uint ImageFilter = 1610528;

		///<summary>
		///<para> (0018,9321) CT Exposure Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint CtExposureSequence = 1610529;

		///<summary>
		///<para> (0018,9322) Reconstruction Pixel Spacing </para>
		///<para> VR: FD VM=2 </para>
		///</summary>
        public const uint ReconstructionPixelSpacing = 1610530;

		///<summary>
		///<para> (0018,9323) Exposure Modulation Type </para>
		///<para> VR: CS VM=1-n </para>
		///</summary>
        public const uint ExposureModulationType = 1610531;

		///<summary>
		///<para> (0018,9324) Estimated Dose Saving </para>
		///<para> VR: FD VM=1 </para>
		///</summary>
        public const uint EstimatedDoseSaving = 1610532;

		///<summary>
		///<para> (0018,9325) CT X-Ray Details Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint CtXRayDetailsSequence = 1610533;

		///<summary>
		///<para> (0018,9326) CT Position Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint CtPositionSequence = 1610534;

		///<summary>
		///<para> (0018,9327) Table Position </para>
		///<para> VR: FD VM=1 </para>
		///</summary>
        public const uint TablePosition = 1610535;

		///<summary>
		///<para> (0018,9328) Exposure Time in ms </para>
		///<para> VR: FD VM=1 </para>
		///</summary>
        public const uint ExposureTimeInMs = 1610536;

		///<summary>
		///<para> (0018,9329) CT Image Frame Type Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint CtImageFrameTypeSequence = 1610537;

		///<summary>
		///<para> (0018,9330) X-Ray Tube Current in mA </para>
		///<para> VR: FD VM=1 </para>
		///</summary>
        public const uint XRayTubeCurrentInMa = 1610544;

		///<summary>
		///<para> (0018,9332) Exposure in mAs </para>
		///<para> VR: FD VM=1 </para>
		///</summary>
        public const uint ExposureInMas = 1610546;

		///<summary>
		///<para> (0018,9333) Constant Volume Flag </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint ConstantVolumeFlag = 1610547;

		///<summary>
		///<para> (0018,9334) Fluoroscopy Flag </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint FluoroscopyFlag = 1610548;

		///<summary>
		///<para> (0018,9335) Distance Source to Data Collection Center </para>
		///<para> VR: FD VM=1 </para>
		///</summary>
        public const uint DistanceSourceToDataCollectionCenter = 1610549;

		///<summary>
		///<para> (0018,9337) Contrast/Bolus Agent Number </para>
		///<para> VR: US VM=1 </para>
		///</summary>
        public const uint ContrastBolusAgentNumber = 1610551;

		///<summary>
		///<para> (0018,9338) Contrast/Bolus Ingredient Code Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint ContrastBolusIngredientCodeSequence = 1610552;

		///<summary>
		///<para> (0018,9340) Contrast Administration Profile Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint ContrastAdministrationProfileSequence = 1610560;

		///<summary>
		///<para> (0018,9341) Contrast/Bolus Usage Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint ContrastBolusUsageSequence = 1610561;

		///<summary>
		///<para> (0018,9342) Contrast/Bolus Agent Administered </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint ContrastBolusAgentAdministered = 1610562;

		///<summary>
		///<para> (0018,9343) Contrast/Bolus Agent Detected </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint ContrastBolusAgentDetected = 1610563;

		///<summary>
		///<para> (0018,9344) Contrast/Bolus Agent Phase </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint ContrastBolusAgentPhase = 1610564;

		///<summary>
		///<para> (0018,9345) CTDIvol </para>
		///<para> VR: FD VM=1 </para>
		///</summary>
        public const uint Ctdivol = 1610565;

		///<summary>
		///<para> (0018,9346) CTDI Phantom Type Code Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint CtdiPhantomTypeCodeSequence = 1610566;

		///<summary>
		///<para> (0018,9351) Calcium Scoring Mass Factor Patient </para>
		///<para> VR: FL VM=1 </para>
		///</summary>
        public const uint CalciumScoringMassFactorPatient = 1610577;

		///<summary>
		///<para> (0018,9352) Calcium Scoring Mass Factor Device </para>
		///<para> VR: FL VM=3 </para>
		///</summary>
        public const uint CalciumScoringMassFactorDevice = 1610578;

		///<summary>
		///<para> (0018,9353) Energy Weighting Factor </para>
		///<para> VR: FL VM=1 </para>
		///</summary>
        public const uint EnergyWeightingFactor = 1610579;

		///<summary>
		///<para> (0018,9360) CT Additional X-Ray Source Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint CtAdditionalXRaySourceSequence = 1610592;

		///<summary>
		///<para> (0018,9401) Projection Pixel Calibration Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint ProjectionPixelCalibrationSequence = 1610753;

		///<summary>
		///<para> (0018,9402) Distance Source to Isocenter </para>
		///<para> VR: FL VM=1 </para>
		///</summary>
        public const uint DistanceSourceToIsocenter = 1610754;

		///<summary>
		///<para> (0018,9403) Distance Object to Table Top </para>
		///<para> VR: FL VM=1 </para>
		///</summary>
        public const uint DistanceObjectToTableTop = 1610755;

		///<summary>
		///<para> (0018,9404) Object Pixel Spacing in Center of Beam </para>
		///<para> VR: FL VM=2 </para>
		///</summary>
        public const uint ObjectPixelSpacingInCenterOfBeam = 1610756;

		///<summary>
		///<para> (0018,9405) Positioner Position Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint PositionerPositionSequence = 1610757;

		///<summary>
		///<para> (0018,9406) Table Position Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint TablePositionSequence = 1610758;

		///<summary>
		///<para> (0018,9407) Collimator Shape Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint CollimatorShapeSequence = 1610759;

		///<summary>
		///<para> (0018,9410) Planes in Acquisition </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint PlanesInAcquisition = 1610768;

		///<summary>
		///<para> (0018,9412) XA/XRF Frame Characteristics Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint XaXrfFrameCharacteristicsSequence = 1610770;

		///<summary>
		///<para> (0018,9417) Frame Acquisition Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint FrameAcquisitionSequence = 1610775;

		///<summary>
		///<para> (0018,9420) X-Ray Receptor Type </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint XRayReceptorType = 1610784;

		///<summary>
		///<para> (0018,9423) Acquisition Protocol Name </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint AcquisitionProtocolName = 1610787;

		///<summary>
		///<para> (0018,9424) Acquisition Protocol Description </para>
		///<para> VR: LT VM=1 </para>
		///</summary>
        public const uint AcquisitionProtocolDescription = 1610788;

		///<summary>
		///<para> (0018,9425) Contrast/Bolus Ingredient Opaque </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint ContrastBolusIngredientOpaque = 1610789;

		///<summary>
		///<para> (0018,9426) Distance Receptor Plane to Detector Housing </para>
		///<para> VR: FL VM=1 </para>
		///</summary>
        public const uint DistanceReceptorPlaneToDetectorHousing = 1610790;

		///<summary>
		///<para> (0018,9427) Intensifier Active Shape </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint IntensifierActiveShape = 1610791;

		///<summary>
		///<para> (0018,9428) Intensifier Active Dimension(s) </para>
		///<para> VR: FL VM=1-2 </para>
		///</summary>
        public const uint IntensifierActiveDimensions = 1610792;

		///<summary>
		///<para> (0018,9429) Physical Detector Size </para>
		///<para> VR: FL VM=2 </para>
		///</summary>
        public const uint PhysicalDetectorSize = 1610793;

		///<summary>
		///<para> (0018,9430) Position of Isocenter Projection </para>
		///<para> VR: FL VM=2 </para>
		///</summary>
        public const uint PositionOfIsocenterProjection = 1610800;

		///<summary>
		///<para> (0018,9432) Field of View Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint FieldOfViewSequence = 1610802;

		///<summary>
		///<para> (0018,9433) Field of View Description </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint FieldOfViewDescription = 1610803;

		///<summary>
		///<para> (0018,9434) Exposure Control Sensing Regions Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint ExposureControlSensingRegionsSequence = 1610804;

		///<summary>
		///<para> (0018,9435) Exposure Control Sensing Region Shape </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint ExposureControlSensingRegionShape = 1610805;

		///<summary>
		///<para> (0018,9436) Exposure Control Sensing Region Left Vertical Edge </para>
		///<para> VR: SS VM=1 </para>
		///</summary>
        public const uint ExposureControlSensingRegionLeftVerticalEdge = 1610806;

		///<summary>
		///<para> (0018,9437) Exposure Control Sensing Region Right Vertical Edge </para>
		///<para> VR: SS VM=1 </para>
		///</summary>
        public const uint ExposureControlSensingRegionRightVerticalEdge = 1610807;

		///<summary>
		///<para> (0018,9438) Exposure Control Sensing Region Upper Horizontal Edge </para>
		///<para> VR: SS VM=1 </para>
		///</summary>
        public const uint ExposureControlSensingRegionUpperHorizontalEdge = 1610808;

		///<summary>
		///<para> (0018,9439) Exposure Control Sensing Region Lower Horizontal Edge </para>
		///<para> VR: SS VM=1 </para>
		///</summary>
        public const uint ExposureControlSensingRegionLowerHorizontalEdge = 1610809;

		///<summary>
		///<para> (0018,9440) Center of Circular Exposure Control Sensing Region </para>
		///<para> VR: SS VM=2 </para>
		///</summary>
        public const uint CenterOfCircularExposureControlSensingRegion = 1610816;

		///<summary>
		///<para> (0018,9441) Radius of Circular Exposure Control Sensing Region </para>
		///<para> VR: US VM=1 </para>
		///</summary>
        public const uint RadiusOfCircularExposureControlSensingRegion = 1610817;

		///<summary>
		///<para> (0018,9442) Vertices of the Polygonal Exposure Control Sensing Region </para>
		///<para> VR: SS VM=2-n </para>
		///</summary>
        public const uint VerticesOfThePolygonalExposureControlSensingRegion = 1610818;

		///<summary>
		///<para> (0018,9447) Column Angulation (Patient) </para>
		///<para> VR: FL VM=1 </para>
		///</summary>
        public const uint ColumnAngulationPatient = 1610823;

		///<summary>
		///<para> (0018,9449) Beam Angle </para>
		///<para> VR: FL VM=1 </para>
		///</summary>
        public const uint BeamAngle = 1610825;

		///<summary>
		///<para> (0018,9451) Frame Detector Parameters Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint FrameDetectorParametersSequence = 1610833;

		///<summary>
		///<para> (0018,9452) Calculated Anatomy Thickness </para>
		///<para> VR: FL VM=1 </para>
		///</summary>
        public const uint CalculatedAnatomyThickness = 1610834;

		///<summary>
		///<para> (0018,9455) Calibration Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint CalibrationSequence = 1610837;

		///<summary>
		///<para> (0018,9456) Object Thickness Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint ObjectThicknessSequence = 1610838;

		///<summary>
		///<para> (0018,9457) Plane Identification </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint PlaneIdentification = 1610839;

		///<summary>
		///<para> (0018,9461) Field of View Dimension(s) in Float </para>
		///<para> VR: FL VM=1-2 </para>
		///</summary>
        public const uint FieldOfViewDimensionsInFloat = 1610849;

		///<summary>
		///<para> (0018,9462) Isocenter Reference System Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint IsocenterReferenceSystemSequence = 1610850;

		///<summary>
		///<para> (0018,9463) Positioner Isocenter Primary Angle </para>
		///<para> VR: FL VM=1 </para>
		///</summary>
        public const uint PositionerIsocenterPrimaryAngle = 1610851;

		///<summary>
		///<para> (0018,9464) Positioner Isocenter Secondary Angle </para>
		///<para> VR: FL VM=1 </para>
		///</summary>
        public const uint PositionerIsocenterSecondaryAngle = 1610852;

		///<summary>
		///<para> (0018,9465) Positioner Isocenter Detector Rotation Angle </para>
		///<para> VR: FL VM=1 </para>
		///</summary>
        public const uint PositionerIsocenterDetectorRotationAngle = 1610853;

		///<summary>
		///<para> (0018,9466) Table X Position to Isocenter </para>
		///<para> VR: FL VM=1 </para>
		///</summary>
        public const uint TableXPositionToIsocenter = 1610854;

		///<summary>
		///<para> (0018,9467) Table Y Position to Isocenter </para>
		///<para> VR: FL VM=1 </para>
		///</summary>
        public const uint TableYPositionToIsocenter = 1610855;

		///<summary>
		///<para> (0018,9468) Table Z Position to Isocenter </para>
		///<para> VR: FL VM=1 </para>
		///</summary>
        public const uint TableZPositionToIsocenter = 1610856;

		///<summary>
		///<para> (0018,9469) Table Horizontal Rotation Angle </para>
		///<para> VR: FL VM=1 </para>
		///</summary>
        public const uint TableHorizontalRotationAngle = 1610857;

		///<summary>
		///<para> (0018,9470) Table Head Tilt Angle </para>
		///<para> VR: FL VM=1 </para>
		///</summary>
        public const uint TableHeadTiltAngle = 1610864;

		///<summary>
		///<para> (0018,9471) Table Cradle Tilt Angle </para>
		///<para> VR: FL VM=1 </para>
		///</summary>
        public const uint TableCradleTiltAngle = 1610865;

		///<summary>
		///<para> (0018,9472) Frame Display Shutter Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint FrameDisplayShutterSequence = 1610866;

		///<summary>
		///<para> (0018,9473) Acquired Image Area Dose Product </para>
		///<para> VR: FL VM=1 </para>
		///</summary>
        public const uint AcquiredImageAreaDoseProduct = 1610867;

		///<summary>
		///<para> (0018,9474) C-arm Positioner Tabletop Relationship </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint CArmPositionerTabletopRelationship = 1610868;

		///<summary>
		///<para> (0018,9476) X-Ray Geometry Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint XRayGeometrySequence = 1610870;

		///<summary>
		///<para> (0018,9477) Irradiation Event Identification Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint IrradiationEventIdentificationSequence = 1610871;

		///<summary>
		///<para> (0018,9504) X-Ray 3D Frame Type Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint XRay3dFrameTypeSequence = 1611012;

		///<summary>
		///<para> (0018,9506) Contributing Sources Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint ContributingSourcesSequence = 1611014;

		///<summary>
		///<para> (0018,9507) X-Ray 3D Acquisition Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint XRay3dAcquisitionSequence = 1611015;

		///<summary>
		///<para> (0018,9508) Primary Positioner Scan Arc </para>
		///<para> VR: FL VM=1 </para>
		///</summary>
        public const uint PrimaryPositionerScanArc = 1611016;

		///<summary>
		///<para> (0018,9509) Secondary Positioner Scan Arc </para>
		///<para> VR: FL VM=1 </para>
		///</summary>
        public const uint SecondaryPositionerScanArc = 1611017;

		///<summary>
		///<para> (0018,9510) Primary Positioner Scan Start Angle </para>
		///<para> VR: FL VM=1 </para>
		///</summary>
        public const uint PrimaryPositionerScanStartAngle = 1611024;

		///<summary>
		///<para> (0018,9511) Secondary Positioner Scan Start Angle </para>
		///<para> VR: FL VM=1 </para>
		///</summary>
        public const uint SecondaryPositionerScanStartAngle = 1611025;

		///<summary>
		///<para> (0018,9514) Primary Positioner Increment </para>
		///<para> VR: FL VM=1 </para>
		///</summary>
        public const uint PrimaryPositionerIncrement = 1611028;

		///<summary>
		///<para> (0018,9515) Secondary Positioner Increment </para>
		///<para> VR: FL VM=1 </para>
		///</summary>
        public const uint SecondaryPositionerIncrement = 1611029;

		///<summary>
		///<para> (0018,9516) Start Acquisition DateTime </para>
		///<para> VR: DT VM=1 </para>
		///</summary>
        public const uint StartAcquisitionDatetime = 1611030;

		///<summary>
		///<para> (0018,9517) End Acquisition DateTime </para>
		///<para> VR: DT VM=1 </para>
		///</summary>
        public const uint EndAcquisitionDatetime = 1611031;

		///<summary>
		///<para> (0018,9518) Primary Positioner Increment Sign </para>
		///<para> VR: SS VM=1 </para>
		///</summary>
        public const uint PrimaryPositionerIncrementSign = 1611032;

		///<summary>
		///<para> (0018,9519) Secondary Positioner Increment Sign </para>
		///<para> VR: SS VM=1 </para>
		///</summary>
        public const uint SecondaryPositionerIncrementSign = 1611033;

		///<summary>
		///<para> (0018,9524) Application Name </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint ApplicationName = 1611044;

		///<summary>
		///<para> (0018,9525) Application Version </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint ApplicationVersion = 1611045;

		///<summary>
		///<para> (0018,9526) Application Manufacturer </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint ApplicationManufacturer = 1611046;

		///<summary>
		///<para> (0018,9527) Algorithm Type </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint AlgorithmType = 1611047;

		///<summary>
		///<para> (0018,9528) Algorithm Description </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint AlgorithmDescription = 1611048;

		///<summary>
		///<para> (0018,9530) X-Ray 3D Reconstruction Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint XRay3dReconstructionSequence = 1611056;

		///<summary>
		///<para> (0018,9531) Reconstruction Description </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint ReconstructionDescription = 1611057;

		///<summary>
		///<para> (0018,9538) Per Projection Acquisition Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint PerProjectionAcquisitionSequence = 1611064;

		///<summary>
		///<para> (0018,9541) Detector Position Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint DetectorPositionSequence = 1611073;

		///<summary>
		///<para> (0018,9542) X-Ray Acquisition Dose Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint XRayAcquisitionDoseSequence = 1611074;

		///<summary>
		///<para> (0018,9543) X-Ray Source Isocenter Primary Angle </para>
		///<para> VR: FD VM=1 </para>
		///</summary>
        public const uint XRaySourceIsocenterPrimaryAngle = 1611075;

		///<summary>
		///<para> (0018,9544) X-Ray Source Isocenter Secondary Angle </para>
		///<para> VR: FD VM=1 </para>
		///</summary>
        public const uint XRaySourceIsocenterSecondaryAngle = 1611076;

		///<summary>
		///<para> (0018,9545) Breast Support Isocenter Primary Angle </para>
		///<para> VR: FD VM=1 </para>
		///</summary>
        public const uint BreastSupportIsocenterPrimaryAngle = 1611077;

		///<summary>
		///<para> (0018,9546) Breast Support Isocenter Secondary Angle </para>
		///<para> VR: FD VM=1 </para>
		///</summary>
        public const uint BreastSupportIsocenterSecondaryAngle = 1611078;

		///<summary>
		///<para> (0018,9547) Breast Support X Position to Isocenter </para>
		///<para> VR: FD VM=1 </para>
		///</summary>
        public const uint BreastSupportXPositionToIsocenter = 1611079;

		///<summary>
		///<para> (0018,9548) Breast Support Y Position to Isocenter </para>
		///<para> VR: FD VM=1 </para>
		///</summary>
        public const uint BreastSupportYPositionToIsocenter = 1611080;

		///<summary>
		///<para> (0018,9549) Breast Support Z Position to Isocenter </para>
		///<para> VR: FD VM=1 </para>
		///</summary>
        public const uint BreastSupportZPositionToIsocenter = 1611081;

		///<summary>
		///<para> (0018,9550) Detector Isocenter Primary Angle </para>
		///<para> VR: FD VM=1 </para>
		///</summary>
        public const uint DetectorIsocenterPrimaryAngle = 1611088;

		///<summary>
		///<para> (0018,9551) Detector Isocenter Secondary Angle </para>
		///<para> VR: FD VM=1 </para>
		///</summary>
        public const uint DetectorIsocenterSecondaryAngle = 1611089;

		///<summary>
		///<para> (0018,9552) Detector X Position to Isocenter </para>
		///<para> VR: FD VM=1 </para>
		///</summary>
        public const uint DetectorXPositionToIsocenter = 1611090;

		///<summary>
		///<para> (0018,9553) Detector Y Position to Isocenter </para>
		///<para> VR: FD VM=1 </para>
		///</summary>
        public const uint DetectorYPositionToIsocenter = 1611091;

		///<summary>
		///<para> (0018,9554) Detector Z Position to Isocenter </para>
		///<para> VR: FD VM=1 </para>
		///</summary>
        public const uint DetectorZPositionToIsocenter = 1611092;

		///<summary>
		///<para> (0018,9555) X-Ray Grid Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint XRayGridSequence = 1611093;

		///<summary>
		///<para> (0018,9556) X-Ray Filter Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint XRayFilterSequence = 1611094;

		///<summary>
		///<para> (0018,9557) Detector Active Area TLHC Position </para>
		///<para> VR: FD VM=3 </para>
		///</summary>
        public const uint DetectorActiveAreaTlhcPosition = 1611095;

		///<summary>
		///<para> (0018,9558) Detector Active Area Orientation </para>
		///<para> VR: FD VM=6 </para>
		///</summary>
        public const uint DetectorActiveAreaOrientation = 1611096;

		///<summary>
		///<para> (0018,9559) Positioner Primary Angle Direction </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint PositionerPrimaryAngleDirection = 1611097;

		///<summary>
		///<para> (0018,9601) Diffusion b-matrix Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint DiffusionBMatrixSequence = 1611265;

		///<summary>
		///<para> (0018,9602) Diffusion b-value XX </para>
		///<para> VR: FD VM=1 </para>
		///</summary>
        public const uint DiffusionBValueXx = 1611266;

		///<summary>
		///<para> (0018,9603) Diffusion b-value XY </para>
		///<para> VR: FD VM=1 </para>
		///</summary>
        public const uint DiffusionBValueXy = 1611267;

		///<summary>
		///<para> (0018,9604) Diffusion b-value XZ </para>
		///<para> VR: FD VM=1 </para>
		///</summary>
        public const uint DiffusionBValueXz = 1611268;

		///<summary>
		///<para> (0018,9605) Diffusion b-value YY </para>
		///<para> VR: FD VM=1 </para>
		///</summary>
        public const uint DiffusionBValueYy = 1611269;

		///<summary>
		///<para> (0018,9606) Diffusion b-value YZ </para>
		///<para> VR: FD VM=1 </para>
		///</summary>
        public const uint DiffusionBValueYz = 1611270;

		///<summary>
		///<para> (0018,9607) Diffusion b-value ZZ </para>
		///<para> VR: FD VM=1 </para>
		///</summary>
        public const uint DiffusionBValueZz = 1611271;

		///<summary>
		///<para> (0018,9621) Functional MR Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint FunctionalMrSequence = 1611297;

		///<summary>
		///<para> (0018,9622) Functional Settling Phase Frames Present </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint FunctionalSettlingPhaseFramesPresent = 1611298;

		///<summary>
		///<para> (0018,9623) Functional Sync Pulse </para>
		///<para> VR: DT VM=1 </para>
		///</summary>
        public const uint FunctionalSyncPulse = 1611299;

		///<summary>
		///<para> (0018,9624) Settling Phase Frame </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint SettlingPhaseFrame = 1611300;

		///<summary>
		///<para> (0018,9701) Decay Correction DateTime </para>
		///<para> VR: DT VM=1 </para>
		///</summary>
        public const uint DecayCorrectionDatetime = 1611521;

		///<summary>
		///<para> (0018,9715) Start Density Threshold </para>
		///<para> VR: FD VM=1 </para>
		///</summary>
        public const uint StartDensityThreshold = 1611541;

		///<summary>
		///<para> (0018,9716) Start Relative Density Difference Threshold </para>
		///<para> VR: FD VM=1 </para>
		///</summary>
        public const uint StartRelativeDensityDifferenceThreshold = 1611542;

		///<summary>
		///<para> (0018,9717) Start Cardiac Trigger Count Threshold </para>
		///<para> VR: FD VM=1 </para>
		///</summary>
        public const uint StartCardiacTriggerCountThreshold = 1611543;

		///<summary>
		///<para> (0018,9718) Start Respiratory Trigger Count Threshold </para>
		///<para> VR: FD VM=1 </para>
		///</summary>
        public const uint StartRespiratoryTriggerCountThreshold = 1611544;

		///<summary>
		///<para> (0018,9719) Termination Counts Threshold </para>
		///<para> VR: FD VM=1 </para>
		///</summary>
        public const uint TerminationCountsThreshold = 1611545;

		///<summary>
		///<para> (0018,9720) Termination Density Threshold </para>
		///<para> VR: FD VM=1 </para>
		///</summary>
        public const uint TerminationDensityThreshold = 1611552;

		///<summary>
		///<para> (0018,9721) Termination Relative Density Threshold </para>
		///<para> VR: FD VM=1 </para>
		///</summary>
        public const uint TerminationRelativeDensityThreshold = 1611553;

		///<summary>
		///<para> (0018,9722) Termination Time Threshold </para>
		///<para> VR: FD VM=1 </para>
		///</summary>
        public const uint TerminationTimeThreshold = 1611554;

		///<summary>
		///<para> (0018,9723) Termination Cardiac Trigger Count Threshold </para>
		///<para> VR: FD VM=1 </para>
		///</summary>
        public const uint TerminationCardiacTriggerCountThreshold = 1611555;

		///<summary>
		///<para> (0018,9724) Termination Respiratory Trigger Count Threshold </para>
		///<para> VR: FD VM=1 </para>
		///</summary>
        public const uint TerminationRespiratoryTriggerCountThreshold = 1611556;

		///<summary>
		///<para> (0018,9725) Detector Geometry </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint DetectorGeometry = 1611557;

		///<summary>
		///<para> (0018,9726) Transverse Detector Separation </para>
		///<para> VR: FD VM=1 </para>
		///</summary>
        public const uint TransverseDetectorSeparation = 1611558;

		///<summary>
		///<para> (0018,9727) Axial Detector Dimension </para>
		///<para> VR: FD VM=1 </para>
		///</summary>
        public const uint AxialDetectorDimension = 1611559;

		///<summary>
		///<para> (0018,9729) Radiopharmaceutical Agent Number </para>
		///<para> VR: US VM=1 </para>
		///</summary>
        public const uint RadiopharmaceuticalAgentNumber = 1611561;

		///<summary>
		///<para> (0018,9732) PET Frame Acquisition Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint PetFrameAcquisitionSequence = 1611570;

		///<summary>
		///<para> (0018,9733) PET Detector Motion Details Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint PetDetectorMotionDetailsSequence = 1611571;

		///<summary>
		///<para> (0018,9734) PET Table Dynamics Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint PetTableDynamicsSequence = 1611572;

		///<summary>
		///<para> (0018,9735) PET Position Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint PetPositionSequence = 1611573;

		///<summary>
		///<para> (0018,9736) PET Frame Correction Factors Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint PetFrameCorrectionFactorsSequence = 1611574;

		///<summary>
		///<para> (0018,9737) Radiopharmaceutical Usage Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint RadiopharmaceuticalUsageSequence = 1611575;

		///<summary>
		///<para> (0018,9738) Attenuation Correction Source </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint AttenuationCorrectionSource = 1611576;

		///<summary>
		///<para> (0018,9739) Number of Iterations </para>
		///<para> VR: US VM=1 </para>
		///</summary>
        public const uint NumberOfIterations = 1611577;

		///<summary>
		///<para> (0018,9740) Number of Subsets </para>
		///<para> VR: US VM=1 </para>
		///</summary>
        public const uint NumberOfSubsets = 1611584;

		///<summary>
		///<para> (0018,9749) PET Reconstruction Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint PetReconstructionSequence = 1611593;

		///<summary>
		///<para> (0018,9751) PET Frame Type Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint PetFrameTypeSequence = 1611601;

		///<summary>
		///<para> (0018,9755) Time of Flight Information Used </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint TimeOfFlightInformationUsed = 1611605;

		///<summary>
		///<para> (0018,9756) Reconstruction Type </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint ReconstructionType = 1611606;

		///<summary>
		///<para> (0018,9758) Decay Corrected </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint DecayCorrected = 1611608;

		///<summary>
		///<para> (0018,9759) Attenuation Corrected </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint AttenuationCorrected = 1611609;

		///<summary>
		///<para> (0018,9760) Scatter Corrected </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint ScatterCorrected = 1611616;

		///<summary>
		///<para> (0018,9761) Dead Time Corrected </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint DeadTimeCorrected = 1611617;

		///<summary>
		///<para> (0018,9762) Gantry Motion Corrected </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint GantryMotionCorrected = 1611618;

		///<summary>
		///<para> (0018,9763) Patient Motion Corrected </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint PatientMotionCorrected = 1611619;

		///<summary>
		///<para> (0018,9764) Count Loss Normalization Corrected </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint CountLossNormalizationCorrected = 1611620;

		///<summary>
		///<para> (0018,9765) Randoms Corrected </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint RandomsCorrected = 1611621;

		///<summary>
		///<para> (0018,9766) Non-uniform Radial Sampling Corrected </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint NonUniformRadialSamplingCorrected = 1611622;

		///<summary>
		///<para> (0018,9767) Sensitivity Calibrated </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint SensitivityCalibrated = 1611623;

		///<summary>
		///<para> (0018,9768) Detector Normalization Correction </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint DetectorNormalizationCorrection = 1611624;

		///<summary>
		///<para> (0018,9769) Iterative Reconstruction Method </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint IterativeReconstructionMethod = 1611625;

		///<summary>
		///<para> (0018,9770) Attenuation Correction Temporal Relationship </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint AttenuationCorrectionTemporalRelationship = 1611632;

		///<summary>
		///<para> (0018,9771) Patient Physiological State Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint PatientPhysiologicalStateSequence = 1611633;

		///<summary>
		///<para> (0018,9772) Patient Physiological State Code Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint PatientPhysiologicalStateCodeSequence = 1611634;

		///<summary>
		///<para> (0018,9801) Depth(s) of Focus </para>
		///<para> VR: FD VM=1-n </para>
		///</summary>
        public const uint DepthsOfFocus = 1611777;

		///<summary>
		///<para> (0018,9803) Excluded Intervals Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint ExcludedIntervalsSequence = 1611779;

		///<summary>
		///<para> (0018,9804) Exclusion Start DateTime </para>
		///<para> VR: DT VM=1 </para>
		///</summary>
        public const uint ExclusionStartDatetime = 1611780;

		///<summary>
		///<para> (0018,9805) Exclusion Duration </para>
		///<para> VR: FD VM=1 </para>
		///</summary>
        public const uint ExclusionDuration = 1611781;

		///<summary>
		///<para> (0018,9806) US Image Description Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint UsImageDescriptionSequence = 1611782;

		///<summary>
		///<para> (0018,9807) Image Data Type Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint ImageDataTypeSequence = 1611783;

		///<summary>
		///<para> (0018,9808) Data Type </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint DataType = 1611784;

		///<summary>
		///<para> (0018,9809) Transducer Scan Pattern Code Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint TransducerScanPatternCodeSequence = 1611785;

		///<summary>
		///<para> (0018,980B) Aliased Data Type </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint AliasedDataType = 1611787;

		///<summary>
		///<para> (0018,980C) Position Measuring Device Used </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint PositionMeasuringDeviceUsed = 1611788;

		///<summary>
		///<para> (0018,980D) Transducer Geometry Code Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint TransducerGeometryCodeSequence = 1611789;

		///<summary>
		///<para> (0018,980E) Transducer Beam Steering Code Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint TransducerBeamSteeringCodeSequence = 1611790;

		///<summary>
		///<para> (0018,980F) Transducer Application Code Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint TransducerApplicationCodeSequence = 1611791;

		///<summary>
		///<para> (0018,9810) Zero Velocity Pixel Value </para>
		///<para> VR: US/SS VM=1 </para>
		///</summary>
        public const uint ZeroVelocityPixelValue = 1611792;

		///<summary>
		///<para> (0018,9900) Reference Location Label </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint ReferenceLocationLabel = 1612032;

		///<summary>
		///<para> (0018,9901) Reference Location Description </para>
		///<para> VR: UT VM=1 </para>
		///</summary>
        public const uint ReferenceLocationDescription = 1612033;

		///<summary>
		///<para> (0018,9902) Reference Basis Code Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint ReferenceBasisCodeSequence = 1612034;

		///<summary>
		///<para> (0018,9903) Reference Geometry Code Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint ReferenceGeometryCodeSequence = 1612035;

		///<summary>
		///<para> (0018,9904) Offset Distance </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint OffsetDistance = 1612036;

		///<summary>
		///<para> (0018,9905) Offset Direction </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint OffsetDirection = 1612037;

		///<summary>
		///<para> (0018,9906) Potential Scheduled Protocol Code Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint PotentialScheduledProtocolCodeSequence = 1612038;

		///<summary>
		///<para> (0018,9907) Potential Requested Procedure Code Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint PotentialRequestedProcedureCodeSequence = 1612039;

		///<summary>
		///<para> (0018,9908) Potential Reasons for Procedure </para>
		///<para> VR: UC VM=1-n </para>
		///</summary>
        public const uint PotentialReasonsForProcedure = 1612040;

		///<summary>
		///<para> (0018,9909) Potential Reasons for Procedure Code Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint PotentialReasonsForProcedureCodeSequence = 1612041;

		///<summary>
		///<para> (0018,990A) Potential Diagnostic Tasks </para>
		///<para> VR: UC VM=1-n </para>
		///</summary>
        public const uint PotentialDiagnosticTasks = 1612042;

		///<summary>
		///<para> (0018,990B) Contraindications Code Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint ContraindicationsCodeSequence = 1612043;

		///<summary>
		///<para> (0018,990C) Referenced Defined Protocol Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint ReferencedDefinedProtocolSequence = 1612044;

		///<summary>
		///<para> (0018,990D) Referenced Performed Protocol Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint ReferencedPerformedProtocolSequence = 1612045;

		///<summary>
		///<para> (0018,990E) Predecessor Protocol Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint PredecessorProtocolSequence = 1612046;

		///<summary>
		///<para> (0018,990F) Protocol Planning Information </para>
		///<para> VR: UT VM=1 </para>
		///</summary>
        public const uint ProtocolPlanningInformation = 1612047;

		///<summary>
		///<para> (0018,9910) Protocol Design Rationale </para>
		///<para> VR: UT VM=1 </para>
		///</summary>
        public const uint ProtocolDesignRationale = 1612048;

		///<summary>
		///<para> (0018,9911) Patient Specification Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint PatientSpecificationSequence = 1612049;

		///<summary>
		///<para> (0018,9912) Model Specification Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint ModelSpecificationSequence = 1612050;

		///<summary>
		///<para> (0018,9913) Parameters Specification Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint ParametersSpecificationSequence = 1612051;

		///<summary>
		///<para> (0018,9914) Instruction Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint InstructionSequence = 1612052;

		///<summary>
		///<para> (0018,9915) Instruction Index </para>
		///<para> VR: US VM=1 </para>
		///</summary>
        public const uint InstructionIndex = 1612053;

		///<summary>
		///<para> (0018,9916) Instruction Text </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint InstructionText = 1612054;

		///<summary>
		///<para> (0018,9917) Instruction Description </para>
		///<para> VR: UT VM=1 </para>
		///</summary>
        public const uint InstructionDescription = 1612055;

		///<summary>
		///<para> (0018,9918) Instruction Performed Flag </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint InstructionPerformedFlag = 1612056;

		///<summary>
		///<para> (0018,9919) Instruction Performed DateTime </para>
		///<para> VR: DT VM=1 </para>
		///</summary>
        public const uint InstructionPerformedDatetime = 1612057;

		///<summary>
		///<para> (0018,991A) Instruction Performance Comment </para>
		///<para> VR: UT VM=1 </para>
		///</summary>
        public const uint InstructionPerformanceComment = 1612058;

		///<summary>
		///<para> (0018,991B) Patient Positioning Instruction Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint PatientPositioningInstructionSequence = 1612059;

		///<summary>
		///<para> (0018,991C) Positioning Method Code Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint PositioningMethodCodeSequence = 1612060;

		///<summary>
		///<para> (0018,991D) Positioning Landmark Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint PositioningLandmarkSequence = 1612061;

		///<summary>
		///<para> (0018,991E) Target Frame of Reference UID </para>
		///<para> VR: UI VM=1 </para>
		///</summary>
        public const uint TargetFrameOfReferenceUid = 1612062;

		///<summary>
		///<para> (0018,991F) Acquisition Protocol Element Specification Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint AcquisitionProtocolElementSpecificationSequence = 1612063;

		///<summary>
		///<para> (0018,9920) Acquisition Protocol Element Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint AcquisitionProtocolElementSequence = 1612064;

		///<summary>
		///<para> (0018,9921) Protocol Element Number </para>
		///<para> VR: US VM=1 </para>
		///</summary>
        public const uint ProtocolElementNumber = 1612065;

		///<summary>
		///<para> (0018,9922) Protocol Element Name </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint ProtocolElementName = 1612066;

		///<summary>
		///<para> (0018,9923) Protocol Element Characteristics Summary </para>
		///<para> VR: UT VM=1 </para>
		///</summary>
        public const uint ProtocolElementCharacteristicsSummary = 1612067;

		///<summary>
		///<para> (0018,9924) Protocol Element Purpose </para>
		///<para> VR: UT VM=1 </para>
		///</summary>
        public const uint ProtocolElementPurpose = 1612068;

		///<summary>
		///<para> (0018,9930) Acquisition Motion </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint AcquisitionMotion = 1612080;

		///<summary>
		///<para> (0018,9931) Acquisition Start Location Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint AcquisitionStartLocationSequence = 1612081;

		///<summary>
		///<para> (0018,9932) Acquisition End Location Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint AcquisitionEndLocationSequence = 1612082;

		///<summary>
		///<para> (0018,9933) Reconstruction Protocol Element Specification Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint ReconstructionProtocolElementSpecificationSequence = 1612083;

		///<summary>
		///<para> (0018,9934) Reconstruction Protocol Element Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint ReconstructionProtocolElementSequence = 1612084;

		///<summary>
		///<para> (0018,9935) Storage Protocol Element Specification Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint StorageProtocolElementSpecificationSequence = 1612085;

		///<summary>
		///<para> (0018,9936) Storage Protocol Element Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint StorageProtocolElementSequence = 1612086;

		///<summary>
		///<para> (0018,9937) Requested Series Description </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint RequestedSeriesDescription = 1612087;

		///<summary>
		///<para> (0018,9938) Source Acquisition Protocol Element Number </para>
		///<para> VR: US VM=1-n </para>
		///</summary>
        public const uint SourceAcquisitionProtocolElementNumber = 1612088;

		///<summary>
		///<para> (0018,9939) Source Acquisition Beam Number </para>
		///<para> VR: US VM=1-n </para>
		///</summary>
        public const uint SourceAcquisitionBeamNumber = 1612089;

		///<summary>
		///<para> (0018,993A) Source Reconstruction Protocol Element Number </para>
		///<para> VR: US VM=1-n </para>
		///</summary>
        public const uint SourceReconstructionProtocolElementNumber = 1612090;

		///<summary>
		///<para> (0018,993B) Reconstruction Start Location Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint ReconstructionStartLocationSequence = 1612091;

		///<summary>
		///<para> (0018,993C) Reconstruction End Location Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint ReconstructionEndLocationSequence = 1612092;

		///<summary>
		///<para> (0018,993D) Reconstruction Algorithm Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint ReconstructionAlgorithmSequence = 1612093;

		///<summary>
		///<para> (0018,993E) Reconstruction Target Center Location Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint ReconstructionTargetCenterLocationSequence = 1612094;

		///<summary>
		///<para> (0018,9941) Image Filter Description </para>
		///<para> VR: UT VM=1 </para>
		///</summary>
        public const uint ImageFilterDescription = 1612097;

		///<summary>
		///<para> (0018,9942) CTDIvol Notification Trigger </para>
		///<para> VR: FD VM=1 </para>
		///</summary>
        public const uint CtdivolNotificationTrigger = 1612098;

		///<summary>
		///<para> (0018,9943) DLP Notification Trigger </para>
		///<para> VR: FD VM=1 </para>
		///</summary>
        public const uint DlpNotificationTrigger = 1612099;

		///<summary>
		///<para> (0018,9944) Auto KVP Selection Type </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint AutoKvpSelectionType = 1612100;

		///<summary>
		///<para> (0018,9945) Auto KVP Upper Bound </para>
		///<para> VR: FD VM=1 </para>
		///</summary>
        public const uint AutoKvpUpperBound = 1612101;

		///<summary>
		///<para> (0018,9946) Auto KVP Lower Bound </para>
		///<para> VR: FD VM=1 </para>
		///</summary>
        public const uint AutoKvpLowerBound = 1612102;

		///<summary>
		///<para> (0018,9947) Protocol Defined Patient Position </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint ProtocolDefinedPatientPosition = 1612103;

		///<summary>
		///<para> (0018,A001) Contributing Equipment Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint ContributingEquipmentSequence = 1613825;

		///<summary>
		///<para> (0018,A002) Contribution DateTime </para>
		///<para> VR: DT VM=1 </para>
		///</summary>
        public const uint ContributionDatetime = 1613826;

		///<summary>
		///<para> (0018,A003) Contribution Description </para>
		///<para> VR: ST VM=1 </para>
		///</summary>
        public const uint ContributionDescription = 1613827;

		///<summary>
		///<para> (0020,000D) Study Instance UID </para>
		///<para> VR: UI VM=1 </para>
		///</summary>
        public const uint StudyInstanceUid = 2097165;

		///<summary>
		///<para> (0020,000E) Series Instance UID </para>
		///<para> VR: UI VM=1 </para>
		///</summary>
        public const uint SeriesInstanceUid = 2097166;

		///<summary>
		///<para> (0020,0010) Study ID </para>
		///<para> VR: SH VM=1 </para>
		///</summary>
        public const uint StudyId = 2097168;

		///<summary>
		///<para> (0020,0011) Series Number </para>
		///<para> VR: IS VM=1 </para>
		///</summary>
        public const uint SeriesNumber = 2097169;

		///<summary>
		///<para> (0020,0012) Acquisition Number </para>
		///<para> VR: IS VM=1 </para>
		///</summary>
        public const uint AcquisitionNumber = 2097170;

		///<summary>
		///<para> (0020,0013) Instance Number </para>
		///<para> VR: IS VM=1 </para>
		///</summary>
        public const uint InstanceNumber = 2097171;

		///<summary>
		///<para> (0020,0014) Isotope Number (RETIRED) </para>
		///<para> VR: IS VM=1 </para>
		///</summary>
        public const uint IsotopeNumberRetired = 2097172;

		///<summary>
		///<para> (0020,0015) Phase Number (RETIRED) </para>
		///<para> VR: IS VM=1 </para>
		///</summary>
        public const uint PhaseNumberRetired = 2097173;

		///<summary>
		///<para> (0020,0016) Interval Number (RETIRED) </para>
		///<para> VR: IS VM=1 </para>
		///</summary>
        public const uint IntervalNumberRetired = 2097174;

		///<summary>
		///<para> (0020,0017) Time Slot Number (RETIRED) </para>
		///<para> VR: IS VM=1 </para>
		///</summary>
        public const uint TimeSlotNumberRetired = 2097175;

		///<summary>
		///<para> (0020,0018) Angle Number (RETIRED) </para>
		///<para> VR: IS VM=1 </para>
		///</summary>
        public const uint AngleNumberRetired = 2097176;

		///<summary>
		///<para> (0020,0019) Item Number </para>
		///<para> VR: IS VM=1 </para>
		///</summary>
        public const uint ItemNumber = 2097177;

		///<summary>
		///<para> (0020,0020) Patient Orientation </para>
		///<para> VR: CS VM=2 </para>
		///</summary>
        public const uint PatientOrientation = 2097184;

		///<summary>
		///<para> (0020,0022) Overlay Number (RETIRED) </para>
		///<para> VR: IS VM=1 </para>
		///</summary>
        public const uint OverlayNumberRetired = 2097186;

		///<summary>
		///<para> (0020,0024) Curve Number (RETIRED) </para>
		///<para> VR: IS VM=1 </para>
		///</summary>
        public const uint CurveNumberRetired = 2097188;

		///<summary>
		///<para> (0020,0026) LUT Number (RETIRED) </para>
		///<para> VR: IS VM=1 </para>
		///</summary>
        public const uint LutNumberRetired = 2097190;

		///<summary>
		///<para> (0020,0030) Image Position (RETIRED) </para>
		///<para> VR: DS VM=3 </para>
		///</summary>
        public const uint ImagePositionRetired = 2097200;

		///<summary>
		///<para> (0020,0032) Image Position (Patient) </para>
		///<para> VR: DS VM=3 </para>
		///</summary>
        public const uint ImagePositionPatient = 2097202;

		///<summary>
		///<para> (0020,0035) Image Orientation (RETIRED) </para>
		///<para> VR: DS VM=6 </para>
		///</summary>
        public const uint ImageOrientationRetired = 2097205;

		///<summary>
		///<para> (0020,0037) Image Orientation (Patient) </para>
		///<para> VR: DS VM=6 </para>
		///</summary>
        public const uint ImageOrientationPatient = 2097207;

		///<summary>
		///<para> (0020,0050) Location (RETIRED) </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint LocationRetired = 2097232;

		///<summary>
		///<para> (0020,0052) Frame of Reference UID </para>
		///<para> VR: UI VM=1 </para>
		///</summary>
        public const uint FrameOfReferenceUid = 2097234;

		///<summary>
		///<para> (0020,0060) Laterality </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint Laterality = 2097248;

		///<summary>
		///<para> (0020,0062) Image Laterality </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint ImageLaterality = 2097250;

		///<summary>
		///<para> (0020,0070) Image Geometry Type (RETIRED) </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint ImageGeometryTypeRetired = 2097264;

		///<summary>
		///<para> (0020,0080) Masking Image (RETIRED) </para>
		///<para> VR: CS VM=1-n </para>
		///</summary>
        public const uint MaskingImageRetired = 2097280;

		///<summary>
		///<para> (0020,00AA) Report Number (RETIRED) </para>
		///<para> VR: IS VM=1 </para>
		///</summary>
        public const uint ReportNumberRetired = 2097322;

		///<summary>
		///<para> (0020,0100) Temporal Position Identifier </para>
		///<para> VR: IS VM=1 </para>
		///</summary>
        public const uint TemporalPositionIdentifier = 2097408;

		///<summary>
		///<para> (0020,0105) Number of Temporal Positions </para>
		///<para> VR: IS VM=1 </para>
		///</summary>
        public const uint NumberOfTemporalPositions = 2097413;

		///<summary>
		///<para> (0020,0110) Temporal Resolution </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint TemporalResolution = 2097424;

		///<summary>
		///<para> (0020,0200) Synchronization Frame of Reference UID </para>
		///<para> VR: UI VM=1 </para>
		///</summary>
        public const uint SynchronizationFrameOfReferenceUid = 2097664;

		///<summary>
		///<para> (0020,0242) SOP Instance UID of Concatenation Source </para>
		///<para> VR: UI VM=1 </para>
		///</summary>
        public const uint SopInstanceUidOfConcatenationSource = 2097730;

		///<summary>
		///<para> (0020,1000) Series in Study (RETIRED) </para>
		///<para> VR: IS VM=1 </para>
		///</summary>
        public const uint SeriesInStudyRetired = 2101248;

		///<summary>
		///<para> (0020,1001) Acquisitions in Series (RETIRED) </para>
		///<para> VR: IS VM=1 </para>
		///</summary>
        public const uint AcquisitionsInSeriesRetired = 2101249;

		///<summary>
		///<para> (0020,1002) Images in Acquisition </para>
		///<para> VR: IS VM=1 </para>
		///</summary>
        public const uint ImagesInAcquisition = 2101250;

		///<summary>
		///<para> (0020,1003) Images in Series (RETIRED) </para>
		///<para> VR: IS VM=1 </para>
		///</summary>
        public const uint ImagesInSeriesRetired = 2101251;

		///<summary>
		///<para> (0020,1004) Acquisitions in Study (RETIRED) </para>
		///<para> VR: IS VM=1 </para>
		///</summary>
        public const uint AcquisitionsInStudyRetired = 2101252;

		///<summary>
		///<para> (0020,1005) Images in Study (RETIRED) </para>
		///<para> VR: IS VM=1 </para>
		///</summary>
        public const uint ImagesInStudyRetired = 2101253;

		///<summary>
		///<para> (0020,1020) Reference (RETIRED) </para>
		///<para> VR: LO VM=1-n </para>
		///</summary>
        public const uint ReferenceRetired = 2101280;

		///<summary>
		///<para> (0020,103F) Target Position Reference Indicator </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint TargetPositionReferenceIndicator = 2101311;

		///<summary>
		///<para> (0020,1040) Position Reference Indicator </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint PositionReferenceIndicator = 2101312;

		///<summary>
		///<para> (0020,1041) Slice Location </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint SliceLocation = 2101313;

		///<summary>
		///<para> (0020,1070) Other Study Numbers (RETIRED) </para>
		///<para> VR: IS VM=1-n </para>
		///</summary>
        public const uint OtherStudyNumbersRetired = 2101360;

		///<summary>
		///<para> (0020,1200) Number of Patient Related Studies </para>
		///<para> VR: IS VM=1 </para>
		///</summary>
        public const uint NumberOfPatientRelatedStudies = 2101760;

		///<summary>
		///<para> (0020,1202) Number of Patient Related Series </para>
		///<para> VR: IS VM=1 </para>
		///</summary>
        public const uint NumberOfPatientRelatedSeries = 2101762;

		///<summary>
		///<para> (0020,1204) Number of Patient Related Instances </para>
		///<para> VR: IS VM=1 </para>
		///</summary>
        public const uint NumberOfPatientRelatedInstances = 2101764;

		///<summary>
		///<para> (0020,1206) Number of Study Related Series </para>
		///<para> VR: IS VM=1 </para>
		///</summary>
        public const uint NumberOfStudyRelatedSeries = 2101766;

		///<summary>
		///<para> (0020,1208) Number of Study Related Instances </para>
		///<para> VR: IS VM=1 </para>
		///</summary>
        public const uint NumberOfStudyRelatedInstances = 2101768;

		///<summary>
		///<para> (0020,1209) Number of Series Related Instances </para>
		///<para> VR: IS VM=1 </para>
		///</summary>
        public const uint NumberOfSeriesRelatedInstances = 2101769;

		///<summary>
		///<para> (0020,31xx) Source Image IDs (RETIRED) </para>
		///<para> VR: CS VM=1-n </para>
		///</summary>
        public const uint SourceImageIdsRetired = 2109696;

		///<summary>
		///<para> (0020,3401) Modifying Device ID (RETIRED) </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint ModifyingDeviceIdRetired = 2110465;

		///<summary>
		///<para> (0020,3402) Modified Image ID (RETIRED) </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint ModifiedImageIdRetired = 2110466;

		///<summary>
		///<para> (0020,3403) Modified Image Date (RETIRED) </para>
		///<para> VR: DA VM=1 </para>
		///</summary>
        public const uint ModifiedImageDateRetired = 2110467;

		///<summary>
		///<para> (0020,3404) Modifying Device Manufacturer (RETIRED) </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint ModifyingDeviceManufacturerRetired = 2110468;

		///<summary>
		///<para> (0020,3405) Modified Image Time (RETIRED) </para>
		///<para> VR: TM VM=1 </para>
		///</summary>
        public const uint ModifiedImageTimeRetired = 2110469;

		///<summary>
		///<para> (0020,3406) Modified Image Description (RETIRED) </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint ModifiedImageDescriptionRetired = 2110470;

		///<summary>
		///<para> (0020,4000) Image Comments </para>
		///<para> VR: LT VM=1 </para>
		///</summary>
        public const uint ImageComments = 2113536;

		///<summary>
		///<para> (0020,5000) Original Image Identification (RETIRED) </para>
		///<para> VR: AT VM=1-n </para>
		///</summary>
        public const uint OriginalImageIdentificationRetired = 2117632;

		///<summary>
		///<para> (0020,5002) Original Image Identification Nomenclature (RETIRED) </para>
		///<para> VR: LO VM=1-n </para>
		///</summary>
        public const uint OriginalImageIdentificationNomenclatureRetired = 2117634;

		///<summary>
		///<para> (0020,9056) Stack ID </para>
		///<para> VR: SH VM=1 </para>
		///</summary>
        public const uint StackId = 2134102;

		///<summary>
		///<para> (0020,9057) In-Stack Position Number </para>
		///<para> VR: UL VM=1 </para>
		///</summary>
        public const uint InStackPositionNumber = 2134103;

		///<summary>
		///<para> (0020,9071) Frame Anatomy Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint FrameAnatomySequence = 2134129;

		///<summary>
		///<para> (0020,9072) Frame Laterality </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint FrameLaterality = 2134130;

		///<summary>
		///<para> (0020,9111) Frame Content Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint FrameContentSequence = 2134289;

		///<summary>
		///<para> (0020,9113) Plane Position Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint PlanePositionSequence = 2134291;

		///<summary>
		///<para> (0020,9116) Plane Orientation Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint PlaneOrientationSequence = 2134294;

		///<summary>
		///<para> (0020,9128) Temporal Position Index </para>
		///<para> VR: UL VM=1 </para>
		///</summary>
        public const uint TemporalPositionIndex = 2134312;

		///<summary>
		///<para> (0020,9153) Nominal Cardiac Trigger Delay Time </para>
		///<para> VR: FD VM=1 </para>
		///</summary>
        public const uint NominalCardiacTriggerDelayTime = 2134355;

		///<summary>
		///<para> (0020,9154) Nominal Cardiac Trigger Time Prior To R-Peak </para>
		///<para> VR: FL VM=1 </para>
		///</summary>
        public const uint NominalCardiacTriggerTimePriorToRPeak = 2134356;

		///<summary>
		///<para> (0020,9155) Actual Cardiac Trigger Time Prior To R-Peak </para>
		///<para> VR: FL VM=1 </para>
		///</summary>
        public const uint ActualCardiacTriggerTimePriorToRPeak = 2134357;

		///<summary>
		///<para> (0020,9156) Frame Acquisition Number </para>
		///<para> VR: US VM=1 </para>
		///</summary>
        public const uint FrameAcquisitionNumber = 2134358;

		///<summary>
		///<para> (0020,9157) Dimension Index Values </para>
		///<para> VR: UL VM=1-n </para>
		///</summary>
        public const uint DimensionIndexValues = 2134359;

		///<summary>
		///<para> (0020,9158) Frame Comments </para>
		///<para> VR: LT VM=1 </para>
		///</summary>
        public const uint FrameComments = 2134360;

		///<summary>
		///<para> (0020,9161) Concatenation UID </para>
		///<para> VR: UI VM=1 </para>
		///</summary>
        public const uint ConcatenationUid = 2134369;

		///<summary>
		///<para> (0020,9162) In-concatenation Number </para>
		///<para> VR: US VM=1 </para>
		///</summary>
        public const uint InConcatenationNumber = 2134370;

		///<summary>
		///<para> (0020,9163) In-concatenation Total Number </para>
		///<para> VR: US VM=1 </para>
		///</summary>
        public const uint InConcatenationTotalNumber = 2134371;

		///<summary>
		///<para> (0020,9164) Dimension Organization UID </para>
		///<para> VR: UI VM=1 </para>
		///</summary>
        public const uint DimensionOrganizationUid = 2134372;

		///<summary>
		///<para> (0020,9165) Dimension Index Pointer </para>
		///<para> VR: AT VM=1 </para>
		///</summary>
        public const uint DimensionIndexPointer = 2134373;

		///<summary>
		///<para> (0020,9167) Functional Group Pointer </para>
		///<para> VR: AT VM=1 </para>
		///</summary>
        public const uint FunctionalGroupPointer = 2134375;

		///<summary>
		///<para> (0020,9170) Unassigned Shared Converted Attributes Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint UnassignedSharedConvertedAttributesSequence = 2134384;

		///<summary>
		///<para> (0020,9171) Unassigned Per-Frame Converted Attributes Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint UnassignedPerFrameConvertedAttributesSequence = 2134385;

		///<summary>
		///<para> (0020,9172) Conversion Source Attributes Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint ConversionSourceAttributesSequence = 2134386;

		///<summary>
		///<para> (0020,9213) Dimension Index Private Creator </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint DimensionIndexPrivateCreator = 2134547;

		///<summary>
		///<para> (0020,9221) Dimension Organization Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint DimensionOrganizationSequence = 2134561;

		///<summary>
		///<para> (0020,9222) Dimension Index Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint DimensionIndexSequence = 2134562;

		///<summary>
		///<para> (0020,9228) Concatenation Frame Offset Number </para>
		///<para> VR: UL VM=1 </para>
		///</summary>
        public const uint ConcatenationFrameOffsetNumber = 2134568;

		///<summary>
		///<para> (0020,9238) Functional Group Private Creator </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint FunctionalGroupPrivateCreator = 2134584;

		///<summary>
		///<para> (0020,9241) Nominal Percentage of Cardiac Phase </para>
		///<para> VR: FL VM=1 </para>
		///</summary>
        public const uint NominalPercentageOfCardiacPhase = 2134593;

		///<summary>
		///<para> (0020,9245) Nominal Percentage of Respiratory Phase </para>
		///<para> VR: FL VM=1 </para>
		///</summary>
        public const uint NominalPercentageOfRespiratoryPhase = 2134597;

		///<summary>
		///<para> (0020,9246) Starting Respiratory Amplitude </para>
		///<para> VR: FL VM=1 </para>
		///</summary>
        public const uint StartingRespiratoryAmplitude = 2134598;

		///<summary>
		///<para> (0020,9247) Starting Respiratory Phase </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint StartingRespiratoryPhase = 2134599;

		///<summary>
		///<para> (0020,9248) Ending Respiratory Amplitude </para>
		///<para> VR: FL VM=1 </para>
		///</summary>
        public const uint EndingRespiratoryAmplitude = 2134600;

		///<summary>
		///<para> (0020,9249) Ending Respiratory Phase </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint EndingRespiratoryPhase = 2134601;

		///<summary>
		///<para> (0020,9250) Respiratory Trigger Type </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint RespiratoryTriggerType = 2134608;

		///<summary>
		///<para> (0020,9251) R-R Interval Time Nominal </para>
		///<para> VR: FD VM=1 </para>
		///</summary>
        public const uint RRIntervalTimeNominal = 2134609;

		///<summary>
		///<para> (0020,9252) Actual Cardiac Trigger Delay Time </para>
		///<para> VR: FD VM=1 </para>
		///</summary>
        public const uint ActualCardiacTriggerDelayTime = 2134610;

		///<summary>
		///<para> (0020,9253) Respiratory Synchronization Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint RespiratorySynchronizationSequence = 2134611;

		///<summary>
		///<para> (0020,9254) Respiratory Interval Time </para>
		///<para> VR: FD VM=1 </para>
		///</summary>
        public const uint RespiratoryIntervalTime = 2134612;

		///<summary>
		///<para> (0020,9255) Nominal Respiratory Trigger Delay Time </para>
		///<para> VR: FD VM=1 </para>
		///</summary>
        public const uint NominalRespiratoryTriggerDelayTime = 2134613;

		///<summary>
		///<para> (0020,9256) Respiratory Trigger Delay Threshold </para>
		///<para> VR: FD VM=1 </para>
		///</summary>
        public const uint RespiratoryTriggerDelayThreshold = 2134614;

		///<summary>
		///<para> (0020,9257) Actual Respiratory Trigger Delay Time </para>
		///<para> VR: FD VM=1 </para>
		///</summary>
        public const uint ActualRespiratoryTriggerDelayTime = 2134615;

		///<summary>
		///<para> (0020,9301) Image Position (Volume) </para>
		///<para> VR: FD VM=3 </para>
		///</summary>
        public const uint ImagePositionVolume = 2134785;

		///<summary>
		///<para> (0020,9302) Image Orientation (Volume) </para>
		///<para> VR: FD VM=6 </para>
		///</summary>
        public const uint ImageOrientationVolume = 2134786;

		///<summary>
		///<para> (0020,9307) Ultrasound Acquisition Geometry </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint UltrasoundAcquisitionGeometry = 2134791;

		///<summary>
		///<para> (0020,9308) Apex Position </para>
		///<para> VR: FD VM=3 </para>
		///</summary>
        public const uint ApexPosition = 2134792;

		///<summary>
		///<para> (0020,9309) Volume to Transducer Mapping Matrix </para>
		///<para> VR: FD VM=16 </para>
		///</summary>
        public const uint VolumeToTransducerMappingMatrix = 2134793;

		///<summary>
		///<para> (0020,930A) Volume to Table Mapping Matrix </para>
		///<para> VR: FD VM=16 </para>
		///</summary>
        public const uint VolumeToTableMappingMatrix = 2134794;

		///<summary>
		///<para> (0020,930B) Volume to Transducer Relationship </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint VolumeToTransducerRelationship = 2134795;

		///<summary>
		///<para> (0020,930C) Patient Frame of Reference Source </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint PatientFrameOfReferenceSource = 2134796;

		///<summary>
		///<para> (0020,930D) Temporal Position Time Offset </para>
		///<para> VR: FD VM=1 </para>
		///</summary>
        public const uint TemporalPositionTimeOffset = 2134797;

		///<summary>
		///<para> (0020,930E) Plane Position (Volume) Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint PlanePositionVolumeSequence = 2134798;

		///<summary>
		///<para> (0020,930F) Plane Orientation (Volume) Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint PlaneOrientationVolumeSequence = 2134799;

		///<summary>
		///<para> (0020,9310) Temporal Position Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint TemporalPositionSequence = 2134800;

		///<summary>
		///<para> (0020,9311) Dimension Organization Type </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint DimensionOrganizationType = 2134801;

		///<summary>
		///<para> (0020,9312) Volume Frame of Reference UID </para>
		///<para> VR: UI VM=1 </para>
		///</summary>
        public const uint VolumeFrameOfReferenceUid = 2134802;

		///<summary>
		///<para> (0020,9313) Table Frame of Reference UID </para>
		///<para> VR: UI VM=1 </para>
		///</summary>
        public const uint TableFrameOfReferenceUid = 2134803;

		///<summary>
		///<para> (0020,9421) Dimension Description Label </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint DimensionDescriptionLabel = 2135073;

		///<summary>
		///<para> (0020,9450) Patient Orientation in Frame Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint PatientOrientationInFrameSequence = 2135120;

		///<summary>
		///<para> (0020,9453) Frame Label </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint FrameLabel = 2135123;

		///<summary>
		///<para> (0020,9518) Acquisition Index </para>
		///<para> VR: US VM=1-n </para>
		///</summary>
        public const uint AcquisitionIndex = 2135320;

		///<summary>
		///<para> (0020,9529) Contributing SOP Instances Reference Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint ContributingSopInstancesReferenceSequence = 2135337;

		///<summary>
		///<para> (0020,9536) Reconstruction Index </para>
		///<para> VR: US VM=1 </para>
		///</summary>
        public const uint ReconstructionIndex = 2135350;

		///<summary>
		///<para> (0022,0001) Light Path Filter Pass-Through Wavelength </para>
		///<para> VR: US VM=1 </para>
		///</summary>
        public const uint LightPathFilterPassThroughWavelength = 2228225;

		///<summary>
		///<para> (0022,0002) Light Path Filter Pass Band </para>
		///<para> VR: US VM=2 </para>
		///</summary>
        public const uint LightPathFilterPassBand = 2228226;

		///<summary>
		///<para> (0022,0003) Image Path Filter Pass-Through Wavelength </para>
		///<para> VR: US VM=1 </para>
		///</summary>
        public const uint ImagePathFilterPassThroughWavelength = 2228227;

		///<summary>
		///<para> (0022,0004) Image Path Filter Pass Band </para>
		///<para> VR: US VM=2 </para>
		///</summary>
        public const uint ImagePathFilterPassBand = 2228228;

		///<summary>
		///<para> (0022,0005) Patient Eye Movement Commanded </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint PatientEyeMovementCommanded = 2228229;

		///<summary>
		///<para> (0022,0006) Patient Eye Movement Command Code Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint PatientEyeMovementCommandCodeSequence = 2228230;

		///<summary>
		///<para> (0022,0007) Spherical Lens Power </para>
		///<para> VR: FL VM=1 </para>
		///</summary>
        public const uint SphericalLensPower = 2228231;

		///<summary>
		///<para> (0022,0008) Cylinder Lens Power </para>
		///<para> VR: FL VM=1 </para>
		///</summary>
        public const uint CylinderLensPower = 2228232;

		///<summary>
		///<para> (0022,0009) Cylinder Axis </para>
		///<para> VR: FL VM=1 </para>
		///</summary>
        public const uint CylinderAxis = 2228233;

		///<summary>
		///<para> (0022,000A) Emmetropic Magnification </para>
		///<para> VR: FL VM=1 </para>
		///</summary>
        public const uint EmmetropicMagnification = 2228234;

		///<summary>
		///<para> (0022,000B) Intra Ocular Pressure </para>
		///<para> VR: FL VM=1 </para>
		///</summary>
        public const uint IntraOcularPressure = 2228235;

		///<summary>
		///<para> (0022,000C) Horizontal Field of View </para>
		///<para> VR: FL VM=1 </para>
		///</summary>
        public const uint HorizontalFieldOfView = 2228236;

		///<summary>
		///<para> (0022,000D) Pupil Dilated </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint PupilDilated = 2228237;

		///<summary>
		///<para> (0022,000E) Degree of Dilation </para>
		///<para> VR: FL VM=1 </para>
		///</summary>
        public const uint DegreeOfDilation = 2228238;

		///<summary>
		///<para> (0022,0010) Stereo Baseline Angle </para>
		///<para> VR: FL VM=1 </para>
		///</summary>
        public const uint StereoBaselineAngle = 2228240;

		///<summary>
		///<para> (0022,0011) Stereo Baseline Displacement </para>
		///<para> VR: FL VM=1 </para>
		///</summary>
        public const uint StereoBaselineDisplacement = 2228241;

		///<summary>
		///<para> (0022,0012) Stereo Horizontal Pixel Offset </para>
		///<para> VR: FL VM=1 </para>
		///</summary>
        public const uint StereoHorizontalPixelOffset = 2228242;

		///<summary>
		///<para> (0022,0013) Stereo Vertical Pixel Offset </para>
		///<para> VR: FL VM=1 </para>
		///</summary>
        public const uint StereoVerticalPixelOffset = 2228243;

		///<summary>
		///<para> (0022,0014) Stereo Rotation </para>
		///<para> VR: FL VM=1 </para>
		///</summary>
        public const uint StereoRotation = 2228244;

		///<summary>
		///<para> (0022,0015) Acquisition Device Type Code Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint AcquisitionDeviceTypeCodeSequence = 2228245;

		///<summary>
		///<para> (0022,0016) Illumination Type Code Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint IlluminationTypeCodeSequence = 2228246;

		///<summary>
		///<para> (0022,0017) Light Path Filter Type Stack Code Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint LightPathFilterTypeStackCodeSequence = 2228247;

		///<summary>
		///<para> (0022,0018) Image Path Filter Type Stack Code Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint ImagePathFilterTypeStackCodeSequence = 2228248;

		///<summary>
		///<para> (0022,0019) Lenses Code Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint LensesCodeSequence = 2228249;

		///<summary>
		///<para> (0022,001A) Channel Description Code Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint ChannelDescriptionCodeSequence = 2228250;

		///<summary>
		///<para> (0022,001B) Refractive State Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint RefractiveStateSequence = 2228251;

		///<summary>
		///<para> (0022,001C) Mydriatic Agent Code Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint MydriaticAgentCodeSequence = 2228252;

		///<summary>
		///<para> (0022,001D) Relative Image Position Code Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint RelativeImagePositionCodeSequence = 2228253;

		///<summary>
		///<para> (0022,001E) Camera Angle of View </para>
		///<para> VR: FL VM=1 </para>
		///</summary>
        public const uint CameraAngleOfView = 2228254;

		///<summary>
		///<para> (0022,0020) Stereo Pairs Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint StereoPairsSequence = 2228256;

		///<summary>
		///<para> (0022,0021) Left Image Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint LeftImageSequence = 2228257;

		///<summary>
		///<para> (0022,0022) Right Image Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint RightImageSequence = 2228258;

		///<summary>
		///<para> (0022,0028) Stereo Pairs Present </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint StereoPairsPresent = 2228264;

		///<summary>
		///<para> (0022,0030) Axial Length of the Eye </para>
		///<para> VR: FL VM=1 </para>
		///</summary>
        public const uint AxialLengthOfTheEye = 2228272;

		///<summary>
		///<para> (0022,0031) Ophthalmic Frame Location Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint OphthalmicFrameLocationSequence = 2228273;

		///<summary>
		///<para> (0022,0032) Reference Coordinates </para>
		///<para> VR: FL VM=2-2n </para>
		///</summary>
        public const uint ReferenceCoordinates = 2228274;

		///<summary>
		///<para> (0022,0035) Depth Spatial Resolution </para>
		///<para> VR: FL VM=1 </para>
		///</summary>
        public const uint DepthSpatialResolution = 2228277;

		///<summary>
		///<para> (0022,0036) Maximum Depth Distortion </para>
		///<para> VR: FL VM=1 </para>
		///</summary>
        public const uint MaximumDepthDistortion = 2228278;

		///<summary>
		///<para> (0022,0037) Along-scan Spatial Resolution </para>
		///<para> VR: FL VM=1 </para>
		///</summary>
        public const uint AlongScanSpatialResolution = 2228279;

		///<summary>
		///<para> (0022,0038) Maximum Along-scan Distortion </para>
		///<para> VR: FL VM=1 </para>
		///</summary>
        public const uint MaximumAlongScanDistortion = 2228280;

		///<summary>
		///<para> (0022,0039) Ophthalmic Image Orientation </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint OphthalmicImageOrientation = 2228281;

		///<summary>
		///<para> (0022,0041) Depth of Transverse Image </para>
		///<para> VR: FL VM=1 </para>
		///</summary>
        public const uint DepthOfTransverseImage = 2228289;

		///<summary>
		///<para> (0022,0042) Mydriatic Agent Concentration Units Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint MydriaticAgentConcentrationUnitsSequence = 2228290;

		///<summary>
		///<para> (0022,0048) Across-scan Spatial Resolution </para>
		///<para> VR: FL VM=1 </para>
		///</summary>
        public const uint AcrossScanSpatialResolution = 2228296;

		///<summary>
		///<para> (0022,0049) Maximum Across-scan Distortion </para>
		///<para> VR: FL VM=1 </para>
		///</summary>
        public const uint MaximumAcrossScanDistortion = 2228297;

		///<summary>
		///<para> (0022,004E) Mydriatic Agent Concentration </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint MydriaticAgentConcentration = 2228302;

		///<summary>
		///<para> (0022,0055) Illumination Wave Length </para>
		///<para> VR: FL VM=1 </para>
		///</summary>
        public const uint IlluminationWaveLength = 2228309;

		///<summary>
		///<para> (0022,0056) Illumination Power </para>
		///<para> VR: FL VM=1 </para>
		///</summary>
        public const uint IlluminationPower = 2228310;

		///<summary>
		///<para> (0022,0057) Illumination Bandwidth </para>
		///<para> VR: FL VM=1 </para>
		///</summary>
        public const uint IlluminationBandwidth = 2228311;

		///<summary>
		///<para> (0022,0058) Mydriatic Agent Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint MydriaticAgentSequence = 2228312;

		///<summary>
		///<para> (0022,1007) Ophthalmic Axial Measurements Right Eye Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint OphthalmicAxialMeasurementsRightEyeSequence = 2232327;

		///<summary>
		///<para> (0022,1008) Ophthalmic Axial Measurements Left Eye Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint OphthalmicAxialMeasurementsLeftEyeSequence = 2232328;

		///<summary>
		///<para> (0022,1009) Ophthalmic Axial Measurements Device Type </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint OphthalmicAxialMeasurementsDeviceType = 2232329;

		///<summary>
		///<para> (0022,1010) Ophthalmic Axial Length Measurements Type </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint OphthalmicAxialLengthMeasurementsType = 2232336;

		///<summary>
		///<para> (0022,1012) Ophthalmic Axial Length Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint OphthalmicAxialLengthSequence = 2232338;

		///<summary>
		///<para> (0022,1019) Ophthalmic Axial Length </para>
		///<para> VR: FL VM=1 </para>
		///</summary>
        public const uint OphthalmicAxialLength = 2232345;

		///<summary>
		///<para> (0022,1024) Lens Status Code Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint LensStatusCodeSequence = 2232356;

		///<summary>
		///<para> (0022,1025) Vitreous Status Code Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint VitreousStatusCodeSequence = 2232357;

		///<summary>
		///<para> (0022,1028) IOL Formula Code Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint IolFormulaCodeSequence = 2232360;

		///<summary>
		///<para> (0022,1029) IOL Formula Detail </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint IolFormulaDetail = 2232361;

		///<summary>
		///<para> (0022,1033) Keratometer Index </para>
		///<para> VR: FL VM=1 </para>
		///</summary>
        public const uint KeratometerIndex = 2232371;

		///<summary>
		///<para> (0022,1035) Source of Ophthalmic Axial Length Code Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint SourceOfOphthalmicAxialLengthCodeSequence = 2232373;

		///<summary>
		///<para> (0022,1037) Target Refraction </para>
		///<para> VR: FL VM=1 </para>
		///</summary>
        public const uint TargetRefraction = 2232375;

		///<summary>
		///<para> (0022,1039) Refractive Procedure Occurred </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint RefractiveProcedureOccurred = 2232377;

		///<summary>
		///<para> (0022,1040) Refractive Surgery Type Code Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint RefractiveSurgeryTypeCodeSequence = 2232384;

		///<summary>
		///<para> (0022,1044) Ophthalmic Ultrasound Method Code Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint OphthalmicUltrasoundMethodCodeSequence = 2232388;

		///<summary>
		///<para> (0022,1050) Ophthalmic Axial Length Measurements Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint OphthalmicAxialLengthMeasurementsSequence = 2232400;

		///<summary>
		///<para> (0022,1053) IOL Power </para>
		///<para> VR: FL VM=1 </para>
		///</summary>
        public const uint IolPower = 2232403;

		///<summary>
		///<para> (0022,1054) Predicted Refractive Error </para>
		///<para> VR: FL VM=1 </para>
		///</summary>
        public const uint PredictedRefractiveError = 2232404;

		///<summary>
		///<para> (0022,1059) Ophthalmic Axial Length Velocity </para>
		///<para> VR: FL VM=1 </para>
		///</summary>
        public const uint OphthalmicAxialLengthVelocity = 2232409;

		///<summary>
		///<para> (0022,1065) Lens Status Description </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint LensStatusDescription = 2232421;

		///<summary>
		///<para> (0022,1066) Vitreous Status Description </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint VitreousStatusDescription = 2232422;

		///<summary>
		///<para> (0022,1090) IOL Power Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint IolPowerSequence = 2232464;

		///<summary>
		///<para> (0022,1092) Lens Constant Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint LensConstantSequence = 2232466;

		///<summary>
		///<para> (0022,1093) IOL Manufacturer </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint IolManufacturer = 2232467;

		///<summary>
		///<para> (0022,1094) Lens Constant Description (RETIRED) </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint LensConstantDescriptionRetired = 2232468;

		///<summary>
		///<para> (0022,1095) Implant Name </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint ImplantName = 2232469;

		///<summary>
		///<para> (0022,1096) Keratometry Measurement Type Code Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint KeratometryMeasurementTypeCodeSequence = 2232470;

		///<summary>
		///<para> (0022,1097) Implant Part Number </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint ImplantPartNumber = 2232471;

		///<summary>
		///<para> (0022,1100) Referenced Ophthalmic Axial Measurements Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint ReferencedOphthalmicAxialMeasurementsSequence = 2232576;

		///<summary>
		///<para> (0022,1101) Ophthalmic Axial Length Measurements Segment Name Code Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint OphthalmicAxialLengthMeasurementsSegmentNameCodeSequence = 2232577;

		///<summary>
		///<para> (0022,1103) Refractive Error Before Refractive Surgery Code Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint RefractiveErrorBeforeRefractiveSurgeryCodeSequence = 2232579;

		///<summary>
		///<para> (0022,1121) IOL Power For Exact Emmetropia </para>
		///<para> VR: FL VM=1 </para>
		///</summary>
        public const uint IolPowerForExactEmmetropia = 2232609;

		///<summary>
		///<para> (0022,1122) IOL Power For Exact Target Refraction </para>
		///<para> VR: FL VM=1 </para>
		///</summary>
        public const uint IolPowerForExactTargetRefraction = 2232610;

		///<summary>
		///<para> (0022,1125) Anterior Chamber Depth Definition Code Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint AnteriorChamberDepthDefinitionCodeSequence = 2232613;

		///<summary>
		///<para> (0022,1127) Lens Thickness Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint LensThicknessSequence = 2232615;

		///<summary>
		///<para> (0022,1128) Anterior Chamber Depth Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint AnteriorChamberDepthSequence = 2232616;

		///<summary>
		///<para> (0022,1130) Lens Thickness </para>
		///<para> VR: FL VM=1 </para>
		///</summary>
        public const uint LensThickness = 2232624;

		///<summary>
		///<para> (0022,1131) Anterior Chamber Depth </para>
		///<para> VR: FL VM=1 </para>
		///</summary>
        public const uint AnteriorChamberDepth = 2232625;

		///<summary>
		///<para> (0022,1132) Source of Lens Thickness Data Code Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint SourceOfLensThicknessDataCodeSequence = 2232626;

		///<summary>
		///<para> (0022,1133) Source of Anterior Chamber Depth Data Code Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint SourceOfAnteriorChamberDepthDataCodeSequence = 2232627;

		///<summary>
		///<para> (0022,1134) Source of Refractive Measurements Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint SourceOfRefractiveMeasurementsSequence = 2232628;

		///<summary>
		///<para> (0022,1135) Source of Refractive Measurements Code Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint SourceOfRefractiveMeasurementsCodeSequence = 2232629;

		///<summary>
		///<para> (0022,1140) Ophthalmic Axial Length Measurement Modified </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint OphthalmicAxialLengthMeasurementModified = 2232640;

		///<summary>
		///<para> (0022,1150) Ophthalmic Axial Length Data Source Code Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint OphthalmicAxialLengthDataSourceCodeSequence = 2232656;

		///<summary>
		///<para> (0022,1153) Ophthalmic Axial Length Acquisition Method Code Sequence (RETIRED) </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint OphthalmicAxialLengthAcquisitionMethodCodeSequenceRetired = 2232659;

		///<summary>
		///<para> (0022,1155) Signal to Noise Ratio </para>
		///<para> VR: FL VM=1 </para>
		///</summary>
        public const uint SignalToNoiseRatio = 2232661;

		///<summary>
		///<para> (0022,1159) Ophthalmic Axial Length Data Source Description </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint OphthalmicAxialLengthDataSourceDescription = 2232665;

		///<summary>
		///<para> (0022,1210) Ophthalmic Axial Length Measurements Total Length Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint OphthalmicAxialLengthMeasurementsTotalLengthSequence = 2232848;

		///<summary>
		///<para> (0022,1211) Ophthalmic Axial Length Measurements Segmental Length Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint OphthalmicAxialLengthMeasurementsSegmentalLengthSequence = 2232849;

		///<summary>
		///<para> (0022,1212) Ophthalmic Axial Length Measurements Length Summation Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint OphthalmicAxialLengthMeasurementsLengthSummationSequence = 2232850;

		///<summary>
		///<para> (0022,1220) Ultrasound Ophthalmic Axial Length Measurements Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint UltrasoundOphthalmicAxialLengthMeasurementsSequence = 2232864;

		///<summary>
		///<para> (0022,1225) Optical Ophthalmic Axial Length Measurements Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint OpticalOphthalmicAxialLengthMeasurementsSequence = 2232869;

		///<summary>
		///<para> (0022,1230) Ultrasound Selected Ophthalmic Axial Length Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint UltrasoundSelectedOphthalmicAxialLengthSequence = 2232880;

		///<summary>
		///<para> (0022,1250) Ophthalmic Axial Length Selection Method Code Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint OphthalmicAxialLengthSelectionMethodCodeSequence = 2232912;

		///<summary>
		///<para> (0022,1255) Optical Selected Ophthalmic Axial Length Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint OpticalSelectedOphthalmicAxialLengthSequence = 2232917;

		///<summary>
		///<para> (0022,1257) Selected Segmental Ophthalmic Axial Length Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint SelectedSegmentalOphthalmicAxialLengthSequence = 2232919;

		///<summary>
		///<para> (0022,1260) Selected Total Ophthalmic Axial Length Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint SelectedTotalOphthalmicAxialLengthSequence = 2232928;

		///<summary>
		///<para> (0022,1262) Ophthalmic Axial Length Quality Metric Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint OphthalmicAxialLengthQualityMetricSequence = 2232930;

		///<summary>
		///<para> (0022,1265) Ophthalmic Axial Length Quality Metric Type Code Sequence (RETIRED) </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint OphthalmicAxialLengthQualityMetricTypeCodeSequenceRetired = 2232933;

		///<summary>
		///<para> (0022,1273) Ophthalmic Axial Length Quality Metric Type Description (RETIRED) </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint OphthalmicAxialLengthQualityMetricTypeDescriptionRetired = 2232947;

		///<summary>
		///<para> (0022,1300) Intraocular Lens Calculations Right Eye Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint IntraocularLensCalculationsRightEyeSequence = 2233088;

		///<summary>
		///<para> (0022,1310) Intraocular Lens Calculations Left Eye Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint IntraocularLensCalculationsLeftEyeSequence = 2233104;

		///<summary>
		///<para> (0022,1330) Referenced Ophthalmic Axial Length Measurement QC Image Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint ReferencedOphthalmicAxialLengthMeasurementQcImageSequence = 2233136;

		///<summary>
		///<para> (0022,1415) Ophthalmic Mapping Device Type </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint OphthalmicMappingDeviceType = 2233365;

		///<summary>
		///<para> (0022,1420) Acquisition Method Code Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint AcquisitionMethodCodeSequence = 2233376;

		///<summary>
		///<para> (0022,1423) Acquisition Method Algorithm Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint AcquisitionMethodAlgorithmSequence = 2233379;

		///<summary>
		///<para> (0022,1436) Ophthalmic Thickness Map Type Code Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint OphthalmicThicknessMapTypeCodeSequence = 2233398;

		///<summary>
		///<para> (0022,1443) Ophthalmic Thickness Mapping Normals Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint OphthalmicThicknessMappingNormalsSequence = 2233411;

		///<summary>
		///<para> (0022,1445) Retinal Thickness Definition Code Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint RetinalThicknessDefinitionCodeSequence = 2233413;

		///<summary>
		///<para> (0022,1450) Pixel Value Mapping to Coded Concept Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint PixelValueMappingToCodedConceptSequence = 2233424;

		///<summary>
		///<para> (0022,1452) Mapped Pixel Value </para>
		///<para> VR: US/SS VM=1 </para>
		///</summary>
        public const uint MappedPixelValue = 2233426;

		///<summary>
		///<para> (0022,1454) Pixel Value Mapping Explanation </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint PixelValueMappingExplanation = 2233428;

		///<summary>
		///<para> (0022,1458) Ophthalmic Thickness Map Quality Threshold Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint OphthalmicThicknessMapQualityThresholdSequence = 2233432;

		///<summary>
		///<para> (0022,1460) Ophthalmic Thickness Map Threshold Quality Rating </para>
		///<para> VR: FL VM=1 </para>
		///</summary>
        public const uint OphthalmicThicknessMapThresholdQualityRating = 2233440;

		///<summary>
		///<para> (0022,1463) Anatomic Structure Reference Point </para>
		///<para> VR: FL VM=2 </para>
		///</summary>
        public const uint AnatomicStructureReferencePoint = 2233443;

		///<summary>
		///<para> (0022,1465) Registration to Localizer Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint RegistrationToLocalizerSequence = 2233445;

		///<summary>
		///<para> (0022,1466) Registered Localizer Units </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint RegisteredLocalizerUnits = 2233446;

		///<summary>
		///<para> (0022,1467) Registered Localizer Top Left Hand Corner </para>
		///<para> VR: FL VM=2 </para>
		///</summary>
        public const uint RegisteredLocalizerTopLeftHandCorner = 2233447;

		///<summary>
		///<para> (0022,1468) Registered Localizer Bottom Right Hand Corner </para>
		///<para> VR: FL VM=2 </para>
		///</summary>
        public const uint RegisteredLocalizerBottomRightHandCorner = 2233448;

		///<summary>
		///<para> (0022,1470) Ophthalmic Thickness Map Quality Rating Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint OphthalmicThicknessMapQualityRatingSequence = 2233456;

		///<summary>
		///<para> (0022,1472) Relevant OPT Attributes Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint RelevantOptAttributesSequence = 2233458;

		///<summary>
		///<para> (0022,1512) Transformation Method Code Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint TransformationMethodCodeSequence = 2233618;

		///<summary>
		///<para> (0022,1513) Transformation Algorithm Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint TransformationAlgorithmSequence = 2233619;

		///<summary>
		///<para> (0022,1515) Ophthalmic Axial Length Method </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint OphthalmicAxialLengthMethod = 2233621;

		///<summary>
		///<para> (0022,1517) Ophthalmic FOV </para>
		///<para> VR: FL VM=1 </para>
		///</summary>
        public const uint OphthalmicFov = 2233623;

		///<summary>
		///<para> (0022,1518) Two Dimensional to Three Dimensional Map Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint TwoDimensionalToThreeDimensionalMapSequence = 2233624;

		///<summary>
		///<para> (0022,1525) Wide Field Ophthalmic Photography Quality Rating Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint WideFieldOphthalmicPhotographyQualityRatingSequence = 2233637;

		///<summary>
		///<para> (0022,1526) Wide Field Ophthalmic Photography Quality Threshold Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint WideFieldOphthalmicPhotographyQualityThresholdSequence = 2233638;

		///<summary>
		///<para> (0022,1527) Wide Field Ophthalmic Photography Threshold Quality Rating </para>
		///<para> VR: FL VM=1 </para>
		///</summary>
        public const uint WideFieldOphthalmicPhotographyThresholdQualityRating = 2233639;

		///<summary>
		///<para> (0022,1528) X Coordinates Center Pixel View Angle </para>
		///<para> VR: FL VM=1 </para>
		///</summary>
        public const uint XCoordinatesCenterPixelViewAngle = 2233640;

		///<summary>
		///<para> (0022,1529) Y Coordinates Center Pixel View Angle </para>
		///<para> VR: FL VM=1 </para>
		///</summary>
        public const uint YCoordinatesCenterPixelViewAngle = 2233641;

		///<summary>
		///<para> (0022,1530) Number of Map Points </para>
		///<para> VR: UL VM=1 </para>
		///</summary>
        public const uint NumberOfMapPoints = 2233648;

		///<summary>
		///<para> (0022,1531) Two Dimensional to Three Dimensional Map Data </para>
		///<para> VR: OF VM=1 </para>
		///</summary>
        public const uint TwoDimensionalToThreeDimensionalMapData = 2233649;

		///<summary>
		///<para> (0024,0010) Visual Field Horizontal Extent </para>
		///<para> VR: FL VM=1 </para>
		///</summary>
        public const uint VisualFieldHorizontalExtent = 2359312;

		///<summary>
		///<para> (0024,0011) Visual Field Vertical Extent </para>
		///<para> VR: FL VM=1 </para>
		///</summary>
        public const uint VisualFieldVerticalExtent = 2359313;

		///<summary>
		///<para> (0024,0012) Visual Field Shape </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint VisualFieldShape = 2359314;

		///<summary>
		///<para> (0024,0016) Screening Test Mode Code Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint ScreeningTestModeCodeSequence = 2359318;

		///<summary>
		///<para> (0024,0018) Maximum Stimulus Luminance </para>
		///<para> VR: FL VM=1 </para>
		///</summary>
        public const uint MaximumStimulusLuminance = 2359320;

		///<summary>
		///<para> (0024,0020) Background Luminance </para>
		///<para> VR: FL VM=1 </para>
		///</summary>
        public const uint BackgroundLuminance = 2359328;

		///<summary>
		///<para> (0024,0021) Stimulus Color Code Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint StimulusColorCodeSequence = 2359329;

		///<summary>
		///<para> (0024,0024) Background Illumination Color Code Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint BackgroundIlluminationColorCodeSequence = 2359332;

		///<summary>
		///<para> (0024,0025) Stimulus Area </para>
		///<para> VR: FL VM=1 </para>
		///</summary>
        public const uint StimulusArea = 2359333;

		///<summary>
		///<para> (0024,0028) Stimulus Presentation Time </para>
		///<para> VR: FL VM=1 </para>
		///</summary>
        public const uint StimulusPresentationTime = 2359336;

		///<summary>
		///<para> (0024,0032) Fixation Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint FixationSequence = 2359346;

		///<summary>
		///<para> (0024,0033) Fixation Monitoring Code Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint FixationMonitoringCodeSequence = 2359347;

		///<summary>
		///<para> (0024,0034) Visual Field Catch Trial Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint VisualFieldCatchTrialSequence = 2359348;

		///<summary>
		///<para> (0024,0035) Fixation Checked Quantity </para>
		///<para> VR: US VM=1 </para>
		///</summary>
        public const uint FixationCheckedQuantity = 2359349;

		///<summary>
		///<para> (0024,0036) Patient Not Properly Fixated Quantity </para>
		///<para> VR: US VM=1 </para>
		///</summary>
        public const uint PatientNotProperlyFixatedQuantity = 2359350;

		///<summary>
		///<para> (0024,0037) Presented Visual Stimuli Data Flag </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint PresentedVisualStimuliDataFlag = 2359351;

		///<summary>
		///<para> (0024,0038) Number of Visual Stimuli </para>
		///<para> VR: US VM=1 </para>
		///</summary>
        public const uint NumberOfVisualStimuli = 2359352;

		///<summary>
		///<para> (0024,0039) Excessive Fixation Losses Data Flag </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint ExcessiveFixationLossesDataFlag = 2359353;

		///<summary>
		///<para> (0024,0040) Excessive Fixation Losses </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint ExcessiveFixationLosses = 2359360;

		///<summary>
		///<para> (0024,0042) Stimuli Retesting Quantity </para>
		///<para> VR: US VM=1 </para>
		///</summary>
        public const uint StimuliRetestingQuantity = 2359362;

		///<summary>
		///<para> (0024,0044) Comments on Patient's Performance of Visual Field </para>
		///<para> VR: LT VM=1 </para>
		///</summary>
        public const uint CommentsOnPatientsPerformanceOfVisualField = 2359364;

		///<summary>
		///<para> (0024,0045) False Negatives Estimate Flag </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint FalseNegativesEstimateFlag = 2359365;

		///<summary>
		///<para> (0024,0046) False Negatives Estimate </para>
		///<para> VR: FL VM=1 </para>
		///</summary>
        public const uint FalseNegativesEstimate = 2359366;

		///<summary>
		///<para> (0024,0048) Negative Catch Trials Quantity </para>
		///<para> VR: US VM=1 </para>
		///</summary>
        public const uint NegativeCatchTrialsQuantity = 2359368;

		///<summary>
		///<para> (0024,0050) False Negatives Quantity </para>
		///<para> VR: US VM=1 </para>
		///</summary>
        public const uint FalseNegativesQuantity = 2359376;

		///<summary>
		///<para> (0024,0051) Excessive False Negatives Data Flag </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint ExcessiveFalseNegativesDataFlag = 2359377;

		///<summary>
		///<para> (0024,0052) Excessive False Negatives </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint ExcessiveFalseNegatives = 2359378;

		///<summary>
		///<para> (0024,0053) False Positives Estimate Flag </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint FalsePositivesEstimateFlag = 2359379;

		///<summary>
		///<para> (0024,0054) False Positives Estimate </para>
		///<para> VR: FL VM=1 </para>
		///</summary>
        public const uint FalsePositivesEstimate = 2359380;

		///<summary>
		///<para> (0024,0055) Catch Trials Data Flag </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint CatchTrialsDataFlag = 2359381;

		///<summary>
		///<para> (0024,0056) Positive Catch Trials Quantity </para>
		///<para> VR: US VM=1 </para>
		///</summary>
        public const uint PositiveCatchTrialsQuantity = 2359382;

		///<summary>
		///<para> (0024,0057) Test Point Normals Data Flag </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint TestPointNormalsDataFlag = 2359383;

		///<summary>
		///<para> (0024,0058) Test Point Normals Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint TestPointNormalsSequence = 2359384;

		///<summary>
		///<para> (0024,0059) Global Deviation Probability Normals Flag </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint GlobalDeviationProbabilityNormalsFlag = 2359385;

		///<summary>
		///<para> (0024,0060) False Positives Quantity </para>
		///<para> VR: US VM=1 </para>
		///</summary>
        public const uint FalsePositivesQuantity = 2359392;

		///<summary>
		///<para> (0024,0061) Excessive False Positives Data Flag </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint ExcessiveFalsePositivesDataFlag = 2359393;

		///<summary>
		///<para> (0024,0062) Excessive False Positives </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint ExcessiveFalsePositives = 2359394;

		///<summary>
		///<para> (0024,0063) Visual Field Test Normals Flag </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint VisualFieldTestNormalsFlag = 2359395;

		///<summary>
		///<para> (0024,0064) Results Normals Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint ResultsNormalsSequence = 2359396;

		///<summary>
		///<para> (0024,0065) Age Corrected Sensitivity Deviation Algorithm Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint AgeCorrectedSensitivityDeviationAlgorithmSequence = 2359397;

		///<summary>
		///<para> (0024,0066) Global Deviation From Normal </para>
		///<para> VR: FL VM=1 </para>
		///</summary>
        public const uint GlobalDeviationFromNormal = 2359398;

		///<summary>
		///<para> (0024,0067) Generalized Defect Sensitivity Deviation Algorithm Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint GeneralizedDefectSensitivityDeviationAlgorithmSequence = 2359399;

		///<summary>
		///<para> (0024,0068) Localized Deviation From Normal </para>
		///<para> VR: FL VM=1 </para>
		///</summary>
        public const uint LocalizedDeviationFromNormal = 2359400;

		///<summary>
		///<para> (0024,0069) Patient Reliability Indicator </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint PatientReliabilityIndicator = 2359401;

		///<summary>
		///<para> (0024,0070) Visual Field Mean Sensitivity </para>
		///<para> VR: FL VM=1 </para>
		///</summary>
        public const uint VisualFieldMeanSensitivity = 2359408;

		///<summary>
		///<para> (0024,0071) Global Deviation Probability </para>
		///<para> VR: FL VM=1 </para>
		///</summary>
        public const uint GlobalDeviationProbability = 2359409;

		///<summary>
		///<para> (0024,0072) Local Deviation Probability Normals Flag </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint LocalDeviationProbabilityNormalsFlag = 2359410;

		///<summary>
		///<para> (0024,0073) Localized Deviation Probability </para>
		///<para> VR: FL VM=1 </para>
		///</summary>
        public const uint LocalizedDeviationProbability = 2359411;

		///<summary>
		///<para> (0024,0074) Short Term Fluctuation Calculated </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint ShortTermFluctuationCalculated = 2359412;

		///<summary>
		///<para> (0024,0075) Short Term Fluctuation </para>
		///<para> VR: FL VM=1 </para>
		///</summary>
        public const uint ShortTermFluctuation = 2359413;

		///<summary>
		///<para> (0024,0076) Short Term Fluctuation Probability Calculated </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint ShortTermFluctuationProbabilityCalculated = 2359414;

		///<summary>
		///<para> (0024,0077) Short Term Fluctuation Probability </para>
		///<para> VR: FL VM=1 </para>
		///</summary>
        public const uint ShortTermFluctuationProbability = 2359415;

		///<summary>
		///<para> (0024,0078) Corrected Localized Deviation From Normal Calculated </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint CorrectedLocalizedDeviationFromNormalCalculated = 2359416;

		///<summary>
		///<para> (0024,0079) Corrected Localized Deviation From Normal </para>
		///<para> VR: FL VM=1 </para>
		///</summary>
        public const uint CorrectedLocalizedDeviationFromNormal = 2359417;

		///<summary>
		///<para> (0024,0080) Corrected Localized Deviation From Normal Probability Calculated </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint CorrectedLocalizedDeviationFromNormalProbabilityCalculated = 2359424;

		///<summary>
		///<para> (0024,0081) Corrected Localized Deviation From Normal Probability </para>
		///<para> VR: FL VM=1 </para>
		///</summary>
        public const uint CorrectedLocalizedDeviationFromNormalProbability = 2359425;

		///<summary>
		///<para> (0024,0083) Global Deviation Probability Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint GlobalDeviationProbabilitySequence = 2359427;

		///<summary>
		///<para> (0024,0085) Localized Deviation Probability Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint LocalizedDeviationProbabilitySequence = 2359429;

		///<summary>
		///<para> (0024,0086) Foveal Sensitivity Measured </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint FovealSensitivityMeasured = 2359430;

		///<summary>
		///<para> (0024,0087) Foveal Sensitivity </para>
		///<para> VR: FL VM=1 </para>
		///</summary>
        public const uint FovealSensitivity = 2359431;

		///<summary>
		///<para> (0024,0088) Visual Field Test Duration </para>
		///<para> VR: FL VM=1 </para>
		///</summary>
        public const uint VisualFieldTestDuration = 2359432;

		///<summary>
		///<para> (0024,0089) Visual Field Test Point Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint VisualFieldTestPointSequence = 2359433;

		///<summary>
		///<para> (0024,0090) Visual Field Test Point X-Coordinate </para>
		///<para> VR: FL VM=1 </para>
		///</summary>
        public const uint VisualFieldTestPointXCoordinate = 2359440;

		///<summary>
		///<para> (0024,0091) Visual Field Test Point Y-Coordinate </para>
		///<para> VR: FL VM=1 </para>
		///</summary>
        public const uint VisualFieldTestPointYCoordinate = 2359441;

		///<summary>
		///<para> (0024,0092) Age Corrected Sensitivity Deviation Value </para>
		///<para> VR: FL VM=1 </para>
		///</summary>
        public const uint AgeCorrectedSensitivityDeviationValue = 2359442;

		///<summary>
		///<para> (0024,0093) Stimulus Results </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint StimulusResults = 2359443;

		///<summary>
		///<para> (0024,0094) Sensitivity Value </para>
		///<para> VR: FL VM=1 </para>
		///</summary>
        public const uint SensitivityValue = 2359444;

		///<summary>
		///<para> (0024,0095) Retest Stimulus Seen </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint RetestStimulusSeen = 2359445;

		///<summary>
		///<para> (0024,0096) Retest Sensitivity Value </para>
		///<para> VR: FL VM=1 </para>
		///</summary>
        public const uint RetestSensitivityValue = 2359446;

		///<summary>
		///<para> (0024,0097) Visual Field Test Point Normals Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint VisualFieldTestPointNormalsSequence = 2359447;

		///<summary>
		///<para> (0024,0098) Quantified Defect </para>
		///<para> VR: FL VM=1 </para>
		///</summary>
        public const uint QuantifiedDefect = 2359448;

		///<summary>
		///<para> (0024,0100) Age Corrected Sensitivity Deviation Probability Value </para>
		///<para> VR: FL VM=1 </para>
		///</summary>
        public const uint AgeCorrectedSensitivityDeviationProbabilityValue = 2359552;

		///<summary>
		///<para> (0024,0102) Generalized Defect Corrected Sensitivity Deviation Flag </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint GeneralizedDefectCorrectedSensitivityDeviationFlag = 2359554;

		///<summary>
		///<para> (0024,0103) Generalized Defect Corrected Sensitivity Deviation Value </para>
		///<para> VR: FL VM=1 </para>
		///</summary>
        public const uint GeneralizedDefectCorrectedSensitivityDeviationValue = 2359555;

		///<summary>
		///<para> (0024,0104) Generalized Defect Corrected Sensitivity Deviation Probability Value </para>
		///<para> VR: FL VM=1 </para>
		///</summary>
        public const uint GeneralizedDefectCorrectedSensitivityDeviationProbabilityValue = 2359556;

		///<summary>
		///<para> (0024,0105) Minimum Sensitivity Value </para>
		///<para> VR: FL VM=1 </para>
		///</summary>
        public const uint MinimumSensitivityValue = 2359557;

		///<summary>
		///<para> (0024,0106) Blind Spot Localized </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint BlindSpotLocalized = 2359558;

		///<summary>
		///<para> (0024,0107) Blind Spot X-Coordinate </para>
		///<para> VR: FL VM=1 </para>
		///</summary>
        public const uint BlindSpotXCoordinate = 2359559;

		///<summary>
		///<para> (0024,0108) Blind Spot Y-Coordinate </para>
		///<para> VR: FL VM=1 </para>
		///</summary>
        public const uint BlindSpotYCoordinate = 2359560;

		///<summary>
		///<para> (0024,0110) Visual Acuity Measurement Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint VisualAcuityMeasurementSequence = 2359568;

		///<summary>
		///<para> (0024,0112) Refractive Parameters Used on Patient Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint RefractiveParametersUsedOnPatientSequence = 2359570;

		///<summary>
		///<para> (0024,0113) Measurement Laterality </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint MeasurementLaterality = 2359571;

		///<summary>
		///<para> (0024,0114) Ophthalmic Patient Clinical Information Left Eye Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint OphthalmicPatientClinicalInformationLeftEyeSequence = 2359572;

		///<summary>
		///<para> (0024,0115) Ophthalmic Patient Clinical Information Right Eye Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint OphthalmicPatientClinicalInformationRightEyeSequence = 2359573;

		///<summary>
		///<para> (0024,0117) Foveal Point Normative Data Flag </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint FovealPointNormativeDataFlag = 2359575;

		///<summary>
		///<para> (0024,0118) Foveal Point Probability Value </para>
		///<para> VR: FL VM=1 </para>
		///</summary>
        public const uint FovealPointProbabilityValue = 2359576;

		///<summary>
		///<para> (0024,0120) Screening Baseline Measured </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint ScreeningBaselineMeasured = 2359584;

		///<summary>
		///<para> (0024,0122) Screening Baseline Measured Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint ScreeningBaselineMeasuredSequence = 2359586;

		///<summary>
		///<para> (0024,0124) Screening Baseline Type </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint ScreeningBaselineType = 2359588;

		///<summary>
		///<para> (0024,0126) Screening Baseline Value </para>
		///<para> VR: FL VM=1 </para>
		///</summary>
        public const uint ScreeningBaselineValue = 2359590;

		///<summary>
		///<para> (0024,0202) Algorithm Source </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint AlgorithmSource = 2359810;

		///<summary>
		///<para> (0024,0306) Data Set Name </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint DataSetName = 2360070;

		///<summary>
		///<para> (0024,0307) Data Set Version </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint DataSetVersion = 2360071;

		///<summary>
		///<para> (0024,0308) Data Set Source </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint DataSetSource = 2360072;

		///<summary>
		///<para> (0024,0309) Data Set Description </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint DataSetDescription = 2360073;

		///<summary>
		///<para> (0024,0317) Visual Field Test Reliability Global Index Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint VisualFieldTestReliabilityGlobalIndexSequence = 2360087;

		///<summary>
		///<para> (0024,0320) Visual Field Global Results Index Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint VisualFieldGlobalResultsIndexSequence = 2360096;

		///<summary>
		///<para> (0024,0325) Data Observation Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint DataObservationSequence = 2360101;

		///<summary>
		///<para> (0024,0338) Index Normals Flag </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint IndexNormalsFlag = 2360120;

		///<summary>
		///<para> (0024,0341) Index Probability </para>
		///<para> VR: FL VM=1 </para>
		///</summary>
        public const uint IndexProbability = 2360129;

		///<summary>
		///<para> (0024,0344) Index Probability Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint IndexProbabilitySequence = 2360132;

		///<summary>
		///<para> (0028,0002) Samples per Pixel </para>
		///<para> VR: US VM=1 </para>
		///</summary>
        public const uint SamplesPerPixel = 2621442;

		///<summary>
		///<para> (0028,0003) Samples per Pixel Used </para>
		///<para> VR: US VM=1 </para>
		///</summary>
        public const uint SamplesPerPixelUsed = 2621443;

		///<summary>
		///<para> (0028,0004) Photometric Interpretation </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint PhotometricInterpretation = 2621444;

		///<summary>
		///<para> (0028,0005) Image Dimensions (RETIRED) </para>
		///<para> VR: US VM=1 </para>
		///</summary>
        public const uint ImageDimensionsRetired = 2621445;

		///<summary>
		///<para> (0028,0006) Planar Configuration </para>
		///<para> VR: US VM=1 </para>
		///</summary>
        public const uint PlanarConfiguration = 2621446;

		///<summary>
		///<para> (0028,0008) Number of Frames </para>
		///<para> VR: IS VM=1 </para>
		///</summary>
        public const uint NumberOfFrames = 2621448;

		///<summary>
		///<para> (0028,0009) Frame Increment Pointer </para>
		///<para> VR: AT VM=1-n </para>
		///</summary>
        public const uint FrameIncrementPointer = 2621449;

		///<summary>
		///<para> (0028,000A) Frame Dimension Pointer </para>
		///<para> VR: AT VM=1-n </para>
		///</summary>
        public const uint FrameDimensionPointer = 2621450;

		///<summary>
		///<para> (0028,0010) Rows </para>
		///<para> VR: US VM=1 </para>
		///</summary>
        public const uint Rows = 2621456;

		///<summary>
		///<para> (0028,0011) Columns </para>
		///<para> VR: US VM=1 </para>
		///</summary>
        public const uint Columns = 2621457;

		///<summary>
		///<para> (0028,0012) Planes (RETIRED) </para>
		///<para> VR: US VM=1 </para>
		///</summary>
        public const uint PlanesRetired = 2621458;

		///<summary>
		///<para> (0028,0014) Ultrasound Color Data Present </para>
		///<para> VR: US VM=1 </para>
		///</summary>
        public const uint UltrasoundColorDataPresent = 2621460;

		///<summary>
		///<para> (0028,0030) Pixel Spacing </para>
		///<para> VR: DS VM=2 </para>
		///</summary>
        public const uint PixelSpacing = 2621488;

		///<summary>
		///<para> (0028,0031) Zoom Factor </para>
		///<para> VR: DS VM=2 </para>
		///</summary>
        public const uint ZoomFactor = 2621489;

		///<summary>
		///<para> (0028,0032) Zoom Center </para>
		///<para> VR: DS VM=2 </para>
		///</summary>
        public const uint ZoomCenter = 2621490;

		///<summary>
		///<para> (0028,0034) Pixel Aspect Ratio </para>
		///<para> VR: IS VM=2 </para>
		///</summary>
        public const uint PixelAspectRatio = 2621492;

		///<summary>
		///<para> (0028,0040) Image Format (RETIRED) </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint ImageFormatRetired = 2621504;

		///<summary>
		///<para> (0028,0050) Manipulated Image (RETIRED) </para>
		///<para> VR: LO VM=1-n </para>
		///</summary>
        public const uint ManipulatedImageRetired = 2621520;

		///<summary>
		///<para> (0028,0051) Corrected Image </para>
		///<para> VR: CS VM=1-n </para>
		///</summary>
        public const uint CorrectedImage = 2621521;

		///<summary>
		///<para> (0028,005F) Compression Recognition Code (RETIRED) </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint CompressionRecognitionCodeRetired = 2621535;

		///<summary>
		///<para> (0028,0060) Compression Code (RETIRED) </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint CompressionCodeRetired = 2621536;

		///<summary>
		///<para> (0028,0061) Compression Originator (RETIRED) </para>
		///<para> VR: SH VM=1 </para>
		///</summary>
        public const uint CompressionOriginatorRetired = 2621537;

		///<summary>
		///<para> (0028,0062) Compression Label (RETIRED) </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint CompressionLabelRetired = 2621538;

		///<summary>
		///<para> (0028,0063) Compression Description (RETIRED) </para>
		///<para> VR: SH VM=1 </para>
		///</summary>
        public const uint CompressionDescriptionRetired = 2621539;

		///<summary>
		///<para> (0028,0065) Compression Sequence (RETIRED) </para>
		///<para> VR: CS VM=1-n </para>
		///</summary>
        public const uint CompressionSequenceRetired = 2621541;

		///<summary>
		///<para> (0028,0066) Compression Step Pointers (RETIRED) </para>
		///<para> VR: AT VM=1-n </para>
		///</summary>
        public const uint CompressionStepPointersRetired = 2621542;

		///<summary>
		///<para> (0028,0068) Repeat Interval (RETIRED) </para>
		///<para> VR: US VM=1 </para>
		///</summary>
        public const uint RepeatIntervalRetired = 2621544;

		///<summary>
		///<para> (0028,0069) Bits Grouped (RETIRED) </para>
		///<para> VR: US VM=1 </para>
		///</summary>
        public const uint BitsGroupedRetired = 2621545;

		///<summary>
		///<para> (0028,0070) Perimeter Table (RETIRED) </para>
		///<para> VR: US VM=1-n </para>
		///</summary>
        public const uint PerimeterTableRetired = 2621552;

		///<summary>
		///<para> (0028,0071) Perimeter Value (RETIRED) </para>
		///<para> VR: US/SS VM=1 </para>
		///</summary>
        public const uint PerimeterValueRetired = 2621553;

		///<summary>
		///<para> (0028,0080) Predictor Rows (RETIRED) </para>
		///<para> VR: US VM=1 </para>
		///</summary>
        public const uint PredictorRowsRetired = 2621568;

		///<summary>
		///<para> (0028,0081) Predictor Columns (RETIRED) </para>
		///<para> VR: US VM=1 </para>
		///</summary>
        public const uint PredictorColumnsRetired = 2621569;

		///<summary>
		///<para> (0028,0082) Predictor Constants (RETIRED) </para>
		///<para> VR: US VM=1-n </para>
		///</summary>
        public const uint PredictorConstantsRetired = 2621570;

		///<summary>
		///<para> (0028,0090) Blocked Pixels (RETIRED) </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint BlockedPixelsRetired = 2621584;

		///<summary>
		///<para> (0028,0091) Block Rows (RETIRED) </para>
		///<para> VR: US VM=1 </para>
		///</summary>
        public const uint BlockRowsRetired = 2621585;

		///<summary>
		///<para> (0028,0092) Block Columns (RETIRED) </para>
		///<para> VR: US VM=1 </para>
		///</summary>
        public const uint BlockColumnsRetired = 2621586;

		///<summary>
		///<para> (0028,0093) Row Overlap (RETIRED) </para>
		///<para> VR: US VM=1 </para>
		///</summary>
        public const uint RowOverlapRetired = 2621587;

		///<summary>
		///<para> (0028,0094) Column Overlap (RETIRED) </para>
		///<para> VR: US VM=1 </para>
		///</summary>
        public const uint ColumnOverlapRetired = 2621588;

		///<summary>
		///<para> (0028,0100) Bits Allocated </para>
		///<para> VR: US VM=1 </para>
		///</summary>
        public const uint BitsAllocated = 2621696;

		///<summary>
		///<para> (0028,0101) Bits Stored </para>
		///<para> VR: US VM=1 </para>
		///</summary>
        public const uint BitsStored = 2621697;

		///<summary>
		///<para> (0028,0102) High Bit </para>
		///<para> VR: US VM=1 </para>
		///</summary>
        public const uint HighBit = 2621698;

		///<summary>
		///<para> (0028,0103) Pixel Representation </para>
		///<para> VR: US VM=1 </para>
		///</summary>
        public const uint PixelRepresentation = 2621699;

		///<summary>
		///<para> (0028,0104) Smallest Valid Pixel Value (RETIRED) </para>
		///<para> VR: US/SS VM=1 </para>
		///</summary>
        public const uint SmallestValidPixelValueRetired = 2621700;

		///<summary>
		///<para> (0028,0105) Largest Valid Pixel Value (RETIRED) </para>
		///<para> VR: US/SS VM=1 </para>
		///</summary>
        public const uint LargestValidPixelValueRetired = 2621701;

		///<summary>
		///<para> (0028,0106) Smallest Image Pixel Value </para>
		///<para> VR: US/SS VM=1 </para>
		///</summary>
        public const uint SmallestImagePixelValue = 2621702;

		///<summary>
		///<para> (0028,0107) Largest Image Pixel Value </para>
		///<para> VR: US/SS VM=1 </para>
		///</summary>
        public const uint LargestImagePixelValue = 2621703;

		///<summary>
		///<para> (0028,0108) Smallest Pixel Value in Series </para>
		///<para> VR: US/SS VM=1 </para>
		///</summary>
        public const uint SmallestPixelValueInSeries = 2621704;

		///<summary>
		///<para> (0028,0109) Largest Pixel Value in Series </para>
		///<para> VR: US/SS VM=1 </para>
		///</summary>
        public const uint LargestPixelValueInSeries = 2621705;

		///<summary>
		///<para> (0028,0110) Smallest Image Pixel Value in Plane (RETIRED) </para>
		///<para> VR: US/SS VM=1 </para>
		///</summary>
        public const uint SmallestImagePixelValueInPlaneRetired = 2621712;

		///<summary>
		///<para> (0028,0111) Largest Image Pixel Value in Plane (RETIRED) </para>
		///<para> VR: US/SS VM=1 </para>
		///</summary>
        public const uint LargestImagePixelValueInPlaneRetired = 2621713;

		///<summary>
		///<para> (0028,0120) Pixel Padding Value </para>
		///<para> VR: US/SS VM=1 </para>
		///</summary>
        public const uint PixelPaddingValue = 2621728;

		///<summary>
		///<para> (0028,0121) Pixel Padding Range Limit </para>
		///<para> VR: US/SS VM=1 </para>
		///</summary>
        public const uint PixelPaddingRangeLimit = 2621729;

		///<summary>
		///<para> (0028,0122) Float Pixel Padding Value </para>
		///<para> VR: FL VM=1 </para>
		///</summary>
        public const uint FloatPixelPaddingValue = 2621730;

		///<summary>
		///<para> (0028,0123) Double Float Pixel Padding Value </para>
		///<para> VR: FD VM=1 </para>
		///</summary>
        public const uint DoubleFloatPixelPaddingValue = 2621731;

		///<summary>
		///<para> (0028,0124) Float Pixel Padding Range Limit </para>
		///<para> VR: FL VM=1 </para>
		///</summary>
        public const uint FloatPixelPaddingRangeLimit = 2621732;

		///<summary>
		///<para> (0028,0125) Double Float Pixel Padding Range Limit </para>
		///<para> VR: FD VM=1 </para>
		///</summary>
        public const uint DoubleFloatPixelPaddingRangeLimit = 2621733;

		///<summary>
		///<para> (0028,0200) Image Location (RETIRED) </para>
		///<para> VR: US VM=1 </para>
		///</summary>
        public const uint ImageLocationRetired = 2621952;

		///<summary>
		///<para> (0028,0300) Quality Control Image </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint QualityControlImage = 2622208;

		///<summary>
		///<para> (0028,0301) Burned In Annotation </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint BurnedInAnnotation = 2622209;

		///<summary>
		///<para> (0028,0302) Recognizable Visual Features </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint RecognizableVisualFeatures = 2622210;

		///<summary>
		///<para> (0028,0303) Longitudinal Temporal Information Modified </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint LongitudinalTemporalInformationModified = 2622211;

		///<summary>
		///<para> (0028,0304) Referenced Color Palette Instance UID </para>
		///<para> VR: UI VM=1 </para>
		///</summary>
        public const uint ReferencedColorPaletteInstanceUid = 2622212;

		///<summary>
		///<para> (0028,0400) Transform Label (RETIRED) </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint TransformLabelRetired = 2622464;

		///<summary>
		///<para> (0028,0401) Transform Version Number (RETIRED) </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint TransformVersionNumberRetired = 2622465;

		///<summary>
		///<para> (0028,0402) Number of Transform Steps (RETIRED) </para>
		///<para> VR: US VM=1 </para>
		///</summary>
        public const uint NumberOfTransformStepsRetired = 2622466;

		///<summary>
		///<para> (0028,0403) Sequence of Compressed Data (RETIRED) </para>
		///<para> VR: LO VM=1-n </para>
		///</summary>
        public const uint SequenceOfCompressedDataRetired = 2622467;

		///<summary>
		///<para> (0028,0404) Details of Coefficients (RETIRED) </para>
		///<para> VR: AT VM=1-n </para>
		///</summary>
        public const uint DetailsOfCoefficientsRetired = 2622468;

		///<summary>
		///<para> (0028,04x0) Rows For Nth Order Coefficients (RETIRED) </para>
		///<para> VR: US VM=1 </para>
		///</summary>
        public const uint RowsForNthOrderCoefficientsRetired = 2622464;

		///<summary>
		///<para> (0028,04x1) Columns For Nth Order Coefficients (RETIRED) </para>
		///<para> VR: US VM=1 </para>
		///</summary>
        public const uint ColumnsForNthOrderCoefficientsRetired = 2622465;

		///<summary>
		///<para> (0028,04x2) Coefficient Coding (RETIRED) </para>
		///<para> VR: LO VM=1-n </para>
		///</summary>
        public const uint CoefficientCodingRetired = 2622466;

		///<summary>
		///<para> (0028,04x3) Coefficient Coding Pointers (RETIRED) </para>
		///<para> VR: AT VM=1-n </para>
		///</summary>
        public const uint CoefficientCodingPointersRetired = 2622467;

		///<summary>
		///<para> (0028,0700) DCT Label (RETIRED) </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint DctLabelRetired = 2623232;

		///<summary>
		///<para> (0028,0701) Data Block Description (RETIRED) </para>
		///<para> VR: CS VM=1-n </para>
		///</summary>
        public const uint DataBlockDescriptionRetired = 2623233;

		///<summary>
		///<para> (0028,0702) Data Block (RETIRED) </para>
		///<para> VR: AT VM=1-n </para>
		///</summary>
        public const uint DataBlockRetired = 2623234;

		///<summary>
		///<para> (0028,0710) Normalization Factor Format (RETIRED) </para>
		///<para> VR: US VM=1 </para>
		///</summary>
        public const uint NormalizationFactorFormatRetired = 2623248;

		///<summary>
		///<para> (0028,0720) Zonal Map Number Format (RETIRED) </para>
		///<para> VR: US VM=1 </para>
		///</summary>
        public const uint ZonalMapNumberFormatRetired = 2623264;

		///<summary>
		///<para> (0028,0721) Zonal Map Location (RETIRED) </para>
		///<para> VR: AT VM=1-n </para>
		///</summary>
        public const uint ZonalMapLocationRetired = 2623265;

		///<summary>
		///<para> (0028,0722) Zonal Map Format (RETIRED) </para>
		///<para> VR: US VM=1 </para>
		///</summary>
        public const uint ZonalMapFormatRetired = 2623266;

		///<summary>
		///<para> (0028,0730) Adaptive Map Format (RETIRED) </para>
		///<para> VR: US VM=1 </para>
		///</summary>
        public const uint AdaptiveMapFormatRetired = 2623280;

		///<summary>
		///<para> (0028,0740) Code Number Format (RETIRED) </para>
		///<para> VR: US VM=1 </para>
		///</summary>
        public const uint CodeNumberFormatRetired = 2623296;

		///<summary>
		///<para> (0028,08x0) Code Label (RETIRED) </para>
		///<para> VR: CS VM=1-n </para>
		///</summary>
        public const uint CodeLabelRetired = 2623488;

		///<summary>
		///<para> (0028,08x2) Number of Tables (RETIRED) </para>
		///<para> VR: US VM=1 </para>
		///</summary>
        public const uint NumberOfTablesRetired = 2623490;

		///<summary>
		///<para> (0028,08x3) Code Table Location (RETIRED) </para>
		///<para> VR: AT VM=1-n </para>
		///</summary>
        public const uint CodeTableLocationRetired = 2623491;

		///<summary>
		///<para> (0028,08x4) Bits For Code Word (RETIRED) </para>
		///<para> VR: US VM=1 </para>
		///</summary>
        public const uint BitsForCodeWordRetired = 2623492;

		///<summary>
		///<para> (0028,08x8) Image Data Location (RETIRED) </para>
		///<para> VR: AT VM=1-n </para>
		///</summary>
        public const uint ImageDataLocationRetired = 2623496;

		///<summary>
		///<para> (0028,0A02) Pixel Spacing Calibration Type </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint PixelSpacingCalibrationType = 2624002;

		///<summary>
		///<para> (0028,0A04) Pixel Spacing Calibration Description </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint PixelSpacingCalibrationDescription = 2624004;

		///<summary>
		///<para> (0028,1040) Pixel Intensity Relationship </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint PixelIntensityRelationship = 2625600;

		///<summary>
		///<para> (0028,1041) Pixel Intensity Relationship Sign </para>
		///<para> VR: SS VM=1 </para>
		///</summary>
        public const uint PixelIntensityRelationshipSign = 2625601;

		///<summary>
		///<para> (0028,1050) Window Center </para>
		///<para> VR: DS VM=1-n </para>
		///</summary>
        public const uint WindowCenter = 2625616;

		///<summary>
		///<para> (0028,1051) Window Width </para>
		///<para> VR: DS VM=1-n </para>
		///</summary>
        public const uint WindowWidth = 2625617;

		///<summary>
		///<para> (0028,1052) Rescale Intercept </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint RescaleIntercept = 2625618;

		///<summary>
		///<para> (0028,1053) Rescale Slope </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint RescaleSlope = 2625619;

		///<summary>
		///<para> (0028,1054) Rescale Type </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint RescaleType = 2625620;

		///<summary>
		///<para> (0028,1055) Window Center & Width Explanation </para>
		///<para> VR: LO VM=1-n </para>
		///</summary>
        public const uint WindowCenterWidthExplanation = 2625621;

		///<summary>
		///<para> (0028,1056) VOI LUT Function </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint VoiLutFunction = 2625622;

		///<summary>
		///<para> (0028,1080) Gray Scale (RETIRED) </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint GrayScaleRetired = 2625664;

		///<summary>
		///<para> (0028,1090) Recommended Viewing Mode </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint RecommendedViewingMode = 2625680;

		///<summary>
		///<para> (0028,1100) Gray Lookup Table Descriptor (RETIRED) </para>
		///<para> VR: US/SS VM=3 </para>
		///</summary>
        public const uint GrayLookupTableDescriptorRetired = 2625792;

		///<summary>
		///<para> (0028,1101) Red Palette Color Lookup Table Descriptor </para>
		///<para> VR: US/SS VM=3 </para>
		///</summary>
        public const uint RedPaletteColorLookupTableDescriptor = 2625793;

		///<summary>
		///<para> (0028,1102) Green Palette Color Lookup Table Descriptor </para>
		///<para> VR: US/SS VM=3 </para>
		///</summary>
        public const uint GreenPaletteColorLookupTableDescriptor = 2625794;

		///<summary>
		///<para> (0028,1103) Blue Palette Color Lookup Table Descriptor </para>
		///<para> VR: US/SS VM=3 </para>
		///</summary>
        public const uint BluePaletteColorLookupTableDescriptor = 2625795;

		///<summary>
		///<para> (0028,1104) Alpha Palette Color Lookup Table Descriptor </para>
		///<para> VR: US VM=3 </para>
		///</summary>
        public const uint AlphaPaletteColorLookupTableDescriptor = 2625796;

		///<summary>
		///<para> (0028,1111) Large Red Palette Color Lookup Table Descriptor (RETIRED) </para>
		///<para> VR: US/SS VM=4 </para>
		///</summary>
        public const uint LargeRedPaletteColorLookupTableDescriptorRetired = 2625809;

		///<summary>
		///<para> (0028,1112) Large Green Palette Color Lookup Table Descriptor (RETIRED) </para>
		///<para> VR: US/SS VM=4 </para>
		///</summary>
        public const uint LargeGreenPaletteColorLookupTableDescriptorRetired = 2625810;

		///<summary>
		///<para> (0028,1113) Large Blue Palette Color Lookup Table Descriptor (RETIRED) </para>
		///<para> VR: US/SS VM=4 </para>
		///</summary>
        public const uint LargeBluePaletteColorLookupTableDescriptorRetired = 2625811;

		///<summary>
		///<para> (0028,1199) Palette Color Lookup Table UID </para>
		///<para> VR: UI VM=1 </para>
		///</summary>
        public const uint PaletteColorLookupTableUid = 2625945;

		///<summary>
		///<para> (0028,1200) Gray Lookup Table Data (RETIRED) </para>
		///<para> VR: US/SS/OW VM=1-n or 1 </para>
		///</summary>
        public const uint GrayLookupTableDataRetired = 2626048;

		///<summary>
		///<para> (0028,1201) Red Palette Color Lookup Table Data </para>
		///<para> VR: OW VM=1 </para>
		///</summary>
        public const uint RedPaletteColorLookupTableData = 2626049;

		///<summary>
		///<para> (0028,1202) Green Palette Color Lookup Table Data </para>
		///<para> VR: OW VM=1 </para>
		///</summary>
        public const uint GreenPaletteColorLookupTableData = 2626050;

		///<summary>
		///<para> (0028,1203) Blue Palette Color Lookup Table Data </para>
		///<para> VR: OW VM=1 </para>
		///</summary>
        public const uint BluePaletteColorLookupTableData = 2626051;

		///<summary>
		///<para> (0028,1204) Alpha Palette Color Lookup Table Data </para>
		///<para> VR: OW VM=1 </para>
		///</summary>
        public const uint AlphaPaletteColorLookupTableData = 2626052;

		///<summary>
		///<para> (0028,1211) Large Red Palette Color Lookup Table Data (RETIRED) </para>
		///<para> VR: OW VM=1 </para>
		///</summary>
        public const uint LargeRedPaletteColorLookupTableDataRetired = 2626065;

		///<summary>
		///<para> (0028,1212) Large Green Palette Color Lookup Table Data (RETIRED) </para>
		///<para> VR: OW VM=1 </para>
		///</summary>
        public const uint LargeGreenPaletteColorLookupTableDataRetired = 2626066;

		///<summary>
		///<para> (0028,1213) Large Blue Palette Color Lookup Table Data (RETIRED) </para>
		///<para> VR: OW VM=1 </para>
		///</summary>
        public const uint LargeBluePaletteColorLookupTableDataRetired = 2626067;

		///<summary>
		///<para> (0028,1214) Large Palette Color Lookup Table UID (RETIRED) </para>
		///<para> VR: UI VM=1 </para>
		///</summary>
        public const uint LargePaletteColorLookupTableUidRetired = 2626068;

		///<summary>
		///<para> (0028,1221) Segmented Red Palette Color Lookup Table Data </para>
		///<para> VR: OW VM=1 </para>
		///</summary>
        public const uint SegmentedRedPaletteColorLookupTableData = 2626081;

		///<summary>
		///<para> (0028,1222) Segmented Green Palette Color Lookup Table Data </para>
		///<para> VR: OW VM=1 </para>
		///</summary>
        public const uint SegmentedGreenPaletteColorLookupTableData = 2626082;

		///<summary>
		///<para> (0028,1223) Segmented Blue Palette Color Lookup Table Data </para>
		///<para> VR: OW VM=1 </para>
		///</summary>
        public const uint SegmentedBluePaletteColorLookupTableData = 2626083;

		///<summary>
		///<para> (0028,1224) Segmented Alpha Palette Color Lookup Table Data </para>
		///<para> VR: OW VM=1 </para>
		///</summary>
        public const uint SegmentedAlphaPaletteColorLookupTableData = 2626084;

		///<summary>
		///<para> (0028,1230) Stored Value Color Range Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint StoredValueColorRangeSequence = 2626096;

		///<summary>
		///<para> (0028,1231) Minimum Stored Value Mapped </para>
		///<para> VR: FD VM=1 </para>
		///</summary>
        public const uint MinimumStoredValueMapped = 2626097;

		///<summary>
		///<para> (0028,1232) Maximum Stored Value Mapped </para>
		///<para> VR: FD VM=1 </para>
		///</summary>
        public const uint MaximumStoredValueMapped = 2626098;

		///<summary>
		///<para> (0028,1300) Breast Implant Present </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint BreastImplantPresent = 2626304;

		///<summary>
		///<para> (0028,1350) Partial View </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint PartialView = 2626384;

		///<summary>
		///<para> (0028,1351) Partial View Description </para>
		///<para> VR: ST VM=1 </para>
		///</summary>
        public const uint PartialViewDescription = 2626385;

		///<summary>
		///<para> (0028,1352) Partial View Code Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint PartialViewCodeSequence = 2626386;

		///<summary>
		///<para> (0028,135A) Spatial Locations Preserved </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint SpatialLocationsPreserved = 2626394;

		///<summary>
		///<para> (0028,1401) Data Frame Assignment Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint DataFrameAssignmentSequence = 2626561;

		///<summary>
		///<para> (0028,1402) Data Path Assignment </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint DataPathAssignment = 2626562;

		///<summary>
		///<para> (0028,1403) Bits Mapped to Color Lookup Table </para>
		///<para> VR: US VM=1 </para>
		///</summary>
        public const uint BitsMappedToColorLookupTable = 2626563;

		///<summary>
		///<para> (0028,1404) Blending LUT 1 Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint BlendingLut1Sequence = 2626564;

		///<summary>
		///<para> (0028,1405) Blending LUT 1 Transfer Function </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint BlendingLut1TransferFunction = 2626565;

		///<summary>
		///<para> (0028,1406) Blending Weight Constant </para>
		///<para> VR: FD VM=1 </para>
		///</summary>
        public const uint BlendingWeightConstant = 2626566;

		///<summary>
		///<para> (0028,1407) Blending Lookup Table Descriptor </para>
		///<para> VR: US VM=3 </para>
		///</summary>
        public const uint BlendingLookupTableDescriptor = 2626567;

		///<summary>
		///<para> (0028,1408) Blending Lookup Table Data </para>
		///<para> VR: OW VM=1 </para>
		///</summary>
        public const uint BlendingLookupTableData = 2626568;

		///<summary>
		///<para> (0028,140B) Enhanced Palette Color Lookup Table Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint EnhancedPaletteColorLookupTableSequence = 2626571;

		///<summary>
		///<para> (0028,140C) Blending LUT 2 Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint BlendingLut2Sequence = 2626572;

		///<summary>
		///<para> (0028,140D) Blending LUT 2 Transfer Function </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint BlendingLut2TransferFunction = 2626573;

		///<summary>
		///<para> (0028,140E) Data Path ID </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint DataPathId = 2626574;

		///<summary>
		///<para> (0028,140F) RGB LUT Transfer Function </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint RgbLutTransferFunction = 2626575;

		///<summary>
		///<para> (0028,1410) Alpha LUT Transfer Function </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint AlphaLutTransferFunction = 2626576;

		///<summary>
		///<para> (0028,2000) ICC Profile </para>
		///<para> VR: OB VM=1 </para>
		///</summary>
        public const uint IccProfile = 2629632;

		///<summary>
		///<para> (0028,2002) Color Space </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint ColorSpace = 2629634;

		///<summary>
		///<para> (0028,2110) Lossy Image Compression </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint LossyImageCompression = 2629904;

		///<summary>
		///<para> (0028,2112) Lossy Image Compression Ratio </para>
		///<para> VR: DS VM=1-n </para>
		///</summary>
        public const uint LossyImageCompressionRatio = 2629906;

		///<summary>
		///<para> (0028,2114) Lossy Image Compression Method </para>
		///<para> VR: CS VM=1-n </para>
		///</summary>
        public const uint LossyImageCompressionMethod = 2629908;

		///<summary>
		///<para> (0028,3000) Modality LUT Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint ModalityLutSequence = 2633728;

		///<summary>
		///<para> (0028,3002) LUT Descriptor </para>
		///<para> VR: US/SS VM=3 </para>
		///</summary>
        public const uint LutDescriptor = 2633730;

		///<summary>
		///<para> (0028,3003) LUT Explanation </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint LutExplanation = 2633731;

		///<summary>
		///<para> (0028,3004) Modality LUT Type </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint ModalityLutType = 2633732;

		///<summary>
		///<para> (0028,3006) LUT Data </para>
		///<para> VR: US/OW VM=1-n or 1 </para>
		///</summary>
        public const uint LutData = 2633734;

		///<summary>
		///<para> (0028,3010) VOI LUT Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint VoiLutSequence = 2633744;

		///<summary>
		///<para> (0028,3110) Softcopy VOI LUT Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint SoftcopyVoiLutSequence = 2634000;

		///<summary>
		///<para> (0028,4000) Image Presentation Comments (RETIRED) </para>
		///<para> VR: LT VM=1 </para>
		///</summary>
        public const uint ImagePresentationCommentsRetired = 2637824;

		///<summary>
		///<para> (0028,5000) Bi-Plane Acquisition Sequence (RETIRED) </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint BiPlaneAcquisitionSequenceRetired = 2641920;

		///<summary>
		///<para> (0028,6010) Representative Frame Number </para>
		///<para> VR: US VM=1 </para>
		///</summary>
        public const uint RepresentativeFrameNumber = 2646032;

		///<summary>
		///<para> (0028,6020) Frame Numbers of Interest (FOI) </para>
		///<para> VR: US VM=1-n </para>
		///</summary>
        public const uint FrameNumbersOfInterestFoi = 2646048;

		///<summary>
		///<para> (0028,6022) Frame of Interest Description </para>
		///<para> VR: LO VM=1-n </para>
		///</summary>
        public const uint FrameOfInterestDescription = 2646050;

		///<summary>
		///<para> (0028,6023) Frame of Interest Type </para>
		///<para> VR: CS VM=1-n </para>
		///</summary>
        public const uint FrameOfInterestType = 2646051;

		///<summary>
		///<para> (0028,6030) Mask Pointer(s) (RETIRED) </para>
		///<para> VR: US VM=1-n </para>
		///</summary>
        public const uint MaskPointersRetired = 2646064;

		///<summary>
		///<para> (0028,6040) R Wave Pointer </para>
		///<para> VR: US VM=1-n </para>
		///</summary>
        public const uint RWavePointer = 2646080;

		///<summary>
		///<para> (0028,6100) Mask Subtraction Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint MaskSubtractionSequence = 2646272;

		///<summary>
		///<para> (0028,6101) Mask Operation </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint MaskOperation = 2646273;

		///<summary>
		///<para> (0028,6102) Applicable Frame Range </para>
		///<para> VR: US VM=2-2n </para>
		///</summary>
        public const uint ApplicableFrameRange = 2646274;

		///<summary>
		///<para> (0028,6110) Mask Frame Numbers </para>
		///<para> VR: US VM=1-n </para>
		///</summary>
        public const uint MaskFrameNumbers = 2646288;

		///<summary>
		///<para> (0028,6112) Contrast Frame Averaging </para>
		///<para> VR: US VM=1 </para>
		///</summary>
        public const uint ContrastFrameAveraging = 2646290;

		///<summary>
		///<para> (0028,6114) Mask Sub-pixel Shift </para>
		///<para> VR: FL VM=2 </para>
		///</summary>
        public const uint MaskSubPixelShift = 2646292;

		///<summary>
		///<para> (0028,6120) TID Offset </para>
		///<para> VR: SS VM=1 </para>
		///</summary>
        public const uint TidOffset = 2646304;

		///<summary>
		///<para> (0028,6190) Mask Operation Explanation </para>
		///<para> VR: ST VM=1 </para>
		///</summary>
        public const uint MaskOperationExplanation = 2646416;

		///<summary>
		///<para> (0028,7000) Equipment Administrator Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint EquipmentAdministratorSequence = 2650112;

		///<summary>
		///<para> (0028,7001) Number of Display Subsystems </para>
		///<para> VR: US VM=1 </para>
		///</summary>
        public const uint NumberOfDisplaySubsystems = 2650113;

		///<summary>
		///<para> (0028,7002) Current Configuration ID </para>
		///<para> VR: US VM=1 </para>
		///</summary>
        public const uint CurrentConfigurationId = 2650114;

		///<summary>
		///<para> (0028,7003) Display Subsystem ID </para>
		///<para> VR: US VM=1 </para>
		///</summary>
        public const uint DisplaySubsystemId = 2650115;

		///<summary>
		///<para> (0028,7004) Display Subsystem Name </para>
		///<para> VR: SH VM=1 </para>
		///</summary>
        public const uint DisplaySubsystemName = 2650116;

		///<summary>
		///<para> (0028,7005) Display Subsystem Description </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint DisplaySubsystemDescription = 2650117;

		///<summary>
		///<para> (0028,7006) System Status </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint SystemStatus = 2650118;

		///<summary>
		///<para> (0028,7007) System Status Comment </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint SystemStatusComment = 2650119;

		///<summary>
		///<para> (0028,7008) Target Luminance Characteristics Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint TargetLuminanceCharacteristicsSequence = 2650120;

		///<summary>
		///<para> (0028,7009) Luminance Characteristics ID </para>
		///<para> VR: US VM=1 </para>
		///</summary>
        public const uint LuminanceCharacteristicsId = 2650121;

		///<summary>
		///<para> (0028,700A) Display Subsystem Configuration Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint DisplaySubsystemConfigurationSequence = 2650122;

		///<summary>
		///<para> (0028,700B) Configuration ID </para>
		///<para> VR: US VM=1 </para>
		///</summary>
        public const uint ConfigurationId = 2650123;

		///<summary>
		///<para> (0028,700C) Configuration Name </para>
		///<para> VR: SH VM=1 </para>
		///</summary>
        public const uint ConfigurationName = 2650124;

		///<summary>
		///<para> (0028,700D) Configuration Description </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint ConfigurationDescription = 2650125;

		///<summary>
		///<para> (0028,700E) Referenced Target Luminance Characteristics ID </para>
		///<para> VR: US VM=1 </para>
		///</summary>
        public const uint ReferencedTargetLuminanceCharacteristicsId = 2650126;

		///<summary>
		///<para> (0028,700F) QA Results Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint QaResultsSequence = 2650127;

		///<summary>
		///<para> (0028,7010) Display Subsystem QA Results Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint DisplaySubsystemQaResultsSequence = 2650128;

		///<summary>
		///<para> (0028,7011) Configuration QA Results Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint ConfigurationQaResultsSequence = 2650129;

		///<summary>
		///<para> (0028,7012) Measurement Equipment Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint MeasurementEquipmentSequence = 2650130;

		///<summary>
		///<para> (0028,7013) Measurement Functions </para>
		///<para> VR: CS VM=1-n </para>
		///</summary>
        public const uint MeasurementFunctions = 2650131;

		///<summary>
		///<para> (0028,7014) Measurement Equipment Type </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint MeasurementEquipmentType = 2650132;

		///<summary>
		///<para> (0028,7015) Visual Evaluation Result Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint VisualEvaluationResultSequence = 2650133;

		///<summary>
		///<para> (0028,7016) Display Calibration Result Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint DisplayCalibrationResultSequence = 2650134;

		///<summary>
		///<para> (0028,7017) DDL Value </para>
		///<para> VR: US VM=1 </para>
		///</summary>
        public const uint DdlValue = 2650135;

		///<summary>
		///<para> (0028,7018) CIExy White Point </para>
		///<para> VR: FL VM=2 </para>
		///</summary>
        public const uint CiexyWhitePoint = 2650136;

		///<summary>
		///<para> (0028,7019) Display Function Type </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint DisplayFunctionType = 2650137;

		///<summary>
		///<para> (0028,701A) Gamma Value </para>
		///<para> VR: FL VM=1 </para>
		///</summary>
        public const uint GammaValue = 2650138;

		///<summary>
		///<para> (0028,701B) Number of Luminance Points </para>
		///<para> VR: US VM=1 </para>
		///</summary>
        public const uint NumberOfLuminancePoints = 2650139;

		///<summary>
		///<para> (0028,701C) Luminance Response Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint LuminanceResponseSequence = 2650140;

		///<summary>
		///<para> (0028,701D) Target Minimum Luminance </para>
		///<para> VR: FL VM=1 </para>
		///</summary>
        public const uint TargetMinimumLuminance = 2650141;

		///<summary>
		///<para> (0028,701E) Target Maximum Luminance </para>
		///<para> VR: FL VM=1 </para>
		///</summary>
        public const uint TargetMaximumLuminance = 2650142;

		///<summary>
		///<para> (0028,701F) Luminance Value </para>
		///<para> VR: FL VM=1 </para>
		///</summary>
        public const uint LuminanceValue = 2650143;

		///<summary>
		///<para> (0028,7020) Luminance Response Description </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint LuminanceResponseDescription = 2650144;

		///<summary>
		///<para> (0028,7021) White Point Flag </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint WhitePointFlag = 2650145;

		///<summary>
		///<para> (0028,7022) Display Device Type Code Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint DisplayDeviceTypeCodeSequence = 2650146;

		///<summary>
		///<para> (0028,7023) Display Subsystem Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint DisplaySubsystemSequence = 2650147;

		///<summary>
		///<para> (0028,7024) Luminance Result Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint LuminanceResultSequence = 2650148;

		///<summary>
		///<para> (0028,7025) Ambient Light Value Source </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint AmbientLightValueSource = 2650149;

		///<summary>
		///<para> (0028,7026) Measured Characteristics </para>
		///<para> VR: CS VM=1-n </para>
		///</summary>
        public const uint MeasuredCharacteristics = 2650150;

		///<summary>
		///<para> (0028,7027) Luminance Uniformity Result Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint LuminanceUniformityResultSequence = 2650151;

		///<summary>
		///<para> (0028,7028) Visual Evaluation Test Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint VisualEvaluationTestSequence = 2650152;

		///<summary>
		///<para> (0028,7029) Test Result </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint TestResult = 2650153;

		///<summary>
		///<para> (0028,702A) Test Result Comment </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint TestResultComment = 2650154;

		///<summary>
		///<para> (0028,702B) Test Image Validation </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint TestImageValidation = 2650155;

		///<summary>
		///<para> (0028,702C) Test Pattern Code Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint TestPatternCodeSequence = 2650156;

		///<summary>
		///<para> (0028,702D) Measurement Pattern Code Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint MeasurementPatternCodeSequence = 2650157;

		///<summary>
		///<para> (0028,702E) Visual Evaluation Method Code Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint VisualEvaluationMethodCodeSequence = 2650158;

		///<summary>
		///<para> (0028,7FE0) Pixel Data Provider URL </para>
		///<para> VR: UR VM=1 </para>
		///</summary>
        public const uint PixelDataProviderUrl = 2654176;

		///<summary>
		///<para> (0028,9001) Data Point Rows </para>
		///<para> VR: UL VM=1 </para>
		///</summary>
        public const uint DataPointRows = 2658305;

		///<summary>
		///<para> (0028,9002) Data Point Columns </para>
		///<para> VR: UL VM=1 </para>
		///</summary>
        public const uint DataPointColumns = 2658306;

		///<summary>
		///<para> (0028,9003) Signal Domain Columns </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint SignalDomainColumns = 2658307;

		///<summary>
		///<para> (0028,9099) Largest Monochrome Pixel Value (RETIRED) </para>
		///<para> VR: US VM=1 </para>
		///</summary>
        public const uint LargestMonochromePixelValueRetired = 2658457;

		///<summary>
		///<para> (0028,9108) Data Representation </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint DataRepresentation = 2658568;

		///<summary>
		///<para> (0028,9110) Pixel Measures Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint PixelMeasuresSequence = 2658576;

		///<summary>
		///<para> (0028,9132) Frame VOI LUT Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint FrameVoiLutSequence = 2658610;

		///<summary>
		///<para> (0028,9145) Pixel Value Transformation Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint PixelValueTransformationSequence = 2658629;

		///<summary>
		///<para> (0028,9235) Signal Domain Rows </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint SignalDomainRows = 2658869;

		///<summary>
		///<para> (0028,9411) Display Filter Percentage </para>
		///<para> VR: FL VM=1 </para>
		///</summary>
        public const uint DisplayFilterPercentage = 2659345;

		///<summary>
		///<para> (0028,9415) Frame Pixel Shift Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint FramePixelShiftSequence = 2659349;

		///<summary>
		///<para> (0028,9416) Subtraction Item ID </para>
		///<para> VR: US VM=1 </para>
		///</summary>
        public const uint SubtractionItemId = 2659350;

		///<summary>
		///<para> (0028,9422) Pixel Intensity Relationship LUT Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint PixelIntensityRelationshipLutSequence = 2659362;

		///<summary>
		///<para> (0028,9443) Frame Pixel Data Properties Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint FramePixelDataPropertiesSequence = 2659395;

		///<summary>
		///<para> (0028,9444) Geometrical Properties </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint GeometricalProperties = 2659396;

		///<summary>
		///<para> (0028,9445) Geometric Maximum Distortion </para>
		///<para> VR: FL VM=1 </para>
		///</summary>
        public const uint GeometricMaximumDistortion = 2659397;

		///<summary>
		///<para> (0028,9446) Image Processing Applied </para>
		///<para> VR: CS VM=1-n </para>
		///</summary>
        public const uint ImageProcessingApplied = 2659398;

		///<summary>
		///<para> (0028,9454) Mask Selection Mode </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint MaskSelectionMode = 2659412;

		///<summary>
		///<para> (0028,9474) LUT Function </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint LutFunction = 2659444;

		///<summary>
		///<para> (0028,9478) Mask Visibility Percentage </para>
		///<para> VR: FL VM=1 </para>
		///</summary>
        public const uint MaskVisibilityPercentage = 2659448;

		///<summary>
		///<para> (0028,9501) Pixel Shift Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint PixelShiftSequence = 2659585;

		///<summary>
		///<para> (0028,9502) Region Pixel Shift Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint RegionPixelShiftSequence = 2659586;

		///<summary>
		///<para> (0028,9503) Vertices of the Region </para>
		///<para> VR: SS VM=2-2n </para>
		///</summary>
        public const uint VerticesOfTheRegion = 2659587;

		///<summary>
		///<para> (0028,9505) Multi-frame Presentation Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint MultiFramePresentationSequence = 2659589;

		///<summary>
		///<para> (0028,9506) Pixel Shift Frame Range </para>
		///<para> VR: US VM=2-2n </para>
		///</summary>
        public const uint PixelShiftFrameRange = 2659590;

		///<summary>
		///<para> (0028,9507) LUT Frame Range </para>
		///<para> VR: US VM=2-2n </para>
		///</summary>
        public const uint LutFrameRange = 2659591;

		///<summary>
		///<para> (0028,9520) Image to Equipment Mapping Matrix </para>
		///<para> VR: DS VM=16 </para>
		///</summary>
        public const uint ImageToEquipmentMappingMatrix = 2659616;

		///<summary>
		///<para> (0028,9537) Equipment Coordinate System Identification </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint EquipmentCoordinateSystemIdentification = 2659639;

		///<summary>
		///<para> (0032,000A) Study Status ID (RETIRED) </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint StudyStatusIdRetired = 3276810;

		///<summary>
		///<para> (0032,000C) Study Priority ID (RETIRED) </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint StudyPriorityIdRetired = 3276812;

		///<summary>
		///<para> (0032,0012) Study ID Issuer (RETIRED) </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint StudyIdIssuerRetired = 3276818;

		///<summary>
		///<para> (0032,0032) Study Verified Date (RETIRED) </para>
		///<para> VR: DA VM=1 </para>
		///</summary>
        public const uint StudyVerifiedDateRetired = 3276850;

		///<summary>
		///<para> (0032,0033) Study Verified Time (RETIRED) </para>
		///<para> VR: TM VM=1 </para>
		///</summary>
        public const uint StudyVerifiedTimeRetired = 3276851;

		///<summary>
		///<para> (0032,0034) Study Read Date (RETIRED) </para>
		///<para> VR: DA VM=1 </para>
		///</summary>
        public const uint StudyReadDateRetired = 3276852;

		///<summary>
		///<para> (0032,0035) Study Read Time (RETIRED) </para>
		///<para> VR: TM VM=1 </para>
		///</summary>
        public const uint StudyReadTimeRetired = 3276853;

		///<summary>
		///<para> (0032,1000) Scheduled Study Start Date (RETIRED) </para>
		///<para> VR: DA VM=1 </para>
		///</summary>
        public const uint ScheduledStudyStartDateRetired = 3280896;

		///<summary>
		///<para> (0032,1001) Scheduled Study Start Time (RETIRED) </para>
		///<para> VR: TM VM=1 </para>
		///</summary>
        public const uint ScheduledStudyStartTimeRetired = 3280897;

		///<summary>
		///<para> (0032,1010) Scheduled Study Stop Date (RETIRED) </para>
		///<para> VR: DA VM=1 </para>
		///</summary>
        public const uint ScheduledStudyStopDateRetired = 3280912;

		///<summary>
		///<para> (0032,1011) Scheduled Study Stop Time (RETIRED) </para>
		///<para> VR: TM VM=1 </para>
		///</summary>
        public const uint ScheduledStudyStopTimeRetired = 3280913;

		///<summary>
		///<para> (0032,1020) Scheduled Study Location (RETIRED) </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint ScheduledStudyLocationRetired = 3280928;

		///<summary>
		///<para> (0032,1021) Scheduled Study Location AE Title (RETIRED) </para>
		///<para> VR: AE VM=1-n </para>
		///</summary>
        public const uint ScheduledStudyLocationAeTitleRetired = 3280929;

		///<summary>
		///<para> (0032,1030) Reason for Study (RETIRED) </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint ReasonForStudyRetired = 3280944;

		///<summary>
		///<para> (0032,1031) Requesting Physician Identification Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint RequestingPhysicianIdentificationSequence = 3280945;

		///<summary>
		///<para> (0032,1032) Requesting Physician </para>
		///<para> VR: PN VM=1 </para>
		///</summary>
        public const uint RequestingPhysician = 3280946;

		///<summary>
		///<para> (0032,1033) Requesting Service </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint RequestingService = 3280947;

		///<summary>
		///<para> (0032,1034) Requesting Service Code Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint RequestingServiceCodeSequence = 3280948;

		///<summary>
		///<para> (0032,1040) Study Arrival Date (RETIRED) </para>
		///<para> VR: DA VM=1 </para>
		///</summary>
        public const uint StudyArrivalDateRetired = 3280960;

		///<summary>
		///<para> (0032,1041) Study Arrival Time (RETIRED) </para>
		///<para> VR: TM VM=1 </para>
		///</summary>
        public const uint StudyArrivalTimeRetired = 3280961;

		///<summary>
		///<para> (0032,1050) Study Completion Date (RETIRED) </para>
		///<para> VR: DA VM=1 </para>
		///</summary>
        public const uint StudyCompletionDateRetired = 3280976;

		///<summary>
		///<para> (0032,1051) Study Completion Time (RETIRED) </para>
		///<para> VR: TM VM=1 </para>
		///</summary>
        public const uint StudyCompletionTimeRetired = 3280977;

		///<summary>
		///<para> (0032,1055) Study Component Status ID (RETIRED) </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint StudyComponentStatusIdRetired = 3280981;

		///<summary>
		///<para> (0032,1060) Requested Procedure Description </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint RequestedProcedureDescription = 3280992;

		///<summary>
		///<para> (0032,1064) Requested Procedure Code Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint RequestedProcedureCodeSequence = 3280996;

		///<summary>
		///<para> (0032,1070) Requested Contrast Agent </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint RequestedContrastAgent = 3281008;

		///<summary>
		///<para> (0032,4000) Study Comments (RETIRED) </para>
		///<para> VR: LT VM=1 </para>
		///</summary>
        public const uint StudyCommentsRetired = 3293184;

		///<summary>
		///<para> (0038,0004) Referenced Patient Alias Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint ReferencedPatientAliasSequence = 3670020;

		///<summary>
		///<para> (0038,0008) Visit Status ID </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint VisitStatusId = 3670024;

		///<summary>
		///<para> (0038,0010) Admission ID </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint AdmissionId = 3670032;

		///<summary>
		///<para> (0038,0011) Issuer of Admission ID (RETIRED) </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint IssuerOfAdmissionIdRetired = 3670033;

		///<summary>
		///<para> (0038,0014) Issuer of Admission ID Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint IssuerOfAdmissionIdSequence = 3670036;

		///<summary>
		///<para> (0038,0016) Route of Admissions </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint RouteOfAdmissions = 3670038;

		///<summary>
		///<para> (0038,001A) Scheduled Admission Date (RETIRED) </para>
		///<para> VR: DA VM=1 </para>
		///</summary>
        public const uint ScheduledAdmissionDateRetired = 3670042;

		///<summary>
		///<para> (0038,001B) Scheduled Admission Time (RETIRED) </para>
		///<para> VR: TM VM=1 </para>
		///</summary>
        public const uint ScheduledAdmissionTimeRetired = 3670043;

		///<summary>
		///<para> (0038,001C) Scheduled Discharge Date (RETIRED) </para>
		///<para> VR: DA VM=1 </para>
		///</summary>
        public const uint ScheduledDischargeDateRetired = 3670044;

		///<summary>
		///<para> (0038,001D) Scheduled Discharge Time (RETIRED) </para>
		///<para> VR: TM VM=1 </para>
		///</summary>
        public const uint ScheduledDischargeTimeRetired = 3670045;

		///<summary>
		///<para> (0038,001E) Scheduled Patient Institution Residence (RETIRED) </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint ScheduledPatientInstitutionResidenceRetired = 3670046;

		///<summary>
		///<para> (0038,0020) Admitting Date </para>
		///<para> VR: DA VM=1 </para>
		///</summary>
        public const uint AdmittingDate = 3670048;

		///<summary>
		///<para> (0038,0021) Admitting Time </para>
		///<para> VR: TM VM=1 </para>
		///</summary>
        public const uint AdmittingTime = 3670049;

		///<summary>
		///<para> (0038,0030) Discharge Date (RETIRED) </para>
		///<para> VR: DA VM=1 </para>
		///</summary>
        public const uint DischargeDateRetired = 3670064;

		///<summary>
		///<para> (0038,0032) Discharge Time (RETIRED) </para>
		///<para> VR: TM VM=1 </para>
		///</summary>
        public const uint DischargeTimeRetired = 3670066;

		///<summary>
		///<para> (0038,0040) Discharge Diagnosis Description (RETIRED) </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint DischargeDiagnosisDescriptionRetired = 3670080;

		///<summary>
		///<para> (0038,0044) Discharge Diagnosis Code Sequence (RETIRED) </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint DischargeDiagnosisCodeSequenceRetired = 3670084;

		///<summary>
		///<para> (0038,0050) Special Needs </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint SpecialNeeds = 3670096;

		///<summary>
		///<para> (0038,0060) Service Episode ID </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint ServiceEpisodeId = 3670112;

		///<summary>
		///<para> (0038,0061) Issuer of Service Episode ID (RETIRED) </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint IssuerOfServiceEpisodeIdRetired = 3670113;

		///<summary>
		///<para> (0038,0062) Service Episode Description </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint ServiceEpisodeDescription = 3670114;

		///<summary>
		///<para> (0038,0064) Issuer of Service Episode ID Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint IssuerOfServiceEpisodeIdSequence = 3670116;

		///<summary>
		///<para> (0038,0100) Pertinent Documents Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint PertinentDocumentsSequence = 3670272;

		///<summary>
		///<para> (0038,0101) Pertinent Resources Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint PertinentResourcesSequence = 3670273;

		///<summary>
		///<para> (0038,0102) Resource Description </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint ResourceDescription = 3670274;

		///<summary>
		///<para> (0038,0300) Current Patient Location </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint CurrentPatientLocation = 3670784;

		///<summary>
		///<para> (0038,0400) Patient's Institution Residence </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint PatientsInstitutionResidence = 3671040;

		///<summary>
		///<para> (0038,0500) Patient State </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint PatientState = 3671296;

		///<summary>
		///<para> (0038,0502) Patient Clinical Trial Participation Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint PatientClinicalTrialParticipationSequence = 3671298;

		///<summary>
		///<para> (0038,4000) Visit Comments </para>
		///<para> VR: LT VM=1 </para>
		///</summary>
        public const uint VisitComments = 3686400;

		///<summary>
		///<para> (003A,0004) Waveform Originality </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint WaveformOriginality = 3801092;

		///<summary>
		///<para> (003A,0005) Number of Waveform Channels </para>
		///<para> VR: US VM=1 </para>
		///</summary>
        public const uint NumberOfWaveformChannels = 3801093;

		///<summary>
		///<para> (003A,0010) Number of Waveform Samples </para>
		///<para> VR: UL VM=1 </para>
		///</summary>
        public const uint NumberOfWaveformSamples = 3801104;

		///<summary>
		///<para> (003A,001A) Sampling Frequency </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint SamplingFrequency = 3801114;

		///<summary>
		///<para> (003A,0020) Multiplex Group Label </para>
		///<para> VR: SH VM=1 </para>
		///</summary>
        public const uint MultiplexGroupLabel = 3801120;

		///<summary>
		///<para> (003A,0200) Channel Definition Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint ChannelDefinitionSequence = 3801600;

		///<summary>
		///<para> (003A,0202) Waveform Channel Number </para>
		///<para> VR: IS VM=1 </para>
		///</summary>
        public const uint WaveformChannelNumber = 3801602;

		///<summary>
		///<para> (003A,0203) Channel Label </para>
		///<para> VR: SH VM=1 </para>
		///</summary>
        public const uint ChannelLabel = 3801603;

		///<summary>
		///<para> (003A,0205) Channel Status </para>
		///<para> VR: CS VM=1-n </para>
		///</summary>
        public const uint ChannelStatus = 3801605;

		///<summary>
		///<para> (003A,0208) Channel Source Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint ChannelSourceSequence = 3801608;

		///<summary>
		///<para> (003A,0209) Channel Source Modifiers Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint ChannelSourceModifiersSequence = 3801609;

		///<summary>
		///<para> (003A,020A) Source Waveform Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint SourceWaveformSequence = 3801610;

		///<summary>
		///<para> (003A,020C) Channel Derivation Description </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint ChannelDerivationDescription = 3801612;

		///<summary>
		///<para> (003A,0210) Channel Sensitivity </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint ChannelSensitivity = 3801616;

		///<summary>
		///<para> (003A,0211) Channel Sensitivity Units Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint ChannelSensitivityUnitsSequence = 3801617;

		///<summary>
		///<para> (003A,0212) Channel Sensitivity Correction Factor </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint ChannelSensitivityCorrectionFactor = 3801618;

		///<summary>
		///<para> (003A,0213) Channel Baseline </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint ChannelBaseline = 3801619;

		///<summary>
		///<para> (003A,0214) Channel Time Skew </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint ChannelTimeSkew = 3801620;

		///<summary>
		///<para> (003A,0215) Channel Sample Skew </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint ChannelSampleSkew = 3801621;

		///<summary>
		///<para> (003A,0218) Channel Offset </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint ChannelOffset = 3801624;

		///<summary>
		///<para> (003A,021A) Waveform Bits Stored </para>
		///<para> VR: US VM=1 </para>
		///</summary>
        public const uint WaveformBitsStored = 3801626;

		///<summary>
		///<para> (003A,0220) Filter Low Frequency </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint FilterLowFrequency = 3801632;

		///<summary>
		///<para> (003A,0221) Filter High Frequency </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint FilterHighFrequency = 3801633;

		///<summary>
		///<para> (003A,0222) Notch Filter Frequency </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint NotchFilterFrequency = 3801634;

		///<summary>
		///<para> (003A,0223) Notch Filter Bandwidth </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint NotchFilterBandwidth = 3801635;

		///<summary>
		///<para> (003A,0230) Waveform Data Display Scale </para>
		///<para> VR: FL VM=1 </para>
		///</summary>
        public const uint WaveformDataDisplayScale = 3801648;

		///<summary>
		///<para> (003A,0231) Waveform Display Background CIELab Value </para>
		///<para> VR: US VM=3 </para>
		///</summary>
        public const uint WaveformDisplayBackgroundCielabValue = 3801649;

		///<summary>
		///<para> (003A,0240) Waveform Presentation Group Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint WaveformPresentationGroupSequence = 3801664;

		///<summary>
		///<para> (003A,0241) Presentation Group Number </para>
		///<para> VR: US VM=1 </para>
		///</summary>
        public const uint PresentationGroupNumber = 3801665;

		///<summary>
		///<para> (003A,0242) Channel Display Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint ChannelDisplaySequence = 3801666;

		///<summary>
		///<para> (003A,0244) Channel Recommended Display CIELab Value </para>
		///<para> VR: US VM=3 </para>
		///</summary>
        public const uint ChannelRecommendedDisplayCielabValue = 3801668;

		///<summary>
		///<para> (003A,0245) Channel Position </para>
		///<para> VR: FL VM=1 </para>
		///</summary>
        public const uint ChannelPosition = 3801669;

		///<summary>
		///<para> (003A,0246) Display Shading Flag </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint DisplayShadingFlag = 3801670;

		///<summary>
		///<para> (003A,0247) Fractional Channel Display Scale </para>
		///<para> VR: FL VM=1 </para>
		///</summary>
        public const uint FractionalChannelDisplayScale = 3801671;

		///<summary>
		///<para> (003A,0248) Absolute Channel Display Scale </para>
		///<para> VR: FL VM=1 </para>
		///</summary>
        public const uint AbsoluteChannelDisplayScale = 3801672;

		///<summary>
		///<para> (003A,0300) Multiplexed Audio Channels Description Code Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint MultiplexedAudioChannelsDescriptionCodeSequence = 3801856;

		///<summary>
		///<para> (003A,0301) Channel Identification Code </para>
		///<para> VR: IS VM=1 </para>
		///</summary>
        public const uint ChannelIdentificationCode = 3801857;

		///<summary>
		///<para> (003A,0302) Channel Mode </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint ChannelMode = 3801858;

		///<summary>
		///<para> (0040,0001) Scheduled Station AE Title </para>
		///<para> VR: AE VM=1-n </para>
		///</summary>
        public const uint ScheduledStationAeTitle = 4194305;

		///<summary>
		///<para> (0040,0002) Scheduled Procedure Step Start Date </para>
		///<para> VR: DA VM=1 </para>
		///</summary>
        public const uint ScheduledProcedureStepStartDate = 4194306;

		///<summary>
		///<para> (0040,0003) Scheduled Procedure Step Start Time </para>
		///<para> VR: TM VM=1 </para>
		///</summary>
        public const uint ScheduledProcedureStepStartTime = 4194307;

		///<summary>
		///<para> (0040,0004) Scheduled Procedure Step End Date </para>
		///<para> VR: DA VM=1 </para>
		///</summary>
        public const uint ScheduledProcedureStepEndDate = 4194308;

		///<summary>
		///<para> (0040,0005) Scheduled Procedure Step End Time </para>
		///<para> VR: TM VM=1 </para>
		///</summary>
        public const uint ScheduledProcedureStepEndTime = 4194309;

		///<summary>
		///<para> (0040,0006) Scheduled Performing Physician's Name </para>
		///<para> VR: PN VM=1 </para>
		///</summary>
        public const uint ScheduledPerformingPhysiciansName = 4194310;

		///<summary>
		///<para> (0040,0007) Scheduled Procedure Step Description </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint ScheduledProcedureStepDescription = 4194311;

		///<summary>
		///<para> (0040,0008) Scheduled Protocol Code Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint ScheduledProtocolCodeSequence = 4194312;

		///<summary>
		///<para> (0040,0009) Scheduled Procedure Step ID </para>
		///<para> VR: SH VM=1 </para>
		///</summary>
        public const uint ScheduledProcedureStepId = 4194313;

		///<summary>
		///<para> (0040,000A) Stage Code Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint StageCodeSequence = 4194314;

		///<summary>
		///<para> (0040,000B) Scheduled Performing Physician Identification Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint ScheduledPerformingPhysicianIdentificationSequence = 4194315;

		///<summary>
		///<para> (0040,0010) Scheduled Station Name </para>
		///<para> VR: SH VM=1-n </para>
		///</summary>
        public const uint ScheduledStationName = 4194320;

		///<summary>
		///<para> (0040,0011) Scheduled Procedure Step Location </para>
		///<para> VR: SH VM=1 </para>
		///</summary>
        public const uint ScheduledProcedureStepLocation = 4194321;

		///<summary>
		///<para> (0040,0012) Pre-Medication </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint PreMedication = 4194322;

		///<summary>
		///<para> (0040,0020) Scheduled Procedure Step Status </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint ScheduledProcedureStepStatus = 4194336;

		///<summary>
		///<para> (0040,0026) Order Placer Identifier Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint OrderPlacerIdentifierSequence = 4194342;

		///<summary>
		///<para> (0040,0027) Order Filler Identifier Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint OrderFillerIdentifierSequence = 4194343;

		///<summary>
		///<para> (0040,0031) Local Namespace Entity ID </para>
		///<para> VR: UT VM=1 </para>
		///</summary>
        public const uint LocalNamespaceEntityId = 4194353;

		///<summary>
		///<para> (0040,0032) Universal Entity ID </para>
		///<para> VR: UT VM=1 </para>
		///</summary>
        public const uint UniversalEntityId = 4194354;

		///<summary>
		///<para> (0040,0033) Universal Entity ID Type </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint UniversalEntityIdType = 4194355;

		///<summary>
		///<para> (0040,0035) Identifier Type Code </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint IdentifierTypeCode = 4194357;

		///<summary>
		///<para> (0040,0036) Assigning Facility Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint AssigningFacilitySequence = 4194358;

		///<summary>
		///<para> (0040,0039) Assigning Jurisdiction Code Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint AssigningJurisdictionCodeSequence = 4194361;

		///<summary>
		///<para> (0040,003A) Assigning Agency or Department Code Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint AssigningAgencyOrDepartmentCodeSequence = 4194362;

		///<summary>
		///<para> (0040,0100) Scheduled Procedure Step Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint ScheduledProcedureStepSequence = 4194560;

		///<summary>
		///<para> (0040,0220) Referenced Non-Image Composite SOP Instance Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint ReferencedNonImageCompositeSopInstanceSequence = 4194848;

		///<summary>
		///<para> (0040,0241) Performed Station AE Title </para>
		///<para> VR: AE VM=1 </para>
		///</summary>
        public const uint PerformedStationAeTitle = 4194881;

		///<summary>
		///<para> (0040,0242) Performed Station Name </para>
		///<para> VR: SH VM=1 </para>
		///</summary>
        public const uint PerformedStationName = 4194882;

		///<summary>
		///<para> (0040,0243) Performed Location </para>
		///<para> VR: SH VM=1 </para>
		///</summary>
        public const uint PerformedLocation = 4194883;

		///<summary>
		///<para> (0040,0244) Performed Procedure Step Start Date </para>
		///<para> VR: DA VM=1 </para>
		///</summary>
        public const uint PerformedProcedureStepStartDate = 4194884;

		///<summary>
		///<para> (0040,0245) Performed Procedure Step Start Time </para>
		///<para> VR: TM VM=1 </para>
		///</summary>
        public const uint PerformedProcedureStepStartTime = 4194885;

		///<summary>
		///<para> (0040,0250) Performed Procedure Step End Date </para>
		///<para> VR: DA VM=1 </para>
		///</summary>
        public const uint PerformedProcedureStepEndDate = 4194896;

		///<summary>
		///<para> (0040,0251) Performed Procedure Step End Time </para>
		///<para> VR: TM VM=1 </para>
		///</summary>
        public const uint PerformedProcedureStepEndTime = 4194897;

		///<summary>
		///<para> (0040,0252) Performed Procedure Step Status </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint PerformedProcedureStepStatus = 4194898;

		///<summary>
		///<para> (0040,0253) Performed Procedure Step ID </para>
		///<para> VR: SH VM=1 </para>
		///</summary>
        public const uint PerformedProcedureStepId = 4194899;

		///<summary>
		///<para> (0040,0254) Performed Procedure Step Description </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint PerformedProcedureStepDescription = 4194900;

		///<summary>
		///<para> (0040,0255) Performed Procedure Type Description </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint PerformedProcedureTypeDescription = 4194901;

		///<summary>
		///<para> (0040,0260) Performed Protocol Code Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint PerformedProtocolCodeSequence = 4194912;

		///<summary>
		///<para> (0040,0261) Performed Protocol Type </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint PerformedProtocolType = 4194913;

		///<summary>
		///<para> (0040,0270) Scheduled Step Attributes Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint ScheduledStepAttributesSequence = 4194928;

		///<summary>
		///<para> (0040,0275) Request Attributes Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint RequestAttributesSequence = 4194933;

		///<summary>
		///<para> (0040,0280) Comments on the Performed Procedure Step </para>
		///<para> VR: ST VM=1 </para>
		///</summary>
        public const uint CommentsOnThePerformedProcedureStep = 4194944;

		///<summary>
		///<para> (0040,0281) Performed Procedure Step Discontinuation Reason Code Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint PerformedProcedureStepDiscontinuationReasonCodeSequence = 4194945;

		///<summary>
		///<para> (0040,0293) Quantity Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint QuantitySequence = 4194963;

		///<summary>
		///<para> (0040,0294) Quantity </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint Quantity = 4194964;

		///<summary>
		///<para> (0040,0295) Measuring Units Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint MeasuringUnitsSequence = 4194965;

		///<summary>
		///<para> (0040,0296) Billing Item Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint BillingItemSequence = 4194966;

		///<summary>
		///<para> (0040,0300) Total Time of Fluoroscopy </para>
		///<para> VR: US VM=1 </para>
		///</summary>
        public const uint TotalTimeOfFluoroscopy = 4195072;

		///<summary>
		///<para> (0040,0301) Total Number of Exposures </para>
		///<para> VR: US VM=1 </para>
		///</summary>
        public const uint TotalNumberOfExposures = 4195073;

		///<summary>
		///<para> (0040,0302) Entrance Dose </para>
		///<para> VR: US VM=1 </para>
		///</summary>
        public const uint EntranceDose = 4195074;

		///<summary>
		///<para> (0040,0303) Exposed Area </para>
		///<para> VR: US VM=1-2 </para>
		///</summary>
        public const uint ExposedArea = 4195075;

		///<summary>
		///<para> (0040,0306) Distance Source to Entrance </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint DistanceSourceToEntrance = 4195078;

		///<summary>
		///<para> (0040,0307) Distance Source to Support (RETIRED) </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint DistanceSourceToSupportRetired = 4195079;

		///<summary>
		///<para> (0040,030E) Exposure Dose Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint ExposureDoseSequence = 4195086;

		///<summary>
		///<para> (0040,0310) Comments on Radiation Dose </para>
		///<para> VR: ST VM=1 </para>
		///</summary>
        public const uint CommentsOnRadiationDose = 4195088;

		///<summary>
		///<para> (0040,0312) X-Ray Output </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint XRayOutput = 4195090;

		///<summary>
		///<para> (0040,0314) Half Value Layer </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint HalfValueLayer = 4195092;

		///<summary>
		///<para> (0040,0316) Organ Dose </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint OrganDose = 4195094;

		///<summary>
		///<para> (0040,0318) Organ Exposed </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint OrganExposed = 4195096;

		///<summary>
		///<para> (0040,0320) Billing Procedure Step Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint BillingProcedureStepSequence = 4195104;

		///<summary>
		///<para> (0040,0321) Film Consumption Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint FilmConsumptionSequence = 4195105;

		///<summary>
		///<para> (0040,0324) Billing Supplies and Devices Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint BillingSuppliesAndDevicesSequence = 4195108;

		///<summary>
		///<para> (0040,0330) Referenced Procedure Step Sequence (RETIRED) </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint ReferencedProcedureStepSequenceRetired = 4195120;

		///<summary>
		///<para> (0040,0340) Performed Series Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint PerformedSeriesSequence = 4195136;

		///<summary>
		///<para> (0040,0400) Comments on the Scheduled Procedure Step </para>
		///<para> VR: LT VM=1 </para>
		///</summary>
        public const uint CommentsOnTheScheduledProcedureStep = 4195328;

		///<summary>
		///<para> (0040,0440) Protocol Context Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint ProtocolContextSequence = 4195392;

		///<summary>
		///<para> (0040,0441) Content Item Modifier Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint ContentItemModifierSequence = 4195393;

		///<summary>
		///<para> (0040,0500) Scheduled Specimen Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint ScheduledSpecimenSequence = 4195584;

		///<summary>
		///<para> (0040,050A) Specimen Accession Number (RETIRED) </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint SpecimenAccessionNumberRetired = 4195594;

		///<summary>
		///<para> (0040,0512) Container Identifier </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint ContainerIdentifier = 4195602;

		///<summary>
		///<para> (0040,0513) Issuer of the Container Identifier Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint IssuerOfTheContainerIdentifierSequence = 4195603;

		///<summary>
		///<para> (0040,0515) Alternate Container Identifier Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint AlternateContainerIdentifierSequence = 4195605;

		///<summary>
		///<para> (0040,0518) Container Type Code Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint ContainerTypeCodeSequence = 4195608;

		///<summary>
		///<para> (0040,051A) Container Description </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint ContainerDescription = 4195610;

		///<summary>
		///<para> (0040,0520) Container Component Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint ContainerComponentSequence = 4195616;

		///<summary>
		///<para> (0040,0550) Specimen Sequence (RETIRED) </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint SpecimenSequenceRetired = 4195664;

		///<summary>
		///<para> (0040,0551) Specimen Identifier </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint SpecimenIdentifier = 4195665;

		///<summary>
		///<para> (0040,0552) Specimen Description Sequence (Trial) (RETIRED) </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint SpecimenDescriptionSequenceTrialRetired = 4195666;

		///<summary>
		///<para> (0040,0553) Specimen Description (Trial) (RETIRED) </para>
		///<para> VR: ST VM=1 </para>
		///</summary>
        public const uint SpecimenDescriptionTrialRetired = 4195667;

		///<summary>
		///<para> (0040,0554) Specimen UID </para>
		///<para> VR: UI VM=1 </para>
		///</summary>
        public const uint SpecimenUid = 4195668;

		///<summary>
		///<para> (0040,0555) Acquisition Context Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint AcquisitionContextSequence = 4195669;

		///<summary>
		///<para> (0040,0556) Acquisition Context Description </para>
		///<para> VR: ST VM=1 </para>
		///</summary>
        public const uint AcquisitionContextDescription = 4195670;

		///<summary>
		///<para> (0040,059A) Specimen Type Code Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint SpecimenTypeCodeSequence = 4195738;

		///<summary>
		///<para> (0040,0560) Specimen Description Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint SpecimenDescriptionSequence = 4195680;

		///<summary>
		///<para> (0040,0562) Issuer of the Specimen Identifier Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint IssuerOfTheSpecimenIdentifierSequence = 4195682;

		///<summary>
		///<para> (0040,0600) Specimen Short Description </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint SpecimenShortDescription = 4195840;

		///<summary>
		///<para> (0040,0602) Specimen Detailed Description </para>
		///<para> VR: UT VM=1 </para>
		///</summary>
        public const uint SpecimenDetailedDescription = 4195842;

		///<summary>
		///<para> (0040,0610) Specimen Preparation Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint SpecimenPreparationSequence = 4195856;

		///<summary>
		///<para> (0040,0612) Specimen Preparation Step Content Item Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint SpecimenPreparationStepContentItemSequence = 4195858;

		///<summary>
		///<para> (0040,0620) Specimen Localization Content Item Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint SpecimenLocalizationContentItemSequence = 4195872;

		///<summary>
		///<para> (0040,06FA) Slide Identifier (RETIRED) </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint SlideIdentifierRetired = 4196090;

		///<summary>
		///<para> (0040,071A) Image Center Point Coordinates Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint ImageCenterPointCoordinatesSequence = 4196122;

		///<summary>
		///<para> (0040,072A) X Offset in Slide Coordinate System </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint XOffsetInSlideCoordinateSystem = 4196138;

		///<summary>
		///<para> (0040,073A) Y Offset in Slide Coordinate System </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint YOffsetInSlideCoordinateSystem = 4196154;

		///<summary>
		///<para> (0040,074A) Z Offset in Slide Coordinate System </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint ZOffsetInSlideCoordinateSystem = 4196170;

		///<summary>
		///<para> (0040,08D8) Pixel Spacing Sequence (RETIRED) </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint PixelSpacingSequenceRetired = 4196568;

		///<summary>
		///<para> (0040,08DA) Coordinate System Axis Code Sequence (RETIRED) </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint CoordinateSystemAxisCodeSequenceRetired = 4196570;

		///<summary>
		///<para> (0040,08EA) Measurement Units Code Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint MeasurementUnitsCodeSequence = 4196586;

		///<summary>
		///<para> (0040,09F8) Vital Stain Code Sequence (Trial) (RETIRED) </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint VitalStainCodeSequenceTrialRetired = 4196856;

		///<summary>
		///<para> (0040,1001) Requested Procedure ID </para>
		///<para> VR: SH VM=1 </para>
		///</summary>
        public const uint RequestedProcedureId = 4198401;

		///<summary>
		///<para> (0040,1002) Reason for the Requested Procedure </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint ReasonForTheRequestedProcedure = 4198402;

		///<summary>
		///<para> (0040,1003) Requested Procedure Priority </para>
		///<para> VR: SH VM=1 </para>
		///</summary>
        public const uint RequestedProcedurePriority = 4198403;

		///<summary>
		///<para> (0040,1004) Patient Transport Arrangements </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint PatientTransportArrangements = 4198404;

		///<summary>
		///<para> (0040,1005) Requested Procedure Location </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint RequestedProcedureLocation = 4198405;

		///<summary>
		///<para> (0040,1006) Placer Order Number / Procedure (RETIRED) </para>
		///<para> VR: SH VM=1 </para>
		///</summary>
        public const uint PlacerOrderNumberProcedureRetired = 4198406;

		///<summary>
		///<para> (0040,1007) Filler Order Number / Procedure (RETIRED) </para>
		///<para> VR: SH VM=1 </para>
		///</summary>
        public const uint FillerOrderNumberProcedureRetired = 4198407;

		///<summary>
		///<para> (0040,1008) Confidentiality Code </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint ConfidentialityCode = 4198408;

		///<summary>
		///<para> (0040,1009) Reporting Priority </para>
		///<para> VR: SH VM=1 </para>
		///</summary>
        public const uint ReportingPriority = 4198409;

		///<summary>
		///<para> (0040,100A) Reason for Requested Procedure Code Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint ReasonForRequestedProcedureCodeSequence = 4198410;

		///<summary>
		///<para> (0040,1010) Names of Intended Recipients of Results </para>
		///<para> VR: PN VM=1-n </para>
		///</summary>
        public const uint NamesOfIntendedRecipientsOfResults = 4198416;

		///<summary>
		///<para> (0040,1011) Intended Recipients of Results Identification Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint IntendedRecipientsOfResultsIdentificationSequence = 4198417;

		///<summary>
		///<para> (0040,1012) Reason For Performed Procedure Code Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint ReasonForPerformedProcedureCodeSequence = 4198418;

		///<summary>
		///<para> (0040,1060) Requested Procedure Description (Trial) (RETIRED) </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint RequestedProcedureDescriptionTrialRetired = 4198496;

		///<summary>
		///<para> (0040,1101) Person Identification Code Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint PersonIdentificationCodeSequence = 4198657;

		///<summary>
		///<para> (0040,1102) Person's Address </para>
		///<para> VR: ST VM=1 </para>
		///</summary>
        public const uint PersonsAddress = 4198658;

		///<summary>
		///<para> (0040,1103) Person's Telephone Numbers </para>
		///<para> VR: LO VM=1-n </para>
		///</summary>
        public const uint PersonsTelephoneNumbers = 4198659;

		///<summary>
		///<para> (0040,1104) Person's Telecom Information </para>
		///<para> VR: LT VM=1 </para>
		///</summary>
        public const uint PersonsTelecomInformation = 4198660;

		///<summary>
		///<para> (0040,1400) Requested Procedure Comments </para>
		///<para> VR: LT VM=1 </para>
		///</summary>
        public const uint RequestedProcedureComments = 4199424;

		///<summary>
		///<para> (0040,2001) Reason for the Imaging Service Request (RETIRED) </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint ReasonForTheImagingServiceRequestRetired = 4202497;

		///<summary>
		///<para> (0040,2004) Issue Date of Imaging Service Request </para>
		///<para> VR: DA VM=1 </para>
		///</summary>
        public const uint IssueDateOfImagingServiceRequest = 4202500;

		///<summary>
		///<para> (0040,2005) Issue Time of Imaging Service Request </para>
		///<para> VR: TM VM=1 </para>
		///</summary>
        public const uint IssueTimeOfImagingServiceRequest = 4202501;

		///<summary>
		///<para> (0040,2006) Placer Order Number / Imaging Service Request (Retired) (RETIRED) </para>
		///<para> VR: SH VM=1 </para>
		///</summary>
        public const uint PlacerOrderNumberImagingServiceRequestRetiredRetired = 4202502;

		///<summary>
		///<para> (0040,2007) Filler Order Number / Imaging Service Request (Retired) (RETIRED) </para>
		///<para> VR: SH VM=1 </para>
		///</summary>
        public const uint FillerOrderNumberImagingServiceRequestRetiredRetired = 4202503;

		///<summary>
		///<para> (0040,2008) Order Entered By </para>
		///<para> VR: PN VM=1 </para>
		///</summary>
        public const uint OrderEnteredBy = 4202504;

		///<summary>
		///<para> (0040,2009) Order Enterer's Location </para>
		///<para> VR: SH VM=1 </para>
		///</summary>
        public const uint OrderEnterersLocation = 4202505;

		///<summary>
		///<para> (0040,2010) Order Callback Phone Number </para>
		///<para> VR: SH VM=1 </para>
		///</summary>
        public const uint OrderCallbackPhoneNumber = 4202512;

		///<summary>
		///<para> (0040,2011) Order Callback Telecom Information </para>
		///<para> VR: LT VM=1 </para>
		///</summary>
        public const uint OrderCallbackTelecomInformation = 4202513;

		///<summary>
		///<para> (0040,2016) Placer Order Number / Imaging Service Request </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint PlacerOrderNumberImagingServiceRequest = 4202518;

		///<summary>
		///<para> (0040,2017) Filler Order Number / Imaging Service Request </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint FillerOrderNumberImagingServiceRequest = 4202519;

		///<summary>
		///<para> (0040,2400) Imaging Service Request Comments </para>
		///<para> VR: LT VM=1 </para>
		///</summary>
        public const uint ImagingServiceRequestComments = 4203520;

		///<summary>
		///<para> (0040,3001) Confidentiality Constraint on Patient Data Description </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint ConfidentialityConstraintOnPatientDataDescription = 4206593;

		///<summary>
		///<para> (0040,4001) General Purpose Scheduled Procedure Step Status (RETIRED) </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint GeneralPurposeScheduledProcedureStepStatusRetired = 4210689;

		///<summary>
		///<para> (0040,4002) General Purpose Performed Procedure Step Status (RETIRED) </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint GeneralPurposePerformedProcedureStepStatusRetired = 4210690;

		///<summary>
		///<para> (0040,4003) General Purpose Scheduled Procedure Step Priority (RETIRED) </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint GeneralPurposeScheduledProcedureStepPriorityRetired = 4210691;

		///<summary>
		///<para> (0040,4004) Scheduled Processing Applications Code Sequence (RETIRED) </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint ScheduledProcessingApplicationsCodeSequenceRetired = 4210692;

		///<summary>
		///<para> (0040,4005) Scheduled Procedure Step Start DateTime </para>
		///<para> VR: DT VM=1 </para>
		///</summary>
        public const uint ScheduledProcedureStepStartDatetime = 4210693;

		///<summary>
		///<para> (0040,4006) Multiple Copies Flag (RETIRED) </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint MultipleCopiesFlagRetired = 4210694;

		///<summary>
		///<para> (0040,4007) Performed Processing Applications Code Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint PerformedProcessingApplicationsCodeSequence = 4210695;

		///<summary>
		///<para> (0040,4009) Human Performer Code Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint HumanPerformerCodeSequence = 4210697;

		///<summary>
		///<para> (0040,4010) Scheduled Procedure Step Modification DateTime </para>
		///<para> VR: DT VM=1 </para>
		///</summary>
        public const uint ScheduledProcedureStepModificationDatetime = 4210704;

		///<summary>
		///<para> (0040,4011) Expected Completion DateTime </para>
		///<para> VR: DT VM=1 </para>
		///</summary>
        public const uint ExpectedCompletionDatetime = 4210705;

		///<summary>
		///<para> (0040,4015) Resulting General Purpose Performed Procedure Steps Sequence (RETIRED) </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint ResultingGeneralPurposePerformedProcedureStepsSequenceRetired = 4210709;

		///<summary>
		///<para> (0040,4016) Referenced General Purpose Scheduled Procedure Step Sequence (RETIRED) </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint ReferencedGeneralPurposeScheduledProcedureStepSequenceRetired = 4210710;

		///<summary>
		///<para> (0040,4018) Scheduled Workitem Code Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint ScheduledWorkitemCodeSequence = 4210712;

		///<summary>
		///<para> (0040,4019) Performed Workitem Code Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint PerformedWorkitemCodeSequence = 4210713;

		///<summary>
		///<para> (0040,4020) Input Availability Flag </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint InputAvailabilityFlag = 4210720;

		///<summary>
		///<para> (0040,4021) Input Information Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint InputInformationSequence = 4210721;

		///<summary>
		///<para> (0040,4022) Relevant Information Sequence (RETIRED) </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint RelevantInformationSequenceRetired = 4210722;

		///<summary>
		///<para> (0040,4023) Referenced General Purpose Scheduled Procedure Step Transaction UID (RETIRED) </para>
		///<para> VR: UI VM=1 </para>
		///</summary>
        public const uint ReferencedGeneralPurposeScheduledProcedureStepTransactionUidRetired = 4210723;

		///<summary>
		///<para> (0040,4025) Scheduled Station Name Code Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint ScheduledStationNameCodeSequence = 4210725;

		///<summary>
		///<para> (0040,4026) Scheduled Station Class Code Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint ScheduledStationClassCodeSequence = 4210726;

		///<summary>
		///<para> (0040,4027) Scheduled Station Geographic Location Code Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint ScheduledStationGeographicLocationCodeSequence = 4210727;

		///<summary>
		///<para> (0040,4028) Performed Station Name Code Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint PerformedStationNameCodeSequence = 4210728;

		///<summary>
		///<para> (0040,4029) Performed Station Class Code Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint PerformedStationClassCodeSequence = 4210729;

		///<summary>
		///<para> (0040,4030) Performed Station Geographic Location Code Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint PerformedStationGeographicLocationCodeSequence = 4210736;

		///<summary>
		///<para> (0040,4031) Requested Subsequent Workitem Code Sequence (RETIRED) </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint RequestedSubsequentWorkitemCodeSequenceRetired = 4210737;

		///<summary>
		///<para> (0040,4032) Non-DICOM Output Code Sequence (RETIRED) </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint NonDicomOutputCodeSequenceRetired = 4210738;

		///<summary>
		///<para> (0040,4033) Output Information Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint OutputInformationSequence = 4210739;

		///<summary>
		///<para> (0040,4034) Scheduled Human Performers Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint ScheduledHumanPerformersSequence = 4210740;

		///<summary>
		///<para> (0040,4035) Actual Human Performers Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint ActualHumanPerformersSequence = 4210741;

		///<summary>
		///<para> (0040,4036) Human Performer's Organization </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint HumanPerformersOrganization = 4210742;

		///<summary>
		///<para> (0040,4037) Human Performer's Name </para>
		///<para> VR: PN VM=1 </para>
		///</summary>
        public const uint HumanPerformersName = 4210743;

		///<summary>
		///<para> (0040,4040) Raw Data Handling </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint RawDataHandling = 4210752;

		///<summary>
		///<para> (0040,4041) Input Readiness State </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint InputReadinessState = 4210753;

		///<summary>
		///<para> (0040,4050) Performed Procedure Step Start DateTime </para>
		///<para> VR: DT VM=1 </para>
		///</summary>
        public const uint PerformedProcedureStepStartDatetime = 4210768;

		///<summary>
		///<para> (0040,4051) Performed Procedure Step End DateTime </para>
		///<para> VR: DT VM=1 </para>
		///</summary>
        public const uint PerformedProcedureStepEndDatetime = 4210769;

		///<summary>
		///<para> (0040,4052) Procedure Step Cancellation DateTime </para>
		///<para> VR: DT VM=1 </para>
		///</summary>
        public const uint ProcedureStepCancellationDatetime = 4210770;

		///<summary>
		///<para> (0040,4070) Output Destination Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint OutputDestinationSequence = 4210800;

		///<summary>
		///<para> (0040,4071) DICOM Storage Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint DicomStorageSequence = 4210801;

		///<summary>
		///<para> (0040,4072) STOW-RS Storage Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint StowRsStorageSequence = 4210802;

		///<summary>
		///<para> (0040,4073) Storage URL </para>
		///<para> VR: UR VM=1 </para>
		///</summary>
        public const uint StorageUrl = 4210803;

		///<summary>
		///<para> (0040,4074) XDS Storage Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint XdsStorageSequence = 4210804;

		///<summary>
		///<para> (0040,8302) Entrance Dose in mGy </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint EntranceDoseInMgy = 4227842;

		///<summary>
		///<para> (0040,9092) Parametric Map Frame Type Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint ParametricMapFrameTypeSequence = 4231314;

		///<summary>
		///<para> (0040,9094) Referenced Image Real World Value Mapping Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint ReferencedImageRealWorldValueMappingSequence = 4231316;

		///<summary>
		///<para> (0040,9096) Real World Value Mapping Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint RealWorldValueMappingSequence = 4231318;

		///<summary>
		///<para> (0040,9098) Pixel Value Mapping Code Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint PixelValueMappingCodeSequence = 4231320;

		///<summary>
		///<para> (0040,9210) LUT Label </para>
		///<para> VR: SH VM=1 </para>
		///</summary>
        public const uint LutLabel = 4231696;

		///<summary>
		///<para> (0040,9211) Real World Value Last Value Mapped </para>
		///<para> VR: US/SS VM=1 </para>
		///</summary>
        public const uint RealWorldValueLastValueMapped = 4231697;

		///<summary>
		///<para> (0040,9212) Real World Value LUT Data </para>
		///<para> VR: FD VM=1-n </para>
		///</summary>
        public const uint RealWorldValueLutData = 4231698;

		///<summary>
		///<para> (0040,9213) Double Float Real World Value Last Value Mapped </para>
		///<para> VR: FD VM=1 </para>
		///</summary>
        public const uint DoubleFloatRealWorldValueLastValueMapped = 4231699;

		///<summary>
		///<para> (0040,9214) Double Float Real World Value First Value Mapped </para>
		///<para> VR: FD VM=1 </para>
		///</summary>
        public const uint DoubleFloatRealWorldValueFirstValueMapped = 4231700;

		///<summary>
		///<para> (0040,9216) Real World Value First Value Mapped </para>
		///<para> VR: US/SS VM=1 </para>
		///</summary>
        public const uint RealWorldValueFirstValueMapped = 4231702;

		///<summary>
		///<para> (0040,9220) Quantity Definition Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint QuantityDefinitionSequence = 4231712;

		///<summary>
		///<para> (0040,9224) Real World Value Intercept </para>
		///<para> VR: FD VM=1 </para>
		///</summary>
        public const uint RealWorldValueIntercept = 4231716;

		///<summary>
		///<para> (0040,9225) Real World Value Slope </para>
		///<para> VR: FD VM=1 </para>
		///</summary>
        public const uint RealWorldValueSlope = 4231717;

		///<summary>
		///<para> (0040,A007) Findings Flag (Trial) (RETIRED) </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint FindingsFlagTrialRetired = 4235271;

		///<summary>
		///<para> (0040,A010) Relationship Type </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint RelationshipType = 4235280;

		///<summary>
		///<para> (0040,A020) Findings Sequence (Trial) (RETIRED) </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint FindingsSequenceTrialRetired = 4235296;

		///<summary>
		///<para> (0040,A021) Findings Group UID (Trial) (RETIRED) </para>
		///<para> VR: UI VM=1 </para>
		///</summary>
        public const uint FindingsGroupUidTrialRetired = 4235297;

		///<summary>
		///<para> (0040,A022) Referenced Findings Group UID (Trial) (RETIRED) </para>
		///<para> VR: UI VM=1 </para>
		///</summary>
        public const uint ReferencedFindingsGroupUidTrialRetired = 4235298;

		///<summary>
		///<para> (0040,A023) Findings Group Recording Date (Trial) (RETIRED) </para>
		///<para> VR: DA VM=1 </para>
		///</summary>
        public const uint FindingsGroupRecordingDateTrialRetired = 4235299;

		///<summary>
		///<para> (0040,A024) Findings Group Recording Time (Trial) (RETIRED) </para>
		///<para> VR: TM VM=1 </para>
		///</summary>
        public const uint FindingsGroupRecordingTimeTrialRetired = 4235300;

		///<summary>
		///<para> (0040,A026) Findings Source Category Code Sequence (Trial) (RETIRED) </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint FindingsSourceCategoryCodeSequenceTrialRetired = 4235302;

		///<summary>
		///<para> (0040,A027) Verifying Organization </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint VerifyingOrganization = 4235303;

		///<summary>
		///<para> (0040,A028) Documenting Organization Identifier Code Sequence (Trial) (RETIRED) </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint DocumentingOrganizationIdentifierCodeSequenceTrialRetired = 4235304;

		///<summary>
		///<para> (0040,A030) Verification DateTime </para>
		///<para> VR: DT VM=1 </para>
		///</summary>
        public const uint VerificationDatetime = 4235312;

		///<summary>
		///<para> (0040,A032) Observation DateTime </para>
		///<para> VR: DT VM=1 </para>
		///</summary>
        public const uint ObservationDatetime = 4235314;

		///<summary>
		///<para> (0040,A040) Value Type </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint ValueType = 4235328;

		///<summary>
		///<para> (0040,A043) Concept Name Code Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint ConceptNameCodeSequence = 4235331;

		///<summary>
		///<para> (0040,A047) Measurement Precision Description (Trial) (RETIRED) </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint MeasurementPrecisionDescriptionTrialRetired = 4235335;

		///<summary>
		///<para> (0040,A050) Continuity Of Content </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint ContinuityOfContent = 4235344;

		///<summary>
		///<para> (0040,A057) Urgency or Priority Alerts (Trial) (RETIRED) </para>
		///<para> VR: CS VM=1-n </para>
		///</summary>
        public const uint UrgencyOrPriorityAlertsTrialRetired = 4235351;

		///<summary>
		///<para> (0040,A060) Sequencing Indicator (Trial) (RETIRED) </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint SequencingIndicatorTrialRetired = 4235360;

		///<summary>
		///<para> (0040,A066) Document Identifier Code Sequence (Trial) (RETIRED) </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint DocumentIdentifierCodeSequenceTrialRetired = 4235366;

		///<summary>
		///<para> (0040,A067) Document Author (Trial) (RETIRED) </para>
		///<para> VR: PN VM=1 </para>
		///</summary>
        public const uint DocumentAuthorTrialRetired = 4235367;

		///<summary>
		///<para> (0040,A068) Document Author Identifier Code Sequence (Trial) (RETIRED) </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint DocumentAuthorIdentifierCodeSequenceTrialRetired = 4235368;

		///<summary>
		///<para> (0040,A070) Identifier Code Sequence (Trial) (RETIRED) </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint IdentifierCodeSequenceTrialRetired = 4235376;

		///<summary>
		///<para> (0040,A073) Verifying Observer Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint VerifyingObserverSequence = 4235379;

		///<summary>
		///<para> (0040,A074) Object Binary Identifier (Trial) (RETIRED) </para>
		///<para> VR: OB VM=1 </para>
		///</summary>
        public const uint ObjectBinaryIdentifierTrialRetired = 4235380;

		///<summary>
		///<para> (0040,A075) Verifying Observer Name </para>
		///<para> VR: PN VM=1 </para>
		///</summary>
        public const uint VerifyingObserverName = 4235381;

		///<summary>
		///<para> (0040,A076) Documenting Observer Identifier Code Sequence (Trial) (RETIRED) </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint DocumentingObserverIdentifierCodeSequenceTrialRetired = 4235382;

		///<summary>
		///<para> (0040,A078) Author Observer Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint AuthorObserverSequence = 4235384;

		///<summary>
		///<para> (0040,A07A) Participant Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint ParticipantSequence = 4235386;

		///<summary>
		///<para> (0040,A07C) Custodial Organization Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint CustodialOrganizationSequence = 4235388;

		///<summary>
		///<para> (0040,A080) Participation Type </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint ParticipationType = 4235392;

		///<summary>
		///<para> (0040,A082) Participation DateTime </para>
		///<para> VR: DT VM=1 </para>
		///</summary>
        public const uint ParticipationDatetime = 4235394;

		///<summary>
		///<para> (0040,A084) Observer Type </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint ObserverType = 4235396;

		///<summary>
		///<para> (0040,A085) Procedure Identifier Code Sequence (Trial) (RETIRED) </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint ProcedureIdentifierCodeSequenceTrialRetired = 4235397;

		///<summary>
		///<para> (0040,A088) Verifying Observer Identification Code Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint VerifyingObserverIdentificationCodeSequence = 4235400;

		///<summary>
		///<para> (0040,A089) Object Directory Binary Identifier (Trial) (RETIRED) </para>
		///<para> VR: OB VM=1 </para>
		///</summary>
        public const uint ObjectDirectoryBinaryIdentifierTrialRetired = 4235401;

		///<summary>
		///<para> (0040,A090) Equivalent CDA Document Sequence (RETIRED) </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint EquivalentCdaDocumentSequenceRetired = 4235408;

		///<summary>
		///<para> (0040,A0B0) Referenced Waveform Channels </para>
		///<para> VR: US VM=2-2n </para>
		///</summary>
        public const uint ReferencedWaveformChannels = 4235440;

		///<summary>
		///<para> (0040,A110) Date of Document or Verbal Transaction (Trial) (RETIRED) </para>
		///<para> VR: DA VM=1 </para>
		///</summary>
        public const uint DateOfDocumentOrVerbalTransactionTrialRetired = 4235536;

		///<summary>
		///<para> (0040,A112) Time of Document Creation or Verbal Transaction (Trial) (RETIRED) </para>
		///<para> VR: TM VM=1 </para>
		///</summary>
        public const uint TimeOfDocumentCreationOrVerbalTransactionTrialRetired = 4235538;

		///<summary>
		///<para> (0040,A120) DateTime </para>
		///<para> VR: DT VM=1 </para>
		///</summary>
        public const uint Datetime = 4235552;

		///<summary>
		///<para> (0040,A121) Date </para>
		///<para> VR: DA VM=1 </para>
		///</summary>
        public const uint Date = 4235553;

		///<summary>
		///<para> (0040,A122) Time </para>
		///<para> VR: TM VM=1 </para>
		///</summary>
        public const uint Time = 4235554;

		///<summary>
		///<para> (0040,A123) Person Name </para>
		///<para> VR: PN VM=1 </para>
		///</summary>
        public const uint PersonName = 4235555;

		///<summary>
		///<para> (0040,A124) UID </para>
		///<para> VR: UI VM=1 </para>
		///</summary>
        public const uint Uid = 4235556;

		///<summary>
		///<para> (0040,A125) Report Status ID (Trial) (RETIRED) </para>
		///<para> VR: CS VM=2 </para>
		///</summary>
        public const uint ReportStatusIdTrialRetired = 4235557;

		///<summary>
		///<para> (0040,A130) Temporal Range Type </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint TemporalRangeType = 4235568;

		///<summary>
		///<para> (0040,A132) Referenced Sample Positions </para>
		///<para> VR: UL VM=1-n </para>
		///</summary>
        public const uint ReferencedSamplePositions = 4235570;

		///<summary>
		///<para> (0040,A136) Referenced Frame Numbers </para>
		///<para> VR: US VM=1-n </para>
		///</summary>
        public const uint ReferencedFrameNumbers = 4235574;

		///<summary>
		///<para> (0040,A138) Referenced Time Offsets </para>
		///<para> VR: DS VM=1-n </para>
		///</summary>
        public const uint ReferencedTimeOffsets = 4235576;

		///<summary>
		///<para> (0040,A13A) Referenced DateTime </para>
		///<para> VR: DT VM=1-n </para>
		///</summary>
        public const uint ReferencedDatetime = 4235578;

		///<summary>
		///<para> (0040,A160) Text Value </para>
		///<para> VR: UT VM=1 </para>
		///</summary>
        public const uint TextValue = 4235616;

		///<summary>
		///<para> (0040,A161) Floating Point Value </para>
		///<para> VR: FD VM=1-n </para>
		///</summary>
        public const uint FloatingPointValue = 4235617;

		///<summary>
		///<para> (0040,A162) Rational Numerator Value </para>
		///<para> VR: SL VM=1-n </para>
		///</summary>
        public const uint RationalNumeratorValue = 4235618;

		///<summary>
		///<para> (0040,A163) Rational Denominator Value </para>
		///<para> VR: UL VM=1-n </para>
		///</summary>
        public const uint RationalDenominatorValue = 4235619;

		///<summary>
		///<para> (0040,A167) Observation Category Code Sequence (Trial) (RETIRED) </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint ObservationCategoryCodeSequenceTrialRetired = 4235623;

		///<summary>
		///<para> (0040,A168) Concept Code Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint ConceptCodeSequence = 4235624;

		///<summary>
		///<para> (0040,A16A) Bibliographic Citation (Trial) (RETIRED) </para>
		///<para> VR: ST VM=1 </para>
		///</summary>
        public const uint BibliographicCitationTrialRetired = 4235626;

		///<summary>
		///<para> (0040,A170) Purpose of Reference Code Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint PurposeOfReferenceCodeSequence = 4235632;

		///<summary>
		///<para> (0040,A171) Observation UID </para>
		///<para> VR: UI VM=1 </para>
		///</summary>
        public const uint ObservationUid = 4235633;

		///<summary>
		///<para> (0040,A172) Referenced Observation UID (Trial) (RETIRED) </para>
		///<para> VR: UI VM=1 </para>
		///</summary>
        public const uint ReferencedObservationUidTrialRetired = 4235634;

		///<summary>
		///<para> (0040,A173) Referenced Observation Class (Trial) (RETIRED) </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint ReferencedObservationClassTrialRetired = 4235635;

		///<summary>
		///<para> (0040,A174) Referenced Object Observation Class (Trial) (RETIRED) </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint ReferencedObjectObservationClassTrialRetired = 4235636;

		///<summary>
		///<para> (0040,A180) Annotation Group Number </para>
		///<para> VR: US VM=1 </para>
		///</summary>
        public const uint AnnotationGroupNumber = 4235648;

		///<summary>
		///<para> (0040,A192) Observation Date (Trial) (RETIRED) </para>
		///<para> VR: DA VM=1 </para>
		///</summary>
        public const uint ObservationDateTrialRetired = 4235666;

		///<summary>
		///<para> (0040,A193) Observation Time (Trial) (RETIRED) </para>
		///<para> VR: TM VM=1 </para>
		///</summary>
        public const uint ObservationTimeTrialRetired = 4235667;

		///<summary>
		///<para> (0040,A194) Measurement Automation (Trial) (RETIRED) </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint MeasurementAutomationTrialRetired = 4235668;

		///<summary>
		///<para> (0040,A195) Modifier Code Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint ModifierCodeSequence = 4235669;

		///<summary>
		///<para> (0040,A224) Identification Description (Trial) (RETIRED) </para>
		///<para> VR: ST VM=1 </para>
		///</summary>
        public const uint IdentificationDescriptionTrialRetired = 4235812;

		///<summary>
		///<para> (0040,A290) Coordinates Set Geometric Type (Trial) (RETIRED) </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint CoordinatesSetGeometricTypeTrialRetired = 4235920;

		///<summary>
		///<para> (0040,A296) Algorithm Code Sequence (Trial) (RETIRED) </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint AlgorithmCodeSequenceTrialRetired = 4235926;

		///<summary>
		///<para> (0040,A297) Algorithm Description (Trial) (RETIRED) </para>
		///<para> VR: ST VM=1 </para>
		///</summary>
        public const uint AlgorithmDescriptionTrialRetired = 4235927;

		///<summary>
		///<para> (0040,A29A) Pixel Coordinates Set (Trial) (RETIRED) </para>
		///<para> VR: SL VM=2-2n </para>
		///</summary>
        public const uint PixelCoordinatesSetTrialRetired = 4235930;

		///<summary>
		///<para> (0040,A300) Measured Value Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint MeasuredValueSequence = 4236032;

		///<summary>
		///<para> (0040,A301) Numeric Value Qualifier Code Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint NumericValueQualifierCodeSequence = 4236033;

		///<summary>
		///<para> (0040,A307) Current Observer (Trial) (RETIRED) </para>
		///<para> VR: PN VM=1 </para>
		///</summary>
        public const uint CurrentObserverTrialRetired = 4236039;

		///<summary>
		///<para> (0040,A30A) Numeric Value </para>
		///<para> VR: DS VM=1-n </para>
		///</summary>
        public const uint NumericValue = 4236042;

		///<summary>
		///<para> (0040,A313) Referenced Accession Sequence (Trial) (RETIRED) </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint ReferencedAccessionSequenceTrialRetired = 4236051;

		///<summary>
		///<para> (0040,A33A) Report Status Comment (Trial) (RETIRED) </para>
		///<para> VR: ST VM=1 </para>
		///</summary>
        public const uint ReportStatusCommentTrialRetired = 4236090;

		///<summary>
		///<para> (0040,A340) Procedure Context Sequence (Trial) (RETIRED) </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint ProcedureContextSequenceTrialRetired = 4236096;

		///<summary>
		///<para> (0040,A352) Verbal Source (Trial) (RETIRED) </para>
		///<para> VR: PN VM=1 </para>
		///</summary>
        public const uint VerbalSourceTrialRetired = 4236114;

		///<summary>
		///<para> (0040,A353) Address (Trial) (RETIRED) </para>
		///<para> VR: ST VM=1 </para>
		///</summary>
        public const uint AddressTrialRetired = 4236115;

		///<summary>
		///<para> (0040,A354) Telephone Number (Trial) (RETIRED) </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint TelephoneNumberTrialRetired = 4236116;

		///<summary>
		///<para> (0040,A358) Verbal Source Identifier Code Sequence (Trial) (RETIRED) </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint VerbalSourceIdentifierCodeSequenceTrialRetired = 4236120;

		///<summary>
		///<para> (0040,A360) Predecessor Documents Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint PredecessorDocumentsSequence = 4236128;

		///<summary>
		///<para> (0040,A370) Referenced Request Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint ReferencedRequestSequence = 4236144;

		///<summary>
		///<para> (0040,A372) Performed Procedure Code Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint PerformedProcedureCodeSequence = 4236146;

		///<summary>
		///<para> (0040,A375) Current Requested Procedure Evidence Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint CurrentRequestedProcedureEvidenceSequence = 4236149;

		///<summary>
		///<para> (0040,A380) Report Detail Sequence (Trial) (RETIRED) </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint ReportDetailSequenceTrialRetired = 4236160;

		///<summary>
		///<para> (0040,A385) Pertinent Other Evidence Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint PertinentOtherEvidenceSequence = 4236165;

		///<summary>
		///<para> (0040,A390) HL7 Structured Document Reference Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint Hl7StructuredDocumentReferenceSequence = 4236176;

		///<summary>
		///<para> (0040,A402) Observation Subject UID (Trial) (RETIRED) </para>
		///<para> VR: UI VM=1 </para>
		///</summary>
        public const uint ObservationSubjectUidTrialRetired = 4236290;

		///<summary>
		///<para> (0040,A403) Observation Subject Class (Trial) (RETIRED) </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint ObservationSubjectClassTrialRetired = 4236291;

		///<summary>
		///<para> (0040,A404) Observation Subject Type Code Sequence (Trial) (RETIRED) </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint ObservationSubjectTypeCodeSequenceTrialRetired = 4236292;

		///<summary>
		///<para> (0040,A491) Completion Flag </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint CompletionFlag = 4236433;

		///<summary>
		///<para> (0040,A492) Completion Flag Description </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint CompletionFlagDescription = 4236434;

		///<summary>
		///<para> (0040,A493) Verification Flag </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint VerificationFlag = 4236435;

		///<summary>
		///<para> (0040,A494) Archive Requested </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint ArchiveRequested = 4236436;

		///<summary>
		///<para> (0040,A496) Preliminary Flag </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint PreliminaryFlag = 4236438;

		///<summary>
		///<para> (0040,A504) Content Template Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint ContentTemplateSequence = 4236548;

		///<summary>
		///<para> (0040,A525) Identical Documents Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint IdenticalDocumentsSequence = 4236581;

		///<summary>
		///<para> (0040,A600) Observation Subject Context Flag (Trial) (RETIRED) </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint ObservationSubjectContextFlagTrialRetired = 4236800;

		///<summary>
		///<para> (0040,A601) Observer Context Flag (Trial) (RETIRED) </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint ObserverContextFlagTrialRetired = 4236801;

		///<summary>
		///<para> (0040,A603) Procedure Context Flag (Trial) (RETIRED) </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint ProcedureContextFlagTrialRetired = 4236803;

		///<summary>
		///<para> (0040,A730) Content Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint ContentSequence = 4237104;

		///<summary>
		///<para> (0040,A731) Relationship Sequence (Trial) (RETIRED) </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint RelationshipSequenceTrialRetired = 4237105;

		///<summary>
		///<para> (0040,A732) Relationship Type Code Sequence (Trial) (RETIRED) </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint RelationshipTypeCodeSequenceTrialRetired = 4237106;

		///<summary>
		///<para> (0040,A744) Language Code Sequence (Trial) (RETIRED) </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint LanguageCodeSequenceTrialRetired = 4237124;

		///<summary>
		///<para> (0040,A992) Uniform Resource Locator (Trial) (RETIRED) </para>
		///<para> VR: ST VM=1 </para>
		///</summary>
        public const uint UniformResourceLocatorTrialRetired = 4237714;

		///<summary>
		///<para> (0040,B020) Waveform Annotation Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint WaveformAnnotationSequence = 4239392;

		///<summary>
		///<para> (0040,DB00) Template Identifier </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint TemplateIdentifier = 4250368;

		///<summary>
		///<para> (0040,DB06) Template Version (RETIRED) </para>
		///<para> VR: DT VM=1 </para>
		///</summary>
        public const uint TemplateVersionRetired = 4250374;

		///<summary>
		///<para> (0040,DB07) Template Local Version (RETIRED) </para>
		///<para> VR: DT VM=1 </para>
		///</summary>
        public const uint TemplateLocalVersionRetired = 4250375;

		///<summary>
		///<para> (0040,DB0B) Template Extension Flag (RETIRED) </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint TemplateExtensionFlagRetired = 4250379;

		///<summary>
		///<para> (0040,DB0C) Template Extension Organization UID (RETIRED) </para>
		///<para> VR: UI VM=1 </para>
		///</summary>
        public const uint TemplateExtensionOrganizationUidRetired = 4250380;

		///<summary>
		///<para> (0040,DB0D) Template Extension Creator UID (RETIRED) </para>
		///<para> VR: UI VM=1 </para>
		///</summary>
        public const uint TemplateExtensionCreatorUidRetired = 4250381;

		///<summary>
		///<para> (0040,DB73) Referenced Content Item Identifier </para>
		///<para> VR: UL VM=1-n </para>
		///</summary>
        public const uint ReferencedContentItemIdentifier = 4250483;

		///<summary>
		///<para> (0040,E001) HL7 Instance Identifier </para>
		///<para> VR: ST VM=1 </para>
		///</summary>
        public const uint Hl7InstanceIdentifier = 4251649;

		///<summary>
		///<para> (0040,E004) HL7 Document Effective Time </para>
		///<para> VR: DT VM=1 </para>
		///</summary>
        public const uint Hl7DocumentEffectiveTime = 4251652;

		///<summary>
		///<para> (0040,E006) HL7 Document Type Code Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint Hl7DocumentTypeCodeSequence = 4251654;

		///<summary>
		///<para> (0040,E008) Document Class Code Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint DocumentClassCodeSequence = 4251656;

		///<summary>
		///<para> (0040,E010) Retrieve URI </para>
		///<para> VR: UR VM=1 </para>
		///</summary>
        public const uint RetrieveUri = 4251664;

		///<summary>
		///<para> (0040,E011) Retrieve Location UID </para>
		///<para> VR: UI VM=1 </para>
		///</summary>
        public const uint RetrieveLocationUid = 4251665;

		///<summary>
		///<para> (0040,E020) Type of Instances </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint TypeOfInstances = 4251680;

		///<summary>
		///<para> (0040,E021) DICOM Retrieval Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint DicomRetrievalSequence = 4251681;

		///<summary>
		///<para> (0040,E022) DICOM Media Retrieval Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint DicomMediaRetrievalSequence = 4251682;

		///<summary>
		///<para> (0040,E023) WADO Retrieval Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint WadoRetrievalSequence = 4251683;

		///<summary>
		///<para> (0040,E024) XDS Retrieval Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint XdsRetrievalSequence = 4251684;

		///<summary>
		///<para> (0040,E025) WADO-RS Retrieval Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint WadoRsRetrievalSequence = 4251685;

		///<summary>
		///<para> (0040,E030) Repository Unique ID </para>
		///<para> VR: UI VM=1 </para>
		///</summary>
        public const uint RepositoryUniqueId = 4251696;

		///<summary>
		///<para> (0040,E031) Home Community ID </para>
		///<para> VR: UI VM=1 </para>
		///</summary>
        public const uint HomeCommunityId = 4251697;

		///<summary>
		///<para> (0042,0010) Document Title </para>
		///<para> VR: ST VM=1 </para>
		///</summary>
        public const uint DocumentTitle = 4325392;

		///<summary>
		///<para> (0042,0011) Encapsulated Document </para>
		///<para> VR: OB VM=1 </para>
		///</summary>
        public const uint EncapsulatedDocument = 4325393;

		///<summary>
		///<para> (0042,0012) MIME Type of Encapsulated Document </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint MimeTypeOfEncapsulatedDocument = 4325394;

		///<summary>
		///<para> (0042,0013) Source Instance Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint SourceInstanceSequence = 4325395;

		///<summary>
		///<para> (0042,0014) List of MIME Types </para>
		///<para> VR: LO VM=1-n </para>
		///</summary>
        public const uint ListOfMimeTypes = 4325396;

		///<summary>
		///<para> (0044,0001) Product Package Identifier </para>
		///<para> VR: ST VM=1 </para>
		///</summary>
        public const uint ProductPackageIdentifier = 4456449;

		///<summary>
		///<para> (0044,0002) Substance Administration Approval </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint SubstanceAdministrationApproval = 4456450;

		///<summary>
		///<para> (0044,0003) Approval Status Further Description </para>
		///<para> VR: LT VM=1 </para>
		///</summary>
        public const uint ApprovalStatusFurtherDescription = 4456451;

		///<summary>
		///<para> (0044,0004) Approval Status DateTime </para>
		///<para> VR: DT VM=1 </para>
		///</summary>
        public const uint ApprovalStatusDatetime = 4456452;

		///<summary>
		///<para> (0044,0007) Product Type Code Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint ProductTypeCodeSequence = 4456455;

		///<summary>
		///<para> (0044,0008) Product Name </para>
		///<para> VR: LO VM=1-n </para>
		///</summary>
        public const uint ProductName = 4456456;

		///<summary>
		///<para> (0044,0009) Product Description </para>
		///<para> VR: LT VM=1 </para>
		///</summary>
        public const uint ProductDescription = 4456457;

		///<summary>
		///<para> (0044,000A) Product Lot Identifier </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint ProductLotIdentifier = 4456458;

		///<summary>
		///<para> (0044,000B) Product Expiration DateTime </para>
		///<para> VR: DT VM=1 </para>
		///</summary>
        public const uint ProductExpirationDatetime = 4456459;

		///<summary>
		///<para> (0044,0010) Substance Administration DateTime </para>
		///<para> VR: DT VM=1 </para>
		///</summary>
        public const uint SubstanceAdministrationDatetime = 4456464;

		///<summary>
		///<para> (0044,0011) Substance Administration Notes </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint SubstanceAdministrationNotes = 4456465;

		///<summary>
		///<para> (0044,0012) Substance Administration Device ID </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint SubstanceAdministrationDeviceId = 4456466;

		///<summary>
		///<para> (0044,0013) Product Parameter Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint ProductParameterSequence = 4456467;

		///<summary>
		///<para> (0044,0019) Substance Administration Parameter Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint SubstanceAdministrationParameterSequence = 4456473;

		///<summary>
		///<para> (0046,0012) Lens Description </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint LensDescription = 4587538;

		///<summary>
		///<para> (0046,0014) Right Lens Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint RightLensSequence = 4587540;

		///<summary>
		///<para> (0046,0015) Left Lens Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint LeftLensSequence = 4587541;

		///<summary>
		///<para> (0046,0016) Unspecified Laterality Lens Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint UnspecifiedLateralityLensSequence = 4587542;

		///<summary>
		///<para> (0046,0018) Cylinder Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint CylinderSequence = 4587544;

		///<summary>
		///<para> (0046,0028) Prism Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint PrismSequence = 4587560;

		///<summary>
		///<para> (0046,0030) Horizontal Prism Power </para>
		///<para> VR: FD VM=1 </para>
		///</summary>
        public const uint HorizontalPrismPower = 4587568;

		///<summary>
		///<para> (0046,0032) Horizontal Prism Base </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint HorizontalPrismBase = 4587570;

		///<summary>
		///<para> (0046,0034) Vertical Prism Power </para>
		///<para> VR: FD VM=1 </para>
		///</summary>
        public const uint VerticalPrismPower = 4587572;

		///<summary>
		///<para> (0046,0036) Vertical Prism Base </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint VerticalPrismBase = 4587574;

		///<summary>
		///<para> (0046,0038) Lens Segment Type </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint LensSegmentType = 4587576;

		///<summary>
		///<para> (0046,0040) Optical Transmittance </para>
		///<para> VR: FD VM=1 </para>
		///</summary>
        public const uint OpticalTransmittance = 4587584;

		///<summary>
		///<para> (0046,0042) Channel Width </para>
		///<para> VR: FD VM=1 </para>
		///</summary>
        public const uint ChannelWidth = 4587586;

		///<summary>
		///<para> (0046,0044) Pupil Size </para>
		///<para> VR: FD VM=1 </para>
		///</summary>
        public const uint PupilSize = 4587588;

		///<summary>
		///<para> (0046,0046) Corneal Size </para>
		///<para> VR: FD VM=1 </para>
		///</summary>
        public const uint CornealSize = 4587590;

		///<summary>
		///<para> (0046,0050) Autorefraction Right Eye Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint AutorefractionRightEyeSequence = 4587600;

		///<summary>
		///<para> (0046,0052) Autorefraction Left Eye Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint AutorefractionLeftEyeSequence = 4587602;

		///<summary>
		///<para> (0046,0060) Distance Pupillary Distance </para>
		///<para> VR: FD VM=1 </para>
		///</summary>
        public const uint DistancePupillaryDistance = 4587616;

		///<summary>
		///<para> (0046,0062) Near Pupillary Distance </para>
		///<para> VR: FD VM=1 </para>
		///</summary>
        public const uint NearPupillaryDistance = 4587618;

		///<summary>
		///<para> (0046,0063) Intermediate Pupillary Distance </para>
		///<para> VR: FD VM=1 </para>
		///</summary>
        public const uint IntermediatePupillaryDistance = 4587619;

		///<summary>
		///<para> (0046,0064) Other Pupillary Distance </para>
		///<para> VR: FD VM=1 </para>
		///</summary>
        public const uint OtherPupillaryDistance = 4587620;

		///<summary>
		///<para> (0046,0070) Keratometry Right Eye Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint KeratometryRightEyeSequence = 4587632;

		///<summary>
		///<para> (0046,0071) Keratometry Left Eye Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint KeratometryLeftEyeSequence = 4587633;

		///<summary>
		///<para> (0046,0074) Steep Keratometric Axis Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint SteepKeratometricAxisSequence = 4587636;

		///<summary>
		///<para> (0046,0075) Radius of Curvature </para>
		///<para> VR: FD VM=1 </para>
		///</summary>
        public const uint RadiusOfCurvature = 4587637;

		///<summary>
		///<para> (0046,0076) Keratometric Power </para>
		///<para> VR: FD VM=1 </para>
		///</summary>
        public const uint KeratometricPower = 4587638;

		///<summary>
		///<para> (0046,0077) Keratometric Axis </para>
		///<para> VR: FD VM=1 </para>
		///</summary>
        public const uint KeratometricAxis = 4587639;

		///<summary>
		///<para> (0046,0080) Flat Keratometric Axis Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint FlatKeratometricAxisSequence = 4587648;

		///<summary>
		///<para> (0046,0092) Background Color </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint BackgroundColor = 4587666;

		///<summary>
		///<para> (0046,0094) Optotype </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint Optotype = 4587668;

		///<summary>
		///<para> (0046,0095) Optotype Presentation </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint OptotypePresentation = 4587669;

		///<summary>
		///<para> (0046,0097) Subjective Refraction Right Eye Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint SubjectiveRefractionRightEyeSequence = 4587671;

		///<summary>
		///<para> (0046,0098) Subjective Refraction Left Eye Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint SubjectiveRefractionLeftEyeSequence = 4587672;

		///<summary>
		///<para> (0046,0100) Add Near Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint AddNearSequence = 4587776;

		///<summary>
		///<para> (0046,0101) Add Intermediate Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint AddIntermediateSequence = 4587777;

		///<summary>
		///<para> (0046,0102) Add Other Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint AddOtherSequence = 4587778;

		///<summary>
		///<para> (0046,0104) Add Power </para>
		///<para> VR: FD VM=1 </para>
		///</summary>
        public const uint AddPower = 4587780;

		///<summary>
		///<para> (0046,0106) Viewing Distance </para>
		///<para> VR: FD VM=1 </para>
		///</summary>
        public const uint ViewingDistance = 4587782;

		///<summary>
		///<para> (0046,0121) Visual Acuity Type Code Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint VisualAcuityTypeCodeSequence = 4587809;

		///<summary>
		///<para> (0046,0122) Visual Acuity Right Eye Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint VisualAcuityRightEyeSequence = 4587810;

		///<summary>
		///<para> (0046,0123) Visual Acuity Left Eye Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint VisualAcuityLeftEyeSequence = 4587811;

		///<summary>
		///<para> (0046,0124) Visual Acuity Both Eyes Open Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint VisualAcuityBothEyesOpenSequence = 4587812;

		///<summary>
		///<para> (0046,0125) Viewing Distance Type </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint ViewingDistanceType = 4587813;

		///<summary>
		///<para> (0046,0135) Visual Acuity Modifiers </para>
		///<para> VR: SS VM=2 </para>
		///</summary>
        public const uint VisualAcuityModifiers = 4587829;

		///<summary>
		///<para> (0046,0137) Decimal Visual Acuity </para>
		///<para> VR: FD VM=1 </para>
		///</summary>
        public const uint DecimalVisualAcuity = 4587831;

		///<summary>
		///<para> (0046,0139) Optotype Detailed Definition </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint OptotypeDetailedDefinition = 4587833;

		///<summary>
		///<para> (0046,0145) Referenced Refractive Measurements Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint ReferencedRefractiveMeasurementsSequence = 4587845;

		///<summary>
		///<para> (0046,0146) Sphere Power </para>
		///<para> VR: FD VM=1 </para>
		///</summary>
        public const uint SpherePower = 4587846;

		///<summary>
		///<para> (0046,0147) Cylinder Power </para>
		///<para> VR: FD VM=1 </para>
		///</summary>
        public const uint CylinderPower = 4587847;

		///<summary>
		///<para> (0046,0201) Corneal Topography Surface </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint CornealTopographySurface = 4588033;

		///<summary>
		///<para> (0046,0202) Corneal Vertex Location </para>
		///<para> VR: FL VM=2 </para>
		///</summary>
        public const uint CornealVertexLocation = 4588034;

		///<summary>
		///<para> (0046,0203) Pupil Centroid X-Coordinate </para>
		///<para> VR: FL VM=1 </para>
		///</summary>
        public const uint PupilCentroidXCoordinate = 4588035;

		///<summary>
		///<para> (0046,0204) Pupil Centroid Y-Coordinate </para>
		///<para> VR: FL VM=1 </para>
		///</summary>
        public const uint PupilCentroidYCoordinate = 4588036;

		///<summary>
		///<para> (0046,0205) Equivalent Pupil Radius </para>
		///<para> VR: FL VM=1 </para>
		///</summary>
        public const uint EquivalentPupilRadius = 4588037;

		///<summary>
		///<para> (0046,0207) Corneal Topography Map Type Code Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint CornealTopographyMapTypeCodeSequence = 4588039;

		///<summary>
		///<para> (0046,0208) Vertices of the Outline of Pupil </para>
		///<para> VR: IS VM=2-2n </para>
		///</summary>
        public const uint VerticesOfTheOutlineOfPupil = 4588040;

		///<summary>
		///<para> (0046,0210) Corneal Topography Mapping Normals Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint CornealTopographyMappingNormalsSequence = 4588048;

		///<summary>
		///<para> (0046,0211) Maximum Corneal Curvature Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint MaximumCornealCurvatureSequence = 4588049;

		///<summary>
		///<para> (0046,0212) Maximum Corneal Curvature </para>
		///<para> VR: FL VM=1 </para>
		///</summary>
        public const uint MaximumCornealCurvature = 4588050;

		///<summary>
		///<para> (0046,0213) Maximum Corneal Curvature Location </para>
		///<para> VR: FL VM=2 </para>
		///</summary>
        public const uint MaximumCornealCurvatureLocation = 4588051;

		///<summary>
		///<para> (0046,0215) Minimum Keratometric Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint MinimumKeratometricSequence = 4588053;

		///<summary>
		///<para> (0046,0218) Simulated Keratometric Cylinder Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint SimulatedKeratometricCylinderSequence = 4588056;

		///<summary>
		///<para> (0046,0220) Average Corneal Power </para>
		///<para> VR: FL VM=1 </para>
		///</summary>
        public const uint AverageCornealPower = 4588064;

		///<summary>
		///<para> (0046,0224) Corneal I-S Value </para>
		///<para> VR: FL VM=1 </para>
		///</summary>
        public const uint CornealISValue = 4588068;

		///<summary>
		///<para> (0046,0227) Analyzed Area </para>
		///<para> VR: FL VM=1 </para>
		///</summary>
        public const uint AnalyzedArea = 4588071;

		///<summary>
		///<para> (0046,0230) Surface Regularity Index </para>
		///<para> VR: FL VM=1 </para>
		///</summary>
        public const uint SurfaceRegularityIndex = 4588080;

		///<summary>
		///<para> (0046,0232) Surface Asymmetry Index </para>
		///<para> VR: FL VM=1 </para>
		///</summary>
        public const uint SurfaceAsymmetryIndex = 4588082;

		///<summary>
		///<para> (0046,0234) Corneal Eccentricity Index </para>
		///<para> VR: FL VM=1 </para>
		///</summary>
        public const uint CornealEccentricityIndex = 4588084;

		///<summary>
		///<para> (0046,0236) Keratoconus Prediction Index </para>
		///<para> VR: FL VM=1 </para>
		///</summary>
        public const uint KeratoconusPredictionIndex = 4588086;

		///<summary>
		///<para> (0046,0238) Decimal Potential Visual Acuity </para>
		///<para> VR: FL VM=1 </para>
		///</summary>
        public const uint DecimalPotentialVisualAcuity = 4588088;

		///<summary>
		///<para> (0046,0242) Corneal Topography Map Quality Evaluation </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint CornealTopographyMapQualityEvaluation = 4588098;

		///<summary>
		///<para> (0046,0244) Source Image Corneal Processed Data Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint SourceImageCornealProcessedDataSequence = 4588100;

		///<summary>
		///<para> (0046,0247) Corneal Point Location </para>
		///<para> VR: FL VM=3 </para>
		///</summary>
        public const uint CornealPointLocation = 4588103;

		///<summary>
		///<para> (0046,0248) Corneal Point Estimated </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint CornealPointEstimated = 4588104;

		///<summary>
		///<para> (0046,0249) Axial Power </para>
		///<para> VR: FL VM=1 </para>
		///</summary>
        public const uint AxialPower = 4588105;

		///<summary>
		///<para> (0046,0250) Tangential Power </para>
		///<para> VR: FL VM=1 </para>
		///</summary>
        public const uint TangentialPower = 4588112;

		///<summary>
		///<para> (0046,0251) Refractive Power </para>
		///<para> VR: FL VM=1 </para>
		///</summary>
        public const uint RefractivePower = 4588113;

		///<summary>
		///<para> (0046,0252) Relative Elevation </para>
		///<para> VR: FL VM=1 </para>
		///</summary>
        public const uint RelativeElevation = 4588114;

		///<summary>
		///<para> (0046,0253) Corneal Wavefront </para>
		///<para> VR: FL VM=1 </para>
		///</summary>
        public const uint CornealWavefront = 4588115;

		///<summary>
		///<para> (0048,0001) Imaged Volume Width </para>
		///<para> VR: FL VM=1 </para>
		///</summary>
        public const uint ImagedVolumeWidth = 4718593;

		///<summary>
		///<para> (0048,0002) Imaged Volume Height </para>
		///<para> VR: FL VM=1 </para>
		///</summary>
        public const uint ImagedVolumeHeight = 4718594;

		///<summary>
		///<para> (0048,0003) Imaged Volume Depth </para>
		///<para> VR: FL VM=1 </para>
		///</summary>
        public const uint ImagedVolumeDepth = 4718595;

		///<summary>
		///<para> (0048,0006) Total Pixel Matrix Columns </para>
		///<para> VR: UL VM=1 </para>
		///</summary>
        public const uint TotalPixelMatrixColumns = 4718598;

		///<summary>
		///<para> (0048,0007) Total Pixel Matrix Rows </para>
		///<para> VR: UL VM=1 </para>
		///</summary>
        public const uint TotalPixelMatrixRows = 4718599;

		///<summary>
		///<para> (0048,0008) Total Pixel Matrix Origin Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint TotalPixelMatrixOriginSequence = 4718600;

		///<summary>
		///<para> (0048,0010) Specimen Label in Image </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint SpecimenLabelInImage = 4718608;

		///<summary>
		///<para> (0048,0011) Focus Method </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint FocusMethod = 4718609;

		///<summary>
		///<para> (0048,0012) Extended Depth of Field </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint ExtendedDepthOfField = 4718610;

		///<summary>
		///<para> (0048,0013) Number of Focal Planes </para>
		///<para> VR: US VM=1 </para>
		///</summary>
        public const uint NumberOfFocalPlanes = 4718611;

		///<summary>
		///<para> (0048,0014) Distance Between Focal Planes </para>
		///<para> VR: FL VM=1 </para>
		///</summary>
        public const uint DistanceBetweenFocalPlanes = 4718612;

		///<summary>
		///<para> (0048,0015) Recommended Absent Pixel CIELab Value </para>
		///<para> VR: US VM=3 </para>
		///</summary>
        public const uint RecommendedAbsentPixelCielabValue = 4718613;

		///<summary>
		///<para> (0048,0100) Illuminator Type Code Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint IlluminatorTypeCodeSequence = 4718848;

		///<summary>
		///<para> (0048,0102) Image Orientation (Slide) </para>
		///<para> VR: DS VM=6 </para>
		///</summary>
        public const uint ImageOrientationSlide = 4718850;

		///<summary>
		///<para> (0048,0105) Optical Path Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint OpticalPathSequence = 4718853;

		///<summary>
		///<para> (0048,0106) Optical Path Identifier </para>
		///<para> VR: SH VM=1 </para>
		///</summary>
        public const uint OpticalPathIdentifier = 4718854;

		///<summary>
		///<para> (0048,0107) Optical Path Description </para>
		///<para> VR: ST VM=1 </para>
		///</summary>
        public const uint OpticalPathDescription = 4718855;

		///<summary>
		///<para> (0048,0108) Illumination Color Code Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint IlluminationColorCodeSequence = 4718856;

		///<summary>
		///<para> (0048,0110) Specimen Reference Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint SpecimenReferenceSequence = 4718864;

		///<summary>
		///<para> (0048,0111) Condenser Lens Power </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint CondenserLensPower = 4718865;

		///<summary>
		///<para> (0048,0112) Objective Lens Power </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint ObjectiveLensPower = 4718866;

		///<summary>
		///<para> (0048,0113) Objective Lens Numerical Aperture </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint ObjectiveLensNumericalAperture = 4718867;

		///<summary>
		///<para> (0048,0120) Palette Color Lookup Table Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint PaletteColorLookupTableSequence = 4718880;

		///<summary>
		///<para> (0048,0200) Referenced Image Navigation Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint ReferencedImageNavigationSequence = 4719104;

		///<summary>
		///<para> (0048,0201) Top Left Hand Corner of Localizer Area </para>
		///<para> VR: US VM=2 </para>
		///</summary>
        public const uint TopLeftHandCornerOfLocalizerArea = 4719105;

		///<summary>
		///<para> (0048,0202) Bottom Right Hand Corner of Localizer Area </para>
		///<para> VR: US VM=2 </para>
		///</summary>
        public const uint BottomRightHandCornerOfLocalizerArea = 4719106;

		///<summary>
		///<para> (0048,0207) Optical Path Identification Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint OpticalPathIdentificationSequence = 4719111;

		///<summary>
		///<para> (0048,021A) Plane Position (Slide) Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint PlanePositionSlideSequence = 4719130;

		///<summary>
		///<para> (0048,021E) Column Position In Total Image Pixel Matrix </para>
		///<para> VR: SL VM=1 </para>
		///</summary>
        public const uint ColumnPositionInTotalImagePixelMatrix = 4719134;

		///<summary>
		///<para> (0048,021F) Row Position In Total Image Pixel Matrix </para>
		///<para> VR: SL VM=1 </para>
		///</summary>
        public const uint RowPositionInTotalImagePixelMatrix = 4719135;

		///<summary>
		///<para> (0048,0301) Pixel Origin Interpretation </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint PixelOriginInterpretation = 4719361;

		///<summary>
		///<para> (0050,0004) Calibration Image </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint CalibrationImage = 5242884;

		///<summary>
		///<para> (0050,0010) Device Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint DeviceSequence = 5242896;

		///<summary>
		///<para> (0050,0012) Container Component Type Code Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint ContainerComponentTypeCodeSequence = 5242898;

		///<summary>
		///<para> (0050,0013) Container Component Thickness </para>
		///<para> VR: FD VM=1 </para>
		///</summary>
        public const uint ContainerComponentThickness = 5242899;

		///<summary>
		///<para> (0050,0014) Device Length </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint DeviceLength = 5242900;

		///<summary>
		///<para> (0050,0015) Container Component Width </para>
		///<para> VR: FD VM=1 </para>
		///</summary>
        public const uint ContainerComponentWidth = 5242901;

		///<summary>
		///<para> (0050,0016) Device Diameter </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint DeviceDiameter = 5242902;

		///<summary>
		///<para> (0050,0017) Device Diameter Units </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint DeviceDiameterUnits = 5242903;

		///<summary>
		///<para> (0050,0018) Device Volume </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint DeviceVolume = 5242904;

		///<summary>
		///<para> (0050,0019) Inter-Marker Distance </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint InterMarkerDistance = 5242905;

		///<summary>
		///<para> (0050,001A) Container Component Material </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint ContainerComponentMaterial = 5242906;

		///<summary>
		///<para> (0050,001B) Container Component ID </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint ContainerComponentId = 5242907;

		///<summary>
		///<para> (0050,001C) Container Component Length </para>
		///<para> VR: FD VM=1 </para>
		///</summary>
        public const uint ContainerComponentLength = 5242908;

		///<summary>
		///<para> (0050,001D) Container Component Diameter </para>
		///<para> VR: FD VM=1 </para>
		///</summary>
        public const uint ContainerComponentDiameter = 5242909;

		///<summary>
		///<para> (0050,001E) Container Component Description </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint ContainerComponentDescription = 5242910;

		///<summary>
		///<para> (0050,0020) Device Description </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint DeviceDescription = 5242912;

		///<summary>
		///<para> (0052,0001) Contrast/Bolus Ingredient Percent by Volume </para>
		///<para> VR: FL VM=1 </para>
		///</summary>
        public const uint ContrastBolusIngredientPercentByVolume = 5373953;

		///<summary>
		///<para> (0052,0002) OCT Focal Distance </para>
		///<para> VR: FD VM=1 </para>
		///</summary>
        public const uint OctFocalDistance = 5373954;

		///<summary>
		///<para> (0052,0003) Beam Spot Size </para>
		///<para> VR: FD VM=1 </para>
		///</summary>
        public const uint BeamSpotSize = 5373955;

		///<summary>
		///<para> (0052,0004) Effective Refractive Index </para>
		///<para> VR: FD VM=1 </para>
		///</summary>
        public const uint EffectiveRefractiveIndex = 5373956;

		///<summary>
		///<para> (0052,0006) OCT Acquisition Domain </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint OctAcquisitionDomain = 5373958;

		///<summary>
		///<para> (0052,0007) OCT Optical Center Wavelength </para>
		///<para> VR: FD VM=1 </para>
		///</summary>
        public const uint OctOpticalCenterWavelength = 5373959;

		///<summary>
		///<para> (0052,0008) Axial Resolution </para>
		///<para> VR: FD VM=1 </para>
		///</summary>
        public const uint AxialResolution = 5373960;

		///<summary>
		///<para> (0052,0009) Ranging Depth </para>
		///<para> VR: FD VM=1 </para>
		///</summary>
        public const uint RangingDepth = 5373961;

		///<summary>
		///<para> (0052,0011) A-line Rate </para>
		///<para> VR: FD VM=1 </para>
		///</summary>
        public const uint ALineRate = 5373969;

		///<summary>
		///<para> (0052,0012) A-lines Per Frame </para>
		///<para> VR: US VM=1 </para>
		///</summary>
        public const uint ALinesPerFrame = 5373970;

		///<summary>
		///<para> (0052,0013) Catheter Rotational Rate </para>
		///<para> VR: FD VM=1 </para>
		///</summary>
        public const uint CatheterRotationalRate = 5373971;

		///<summary>
		///<para> (0052,0014) A-line Pixel Spacing </para>
		///<para> VR: FD VM=1 </para>
		///</summary>
        public const uint ALinePixelSpacing = 5373972;

		///<summary>
		///<para> (0052,0016) Mode of Percutaneous Access Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint ModeOfPercutaneousAccessSequence = 5373974;

		///<summary>
		///<para> (0052,0025) Intravascular OCT Frame Type Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint IntravascularOctFrameTypeSequence = 5373989;

		///<summary>
		///<para> (0052,0026) OCT Z Offset Applied </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint OctZOffsetApplied = 5373990;

		///<summary>
		///<para> (0052,0027) Intravascular Frame Content Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint IntravascularFrameContentSequence = 5373991;

		///<summary>
		///<para> (0052,0028) Intravascular Longitudinal Distance </para>
		///<para> VR: FD VM=1 </para>
		///</summary>
        public const uint IntravascularLongitudinalDistance = 5373992;

		///<summary>
		///<para> (0052,0029) Intravascular OCT Frame Content Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint IntravascularOctFrameContentSequence = 5373993;

		///<summary>
		///<para> (0052,0030) OCT Z Offset Correction </para>
		///<para> VR: SS VM=1 </para>
		///</summary>
        public const uint OctZOffsetCorrection = 5374000;

		///<summary>
		///<para> (0052,0031) Catheter Direction of Rotation </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint CatheterDirectionOfRotation = 5374001;

		///<summary>
		///<para> (0052,0033) Seam Line Location </para>
		///<para> VR: FD VM=1 </para>
		///</summary>
        public const uint SeamLineLocation = 5374003;

		///<summary>
		///<para> (0052,0034) First A-line Location </para>
		///<para> VR: FD VM=1 </para>
		///</summary>
        public const uint FirstALineLocation = 5374004;

		///<summary>
		///<para> (0052,0036) Seam Line Index </para>
		///<para> VR: US VM=1 </para>
		///</summary>
        public const uint SeamLineIndex = 5374006;

		///<summary>
		///<para> (0052,0038) Number of Padded A-lines </para>
		///<para> VR: US VM=1 </para>
		///</summary>
        public const uint NumberOfPaddedALines = 5374008;

		///<summary>
		///<para> (0052,0039) Interpolation Type </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint InterpolationType = 5374009;

		///<summary>
		///<para> (0052,003A) Refractive Index Applied </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint RefractiveIndexApplied = 5374010;

		///<summary>
		///<para> (0054,0010) Energy Window Vector </para>
		///<para> VR: US VM=1-n </para>
		///</summary>
        public const uint EnergyWindowVector = 5505040;

		///<summary>
		///<para> (0054,0011) Number of Energy Windows </para>
		///<para> VR: US VM=1 </para>
		///</summary>
        public const uint NumberOfEnergyWindows = 5505041;

		///<summary>
		///<para> (0054,0012) Energy Window Information Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint EnergyWindowInformationSequence = 5505042;

		///<summary>
		///<para> (0054,0013) Energy Window Range Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint EnergyWindowRangeSequence = 5505043;

		///<summary>
		///<para> (0054,0014) Energy Window Lower Limit </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint EnergyWindowLowerLimit = 5505044;

		///<summary>
		///<para> (0054,0015) Energy Window Upper Limit </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint EnergyWindowUpperLimit = 5505045;

		///<summary>
		///<para> (0054,0016) Radiopharmaceutical Information Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint RadiopharmaceuticalInformationSequence = 5505046;

		///<summary>
		///<para> (0054,0017) Residual Syringe Counts </para>
		///<para> VR: IS VM=1 </para>
		///</summary>
        public const uint ResidualSyringeCounts = 5505047;

		///<summary>
		///<para> (0054,0018) Energy Window Name </para>
		///<para> VR: SH VM=1 </para>
		///</summary>
        public const uint EnergyWindowName = 5505048;

		///<summary>
		///<para> (0054,0020) Detector Vector </para>
		///<para> VR: US VM=1-n </para>
		///</summary>
        public const uint DetectorVector = 5505056;

		///<summary>
		///<para> (0054,0021) Number of Detectors </para>
		///<para> VR: US VM=1 </para>
		///</summary>
        public const uint NumberOfDetectors = 5505057;

		///<summary>
		///<para> (0054,0022) Detector Information Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint DetectorInformationSequence = 5505058;

		///<summary>
		///<para> (0054,0030) Phase Vector </para>
		///<para> VR: US VM=1-n </para>
		///</summary>
        public const uint PhaseVector = 5505072;

		///<summary>
		///<para> (0054,0031) Number of Phases </para>
		///<para> VR: US VM=1 </para>
		///</summary>
        public const uint NumberOfPhases = 5505073;

		///<summary>
		///<para> (0054,0032) Phase Information Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint PhaseInformationSequence = 5505074;

		///<summary>
		///<para> (0054,0033) Number of Frames in Phase </para>
		///<para> VR: US VM=1 </para>
		///</summary>
        public const uint NumberOfFramesInPhase = 5505075;

		///<summary>
		///<para> (0054,0036) Phase Delay </para>
		///<para> VR: IS VM=1 </para>
		///</summary>
        public const uint PhaseDelay = 5505078;

		///<summary>
		///<para> (0054,0038) Pause Between Frames </para>
		///<para> VR: IS VM=1 </para>
		///</summary>
        public const uint PauseBetweenFrames = 5505080;

		///<summary>
		///<para> (0054,0039) Phase Description </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint PhaseDescription = 5505081;

		///<summary>
		///<para> (0054,0050) Rotation Vector </para>
		///<para> VR: US VM=1-n </para>
		///</summary>
        public const uint RotationVector = 5505104;

		///<summary>
		///<para> (0054,0051) Number of Rotations </para>
		///<para> VR: US VM=1 </para>
		///</summary>
        public const uint NumberOfRotations = 5505105;

		///<summary>
		///<para> (0054,0052) Rotation Information Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint RotationInformationSequence = 5505106;

		///<summary>
		///<para> (0054,0053) Number of Frames in Rotation </para>
		///<para> VR: US VM=1 </para>
		///</summary>
        public const uint NumberOfFramesInRotation = 5505107;

		///<summary>
		///<para> (0054,0060) R-R Interval Vector </para>
		///<para> VR: US VM=1-n </para>
		///</summary>
        public const uint RRIntervalVector = 5505120;

		///<summary>
		///<para> (0054,0061) Number of R-R Intervals </para>
		///<para> VR: US VM=1 </para>
		///</summary>
        public const uint NumberOfRRIntervals = 5505121;

		///<summary>
		///<para> (0054,0062) Gated Information Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint GatedInformationSequence = 5505122;

		///<summary>
		///<para> (0054,0063) Data Information Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint DataInformationSequence = 5505123;

		///<summary>
		///<para> (0054,0070) Time Slot Vector </para>
		///<para> VR: US VM=1-n </para>
		///</summary>
        public const uint TimeSlotVector = 5505136;

		///<summary>
		///<para> (0054,0071) Number of Time Slots </para>
		///<para> VR: US VM=1 </para>
		///</summary>
        public const uint NumberOfTimeSlots = 5505137;

		///<summary>
		///<para> (0054,0072) Time Slot Information Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint TimeSlotInformationSequence = 5505138;

		///<summary>
		///<para> (0054,0073) Time Slot Time </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint TimeSlotTime = 5505139;

		///<summary>
		///<para> (0054,0080) Slice Vector </para>
		///<para> VR: US VM=1-n </para>
		///</summary>
        public const uint SliceVector = 5505152;

		///<summary>
		///<para> (0054,0081) Number of Slices </para>
		///<para> VR: US VM=1 </para>
		///</summary>
        public const uint NumberOfSlices = 5505153;

		///<summary>
		///<para> (0054,0090) Angular View Vector </para>
		///<para> VR: US VM=1-n </para>
		///</summary>
        public const uint AngularViewVector = 5505168;

		///<summary>
		///<para> (0054,0100) Time Slice Vector </para>
		///<para> VR: US VM=1-n </para>
		///</summary>
        public const uint TimeSliceVector = 5505280;

		///<summary>
		///<para> (0054,0101) Number of Time Slices </para>
		///<para> VR: US VM=1 </para>
		///</summary>
        public const uint NumberOfTimeSlices = 5505281;

		///<summary>
		///<para> (0054,0200) Start Angle </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint StartAngle = 5505536;

		///<summary>
		///<para> (0054,0202) Type of Detector Motion </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint TypeOfDetectorMotion = 5505538;

		///<summary>
		///<para> (0054,0210) Trigger Vector </para>
		///<para> VR: IS VM=1-n </para>
		///</summary>
        public const uint TriggerVector = 5505552;

		///<summary>
		///<para> (0054,0211) Number of Triggers in Phase </para>
		///<para> VR: US VM=1 </para>
		///</summary>
        public const uint NumberOfTriggersInPhase = 5505553;

		///<summary>
		///<para> (0054,0220) View Code Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint ViewCodeSequence = 5505568;

		///<summary>
		///<para> (0054,0222) View Modifier Code Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint ViewModifierCodeSequence = 5505570;

		///<summary>
		///<para> (0054,0300) Radionuclide Code Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint RadionuclideCodeSequence = 5505792;

		///<summary>
		///<para> (0054,0302) Administration Route Code Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint AdministrationRouteCodeSequence = 5505794;

		///<summary>
		///<para> (0054,0304) Radiopharmaceutical Code Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint RadiopharmaceuticalCodeSequence = 5505796;

		///<summary>
		///<para> (0054,0306) Calibration Data Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint CalibrationDataSequence = 5505798;

		///<summary>
		///<para> (0054,0308) Energy Window Number </para>
		///<para> VR: US VM=1 </para>
		///</summary>
        public const uint EnergyWindowNumber = 5505800;

		///<summary>
		///<para> (0054,0400) Image ID </para>
		///<para> VR: SH VM=1 </para>
		///</summary>
        public const uint ImageId = 5506048;

		///<summary>
		///<para> (0054,0410) Patient Orientation Code Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint PatientOrientationCodeSequence = 5506064;

		///<summary>
		///<para> (0054,0412) Patient Orientation Modifier Code Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint PatientOrientationModifierCodeSequence = 5506066;

		///<summary>
		///<para> (0054,0414) Patient Gantry Relationship Code Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint PatientGantryRelationshipCodeSequence = 5506068;

		///<summary>
		///<para> (0054,0500) Slice Progression Direction </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint SliceProgressionDirection = 5506304;

		///<summary>
		///<para> (0054,0501) Scan Progression Direction </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint ScanProgressionDirection = 5506305;

		///<summary>
		///<para> (0054,1000) Series Type </para>
		///<para> VR: CS VM=2 </para>
		///</summary>
        public const uint SeriesType = 5509120;

		///<summary>
		///<para> (0054,1001) Units </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint Units = 5509121;

		///<summary>
		///<para> (0054,1002) Counts Source </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint CountsSource = 5509122;

		///<summary>
		///<para> (0054,1004) Reprojection Method </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint ReprojectionMethod = 5509124;

		///<summary>
		///<para> (0054,1006) SUV Type </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint SuvType = 5509126;

		///<summary>
		///<para> (0054,1100) Randoms Correction Method </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint RandomsCorrectionMethod = 5509376;

		///<summary>
		///<para> (0054,1101) Attenuation Correction Method </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint AttenuationCorrectionMethod = 5509377;

		///<summary>
		///<para> (0054,1102) Decay Correction </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint DecayCorrection = 5509378;

		///<summary>
		///<para> (0054,1103) Reconstruction Method </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint ReconstructionMethod = 5509379;

		///<summary>
		///<para> (0054,1104) Detector Lines of Response Used </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint DetectorLinesOfResponseUsed = 5509380;

		///<summary>
		///<para> (0054,1105) Scatter Correction Method </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint ScatterCorrectionMethod = 5509381;

		///<summary>
		///<para> (0054,1200) Axial Acceptance </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint AxialAcceptance = 5509632;

		///<summary>
		///<para> (0054,1201) Axial Mash </para>
		///<para> VR: IS VM=2 </para>
		///</summary>
        public const uint AxialMash = 5509633;

		///<summary>
		///<para> (0054,1202) Transverse Mash </para>
		///<para> VR: IS VM=1 </para>
		///</summary>
        public const uint TransverseMash = 5509634;

		///<summary>
		///<para> (0054,1203) Detector Element Size </para>
		///<para> VR: DS VM=2 </para>
		///</summary>
        public const uint DetectorElementSize = 5509635;

		///<summary>
		///<para> (0054,1210) Coincidence Window Width </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint CoincidenceWindowWidth = 5509648;

		///<summary>
		///<para> (0054,1220) Secondary Counts Type </para>
		///<para> VR: CS VM=1-n </para>
		///</summary>
        public const uint SecondaryCountsType = 5509664;

		///<summary>
		///<para> (0054,1300) Frame Reference Time </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint FrameReferenceTime = 5509888;

		///<summary>
		///<para> (0054,1310) Primary (Prompts) Counts Accumulated </para>
		///<para> VR: IS VM=1 </para>
		///</summary>
        public const uint PrimaryPromptsCountsAccumulated = 5509904;

		///<summary>
		///<para> (0054,1311) Secondary Counts Accumulated </para>
		///<para> VR: IS VM=1-n </para>
		///</summary>
        public const uint SecondaryCountsAccumulated = 5509905;

		///<summary>
		///<para> (0054,1320) Slice Sensitivity Factor </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint SliceSensitivityFactor = 5509920;

		///<summary>
		///<para> (0054,1321) Decay Factor </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint DecayFactor = 5509921;

		///<summary>
		///<para> (0054,1322) Dose Calibration Factor </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint DoseCalibrationFactor = 5509922;

		///<summary>
		///<para> (0054,1323) Scatter Fraction Factor </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint ScatterFractionFactor = 5509923;

		///<summary>
		///<para> (0054,1324) Dead Time Factor </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint DeadTimeFactor = 5509924;

		///<summary>
		///<para> (0054,1330) Image Index </para>
		///<para> VR: US VM=1 </para>
		///</summary>
        public const uint ImageIndex = 5509936;

		///<summary>
		///<para> (0054,1400) Counts Included (RETIRED) </para>
		///<para> VR: CS VM=1-n </para>
		///</summary>
        public const uint CountsIncludedRetired = 5510144;

		///<summary>
		///<para> (0054,1401) Dead Time Correction Flag (RETIRED) </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint DeadTimeCorrectionFlagRetired = 5510145;

		///<summary>
		///<para> (0060,3000) Histogram Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint HistogramSequence = 6303744;

		///<summary>
		///<para> (0060,3002) Histogram Number of Bins </para>
		///<para> VR: US VM=1 </para>
		///</summary>
        public const uint HistogramNumberOfBins = 6303746;

		///<summary>
		///<para> (0060,3004) Histogram First Bin Value </para>
		///<para> VR: US/SS VM=1 </para>
		///</summary>
        public const uint HistogramFirstBinValue = 6303748;

		///<summary>
		///<para> (0060,3006) Histogram Last Bin Value </para>
		///<para> VR: US/SS VM=1 </para>
		///</summary>
        public const uint HistogramLastBinValue = 6303750;

		///<summary>
		///<para> (0060,3008) Histogram Bin Width </para>
		///<para> VR: US VM=1 </para>
		///</summary>
        public const uint HistogramBinWidth = 6303752;

		///<summary>
		///<para> (0060,3010) Histogram Explanation </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint HistogramExplanation = 6303760;

		///<summary>
		///<para> (0060,3020) Histogram Data </para>
		///<para> VR: UL VM=1-n </para>
		///</summary>
        public const uint HistogramData = 6303776;

		///<summary>
		///<para> (0062,0001) Segmentation Type </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint SegmentationType = 6422529;

		///<summary>
		///<para> (0062,0002) Segment Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint SegmentSequence = 6422530;

		///<summary>
		///<para> (0062,0003) Segmented Property Category Code Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint SegmentedPropertyCategoryCodeSequence = 6422531;

		///<summary>
		///<para> (0062,0004) Segment Number </para>
		///<para> VR: US VM=1 </para>
		///</summary>
        public const uint SegmentNumber = 6422532;

		///<summary>
		///<para> (0062,0005) Segment Label </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint SegmentLabel = 6422533;

		///<summary>
		///<para> (0062,0006) Segment Description </para>
		///<para> VR: ST VM=1 </para>
		///</summary>
        public const uint SegmentDescription = 6422534;

		///<summary>
		///<para> (0062,0007) Segmentation Algorithm Identification Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint SegmentationAlgorithmIdentificationSequence = 6422535;

		///<summary>
		///<para> (0062,0008) Segment Algorithm Type </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint SegmentAlgorithmType = 6422536;

		///<summary>
		///<para> (0062,0009) Segment Algorithm Name </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint SegmentAlgorithmName = 6422537;

		///<summary>
		///<para> (0062,000A) Segment Identification Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint SegmentIdentificationSequence = 6422538;

		///<summary>
		///<para> (0062,000B) Referenced Segment Number </para>
		///<para> VR: US VM=1-n </para>
		///</summary>
        public const uint ReferencedSegmentNumber = 6422539;

		///<summary>
		///<para> (0062,000C) Recommended Display Grayscale Value </para>
		///<para> VR: US VM=1 </para>
		///</summary>
        public const uint RecommendedDisplayGrayscaleValue = 6422540;

		///<summary>
		///<para> (0062,000D) Recommended Display CIELab Value </para>
		///<para> VR: US VM=3 </para>
		///</summary>
        public const uint RecommendedDisplayCielabValue = 6422541;

		///<summary>
		///<para> (0062,000E) Maximum Fractional Value </para>
		///<para> VR: US VM=1 </para>
		///</summary>
        public const uint MaximumFractionalValue = 6422542;

		///<summary>
		///<para> (0062,000F) Segmented Property Type Code Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint SegmentedPropertyTypeCodeSequence = 6422543;

		///<summary>
		///<para> (0062,0010) Segmentation Fractional Type </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint SegmentationFractionalType = 6422544;

		///<summary>
		///<para> (0062,0011) Segmented Property Type Modifier Code Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint SegmentedPropertyTypeModifierCodeSequence = 6422545;

		///<summary>
		///<para> (0062,0012) Used Segments Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint UsedSegmentsSequence = 6422546;

		///<summary>
		///<para> (0062,0020) Tracking ID </para>
		///<para> VR: UT VM=1 </para>
		///</summary>
        public const uint TrackingId = 6422560;

		///<summary>
		///<para> (0062,0021) Tracking UID </para>
		///<para> VR: UI VM=1 </para>
		///</summary>
        public const uint TrackingUid = 6422561;

		///<summary>
		///<para> (0064,0002) Deformable Registration Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint DeformableRegistrationSequence = 6553602;

		///<summary>
		///<para> (0064,0003) Source Frame of Reference UID </para>
		///<para> VR: UI VM=1 </para>
		///</summary>
        public const uint SourceFrameOfReferenceUid = 6553603;

		///<summary>
		///<para> (0064,0005) Deformable Registration Grid Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint DeformableRegistrationGridSequence = 6553605;

		///<summary>
		///<para> (0064,0007) Grid Dimensions </para>
		///<para> VR: UL VM=3 </para>
		///</summary>
        public const uint GridDimensions = 6553607;

		///<summary>
		///<para> (0064,0008) Grid Resolution </para>
		///<para> VR: FD VM=3 </para>
		///</summary>
        public const uint GridResolution = 6553608;

		///<summary>
		///<para> (0064,0009) Vector Grid Data </para>
		///<para> VR: OF VM=1 </para>
		///</summary>
        public const uint VectorGridData = 6553609;

		///<summary>
		///<para> (0064,000F) Pre Deformation Matrix Registration Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint PreDeformationMatrixRegistrationSequence = 6553615;

		///<summary>
		///<para> (0064,0010) Post Deformation Matrix Registration Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint PostDeformationMatrixRegistrationSequence = 6553616;

		///<summary>
		///<para> (0066,0001) Number of Surfaces </para>
		///<para> VR: UL VM=1 </para>
		///</summary>
        public const uint NumberOfSurfaces = 6684673;

		///<summary>
		///<para> (0066,0002) Surface Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint SurfaceSequence = 6684674;

		///<summary>
		///<para> (0066,0003) Surface Number </para>
		///<para> VR: UL VM=1 </para>
		///</summary>
        public const uint SurfaceNumber = 6684675;

		///<summary>
		///<para> (0066,0004) Surface Comments </para>
		///<para> VR: LT VM=1 </para>
		///</summary>
        public const uint SurfaceComments = 6684676;

		///<summary>
		///<para> (0066,0009) Surface Processing </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint SurfaceProcessing = 6684681;

		///<summary>
		///<para> (0066,000A) Surface Processing Ratio </para>
		///<para> VR: FL VM=1 </para>
		///</summary>
        public const uint SurfaceProcessingRatio = 6684682;

		///<summary>
		///<para> (0066,000B) Surface Processing Description </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint SurfaceProcessingDescription = 6684683;

		///<summary>
		///<para> (0066,000C) Recommended Presentation Opacity </para>
		///<para> VR: FL VM=1 </para>
		///</summary>
        public const uint RecommendedPresentationOpacity = 6684684;

		///<summary>
		///<para> (0066,000D) Recommended Presentation Type </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint RecommendedPresentationType = 6684685;

		///<summary>
		///<para> (0066,000E) Finite Volume </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint FiniteVolume = 6684686;

		///<summary>
		///<para> (0066,0010) Manifold </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint Manifold = 6684688;

		///<summary>
		///<para> (0066,0011) Surface Points Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint SurfacePointsSequence = 6684689;

		///<summary>
		///<para> (0066,0012) Surface Points Normals Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint SurfacePointsNormalsSequence = 6684690;

		///<summary>
		///<para> (0066,0013) Surface Mesh Primitives Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint SurfaceMeshPrimitivesSequence = 6684691;

		///<summary>
		///<para> (0066,0015) Number of Surface Points </para>
		///<para> VR: UL VM=1 </para>
		///</summary>
        public const uint NumberOfSurfacePoints = 6684693;

		///<summary>
		///<para> (0066,0016) Point Coordinates Data </para>
		///<para> VR: OF VM=1 </para>
		///</summary>
        public const uint PointCoordinatesData = 6684694;

		///<summary>
		///<para> (0066,0017) Point Position Accuracy </para>
		///<para> VR: FL VM=3 </para>
		///</summary>
        public const uint PointPositionAccuracy = 6684695;

		///<summary>
		///<para> (0066,0018) Mean Point Distance </para>
		///<para> VR: FL VM=1 </para>
		///</summary>
        public const uint MeanPointDistance = 6684696;

		///<summary>
		///<para> (0066,0019) Maximum Point Distance </para>
		///<para> VR: FL VM=1 </para>
		///</summary>
        public const uint MaximumPointDistance = 6684697;

		///<summary>
		///<para> (0066,001A) Points Bounding Box Coordinates </para>
		///<para> VR: FL VM=6 </para>
		///</summary>
        public const uint PointsBoundingBoxCoordinates = 6684698;

		///<summary>
		///<para> (0066,001B) Axis of Rotation </para>
		///<para> VR: FL VM=3 </para>
		///</summary>
        public const uint AxisOfRotation = 6684699;

		///<summary>
		///<para> (0066,001C) Center of Rotation </para>
		///<para> VR: FL VM=3 </para>
		///</summary>
        public const uint CenterOfRotation = 6684700;

		///<summary>
		///<para> (0066,001E) Number of Vectors </para>
		///<para> VR: UL VM=1 </para>
		///</summary>
        public const uint NumberOfVectors = 6684702;

		///<summary>
		///<para> (0066,001F) Vector Dimensionality </para>
		///<para> VR: US VM=1 </para>
		///</summary>
        public const uint VectorDimensionality = 6684703;

		///<summary>
		///<para> (0066,0020) Vector Accuracy </para>
		///<para> VR: FL VM=1-n </para>
		///</summary>
        public const uint VectorAccuracy = 6684704;

		///<summary>
		///<para> (0066,0021) Vector Coordinate Data </para>
		///<para> VR: OF VM=1 </para>
		///</summary>
        public const uint VectorCoordinateData = 6684705;

		///<summary>
		///<para> (0066,0023) Triangle Point Index List (RETIRED) </para>
		///<para> VR: OW VM=1 </para>
		///</summary>
        public const uint TrianglePointIndexListRetired = 6684707;

		///<summary>
		///<para> (0066,0024) Edge Point Index List (RETIRED) </para>
		///<para> VR: OW VM=1 </para>
		///</summary>
        public const uint EdgePointIndexListRetired = 6684708;

		///<summary>
		///<para> (0066,0025) Vertex Point Index List (RETIRED) </para>
		///<para> VR: OW VM=1 </para>
		///</summary>
        public const uint VertexPointIndexListRetired = 6684709;

		///<summary>
		///<para> (0066,0026) Triangle Strip Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint TriangleStripSequence = 6684710;

		///<summary>
		///<para> (0066,0027) Triangle Fan Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint TriangleFanSequence = 6684711;

		///<summary>
		///<para> (0066,0028) Line Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint LineSequence = 6684712;

		///<summary>
		///<para> (0066,0029) Primitive Point Index List (RETIRED) </para>
		///<para> VR: OW VM=1 </para>
		///</summary>
        public const uint PrimitivePointIndexListRetired = 6684713;

		///<summary>
		///<para> (0066,002A) Surface Count </para>
		///<para> VR: UL VM=1 </para>
		///</summary>
        public const uint SurfaceCount = 6684714;

		///<summary>
		///<para> (0066,002B) Referenced Surface Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint ReferencedSurfaceSequence = 6684715;

		///<summary>
		///<para> (0066,002C) Referenced Surface Number </para>
		///<para> VR: UL VM=1 </para>
		///</summary>
        public const uint ReferencedSurfaceNumber = 6684716;

		///<summary>
		///<para> (0066,002D) Segment Surface Generation Algorithm Identification Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint SegmentSurfaceGenerationAlgorithmIdentificationSequence = 6684717;

		///<summary>
		///<para> (0066,002E) Segment Surface Source Instance Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint SegmentSurfaceSourceInstanceSequence = 6684718;

		///<summary>
		///<para> (0066,002F) Algorithm Family Code Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint AlgorithmFamilyCodeSequence = 6684719;

		///<summary>
		///<para> (0066,0030) Algorithm Name Code Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint AlgorithmNameCodeSequence = 6684720;

		///<summary>
		///<para> (0066,0031) Algorithm Version </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint AlgorithmVersion = 6684721;

		///<summary>
		///<para> (0066,0032) Algorithm Parameters </para>
		///<para> VR: LT VM=1 </para>
		///</summary>
        public const uint AlgorithmParameters = 6684722;

		///<summary>
		///<para> (0066,0034) Facet Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint FacetSequence = 6684724;

		///<summary>
		///<para> (0066,0035) Surface Processing Algorithm Identification Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint SurfaceProcessingAlgorithmIdentificationSequence = 6684725;

		///<summary>
		///<para> (0066,0036) Algorithm Name </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint AlgorithmName = 6684726;

		///<summary>
		///<para> (0066,0037) Recommended Point Radius </para>
		///<para> VR: FL VM=1 </para>
		///</summary>
        public const uint RecommendedPointRadius = 6684727;

		///<summary>
		///<para> (0066,0038) Recommended Line Thickness </para>
		///<para> VR: FL VM=1 </para>
		///</summary>
        public const uint RecommendedLineThickness = 6684728;

		///<summary>
		///<para> (0066,0040) Long Primitive Point Index List </para>
		///<para> VR: OL VM=1 </para>
		///</summary>
        public const uint LongPrimitivePointIndexList = 6684736;

		///<summary>
		///<para> (0066,0041) Long Triangle Point Index List </para>
		///<para> VR: OL VM=1 </para>
		///</summary>
        public const uint LongTrianglePointIndexList = 6684737;

		///<summary>
		///<para> (0066,0042) Long Edge Point Index List </para>
		///<para> VR: OL VM=1 </para>
		///</summary>
        public const uint LongEdgePointIndexList = 6684738;

		///<summary>
		///<para> (0066,0043) Long Vertex Point Index List </para>
		///<para> VR: OL VM=1 </para>
		///</summary>
        public const uint LongVertexPointIndexList = 6684739;

		///<summary>
		///<para> (0066,0101) Track Set Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint TrackSetSequence = 6684929;

		///<summary>
		///<para> (0066,0102) Track Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint TrackSequence = 6684930;

		///<summary>
		///<para> (0066,0103) Recommended Display CIELab Value List </para>
		///<para> VR: OW VM=1 </para>
		///</summary>
        public const uint RecommendedDisplayCielabValueList = 6684931;

		///<summary>
		///<para> (0066,0104) Tracking Algorithm Identification Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint TrackingAlgorithmIdentificationSequence = 6684932;

		///<summary>
		///<para> (0066,0105) Track Set Number </para>
		///<para> VR: UL VM=1 </para>
		///</summary>
        public const uint TrackSetNumber = 6684933;

		///<summary>
		///<para> (0066,0106) Track Set Label </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint TrackSetLabel = 6684934;

		///<summary>
		///<para> (0066,0107) Track Set Description </para>
		///<para> VR: UT VM=1 </para>
		///</summary>
        public const uint TrackSetDescription = 6684935;

		///<summary>
		///<para> (0066,0108) Track Set Anatomical Type Code Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint TrackSetAnatomicalTypeCodeSequence = 6684936;

		///<summary>
		///<para> (0066,0121) Measurements Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint MeasurementsSequence = 6684961;

		///<summary>
		///<para> (0066,0124) Track Set Statistics Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint TrackSetStatisticsSequence = 6684964;

		///<summary>
		///<para> (0066,0125) Floating Point Values </para>
		///<para> VR: OF VM=1 </para>
		///</summary>
        public const uint FloatingPointValues = 6684965;

		///<summary>
		///<para> (0066,0129) Track Point Index List </para>
		///<para> VR: OL VM=1 </para>
		///</summary>
        public const uint TrackPointIndexList = 6684969;

		///<summary>
		///<para> (0066,0130) Track Statistics Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint TrackStatisticsSequence = 6684976;

		///<summary>
		///<para> (0066,0132) Measurement Values Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint MeasurementValuesSequence = 6684978;

		///<summary>
		///<para> (0066,0133) Diffusion Acquisition Code Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint DiffusionAcquisitionCodeSequence = 6684979;

		///<summary>
		///<para> (0066,0134) Diffusion Model Code Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint DiffusionModelCodeSequence = 6684980;

		///<summary>
		///<para> (0068,6210) Implant Size </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint ImplantSize = 6840848;

		///<summary>
		///<para> (0068,6221) Implant Template Version </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint ImplantTemplateVersion = 6840865;

		///<summary>
		///<para> (0068,6222) Replaced Implant Template Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint ReplacedImplantTemplateSequence = 6840866;

		///<summary>
		///<para> (0068,6223) Implant Type </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint ImplantType = 6840867;

		///<summary>
		///<para> (0068,6224) Derivation Implant Template Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint DerivationImplantTemplateSequence = 6840868;

		///<summary>
		///<para> (0068,6225) Original Implant Template Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint OriginalImplantTemplateSequence = 6840869;

		///<summary>
		///<para> (0068,6226) Effective DateTime </para>
		///<para> VR: DT VM=1 </para>
		///</summary>
        public const uint EffectiveDatetime = 6840870;

		///<summary>
		///<para> (0068,6230) Implant Target Anatomy Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint ImplantTargetAnatomySequence = 6840880;

		///<summary>
		///<para> (0068,6260) Information From Manufacturer Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint InformationFromManufacturerSequence = 6840928;

		///<summary>
		///<para> (0068,6265) Notification From Manufacturer Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint NotificationFromManufacturerSequence = 6840933;

		///<summary>
		///<para> (0068,6270) Information Issue DateTime </para>
		///<para> VR: DT VM=1 </para>
		///</summary>
        public const uint InformationIssueDatetime = 6840944;

		///<summary>
		///<para> (0068,6280) Information Summary </para>
		///<para> VR: ST VM=1 </para>
		///</summary>
        public const uint InformationSummary = 6840960;

		///<summary>
		///<para> (0068,62A0) Implant Regulatory Disapproval Code Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint ImplantRegulatoryDisapprovalCodeSequence = 6840992;

		///<summary>
		///<para> (0068,62A5) Overall Template Spatial Tolerance </para>
		///<para> VR: FD VM=1 </para>
		///</summary>
        public const uint OverallTemplateSpatialTolerance = 6840997;

		///<summary>
		///<para> (0068,62C0) HPGL Document Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint HpglDocumentSequence = 6841024;

		///<summary>
		///<para> (0068,62D0) HPGL Document ID </para>
		///<para> VR: US VM=1 </para>
		///</summary>
        public const uint HpglDocumentId = 6841040;

		///<summary>
		///<para> (0068,62D5) HPGL Document Label </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint HpglDocumentLabel = 6841045;

		///<summary>
		///<para> (0068,62E0) View Orientation Code Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint ViewOrientationCodeSequence = 6841056;

		///<summary>
		///<para> (0068,62F0) View Orientation Modifier </para>
		///<para> VR: FD VM=9 </para>
		///</summary>
        public const uint ViewOrientationModifier = 6841072;

		///<summary>
		///<para> (0068,62F2) HPGL Document Scaling </para>
		///<para> VR: FD VM=1 </para>
		///</summary>
        public const uint HpglDocumentScaling = 6841074;

		///<summary>
		///<para> (0068,6300) HPGL Document </para>
		///<para> VR: OB VM=1 </para>
		///</summary>
        public const uint HpglDocument = 6841088;

		///<summary>
		///<para> (0068,6310) HPGL Contour Pen Number </para>
		///<para> VR: US VM=1 </para>
		///</summary>
        public const uint HpglContourPenNumber = 6841104;

		///<summary>
		///<para> (0068,6320) HPGL Pen Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint HpglPenSequence = 6841120;

		///<summary>
		///<para> (0068,6330) HPGL Pen Number </para>
		///<para> VR: US VM=1 </para>
		///</summary>
        public const uint HpglPenNumber = 6841136;

		///<summary>
		///<para> (0068,6340) HPGL Pen Label </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint HpglPenLabel = 6841152;

		///<summary>
		///<para> (0068,6345) HPGL Pen Description </para>
		///<para> VR: ST VM=1 </para>
		///</summary>
        public const uint HpglPenDescription = 6841157;

		///<summary>
		///<para> (0068,6346) Recommended Rotation Point </para>
		///<para> VR: FD VM=2 </para>
		///</summary>
        public const uint RecommendedRotationPoint = 6841158;

		///<summary>
		///<para> (0068,6347) Bounding Rectangle </para>
		///<para> VR: FD VM=4 </para>
		///</summary>
        public const uint BoundingRectangle = 6841159;

		///<summary>
		///<para> (0068,6350) Implant Template 3D Model Surface Number </para>
		///<para> VR: US VM=1-n </para>
		///</summary>
        public const uint ImplantTemplate3dModelSurfaceNumber = 6841168;

		///<summary>
		///<para> (0068,6360) Surface Model Description Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint SurfaceModelDescriptionSequence = 6841184;

		///<summary>
		///<para> (0068,6380) Surface Model Label </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint SurfaceModelLabel = 6841216;

		///<summary>
		///<para> (0068,6390) Surface Model Scaling Factor </para>
		///<para> VR: FD VM=1 </para>
		///</summary>
        public const uint SurfaceModelScalingFactor = 6841232;

		///<summary>
		///<para> (0068,63A0) Materials Code Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint MaterialsCodeSequence = 6841248;

		///<summary>
		///<para> (0068,63A4) Coating Materials Code Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint CoatingMaterialsCodeSequence = 6841252;

		///<summary>
		///<para> (0068,63A8) Implant Type Code Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint ImplantTypeCodeSequence = 6841256;

		///<summary>
		///<para> (0068,63AC) Fixation Method Code Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint FixationMethodCodeSequence = 6841260;

		///<summary>
		///<para> (0068,63B0) Mating Feature Sets Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint MatingFeatureSetsSequence = 6841264;

		///<summary>
		///<para> (0068,63C0) Mating Feature Set ID </para>
		///<para> VR: US VM=1 </para>
		///</summary>
        public const uint MatingFeatureSetId = 6841280;

		///<summary>
		///<para> (0068,63D0) Mating Feature Set Label </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint MatingFeatureSetLabel = 6841296;

		///<summary>
		///<para> (0068,63E0) Mating Feature Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint MatingFeatureSequence = 6841312;

		///<summary>
		///<para> (0068,63F0) Mating Feature ID </para>
		///<para> VR: US VM=1 </para>
		///</summary>
        public const uint MatingFeatureId = 6841328;

		///<summary>
		///<para> (0068,6400) Mating Feature Degree of Freedom Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint MatingFeatureDegreeOfFreedomSequence = 6841344;

		///<summary>
		///<para> (0068,6410) Degree of Freedom ID </para>
		///<para> VR: US VM=1 </para>
		///</summary>
        public const uint DegreeOfFreedomId = 6841360;

		///<summary>
		///<para> (0068,6420) Degree of Freedom Type </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint DegreeOfFreedomType = 6841376;

		///<summary>
		///<para> (0068,6430) 2D Mating Feature Coordinates Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint TwoDMatingFeatureCoordinatesSequence = 6841392;

		///<summary>
		///<para> (0068,6440) Referenced HPGL Document ID </para>
		///<para> VR: US VM=1 </para>
		///</summary>
        public const uint ReferencedHpglDocumentId = 6841408;

		///<summary>
		///<para> (0068,6450) 2D Mating Point </para>
		///<para> VR: FD VM=2 </para>
		///</summary>
        public const uint TwoDMatingPoint = 6841424;

		///<summary>
		///<para> (0068,6460) 2D Mating Axes </para>
		///<para> VR: FD VM=4 </para>
		///</summary>
        public const uint TwoDMatingAxes = 6841440;

		///<summary>
		///<para> (0068,6470) 2D Degree of Freedom Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint TwoDDegreeOfFreedomSequence = 6841456;

		///<summary>
		///<para> (0068,6490) 3D Degree of Freedom Axis </para>
		///<para> VR: FD VM=3 </para>
		///</summary>
        public const uint ThreeDDegreeOfFreedomAxis = 6841488;

		///<summary>
		///<para> (0068,64A0) Range of Freedom </para>
		///<para> VR: FD VM=2 </para>
		///</summary>
        public const uint RangeOfFreedom = 6841504;

		///<summary>
		///<para> (0068,64C0) 3D Mating Point </para>
		///<para> VR: FD VM=3 </para>
		///</summary>
        public const uint ThreeDMatingPoint = 6841536;

		///<summary>
		///<para> (0068,64D0) 3D Mating Axes </para>
		///<para> VR: FD VM=9 </para>
		///</summary>
        public const uint ThreeDMatingAxes = 6841552;

		///<summary>
		///<para> (0068,64F0) 2D Degree of Freedom Axis </para>
		///<para> VR: FD VM=3 </para>
		///</summary>
        public const uint TwoDDegreeOfFreedomAxis = 6841584;

		///<summary>
		///<para> (0068,6500) Planning Landmark Point Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint PlanningLandmarkPointSequence = 6841600;

		///<summary>
		///<para> (0068,6510) Planning Landmark Line Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint PlanningLandmarkLineSequence = 6841616;

		///<summary>
		///<para> (0068,6520) Planning Landmark Plane Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint PlanningLandmarkPlaneSequence = 6841632;

		///<summary>
		///<para> (0068,6530) Planning Landmark ID </para>
		///<para> VR: US VM=1 </para>
		///</summary>
        public const uint PlanningLandmarkId = 6841648;

		///<summary>
		///<para> (0068,6540) Planning Landmark Description </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint PlanningLandmarkDescription = 6841664;

		///<summary>
		///<para> (0068,6545) Planning Landmark Identification Code Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint PlanningLandmarkIdentificationCodeSequence = 6841669;

		///<summary>
		///<para> (0068,6550) 2D Point Coordinates Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint TwoDPointCoordinatesSequence = 6841680;

		///<summary>
		///<para> (0068,6560) 2D Point Coordinates </para>
		///<para> VR: FD VM=2 </para>
		///</summary>
        public const uint TwoDPointCoordinates = 6841696;

		///<summary>
		///<para> (0068,6590) 3D Point Coordinates </para>
		///<para> VR: FD VM=3 </para>
		///</summary>
        public const uint ThreeDPointCoordinates = 6841744;

		///<summary>
		///<para> (0068,65A0) 2D Line Coordinates Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint TwoDLineCoordinatesSequence = 6841760;

		///<summary>
		///<para> (0068,65B0) 2D Line Coordinates </para>
		///<para> VR: FD VM=4 </para>
		///</summary>
        public const uint TwoDLineCoordinates = 6841776;

		///<summary>
		///<para> (0068,65D0) 3D Line Coordinates </para>
		///<para> VR: FD VM=6 </para>
		///</summary>
        public const uint ThreeDLineCoordinates = 6841808;

		///<summary>
		///<para> (0068,65E0) 2D Plane Coordinates Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint TwoDPlaneCoordinatesSequence = 6841824;

		///<summary>
		///<para> (0068,65F0) 2D Plane Intersection </para>
		///<para> VR: FD VM=4 </para>
		///</summary>
        public const uint TwoDPlaneIntersection = 6841840;

		///<summary>
		///<para> (0068,6610) 3D Plane Origin </para>
		///<para> VR: FD VM=3 </para>
		///</summary>
        public const uint ThreeDPlaneOrigin = 6841872;

		///<summary>
		///<para> (0068,6620) 3D Plane Normal </para>
		///<para> VR: FD VM=3 </para>
		///</summary>
        public const uint ThreeDPlaneNormal = 6841888;

		///<summary>
		///<para> (0070,0001) Graphic Annotation Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint GraphicAnnotationSequence = 7340033;

		///<summary>
		///<para> (0070,0002) Graphic Layer </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint GraphicLayer = 7340034;

		///<summary>
		///<para> (0070,0003) Bounding Box Annotation Units </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint BoundingBoxAnnotationUnits = 7340035;

		///<summary>
		///<para> (0070,0004) Anchor Point Annotation Units </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint AnchorPointAnnotationUnits = 7340036;

		///<summary>
		///<para> (0070,0005) Graphic Annotation Units </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint GraphicAnnotationUnits = 7340037;

		///<summary>
		///<para> (0070,0006) Unformatted Text Value </para>
		///<para> VR: ST VM=1 </para>
		///</summary>
        public const uint UnformattedTextValue = 7340038;

		///<summary>
		///<para> (0070,0008) Text Object Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint TextObjectSequence = 7340040;

		///<summary>
		///<para> (0070,0009) Graphic Object Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint GraphicObjectSequence = 7340041;

		///<summary>
		///<para> (0070,0010) Bounding Box Top Left Hand Corner </para>
		///<para> VR: FL VM=2 </para>
		///</summary>
        public const uint BoundingBoxTopLeftHandCorner = 7340048;

		///<summary>
		///<para> (0070,0011) Bounding Box Bottom Right Hand Corner </para>
		///<para> VR: FL VM=2 </para>
		///</summary>
        public const uint BoundingBoxBottomRightHandCorner = 7340049;

		///<summary>
		///<para> (0070,0012) Bounding Box Text Horizontal Justification </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint BoundingBoxTextHorizontalJustification = 7340050;

		///<summary>
		///<para> (0070,0014) Anchor Point </para>
		///<para> VR: FL VM=2 </para>
		///</summary>
        public const uint AnchorPoint = 7340052;

		///<summary>
		///<para> (0070,0015) Anchor Point Visibility </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint AnchorPointVisibility = 7340053;

		///<summary>
		///<para> (0070,0020) Graphic Dimensions </para>
		///<para> VR: US VM=1 </para>
		///</summary>
        public const uint GraphicDimensions = 7340064;

		///<summary>
		///<para> (0070,0021) Number of Graphic Points </para>
		///<para> VR: US VM=1 </para>
		///</summary>
        public const uint NumberOfGraphicPoints = 7340065;

		///<summary>
		///<para> (0070,0022) Graphic Data </para>
		///<para> VR: FL VM=2-n </para>
		///</summary>
        public const uint GraphicData = 7340066;

		///<summary>
		///<para> (0070,0023) Graphic Type </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint GraphicType = 7340067;

		///<summary>
		///<para> (0070,0024) Graphic Filled </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint GraphicFilled = 7340068;

		///<summary>
		///<para> (0070,0040) Image Rotation (Retired) (RETIRED) </para>
		///<para> VR: IS VM=1 </para>
		///</summary>
        public const uint ImageRotationRetiredRetired = 7340096;

		///<summary>
		///<para> (0070,0041) Image Horizontal Flip </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint ImageHorizontalFlip = 7340097;

		///<summary>
		///<para> (0070,0042) Image Rotation </para>
		///<para> VR: US VM=1 </para>
		///</summary>
        public const uint ImageRotation = 7340098;

		///<summary>
		///<para> (0070,0050) Displayed Area Top Left Hand Corner (Trial) (RETIRED) </para>
		///<para> VR: US VM=2 </para>
		///</summary>
        public const uint DisplayedAreaTopLeftHandCornerTrialRetired = 7340112;

		///<summary>
		///<para> (0070,0051) Displayed Area Bottom Right Hand Corner (Trial) (RETIRED) </para>
		///<para> VR: US VM=2 </para>
		///</summary>
        public const uint DisplayedAreaBottomRightHandCornerTrialRetired = 7340113;

		///<summary>
		///<para> (0070,0052) Displayed Area Top Left Hand Corner </para>
		///<para> VR: SL VM=2 </para>
		///</summary>
        public const uint DisplayedAreaTopLeftHandCorner = 7340114;

		///<summary>
		///<para> (0070,0053) Displayed Area Bottom Right Hand Corner </para>
		///<para> VR: SL VM=2 </para>
		///</summary>
        public const uint DisplayedAreaBottomRightHandCorner = 7340115;

		///<summary>
		///<para> (0070,005A) Displayed Area Selection Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint DisplayedAreaSelectionSequence = 7340122;

		///<summary>
		///<para> (0070,0060) Graphic Layer Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint GraphicLayerSequence = 7340128;

		///<summary>
		///<para> (0070,0062) Graphic Layer Order </para>
		///<para> VR: IS VM=1 </para>
		///</summary>
        public const uint GraphicLayerOrder = 7340130;

		///<summary>
		///<para> (0070,0066) Graphic Layer Recommended Display Grayscale Value </para>
		///<para> VR: US VM=1 </para>
		///</summary>
        public const uint GraphicLayerRecommendedDisplayGrayscaleValue = 7340134;

		///<summary>
		///<para> (0070,0067) Graphic Layer Recommended Display RGB Value (RETIRED) </para>
		///<para> VR: US VM=3 </para>
		///</summary>
        public const uint GraphicLayerRecommendedDisplayRgbValueRetired = 7340135;

		///<summary>
		///<para> (0070,0068) Graphic Layer Description </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint GraphicLayerDescription = 7340136;

		///<summary>
		///<para> (0070,0080) Content Label </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint ContentLabel = 7340160;

		///<summary>
		///<para> (0070,0081) Content Description </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint ContentDescription = 7340161;

		///<summary>
		///<para> (0070,0082) Presentation Creation Date </para>
		///<para> VR: DA VM=1 </para>
		///</summary>
        public const uint PresentationCreationDate = 7340162;

		///<summary>
		///<para> (0070,0083) Presentation Creation Time </para>
		///<para> VR: TM VM=1 </para>
		///</summary>
        public const uint PresentationCreationTime = 7340163;

		///<summary>
		///<para> (0070,0084) Content Creator's Name </para>
		///<para> VR: PN VM=1 </para>
		///</summary>
        public const uint ContentCreatorsName = 7340164;

		///<summary>
		///<para> (0070,0086) Content Creator's Identification Code Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint ContentCreatorsIdentificationCodeSequence = 7340166;

		///<summary>
		///<para> (0070,0087) Alternate Content Description Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint AlternateContentDescriptionSequence = 7340167;

		///<summary>
		///<para> (0070,0100) Presentation Size Mode </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint PresentationSizeMode = 7340288;

		///<summary>
		///<para> (0070,0101) Presentation Pixel Spacing </para>
		///<para> VR: DS VM=2 </para>
		///</summary>
        public const uint PresentationPixelSpacing = 7340289;

		///<summary>
		///<para> (0070,0102) Presentation Pixel Aspect Ratio </para>
		///<para> VR: IS VM=2 </para>
		///</summary>
        public const uint PresentationPixelAspectRatio = 7340290;

		///<summary>
		///<para> (0070,0103) Presentation Pixel Magnification Ratio </para>
		///<para> VR: FL VM=1 </para>
		///</summary>
        public const uint PresentationPixelMagnificationRatio = 7340291;

		///<summary>
		///<para> (0070,0207) Graphic Group Label </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint GraphicGroupLabel = 7340551;

		///<summary>
		///<para> (0070,0208) Graphic Group Description </para>
		///<para> VR: ST VM=1 </para>
		///</summary>
        public const uint GraphicGroupDescription = 7340552;

		///<summary>
		///<para> (0070,0209) Compound Graphic Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint CompoundGraphicSequence = 7340553;

		///<summary>
		///<para> (0070,0226) Compound Graphic Instance ID </para>
		///<para> VR: UL VM=1 </para>
		///</summary>
        public const uint CompoundGraphicInstanceId = 7340582;

		///<summary>
		///<para> (0070,0227) Font Name </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint FontName = 7340583;

		///<summary>
		///<para> (0070,0228) Font Name Type </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint FontNameType = 7340584;

		///<summary>
		///<para> (0070,0229) CSS Font Name </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint CssFontName = 7340585;

		///<summary>
		///<para> (0070,0230) Rotation Angle </para>
		///<para> VR: FD VM=1 </para>
		///</summary>
        public const uint RotationAngle = 7340592;

		///<summary>
		///<para> (0070,0231) Text Style Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint TextStyleSequence = 7340593;

		///<summary>
		///<para> (0070,0232) Line Style Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint LineStyleSequence = 7340594;

		///<summary>
		///<para> (0070,0233) Fill Style Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint FillStyleSequence = 7340595;

		///<summary>
		///<para> (0070,0234) Graphic Group Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint GraphicGroupSequence = 7340596;

		///<summary>
		///<para> (0070,0241) Text Color CIELab Value </para>
		///<para> VR: US VM=3 </para>
		///</summary>
        public const uint TextColorCielabValue = 7340609;

		///<summary>
		///<para> (0070,0242) Horizontal Alignment </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint HorizontalAlignment = 7340610;

		///<summary>
		///<para> (0070,0243) Vertical Alignment </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint VerticalAlignment = 7340611;

		///<summary>
		///<para> (0070,0244) Shadow Style </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint ShadowStyle = 7340612;

		///<summary>
		///<para> (0070,0245) Shadow Offset X </para>
		///<para> VR: FL VM=1 </para>
		///</summary>
        public const uint ShadowOffsetX = 7340613;

		///<summary>
		///<para> (0070,0246) Shadow Offset Y </para>
		///<para> VR: FL VM=1 </para>
		///</summary>
        public const uint ShadowOffsetY = 7340614;

		///<summary>
		///<para> (0070,0247) Shadow Color CIELab Value </para>
		///<para> VR: US VM=3 </para>
		///</summary>
        public const uint ShadowColorCielabValue = 7340615;

		///<summary>
		///<para> (0070,0248) Underlined </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint Underlined = 7340616;

		///<summary>
		///<para> (0070,0249) Bold </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint Bold = 7340617;

		///<summary>
		///<para> (0070,0250) Italic </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint Italic = 7340624;

		///<summary>
		///<para> (0070,0251) Pattern On Color CIELab Value </para>
		///<para> VR: US VM=3 </para>
		///</summary>
        public const uint PatternOnColorCielabValue = 7340625;

		///<summary>
		///<para> (0070,0252) Pattern Off Color CIELab Value </para>
		///<para> VR: US VM=3 </para>
		///</summary>
        public const uint PatternOffColorCielabValue = 7340626;

		///<summary>
		///<para> (0070,0253) Line Thickness </para>
		///<para> VR: FL VM=1 </para>
		///</summary>
        public const uint LineThickness = 7340627;

		///<summary>
		///<para> (0070,0254) Line Dashing Style </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint LineDashingStyle = 7340628;

		///<summary>
		///<para> (0070,0255) Line Pattern </para>
		///<para> VR: UL VM=1 </para>
		///</summary>
        public const uint LinePattern = 7340629;

		///<summary>
		///<para> (0070,0256) Fill Pattern </para>
		///<para> VR: OB VM=1 </para>
		///</summary>
        public const uint FillPattern = 7340630;

		///<summary>
		///<para> (0070,0257) Fill Mode </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint FillMode = 7340631;

		///<summary>
		///<para> (0070,0258) Shadow Opacity </para>
		///<para> VR: FL VM=1 </para>
		///</summary>
        public const uint ShadowOpacity = 7340632;

		///<summary>
		///<para> (0070,0261) Gap Length </para>
		///<para> VR: FL VM=1 </para>
		///</summary>
        public const uint GapLength = 7340641;

		///<summary>
		///<para> (0070,0262) Diameter of Visibility </para>
		///<para> VR: FL VM=1 </para>
		///</summary>
        public const uint DiameterOfVisibility = 7340642;

		///<summary>
		///<para> (0070,0273) Rotation Point </para>
		///<para> VR: FL VM=2 </para>
		///</summary>
        public const uint RotationPoint = 7340659;

		///<summary>
		///<para> (0070,0274) Tick Alignment </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint TickAlignment = 7340660;

		///<summary>
		///<para> (0070,0278) Show Tick Label </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint ShowTickLabel = 7340664;

		///<summary>
		///<para> (0070,0279) Tick Label Alignment </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint TickLabelAlignment = 7340665;

		///<summary>
		///<para> (0070,0282) Compound Graphic Units </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint CompoundGraphicUnits = 7340674;

		///<summary>
		///<para> (0070,0284) Pattern On Opacity </para>
		///<para> VR: FL VM=1 </para>
		///</summary>
        public const uint PatternOnOpacity = 7340676;

		///<summary>
		///<para> (0070,0285) Pattern Off Opacity </para>
		///<para> VR: FL VM=1 </para>
		///</summary>
        public const uint PatternOffOpacity = 7340677;

		///<summary>
		///<para> (0070,0287) Major Ticks Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint MajorTicksSequence = 7340679;

		///<summary>
		///<para> (0070,0288) Tick Position </para>
		///<para> VR: FL VM=1 </para>
		///</summary>
        public const uint TickPosition = 7340680;

		///<summary>
		///<para> (0070,0289) Tick Label </para>
		///<para> VR: SH VM=1 </para>
		///</summary>
        public const uint TickLabel = 7340681;

		///<summary>
		///<para> (0070,0294) Compound Graphic Type </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint CompoundGraphicType = 7340692;

		///<summary>
		///<para> (0070,0295) Graphic Group ID </para>
		///<para> VR: UL VM=1 </para>
		///</summary>
        public const uint GraphicGroupId = 7340693;

		///<summary>
		///<para> (0070,0306) Shape Type </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint ShapeType = 7340806;

		///<summary>
		///<para> (0070,0308) Registration Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint RegistrationSequence = 7340808;

		///<summary>
		///<para> (0070,0309) Matrix Registration Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint MatrixRegistrationSequence = 7340809;

		///<summary>
		///<para> (0070,030A) Matrix Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint MatrixSequence = 7340810;

		///<summary>
		///<para> (0070,030B) Frame of Reference to Displayed Coordinate System Transformation Matrix </para>
		///<para> VR: FD VM=16 </para>
		///</summary>
        public const uint FrameOfReferenceToDisplayedCoordinateSystemTransformationMatrix = 7340811;

		///<summary>
		///<para> (0070,030C) Frame of Reference Transformation Matrix Type </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint FrameOfReferenceTransformationMatrixType = 7340812;

		///<summary>
		///<para> (0070,030D) Registration Type Code Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint RegistrationTypeCodeSequence = 7340813;

		///<summary>
		///<para> (0070,030F) Fiducial Description </para>
		///<para> VR: ST VM=1 </para>
		///</summary>
        public const uint FiducialDescription = 7340815;

		///<summary>
		///<para> (0070,0310) Fiducial Identifier </para>
		///<para> VR: SH VM=1 </para>
		///</summary>
        public const uint FiducialIdentifier = 7340816;

		///<summary>
		///<para> (0070,0311) Fiducial Identifier Code Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint FiducialIdentifierCodeSequence = 7340817;

		///<summary>
		///<para> (0070,0312) Contour Uncertainty Radius </para>
		///<para> VR: FD VM=1 </para>
		///</summary>
        public const uint ContourUncertaintyRadius = 7340818;

		///<summary>
		///<para> (0070,0314) Used Fiducials Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint UsedFiducialsSequence = 7340820;

		///<summary>
		///<para> (0070,0318) Graphic Coordinates Data Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint GraphicCoordinatesDataSequence = 7340824;

		///<summary>
		///<para> (0070,031A) Fiducial UID </para>
		///<para> VR: UI VM=1 </para>
		///</summary>
        public const uint FiducialUid = 7340826;

		///<summary>
		///<para> (0070,031C) Fiducial Set Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint FiducialSetSequence = 7340828;

		///<summary>
		///<para> (0070,031E) Fiducial Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint FiducialSequence = 7340830;

		///<summary>
		///<para> (0070,031F) Fiducials Property Category Code Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint FiducialsPropertyCategoryCodeSequence = 7340831;

		///<summary>
		///<para> (0070,0401) Graphic Layer Recommended Display CIELab Value </para>
		///<para> VR: US VM=3 </para>
		///</summary>
        public const uint GraphicLayerRecommendedDisplayCielabValue = 7341057;

		///<summary>
		///<para> (0070,0402) Blending Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint BlendingSequence = 7341058;

		///<summary>
		///<para> (0070,0403) Relative Opacity </para>
		///<para> VR: FL VM=1 </para>
		///</summary>
        public const uint RelativeOpacity = 7341059;

		///<summary>
		///<para> (0070,0404) Referenced Spatial Registration Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint ReferencedSpatialRegistrationSequence = 7341060;

		///<summary>
		///<para> (0070,0405) Blending Position </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint BlendingPosition = 7341061;

		///<summary>
		///<para> (0070,1101) Presentation Display Collection UID </para>
		///<para> VR: UI VM=1 </para>
		///</summary>
        public const uint PresentationDisplayCollectionUid = 7344385;

		///<summary>
		///<para> (0070,1102) Presentation Sequence Collection UID </para>
		///<para> VR: UI VM=1 </para>
		///</summary>
        public const uint PresentationSequenceCollectionUid = 7344386;

		///<summary>
		///<para> (0070,1103) Presentation Sequence Position Index </para>
		///<para> VR: US VM=1 </para>
		///</summary>
        public const uint PresentationSequencePositionIndex = 7344387;

		///<summary>
		///<para> (0070,1104) Rendered Image Reference Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint RenderedImageReferenceSequence = 7344388;

		///<summary>
		///<para> (0070,1201) Volumetric Presentation State Input Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint VolumetricPresentationStateInputSequence = 7344641;

		///<summary>
		///<para> (0070,1202) Presentation Input Type </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint PresentationInputType = 7344642;

		///<summary>
		///<para> (0070,1203) Input Sequence Position Index </para>
		///<para> VR: US VM=1 </para>
		///</summary>
        public const uint InputSequencePositionIndex = 7344643;

		///<summary>
		///<para> (0070,1204) Crop </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint Crop = 7344644;

		///<summary>
		///<para> (0070,1205) Cropping Specification Index </para>
		///<para> VR: US VM=1-n </para>
		///</summary>
        public const uint CroppingSpecificationIndex = 7344645;

		///<summary>
		///<para> (0070,1206) Compositing Method </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint CompositingMethod = 7344646;

		///<summary>
		///<para> (0070,1207) Volumetric Presentation Input Number </para>
		///<para> VR: US VM=1 </para>
		///</summary>
        public const uint VolumetricPresentationInputNumber = 7344647;

		///<summary>
		///<para> (0070,1208) Image Volume Geometry </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint ImageVolumeGeometry = 7344648;

		///<summary>
		///<para> (0070,1301) Volume Cropping Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint VolumeCroppingSequence = 7344897;

		///<summary>
		///<para> (0070,1302) Volume Cropping Method </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint VolumeCroppingMethod = 7344898;

		///<summary>
		///<para> (0070,1303) Bounding Box Crop </para>
		///<para> VR: FD VM=6 </para>
		///</summary>
        public const uint BoundingBoxCrop = 7344899;

		///<summary>
		///<para> (0070,1304) Oblique Cropping Plane Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint ObliqueCroppingPlaneSequence = 7344900;

		///<summary>
		///<para> (0070,1305) Plane </para>
		///<para> VR: FD VM=4 </para>
		///</summary>
        public const uint Plane = 7344901;

		///<summary>
		///<para> (0070,1306) Plane Normal </para>
		///<para> VR: FD VM=3 </para>
		///</summary>
        public const uint PlaneNormal = 7344902;

		///<summary>
		///<para> (0070,1309) Cropping Specification Number </para>
		///<para> VR: US VM=1 </para>
		///</summary>
        public const uint CroppingSpecificationNumber = 7344905;

		///<summary>
		///<para> (0070,1501) Multi-Planar Reconstruction Style </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint MultiPlanarReconstructionStyle = 7345409;

		///<summary>
		///<para> (0070,1502) MPR Thickness Type </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint MprThicknessType = 7345410;

		///<summary>
		///<para> (0070,1503) MPR Slab Thickness </para>
		///<para> VR: FD VM=1 </para>
		///</summary>
        public const uint MprSlabThickness = 7345411;

		///<summary>
		///<para> (0070,1505) MPR Top Left Hand Corner </para>
		///<para> VR: FD VM=3 </para>
		///</summary>
        public const uint MprTopLeftHandCorner = 7345413;

		///<summary>
		///<para> (0070,1507) MPR View Width Direction </para>
		///<para> VR: FD VM=3 </para>
		///</summary>
        public const uint MprViewWidthDirection = 7345415;

		///<summary>
		///<para> (0070,1508) MPR View Width </para>
		///<para> VR: FD VM=1 </para>
		///</summary>
        public const uint MprViewWidth = 7345416;

		///<summary>
		///<para> (0070,150C) Number of Volumetric Curve Points </para>
		///<para> VR: UL VM=1 </para>
		///</summary>
        public const uint NumberOfVolumetricCurvePoints = 7345420;

		///<summary>
		///<para> (0070,150D) Volumetric Curve Points </para>
		///<para> VR: OD VM=1 </para>
		///</summary>
        public const uint VolumetricCurvePoints = 7345421;

		///<summary>
		///<para> (0070,1511) MPR View Height Direction </para>
		///<para> VR: FD VM=3 </para>
		///</summary>
        public const uint MprViewHeightDirection = 7345425;

		///<summary>
		///<para> (0070,1512) MPR View Height </para>
		///<para> VR: FD VM=1 </para>
		///</summary>
        public const uint MprViewHeight = 7345426;

		///<summary>
		///<para> (0070,1801) Presentation State Classification Component Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint PresentationStateClassificationComponentSequence = 7346177;

		///<summary>
		///<para> (0070,1802) Component Type </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint ComponentType = 7346178;

		///<summary>
		///<para> (0070,1803) Component Input Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint ComponentInputSequence = 7346179;

		///<summary>
		///<para> (0070,1804) Volumetric Presentation Input Index </para>
		///<para> VR: US VM=1 </para>
		///</summary>
        public const uint VolumetricPresentationInputIndex = 7346180;

		///<summary>
		///<para> (0070,1805) Presentation State Compositor Component Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint PresentationStateCompositorComponentSequence = 7346181;

		///<summary>
		///<para> (0070,1806) Weighting Transfer Function Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint WeightingTransferFunctionSequence = 7346182;

		///<summary>
		///<para> (0070,1807) Weighting Lookup Table Descriptor </para>
		///<para> VR: US VM=3 </para>
		///</summary>
        public const uint WeightingLookupTableDescriptor = 7346183;

		///<summary>
		///<para> (0070,1808) Weighting Lookup Table Data </para>
		///<para> VR: OB VM=1 </para>
		///</summary>
        public const uint WeightingLookupTableData = 7346184;

		///<summary>
		///<para> (0070,1901) Volumetric Annotation Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint VolumetricAnnotationSequence = 7346433;

		///<summary>
		///<para> (0070,1903) Referenced Structured Context Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint ReferencedStructuredContextSequence = 7346435;

		///<summary>
		///<para> (0070,1904) Referenced Content Item </para>
		///<para> VR: UI VM=1 </para>
		///</summary>
        public const uint ReferencedContentItem = 7346436;

		///<summary>
		///<para> (0070,1905) Volumetric Presentation Input Annotation Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint VolumetricPresentationInputAnnotationSequence = 7346437;

		///<summary>
		///<para> (0070,1907) Annotation Clipping </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint AnnotationClipping = 7346439;

		///<summary>
		///<para> (0070,1A01) Presentation Animation Style </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint PresentationAnimationStyle = 7346689;

		///<summary>
		///<para> (0070,1A03) Recommended Animation Rate </para>
		///<para> VR: FD VM=1 </para>
		///</summary>
        public const uint RecommendedAnimationRate = 7346691;

		///<summary>
		///<para> (0070,1A04) Animation Curve Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint AnimationCurveSequence = 7346692;

		///<summary>
		///<para> (0070,1A05) Animation Step Size </para>
		///<para> VR: FD VM=1 </para>
		///</summary>
        public const uint AnimationStepSize = 7346693;

		///<summary>
		///<para> (0072,0002) Hanging Protocol Name </para>
		///<para> VR: SH VM=1 </para>
		///</summary>
        public const uint HangingProtocolName = 7471106;

		///<summary>
		///<para> (0072,0004) Hanging Protocol Description </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint HangingProtocolDescription = 7471108;

		///<summary>
		///<para> (0072,0006) Hanging Protocol Level </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint HangingProtocolLevel = 7471110;

		///<summary>
		///<para> (0072,0008) Hanging Protocol Creator </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint HangingProtocolCreator = 7471112;

		///<summary>
		///<para> (0072,000A) Hanging Protocol Creation DateTime </para>
		///<para> VR: DT VM=1 </para>
		///</summary>
        public const uint HangingProtocolCreationDatetime = 7471114;

		///<summary>
		///<para> (0072,000C) Hanging Protocol Definition Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint HangingProtocolDefinitionSequence = 7471116;

		///<summary>
		///<para> (0072,000E) Hanging Protocol User Identification Code Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint HangingProtocolUserIdentificationCodeSequence = 7471118;

		///<summary>
		///<para> (0072,0010) Hanging Protocol User Group Name </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint HangingProtocolUserGroupName = 7471120;

		///<summary>
		///<para> (0072,0012) Source Hanging Protocol Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint SourceHangingProtocolSequence = 7471122;

		///<summary>
		///<para> (0072,0014) Number of Priors Referenced </para>
		///<para> VR: US VM=1 </para>
		///</summary>
        public const uint NumberOfPriorsReferenced = 7471124;

		///<summary>
		///<para> (0072,0020) Image Sets Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint ImageSetsSequence = 7471136;

		///<summary>
		///<para> (0072,0022) Image Set Selector Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint ImageSetSelectorSequence = 7471138;

		///<summary>
		///<para> (0072,0024) Image Set Selector Usage Flag </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint ImageSetSelectorUsageFlag = 7471140;

		///<summary>
		///<para> (0072,0026) Selector Attribute </para>
		///<para> VR: AT VM=1 </para>
		///</summary>
        public const uint SelectorAttribute = 7471142;

		///<summary>
		///<para> (0072,0028) Selector Value Number </para>
		///<para> VR: US VM=1 </para>
		///</summary>
        public const uint SelectorValueNumber = 7471144;

		///<summary>
		///<para> (0072,0030) Time Based Image Sets Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint TimeBasedImageSetsSequence = 7471152;

		///<summary>
		///<para> (0072,0032) Image Set Number </para>
		///<para> VR: US VM=1 </para>
		///</summary>
        public const uint ImageSetNumber = 7471154;

		///<summary>
		///<para> (0072,0034) Image Set Selector Category </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint ImageSetSelectorCategory = 7471156;

		///<summary>
		///<para> (0072,0038) Relative Time </para>
		///<para> VR: US VM=2 </para>
		///</summary>
        public const uint RelativeTime = 7471160;

		///<summary>
		///<para> (0072,003A) Relative Time Units </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint RelativeTimeUnits = 7471162;

		///<summary>
		///<para> (0072,003C) Abstract Prior Value </para>
		///<para> VR: SS VM=2 </para>
		///</summary>
        public const uint AbstractPriorValue = 7471164;

		///<summary>
		///<para> (0072,003E) Abstract Prior Code Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint AbstractPriorCodeSequence = 7471166;

		///<summary>
		///<para> (0072,0040) Image Set Label </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint ImageSetLabel = 7471168;

		///<summary>
		///<para> (0072,0050) Selector Attribute VR </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint SelectorAttributeVr = 7471184;

		///<summary>
		///<para> (0072,0052) Selector Sequence Pointer </para>
		///<para> VR: AT VM=1-n </para>
		///</summary>
        public const uint SelectorSequencePointer = 7471186;

		///<summary>
		///<para> (0072,0054) Selector Sequence Pointer Private Creator </para>
		///<para> VR: LO VM=1-n </para>
		///</summary>
        public const uint SelectorSequencePointerPrivateCreator = 7471188;

		///<summary>
		///<para> (0072,0056) Selector Attribute Private Creator </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint SelectorAttributePrivateCreator = 7471190;

		///<summary>
		///<para> (0072,005E) Selector AE Value </para>
		///<para> VR: AE VM=1-n </para>
		///</summary>
        public const uint SelectorAeValue = 7471198;

		///<summary>
		///<para> (0072,005F) Selector AS Value </para>
		///<para> VR: AS VM=1-n </para>
		///</summary>
        public const uint SelectorAsValue = 7471199;

		///<summary>
		///<para> (0072,0060) Selector AT Value </para>
		///<para> VR: AT VM=1-n </para>
		///</summary>
        public const uint SelectorAtValue = 7471200;

		///<summary>
		///<para> (0072,0061) Selector DA Value </para>
		///<para> VR: DA VM=1-n </para>
		///</summary>
        public const uint SelectorDaValue = 7471201;

		///<summary>
		///<para> (0072,0062) Selector CS Value </para>
		///<para> VR: CS VM=1-n </para>
		///</summary>
        public const uint SelectorCsValue = 7471202;

		///<summary>
		///<para> (0072,0063) Selector DT Value </para>
		///<para> VR: DT VM=1-n </para>
		///</summary>
        public const uint SelectorDtValue = 7471203;

		///<summary>
		///<para> (0072,0064) Selector IS Value </para>
		///<para> VR: IS VM=1-n </para>
		///</summary>
        public const uint SelectorIsValue = 7471204;

		///<summary>
		///<para> (0072,0065) Selector OB Value </para>
		///<para> VR: OB VM=1 </para>
		///</summary>
        public const uint SelectorObValue = 7471205;

		///<summary>
		///<para> (0072,0066) Selector LO Value </para>
		///<para> VR: LO VM=1-n </para>
		///</summary>
        public const uint SelectorLoValue = 7471206;

		///<summary>
		///<para> (0072,0067) Selector OF Value </para>
		///<para> VR: OF VM=1 </para>
		///</summary>
        public const uint SelectorOfValue = 7471207;

		///<summary>
		///<para> (0072,0068) Selector LT Value </para>
		///<para> VR: LT VM=1 </para>
		///</summary>
        public const uint SelectorLtValue = 7471208;

		///<summary>
		///<para> (0072,0069) Selector OW Value </para>
		///<para> VR: OW VM=1 </para>
		///</summary>
        public const uint SelectorOwValue = 7471209;

		///<summary>
		///<para> (0072,006A) Selector PN Value </para>
		///<para> VR: PN VM=1-n </para>
		///</summary>
        public const uint SelectorPnValue = 7471210;

		///<summary>
		///<para> (0072,006B) Selector TM Value </para>
		///<para> VR: TM VM=1-n </para>
		///</summary>
        public const uint SelectorTmValue = 7471211;

		///<summary>
		///<para> (0072,006C) Selector SH Value </para>
		///<para> VR: SH VM=1-n </para>
		///</summary>
        public const uint SelectorShValue = 7471212;

		///<summary>
		///<para> (0072,006D) Selector UN Value </para>
		///<para> VR: UN VM=1 </para>
		///</summary>
        public const uint SelectorUnValue = 7471213;

		///<summary>
		///<para> (0072,006E) Selector ST Value </para>
		///<para> VR: ST VM=1 </para>
		///</summary>
        public const uint SelectorStValue = 7471214;

		///<summary>
		///<para> (0072,006F) Selector UC Value </para>
		///<para> VR: UC VM=1-n </para>
		///</summary>
        public const uint SelectorUcValue = 7471215;

		///<summary>
		///<para> (0072,0070) Selector UT Value </para>
		///<para> VR: UT VM=1 </para>
		///</summary>
        public const uint SelectorUtValue = 7471216;

		///<summary>
		///<para> (0072,0071) Selector UR Value </para>
		///<para> VR: UR VM=1 </para>
		///</summary>
        public const uint SelectorUrValue = 7471217;

		///<summary>
		///<para> (0072,0072) Selector DS Value </para>
		///<para> VR: DS VM=1-n </para>
		///</summary>
        public const uint SelectorDsValue = 7471218;

		///<summary>
		///<para> (0072,0073) Selector OD Value </para>
		///<para> VR: OD VM=1 </para>
		///</summary>
        public const uint SelectorOdValue = 7471219;

		///<summary>
		///<para> (0072,0074) Selector FD Value </para>
		///<para> VR: FD VM=1-n </para>
		///</summary>
        public const uint SelectorFdValue = 7471220;

		///<summary>
		///<para> (0072,0075) Selector OL Value </para>
		///<para> VR: OL VM=1 </para>
		///</summary>
        public const uint SelectorOlValue = 7471221;

		///<summary>
		///<para> (0072,0076) Selector FL Value </para>
		///<para> VR: FL VM=1-n </para>
		///</summary>
        public const uint SelectorFlValue = 7471222;

		///<summary>
		///<para> (0072,0078) Selector UL Value </para>
		///<para> VR: UL VM=1-n </para>
		///</summary>
        public const uint SelectorUlValue = 7471224;

		///<summary>
		///<para> (0072,007A) Selector US Value </para>
		///<para> VR: US VM=1-n </para>
		///</summary>
        public const uint SelectorUsValue = 7471226;

		///<summary>
		///<para> (0072,007C) Selector SL Value </para>
		///<para> VR: SL VM=1-n </para>
		///</summary>
        public const uint SelectorSlValue = 7471228;

		///<summary>
		///<para> (0072,007E) Selector SS Value </para>
		///<para> VR: SS VM=1-n </para>
		///</summary>
        public const uint SelectorSsValue = 7471230;

		///<summary>
		///<para> (0072,007F) Selector UI Value </para>
		///<para> VR: UI VM=1-n </para>
		///</summary>
        public const uint SelectorUiValue = 7471231;

		///<summary>
		///<para> (0072,0080) Selector Code Sequence Value </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint SelectorCodeSequenceValue = 7471232;

		///<summary>
		///<para> (0072,0100) Number of Screens </para>
		///<para> VR: US VM=1 </para>
		///</summary>
        public const uint NumberOfScreens = 7471360;

		///<summary>
		///<para> (0072,0102) Nominal Screen Definition Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint NominalScreenDefinitionSequence = 7471362;

		///<summary>
		///<para> (0072,0104) Number of Vertical Pixels </para>
		///<para> VR: US VM=1 </para>
		///</summary>
        public const uint NumberOfVerticalPixels = 7471364;

		///<summary>
		///<para> (0072,0106) Number of Horizontal Pixels </para>
		///<para> VR: US VM=1 </para>
		///</summary>
        public const uint NumberOfHorizontalPixels = 7471366;

		///<summary>
		///<para> (0072,0108) Display Environment Spatial Position </para>
		///<para> VR: FD VM=4 </para>
		///</summary>
        public const uint DisplayEnvironmentSpatialPosition = 7471368;

		///<summary>
		///<para> (0072,010A) Screen Minimum Grayscale Bit Depth </para>
		///<para> VR: US VM=1 </para>
		///</summary>
        public const uint ScreenMinimumGrayscaleBitDepth = 7471370;

		///<summary>
		///<para> (0072,010C) Screen Minimum Color Bit Depth </para>
		///<para> VR: US VM=1 </para>
		///</summary>
        public const uint ScreenMinimumColorBitDepth = 7471372;

		///<summary>
		///<para> (0072,010E) Application Maximum Repaint Time </para>
		///<para> VR: US VM=1 </para>
		///</summary>
        public const uint ApplicationMaximumRepaintTime = 7471374;

		///<summary>
		///<para> (0072,0200) Display Sets Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint DisplaySetsSequence = 7471616;

		///<summary>
		///<para> (0072,0202) Display Set Number </para>
		///<para> VR: US VM=1 </para>
		///</summary>
        public const uint DisplaySetNumber = 7471618;

		///<summary>
		///<para> (0072,0203) Display Set Label </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint DisplaySetLabel = 7471619;

		///<summary>
		///<para> (0072,0204) Display Set Presentation Group </para>
		///<para> VR: US VM=1 </para>
		///</summary>
        public const uint DisplaySetPresentationGroup = 7471620;

		///<summary>
		///<para> (0072,0206) Display Set Presentation Group Description </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint DisplaySetPresentationGroupDescription = 7471622;

		///<summary>
		///<para> (0072,0208) Partial Data Display Handling </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint PartialDataDisplayHandling = 7471624;

		///<summary>
		///<para> (0072,0210) Synchronized Scrolling Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint SynchronizedScrollingSequence = 7471632;

		///<summary>
		///<para> (0072,0212) Display Set Scrolling Group </para>
		///<para> VR: US VM=2-n </para>
		///</summary>
        public const uint DisplaySetScrollingGroup = 7471634;

		///<summary>
		///<para> (0072,0214) Navigation Indicator Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint NavigationIndicatorSequence = 7471636;

		///<summary>
		///<para> (0072,0216) Navigation Display Set </para>
		///<para> VR: US VM=1 </para>
		///</summary>
        public const uint NavigationDisplaySet = 7471638;

		///<summary>
		///<para> (0072,0218) Reference Display Sets </para>
		///<para> VR: US VM=1-n </para>
		///</summary>
        public const uint ReferenceDisplaySets = 7471640;

		///<summary>
		///<para> (0072,0300) Image Boxes Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint ImageBoxesSequence = 7471872;

		///<summary>
		///<para> (0072,0302) Image Box Number </para>
		///<para> VR: US VM=1 </para>
		///</summary>
        public const uint ImageBoxNumber = 7471874;

		///<summary>
		///<para> (0072,0304) Image Box Layout Type </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint ImageBoxLayoutType = 7471876;

		///<summary>
		///<para> (0072,0306) Image Box Tile Horizontal Dimension </para>
		///<para> VR: US VM=1 </para>
		///</summary>
        public const uint ImageBoxTileHorizontalDimension = 7471878;

		///<summary>
		///<para> (0072,0308) Image Box Tile Vertical Dimension </para>
		///<para> VR: US VM=1 </para>
		///</summary>
        public const uint ImageBoxTileVerticalDimension = 7471880;

		///<summary>
		///<para> (0072,0310) Image Box Scroll Direction </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint ImageBoxScrollDirection = 7471888;

		///<summary>
		///<para> (0072,0312) Image Box Small Scroll Type </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint ImageBoxSmallScrollType = 7471890;

		///<summary>
		///<para> (0072,0314) Image Box Small Scroll Amount </para>
		///<para> VR: US VM=1 </para>
		///</summary>
        public const uint ImageBoxSmallScrollAmount = 7471892;

		///<summary>
		///<para> (0072,0316) Image Box Large Scroll Type </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint ImageBoxLargeScrollType = 7471894;

		///<summary>
		///<para> (0072,0318) Image Box Large Scroll Amount </para>
		///<para> VR: US VM=1 </para>
		///</summary>
        public const uint ImageBoxLargeScrollAmount = 7471896;

		///<summary>
		///<para> (0072,0320) Image Box Overlap Priority </para>
		///<para> VR: US VM=1 </para>
		///</summary>
        public const uint ImageBoxOverlapPriority = 7471904;

		///<summary>
		///<para> (0072,0330) Cine Relative to Real-Time </para>
		///<para> VR: FD VM=1 </para>
		///</summary>
        public const uint CineRelativeToRealTime = 7471920;

		///<summary>
		///<para> (0072,0400) Filter Operations Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint FilterOperationsSequence = 7472128;

		///<summary>
		///<para> (0072,0402) Filter-by Category </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint FilterByCategory = 7472130;

		///<summary>
		///<para> (0072,0404) Filter-by Attribute Presence </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint FilterByAttributePresence = 7472132;

		///<summary>
		///<para> (0072,0406) Filter-by Operator </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint FilterByOperator = 7472134;

		///<summary>
		///<para> (0072,0420) Structured Display Background CIELab Value </para>
		///<para> VR: US VM=3 </para>
		///</summary>
        public const uint StructuredDisplayBackgroundCielabValue = 7472160;

		///<summary>
		///<para> (0072,0421) Empty Image Box CIELab Value </para>
		///<para> VR: US VM=3 </para>
		///</summary>
        public const uint EmptyImageBoxCielabValue = 7472161;

		///<summary>
		///<para> (0072,0422) Structured Display Image Box Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint StructuredDisplayImageBoxSequence = 7472162;

		///<summary>
		///<para> (0072,0424) Structured Display Text Box Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint StructuredDisplayTextBoxSequence = 7472164;

		///<summary>
		///<para> (0072,0427) Referenced First Frame Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint ReferencedFirstFrameSequence = 7472167;

		///<summary>
		///<para> (0072,0430) Image Box Synchronization Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint ImageBoxSynchronizationSequence = 7472176;

		///<summary>
		///<para> (0072,0432) Synchronized Image Box List </para>
		///<para> VR: US VM=2-n </para>
		///</summary>
        public const uint SynchronizedImageBoxList = 7472178;

		///<summary>
		///<para> (0072,0434) Type of Synchronization </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint TypeOfSynchronization = 7472180;

		///<summary>
		///<para> (0072,0500) Blending Operation Type </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint BlendingOperationType = 7472384;

		///<summary>
		///<para> (0072,0510) Reformatting Operation Type </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint ReformattingOperationType = 7472400;

		///<summary>
		///<para> (0072,0512) Reformatting Thickness </para>
		///<para> VR: FD VM=1 </para>
		///</summary>
        public const uint ReformattingThickness = 7472402;

		///<summary>
		///<para> (0072,0514) Reformatting Interval </para>
		///<para> VR: FD VM=1 </para>
		///</summary>
        public const uint ReformattingInterval = 7472404;

		///<summary>
		///<para> (0072,0516) Reformatting Operation Initial View Direction </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint ReformattingOperationInitialViewDirection = 7472406;

		///<summary>
		///<para> (0072,0520) 3D Rendering Type </para>
		///<para> VR: CS VM=1-n </para>
		///</summary>
        public const uint ThreeDRenderingType = 7472416;

		///<summary>
		///<para> (0072,0600) Sorting Operations Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint SortingOperationsSequence = 7472640;

		///<summary>
		///<para> (0072,0602) Sort-by Category </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint SortByCategory = 7472642;

		///<summary>
		///<para> (0072,0604) Sorting Direction </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint SortingDirection = 7472644;

		///<summary>
		///<para> (0072,0700) Display Set Patient Orientation </para>
		///<para> VR: CS VM=2 </para>
		///</summary>
        public const uint DisplaySetPatientOrientation = 7472896;

		///<summary>
		///<para> (0072,0702) VOI Type </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint VoiType = 7472898;

		///<summary>
		///<para> (0072,0704) Pseudo-Color Type </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint PseudoColorType = 7472900;

		///<summary>
		///<para> (0072,0705) Pseudo-Color Palette Instance Reference Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint PseudoColorPaletteInstanceReferenceSequence = 7472901;

		///<summary>
		///<para> (0072,0706) Show Grayscale Inverted </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint ShowGrayscaleInverted = 7472902;

		///<summary>
		///<para> (0072,0710) Show Image True Size Flag </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint ShowImageTrueSizeFlag = 7472912;

		///<summary>
		///<para> (0072,0712) Show Graphic Annotation Flag </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint ShowGraphicAnnotationFlag = 7472914;

		///<summary>
		///<para> (0072,0714) Show Patient Demographics Flag </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint ShowPatientDemographicsFlag = 7472916;

		///<summary>
		///<para> (0072,0716) Show Acquisition Techniques Flag </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint ShowAcquisitionTechniquesFlag = 7472918;

		///<summary>
		///<para> (0072,0717) Display Set Horizontal Justification </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint DisplaySetHorizontalJustification = 7472919;

		///<summary>
		///<para> (0072,0718) Display Set Vertical Justification </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint DisplaySetVerticalJustification = 7472920;

		///<summary>
		///<para> (0074,0120) Continuation Start Meterset </para>
		///<para> VR: FD VM=1 </para>
		///</summary>
        public const uint ContinuationStartMeterset = 7602464;

		///<summary>
		///<para> (0074,0121) Continuation End Meterset </para>
		///<para> VR: FD VM=1 </para>
		///</summary>
        public const uint ContinuationEndMeterset = 7602465;

		///<summary>
		///<para> (0074,1000) Procedure Step State </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint ProcedureStepState = 7606272;

		///<summary>
		///<para> (0074,1002) Procedure Step Progress Information Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint ProcedureStepProgressInformationSequence = 7606274;

		///<summary>
		///<para> (0074,1004) Procedure Step Progress </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint ProcedureStepProgress = 7606276;

		///<summary>
		///<para> (0074,1006) Procedure Step Progress Description </para>
		///<para> VR: ST VM=1 </para>
		///</summary>
        public const uint ProcedureStepProgressDescription = 7606278;

		///<summary>
		///<para> (0074,1008) Procedure Step Communications URI Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint ProcedureStepCommunicationsUriSequence = 7606280;

		///<summary>
		///<para> (0074,100A) Contact URI </para>
		///<para> VR: UR VM=1 </para>
		///</summary>
        public const uint ContactUri = 7606282;

		///<summary>
		///<para> (0074,100C) Contact Display Name </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint ContactDisplayName = 7606284;

		///<summary>
		///<para> (0074,100E) Procedure Step Discontinuation Reason Code Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint ProcedureStepDiscontinuationReasonCodeSequence = 7606286;

		///<summary>
		///<para> (0074,1020) Beam Task Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint BeamTaskSequence = 7606304;

		///<summary>
		///<para> (0074,1022) Beam Task Type </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint BeamTaskType = 7606306;

		///<summary>
		///<para> (0074,1024) Beam Order Index (Trial) (RETIRED) </para>
		///<para> VR: IS VM=1 </para>
		///</summary>
        public const uint BeamOrderIndexTrialRetired = 7606308;

		///<summary>
		///<para> (0074,1025) Autosequence Flag </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint AutosequenceFlag = 7606309;

		///<summary>
		///<para> (0074,1026) Table Top Vertical Adjusted Position </para>
		///<para> VR: FD VM=1 </para>
		///</summary>
        public const uint TableTopVerticalAdjustedPosition = 7606310;

		///<summary>
		///<para> (0074,1027) Table Top Longitudinal Adjusted Position </para>
		///<para> VR: FD VM=1 </para>
		///</summary>
        public const uint TableTopLongitudinalAdjustedPosition = 7606311;

		///<summary>
		///<para> (0074,1028) Table Top Lateral Adjusted Position </para>
		///<para> VR: FD VM=1 </para>
		///</summary>
        public const uint TableTopLateralAdjustedPosition = 7606312;

		///<summary>
		///<para> (0074,102A) Patient Support Adjusted Angle </para>
		///<para> VR: FD VM=1 </para>
		///</summary>
        public const uint PatientSupportAdjustedAngle = 7606314;

		///<summary>
		///<para> (0074,102B) Table Top Eccentric Adjusted Angle </para>
		///<para> VR: FD VM=1 </para>
		///</summary>
        public const uint TableTopEccentricAdjustedAngle = 7606315;

		///<summary>
		///<para> (0074,102C) Table Top Pitch Adjusted Angle </para>
		///<para> VR: FD VM=1 </para>
		///</summary>
        public const uint TableTopPitchAdjustedAngle = 7606316;

		///<summary>
		///<para> (0074,102D) Table Top Roll Adjusted Angle </para>
		///<para> VR: FD VM=1 </para>
		///</summary>
        public const uint TableTopRollAdjustedAngle = 7606317;

		///<summary>
		///<para> (0074,1030) Delivery Verification Image Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint DeliveryVerificationImageSequence = 7606320;

		///<summary>
		///<para> (0074,1032) Verification Image Timing </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint VerificationImageTiming = 7606322;

		///<summary>
		///<para> (0074,1034) Double Exposure Flag </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint DoubleExposureFlag = 7606324;

		///<summary>
		///<para> (0074,1036) Double Exposure Ordering </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint DoubleExposureOrdering = 7606326;

		///<summary>
		///<para> (0074,1038) Double Exposure Meterset (Trial) (RETIRED) </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint DoubleExposureMetersetTrialRetired = 7606328;

		///<summary>
		///<para> (0074,103A) Double Exposure Field Delta (Trial) (RETIRED) </para>
		///<para> VR: DS VM=4 </para>
		///</summary>
        public const uint DoubleExposureFieldDeltaTrialRetired = 7606330;

		///<summary>
		///<para> (0074,1040) Related Reference RT Image Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint RelatedReferenceRtImageSequence = 7606336;

		///<summary>
		///<para> (0074,1042) General Machine Verification Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint GeneralMachineVerificationSequence = 7606338;

		///<summary>
		///<para> (0074,1044) Conventional Machine Verification Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint ConventionalMachineVerificationSequence = 7606340;

		///<summary>
		///<para> (0074,1046) Ion Machine Verification Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint IonMachineVerificationSequence = 7606342;

		///<summary>
		///<para> (0074,1048) Failed Attributes Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint FailedAttributesSequence = 7606344;

		///<summary>
		///<para> (0074,104A) Overridden Attributes Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint OverriddenAttributesSequence = 7606346;

		///<summary>
		///<para> (0074,104C) Conventional Control Point Verification Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint ConventionalControlPointVerificationSequence = 7606348;

		///<summary>
		///<para> (0074,104E) Ion Control Point Verification Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint IonControlPointVerificationSequence = 7606350;

		///<summary>
		///<para> (0074,1050) Attribute Occurrence Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint AttributeOccurrenceSequence = 7606352;

		///<summary>
		///<para> (0074,1052) Attribute Occurrence Pointer </para>
		///<para> VR: AT VM=1 </para>
		///</summary>
        public const uint AttributeOccurrencePointer = 7606354;

		///<summary>
		///<para> (0074,1054) Attribute Item Selector </para>
		///<para> VR: UL VM=1 </para>
		///</summary>
        public const uint AttributeItemSelector = 7606356;

		///<summary>
		///<para> (0074,1056) Attribute Occurrence Private Creator </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint AttributeOccurrencePrivateCreator = 7606358;

		///<summary>
		///<para> (0074,1057) Selector Sequence Pointer Items </para>
		///<para> VR: IS VM=1-n </para>
		///</summary>
        public const uint SelectorSequencePointerItems = 7606359;

		///<summary>
		///<para> (0074,1200) Scheduled Procedure Step Priority </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint ScheduledProcedureStepPriority = 7606784;

		///<summary>
		///<para> (0074,1202) Worklist Label </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint WorklistLabel = 7606786;

		///<summary>
		///<para> (0074,1204) Procedure Step Label </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint ProcedureStepLabel = 7606788;

		///<summary>
		///<para> (0074,1210) Scheduled Processing Parameters Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint ScheduledProcessingParametersSequence = 7606800;

		///<summary>
		///<para> (0074,1212) Performed Processing Parameters Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint PerformedProcessingParametersSequence = 7606802;

		///<summary>
		///<para> (0074,1216) Unified Procedure Step Performed Procedure Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint UnifiedProcedureStepPerformedProcedureSequence = 7606806;

		///<summary>
		///<para> (0074,1220) Related Procedure Step Sequence (RETIRED) </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint RelatedProcedureStepSequenceRetired = 7606816;

		///<summary>
		///<para> (0074,1222) Procedure Step Relationship Type (RETIRED) </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint ProcedureStepRelationshipTypeRetired = 7606818;

		///<summary>
		///<para> (0074,1224) Replaced Procedure Step Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint ReplacedProcedureStepSequence = 7606820;

		///<summary>
		///<para> (0074,1230) Deletion Lock </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint DeletionLock = 7606832;

		///<summary>
		///<para> (0074,1234) Receiving AE </para>
		///<para> VR: AE VM=1 </para>
		///</summary>
        public const uint ReceivingAe = 7606836;

		///<summary>
		///<para> (0074,1236) Requesting AE </para>
		///<para> VR: AE VM=1 </para>
		///</summary>
        public const uint RequestingAe = 7606838;

		///<summary>
		///<para> (0074,1238) Reason for Cancellation </para>
		///<para> VR: LT VM=1 </para>
		///</summary>
        public const uint ReasonForCancellation = 7606840;

		///<summary>
		///<para> (0074,1242) SCP Status </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint ScpStatus = 7606850;

		///<summary>
		///<para> (0074,1244) Subscription List Status </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint SubscriptionListStatus = 7606852;

		///<summary>
		///<para> (0074,1246) Unified Procedure Step List Status </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint UnifiedProcedureStepListStatus = 7606854;

		///<summary>
		///<para> (0074,1324) Beam Order Index </para>
		///<para> VR: UL VM=1 </para>
		///</summary>
        public const uint BeamOrderIndex = 7607076;

		///<summary>
		///<para> (0074,1338) Double Exposure Meterset </para>
		///<para> VR: FD VM=1 </para>
		///</summary>
        public const uint DoubleExposureMeterset = 7607096;

		///<summary>
		///<para> (0074,133A) Double Exposure Field Delta </para>
		///<para> VR: FD VM=4 </para>
		///</summary>
        public const uint DoubleExposureFieldDelta = 7607098;

		///<summary>
		///<para> (0074,1401) Brachy Task Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint BrachyTaskSequence = 7607297;

		///<summary>
		///<para> (0074,1402) Continuation Start Total Reference Air Kerma </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint ContinuationStartTotalReferenceAirKerma = 7607298;

		///<summary>
		///<para> (0074,1403) Continuation End Total Reference Air Kerma </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint ContinuationEndTotalReferenceAirKerma = 7607299;

		///<summary>
		///<para> (0074,1404) Continuation Pulse Number </para>
		///<para> VR: IS VM=1 </para>
		///</summary>
        public const uint ContinuationPulseNumber = 7607300;

		///<summary>
		///<para> (0074,1405) Channel Delivery Order Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint ChannelDeliveryOrderSequence = 7607301;

		///<summary>
		///<para> (0074,1406) Referenced Channel Number </para>
		///<para> VR: IS VM=1 </para>
		///</summary>
        public const uint ReferencedChannelNumber = 7607302;

		///<summary>
		///<para> (0074,1407) Start Cumulative Time Weight </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint StartCumulativeTimeWeight = 7607303;

		///<summary>
		///<para> (0074,1408) End Cumulative Time Weight </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint EndCumulativeTimeWeight = 7607304;

		///<summary>
		///<para> (0074,1409) Omitted Channel Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint OmittedChannelSequence = 7607305;

		///<summary>
		///<para> (0074,140A) Reason for Channel Omission </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint ReasonForChannelOmission = 7607306;

		///<summary>
		///<para> (0074,140B) Reason for Channel Omission Description </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint ReasonForChannelOmissionDescription = 7607307;

		///<summary>
		///<para> (0074,140C) Channel Delivery Order Index </para>
		///<para> VR: IS VM=1 </para>
		///</summary>
        public const uint ChannelDeliveryOrderIndex = 7607308;

		///<summary>
		///<para> (0074,140D) Channel Delivery Continuation Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint ChannelDeliveryContinuationSequence = 7607309;

		///<summary>
		///<para> (0074,140E) Omitted Application Setup Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint OmittedApplicationSetupSequence = 7607310;

		///<summary>
		///<para> (0076,0001) Implant Assembly Template Name </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint ImplantAssemblyTemplateName = 7733249;

		///<summary>
		///<para> (0076,0003) Implant Assembly Template Issuer </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint ImplantAssemblyTemplateIssuer = 7733251;

		///<summary>
		///<para> (0076,0006) Implant Assembly Template Version </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint ImplantAssemblyTemplateVersion = 7733254;

		///<summary>
		///<para> (0076,0008) Replaced Implant Assembly Template Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint ReplacedImplantAssemblyTemplateSequence = 7733256;

		///<summary>
		///<para> (0076,000A) Implant Assembly Template Type </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint ImplantAssemblyTemplateType = 7733258;

		///<summary>
		///<para> (0076,000C) Original Implant Assembly Template Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint OriginalImplantAssemblyTemplateSequence = 7733260;

		///<summary>
		///<para> (0076,000E) Derivation Implant Assembly Template Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint DerivationImplantAssemblyTemplateSequence = 7733262;

		///<summary>
		///<para> (0076,0010) Implant Assembly Template Target Anatomy Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint ImplantAssemblyTemplateTargetAnatomySequence = 7733264;

		///<summary>
		///<para> (0076,0020) Procedure Type Code Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint ProcedureTypeCodeSequence = 7733280;

		///<summary>
		///<para> (0076,0030) Surgical Technique </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint SurgicalTechnique = 7733296;

		///<summary>
		///<para> (0076,0032) Component Types Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint ComponentTypesSequence = 7733298;

		///<summary>
		///<para> (0076,0034) Component Type Code Sequence </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint ComponentTypeCodeSequence = 7733300;

		///<summary>
		///<para> (0076,0036) Exclusive Component Type </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint ExclusiveComponentType = 7733302;

		///<summary>
		///<para> (0076,0038) Mandatory Component Type </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint MandatoryComponentType = 7733304;

		///<summary>
		///<para> (0076,0040) Component Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint ComponentSequence = 7733312;

		///<summary>
		///<para> (0076,0055) Component ID </para>
		///<para> VR: US VM=1 </para>
		///</summary>
        public const uint ComponentId = 7733333;

		///<summary>
		///<para> (0076,0060) Component Assembly Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint ComponentAssemblySequence = 7733344;

		///<summary>
		///<para> (0076,0070) Component 1 Referenced ID </para>
		///<para> VR: US VM=1 </para>
		///</summary>
        public const uint Component1ReferencedId = 7733360;

		///<summary>
		///<para> (0076,0080) Component 1 Referenced Mating Feature Set ID </para>
		///<para> VR: US VM=1 </para>
		///</summary>
        public const uint Component1ReferencedMatingFeatureSetId = 7733376;

		///<summary>
		///<para> (0076,0090) Component 1 Referenced Mating Feature ID </para>
		///<para> VR: US VM=1 </para>
		///</summary>
        public const uint Component1ReferencedMatingFeatureId = 7733392;

		///<summary>
		///<para> (0076,00A0) Component 2 Referenced ID </para>
		///<para> VR: US VM=1 </para>
		///</summary>
        public const uint Component2ReferencedId = 7733408;

		///<summary>
		///<para> (0076,00B0) Component 2 Referenced Mating Feature Set ID </para>
		///<para> VR: US VM=1 </para>
		///</summary>
        public const uint Component2ReferencedMatingFeatureSetId = 7733424;

		///<summary>
		///<para> (0076,00C0) Component 2 Referenced Mating Feature ID </para>
		///<para> VR: US VM=1 </para>
		///</summary>
        public const uint Component2ReferencedMatingFeatureId = 7733440;

		///<summary>
		///<para> (0078,0001) Implant Template Group Name </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint ImplantTemplateGroupName = 7864321;

		///<summary>
		///<para> (0078,0010) Implant Template Group Description </para>
		///<para> VR: ST VM=1 </para>
		///</summary>
        public const uint ImplantTemplateGroupDescription = 7864336;

		///<summary>
		///<para> (0078,0020) Implant Template Group Issuer </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint ImplantTemplateGroupIssuer = 7864352;

		///<summary>
		///<para> (0078,0024) Implant Template Group Version </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint ImplantTemplateGroupVersion = 7864356;

		///<summary>
		///<para> (0078,0026) Replaced Implant Template Group Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint ReplacedImplantTemplateGroupSequence = 7864358;

		///<summary>
		///<para> (0078,0028) Implant Template Group Target Anatomy Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint ImplantTemplateGroupTargetAnatomySequence = 7864360;

		///<summary>
		///<para> (0078,002A) Implant Template Group Members Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint ImplantTemplateGroupMembersSequence = 7864362;

		///<summary>
		///<para> (0078,002E) Implant Template Group Member ID </para>
		///<para> VR: US VM=1 </para>
		///</summary>
        public const uint ImplantTemplateGroupMemberId = 7864366;

		///<summary>
		///<para> (0078,0050) 3D Implant Template Group Member Matching Point </para>
		///<para> VR: FD VM=3 </para>
		///</summary>
        public const uint ThreeDImplantTemplateGroupMemberMatchingPoint = 7864400;

		///<summary>
		///<para> (0078,0060) 3D Implant Template Group Member Matching Axes </para>
		///<para> VR: FD VM=9 </para>
		///</summary>
        public const uint ThreeDImplantTemplateGroupMemberMatchingAxes = 7864416;

		///<summary>
		///<para> (0078,0070) Implant Template Group Member Matching 2D Coordinates Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint ImplantTemplateGroupMemberMatching2dCoordinatesSequence = 7864432;

		///<summary>
		///<para> (0078,0090) 2D Implant Template Group Member Matching Point </para>
		///<para> VR: FD VM=2 </para>
		///</summary>
        public const uint TwoDImplantTemplateGroupMemberMatchingPoint = 7864464;

		///<summary>
		///<para> (0078,00A0) 2D Implant Template Group Member Matching Axes </para>
		///<para> VR: FD VM=4 </para>
		///</summary>
        public const uint TwoDImplantTemplateGroupMemberMatchingAxes = 7864480;

		///<summary>
		///<para> (0078,00B0) Implant Template Group Variation Dimension Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint ImplantTemplateGroupVariationDimensionSequence = 7864496;

		///<summary>
		///<para> (0078,00B2) Implant Template Group Variation Dimension Name </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint ImplantTemplateGroupVariationDimensionName = 7864498;

		///<summary>
		///<para> (0078,00B4) Implant Template Group Variation Dimension Rank Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint ImplantTemplateGroupVariationDimensionRankSequence = 7864500;

		///<summary>
		///<para> (0078,00B6) Referenced Implant Template Group Member ID </para>
		///<para> VR: US VM=1 </para>
		///</summary>
        public const uint ReferencedImplantTemplateGroupMemberId = 7864502;

		///<summary>
		///<para> (0078,00B8) Implant Template Group Variation Dimension Rank </para>
		///<para> VR: US VM=1 </para>
		///</summary>
        public const uint ImplantTemplateGroupVariationDimensionRank = 7864504;

		///<summary>
		///<para> (0080,0001) Surface Scan Acquisition Type Code Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint SurfaceScanAcquisitionTypeCodeSequence = 8388609;

		///<summary>
		///<para> (0080,0002) Surface Scan Mode Code Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint SurfaceScanModeCodeSequence = 8388610;

		///<summary>
		///<para> (0080,0003) Registration Method Code Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint RegistrationMethodCodeSequence = 8388611;

		///<summary>
		///<para> (0080,0004) Shot Duration Time </para>
		///<para> VR: FD VM=1 </para>
		///</summary>
        public const uint ShotDurationTime = 8388612;

		///<summary>
		///<para> (0080,0005) Shot Offset Time </para>
		///<para> VR: FD VM=1 </para>
		///</summary>
        public const uint ShotOffsetTime = 8388613;

		///<summary>
		///<para> (0080,0006) Surface Point Presentation Value Data </para>
		///<para> VR: US VM=1-n </para>
		///</summary>
        public const uint SurfacePointPresentationValueData = 8388614;

		///<summary>
		///<para> (0080,0007) Surface Point Color CIELab Value Data </para>
		///<para> VR: US VM=3-3n </para>
		///</summary>
        public const uint SurfacePointColorCielabValueData = 8388615;

		///<summary>
		///<para> (0080,0008) UV Mapping Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint UvMappingSequence = 8388616;

		///<summary>
		///<para> (0080,0009) Texture Label </para>
		///<para> VR: SH VM=1 </para>
		///</summary>
        public const uint TextureLabel = 8388617;

		///<summary>
		///<para> (0080,0010) U Value Data </para>
		///<para> VR: OF VM=1-n </para>
		///</summary>
        public const uint UValueData = 8388624;

		///<summary>
		///<para> (0080,0011) V Value Data </para>
		///<para> VR: OF VM=1-n </para>
		///</summary>
        public const uint VValueData = 8388625;

		///<summary>
		///<para> (0080,0012) Referenced Texture Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint ReferencedTextureSequence = 8388626;

		///<summary>
		///<para> (0080,0013) Referenced Surface Data Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint ReferencedSurfaceDataSequence = 8388627;

		///<summary>
		///<para> (0082,0001) Assessment Summary </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint AssessmentSummary = 8519681;

		///<summary>
		///<para> (0082,0003) Assessment Summary Description </para>
		///<para> VR: UT VM=1 </para>
		///</summary>
        public const uint AssessmentSummaryDescription = 8519683;

		///<summary>
		///<para> (0082,0004) Assessed SOP Instance Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint AssessedSopInstanceSequence = 8519684;

		///<summary>
		///<para> (0082,0005) Referenced Comparison SOP Instance Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint ReferencedComparisonSopInstanceSequence = 8519685;

		///<summary>
		///<para> (0082,0006) Number of Assessment Observations </para>
		///<para> VR: UL VM=1 </para>
		///</summary>
        public const uint NumberOfAssessmentObservations = 8519686;

		///<summary>
		///<para> (0082,0007) Assessment Observations Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint AssessmentObservationsSequence = 8519687;

		///<summary>
		///<para> (0082,0008) Observation Significance </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint ObservationSignificance = 8519688;

		///<summary>
		///<para> (0082,000A) Observation Description </para>
		///<para> VR: UT VM=1 </para>
		///</summary>
        public const uint ObservationDescription = 8519690;

		///<summary>
		///<para> (0082,000C) Structured Constraint Observation Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint StructuredConstraintObservationSequence = 8519692;

		///<summary>
		///<para> (0082,0010) Assessed Attribute Value Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint AssessedAttributeValueSequence = 8519696;

		///<summary>
		///<para> (0082,0016) Assessment Set ID </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint AssessmentSetId = 8519702;

		///<summary>
		///<para> (0082,0017) Assessment Requester Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint AssessmentRequesterSequence = 8519703;

		///<summary>
		///<para> (0082,0018) Selector Attribute Name </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint SelectorAttributeName = 8519704;

		///<summary>
		///<para> (0082,0019) Selector Attribute Keyword </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint SelectorAttributeKeyword = 8519705;

		///<summary>
		///<para> (0082,0021) Assessment Type Code Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint AssessmentTypeCodeSequence = 8519713;

		///<summary>
		///<para> (0082,0022) Observation Basis Code Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint ObservationBasisCodeSequence = 8519714;

		///<summary>
		///<para> (0082,0023) Assessment Label </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint AssessmentLabel = 8519715;

		///<summary>
		///<para> (0082,0032) Constraint Type </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint ConstraintType = 8519730;

		///<summary>
		///<para> (0082,0033) Specification Selection Guidance </para>
		///<para> VR: UT VM=1 </para>
		///</summary>
        public const uint SpecificationSelectionGuidance = 8519731;

		///<summary>
		///<para> (0082,0034) Constraint Value Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint ConstraintValueSequence = 8519732;

		///<summary>
		///<para> (0082,0035) Recommended Default Value Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint RecommendedDefaultValueSequence = 8519733;

		///<summary>
		///<para> (0082,0036) Constraint Violation Significance </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint ConstraintViolationSignificance = 8519734;

		///<summary>
		///<para> (0082,0037) Constraint Violation Condition </para>
		///<para> VR: UT VM=1 </para>
		///</summary>
        public const uint ConstraintViolationCondition = 8519735;

		///<summary>
		///<para> (0082,0038) Modifiable Constraint Flag </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint ModifiableConstraintFlag = 8519736;

		///<summary>
		///<para> (0088,0130) Storage Media File-set ID </para>
		///<para> VR: SH VM=1 </para>
		///</summary>
        public const uint StorageMediaFileSetId = 8913200;

		///<summary>
		///<para> (0088,0140) Storage Media File-set UID </para>
		///<para> VR: UI VM=1 </para>
		///</summary>
        public const uint StorageMediaFileSetUid = 8913216;

		///<summary>
		///<para> (0088,0200) Icon Image Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint IconImageSequence = 8913408;

		///<summary>
		///<para> (0088,0904) Topic Title (RETIRED) </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint TopicTitleRetired = 8915204;

		///<summary>
		///<para> (0088,0906) Topic Subject (RETIRED) </para>
		///<para> VR: ST VM=1 </para>
		///</summary>
        public const uint TopicSubjectRetired = 8915206;

		///<summary>
		///<para> (0088,0910) Topic Author (RETIRED) </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint TopicAuthorRetired = 8915216;

		///<summary>
		///<para> (0088,0912) Topic Keywords (RETIRED) </para>
		///<para> VR: LO VM=1-32 </para>
		///</summary>
        public const uint TopicKeywordsRetired = 8915218;

		///<summary>
		///<para> (0100,0410) SOP Instance Status </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint SopInstanceStatus = 16778256;

		///<summary>
		///<para> (0100,0420) SOP Authorization DateTime </para>
		///<para> VR: DT VM=1 </para>
		///</summary>
        public const uint SopAuthorizationDatetime = 16778272;

		///<summary>
		///<para> (0100,0424) SOP Authorization Comment </para>
		///<para> VR: LT VM=1 </para>
		///</summary>
        public const uint SopAuthorizationComment = 16778276;

		///<summary>
		///<para> (0100,0426) Authorization Equipment Certification Number </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint AuthorizationEquipmentCertificationNumber = 16778278;

		///<summary>
		///<para> (0400,0005) MAC ID Number </para>
		///<para> VR: US VM=1 </para>
		///</summary>
        public const uint MacIdNumber = 67108869;

		///<summary>
		///<para> (0400,0010) MAC Calculation Transfer Syntax UID </para>
		///<para> VR: UI VM=1 </para>
		///</summary>
        public const uint MacCalculationTransferSyntaxUid = 67108880;

		///<summary>
		///<para> (0400,0015) MAC Algorithm </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint MacAlgorithm = 67108885;

		///<summary>
		///<para> (0400,0020) Data Elements Signed </para>
		///<para> VR: AT VM=1-n </para>
		///</summary>
        public const uint DataElementsSigned = 67108896;

		///<summary>
		///<para> (0400,0100) Digital Signature UID </para>
		///<para> VR: UI VM=1 </para>
		///</summary>
        public const uint DigitalSignatureUid = 67109120;

		///<summary>
		///<para> (0400,0105) Digital Signature DateTime </para>
		///<para> VR: DT VM=1 </para>
		///</summary>
        public const uint DigitalSignatureDatetime = 67109125;

		///<summary>
		///<para> (0400,0110) Certificate Type </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint CertificateType = 67109136;

		///<summary>
		///<para> (0400,0115) Certificate of Signer </para>
		///<para> VR: OB VM=1 </para>
		///</summary>
        public const uint CertificateOfSigner = 67109141;

		///<summary>
		///<para> (0400,0120) Signature </para>
		///<para> VR: OB VM=1 </para>
		///</summary>
        public const uint Signature = 67109152;

		///<summary>
		///<para> (0400,0305) Certified Timestamp Type </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint CertifiedTimestampType = 67109637;

		///<summary>
		///<para> (0400,0310) Certified Timestamp </para>
		///<para> VR: OB VM=1 </para>
		///</summary>
        public const uint CertifiedTimestamp = 67109648;

		///<summary>
		///<para> (0400,0401) Digital Signature Purpose Code Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint DigitalSignaturePurposeCodeSequence = 67109889;

		///<summary>
		///<para> (0400,0402) Referenced Digital Signature Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint ReferencedDigitalSignatureSequence = 67109890;

		///<summary>
		///<para> (0400,0403) Referenced SOP Instance MAC Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint ReferencedSopInstanceMacSequence = 67109891;

		///<summary>
		///<para> (0400,0404) MAC </para>
		///<para> VR: OB VM=1 </para>
		///</summary>
        public const uint Mac = 67109892;

		///<summary>
		///<para> (0400,0500) Encrypted Attributes Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint EncryptedAttributesSequence = 67110144;

		///<summary>
		///<para> (0400,0510) Encrypted Content Transfer Syntax UID </para>
		///<para> VR: UI VM=1 </para>
		///</summary>
        public const uint EncryptedContentTransferSyntaxUid = 67110160;

		///<summary>
		///<para> (0400,0520) Encrypted Content </para>
		///<para> VR: OB VM=1 </para>
		///</summary>
        public const uint EncryptedContent = 67110176;

		///<summary>
		///<para> (0400,0550) Modified Attributes Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint ModifiedAttributesSequence = 67110224;

		///<summary>
		///<para> (0400,0561) Original Attributes Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint OriginalAttributesSequence = 67110241;

		///<summary>
		///<para> (0400,0562) Attribute Modification DateTime </para>
		///<para> VR: DT VM=1 </para>
		///</summary>
        public const uint AttributeModificationDatetime = 67110242;

		///<summary>
		///<para> (0400,0563) Modifying System </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint ModifyingSystem = 67110243;

		///<summary>
		///<para> (0400,0564) Source of Previous Values </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint SourceOfPreviousValues = 67110244;

		///<summary>
		///<para> (0400,0565) Reason for the Attribute Modification </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint ReasonForTheAttributeModification = 67110245;

		///<summary>
		///<para> (1000,xxx0) Escape Triplet (RETIRED) </para>
		///<para> VR: US VM=3 </para>
		///</summary>
        public const uint EscapeTripletRetired = 268435456;

		///<summary>
		///<para> (1000,xxx1) Run Length Triplet (RETIRED) </para>
		///<para> VR: US VM=3 </para>
		///</summary>
        public const uint RunLengthTripletRetired = 268435457;

		///<summary>
		///<para> (1000,xxx2) Huffman Table Size (RETIRED) </para>
		///<para> VR: US VM=1 </para>
		///</summary>
        public const uint HuffmanTableSizeRetired = 268435458;

		///<summary>
		///<para> (1000,xxx3) Huffman Table Triplet (RETIRED) </para>
		///<para> VR: US VM=3 </para>
		///</summary>
        public const uint HuffmanTableTripletRetired = 268435459;

		///<summary>
		///<para> (1000,xxx4) Shift Table Size (RETIRED) </para>
		///<para> VR: US VM=1 </para>
		///</summary>
        public const uint ShiftTableSizeRetired = 268435460;

		///<summary>
		///<para> (1000,xxx5) Shift Table Triplet (RETIRED) </para>
		///<para> VR: US VM=3 </para>
		///</summary>
        public const uint ShiftTableTripletRetired = 268435461;

		///<summary>
		///<para> (1010,xxxx) Zonal Map (RETIRED) </para>
		///<para> VR: US VM=1-n </para>
		///</summary>
        public const uint ZonalMapRetired = 269484032;

		///<summary>
		///<para> (2000,0010) Number of Copies </para>
		///<para> VR: IS VM=1 </para>
		///</summary>
        public const uint NumberOfCopies = 536870928;

		///<summary>
		///<para> (2000,001E) Printer Configuration Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint PrinterConfigurationSequence = 536870942;

		///<summary>
		///<para> (2000,0020) Print Priority </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint PrintPriority = 536870944;

		///<summary>
		///<para> (2000,0030) Medium Type </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint MediumType = 536870960;

		///<summary>
		///<para> (2000,0040) Film Destination </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint FilmDestination = 536870976;

		///<summary>
		///<para> (2000,0050) Film Session Label </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint FilmSessionLabel = 536870992;

		///<summary>
		///<para> (2000,0060) Memory Allocation </para>
		///<para> VR: IS VM=1 </para>
		///</summary>
        public const uint MemoryAllocation = 536871008;

		///<summary>
		///<para> (2000,0061) Maximum Memory Allocation </para>
		///<para> VR: IS VM=1 </para>
		///</summary>
        public const uint MaximumMemoryAllocation = 536871009;

		///<summary>
		///<para> (2000,0062) Color Image Printing Flag (RETIRED) </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint ColorImagePrintingFlagRetired = 536871010;

		///<summary>
		///<para> (2000,0063) Collation Flag (RETIRED) </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint CollationFlagRetired = 536871011;

		///<summary>
		///<para> (2000,0065) Annotation Flag (RETIRED) </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint AnnotationFlagRetired = 536871013;

		///<summary>
		///<para> (2000,0067) Image Overlay Flag (RETIRED) </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint ImageOverlayFlagRetired = 536871015;

		///<summary>
		///<para> (2000,0069) Presentation LUT Flag (RETIRED) </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint PresentationLutFlagRetired = 536871017;

		///<summary>
		///<para> (2000,006A) Image Box Presentation LUT Flag (RETIRED) </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint ImageBoxPresentationLutFlagRetired = 536871018;

		///<summary>
		///<para> (2000,00A0) Memory Bit Depth </para>
		///<para> VR: US VM=1 </para>
		///</summary>
        public const uint MemoryBitDepth = 536871072;

		///<summary>
		///<para> (2000,00A1) Printing Bit Depth </para>
		///<para> VR: US VM=1 </para>
		///</summary>
        public const uint PrintingBitDepth = 536871073;

		///<summary>
		///<para> (2000,00A2) Media Installed Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint MediaInstalledSequence = 536871074;

		///<summary>
		///<para> (2000,00A4) Other Media Available Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint OtherMediaAvailableSequence = 536871076;

		///<summary>
		///<para> (2000,00A8) Supported Image Display Formats Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint SupportedImageDisplayFormatsSequence = 536871080;

		///<summary>
		///<para> (2000,0500) Referenced Film Box Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint ReferencedFilmBoxSequence = 536872192;

		///<summary>
		///<para> (2000,0510) Referenced Stored Print Sequence (RETIRED) </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint ReferencedStoredPrintSequenceRetired = 536872208;

		///<summary>
		///<para> (2010,0010) Image Display Format </para>
		///<para> VR: ST VM=1 </para>
		///</summary>
        public const uint ImageDisplayFormat = 537919504;

		///<summary>
		///<para> (2010,0030) Annotation Display Format ID </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint AnnotationDisplayFormatId = 537919536;

		///<summary>
		///<para> (2010,0040) Film Orientation </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint FilmOrientation = 537919552;

		///<summary>
		///<para> (2010,0050) Film Size ID </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint FilmSizeId = 537919568;

		///<summary>
		///<para> (2010,0052) Printer Resolution ID </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint PrinterResolutionId = 537919570;

		///<summary>
		///<para> (2010,0054) Default Printer Resolution ID </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint DefaultPrinterResolutionId = 537919572;

		///<summary>
		///<para> (2010,0060) Magnification Type </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint MagnificationType = 537919584;

		///<summary>
		///<para> (2010,0080) Smoothing Type </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint SmoothingType = 537919616;

		///<summary>
		///<para> (2010,00A6) Default Magnification Type </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint DefaultMagnificationType = 537919654;

		///<summary>
		///<para> (2010,00A7) Other Magnification Types Available </para>
		///<para> VR: CS VM=1-n </para>
		///</summary>
        public const uint OtherMagnificationTypesAvailable = 537919655;

		///<summary>
		///<para> (2010,00A8) Default Smoothing Type </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint DefaultSmoothingType = 537919656;

		///<summary>
		///<para> (2010,00A9) Other Smoothing Types Available </para>
		///<para> VR: CS VM=1-n </para>
		///</summary>
        public const uint OtherSmoothingTypesAvailable = 537919657;

		///<summary>
		///<para> (2010,0100) Border Density </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint BorderDensity = 537919744;

		///<summary>
		///<para> (2010,0110) Empty Image Density </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint EmptyImageDensity = 537919760;

		///<summary>
		///<para> (2010,0120) Min Density </para>
		///<para> VR: US VM=1 </para>
		///</summary>
        public const uint MinDensity = 537919776;

		///<summary>
		///<para> (2010,0130) Max Density </para>
		///<para> VR: US VM=1 </para>
		///</summary>
        public const uint MaxDensity = 537919792;

		///<summary>
		///<para> (2010,0140) Trim </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint Trim = 537919808;

		///<summary>
		///<para> (2010,0150) Configuration Information </para>
		///<para> VR: ST VM=1 </para>
		///</summary>
        public const uint ConfigurationInformation = 537919824;

		///<summary>
		///<para> (2010,0152) Configuration Information Description </para>
		///<para> VR: LT VM=1 </para>
		///</summary>
        public const uint ConfigurationInformationDescription = 537919826;

		///<summary>
		///<para> (2010,0154) Maximum Collated Films </para>
		///<para> VR: IS VM=1 </para>
		///</summary>
        public const uint MaximumCollatedFilms = 537919828;

		///<summary>
		///<para> (2010,015E) Illumination </para>
		///<para> VR: US VM=1 </para>
		///</summary>
        public const uint Illumination = 537919838;

		///<summary>
		///<para> (2010,0160) Reflected Ambient Light </para>
		///<para> VR: US VM=1 </para>
		///</summary>
        public const uint ReflectedAmbientLight = 537919840;

		///<summary>
		///<para> (2010,0376) Printer Pixel Spacing </para>
		///<para> VR: DS VM=2 </para>
		///</summary>
        public const uint PrinterPixelSpacing = 537920374;

		///<summary>
		///<para> (2010,0500) Referenced Film Session Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint ReferencedFilmSessionSequence = 537920768;

		///<summary>
		///<para> (2010,0510) Referenced Image Box Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint ReferencedImageBoxSequence = 537920784;

		///<summary>
		///<para> (2010,0520) Referenced Basic Annotation Box Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint ReferencedBasicAnnotationBoxSequence = 537920800;

		///<summary>
		///<para> (2020,0010) Image Box Position </para>
		///<para> VR: US VM=1 </para>
		///</summary>
        public const uint ImageBoxPosition = 538968080;

		///<summary>
		///<para> (2020,0020) Polarity </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint Polarity = 538968096;

		///<summary>
		///<para> (2020,0030) Requested Image Size </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint RequestedImageSize = 538968112;

		///<summary>
		///<para> (2020,0040) Requested Decimate/Crop Behavior </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint RequestedDecimateCropBehavior = 538968128;

		///<summary>
		///<para> (2020,0050) Requested Resolution ID </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint RequestedResolutionId = 538968144;

		///<summary>
		///<para> (2020,00A0) Requested Image Size Flag </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint RequestedImageSizeFlag = 538968224;

		///<summary>
		///<para> (2020,00A2) Decimate/Crop Result </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint DecimateCropResult = 538968226;

		///<summary>
		///<para> (2020,0110) Basic Grayscale Image Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint BasicGrayscaleImageSequence = 538968336;

		///<summary>
		///<para> (2020,0111) Basic Color Image Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint BasicColorImageSequence = 538968337;

		///<summary>
		///<para> (2020,0130) Referenced Image Overlay Box Sequence (RETIRED) </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint ReferencedImageOverlayBoxSequenceRetired = 538968368;

		///<summary>
		///<para> (2020,0140) Referenced VOI LUT Box Sequence (RETIRED) </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint ReferencedVoiLutBoxSequenceRetired = 538968384;

		///<summary>
		///<para> (2030,0010) Annotation Position </para>
		///<para> VR: US VM=1 </para>
		///</summary>
        public const uint AnnotationPosition = 540016656;

		///<summary>
		///<para> (2030,0020) Text String </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint TextString = 540016672;

		///<summary>
		///<para> (2040,0010) Referenced Overlay Plane Sequence (RETIRED) </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint ReferencedOverlayPlaneSequenceRetired = 541065232;

		///<summary>
		///<para> (2040,0011) Referenced Overlay Plane Groups (RETIRED) </para>
		///<para> VR: US VM=1-99 </para>
		///</summary>
        public const uint ReferencedOverlayPlaneGroupsRetired = 541065233;

		///<summary>
		///<para> (2040,0020) Overlay Pixel Data Sequence (RETIRED) </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint OverlayPixelDataSequenceRetired = 541065248;

		///<summary>
		///<para> (2040,0060) Overlay Magnification Type (RETIRED) </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint OverlayMagnificationTypeRetired = 541065312;

		///<summary>
		///<para> (2040,0070) Overlay Smoothing Type (RETIRED) </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint OverlaySmoothingTypeRetired = 541065328;

		///<summary>
		///<para> (2040,0072) Overlay or Image Magnification (RETIRED) </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint OverlayOrImageMagnificationRetired = 541065330;

		///<summary>
		///<para> (2040,0074) Magnify to Number of Columns (RETIRED) </para>
		///<para> VR: US VM=1 </para>
		///</summary>
        public const uint MagnifyToNumberOfColumnsRetired = 541065332;

		///<summary>
		///<para> (2040,0080) Overlay Foreground Density (RETIRED) </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint OverlayForegroundDensityRetired = 541065344;

		///<summary>
		///<para> (2040,0082) Overlay Background Density (RETIRED) </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint OverlayBackgroundDensityRetired = 541065346;

		///<summary>
		///<para> (2040,0090) Overlay Mode (RETIRED) </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint OverlayModeRetired = 541065360;

		///<summary>
		///<para> (2040,0100) Threshold Density (RETIRED) </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint ThresholdDensityRetired = 541065472;

		///<summary>
		///<para> (2040,0500) Referenced Image Box Sequence (Retired) (RETIRED) </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint ReferencedImageBoxSequenceRetiredRetired = 541066496;

		///<summary>
		///<para> (2050,0010) Presentation LUT Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint PresentationLutSequence = 542113808;

		///<summary>
		///<para> (2050,0020) Presentation LUT Shape </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint PresentationLutShape = 542113824;

		///<summary>
		///<para> (2050,0500) Referenced Presentation LUT Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint ReferencedPresentationLutSequence = 542115072;

		///<summary>
		///<para> (2100,0010) Print Job ID (RETIRED) </para>
		///<para> VR: SH VM=1 </para>
		///</summary>
        public const uint PrintJobIdRetired = 553648144;

		///<summary>
		///<para> (2100,0020) Execution Status </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint ExecutionStatus = 553648160;

		///<summary>
		///<para> (2100,0030) Execution Status Info </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint ExecutionStatusInfo = 553648176;

		///<summary>
		///<para> (2100,0040) Creation Date </para>
		///<para> VR: DA VM=1 </para>
		///</summary>
        public const uint CreationDate = 553648192;

		///<summary>
		///<para> (2100,0050) Creation Time </para>
		///<para> VR: TM VM=1 </para>
		///</summary>
        public const uint CreationTime = 553648208;

		///<summary>
		///<para> (2100,0070) Originator </para>
		///<para> VR: AE VM=1 </para>
		///</summary>
        public const uint Originator = 553648240;

		///<summary>
		///<para> (2100,0140) Destination AE </para>
		///<para> VR: AE VM=1 </para>
		///</summary>
        public const uint DestinationAe = 553648448;

		///<summary>
		///<para> (2100,0160) Owner ID </para>
		///<para> VR: SH VM=1 </para>
		///</summary>
        public const uint OwnerId = 553648480;

		///<summary>
		///<para> (2100,0170) Number of Films </para>
		///<para> VR: IS VM=1 </para>
		///</summary>
        public const uint NumberOfFilms = 553648496;

		///<summary>
		///<para> (2100,0500) Referenced Print Job Sequence (Pull Stored Print) (RETIRED) </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint ReferencedPrintJobSequencePullStoredPrintRetired = 553649408;

		///<summary>
		///<para> (2110,0010) Printer Status </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint PrinterStatus = 554696720;

		///<summary>
		///<para> (2110,0020) Printer Status Info </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint PrinterStatusInfo = 554696736;

		///<summary>
		///<para> (2110,0030) Printer Name </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint PrinterName = 554696752;

		///<summary>
		///<para> (2110,0099) Print Queue ID (RETIRED) </para>
		///<para> VR: SH VM=1 </para>
		///</summary>
        public const uint PrintQueueIdRetired = 554696857;

		///<summary>
		///<para> (2120,0010) Queue Status (RETIRED) </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint QueueStatusRetired = 555745296;

		///<summary>
		///<para> (2120,0050) Print Job Description Sequence (RETIRED) </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint PrintJobDescriptionSequenceRetired = 555745360;

		///<summary>
		///<para> (2120,0070) Referenced Print Job Sequence (RETIRED) </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint ReferencedPrintJobSequenceRetired = 555745392;

		///<summary>
		///<para> (2130,0010) Print Management Capabilities Sequence (RETIRED) </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint PrintManagementCapabilitiesSequenceRetired = 556793872;

		///<summary>
		///<para> (2130,0015) Printer Characteristics Sequence (RETIRED) </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint PrinterCharacteristicsSequenceRetired = 556793877;

		///<summary>
		///<para> (2130,0030) Film Box Content Sequence (RETIRED) </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint FilmBoxContentSequenceRetired = 556793904;

		///<summary>
		///<para> (2130,0040) Image Box Content Sequence (RETIRED) </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint ImageBoxContentSequenceRetired = 556793920;

		///<summary>
		///<para> (2130,0050) Annotation Content Sequence (RETIRED) </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint AnnotationContentSequenceRetired = 556793936;

		///<summary>
		///<para> (2130,0060) Image Overlay Box Content Sequence (RETIRED) </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint ImageOverlayBoxContentSequenceRetired = 556793952;

		///<summary>
		///<para> (2130,0080) Presentation LUT Content Sequence (RETIRED) </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint PresentationLutContentSequenceRetired = 556793984;

		///<summary>
		///<para> (2130,00A0) Proposed Study Sequence (RETIRED) </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint ProposedStudySequenceRetired = 556794016;

		///<summary>
		///<para> (2130,00C0) Original Image Sequence (RETIRED) </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint OriginalImageSequenceRetired = 556794048;

		///<summary>
		///<para> (2200,0001) Label Using Information Extracted From Instances </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint LabelUsingInformationExtractedFromInstances = 570425345;

		///<summary>
		///<para> (2200,0002) Label Text </para>
		///<para> VR: UT VM=1 </para>
		///</summary>
        public const uint LabelText = 570425346;

		///<summary>
		///<para> (2200,0003) Label Style Selection </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint LabelStyleSelection = 570425347;

		///<summary>
		///<para> (2200,0004) Media Disposition </para>
		///<para> VR: LT VM=1 </para>
		///</summary>
        public const uint MediaDisposition = 570425348;

		///<summary>
		///<para> (2200,0005) Barcode Value </para>
		///<para> VR: LT VM=1 </para>
		///</summary>
        public const uint BarcodeValue = 570425349;

		///<summary>
		///<para> (2200,0006) Barcode Symbology </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint BarcodeSymbology = 570425350;

		///<summary>
		///<para> (2200,0007) Allow Media Splitting </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint AllowMediaSplitting = 570425351;

		///<summary>
		///<para> (2200,0008) Include Non-DICOM Objects </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint IncludeNonDicomObjects = 570425352;

		///<summary>
		///<para> (2200,0009) Include Display Application </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint IncludeDisplayApplication = 570425353;

		///<summary>
		///<para> (2200,000A) Preserve Composite Instances After Media Creation </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint PreserveCompositeInstancesAfterMediaCreation = 570425354;

		///<summary>
		///<para> (2200,000B) Total Number of Pieces of Media Created </para>
		///<para> VR: US VM=1 </para>
		///</summary>
        public const uint TotalNumberOfPiecesOfMediaCreated = 570425355;

		///<summary>
		///<para> (2200,000C) Requested Media Application Profile </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint RequestedMediaApplicationProfile = 570425356;

		///<summary>
		///<para> (2200,000D) Referenced Storage Media Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint ReferencedStorageMediaSequence = 570425357;

		///<summary>
		///<para> (2200,000E) Failure Attributes </para>
		///<para> VR: AT VM=1-n </para>
		///</summary>
        public const uint FailureAttributes = 570425358;

		///<summary>
		///<para> (2200,000F) Allow Lossy Compression </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint AllowLossyCompression = 570425359;

		///<summary>
		///<para> (2200,0020) Request Priority </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint RequestPriority = 570425376;

		///<summary>
		///<para> (3002,0002) RT Image Label </para>
		///<para> VR: SH VM=1 </para>
		///</summary>
        public const uint RtImageLabel = 805437442;

		///<summary>
		///<para> (3002,0003) RT Image Name </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint RtImageName = 805437443;

		///<summary>
		///<para> (3002,0004) RT Image Description </para>
		///<para> VR: ST VM=1 </para>
		///</summary>
        public const uint RtImageDescription = 805437444;

		///<summary>
		///<para> (3002,000A) Reported Values Origin </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint ReportedValuesOrigin = 805437450;

		///<summary>
		///<para> (3002,000C) RT Image Plane </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint RtImagePlane = 805437452;

		///<summary>
		///<para> (3002,000D) X-Ray Image Receptor Translation </para>
		///<para> VR: DS VM=3 </para>
		///</summary>
        public const uint XRayImageReceptorTranslation = 805437453;

		///<summary>
		///<para> (3002,000E) X-Ray Image Receptor Angle </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint XRayImageReceptorAngle = 805437454;

		///<summary>
		///<para> (3002,0010) RT Image Orientation </para>
		///<para> VR: DS VM=6 </para>
		///</summary>
        public const uint RtImageOrientation = 805437456;

		///<summary>
		///<para> (3002,0011) Image Plane Pixel Spacing </para>
		///<para> VR: DS VM=2 </para>
		///</summary>
        public const uint ImagePlanePixelSpacing = 805437457;

		///<summary>
		///<para> (3002,0012) RT Image Position </para>
		///<para> VR: DS VM=2 </para>
		///</summary>
        public const uint RtImagePosition = 805437458;

		///<summary>
		///<para> (3002,0020) Radiation Machine Name </para>
		///<para> VR: SH VM=1 </para>
		///</summary>
        public const uint RadiationMachineName = 805437472;

		///<summary>
		///<para> (3002,0022) Radiation Machine SAD </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint RadiationMachineSad = 805437474;

		///<summary>
		///<para> (3002,0024) Radiation Machine SSD </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint RadiationMachineSsd = 805437476;

		///<summary>
		///<para> (3002,0026) RT Image SID </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint RtImageSid = 805437478;

		///<summary>
		///<para> (3002,0028) Source to Reference Object Distance </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint SourceToReferenceObjectDistance = 805437480;

		///<summary>
		///<para> (3002,0029) Fraction Number </para>
		///<para> VR: IS VM=1 </para>
		///</summary>
        public const uint FractionNumber = 805437481;

		///<summary>
		///<para> (3002,0030) Exposure Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint ExposureSequence = 805437488;

		///<summary>
		///<para> (3002,0032) Meterset Exposure </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint MetersetExposure = 805437490;

		///<summary>
		///<para> (3002,0034) Diaphragm Position </para>
		///<para> VR: DS VM=4 </para>
		///</summary>
        public const uint DiaphragmPosition = 805437492;

		///<summary>
		///<para> (3002,0040) Fluence Map Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint FluenceMapSequence = 805437504;

		///<summary>
		///<para> (3002,0041) Fluence Data Source </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint FluenceDataSource = 805437505;

		///<summary>
		///<para> (3002,0042) Fluence Data Scale </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint FluenceDataScale = 805437506;

		///<summary>
		///<para> (3002,0050) Primary Fluence Mode Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint PrimaryFluenceModeSequence = 805437520;

		///<summary>
		///<para> (3002,0051) Fluence Mode </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint FluenceMode = 805437521;

		///<summary>
		///<para> (3002,0052) Fluence Mode ID </para>
		///<para> VR: SH VM=1 </para>
		///</summary>
        public const uint FluenceModeId = 805437522;

		///<summary>
		///<para> (3004,0001) DVH Type </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint DvhType = 805568513;

		///<summary>
		///<para> (3004,0002) Dose Units </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint DoseUnits = 805568514;

		///<summary>
		///<para> (3004,0004) Dose Type </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint DoseType = 805568516;

		///<summary>
		///<para> (3004,0005) Spatial Transform of Dose </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint SpatialTransformOfDose = 805568517;

		///<summary>
		///<para> (3004,0006) Dose Comment </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint DoseComment = 805568518;

		///<summary>
		///<para> (3004,0008) Normalization Point </para>
		///<para> VR: DS VM=3 </para>
		///</summary>
        public const uint NormalizationPoint = 805568520;

		///<summary>
		///<para> (3004,000A) Dose Summation Type </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint DoseSummationType = 805568522;

		///<summary>
		///<para> (3004,000C) Grid Frame Offset Vector </para>
		///<para> VR: DS VM=2-n </para>
		///</summary>
        public const uint GridFrameOffsetVector = 805568524;

		///<summary>
		///<para> (3004,000E) Dose Grid Scaling </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint DoseGridScaling = 805568526;

		///<summary>
		///<para> (3004,0010) RT Dose ROI Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint RtDoseRoiSequence = 805568528;

		///<summary>
		///<para> (3004,0012) Dose Value </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint DoseValue = 805568530;

		///<summary>
		///<para> (3004,0014) Tissue Heterogeneity Correction </para>
		///<para> VR: CS VM=1-3 </para>
		///</summary>
        public const uint TissueHeterogeneityCorrection = 805568532;

		///<summary>
		///<para> (3004,0040) DVH Normalization Point </para>
		///<para> VR: DS VM=3 </para>
		///</summary>
        public const uint DvhNormalizationPoint = 805568576;

		///<summary>
		///<para> (3004,0042) DVH Normalization Dose Value </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint DvhNormalizationDoseValue = 805568578;

		///<summary>
		///<para> (3004,0050) DVH Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint DvhSequence = 805568592;

		///<summary>
		///<para> (3004,0052) DVH Dose Scaling </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint DvhDoseScaling = 805568594;

		///<summary>
		///<para> (3004,0054) DVH Volume Units </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint DvhVolumeUnits = 805568596;

		///<summary>
		///<para> (3004,0056) DVH Number of Bins </para>
		///<para> VR: IS VM=1 </para>
		///</summary>
        public const uint DvhNumberOfBins = 805568598;

		///<summary>
		///<para> (3004,0058) DVH Data </para>
		///<para> VR: DS VM=2-2n </para>
		///</summary>
        public const uint DvhData = 805568600;

		///<summary>
		///<para> (3004,0060) DVH Referenced ROI Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint DvhReferencedRoiSequence = 805568608;

		///<summary>
		///<para> (3004,0062) DVH ROI Contribution Type </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint DvhRoiContributionType = 805568610;

		///<summary>
		///<para> (3004,0070) DVH Minimum Dose </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint DvhMinimumDose = 805568624;

		///<summary>
		///<para> (3004,0072) DVH Maximum Dose </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint DvhMaximumDose = 805568626;

		///<summary>
		///<para> (3004,0074) DVH Mean Dose </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint DvhMeanDose = 805568628;

		///<summary>
		///<para> (3006,0002) Structure Set Label </para>
		///<para> VR: SH VM=1 </para>
		///</summary>
        public const uint StructureSetLabel = 805699586;

		///<summary>
		///<para> (3006,0004) Structure Set Name </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint StructureSetName = 805699588;

		///<summary>
		///<para> (3006,0006) Structure Set Description </para>
		///<para> VR: ST VM=1 </para>
		///</summary>
        public const uint StructureSetDescription = 805699590;

		///<summary>
		///<para> (3006,0008) Structure Set Date </para>
		///<para> VR: DA VM=1 </para>
		///</summary>
        public const uint StructureSetDate = 805699592;

		///<summary>
		///<para> (3006,0009) Structure Set Time </para>
		///<para> VR: TM VM=1 </para>
		///</summary>
        public const uint StructureSetTime = 805699593;

		///<summary>
		///<para> (3006,0010) Referenced Frame of Reference Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint ReferencedFrameOfReferenceSequence = 805699600;

		///<summary>
		///<para> (3006,0012) RT Referenced Study Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint RtReferencedStudySequence = 805699602;

		///<summary>
		///<para> (3006,0014) RT Referenced Series Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint RtReferencedSeriesSequence = 805699604;

		///<summary>
		///<para> (3006,0016) Contour Image Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint ContourImageSequence = 805699606;

		///<summary>
		///<para> (3006,0018) Predecessor Structure Set Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint PredecessorStructureSetSequence = 805699608;

		///<summary>
		///<para> (3006,0020) Structure Set ROI Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint StructureSetRoiSequence = 805699616;

		///<summary>
		///<para> (3006,0022) ROI Number </para>
		///<para> VR: IS VM=1 </para>
		///</summary>
        public const uint RoiNumber = 805699618;

		///<summary>
		///<para> (3006,0024) Referenced Frame of Reference UID </para>
		///<para> VR: UI VM=1 </para>
		///</summary>
        public const uint ReferencedFrameOfReferenceUid = 805699620;

		///<summary>
		///<para> (3006,0026) ROI Name </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint RoiName = 805699622;

		///<summary>
		///<para> (3006,0028) ROI Description </para>
		///<para> VR: ST VM=1 </para>
		///</summary>
        public const uint RoiDescription = 805699624;

		///<summary>
		///<para> (3006,002A) ROI Display Color </para>
		///<para> VR: IS VM=3 </para>
		///</summary>
        public const uint RoiDisplayColor = 805699626;

		///<summary>
		///<para> (3006,002C) ROI Volume </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint RoiVolume = 805699628;

		///<summary>
		///<para> (3006,0030) RT Related ROI Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint RtRelatedRoiSequence = 805699632;

		///<summary>
		///<para> (3006,0033) RT ROI Relationship </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint RtRoiRelationship = 805699635;

		///<summary>
		///<para> (3006,0036) ROI Generation Algorithm </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint RoiGenerationAlgorithm = 805699638;

		///<summary>
		///<para> (3006,0038) ROI Generation Description </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint RoiGenerationDescription = 805699640;

		///<summary>
		///<para> (3006,0039) ROI Contour Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint RoiContourSequence = 805699641;

		///<summary>
		///<para> (3006,0040) Contour Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint ContourSequence = 805699648;

		///<summary>
		///<para> (3006,0042) Contour Geometric Type </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint ContourGeometricType = 805699650;

		///<summary>
		///<para> (3006,0044) Contour Slab Thickness </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint ContourSlabThickness = 805699652;

		///<summary>
		///<para> (3006,0045) Contour Offset Vector </para>
		///<para> VR: DS VM=3 </para>
		///</summary>
        public const uint ContourOffsetVector = 805699653;

		///<summary>
		///<para> (3006,0046) Number of Contour Points </para>
		///<para> VR: IS VM=1 </para>
		///</summary>
        public const uint NumberOfContourPoints = 805699654;

		///<summary>
		///<para> (3006,0048) Contour Number </para>
		///<para> VR: IS VM=1 </para>
		///</summary>
        public const uint ContourNumber = 805699656;

		///<summary>
		///<para> (3006,0049) Attached Contours </para>
		///<para> VR: IS VM=1-n </para>
		///</summary>
        public const uint AttachedContours = 805699657;

		///<summary>
		///<para> (3006,0050) Contour Data </para>
		///<para> VR: DS VM=3-3n </para>
		///</summary>
        public const uint ContourData = 805699664;

		///<summary>
		///<para> (3006,0080) RT ROI Observations Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint RtRoiObservationsSequence = 805699712;

		///<summary>
		///<para> (3006,0082) Observation Number </para>
		///<para> VR: IS VM=1 </para>
		///</summary>
        public const uint ObservationNumber = 805699714;

		///<summary>
		///<para> (3006,0084) Referenced ROI Number </para>
		///<para> VR: IS VM=1 </para>
		///</summary>
        public const uint ReferencedRoiNumber = 805699716;

		///<summary>
		///<para> (3006,0085) ROI Observation Label </para>
		///<para> VR: SH VM=1 </para>
		///</summary>
        public const uint RoiObservationLabel = 805699717;

		///<summary>
		///<para> (3006,0086) RT ROI Identification Code Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint RtRoiIdentificationCodeSequence = 805699718;

		///<summary>
		///<para> (3006,0088) ROI Observation Description </para>
		///<para> VR: ST VM=1 </para>
		///</summary>
        public const uint RoiObservationDescription = 805699720;

		///<summary>
		///<para> (3006,00A0) Related RT ROI Observations Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint RelatedRtRoiObservationsSequence = 805699744;

		///<summary>
		///<para> (3006,00A4) RT ROI Interpreted Type </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint RtRoiInterpretedType = 805699748;

		///<summary>
		///<para> (3006,00A6) ROI Interpreter </para>
		///<para> VR: PN VM=1 </para>
		///</summary>
        public const uint RoiInterpreter = 805699750;

		///<summary>
		///<para> (3006,00B0) ROI Physical Properties Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint RoiPhysicalPropertiesSequence = 805699760;

		///<summary>
		///<para> (3006,00B2) ROI Physical Property </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint RoiPhysicalProperty = 805699762;

		///<summary>
		///<para> (3006,00B4) ROI Physical Property Value </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint RoiPhysicalPropertyValue = 805699764;

		///<summary>
		///<para> (3006,00B6) ROI Elemental Composition Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint RoiElementalCompositionSequence = 805699766;

		///<summary>
		///<para> (3006,00B7) ROI Elemental Composition Atomic Number </para>
		///<para> VR: US VM=1 </para>
		///</summary>
        public const uint RoiElementalCompositionAtomicNumber = 805699767;

		///<summary>
		///<para> (3006,00B8) ROI Elemental Composition Atomic Mass Fraction </para>
		///<para> VR: FL VM=1 </para>
		///</summary>
        public const uint RoiElementalCompositionAtomicMassFraction = 805699768;

		///<summary>
		///<para> (3006,00B9) Additional RT ROI Identification Code Sequence (RETIRED) </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint AdditionalRtRoiIdentificationCodeSequenceRetired = 805699769;

		///<summary>
		///<para> (3006,00C0) Frame of Reference Relationship Sequence (RETIRED) </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint FrameOfReferenceRelationshipSequenceRetired = 805699776;

		///<summary>
		///<para> (3006,00C2) Related Frame of Reference UID (RETIRED) </para>
		///<para> VR: UI VM=1 </para>
		///</summary>
        public const uint RelatedFrameOfReferenceUidRetired = 805699778;

		///<summary>
		///<para> (3006,00C4) Frame of Reference Transformation Type (RETIRED) </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint FrameOfReferenceTransformationTypeRetired = 805699780;

		///<summary>
		///<para> (3006,00C6) Frame of Reference Transformation Matrix </para>
		///<para> VR: DS VM=16 </para>
		///</summary>
        public const uint FrameOfReferenceTransformationMatrix = 805699782;

		///<summary>
		///<para> (3006,00C8) Frame of Reference Transformation Comment </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint FrameOfReferenceTransformationComment = 805699784;

		///<summary>
		///<para> (3008,0010) Measured Dose Reference Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint MeasuredDoseReferenceSequence = 805830672;

		///<summary>
		///<para> (3008,0012) Measured Dose Description </para>
		///<para> VR: ST VM=1 </para>
		///</summary>
        public const uint MeasuredDoseDescription = 805830674;

		///<summary>
		///<para> (3008,0014) Measured Dose Type </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint MeasuredDoseType = 805830676;

		///<summary>
		///<para> (3008,0016) Measured Dose Value </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint MeasuredDoseValue = 805830678;

		///<summary>
		///<para> (3008,0020) Treatment Session Beam Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint TreatmentSessionBeamSequence = 805830688;

		///<summary>
		///<para> (3008,0021) Treatment Session Ion Beam Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint TreatmentSessionIonBeamSequence = 805830689;

		///<summary>
		///<para> (3008,0022) Current Fraction Number </para>
		///<para> VR: IS VM=1 </para>
		///</summary>
        public const uint CurrentFractionNumber = 805830690;

		///<summary>
		///<para> (3008,0024) Treatment Control Point Date </para>
		///<para> VR: DA VM=1 </para>
		///</summary>
        public const uint TreatmentControlPointDate = 805830692;

		///<summary>
		///<para> (3008,0025) Treatment Control Point Time </para>
		///<para> VR: TM VM=1 </para>
		///</summary>
        public const uint TreatmentControlPointTime = 805830693;

		///<summary>
		///<para> (3008,002A) Treatment Termination Status </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint TreatmentTerminationStatus = 805830698;

		///<summary>
		///<para> (3008,002B) Treatment Termination Code </para>
		///<para> VR: SH VM=1 </para>
		///</summary>
        public const uint TreatmentTerminationCode = 805830699;

		///<summary>
		///<para> (3008,002C) Treatment Verification Status </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint TreatmentVerificationStatus = 805830700;

		///<summary>
		///<para> (3008,0030) Referenced Treatment Record Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint ReferencedTreatmentRecordSequence = 805830704;

		///<summary>
		///<para> (3008,0032) Specified Primary Meterset </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint SpecifiedPrimaryMeterset = 805830706;

		///<summary>
		///<para> (3008,0033) Specified Secondary Meterset </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint SpecifiedSecondaryMeterset = 805830707;

		///<summary>
		///<para> (3008,0036) Delivered Primary Meterset </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint DeliveredPrimaryMeterset = 805830710;

		///<summary>
		///<para> (3008,0037) Delivered Secondary Meterset </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint DeliveredSecondaryMeterset = 805830711;

		///<summary>
		///<para> (3008,003A) Specified Treatment Time </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint SpecifiedTreatmentTime = 805830714;

		///<summary>
		///<para> (3008,003B) Delivered Treatment Time </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint DeliveredTreatmentTime = 805830715;

		///<summary>
		///<para> (3008,0040) Control Point Delivery Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint ControlPointDeliverySequence = 805830720;

		///<summary>
		///<para> (3008,0041) Ion Control Point Delivery Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint IonControlPointDeliverySequence = 805830721;

		///<summary>
		///<para> (3008,0042) Specified Meterset </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint SpecifiedMeterset = 805830722;

		///<summary>
		///<para> (3008,0044) Delivered Meterset </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint DeliveredMeterset = 805830724;

		///<summary>
		///<para> (3008,0045) Meterset Rate Set </para>
		///<para> VR: FL VM=1 </para>
		///</summary>
        public const uint MetersetRateSet = 805830725;

		///<summary>
		///<para> (3008,0046) Meterset Rate Delivered </para>
		///<para> VR: FL VM=1 </para>
		///</summary>
        public const uint MetersetRateDelivered = 805830726;

		///<summary>
		///<para> (3008,0047) Scan Spot Metersets Delivered </para>
		///<para> VR: FL VM=1-n </para>
		///</summary>
        public const uint ScanSpotMetersetsDelivered = 805830727;

		///<summary>
		///<para> (3008,0048) Dose Rate Delivered </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint DoseRateDelivered = 805830728;

		///<summary>
		///<para> (3008,0050) Treatment Summary Calculated Dose Reference Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint TreatmentSummaryCalculatedDoseReferenceSequence = 805830736;

		///<summary>
		///<para> (3008,0052) Cumulative Dose to Dose Reference </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint CumulativeDoseToDoseReference = 805830738;

		///<summary>
		///<para> (3008,0054) First Treatment Date </para>
		///<para> VR: DA VM=1 </para>
		///</summary>
        public const uint FirstTreatmentDate = 805830740;

		///<summary>
		///<para> (3008,0056) Most Recent Treatment Date </para>
		///<para> VR: DA VM=1 </para>
		///</summary>
        public const uint MostRecentTreatmentDate = 805830742;

		///<summary>
		///<para> (3008,005A) Number of Fractions Delivered </para>
		///<para> VR: IS VM=1 </para>
		///</summary>
        public const uint NumberOfFractionsDelivered = 805830746;

		///<summary>
		///<para> (3008,0060) Override Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint OverrideSequence = 805830752;

		///<summary>
		///<para> (3008,0061) Parameter Sequence Pointer </para>
		///<para> VR: AT VM=1 </para>
		///</summary>
        public const uint ParameterSequencePointer = 805830753;

		///<summary>
		///<para> (3008,0062) Override Parameter Pointer </para>
		///<para> VR: AT VM=1 </para>
		///</summary>
        public const uint OverrideParameterPointer = 805830754;

		///<summary>
		///<para> (3008,0063) Parameter Item Index </para>
		///<para> VR: IS VM=1 </para>
		///</summary>
        public const uint ParameterItemIndex = 805830755;

		///<summary>
		///<para> (3008,0064) Measured Dose Reference Number </para>
		///<para> VR: IS VM=1 </para>
		///</summary>
        public const uint MeasuredDoseReferenceNumber = 805830756;

		///<summary>
		///<para> (3008,0065) Parameter Pointer </para>
		///<para> VR: AT VM=1 </para>
		///</summary>
        public const uint ParameterPointer = 805830757;

		///<summary>
		///<para> (3008,0066) Override Reason </para>
		///<para> VR: ST VM=1 </para>
		///</summary>
        public const uint OverrideReason = 805830758;

		///<summary>
		///<para> (3008,0067) Parameter Value Number </para>
		///<para> VR: US VM=1 </para>
		///</summary>
        public const uint ParameterValueNumber = 805830759;

		///<summary>
		///<para> (3008,0068) Corrected Parameter Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint CorrectedParameterSequence = 805830760;

		///<summary>
		///<para> (3008,006A) Correction Value </para>
		///<para> VR: FL VM=1 </para>
		///</summary>
        public const uint CorrectionValue = 805830762;

		///<summary>
		///<para> (3008,0070) Calculated Dose Reference Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint CalculatedDoseReferenceSequence = 805830768;

		///<summary>
		///<para> (3008,0072) Calculated Dose Reference Number </para>
		///<para> VR: IS VM=1 </para>
		///</summary>
        public const uint CalculatedDoseReferenceNumber = 805830770;

		///<summary>
		///<para> (3008,0074) Calculated Dose Reference Description </para>
		///<para> VR: ST VM=1 </para>
		///</summary>
        public const uint CalculatedDoseReferenceDescription = 805830772;

		///<summary>
		///<para> (3008,0076) Calculated Dose Reference Dose Value </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint CalculatedDoseReferenceDoseValue = 805830774;

		///<summary>
		///<para> (3008,0078) Start Meterset </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint StartMeterset = 805830776;

		///<summary>
		///<para> (3008,007A) End Meterset </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint EndMeterset = 805830778;

		///<summary>
		///<para> (3008,0080) Referenced Measured Dose Reference Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint ReferencedMeasuredDoseReferenceSequence = 805830784;

		///<summary>
		///<para> (3008,0082) Referenced Measured Dose Reference Number </para>
		///<para> VR: IS VM=1 </para>
		///</summary>
        public const uint ReferencedMeasuredDoseReferenceNumber = 805830786;

		///<summary>
		///<para> (3008,0090) Referenced Calculated Dose Reference Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint ReferencedCalculatedDoseReferenceSequence = 805830800;

		///<summary>
		///<para> (3008,0092) Referenced Calculated Dose Reference Number </para>
		///<para> VR: IS VM=1 </para>
		///</summary>
        public const uint ReferencedCalculatedDoseReferenceNumber = 805830802;

		///<summary>
		///<para> (3008,00A0) Beam Limiting Device Leaf Pairs Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint BeamLimitingDeviceLeafPairsSequence = 805830816;

		///<summary>
		///<para> (3008,00B0) Recorded Wedge Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint RecordedWedgeSequence = 805830832;

		///<summary>
		///<para> (3008,00C0) Recorded Compensator Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint RecordedCompensatorSequence = 805830848;

		///<summary>
		///<para> (3008,00D0) Recorded Block Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint RecordedBlockSequence = 805830864;

		///<summary>
		///<para> (3008,00E0) Treatment Summary Measured Dose Reference Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint TreatmentSummaryMeasuredDoseReferenceSequence = 805830880;

		///<summary>
		///<para> (3008,00F0) Recorded Snout Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint RecordedSnoutSequence = 805830896;

		///<summary>
		///<para> (3008,00F2) Recorded Range Shifter Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint RecordedRangeShifterSequence = 805830898;

		///<summary>
		///<para> (3008,00F4) Recorded Lateral Spreading Device Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint RecordedLateralSpreadingDeviceSequence = 805830900;

		///<summary>
		///<para> (3008,00F6) Recorded Range Modulator Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint RecordedRangeModulatorSequence = 805830902;

		///<summary>
		///<para> (3008,0100) Recorded Source Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint RecordedSourceSequence = 805830912;

		///<summary>
		///<para> (3008,0105) Source Serial Number </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint SourceSerialNumber = 805830917;

		///<summary>
		///<para> (3008,0110) Treatment Session Application Setup Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint TreatmentSessionApplicationSetupSequence = 805830928;

		///<summary>
		///<para> (3008,0116) Application Setup Check </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint ApplicationSetupCheck = 805830934;

		///<summary>
		///<para> (3008,0120) Recorded Brachy Accessory Device Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint RecordedBrachyAccessoryDeviceSequence = 805830944;

		///<summary>
		///<para> (3008,0122) Referenced Brachy Accessory Device Number </para>
		///<para> VR: IS VM=1 </para>
		///</summary>
        public const uint ReferencedBrachyAccessoryDeviceNumber = 805830946;

		///<summary>
		///<para> (3008,0130) Recorded Channel Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint RecordedChannelSequence = 805830960;

		///<summary>
		///<para> (3008,0132) Specified Channel Total Time </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint SpecifiedChannelTotalTime = 805830962;

		///<summary>
		///<para> (3008,0134) Delivered Channel Total Time </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint DeliveredChannelTotalTime = 805830964;

		///<summary>
		///<para> (3008,0136) Specified Number of Pulses </para>
		///<para> VR: IS VM=1 </para>
		///</summary>
        public const uint SpecifiedNumberOfPulses = 805830966;

		///<summary>
		///<para> (3008,0138) Delivered Number of Pulses </para>
		///<para> VR: IS VM=1 </para>
		///</summary>
        public const uint DeliveredNumberOfPulses = 805830968;

		///<summary>
		///<para> (3008,013A) Specified Pulse Repetition Interval </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint SpecifiedPulseRepetitionInterval = 805830970;

		///<summary>
		///<para> (3008,013C) Delivered Pulse Repetition Interval </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint DeliveredPulseRepetitionInterval = 805830972;

		///<summary>
		///<para> (3008,0140) Recorded Source Applicator Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint RecordedSourceApplicatorSequence = 805830976;

		///<summary>
		///<para> (3008,0142) Referenced Source Applicator Number </para>
		///<para> VR: IS VM=1 </para>
		///</summary>
        public const uint ReferencedSourceApplicatorNumber = 805830978;

		///<summary>
		///<para> (3008,0150) Recorded Channel Shield Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint RecordedChannelShieldSequence = 805830992;

		///<summary>
		///<para> (3008,0152) Referenced Channel Shield Number </para>
		///<para> VR: IS VM=1 </para>
		///</summary>
        public const uint ReferencedChannelShieldNumber = 805830994;

		///<summary>
		///<para> (3008,0160) Brachy Control Point Delivered Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint BrachyControlPointDeliveredSequence = 805831008;

		///<summary>
		///<para> (3008,0162) Safe Position Exit Date </para>
		///<para> VR: DA VM=1 </para>
		///</summary>
        public const uint SafePositionExitDate = 805831010;

		///<summary>
		///<para> (3008,0164) Safe Position Exit Time </para>
		///<para> VR: TM VM=1 </para>
		///</summary>
        public const uint SafePositionExitTime = 805831012;

		///<summary>
		///<para> (3008,0166) Safe Position Return Date </para>
		///<para> VR: DA VM=1 </para>
		///</summary>
        public const uint SafePositionReturnDate = 805831014;

		///<summary>
		///<para> (3008,0168) Safe Position Return Time </para>
		///<para> VR: TM VM=1 </para>
		///</summary>
        public const uint SafePositionReturnTime = 805831016;

		///<summary>
		///<para> (3008,0171) Pulse Specific Brachy Control Point Delivered Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint PulseSpecificBrachyControlPointDeliveredSequence = 805831025;

		///<summary>
		///<para> (3008,0172) Pulse Number </para>
		///<para> VR: US VM=1 </para>
		///</summary>
        public const uint PulseNumber = 805831026;

		///<summary>
		///<para> (3008,0173) Brachy Pulse Control Point Delivered Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint BrachyPulseControlPointDeliveredSequence = 805831027;

		///<summary>
		///<para> (3008,0200) Current Treatment Status </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint CurrentTreatmentStatus = 805831168;

		///<summary>
		///<para> (3008,0202) Treatment Status Comment </para>
		///<para> VR: ST VM=1 </para>
		///</summary>
        public const uint TreatmentStatusComment = 805831170;

		///<summary>
		///<para> (3008,0220) Fraction Group Summary Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint FractionGroupSummarySequence = 805831200;

		///<summary>
		///<para> (3008,0223) Referenced Fraction Number </para>
		///<para> VR: IS VM=1 </para>
		///</summary>
        public const uint ReferencedFractionNumber = 805831203;

		///<summary>
		///<para> (3008,0224) Fraction Group Type </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint FractionGroupType = 805831204;

		///<summary>
		///<para> (3008,0230) Beam Stopper Position </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint BeamStopperPosition = 805831216;

		///<summary>
		///<para> (3008,0240) Fraction Status Summary Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint FractionStatusSummarySequence = 805831232;

		///<summary>
		///<para> (3008,0250) Treatment Date </para>
		///<para> VR: DA VM=1 </para>
		///</summary>
        public const uint TreatmentDate = 805831248;

		///<summary>
		///<para> (3008,0251) Treatment Time </para>
		///<para> VR: TM VM=1 </para>
		///</summary>
        public const uint TreatmentTime = 805831249;

		///<summary>
		///<para> (300A,0002) RT Plan Label </para>
		///<para> VR: SH VM=1 </para>
		///</summary>
        public const uint RtPlanLabel = 805961730;

		///<summary>
		///<para> (300A,0003) RT Plan Name </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint RtPlanName = 805961731;

		///<summary>
		///<para> (300A,0004) RT Plan Description </para>
		///<para> VR: ST VM=1 </para>
		///</summary>
        public const uint RtPlanDescription = 805961732;

		///<summary>
		///<para> (300A,0006) RT Plan Date </para>
		///<para> VR: DA VM=1 </para>
		///</summary>
        public const uint RtPlanDate = 805961734;

		///<summary>
		///<para> (300A,0007) RT Plan Time </para>
		///<para> VR: TM VM=1 </para>
		///</summary>
        public const uint RtPlanTime = 805961735;

		///<summary>
		///<para> (300A,0009) Treatment Protocols </para>
		///<para> VR: LO VM=1-n </para>
		///</summary>
        public const uint TreatmentProtocols = 805961737;

		///<summary>
		///<para> (300A,000A) Plan Intent </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint PlanIntent = 805961738;

		///<summary>
		///<para> (300A,000B) Treatment Sites </para>
		///<para> VR: LO VM=1-n </para>
		///</summary>
        public const uint TreatmentSites = 805961739;

		///<summary>
		///<para> (300A,000C) RT Plan Geometry </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint RtPlanGeometry = 805961740;

		///<summary>
		///<para> (300A,000E) Prescription Description </para>
		///<para> VR: ST VM=1 </para>
		///</summary>
        public const uint PrescriptionDescription = 805961742;

		///<summary>
		///<para> (300A,0010) Dose Reference Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint DoseReferenceSequence = 805961744;

		///<summary>
		///<para> (300A,0012) Dose Reference Number </para>
		///<para> VR: IS VM=1 </para>
		///</summary>
        public const uint DoseReferenceNumber = 805961746;

		///<summary>
		///<para> (300A,0013) Dose Reference UID </para>
		///<para> VR: UI VM=1 </para>
		///</summary>
        public const uint DoseReferenceUid = 805961747;

		///<summary>
		///<para> (300A,0014) Dose Reference Structure Type </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint DoseReferenceStructureType = 805961748;

		///<summary>
		///<para> (300A,0015) Nominal Beam Energy Unit </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint NominalBeamEnergyUnit = 805961749;

		///<summary>
		///<para> (300A,0016) Dose Reference Description </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint DoseReferenceDescription = 805961750;

		///<summary>
		///<para> (300A,0018) Dose Reference Point Coordinates </para>
		///<para> VR: DS VM=3 </para>
		///</summary>
        public const uint DoseReferencePointCoordinates = 805961752;

		///<summary>
		///<para> (300A,001A) Nominal Prior Dose </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint NominalPriorDose = 805961754;

		///<summary>
		///<para> (300A,0020) Dose Reference Type </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint DoseReferenceType = 805961760;

		///<summary>
		///<para> (300A,0021) Constraint Weight </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint ConstraintWeight = 805961761;

		///<summary>
		///<para> (300A,0022) Delivery Warning Dose </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint DeliveryWarningDose = 805961762;

		///<summary>
		///<para> (300A,0023) Delivery Maximum Dose </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint DeliveryMaximumDose = 805961763;

		///<summary>
		///<para> (300A,0025) Target Minimum Dose </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint TargetMinimumDose = 805961765;

		///<summary>
		///<para> (300A,0026) Target Prescription Dose </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint TargetPrescriptionDose = 805961766;

		///<summary>
		///<para> (300A,0027) Target Maximum Dose </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint TargetMaximumDose = 805961767;

		///<summary>
		///<para> (300A,0028) Target Underdose Volume Fraction </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint TargetUnderdoseVolumeFraction = 805961768;

		///<summary>
		///<para> (300A,002A) Organ at Risk Full-volume Dose </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint OrganAtRiskFullVolumeDose = 805961770;

		///<summary>
		///<para> (300A,002B) Organ at Risk Limit Dose </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint OrganAtRiskLimitDose = 805961771;

		///<summary>
		///<para> (300A,002C) Organ at Risk Maximum Dose </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint OrganAtRiskMaximumDose = 805961772;

		///<summary>
		///<para> (300A,002D) Organ at Risk Overdose Volume Fraction </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint OrganAtRiskOverdoseVolumeFraction = 805961773;

		///<summary>
		///<para> (300A,0040) Tolerance Table Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint ToleranceTableSequence = 805961792;

		///<summary>
		///<para> (300A,0042) Tolerance Table Number </para>
		///<para> VR: IS VM=1 </para>
		///</summary>
        public const uint ToleranceTableNumber = 805961794;

		///<summary>
		///<para> (300A,0043) Tolerance Table Label </para>
		///<para> VR: SH VM=1 </para>
		///</summary>
        public const uint ToleranceTableLabel = 805961795;

		///<summary>
		///<para> (300A,0044) Gantry Angle Tolerance </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint GantryAngleTolerance = 805961796;

		///<summary>
		///<para> (300A,0046) Beam Limiting Device Angle Tolerance </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint BeamLimitingDeviceAngleTolerance = 805961798;

		///<summary>
		///<para> (300A,0048) Beam Limiting Device Tolerance Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint BeamLimitingDeviceToleranceSequence = 805961800;

		///<summary>
		///<para> (300A,004A) Beam Limiting Device Position Tolerance </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint BeamLimitingDevicePositionTolerance = 805961802;

		///<summary>
		///<para> (300A,004B) Snout Position Tolerance </para>
		///<para> VR: FL VM=1 </para>
		///</summary>
        public const uint SnoutPositionTolerance = 805961803;

		///<summary>
		///<para> (300A,004C) Patient Support Angle Tolerance </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint PatientSupportAngleTolerance = 805961804;

		///<summary>
		///<para> (300A,004E) Table Top Eccentric Angle Tolerance </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint TableTopEccentricAngleTolerance = 805961806;

		///<summary>
		///<para> (300A,004F) Table Top Pitch Angle Tolerance </para>
		///<para> VR: FL VM=1 </para>
		///</summary>
        public const uint TableTopPitchAngleTolerance = 805961807;

		///<summary>
		///<para> (300A,0050) Table Top Roll Angle Tolerance </para>
		///<para> VR: FL VM=1 </para>
		///</summary>
        public const uint TableTopRollAngleTolerance = 805961808;

		///<summary>
		///<para> (300A,0051) Table Top Vertical Position Tolerance </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint TableTopVerticalPositionTolerance = 805961809;

		///<summary>
		///<para> (300A,0052) Table Top Longitudinal Position Tolerance </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint TableTopLongitudinalPositionTolerance = 805961810;

		///<summary>
		///<para> (300A,0053) Table Top Lateral Position Tolerance </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint TableTopLateralPositionTolerance = 805961811;

		///<summary>
		///<para> (300A,0055) RT Plan Relationship </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint RtPlanRelationship = 805961813;

		///<summary>
		///<para> (300A,0070) Fraction Group Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint FractionGroupSequence = 805961840;

		///<summary>
		///<para> (300A,0071) Fraction Group Number </para>
		///<para> VR: IS VM=1 </para>
		///</summary>
        public const uint FractionGroupNumber = 805961841;

		///<summary>
		///<para> (300A,0072) Fraction Group Description </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint FractionGroupDescription = 805961842;

		///<summary>
		///<para> (300A,0078) Number of Fractions Planned </para>
		///<para> VR: IS VM=1 </para>
		///</summary>
        public const uint NumberOfFractionsPlanned = 805961848;

		///<summary>
		///<para> (300A,0079) Number of Fraction Pattern Digits Per Day </para>
		///<para> VR: IS VM=1 </para>
		///</summary>
        public const uint NumberOfFractionPatternDigitsPerDay = 805961849;

		///<summary>
		///<para> (300A,007A) Repeat Fraction Cycle Length </para>
		///<para> VR: IS VM=1 </para>
		///</summary>
        public const uint RepeatFractionCycleLength = 805961850;

		///<summary>
		///<para> (300A,007B) Fraction Pattern </para>
		///<para> VR: LT VM=1 </para>
		///</summary>
        public const uint FractionPattern = 805961851;

		///<summary>
		///<para> (300A,0080) Number of Beams </para>
		///<para> VR: IS VM=1 </para>
		///</summary>
        public const uint NumberOfBeams = 805961856;

		///<summary>
		///<para> (300A,0082) Beam Dose Specification Point </para>
		///<para> VR: DS VM=3 </para>
		///</summary>
        public const uint BeamDoseSpecificationPoint = 805961858;

		///<summary>
		///<para> (300A,0084) Beam Dose </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint BeamDose = 805961860;

		///<summary>
		///<para> (300A,0086) Beam Meterset </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint BeamMeterset = 805961862;

		///<summary>
		///<para> (300A,0088) Beam Dose Point Depth (RETIRED) </para>
		///<para> VR: FL VM=1 </para>
		///</summary>
        public const uint BeamDosePointDepthRetired = 805961864;

		///<summary>
		///<para> (300A,0089) Beam Dose Point Equivalent Depth (RETIRED) </para>
		///<para> VR: FL VM=1 </para>
		///</summary>
        public const uint BeamDosePointEquivalentDepthRetired = 805961865;

		///<summary>
		///<para> (300A,008A) Beam Dose Point SSD (RETIRED) </para>
		///<para> VR: FL VM=1 </para>
		///</summary>
        public const uint BeamDosePointSsdRetired = 805961866;

		///<summary>
		///<para> (300A,008B) Beam Dose Meaning </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint BeamDoseMeaning = 805961867;

		///<summary>
		///<para> (300A,008C) Beam Dose Verification Control Point Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint BeamDoseVerificationControlPointSequence = 805961868;

		///<summary>
		///<para> (300A,008D) Average Beam Dose Point Depth </para>
		///<para> VR: FL VM=1 </para>
		///</summary>
        public const uint AverageBeamDosePointDepth = 805961869;

		///<summary>
		///<para> (300A,008E) Average Beam Dose Point Equivalent Depth </para>
		///<para> VR: FL VM=1 </para>
		///</summary>
        public const uint AverageBeamDosePointEquivalentDepth = 805961870;

		///<summary>
		///<para> (300A,008F) Average Beam Dose Point SSD </para>
		///<para> VR: FL VM=1 </para>
		///</summary>
        public const uint AverageBeamDosePointSsd = 805961871;

		///<summary>
		///<para> (300A,0090) Beam Dose Type </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint BeamDoseType = 805961872;

		///<summary>
		///<para> (300A,0091) Alternate Beam Dose </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint AlternateBeamDose = 805961873;

		///<summary>
		///<para> (300A,0092) Alternate Beam Dose Type </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint AlternateBeamDoseType = 805961874;

		///<summary>
		///<para> (300A,00A0) Number of Brachy Application Setups </para>
		///<para> VR: IS VM=1 </para>
		///</summary>
        public const uint NumberOfBrachyApplicationSetups = 805961888;

		///<summary>
		///<para> (300A,00A2) Brachy Application Setup Dose Specification Point </para>
		///<para> VR: DS VM=3 </para>
		///</summary>
        public const uint BrachyApplicationSetupDoseSpecificationPoint = 805961890;

		///<summary>
		///<para> (300A,00A4) Brachy Application Setup Dose </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint BrachyApplicationSetupDose = 805961892;

		///<summary>
		///<para> (300A,00B0) Beam Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint BeamSequence = 805961904;

		///<summary>
		///<para> (300A,00B2) Treatment Machine Name </para>
		///<para> VR: SH VM=1 </para>
		///</summary>
        public const uint TreatmentMachineName = 805961906;

		///<summary>
		///<para> (300A,00B3) Primary Dosimeter Unit </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint PrimaryDosimeterUnit = 805961907;

		///<summary>
		///<para> (300A,00B4) Source-Axis Distance </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint SourceAxisDistance = 805961908;

		///<summary>
		///<para> (300A,00B6) Beam Limiting Device Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint BeamLimitingDeviceSequence = 805961910;

		///<summary>
		///<para> (300A,00B8) RT Beam Limiting Device Type </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint RtBeamLimitingDeviceType = 805961912;

		///<summary>
		///<para> (300A,00BA) Source to Beam Limiting Device Distance </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint SourceToBeamLimitingDeviceDistance = 805961914;

		///<summary>
		///<para> (300A,00BB) Isocenter to Beam Limiting Device Distance </para>
		///<para> VR: FL VM=1 </para>
		///</summary>
        public const uint IsocenterToBeamLimitingDeviceDistance = 805961915;

		///<summary>
		///<para> (300A,00BC) Number of Leaf/Jaw Pairs </para>
		///<para> VR: IS VM=1 </para>
		///</summary>
        public const uint NumberOfLeafJawPairs = 805961916;

		///<summary>
		///<para> (300A,00BE) Leaf Position Boundaries </para>
		///<para> VR: DS VM=3-n </para>
		///</summary>
        public const uint LeafPositionBoundaries = 805961918;

		///<summary>
		///<para> (300A,00C0) Beam Number </para>
		///<para> VR: IS VM=1 </para>
		///</summary>
        public const uint BeamNumber = 805961920;

		///<summary>
		///<para> (300A,00C2) Beam Name </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint BeamName = 805961922;

		///<summary>
		///<para> (300A,00C3) Beam Description </para>
		///<para> VR: ST VM=1 </para>
		///</summary>
        public const uint BeamDescription = 805961923;

		///<summary>
		///<para> (300A,00C4) Beam Type </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint BeamType = 805961924;

		///<summary>
		///<para> (300A,00C5) Beam Delivery Duration Limit </para>
		///<para> VR: FD VM=1 </para>
		///</summary>
        public const uint BeamDeliveryDurationLimit = 805961925;

		///<summary>
		///<para> (300A,00C6) Radiation Type </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint RadiationType = 805961926;

		///<summary>
		///<para> (300A,00C7) High-Dose Technique Type </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint HighDoseTechniqueType = 805961927;

		///<summary>
		///<para> (300A,00C8) Reference Image Number </para>
		///<para> VR: IS VM=1 </para>
		///</summary>
        public const uint ReferenceImageNumber = 805961928;

		///<summary>
		///<para> (300A,00CA) Planned Verification Image Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint PlannedVerificationImageSequence = 805961930;

		///<summary>
		///<para> (300A,00CC) Imaging Device-Specific Acquisition Parameters </para>
		///<para> VR: LO VM=1-n </para>
		///</summary>
        public const uint ImagingDeviceSpecificAcquisitionParameters = 805961932;

		///<summary>
		///<para> (300A,00CE) Treatment Delivery Type </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint TreatmentDeliveryType = 805961934;

		///<summary>
		///<para> (300A,00D0) Number of Wedges </para>
		///<para> VR: IS VM=1 </para>
		///</summary>
        public const uint NumberOfWedges = 805961936;

		///<summary>
		///<para> (300A,00D1) Wedge Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint WedgeSequence = 805961937;

		///<summary>
		///<para> (300A,00D2) Wedge Number </para>
		///<para> VR: IS VM=1 </para>
		///</summary>
        public const uint WedgeNumber = 805961938;

		///<summary>
		///<para> (300A,00D3) Wedge Type </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint WedgeType = 805961939;

		///<summary>
		///<para> (300A,00D4) Wedge ID </para>
		///<para> VR: SH VM=1 </para>
		///</summary>
        public const uint WedgeId = 805961940;

		///<summary>
		///<para> (300A,00D5) Wedge Angle </para>
		///<para> VR: IS VM=1 </para>
		///</summary>
        public const uint WedgeAngle = 805961941;

		///<summary>
		///<para> (300A,00D6) Wedge Factor </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint WedgeFactor = 805961942;

		///<summary>
		///<para> (300A,00D7) Total Wedge Tray Water-Equivalent Thickness </para>
		///<para> VR: FL VM=1 </para>
		///</summary>
        public const uint TotalWedgeTrayWaterEquivalentThickness = 805961943;

		///<summary>
		///<para> (300A,00D8) Wedge Orientation </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint WedgeOrientation = 805961944;

		///<summary>
		///<para> (300A,00D9) Isocenter to Wedge Tray Distance </para>
		///<para> VR: FL VM=1 </para>
		///</summary>
        public const uint IsocenterToWedgeTrayDistance = 805961945;

		///<summary>
		///<para> (300A,00DA) Source to Wedge Tray Distance </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint SourceToWedgeTrayDistance = 805961946;

		///<summary>
		///<para> (300A,00DB) Wedge Thin Edge Position </para>
		///<para> VR: FL VM=1 </para>
		///</summary>
        public const uint WedgeThinEdgePosition = 805961947;

		///<summary>
		///<para> (300A,00DC) Bolus ID </para>
		///<para> VR: SH VM=1 </para>
		///</summary>
        public const uint BolusId = 805961948;

		///<summary>
		///<para> (300A,00DD) Bolus Description </para>
		///<para> VR: ST VM=1 </para>
		///</summary>
        public const uint BolusDescription = 805961949;

		///<summary>
		///<para> (300A,00DE) Effective Wedge Angle </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint EffectiveWedgeAngle = 805961950;

		///<summary>
		///<para> (300A,00E0) Number of Compensators </para>
		///<para> VR: IS VM=1 </para>
		///</summary>
        public const uint NumberOfCompensators = 805961952;

		///<summary>
		///<para> (300A,00E1) Material ID </para>
		///<para> VR: SH VM=1 </para>
		///</summary>
        public const uint MaterialId = 805961953;

		///<summary>
		///<para> (300A,00E2) Total Compensator Tray Factor </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint TotalCompensatorTrayFactor = 805961954;

		///<summary>
		///<para> (300A,00E3) Compensator Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint CompensatorSequence = 805961955;

		///<summary>
		///<para> (300A,00E4) Compensator Number </para>
		///<para> VR: IS VM=1 </para>
		///</summary>
        public const uint CompensatorNumber = 805961956;

		///<summary>
		///<para> (300A,00E5) Compensator ID </para>
		///<para> VR: SH VM=1 </para>
		///</summary>
        public const uint CompensatorId = 805961957;

		///<summary>
		///<para> (300A,00E6) Source to Compensator Tray Distance </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint SourceToCompensatorTrayDistance = 805961958;

		///<summary>
		///<para> (300A,00E7) Compensator Rows </para>
		///<para> VR: IS VM=1 </para>
		///</summary>
        public const uint CompensatorRows = 805961959;

		///<summary>
		///<para> (300A,00E8) Compensator Columns </para>
		///<para> VR: IS VM=1 </para>
		///</summary>
        public const uint CompensatorColumns = 805961960;

		///<summary>
		///<para> (300A,00E9) Compensator Pixel Spacing </para>
		///<para> VR: DS VM=2 </para>
		///</summary>
        public const uint CompensatorPixelSpacing = 805961961;

		///<summary>
		///<para> (300A,00EA) Compensator Position </para>
		///<para> VR: DS VM=2 </para>
		///</summary>
        public const uint CompensatorPosition = 805961962;

		///<summary>
		///<para> (300A,00EB) Compensator Transmission Data </para>
		///<para> VR: DS VM=1-n </para>
		///</summary>
        public const uint CompensatorTransmissionData = 805961963;

		///<summary>
		///<para> (300A,00EC) Compensator Thickness Data </para>
		///<para> VR: DS VM=1-n </para>
		///</summary>
        public const uint CompensatorThicknessData = 805961964;

		///<summary>
		///<para> (300A,00ED) Number of Boli </para>
		///<para> VR: IS VM=1 </para>
		///</summary>
        public const uint NumberOfBoli = 805961965;

		///<summary>
		///<para> (300A,00EE) Compensator Type </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint CompensatorType = 805961966;

		///<summary>
		///<para> (300A,00EF) Compensator Tray ID </para>
		///<para> VR: SH VM=1 </para>
		///</summary>
        public const uint CompensatorTrayId = 805961967;

		///<summary>
		///<para> (300A,00F0) Number of Blocks </para>
		///<para> VR: IS VM=1 </para>
		///</summary>
        public const uint NumberOfBlocks = 805961968;

		///<summary>
		///<para> (300A,00F2) Total Block Tray Factor </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint TotalBlockTrayFactor = 805961970;

		///<summary>
		///<para> (300A,00F3) Total Block Tray Water-Equivalent Thickness </para>
		///<para> VR: FL VM=1 </para>
		///</summary>
        public const uint TotalBlockTrayWaterEquivalentThickness = 805961971;

		///<summary>
		///<para> (300A,00F4) Block Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint BlockSequence = 805961972;

		///<summary>
		///<para> (300A,00F5) Block Tray ID </para>
		///<para> VR: SH VM=1 </para>
		///</summary>
        public const uint BlockTrayId = 805961973;

		///<summary>
		///<para> (300A,00F6) Source to Block Tray Distance </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint SourceToBlockTrayDistance = 805961974;

		///<summary>
		///<para> (300A,00F7) Isocenter to Block Tray Distance </para>
		///<para> VR: FL VM=1 </para>
		///</summary>
        public const uint IsocenterToBlockTrayDistance = 805961975;

		///<summary>
		///<para> (300A,00F8) Block Type </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint BlockType = 805961976;

		///<summary>
		///<para> (300A,00F9) Accessory Code </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint AccessoryCode = 805961977;

		///<summary>
		///<para> (300A,00FA) Block Divergence </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint BlockDivergence = 805961978;

		///<summary>
		///<para> (300A,00FB) Block Mounting Position </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint BlockMountingPosition = 805961979;

		///<summary>
		///<para> (300A,00FC) Block Number </para>
		///<para> VR: IS VM=1 </para>
		///</summary>
        public const uint BlockNumber = 805961980;

		///<summary>
		///<para> (300A,00FE) Block Name </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint BlockName = 805961982;

		///<summary>
		///<para> (300A,0100) Block Thickness </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint BlockThickness = 805961984;

		///<summary>
		///<para> (300A,0102) Block Transmission </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint BlockTransmission = 805961986;

		///<summary>
		///<para> (300A,0104) Block Number of Points </para>
		///<para> VR: IS VM=1 </para>
		///</summary>
        public const uint BlockNumberOfPoints = 805961988;

		///<summary>
		///<para> (300A,0106) Block Data </para>
		///<para> VR: DS VM=2-2n </para>
		///</summary>
        public const uint BlockData = 805961990;

		///<summary>
		///<para> (300A,0107) Applicator Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint ApplicatorSequence = 805961991;

		///<summary>
		///<para> (300A,0108) Applicator ID </para>
		///<para> VR: SH VM=1 </para>
		///</summary>
        public const uint ApplicatorId = 805961992;

		///<summary>
		///<para> (300A,0109) Applicator Type </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint ApplicatorType = 805961993;

		///<summary>
		///<para> (300A,010A) Applicator Description </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint ApplicatorDescription = 805961994;

		///<summary>
		///<para> (300A,010C) Cumulative Dose Reference Coefficient </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint CumulativeDoseReferenceCoefficient = 805961996;

		///<summary>
		///<para> (300A,010E) Final Cumulative Meterset Weight </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint FinalCumulativeMetersetWeight = 805961998;

		///<summary>
		///<para> (300A,0110) Number of Control Points </para>
		///<para> VR: IS VM=1 </para>
		///</summary>
        public const uint NumberOfControlPoints = 805962000;

		///<summary>
		///<para> (300A,0111) Control Point Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint ControlPointSequence = 805962001;

		///<summary>
		///<para> (300A,0112) Control Point Index </para>
		///<para> VR: IS VM=1 </para>
		///</summary>
        public const uint ControlPointIndex = 805962002;

		///<summary>
		///<para> (300A,0114) Nominal Beam Energy </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint NominalBeamEnergy = 805962004;

		///<summary>
		///<para> (300A,0115) Dose Rate Set </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint DoseRateSet = 805962005;

		///<summary>
		///<para> (300A,0116) Wedge Position Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint WedgePositionSequence = 805962006;

		///<summary>
		///<para> (300A,0118) Wedge Position </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint WedgePosition = 805962008;

		///<summary>
		///<para> (300A,011A) Beam Limiting Device Position Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint BeamLimitingDevicePositionSequence = 805962010;

		///<summary>
		///<para> (300A,011C) Leaf/Jaw Positions </para>
		///<para> VR: DS VM=2-2n </para>
		///</summary>
        public const uint LeafJawPositions = 805962012;

		///<summary>
		///<para> (300A,011E) Gantry Angle </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint GantryAngle = 805962014;

		///<summary>
		///<para> (300A,011F) Gantry Rotation Direction </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint GantryRotationDirection = 805962015;

		///<summary>
		///<para> (300A,0120) Beam Limiting Device Angle </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint BeamLimitingDeviceAngle = 805962016;

		///<summary>
		///<para> (300A,0121) Beam Limiting Device Rotation Direction </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint BeamLimitingDeviceRotationDirection = 805962017;

		///<summary>
		///<para> (300A,0122) Patient Support Angle </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint PatientSupportAngle = 805962018;

		///<summary>
		///<para> (300A,0123) Patient Support Rotation Direction </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint PatientSupportRotationDirection = 805962019;

		///<summary>
		///<para> (300A,0124) Table Top Eccentric Axis Distance </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint TableTopEccentricAxisDistance = 805962020;

		///<summary>
		///<para> (300A,0125) Table Top Eccentric Angle </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint TableTopEccentricAngle = 805962021;

		///<summary>
		///<para> (300A,0126) Table Top Eccentric Rotation Direction </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint TableTopEccentricRotationDirection = 805962022;

		///<summary>
		///<para> (300A,0128) Table Top Vertical Position </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint TableTopVerticalPosition = 805962024;

		///<summary>
		///<para> (300A,0129) Table Top Longitudinal Position </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint TableTopLongitudinalPosition = 805962025;

		///<summary>
		///<para> (300A,012A) Table Top Lateral Position </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint TableTopLateralPosition = 805962026;

		///<summary>
		///<para> (300A,012C) Isocenter Position </para>
		///<para> VR: DS VM=3 </para>
		///</summary>
        public const uint IsocenterPosition = 805962028;

		///<summary>
		///<para> (300A,012E) Surface Entry Point </para>
		///<para> VR: DS VM=3 </para>
		///</summary>
        public const uint SurfaceEntryPoint = 805962030;

		///<summary>
		///<para> (300A,0130) Source to Surface Distance </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint SourceToSurfaceDistance = 805962032;

		///<summary>
		///<para> (300A,0131) Average Beam Dose Point Source to External Contour Distance </para>
		///<para> VR: FL VM=1 </para>
		///</summary>
        public const uint AverageBeamDosePointSourceToExternalContourDistance = 805962033;

		///<summary>
		///<para> (300A,0132) Source to External Contour Distance </para>
		///<para> VR: FL VM=1 </para>
		///</summary>
        public const uint SourceToExternalContourDistance = 805962034;

		///<summary>
		///<para> (300A,0133) External Contour Entry Point </para>
		///<para> VR: FL VM=3 </para>
		///</summary>
        public const uint ExternalContourEntryPoint = 805962035;

		///<summary>
		///<para> (300A,0134) Cumulative Meterset Weight </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint CumulativeMetersetWeight = 805962036;

		///<summary>
		///<para> (300A,0140) Table Top Pitch Angle </para>
		///<para> VR: FL VM=1 </para>
		///</summary>
        public const uint TableTopPitchAngle = 805962048;

		///<summary>
		///<para> (300A,0142) Table Top Pitch Rotation Direction </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint TableTopPitchRotationDirection = 805962050;

		///<summary>
		///<para> (300A,0144) Table Top Roll Angle </para>
		///<para> VR: FL VM=1 </para>
		///</summary>
        public const uint TableTopRollAngle = 805962052;

		///<summary>
		///<para> (300A,0146) Table Top Roll Rotation Direction </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint TableTopRollRotationDirection = 805962054;

		///<summary>
		///<para> (300A,0148) Head Fixation Angle </para>
		///<para> VR: FL VM=1 </para>
		///</summary>
        public const uint HeadFixationAngle = 805962056;

		///<summary>
		///<para> (300A,014A) Gantry Pitch Angle </para>
		///<para> VR: FL VM=1 </para>
		///</summary>
        public const uint GantryPitchAngle = 805962058;

		///<summary>
		///<para> (300A,014C) Gantry Pitch Rotation Direction </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint GantryPitchRotationDirection = 805962060;

		///<summary>
		///<para> (300A,014E) Gantry Pitch Angle Tolerance </para>
		///<para> VR: FL VM=1 </para>
		///</summary>
        public const uint GantryPitchAngleTolerance = 805962062;

		///<summary>
		///<para> (300A,0150) Fixation Eye </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint FixationEye = 805962064;

		///<summary>
		///<para> (300A,0151) Chair Head Frame Position </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint ChairHeadFramePosition = 805962065;

		///<summary>
		///<para> (300A,0152) Head Fixation Angle Tolerance </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint HeadFixationAngleTolerance = 805962066;

		///<summary>
		///<para> (300A,0153) Chair Head Frame Position Tolerance </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint ChairHeadFramePositionTolerance = 805962067;

		///<summary>
		///<para> (300A,0154) Fixation Light Azimuthal Angle Tolerance </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint FixationLightAzimuthalAngleTolerance = 805962068;

		///<summary>
		///<para> (300A,0155) Fixation Light Polar Angle Tolerance </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint FixationLightPolarAngleTolerance = 805962069;

		///<summary>
		///<para> (300A,0180) Patient Setup Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint PatientSetupSequence = 805962112;

		///<summary>
		///<para> (300A,0182) Patient Setup Number </para>
		///<para> VR: IS VM=1 </para>
		///</summary>
        public const uint PatientSetupNumber = 805962114;

		///<summary>
		///<para> (300A,0183) Patient Setup Label </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint PatientSetupLabel = 805962115;

		///<summary>
		///<para> (300A,0184) Patient Additional Position </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint PatientAdditionalPosition = 805962116;

		///<summary>
		///<para> (300A,0190) Fixation Device Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint FixationDeviceSequence = 805962128;

		///<summary>
		///<para> (300A,0192) Fixation Device Type </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint FixationDeviceType = 805962130;

		///<summary>
		///<para> (300A,0194) Fixation Device Label </para>
		///<para> VR: SH VM=1 </para>
		///</summary>
        public const uint FixationDeviceLabel = 805962132;

		///<summary>
		///<para> (300A,0196) Fixation Device Description </para>
		///<para> VR: ST VM=1 </para>
		///</summary>
        public const uint FixationDeviceDescription = 805962134;

		///<summary>
		///<para> (300A,0198) Fixation Device Position </para>
		///<para> VR: SH VM=1 </para>
		///</summary>
        public const uint FixationDevicePosition = 805962136;

		///<summary>
		///<para> (300A,0199) Fixation Device Pitch Angle </para>
		///<para> VR: FL VM=1 </para>
		///</summary>
        public const uint FixationDevicePitchAngle = 805962137;

		///<summary>
		///<para> (300A,019A) Fixation Device Roll Angle </para>
		///<para> VR: FL VM=1 </para>
		///</summary>
        public const uint FixationDeviceRollAngle = 805962138;

		///<summary>
		///<para> (300A,01A0) Shielding Device Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint ShieldingDeviceSequence = 805962144;

		///<summary>
		///<para> (300A,01A2) Shielding Device Type </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint ShieldingDeviceType = 805962146;

		///<summary>
		///<para> (300A,01A4) Shielding Device Label </para>
		///<para> VR: SH VM=1 </para>
		///</summary>
        public const uint ShieldingDeviceLabel = 805962148;

		///<summary>
		///<para> (300A,01A6) Shielding Device Description </para>
		///<para> VR: ST VM=1 </para>
		///</summary>
        public const uint ShieldingDeviceDescription = 805962150;

		///<summary>
		///<para> (300A,01A8) Shielding Device Position </para>
		///<para> VR: SH VM=1 </para>
		///</summary>
        public const uint ShieldingDevicePosition = 805962152;

		///<summary>
		///<para> (300A,01B0) Setup Technique </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint SetupTechnique = 805962160;

		///<summary>
		///<para> (300A,01B2) Setup Technique Description </para>
		///<para> VR: ST VM=1 </para>
		///</summary>
        public const uint SetupTechniqueDescription = 805962162;

		///<summary>
		///<para> (300A,01B4) Setup Device Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint SetupDeviceSequence = 805962164;

		///<summary>
		///<para> (300A,01B6) Setup Device Type </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint SetupDeviceType = 805962166;

		///<summary>
		///<para> (300A,01B8) Setup Device Label </para>
		///<para> VR: SH VM=1 </para>
		///</summary>
        public const uint SetupDeviceLabel = 805962168;

		///<summary>
		///<para> (300A,01BA) Setup Device Description </para>
		///<para> VR: ST VM=1 </para>
		///</summary>
        public const uint SetupDeviceDescription = 805962170;

		///<summary>
		///<para> (300A,01BC) Setup Device Parameter </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint SetupDeviceParameter = 805962172;

		///<summary>
		///<para> (300A,01D0) Setup Reference Description </para>
		///<para> VR: ST VM=1 </para>
		///</summary>
        public const uint SetupReferenceDescription = 805962192;

		///<summary>
		///<para> (300A,01D2) Table Top Vertical Setup Displacement </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint TableTopVerticalSetupDisplacement = 805962194;

		///<summary>
		///<para> (300A,01D4) Table Top Longitudinal Setup Displacement </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint TableTopLongitudinalSetupDisplacement = 805962196;

		///<summary>
		///<para> (300A,01D6) Table Top Lateral Setup Displacement </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint TableTopLateralSetupDisplacement = 805962198;

		///<summary>
		///<para> (300A,0200) Brachy Treatment Technique </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint BrachyTreatmentTechnique = 805962240;

		///<summary>
		///<para> (300A,0202) Brachy Treatment Type </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint BrachyTreatmentType = 805962242;

		///<summary>
		///<para> (300A,0206) Treatment Machine Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint TreatmentMachineSequence = 805962246;

		///<summary>
		///<para> (300A,0210) Source Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint SourceSequence = 805962256;

		///<summary>
		///<para> (300A,0212) Source Number </para>
		///<para> VR: IS VM=1 </para>
		///</summary>
        public const uint SourceNumber = 805962258;

		///<summary>
		///<para> (300A,0214) Source Type </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint SourceType = 805962260;

		///<summary>
		///<para> (300A,0216) Source Manufacturer </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint SourceManufacturer = 805962262;

		///<summary>
		///<para> (300A,0218) Active Source Diameter </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint ActiveSourceDiameter = 805962264;

		///<summary>
		///<para> (300A,021A) Active Source Length </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint ActiveSourceLength = 805962266;

		///<summary>
		///<para> (300A,021B) Source Model ID </para>
		///<para> VR: SH VM=1 </para>
		///</summary>
        public const uint SourceModelId = 805962267;

		///<summary>
		///<para> (300A,021C) Source Description </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint SourceDescription = 805962268;

		///<summary>
		///<para> (300A,0222) Source Encapsulation Nominal Thickness </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint SourceEncapsulationNominalThickness = 805962274;

		///<summary>
		///<para> (300A,0224) Source Encapsulation Nominal Transmission </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint SourceEncapsulationNominalTransmission = 805962276;

		///<summary>
		///<para> (300A,0226) Source Isotope Name </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint SourceIsotopeName = 805962278;

		///<summary>
		///<para> (300A,0228) Source Isotope Half Life </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint SourceIsotopeHalfLife = 805962280;

		///<summary>
		///<para> (300A,0229) Source Strength Units </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint SourceStrengthUnits = 805962281;

		///<summary>
		///<para> (300A,022A) Reference Air Kerma Rate </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint ReferenceAirKermaRate = 805962282;

		///<summary>
		///<para> (300A,022B) Source Strength </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint SourceStrength = 805962283;

		///<summary>
		///<para> (300A,022C) Source Strength Reference Date </para>
		///<para> VR: DA VM=1 </para>
		///</summary>
        public const uint SourceStrengthReferenceDate = 805962284;

		///<summary>
		///<para> (300A,022E) Source Strength Reference Time </para>
		///<para> VR: TM VM=1 </para>
		///</summary>
        public const uint SourceStrengthReferenceTime = 805962286;

		///<summary>
		///<para> (300A,0230) Application Setup Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint ApplicationSetupSequence = 805962288;

		///<summary>
		///<para> (300A,0232) Application Setup Type </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint ApplicationSetupType = 805962290;

		///<summary>
		///<para> (300A,0234) Application Setup Number </para>
		///<para> VR: IS VM=1 </para>
		///</summary>
        public const uint ApplicationSetupNumber = 805962292;

		///<summary>
		///<para> (300A,0236) Application Setup Name </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint ApplicationSetupName = 805962294;

		///<summary>
		///<para> (300A,0238) Application Setup Manufacturer </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint ApplicationSetupManufacturer = 805962296;

		///<summary>
		///<para> (300A,0240) Template Number </para>
		///<para> VR: IS VM=1 </para>
		///</summary>
        public const uint TemplateNumber = 805962304;

		///<summary>
		///<para> (300A,0242) Template Type </para>
		///<para> VR: SH VM=1 </para>
		///</summary>
        public const uint TemplateType = 805962306;

		///<summary>
		///<para> (300A,0244) Template Name </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint TemplateName = 805962308;

		///<summary>
		///<para> (300A,0250) Total Reference Air Kerma </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint TotalReferenceAirKerma = 805962320;

		///<summary>
		///<para> (300A,0260) Brachy Accessory Device Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint BrachyAccessoryDeviceSequence = 805962336;

		///<summary>
		///<para> (300A,0262) Brachy Accessory Device Number </para>
		///<para> VR: IS VM=1 </para>
		///</summary>
        public const uint BrachyAccessoryDeviceNumber = 805962338;

		///<summary>
		///<para> (300A,0263) Brachy Accessory Device ID </para>
		///<para> VR: SH VM=1 </para>
		///</summary>
        public const uint BrachyAccessoryDeviceId = 805962339;

		///<summary>
		///<para> (300A,0264) Brachy Accessory Device Type </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint BrachyAccessoryDeviceType = 805962340;

		///<summary>
		///<para> (300A,0266) Brachy Accessory Device Name </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint BrachyAccessoryDeviceName = 805962342;

		///<summary>
		///<para> (300A,026A) Brachy Accessory Device Nominal Thickness </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint BrachyAccessoryDeviceNominalThickness = 805962346;

		///<summary>
		///<para> (300A,026C) Brachy Accessory Device Nominal Transmission </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint BrachyAccessoryDeviceNominalTransmission = 805962348;

		///<summary>
		///<para> (300A,0280) Channel Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint ChannelSequence = 805962368;

		///<summary>
		///<para> (300A,0282) Channel Number </para>
		///<para> VR: IS VM=1 </para>
		///</summary>
        public const uint ChannelNumber = 805962370;

		///<summary>
		///<para> (300A,0284) Channel Length </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint ChannelLength = 805962372;

		///<summary>
		///<para> (300A,0286) Channel Total Time </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint ChannelTotalTime = 805962374;

		///<summary>
		///<para> (300A,0288) Source Movement Type </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint SourceMovementType = 805962376;

		///<summary>
		///<para> (300A,028A) Number of Pulses </para>
		///<para> VR: IS VM=1 </para>
		///</summary>
        public const uint NumberOfPulses = 805962378;

		///<summary>
		///<para> (300A,028C) Pulse Repetition Interval </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint PulseRepetitionInterval = 805962380;

		///<summary>
		///<para> (300A,0290) Source Applicator Number </para>
		///<para> VR: IS VM=1 </para>
		///</summary>
        public const uint SourceApplicatorNumber = 805962384;

		///<summary>
		///<para> (300A,0291) Source Applicator ID </para>
		///<para> VR: SH VM=1 </para>
		///</summary>
        public const uint SourceApplicatorId = 805962385;

		///<summary>
		///<para> (300A,0292) Source Applicator Type </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint SourceApplicatorType = 805962386;

		///<summary>
		///<para> (300A,0294) Source Applicator Name </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint SourceApplicatorName = 805962388;

		///<summary>
		///<para> (300A,0296) Source Applicator Length </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint SourceApplicatorLength = 805962390;

		///<summary>
		///<para> (300A,0298) Source Applicator Manufacturer </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint SourceApplicatorManufacturer = 805962392;

		///<summary>
		///<para> (300A,029C) Source Applicator Wall Nominal Thickness </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint SourceApplicatorWallNominalThickness = 805962396;

		///<summary>
		///<para> (300A,029E) Source Applicator Wall Nominal Transmission </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint SourceApplicatorWallNominalTransmission = 805962398;

		///<summary>
		///<para> (300A,02A0) Source Applicator Step Size </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint SourceApplicatorStepSize = 805962400;

		///<summary>
		///<para> (300A,02A2) Transfer Tube Number </para>
		///<para> VR: IS VM=1 </para>
		///</summary>
        public const uint TransferTubeNumber = 805962402;

		///<summary>
		///<para> (300A,02A4) Transfer Tube Length </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint TransferTubeLength = 805962404;

		///<summary>
		///<para> (300A,02B0) Channel Shield Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint ChannelShieldSequence = 805962416;

		///<summary>
		///<para> (300A,02B2) Channel Shield Number </para>
		///<para> VR: IS VM=1 </para>
		///</summary>
        public const uint ChannelShieldNumber = 805962418;

		///<summary>
		///<para> (300A,02B3) Channel Shield ID </para>
		///<para> VR: SH VM=1 </para>
		///</summary>
        public const uint ChannelShieldId = 805962419;

		///<summary>
		///<para> (300A,02B4) Channel Shield Name </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint ChannelShieldName = 805962420;

		///<summary>
		///<para> (300A,02B8) Channel Shield Nominal Thickness </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint ChannelShieldNominalThickness = 805962424;

		///<summary>
		///<para> (300A,02BA) Channel Shield Nominal Transmission </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint ChannelShieldNominalTransmission = 805962426;

		///<summary>
		///<para> (300A,02C8) Final Cumulative Time Weight </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint FinalCumulativeTimeWeight = 805962440;

		///<summary>
		///<para> (300A,02D0) Brachy Control Point Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint BrachyControlPointSequence = 805962448;

		///<summary>
		///<para> (300A,02D2) Control Point Relative Position </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint ControlPointRelativePosition = 805962450;

		///<summary>
		///<para> (300A,02D4) Control Point 3D Position </para>
		///<para> VR: DS VM=3 </para>
		///</summary>
        public const uint ControlPoint3dPosition = 805962452;

		///<summary>
		///<para> (300A,02D6) Cumulative Time Weight </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint CumulativeTimeWeight = 805962454;

		///<summary>
		///<para> (300A,02E0) Compensator Divergence </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint CompensatorDivergence = 805962464;

		///<summary>
		///<para> (300A,02E1) Compensator Mounting Position </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint CompensatorMountingPosition = 805962465;

		///<summary>
		///<para> (300A,02E2) Source to Compensator Distance </para>
		///<para> VR: DS VM=1-n </para>
		///</summary>
        public const uint SourceToCompensatorDistance = 805962466;

		///<summary>
		///<para> (300A,02E3) Total Compensator Tray Water-Equivalent Thickness </para>
		///<para> VR: FL VM=1 </para>
		///</summary>
        public const uint TotalCompensatorTrayWaterEquivalentThickness = 805962467;

		///<summary>
		///<para> (300A,02E4) Isocenter to Compensator Tray Distance </para>
		///<para> VR: FL VM=1 </para>
		///</summary>
        public const uint IsocenterToCompensatorTrayDistance = 805962468;

		///<summary>
		///<para> (300A,02E5) Compensator Column Offset </para>
		///<para> VR: FL VM=1 </para>
		///</summary>
        public const uint CompensatorColumnOffset = 805962469;

		///<summary>
		///<para> (300A,02E6) Isocenter to Compensator Distances </para>
		///<para> VR: FL VM=1-n </para>
		///</summary>
        public const uint IsocenterToCompensatorDistances = 805962470;

		///<summary>
		///<para> (300A,02E7) Compensator Relative Stopping Power Ratio </para>
		///<para> VR: FL VM=1 </para>
		///</summary>
        public const uint CompensatorRelativeStoppingPowerRatio = 805962471;

		///<summary>
		///<para> (300A,02E8) Compensator Milling Tool Diameter </para>
		///<para> VR: FL VM=1 </para>
		///</summary>
        public const uint CompensatorMillingToolDiameter = 805962472;

		///<summary>
		///<para> (300A,02EA) Ion Range Compensator Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint IonRangeCompensatorSequence = 805962474;

		///<summary>
		///<para> (300A,02EB) Compensator Description </para>
		///<para> VR: LT VM=1 </para>
		///</summary>
        public const uint CompensatorDescription = 805962475;

		///<summary>
		///<para> (300A,0302) Radiation Mass Number </para>
		///<para> VR: IS VM=1 </para>
		///</summary>
        public const uint RadiationMassNumber = 805962498;

		///<summary>
		///<para> (300A,0304) Radiation Atomic Number </para>
		///<para> VR: IS VM=1 </para>
		///</summary>
        public const uint RadiationAtomicNumber = 805962500;

		///<summary>
		///<para> (300A,0306) Radiation Charge State </para>
		///<para> VR: SS VM=1 </para>
		///</summary>
        public const uint RadiationChargeState = 805962502;

		///<summary>
		///<para> (300A,0308) Scan Mode </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint ScanMode = 805962504;

		///<summary>
		///<para> (300A,0309) Modulated Scan Mode Type </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint ModulatedScanModeType = 805962505;

		///<summary>
		///<para> (300A,030A) Virtual Source-Axis Distances </para>
		///<para> VR: FL VM=2 </para>
		///</summary>
        public const uint VirtualSourceAxisDistances = 805962506;

		///<summary>
		///<para> (300A,030C) Snout Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint SnoutSequence = 805962508;

		///<summary>
		///<para> (300A,030D) Snout Position </para>
		///<para> VR: FL VM=1 </para>
		///</summary>
        public const uint SnoutPosition = 805962509;

		///<summary>
		///<para> (300A,030F) Snout ID </para>
		///<para> VR: SH VM=1 </para>
		///</summary>
        public const uint SnoutId = 805962511;

		///<summary>
		///<para> (300A,0312) Number of Range Shifters </para>
		///<para> VR: IS VM=1 </para>
		///</summary>
        public const uint NumberOfRangeShifters = 805962514;

		///<summary>
		///<para> (300A,0314) Range Shifter Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint RangeShifterSequence = 805962516;

		///<summary>
		///<para> (300A,0316) Range Shifter Number </para>
		///<para> VR: IS VM=1 </para>
		///</summary>
        public const uint RangeShifterNumber = 805962518;

		///<summary>
		///<para> (300A,0318) Range Shifter ID </para>
		///<para> VR: SH VM=1 </para>
		///</summary>
        public const uint RangeShifterId = 805962520;

		///<summary>
		///<para> (300A,0320) Range Shifter Type </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint RangeShifterType = 805962528;

		///<summary>
		///<para> (300A,0322) Range Shifter Description </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint RangeShifterDescription = 805962530;

		///<summary>
		///<para> (300A,0330) Number of Lateral Spreading Devices </para>
		///<para> VR: IS VM=1 </para>
		///</summary>
        public const uint NumberOfLateralSpreadingDevices = 805962544;

		///<summary>
		///<para> (300A,0332) Lateral Spreading Device Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint LateralSpreadingDeviceSequence = 805962546;

		///<summary>
		///<para> (300A,0334) Lateral Spreading Device Number </para>
		///<para> VR: IS VM=1 </para>
		///</summary>
        public const uint LateralSpreadingDeviceNumber = 805962548;

		///<summary>
		///<para> (300A,0336) Lateral Spreading Device ID </para>
		///<para> VR: SH VM=1 </para>
		///</summary>
        public const uint LateralSpreadingDeviceId = 805962550;

		///<summary>
		///<para> (300A,0338) Lateral Spreading Device Type </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint LateralSpreadingDeviceType = 805962552;

		///<summary>
		///<para> (300A,033A) Lateral Spreading Device Description </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint LateralSpreadingDeviceDescription = 805962554;

		///<summary>
		///<para> (300A,033C) Lateral Spreading Device Water Equivalent Thickness </para>
		///<para> VR: FL VM=1 </para>
		///</summary>
        public const uint LateralSpreadingDeviceWaterEquivalentThickness = 805962556;

		///<summary>
		///<para> (300A,0340) Number of Range Modulators </para>
		///<para> VR: IS VM=1 </para>
		///</summary>
        public const uint NumberOfRangeModulators = 805962560;

		///<summary>
		///<para> (300A,0342) Range Modulator Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint RangeModulatorSequence = 805962562;

		///<summary>
		///<para> (300A,0344) Range Modulator Number </para>
		///<para> VR: IS VM=1 </para>
		///</summary>
        public const uint RangeModulatorNumber = 805962564;

		///<summary>
		///<para> (300A,0346) Range Modulator ID </para>
		///<para> VR: SH VM=1 </para>
		///</summary>
        public const uint RangeModulatorId = 805962566;

		///<summary>
		///<para> (300A,0348) Range Modulator Type </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint RangeModulatorType = 805962568;

		///<summary>
		///<para> (300A,034A) Range Modulator Description </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint RangeModulatorDescription = 805962570;

		///<summary>
		///<para> (300A,034C) Beam Current Modulation ID </para>
		///<para> VR: SH VM=1 </para>
		///</summary>
        public const uint BeamCurrentModulationId = 805962572;

		///<summary>
		///<para> (300A,0350) Patient Support Type </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint PatientSupportType = 805962576;

		///<summary>
		///<para> (300A,0352) Patient Support ID </para>
		///<para> VR: SH VM=1 </para>
		///</summary>
        public const uint PatientSupportId = 805962578;

		///<summary>
		///<para> (300A,0354) Patient Support Accessory Code </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint PatientSupportAccessoryCode = 805962580;

		///<summary>
		///<para> (300A,0355) Tray Accessory Code </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint TrayAccessoryCode = 805962581;

		///<summary>
		///<para> (300A,0356) Fixation Light Azimuthal Angle </para>
		///<para> VR: FL VM=1 </para>
		///</summary>
        public const uint FixationLightAzimuthalAngle = 805962582;

		///<summary>
		///<para> (300A,0358) Fixation Light Polar Angle </para>
		///<para> VR: FL VM=1 </para>
		///</summary>
        public const uint FixationLightPolarAngle = 805962584;

		///<summary>
		///<para> (300A,035A) Meterset Rate </para>
		///<para> VR: FL VM=1 </para>
		///</summary>
        public const uint MetersetRate = 805962586;

		///<summary>
		///<para> (300A,0360) Range Shifter Settings Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint RangeShifterSettingsSequence = 805962592;

		///<summary>
		///<para> (300A,0362) Range Shifter Setting </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint RangeShifterSetting = 805962594;

		///<summary>
		///<para> (300A,0364) Isocenter to Range Shifter Distance </para>
		///<para> VR: FL VM=1 </para>
		///</summary>
        public const uint IsocenterToRangeShifterDistance = 805962596;

		///<summary>
		///<para> (300A,0366) Range Shifter Water Equivalent Thickness </para>
		///<para> VR: FL VM=1 </para>
		///</summary>
        public const uint RangeShifterWaterEquivalentThickness = 805962598;

		///<summary>
		///<para> (300A,0370) Lateral Spreading Device Settings Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint LateralSpreadingDeviceSettingsSequence = 805962608;

		///<summary>
		///<para> (300A,0372) Lateral Spreading Device Setting </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint LateralSpreadingDeviceSetting = 805962610;

		///<summary>
		///<para> (300A,0374) Isocenter to Lateral Spreading Device Distance </para>
		///<para> VR: FL VM=1 </para>
		///</summary>
        public const uint IsocenterToLateralSpreadingDeviceDistance = 805962612;

		///<summary>
		///<para> (300A,0380) Range Modulator Settings Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint RangeModulatorSettingsSequence = 805962624;

		///<summary>
		///<para> (300A,0382) Range Modulator Gating Start Value </para>
		///<para> VR: FL VM=1 </para>
		///</summary>
        public const uint RangeModulatorGatingStartValue = 805962626;

		///<summary>
		///<para> (300A,0384) Range Modulator Gating Stop Value </para>
		///<para> VR: FL VM=1 </para>
		///</summary>
        public const uint RangeModulatorGatingStopValue = 805962628;

		///<summary>
		///<para> (300A,0386) Range Modulator Gating Start Water Equivalent Thickness </para>
		///<para> VR: FL VM=1 </para>
		///</summary>
        public const uint RangeModulatorGatingStartWaterEquivalentThickness = 805962630;

		///<summary>
		///<para> (300A,0388) Range Modulator Gating Stop Water Equivalent Thickness </para>
		///<para> VR: FL VM=1 </para>
		///</summary>
        public const uint RangeModulatorGatingStopWaterEquivalentThickness = 805962632;

		///<summary>
		///<para> (300A,038A) Isocenter to Range Modulator Distance </para>
		///<para> VR: FL VM=1 </para>
		///</summary>
        public const uint IsocenterToRangeModulatorDistance = 805962634;

		///<summary>
		///<para> (300A,038F) Scan Spot Time Offset </para>
		///<para> VR: FL VM=1-n </para>
		///</summary>
        public const uint ScanSpotTimeOffset = 805962639;

		///<summary>
		///<para> (300A,0390) Scan Spot Tune ID </para>
		///<para> VR: SH VM=1 </para>
		///</summary>
        public const uint ScanSpotTuneId = 805962640;

		///<summary>
		///<para> (300A,0391) Scan Spot Prescribed Indices </para>
		///<para> VR: IS VM=1-n </para>
		///</summary>
        public const uint ScanSpotPrescribedIndices = 805962641;

		///<summary>
		///<para> (300A,0392) Number of Scan Spot Positions </para>
		///<para> VR: IS VM=1 </para>
		///</summary>
        public const uint NumberOfScanSpotPositions = 805962642;

		///<summary>
		///<para> (300A,0393) Scan Spot Reordered </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint ScanSpotReordered = 805962643;

		///<summary>
		///<para> (300A,0394) Scan Spot Position Map </para>
		///<para> VR: FL VM=1-n </para>
		///</summary>
        public const uint ScanSpotPositionMap = 805962644;

		///<summary>
		///<para> (300A,0395) Scan Spot Reordering Allowed </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint ScanSpotReorderingAllowed = 805962645;

		///<summary>
		///<para> (300A,0396) Scan Spot Meterset Weights </para>
		///<para> VR: FL VM=1-n </para>
		///</summary>
        public const uint ScanSpotMetersetWeights = 805962646;

		///<summary>
		///<para> (300A,0398) Scanning Spot Size </para>
		///<para> VR: FL VM=2 </para>
		///</summary>
        public const uint ScanningSpotSize = 805962648;

		///<summary>
		///<para> (300A,039A) Number of Paintings </para>
		///<para> VR: IS VM=1 </para>
		///</summary>
        public const uint NumberOfPaintings = 805962650;

		///<summary>
		///<para> (300A,03A0) Ion Tolerance Table Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint IonToleranceTableSequence = 805962656;

		///<summary>
		///<para> (300A,03A2) Ion Beam Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint IonBeamSequence = 805962658;

		///<summary>
		///<para> (300A,03A4) Ion Beam Limiting Device Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint IonBeamLimitingDeviceSequence = 805962660;

		///<summary>
		///<para> (300A,03A6) Ion Block Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint IonBlockSequence = 805962662;

		///<summary>
		///<para> (300A,03A8) Ion Control Point Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint IonControlPointSequence = 805962664;

		///<summary>
		///<para> (300A,03AA) Ion Wedge Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint IonWedgeSequence = 805962666;

		///<summary>
		///<para> (300A,03AC) Ion Wedge Position Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint IonWedgePositionSequence = 805962668;

		///<summary>
		///<para> (300A,0401) Referenced Setup Image Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint ReferencedSetupImageSequence = 805962753;

		///<summary>
		///<para> (300A,0402) Setup Image Comment </para>
		///<para> VR: ST VM=1 </para>
		///</summary>
        public const uint SetupImageComment = 805962754;

		///<summary>
		///<para> (300A,0410) Motion Synchronization Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint MotionSynchronizationSequence = 805962768;

		///<summary>
		///<para> (300A,0412) Control Point Orientation </para>
		///<para> VR: FL VM=3 </para>
		///</summary>
        public const uint ControlPointOrientation = 805962770;

		///<summary>
		///<para> (300A,0420) General Accessory Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint GeneralAccessorySequence = 805962784;

		///<summary>
		///<para> (300A,0421) General Accessory ID </para>
		///<para> VR: SH VM=1 </para>
		///</summary>
        public const uint GeneralAccessoryId = 805962785;

		///<summary>
		///<para> (300A,0422) General Accessory Description </para>
		///<para> VR: ST VM=1 </para>
		///</summary>
        public const uint GeneralAccessoryDescription = 805962786;

		///<summary>
		///<para> (300A,0423) General Accessory Type </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint GeneralAccessoryType = 805962787;

		///<summary>
		///<para> (300A,0424) General Accessory Number </para>
		///<para> VR: IS VM=1 </para>
		///</summary>
        public const uint GeneralAccessoryNumber = 805962788;

		///<summary>
		///<para> (300A,0425) Source to General Accessory Distance </para>
		///<para> VR: FL VM=1 </para>
		///</summary>
        public const uint SourceToGeneralAccessoryDistance = 805962789;

		///<summary>
		///<para> (300A,0431) Applicator Geometry Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint ApplicatorGeometrySequence = 805962801;

		///<summary>
		///<para> (300A,0432) Applicator Aperture Shape </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint ApplicatorApertureShape = 805962802;

		///<summary>
		///<para> (300A,0433) Applicator Opening </para>
		///<para> VR: FL VM=1 </para>
		///</summary>
        public const uint ApplicatorOpening = 805962803;

		///<summary>
		///<para> (300A,0434) Applicator Opening X </para>
		///<para> VR: FL VM=1 </para>
		///</summary>
        public const uint ApplicatorOpeningX = 805962804;

		///<summary>
		///<para> (300A,0435) Applicator Opening Y </para>
		///<para> VR: FL VM=1 </para>
		///</summary>
        public const uint ApplicatorOpeningY = 805962805;

		///<summary>
		///<para> (300A,0436) Source to Applicator Mounting Position Distance </para>
		///<para> VR: FL VM=1 </para>
		///</summary>
        public const uint SourceToApplicatorMountingPositionDistance = 805962806;

		///<summary>
		///<para> (300A,0440) Number of Block Slab Items </para>
		///<para> VR: IS VM=1 </para>
		///</summary>
        public const uint NumberOfBlockSlabItems = 805962816;

		///<summary>
		///<para> (300A,0441) Block Slab Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint BlockSlabSequence = 805962817;

		///<summary>
		///<para> (300A,0442) Block Slab Thickness </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint BlockSlabThickness = 805962818;

		///<summary>
		///<para> (300A,0443) Block Slab Number </para>
		///<para> VR: US VM=1 </para>
		///</summary>
        public const uint BlockSlabNumber = 805962819;

		///<summary>
		///<para> (300A,0450) Device Motion Control Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint DeviceMotionControlSequence = 805962832;

		///<summary>
		///<para> (300A,0451) Device Motion Execution Mode </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint DeviceMotionExecutionMode = 805962833;

		///<summary>
		///<para> (300A,0452) Device Motion Observation Mode </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint DeviceMotionObservationMode = 805962834;

		///<summary>
		///<para> (300A,0453) Device Motion Parameter Code Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint DeviceMotionParameterCodeSequence = 805962835;

		///<summary>
		///<para> (300A,0501) Distal Depth Fraction </para>
		///<para> VR: FL VM=1 </para>
		///</summary>
        public const uint DistalDepthFraction = 805963009;

		///<summary>
		///<para> (300A,0502) Distal Depth </para>
		///<para> VR: FL VM=1 </para>
		///</summary>
        public const uint DistalDepth = 805963010;

		///<summary>
		///<para> (300A,0503) Nominal Range Modulation Fractions </para>
		///<para> VR: FL VM=2 </para>
		///</summary>
        public const uint NominalRangeModulationFractions = 805963011;

		///<summary>
		///<para> (300A,0504) Nominal Range Modulated Region Depths </para>
		///<para> VR: FL VM=2 </para>
		///</summary>
        public const uint NominalRangeModulatedRegionDepths = 805963012;

		///<summary>
		///<para> (300A,0505) Depth Dose Parameters Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint DepthDoseParametersSequence = 805963013;

		///<summary>
		///<para> (300A,0506) Delivered Depth Dose Parameters Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint DeliveredDepthDoseParametersSequence = 805963014;

		///<summary>
		///<para> (300A,0507) Delivered Distal Depth Fraction </para>
		///<para> VR: FL VM=1 </para>
		///</summary>
        public const uint DeliveredDistalDepthFraction = 805963015;

		///<summary>
		///<para> (300A,0508) Delivered Distal Depth </para>
		///<para> VR: FL VM=1 </para>
		///</summary>
        public const uint DeliveredDistalDepth = 805963016;

		///<summary>
		///<para> (300A,0509) Delivered Nominal Range Modulation Fractions </para>
		///<para> VR: FL VM=2 </para>
		///</summary>
        public const uint DeliveredNominalRangeModulationFractions = 805963017;

		///<summary>
		///<para> (300A,0510) Delivered Nominal Range Modulated Region Depths </para>
		///<para> VR: FL VM=2 </para>
		///</summary>
        public const uint DeliveredNominalRangeModulatedRegionDepths = 805963024;

		///<summary>
		///<para> (300A,0511) Delivered Reference Dose Definition </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint DeliveredReferenceDoseDefinition = 805963025;

		///<summary>
		///<para> (300A,0512) Reference Dose Definition </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint ReferenceDoseDefinition = 805963026;

		///<summary>
		///<para> (300C,0002) Referenced RT Plan Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint ReferencedRtPlanSequence = 806092802;

		///<summary>
		///<para> (300C,0004) Referenced Beam Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint ReferencedBeamSequence = 806092804;

		///<summary>
		///<para> (300C,0006) Referenced Beam Number </para>
		///<para> VR: IS VM=1 </para>
		///</summary>
        public const uint ReferencedBeamNumber = 806092806;

		///<summary>
		///<para> (300C,0007) Referenced Reference Image Number </para>
		///<para> VR: IS VM=1 </para>
		///</summary>
        public const uint ReferencedReferenceImageNumber = 806092807;

		///<summary>
		///<para> (300C,0008) Start Cumulative Meterset Weight </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint StartCumulativeMetersetWeight = 806092808;

		///<summary>
		///<para> (300C,0009) End Cumulative Meterset Weight </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint EndCumulativeMetersetWeight = 806092809;

		///<summary>
		///<para> (300C,000A) Referenced Brachy Application Setup Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint ReferencedBrachyApplicationSetupSequence = 806092810;

		///<summary>
		///<para> (300C,000C) Referenced Brachy Application Setup Number </para>
		///<para> VR: IS VM=1 </para>
		///</summary>
        public const uint ReferencedBrachyApplicationSetupNumber = 806092812;

		///<summary>
		///<para> (300C,000E) Referenced Source Number </para>
		///<para> VR: IS VM=1 </para>
		///</summary>
        public const uint ReferencedSourceNumber = 806092814;

		///<summary>
		///<para> (300C,0020) Referenced Fraction Group Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint ReferencedFractionGroupSequence = 806092832;

		///<summary>
		///<para> (300C,0022) Referenced Fraction Group Number </para>
		///<para> VR: IS VM=1 </para>
		///</summary>
        public const uint ReferencedFractionGroupNumber = 806092834;

		///<summary>
		///<para> (300C,0040) Referenced Verification Image Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint ReferencedVerificationImageSequence = 806092864;

		///<summary>
		///<para> (300C,0042) Referenced Reference Image Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint ReferencedReferenceImageSequence = 806092866;

		///<summary>
		///<para> (300C,0050) Referenced Dose Reference Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint ReferencedDoseReferenceSequence = 806092880;

		///<summary>
		///<para> (300C,0051) Referenced Dose Reference Number </para>
		///<para> VR: IS VM=1 </para>
		///</summary>
        public const uint ReferencedDoseReferenceNumber = 806092881;

		///<summary>
		///<para> (300C,0055) Brachy Referenced Dose Reference Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint BrachyReferencedDoseReferenceSequence = 806092885;

		///<summary>
		///<para> (300C,0060) Referenced Structure Set Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint ReferencedStructureSetSequence = 806092896;

		///<summary>
		///<para> (300C,006A) Referenced Patient Setup Number </para>
		///<para> VR: IS VM=1 </para>
		///</summary>
        public const uint ReferencedPatientSetupNumber = 806092906;

		///<summary>
		///<para> (300C,0080) Referenced Dose Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint ReferencedDoseSequence = 806092928;

		///<summary>
		///<para> (300C,00A0) Referenced Tolerance Table Number </para>
		///<para> VR: IS VM=1 </para>
		///</summary>
        public const uint ReferencedToleranceTableNumber = 806092960;

		///<summary>
		///<para> (300C,00B0) Referenced Bolus Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint ReferencedBolusSequence = 806092976;

		///<summary>
		///<para> (300C,00C0) Referenced Wedge Number </para>
		///<para> VR: IS VM=1 </para>
		///</summary>
        public const uint ReferencedWedgeNumber = 806092992;

		///<summary>
		///<para> (300C,00D0) Referenced Compensator Number </para>
		///<para> VR: IS VM=1 </para>
		///</summary>
        public const uint ReferencedCompensatorNumber = 806093008;

		///<summary>
		///<para> (300C,00E0) Referenced Block Number </para>
		///<para> VR: IS VM=1 </para>
		///</summary>
        public const uint ReferencedBlockNumber = 806093024;

		///<summary>
		///<para> (300C,00F0) Referenced Control Point Index </para>
		///<para> VR: IS VM=1 </para>
		///</summary>
        public const uint ReferencedControlPointIndex = 806093040;

		///<summary>
		///<para> (300C,00F2) Referenced Control Point Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint ReferencedControlPointSequence = 806093042;

		///<summary>
		///<para> (300C,00F4) Referenced Start Control Point Index </para>
		///<para> VR: IS VM=1 </para>
		///</summary>
        public const uint ReferencedStartControlPointIndex = 806093044;

		///<summary>
		///<para> (300C,00F6) Referenced Stop Control Point Index </para>
		///<para> VR: IS VM=1 </para>
		///</summary>
        public const uint ReferencedStopControlPointIndex = 806093046;

		///<summary>
		///<para> (300C,0100) Referenced Range Shifter Number </para>
		///<para> VR: IS VM=1 </para>
		///</summary>
        public const uint ReferencedRangeShifterNumber = 806093056;

		///<summary>
		///<para> (300C,0102) Referenced Lateral Spreading Device Number </para>
		///<para> VR: IS VM=1 </para>
		///</summary>
        public const uint ReferencedLateralSpreadingDeviceNumber = 806093058;

		///<summary>
		///<para> (300C,0104) Referenced Range Modulator Number </para>
		///<para> VR: IS VM=1 </para>
		///</summary>
        public const uint ReferencedRangeModulatorNumber = 806093060;

		///<summary>
		///<para> (300C,0111) Omitted Beam Task Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint OmittedBeamTaskSequence = 806093073;

		///<summary>
		///<para> (300C,0112) Reason for Omission </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint ReasonForOmission = 806093074;

		///<summary>
		///<para> (300C,0113) Reason for Omission Description </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint ReasonForOmissionDescription = 806093075;

		///<summary>
		///<para> (300E,0002) Approval Status </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint ApprovalStatus = 806223874;

		///<summary>
		///<para> (300E,0004) Review Date </para>
		///<para> VR: DA VM=1 </para>
		///</summary>
        public const uint ReviewDate = 806223876;

		///<summary>
		///<para> (300E,0005) Review Time </para>
		///<para> VR: TM VM=1 </para>
		///</summary>
        public const uint ReviewTime = 806223877;

		///<summary>
		///<para> (300E,0008) Reviewer Name </para>
		///<para> VR: PN VM=1 </para>
		///</summary>
        public const uint ReviewerName = 806223880;

		///<summary>
		///<para> (4000,0010) Arbitrary (RETIRED) </para>
		///<para> VR: LT VM=1 </para>
		///</summary>
        public const uint ArbitraryRetired = 1073741840;

		///<summary>
		///<para> (4000,4000) Text Comments (RETIRED) </para>
		///<para> VR: LT VM=1 </para>
		///</summary>
        public const uint TextCommentsRetired = 1073758208;

		///<summary>
		///<para> (4008,0040) Results ID (RETIRED) </para>
		///<para> VR: SH VM=1 </para>
		///</summary>
        public const uint ResultsIdRetired = 1074266176;

		///<summary>
		///<para> (4008,0042) Results ID Issuer (RETIRED) </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint ResultsIdIssuerRetired = 1074266178;

		///<summary>
		///<para> (4008,0050) Referenced Interpretation Sequence (RETIRED) </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint ReferencedInterpretationSequenceRetired = 1074266192;

		///<summary>
		///<para> (4008,00FF) Report Production Status (Trial) (RETIRED) </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint ReportProductionStatusTrialRetired = 1074266367;

		///<summary>
		///<para> (4008,0100) Interpretation Recorded Date (RETIRED) </para>
		///<para> VR: DA VM=1 </para>
		///</summary>
        public const uint InterpretationRecordedDateRetired = 1074266368;

		///<summary>
		///<para> (4008,0101) Interpretation Recorded Time (RETIRED) </para>
		///<para> VR: TM VM=1 </para>
		///</summary>
        public const uint InterpretationRecordedTimeRetired = 1074266369;

		///<summary>
		///<para> (4008,0102) Interpretation Recorder (RETIRED) </para>
		///<para> VR: PN VM=1 </para>
		///</summary>
        public const uint InterpretationRecorderRetired = 1074266370;

		///<summary>
		///<para> (4008,0103) Reference to Recorded Sound (RETIRED) </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint ReferenceToRecordedSoundRetired = 1074266371;

		///<summary>
		///<para> (4008,0108) Interpretation Transcription Date (RETIRED) </para>
		///<para> VR: DA VM=1 </para>
		///</summary>
        public const uint InterpretationTranscriptionDateRetired = 1074266376;

		///<summary>
		///<para> (4008,0109) Interpretation Transcription Time (RETIRED) </para>
		///<para> VR: TM VM=1 </para>
		///</summary>
        public const uint InterpretationTranscriptionTimeRetired = 1074266377;

		///<summary>
		///<para> (4008,010A) Interpretation Transcriber (RETIRED) </para>
		///<para> VR: PN VM=1 </para>
		///</summary>
        public const uint InterpretationTranscriberRetired = 1074266378;

		///<summary>
		///<para> (4008,010B) Interpretation Text (RETIRED) </para>
		///<para> VR: ST VM=1 </para>
		///</summary>
        public const uint InterpretationTextRetired = 1074266379;

		///<summary>
		///<para> (4008,010C) Interpretation Author (RETIRED) </para>
		///<para> VR: PN VM=1 </para>
		///</summary>
        public const uint InterpretationAuthorRetired = 1074266380;

		///<summary>
		///<para> (4008,0111) Interpretation Approver Sequence (RETIRED) </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint InterpretationApproverSequenceRetired = 1074266385;

		///<summary>
		///<para> (4008,0112) Interpretation Approval Date (RETIRED) </para>
		///<para> VR: DA VM=1 </para>
		///</summary>
        public const uint InterpretationApprovalDateRetired = 1074266386;

		///<summary>
		///<para> (4008,0113) Interpretation Approval Time (RETIRED) </para>
		///<para> VR: TM VM=1 </para>
		///</summary>
        public const uint InterpretationApprovalTimeRetired = 1074266387;

		///<summary>
		///<para> (4008,0114) Physician Approving Interpretation (RETIRED) </para>
		///<para> VR: PN VM=1 </para>
		///</summary>
        public const uint PhysicianApprovingInterpretationRetired = 1074266388;

		///<summary>
		///<para> (4008,0115) Interpretation Diagnosis Description (RETIRED) </para>
		///<para> VR: LT VM=1 </para>
		///</summary>
        public const uint InterpretationDiagnosisDescriptionRetired = 1074266389;

		///<summary>
		///<para> (4008,0117) Interpretation Diagnosis Code Sequence (RETIRED) </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint InterpretationDiagnosisCodeSequenceRetired = 1074266391;

		///<summary>
		///<para> (4008,0118) Results Distribution List Sequence (RETIRED) </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint ResultsDistributionListSequenceRetired = 1074266392;

		///<summary>
		///<para> (4008,0119) Distribution Name (RETIRED) </para>
		///<para> VR: PN VM=1 </para>
		///</summary>
        public const uint DistributionNameRetired = 1074266393;

		///<summary>
		///<para> (4008,011A) Distribution Address (RETIRED) </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint DistributionAddressRetired = 1074266394;

		///<summary>
		///<para> (4008,0200) Interpretation ID (RETIRED) </para>
		///<para> VR: SH VM=1 </para>
		///</summary>
        public const uint InterpretationIdRetired = 1074266624;

		///<summary>
		///<para> (4008,0202) Interpretation ID Issuer (RETIRED) </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint InterpretationIdIssuerRetired = 1074266626;

		///<summary>
		///<para> (4008,0210) Interpretation Type ID (RETIRED) </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint InterpretationTypeIdRetired = 1074266640;

		///<summary>
		///<para> (4008,0212) Interpretation Status ID (RETIRED) </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint InterpretationStatusIdRetired = 1074266642;

		///<summary>
		///<para> (4008,0300) Impressions (RETIRED) </para>
		///<para> VR: ST VM=1 </para>
		///</summary>
        public const uint ImpressionsRetired = 1074266880;

		///<summary>
		///<para> (4008,4000) Results Comments (RETIRED) </para>
		///<para> VR: ST VM=1 </para>
		///</summary>
        public const uint ResultsCommentsRetired = 1074282496;

		///<summary>
		///<para> (4010,0001) Low Energy Detectors </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint LowEnergyDetectors = 1074790401;

		///<summary>
		///<para> (4010,0002) High Energy Detectors </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint HighEnergyDetectors = 1074790402;

		///<summary>
		///<para> (4010,0004) Detector Geometry Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint DetectorGeometrySequence = 1074790404;

		///<summary>
		///<para> (4010,1001) Threat ROI Voxel Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint ThreatRoiVoxelSequence = 1074794497;

		///<summary>
		///<para> (4010,1004) Threat ROI Base </para>
		///<para> VR: FL VM=3 </para>
		///</summary>
        public const uint ThreatRoiBase = 1074794500;

		///<summary>
		///<para> (4010,1005) Threat ROI Extents </para>
		///<para> VR: FL VM=3 </para>
		///</summary>
        public const uint ThreatRoiExtents = 1074794501;

		///<summary>
		///<para> (4010,1006) Threat ROI Bitmap </para>
		///<para> VR: OB VM=1 </para>
		///</summary>
        public const uint ThreatRoiBitmap = 1074794502;

		///<summary>
		///<para> (4010,1007) Route Segment ID </para>
		///<para> VR: SH VM=1 </para>
		///</summary>
        public const uint RouteSegmentId = 1074794503;

		///<summary>
		///<para> (4010,1008) Gantry Type </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint GantryType = 1074794504;

		///<summary>
		///<para> (4010,1009) OOI Owner Type </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint OoiOwnerType = 1074794505;

		///<summary>
		///<para> (4010,100A) Route Segment Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint RouteSegmentSequence = 1074794506;

		///<summary>
		///<para> (4010,1010) Potential Threat Object ID </para>
		///<para> VR: US VM=1 </para>
		///</summary>
        public const uint PotentialThreatObjectId = 1074794512;

		///<summary>
		///<para> (4010,1011) Threat Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint ThreatSequence = 1074794513;

		///<summary>
		///<para> (4010,1012) Threat Category </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint ThreatCategory = 1074794514;

		///<summary>
		///<para> (4010,1013) Threat Category Description </para>
		///<para> VR: LT VM=1 </para>
		///</summary>
        public const uint ThreatCategoryDescription = 1074794515;

		///<summary>
		///<para> (4010,1014) ATD Ability Assessment </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint AtdAbilityAssessment = 1074794516;

		///<summary>
		///<para> (4010,1015) ATD Assessment Flag </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint AtdAssessmentFlag = 1074794517;

		///<summary>
		///<para> (4010,1016) ATD Assessment Probability </para>
		///<para> VR: FL VM=1 </para>
		///</summary>
        public const uint AtdAssessmentProbability = 1074794518;

		///<summary>
		///<para> (4010,1017) Mass </para>
		///<para> VR: FL VM=1 </para>
		///</summary>
        public const uint Mass = 1074794519;

		///<summary>
		///<para> (4010,1018) Density </para>
		///<para> VR: FL VM=1 </para>
		///</summary>
        public const uint Density = 1074794520;

		///<summary>
		///<para> (4010,1019) Z Effective </para>
		///<para> VR: FL VM=1 </para>
		///</summary>
        public const uint ZEffective = 1074794521;

		///<summary>
		///<para> (4010,101A) Boarding Pass ID </para>
		///<para> VR: SH VM=1 </para>
		///</summary>
        public const uint BoardingPassId = 1074794522;

		///<summary>
		///<para> (4010,101B) Center of Mass </para>
		///<para> VR: FL VM=3 </para>
		///</summary>
        public const uint CenterOfMass = 1074794523;

		///<summary>
		///<para> (4010,101C) Center of PTO </para>
		///<para> VR: FL VM=3 </para>
		///</summary>
        public const uint CenterOfPto = 1074794524;

		///<summary>
		///<para> (4010,101D) Bounding Polygon </para>
		///<para> VR: FL VM=6-n </para>
		///</summary>
        public const uint BoundingPolygon = 1074794525;

		///<summary>
		///<para> (4010,101E) Route Segment Start Location ID </para>
		///<para> VR: SH VM=1 </para>
		///</summary>
        public const uint RouteSegmentStartLocationId = 1074794526;

		///<summary>
		///<para> (4010,101F) Route Segment End Location ID </para>
		///<para> VR: SH VM=1 </para>
		///</summary>
        public const uint RouteSegmentEndLocationId = 1074794527;

		///<summary>
		///<para> (4010,1020) Route Segment Location ID Type </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint RouteSegmentLocationIdType = 1074794528;

		///<summary>
		///<para> (4010,1021) Abort Reason </para>
		///<para> VR: CS VM=1-n </para>
		///</summary>
        public const uint AbortReason = 1074794529;

		///<summary>
		///<para> (4010,1023) Volume of PTO </para>
		///<para> VR: FL VM=1 </para>
		///</summary>
        public const uint VolumeOfPto = 1074794531;

		///<summary>
		///<para> (4010,1024) Abort Flag </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint AbortFlag = 1074794532;

		///<summary>
		///<para> (4010,1025) Route Segment Start Time </para>
		///<para> VR: DT VM=1 </para>
		///</summary>
        public const uint RouteSegmentStartTime = 1074794533;

		///<summary>
		///<para> (4010,1026) Route Segment End Time </para>
		///<para> VR: DT VM=1 </para>
		///</summary>
        public const uint RouteSegmentEndTime = 1074794534;

		///<summary>
		///<para> (4010,1027) TDR Type </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint TdrType = 1074794535;

		///<summary>
		///<para> (4010,1028) International Route Segment </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint InternationalRouteSegment = 1074794536;

		///<summary>
		///<para> (4010,1029) Threat Detection Algorithm and Version </para>
		///<para> VR: LO VM=1-n </para>
		///</summary>
        public const uint ThreatDetectionAlgorithmAndVersion = 1074794537;

		///<summary>
		///<para> (4010,102A) Assigned Location </para>
		///<para> VR: SH VM=1 </para>
		///</summary>
        public const uint AssignedLocation = 1074794538;

		///<summary>
		///<para> (4010,102B) Alarm Decision Time </para>
		///<para> VR: DT VM=1 </para>
		///</summary>
        public const uint AlarmDecisionTime = 1074794539;

		///<summary>
		///<para> (4010,1031) Alarm Decision </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint AlarmDecision = 1074794545;

		///<summary>
		///<para> (4010,1033) Number of Total Objects </para>
		///<para> VR: US VM=1 </para>
		///</summary>
        public const uint NumberOfTotalObjects = 1074794547;

		///<summary>
		///<para> (4010,1034) Number of Alarm Objects </para>
		///<para> VR: US VM=1 </para>
		///</summary>
        public const uint NumberOfAlarmObjects = 1074794548;

		///<summary>
		///<para> (4010,1037) PTO Representation Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint PtoRepresentationSequence = 1074794551;

		///<summary>
		///<para> (4010,1038) ATD Assessment Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint AtdAssessmentSequence = 1074794552;

		///<summary>
		///<para> (4010,1039) TIP Type </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint TipType = 1074794553;

		///<summary>
		///<para> (4010,103A) DICOS Version </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint DicosVersion = 1074794554;

		///<summary>
		///<para> (4010,1041) OOI Owner Creation Time </para>
		///<para> VR: DT VM=1 </para>
		///</summary>
        public const uint OoiOwnerCreationTime = 1074794561;

		///<summary>
		///<para> (4010,1042) OOI Type </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint OoiType = 1074794562;

		///<summary>
		///<para> (4010,1043) OOI Size </para>
		///<para> VR: FL VM=3 </para>
		///</summary>
        public const uint OoiSize = 1074794563;

		///<summary>
		///<para> (4010,1044) Acquisition Status </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint AcquisitionStatus = 1074794564;

		///<summary>
		///<para> (4010,1045) Basis Materials Code Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint BasisMaterialsCodeSequence = 1074794565;

		///<summary>
		///<para> (4010,1046) Phantom Type </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint PhantomType = 1074794566;

		///<summary>
		///<para> (4010,1047) OOI Owner Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint OoiOwnerSequence = 1074794567;

		///<summary>
		///<para> (4010,1048) Scan Type </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint ScanType = 1074794568;

		///<summary>
		///<para> (4010,1051) Itinerary ID </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint ItineraryId = 1074794577;

		///<summary>
		///<para> (4010,1052) Itinerary ID Type </para>
		///<para> VR: SH VM=1 </para>
		///</summary>
        public const uint ItineraryIdType = 1074794578;

		///<summary>
		///<para> (4010,1053) Itinerary ID Assigning Authority </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint ItineraryIdAssigningAuthority = 1074794579;

		///<summary>
		///<para> (4010,1054) Route ID </para>
		///<para> VR: SH VM=1 </para>
		///</summary>
        public const uint RouteId = 1074794580;

		///<summary>
		///<para> (4010,1055) Route ID Assigning Authority </para>
		///<para> VR: SH VM=1 </para>
		///</summary>
        public const uint RouteIdAssigningAuthority = 1074794581;

		///<summary>
		///<para> (4010,1056) Inbound Arrival Type </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint InboundArrivalType = 1074794582;

		///<summary>
		///<para> (4010,1058) Carrier ID </para>
		///<para> VR: SH VM=1 </para>
		///</summary>
        public const uint CarrierId = 1074794584;

		///<summary>
		///<para> (4010,1059) Carrier ID Assigning Authority </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint CarrierIdAssigningAuthority = 1074794585;

		///<summary>
		///<para> (4010,1060) Source Orientation </para>
		///<para> VR: FL VM=3 </para>
		///</summary>
        public const uint SourceOrientation = 1074794592;

		///<summary>
		///<para> (4010,1061) Source Position </para>
		///<para> VR: FL VM=3 </para>
		///</summary>
        public const uint SourcePosition = 1074794593;

		///<summary>
		///<para> (4010,1062) Belt Height </para>
		///<para> VR: FL VM=1 </para>
		///</summary>
        public const uint BeltHeight = 1074794594;

		///<summary>
		///<para> (4010,1064) Algorithm Routing Code Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint AlgorithmRoutingCodeSequence = 1074794596;

		///<summary>
		///<para> (4010,1067) Transport Classification </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint TransportClassification = 1074794599;

		///<summary>
		///<para> (4010,1068) OOI Type Descriptor </para>
		///<para> VR: LT VM=1 </para>
		///</summary>
        public const uint OoiTypeDescriptor = 1074794600;

		///<summary>
		///<para> (4010,1069) Total Processing Time </para>
		///<para> VR: FL VM=1 </para>
		///</summary>
        public const uint TotalProcessingTime = 1074794601;

		///<summary>
		///<para> (4010,106C) Detector Calibration Data </para>
		///<para> VR: OB VM=1 </para>
		///</summary>
        public const uint DetectorCalibrationData = 1074794604;

		///<summary>
		///<para> (4010,106D) Additional Screening Performed </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint AdditionalScreeningPerformed = 1074794605;

		///<summary>
		///<para> (4010,106E) Additional Inspection Selection Criteria </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint AdditionalInspectionSelectionCriteria = 1074794606;

		///<summary>
		///<para> (4010,106F) Additional Inspection Method Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint AdditionalInspectionMethodSequence = 1074794607;

		///<summary>
		///<para> (4010,1070) AIT Device Type </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint AitDeviceType = 1074794608;

		///<summary>
		///<para> (4010,1071) QR Measurements Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint QrMeasurementsSequence = 1074794609;

		///<summary>
		///<para> (4010,1072) Target Material Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint TargetMaterialSequence = 1074794610;

		///<summary>
		///<para> (4010,1073) SNR Threshold </para>
		///<para> VR: FD VM=1 </para>
		///</summary>
        public const uint SnrThreshold = 1074794611;

		///<summary>
		///<para> (4010,1075) Image Scale Representation </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint ImageScaleRepresentation = 1074794613;

		///<summary>
		///<para> (4010,1076) Referenced PTO Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint ReferencedPtoSequence = 1074794614;

		///<summary>
		///<para> (4010,1077) Referenced TDR Instance Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint ReferencedTdrInstanceSequence = 1074794615;

		///<summary>
		///<para> (4010,1078) PTO Location Description </para>
		///<para> VR: ST VM=1 </para>
		///</summary>
        public const uint PtoLocationDescription = 1074794616;

		///<summary>
		///<para> (4010,1079) Anomaly Locator Indicator Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint AnomalyLocatorIndicatorSequence = 1074794617;

		///<summary>
		///<para> (4010,107A) Anomaly Locator Indicator </para>
		///<para> VR: FL VM=3 </para>
		///</summary>
        public const uint AnomalyLocatorIndicator = 1074794618;

		///<summary>
		///<para> (4010,107B) PTO Region Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint PtoRegionSequence = 1074794619;

		///<summary>
		///<para> (4010,107C) Inspection Selection Criteria </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint InspectionSelectionCriteria = 1074794620;

		///<summary>
		///<para> (4010,107D) Secondary Inspection Method Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint SecondaryInspectionMethodSequence = 1074794621;

		///<summary>
		///<para> (4010,107E) PRCS to RCS Orientation </para>
		///<para> VR: DS VM=6 </para>
		///</summary>
        public const uint PrcsToRcsOrientation = 1074794622;

		///<summary>
		///<para> (4FFE,0001) MAC Parameters Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint MacParametersSequence = 1342046209;

		///<summary>
		///<para> (50xx,0005) Curve Dimensions (RETIRED) </para>
		///<para> VR: US VM=1 </para>
		///</summary>
        public const uint CurveDimensionsRetired = 1342177285;

		///<summary>
		///<para> (50xx,0010) Number of Points (RETIRED) </para>
		///<para> VR: US VM=1 </para>
		///</summary>
        public const uint NumberOfPointsRetired = 1342177296;

		///<summary>
		///<para> (50xx,0020) Type of Data (RETIRED) </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint TypeOfDataRetired = 1342177312;

		///<summary>
		///<para> (50xx,0022) Curve Description (RETIRED) </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint CurveDescriptionRetired = 1342177314;

		///<summary>
		///<para> (50xx,0030) Axis Units (RETIRED) </para>
		///<para> VR: SH VM=1-n </para>
		///</summary>
        public const uint AxisUnitsRetired = 1342177328;

		///<summary>
		///<para> (50xx,0040) Axis Labels (RETIRED) </para>
		///<para> VR: SH VM=1-n </para>
		///</summary>
        public const uint AxisLabelsRetired = 1342177344;

		///<summary>
		///<para> (50xx,0103) Data Value Representation (RETIRED) </para>
		///<para> VR: US VM=1 </para>
		///</summary>
        public const uint DataValueRepresentationRetired = 1342177539;

		///<summary>
		///<para> (50xx,0104) Minimum Coordinate Value (RETIRED) </para>
		///<para> VR: US VM=1-n </para>
		///</summary>
        public const uint MinimumCoordinateValueRetired = 1342177540;

		///<summary>
		///<para> (50xx,0105) Maximum Coordinate Value (RETIRED) </para>
		///<para> VR: US VM=1-n </para>
		///</summary>
        public const uint MaximumCoordinateValueRetired = 1342177541;

		///<summary>
		///<para> (50xx,0106) Curve Range (RETIRED) </para>
		///<para> VR: SH VM=1-n </para>
		///</summary>
        public const uint CurveRangeRetired = 1342177542;

		///<summary>
		///<para> (50xx,0110) Curve Data Descriptor (RETIRED) </para>
		///<para> VR: US VM=1-n </para>
		///</summary>
        public const uint CurveDataDescriptorRetired = 1342177552;

		///<summary>
		///<para> (50xx,0112) Coordinate Start Value (RETIRED) </para>
		///<para> VR: US VM=1-n </para>
		///</summary>
        public const uint CoordinateStartValueRetired = 1342177554;

		///<summary>
		///<para> (50xx,0114) Coordinate Step Value (RETIRED) </para>
		///<para> VR: US VM=1-n </para>
		///</summary>
        public const uint CoordinateStepValueRetired = 1342177556;

		///<summary>
		///<para> (50xx,1001) Curve Activation Layer (RETIRED) </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint CurveActivationLayerRetired = 1342181377;

		///<summary>
		///<para> (50xx,2000) Audio Type (RETIRED) </para>
		///<para> VR: US VM=1 </para>
		///</summary>
        public const uint AudioTypeRetired = 1342185472;

		///<summary>
		///<para> (50xx,2002) Audio Sample Format (RETIRED) </para>
		///<para> VR: US VM=1 </para>
		///</summary>
        public const uint AudioSampleFormatRetired = 1342185474;

		///<summary>
		///<para> (50xx,2004) Number of Channels (RETIRED) </para>
		///<para> VR: US VM=1 </para>
		///</summary>
        public const uint NumberOfChannelsRetired = 1342185476;

		///<summary>
		///<para> (50xx,2006) Number of Samples (RETIRED) </para>
		///<para> VR: UL VM=1 </para>
		///</summary>
        public const uint NumberOfSamplesRetired = 1342185478;

		///<summary>
		///<para> (50xx,2008) Sample Rate (RETIRED) </para>
		///<para> VR: UL VM=1 </para>
		///</summary>
        public const uint SampleRateRetired = 1342185480;

		///<summary>
		///<para> (50xx,200A) Total Time (RETIRED) </para>
		///<para> VR: UL VM=1 </para>
		///</summary>
        public const uint TotalTimeRetired = 1342185482;

		///<summary>
		///<para> (50xx,200C) Audio Sample Data (RETIRED) </para>
		///<para> VR: OB/OW VM=1 </para>
		///</summary>
        public const uint AudioSampleDataRetired = 1342185484;

		///<summary>
		///<para> (50xx,200E) Audio Comments (RETIRED) </para>
		///<para> VR: LT VM=1 </para>
		///</summary>
        public const uint AudioCommentsRetired = 1342185486;

		///<summary>
		///<para> (50xx,2500) Curve Label (RETIRED) </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint CurveLabelRetired = 1342186752;

		///<summary>
		///<para> (50xx,2600) Curve Referenced Overlay Sequence (RETIRED) </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint CurveReferencedOverlaySequenceRetired = 1342187008;

		///<summary>
		///<para> (50xx,2610) Curve Referenced Overlay Group (RETIRED) </para>
		///<para> VR: US VM=1 </para>
		///</summary>
        public const uint CurveReferencedOverlayGroupRetired = 1342187024;

		///<summary>
		///<para> (50xx,3000) Curve Data (RETIRED) </para>
		///<para> VR: OB/OW VM=1 </para>
		///</summary>
        public const uint CurveDataRetired = 1342189568;

		///<summary>
		///<para> (5200,9229) Shared Functional Groups Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint SharedFunctionalGroupsSequence = 1375769129;

		///<summary>
		///<para> (5200,9230) Per-frame Functional Groups Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint PerFrameFunctionalGroupsSequence = 1375769136;

		///<summary>
		///<para> (5400,0100) Waveform Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint WaveformSequence = 1409286400;

		///<summary>
		///<para> (5400,0110) Channel Minimum Value </para>
		///<para> VR: OB/OW VM=1 </para>
		///</summary>
        public const uint ChannelMinimumValue = 1409286416;

		///<summary>
		///<para> (5400,0112) Channel Maximum Value </para>
		///<para> VR: OB/OW VM=1 </para>
		///</summary>
        public const uint ChannelMaximumValue = 1409286418;

		///<summary>
		///<para> (5400,1004) Waveform Bits Allocated </para>
		///<para> VR: US VM=1 </para>
		///</summary>
        public const uint WaveformBitsAllocated = 1409290244;

		///<summary>
		///<para> (5400,1006) Waveform Sample Interpretation </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint WaveformSampleInterpretation = 1409290246;

		///<summary>
		///<para> (5400,100A) Waveform Padding Value </para>
		///<para> VR: OB/OW VM=1 </para>
		///</summary>
        public const uint WaveformPaddingValue = 1409290250;

		///<summary>
		///<para> (5400,1010) Waveform Data </para>
		///<para> VR: OB/OW VM=1 </para>
		///</summary>
        public const uint WaveformData = 1409290256;

		///<summary>
		///<para> (5600,0010) First Order Phase Correction Angle </para>
		///<para> VR: OF VM=1 </para>
		///</summary>
        public const uint FirstOrderPhaseCorrectionAngle = 1442840592;

		///<summary>
		///<para> (5600,0020) Spectroscopy Data </para>
		///<para> VR: OF VM=1 </para>
		///</summary>
        public const uint SpectroscopyData = 1442840608;

		///<summary>
		///<para> (60xx,0010) Overlay Rows </para>
		///<para> VR: US VM=1 </para>
		///</summary>
        public const uint OverlayRows = 1610612752;

		///<summary>
		///<para> (60xx,0011) Overlay Columns </para>
		///<para> VR: US VM=1 </para>
		///</summary>
        public const uint OverlayColumns = 1610612753;

		///<summary>
		///<para> (60xx,0012) Overlay Planes (RETIRED) </para>
		///<para> VR: US VM=1 </para>
		///</summary>
        public const uint OverlayPlanesRetired = 1610612754;

		///<summary>
		///<para> (60xx,0015) Number of Frames in Overlay </para>
		///<para> VR: IS VM=1 </para>
		///</summary>
        public const uint NumberOfFramesInOverlay = 1610612757;

		///<summary>
		///<para> (60xx,0022) Overlay Description </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint OverlayDescription = 1610612770;

		///<summary>
		///<para> (60xx,0040) Overlay Type </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint OverlayType = 1610612800;

		///<summary>
		///<para> (60xx,0045) Overlay Subtype </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint OverlaySubtype = 1610612805;

		///<summary>
		///<para> (60xx,0050) Overlay Origin </para>
		///<para> VR: SS VM=2 </para>
		///</summary>
        public const uint OverlayOrigin = 1610612816;

		///<summary>
		///<para> (60xx,0051) Image Frame Origin </para>
		///<para> VR: US VM=1 </para>
		///</summary>
        public const uint ImageFrameOrigin = 1610612817;

		///<summary>
		///<para> (60xx,0052) Overlay Plane Origin (RETIRED) </para>
		///<para> VR: US VM=1 </para>
		///</summary>
        public const uint OverlayPlaneOriginRetired = 1610612818;

		///<summary>
		///<para> (60xx,0060) Overlay Compression Code (RETIRED) </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint OverlayCompressionCodeRetired = 1610612832;

		///<summary>
		///<para> (60xx,0061) Overlay Compression Originator (RETIRED) </para>
		///<para> VR: SH VM=1 </para>
		///</summary>
        public const uint OverlayCompressionOriginatorRetired = 1610612833;

		///<summary>
		///<para> (60xx,0062) Overlay Compression Label (RETIRED) </para>
		///<para> VR: SH VM=1 </para>
		///</summary>
        public const uint OverlayCompressionLabelRetired = 1610612834;

		///<summary>
		///<para> (60xx,0063) Overlay Compression Description (RETIRED) </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint OverlayCompressionDescriptionRetired = 1610612835;

		///<summary>
		///<para> (60xx,0066) Overlay Compression Step Pointers (RETIRED) </para>
		///<para> VR: AT VM=1-n </para>
		///</summary>
        public const uint OverlayCompressionStepPointersRetired = 1610612838;

		///<summary>
		///<para> (60xx,0068) Overlay Repeat Interval (RETIRED) </para>
		///<para> VR: US VM=1 </para>
		///</summary>
        public const uint OverlayRepeatIntervalRetired = 1610612840;

		///<summary>
		///<para> (60xx,0069) Overlay Bits Grouped (RETIRED) </para>
		///<para> VR: US VM=1 </para>
		///</summary>
        public const uint OverlayBitsGroupedRetired = 1610612841;

		///<summary>
		///<para> (60xx,0100) Overlay Bits Allocated </para>
		///<para> VR: US VM=1 </para>
		///</summary>
        public const uint OverlayBitsAllocated = 1610612992;

		///<summary>
		///<para> (60xx,0102) Overlay Bit Position </para>
		///<para> VR: US VM=1 </para>
		///</summary>
        public const uint OverlayBitPosition = 1610612994;

		///<summary>
		///<para> (60xx,0110) Overlay Format (RETIRED) </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint OverlayFormatRetired = 1610613008;

		///<summary>
		///<para> (60xx,0200) Overlay Location (RETIRED) </para>
		///<para> VR: US VM=1 </para>
		///</summary>
        public const uint OverlayLocationRetired = 1610613248;

		///<summary>
		///<para> (60xx,0800) Overlay Code Label (RETIRED) </para>
		///<para> VR: CS VM=1-n </para>
		///</summary>
        public const uint OverlayCodeLabelRetired = 1610614784;

		///<summary>
		///<para> (60xx,0802) Overlay Number of Tables (RETIRED) </para>
		///<para> VR: US VM=1 </para>
		///</summary>
        public const uint OverlayNumberOfTablesRetired = 1610614786;

		///<summary>
		///<para> (60xx,0803) Overlay Code Table Location (RETIRED) </para>
		///<para> VR: AT VM=1-n </para>
		///</summary>
        public const uint OverlayCodeTableLocationRetired = 1610614787;

		///<summary>
		///<para> (60xx,0804) Overlay Bits For Code Word (RETIRED) </para>
		///<para> VR: US VM=1 </para>
		///</summary>
        public const uint OverlayBitsForCodeWordRetired = 1610614788;

		///<summary>
		///<para> (60xx,1001) Overlay Activation Layer </para>
		///<para> VR: CS VM=1 </para>
		///</summary>
        public const uint OverlayActivationLayer = 1610616833;

		///<summary>
		///<para> (60xx,1100) Overlay Descriptor - Gray (RETIRED) </para>
		///<para> VR: US VM=1 </para>
		///</summary>
        public const uint OverlayDescriptorGrayRetired = 1610617088;

		///<summary>
		///<para> (60xx,1101) Overlay Descriptor - Red (RETIRED) </para>
		///<para> VR: US VM=1 </para>
		///</summary>
        public const uint OverlayDescriptorRedRetired = 1610617089;

		///<summary>
		///<para> (60xx,1102) Overlay Descriptor - Green (RETIRED) </para>
		///<para> VR: US VM=1 </para>
		///</summary>
        public const uint OverlayDescriptorGreenRetired = 1610617090;

		///<summary>
		///<para> (60xx,1103) Overlay Descriptor - Blue (RETIRED) </para>
		///<para> VR: US VM=1 </para>
		///</summary>
        public const uint OverlayDescriptorBlueRetired = 1610617091;

		///<summary>
		///<para> (60xx,1200) Overlays - Gray (RETIRED) </para>
		///<para> VR: US VM=1-n </para>
		///</summary>
        public const uint OverlaysGrayRetired = 1610617344;

		///<summary>
		///<para> (60xx,1201) Overlays - Red (RETIRED) </para>
		///<para> VR: US VM=1-n </para>
		///</summary>
        public const uint OverlaysRedRetired = 1610617345;

		///<summary>
		///<para> (60xx,1202) Overlays - Green (RETIRED) </para>
		///<para> VR: US VM=1-n </para>
		///</summary>
        public const uint OverlaysGreenRetired = 1610617346;

		///<summary>
		///<para> (60xx,1203) Overlays - Blue (RETIRED) </para>
		///<para> VR: US VM=1-n </para>
		///</summary>
        public const uint OverlaysBlueRetired = 1610617347;

		///<summary>
		///<para> (60xx,1301) ROI Area </para>
		///<para> VR: IS VM=1 </para>
		///</summary>
        public const uint RoiArea = 1610617601;

		///<summary>
		///<para> (60xx,1302) ROI Mean </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint RoiMean = 1610617602;

		///<summary>
		///<para> (60xx,1303) ROI Standard Deviation </para>
		///<para> VR: DS VM=1 </para>
		///</summary>
        public const uint RoiStandardDeviation = 1610617603;

		///<summary>
		///<para> (60xx,1500) Overlay Label </para>
		///<para> VR: LO VM=1 </para>
		///</summary>
        public const uint OverlayLabel = 1610618112;

		///<summary>
		///<para> (60xx,3000) Overlay Data </para>
		///<para> VR: OB/OW VM=1 </para>
		///</summary>
        public const uint OverlayData = 1610625024;

		///<summary>
		///<para> (60xx,4000) Overlay Comments (RETIRED) </para>
		///<para> VR: LT VM=1 </para>
		///</summary>
        public const uint OverlayCommentsRetired = 1610629120;

		///<summary>
		///<para> (7FE0,0008) Float Pixel Data </para>
		///<para> VR: OF VM=1 </para>
		///</summary>
        public const uint FloatPixelData = 2145386504;

		///<summary>
		///<para> (7FE0,0009) Double Float Pixel Data </para>
		///<para> VR: OD VM=1 </para>
		///</summary>
        public const uint DoubleFloatPixelData = 2145386505;

		///<summary>
		///<para> (7FE0,0010) Pixel Data </para>
		///<para> VR: OB/OW VM=1 </para>
		///</summary>
        public const uint PixelData = 2145386512;

		///<summary>
		///<para> (7FE0,0020) Coefficients SDVN (RETIRED) </para>
		///<para> VR: OW VM=1 </para>
		///</summary>
        public const uint CoefficientsSdvnRetired = 2145386528;

		///<summary>
		///<para> (7FE0,0030) Coefficients SDHN (RETIRED) </para>
		///<para> VR: OW VM=1 </para>
		///</summary>
        public const uint CoefficientsSdhnRetired = 2145386544;

		///<summary>
		///<para> (7FE0,0040) Coefficients SDDN (RETIRED) </para>
		///<para> VR: OW VM=1 </para>
		///</summary>
        public const uint CoefficientsSddnRetired = 2145386560;

		///<summary>
		///<para> (7Fxx,0010) Variable Pixel Data (RETIRED) </para>
		///<para> VR: OB/OW VM=1 </para>
		///</summary>
        public const uint VariablePixelDataRetired = 2130706448;

		///<summary>
		///<para> (7Fxx,0011) Variable Next Data Group (RETIRED) </para>
		///<para> VR: US VM=1 </para>
		///</summary>
        public const uint VariableNextDataGroupRetired = 2130706449;

		///<summary>
		///<para> (7Fxx,0020) Variable Coefficients SDVN (RETIRED) </para>
		///<para> VR: OW VM=1 </para>
		///</summary>
        public const uint VariableCoefficientsSdvnRetired = 2130706464;

		///<summary>
		///<para> (7Fxx,0030) Variable Coefficients SDHN (RETIRED) </para>
		///<para> VR: OW VM=1 </para>
		///</summary>
        public const uint VariableCoefficientsSdhnRetired = 2130706480;

		///<summary>
		///<para> (7Fxx,0040) Variable Coefficients SDDN (RETIRED) </para>
		///<para> VR: OW VM=1 </para>
		///</summary>
        public const uint VariableCoefficientsSddnRetired = 2130706496;

		///<summary>
		///<para> (FFFA,FFFA) Digital Signatures Sequence </para>
		///<para> VR: SQ VM=1 </para>
		///</summary>
        public const uint DigitalSignaturesSequence = 4294639610;

		///<summary>
		///<para> (FFFC,FFFC) Data Set Trailing Padding </para>
		///<para> VR: OB VM=1 </para>
		///</summary>
        public const uint DataSetTrailingPadding = 4294770684;

		///<summary>
		///<para> (FFFE,E000) Item </para>
		///<para> VR: NONE VM=1 </para>
		///</summary>
        public const uint Item = 4294893568;

		///<summary>
		///<para> (FFFE,E00D) Item Delimitation Item </para>
		///<para> VR: NONE VM=1 </para>
		///</summary>
        public const uint ItemDelimitationItem = 4294893581;

		///<summary>
		///<para> (FFFE,E0DD) Sequence Delimitation Item </para>
		///<para> VR: NONE VM=1 </para>
		///</summary>
        public const uint SequenceDelimitationItem = 4294893789;

    }
}
