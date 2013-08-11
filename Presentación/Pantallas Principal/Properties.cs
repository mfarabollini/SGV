using System;


namespace Presentación.Pantallas_Principal
{

	/// <summary>
	/// explanation of the outline of Properties
	/// </summary>
	public class Properties
	{
		public const string SCAN_FUNC = "Scan Function";
		public const string SCAN_FRONT = "Scan Front";
		public const string FRONT_GRAYSCALE = "Front Grayscale";
		public const string FRONT_DISPLAY = "Front Display";
		public const string FRONT_SAVE = "Front Save";
		public const string SCAN_BACK = "Scan Back";
		public const string BACK_GRAYSCALE = "Back Grayscale";
		public const string BACK_DISPLAY = "Back Display";
		public const string BACK_SAVE = "Back Save";
		public const string MICR = "MICR";
		public const string MICR_FONT = "Micr Font";
		public const string MICR_SAVE = "Micr Save";
		public const string MICR_SAVE_ENABLE = "Micr Save Enable";
		public const string ELEC_ENDORSE_TEXT = "Electronic Endorse Text";
		public const string ELEC_ENDORSE_IMAGE = "Electronic Endorse Image";
		public const string MIS_INSERT_DETECT = "PaperMisInsertionErrorDetect";
		public const string MIS_INSERT_EJECT = "PaperMisInsertionErrorEject";
		public const string MIS_INSERT_STAMP = "PaperMisInsertionStamp";
		public const string MIS_INSERT_CANCEL = "PaperMisInsertionCancel";
		public const string NOISE_DETECT = "NoiseErrorDetect";
		public const string NOISE_EJECT = "NoiseErrorEject";
		public const string NOISE_STAMP = "NoiseStamp";
		public const string NOISE_CANCEL = "NoiseCancel";
		public const string DOUBLE_FEED_DETECT = "DoubleFeedErrorDetect";
		public const string DOUBLE_FEED_EJECT = "DoubleFeedErrorEject";
		public const string DOUBLE_FEED_STAMP = "DoubleFeedStamp";
		public const string DOUBLE_FEED_CANCEL = "DoubleFeedCancel";
		public const string NODATA_DETECT = "NodataErrorDetect";
		public const string NODATA_EJECT = "NodataErrorEject";
		public const string NODATA_STAMP = "NodataStamp";
		public const string NODATA_CANCEL = "NodataCancel";
		public const string BADDATA_COUNT = "BaddataCount";
		public const string BADDATA_DETECT = "BaddataErrorDetect";
		public const string BADDATA_EJECT = "BaddataErrorEject";
		public const string BADDATA_STAMP = "BaddataStamp";
		public const string BADDATA_CANCEL = "BaddataCancel";
		public const string CONFIRMATION = "Confirmation Mode";
		public const string RUN_SCN_TO_RESULT = "run ScnToReslut";
		public const string NO_CALL_SCN_TO_RESULT = "No call ScnToReslut";
		public const string SETTINGS_VALUS = "Settings m_Values";

		public const string CONF_EJECT = "Confirmation Eject";
		public const string CONF_STAMP = "Confirmation Stamp";
		public const string CONF_NEXT_CHECK = "Confirmation NextCheck";
		public const string CONF_OK = "Confirmation OK";

		public const string OCR_AB = "Ocr Ab";
		public const string OCR_AB_FONT = "Ocr Ab Font";
		public const string BUZZER_SUCCESS_HZ = "Buzzer Success Hz";
		public const string BUZZER_SUCCESS_COUNT = "Buzzer Success Count";
		public const string BUZZER_ERROR_HZ = "Buzzer Error Hz";
		public const string BUZZER_ERROR_COUNT = "Buzzer Error Count";
		public const string BUZZER_WFEED_HZ = "Buzzer WFeed Hz";
		public const string BUZZER_WFEED_COUNT = "Buzzer WFeed Count";

		public const string NEAR_FULL = "Near Full";

		public const string SUCCESS_STAMP = "Success Stamp";

		public const string IQA_DETECT = "IqaErrorDetect";
		public const string IQA_GRAYSCALE = "IqaGrayScale";
		public const string IQA_EJECT = "IqaErrorEject";
		public const string IQA_STAMP = "IqaStamp";
		public const string IQA_CANCEL = "IqaCancel";

		public const string WATERFALL_ENABLE = "WaterfallEnable";
		public const string WATERFALL_MODE = "WaterfallMode";

		public const string BARCODE_FRONT_DETECT = "BarcodeFrontErrorDetect";
		public const string BARCODE_FRONT_EJECT = "BarcodeFrontErrorEject";
		public const string BARCODE_FRONT_STAMP = "BarcodeFrontStamp";
		public const string BARCODE_FRONT_CANCEL = "BarcodeFrontCancel";

		public const string BARCODE_BACK_DETECT = "BarcodeBackErrorDetect";
		public const string BARCODE_BACK_EJECT = "BarcodeBackErrorEject";
		public const string BARCODE_BACK_STAMP = "BarcodeBackStamp";
		public const string BARCODE_BACK_CANCEL = "BarcodeBackCancel";

		protected System.Collections.Hashtable m_Values;

		public Properties()
		{
			// 
			// TODO: Add the constructor logic here
			//
			m_Values = new System.Collections.Hashtable();
			m_Values.Add(SCAN_FUNC, 0);

			m_Values.Add(SCAN_FRONT, true);
			m_Values.Add(FRONT_GRAYSCALE, false);
			m_Values.Add(FRONT_DISPLAY, true);
			m_Values.Add(FRONT_SAVE, false);

			m_Values.Add(SCAN_BACK, true);
			m_Values.Add(BACK_GRAYSCALE, false);
			m_Values.Add(BACK_DISPLAY, true);
			m_Values.Add(BACK_SAVE, false);

			m_Values.Add(MICR, true);
			m_Values.Add(MICR_FONT, 1);
			m_Values.Add(MICR_SAVE, false);
			m_Values.Add(MICR_SAVE_ENABLE, true);

			m_Values.Add(ELEC_ENDORSE_TEXT, false);
			m_Values.Add(ELEC_ENDORSE_IMAGE, false);

			m_Values.Add(CONFIRMATION, false);
			m_Values.Add(RUN_SCN_TO_RESULT, false);
			m_Values.Add(NO_CALL_SCN_TO_RESULT, false);
			m_Values.Add(SETTINGS_VALUS, false);

			m_Values.Add(MIS_INSERT_DETECT, true);
			m_Values.Add(MIS_INSERT_EJECT, 0);
			m_Values.Add(MIS_INSERT_STAMP, false);
			m_Values.Add(MIS_INSERT_CANCEL, false);

			m_Values.Add(NOISE_DETECT, true);
			m_Values.Add(NOISE_EJECT, 0);
			m_Values.Add(NOISE_STAMP, false);
			m_Values.Add(NOISE_CANCEL, true);

			m_Values.Add(DOUBLE_FEED_DETECT, true);
			m_Values.Add(DOUBLE_FEED_EJECT, 0);
			m_Values.Add(DOUBLE_FEED_STAMP, false);
			m_Values.Add(DOUBLE_FEED_CANCEL, false);

			m_Values.Add(BADDATA_COUNT, 255);
			m_Values.Add(BADDATA_DETECT, true);
			m_Values.Add(BADDATA_EJECT, 0);
			m_Values.Add(BADDATA_STAMP, false);
			m_Values.Add(BADDATA_CANCEL, false);

			m_Values.Add(NODATA_DETECT, true);
			m_Values.Add(NODATA_EJECT, 0);
			m_Values.Add(NODATA_STAMP, false);
			m_Values.Add(NODATA_CANCEL, false);

			m_Values.Add(NEAR_FULL, 0);

			m_Values.Add(SUCCESS_STAMP, 0);
		}

		public Properties(Properties Proc)
		{
			m_Values = (System.Collections.Hashtable)Proc.m_Values.Clone();
		}

		// This method is settings value
		public void SetValue(string strName, object oValue)
		{
			if(m_Values.ContainsKey(strName))
			{
				// If strName exists renewal the value
				m_Values[strName] = oValue;
			}
			else
			{
				// If strName does not exist it adds it
				m_Values.Add(strName, oValue);
			}
		}

		// This method is return value
		public int GetValue(string strName)
		{
			if(m_Values.ContainsKey(strName))
			{
				// If strName exists return to value
				return Convert.ToInt32(m_Values[strName]);
			}
			// If strName does not exist return to 0
			return 0;
		}

		// This method is return value 
		public bool GetValueBool(string strName)
		{
			// Change the values to boolean
			return Convert.ToBoolean(GetValue(strName));
		}
	}
}
