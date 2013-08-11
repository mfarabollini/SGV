using System;
using com.epson.bank.driver;
using Entidades;

namespace Presentación.Pantallas_Principal
{
    /// <summary>
    /// explanation of the outline of ApiUsage
    /// </summary>
    public class ApiUsage
    {
        protected MFDevice m_objmfDevice = null;
        protected MFBase m_objmfBase = null;
        protected MFScan m_objmfScanFront = null;
        protected MFScan m_objmfScanBack = null;
        protected MFMicr m_objmfMicr = null;
        protected MFPrint m_objmfPrint = null;
        protected MFProcess m_objmfProcess = null;
        protected ErrorCode m_errResultCode = ErrorCode.SUCCESS;
        protected Ingreso_Cheque m_objTms1000 = null;
        protected Properties m_objConfig = null;
        protected ErrorCode m_errErrorOccured = ErrorCode.SUCCESS;
        protected System.IAsyncResult m_IAar = null;
        UpdateCallback m_UpdateCallback = null;
        public ApiUsage()
        {
            // 
            // TODO: Add the constructor logic here
            //
            MFDevice.ESCNEnable(Storage.CROP_STORE_MEMORY);
            // Connect to the printer
            m_objmfDevice = new MFDevice(OpenType.TYPE_PRINTER, "TM-S1000U");
            m_objmfBase = new MFBase();
            m_objmfScanFront = new MFScan();
            m_objmfScanBack = new MFScan();
            m_objmfMicr = new MFMicr();
            m_objmfPrint = new MFPrint();
            m_objmfProcess = new MFProcess();
            m_objConfig = new Properties();


            if (CheckResponse(m_objmfDevice.LastError, "Unable to connect to printer\n\nEnsure Driver installed correctly\nand Printer is powered on"))
            {
                return;
            }

            // register for events
            // Register the callback destination
            m_objmfDevice.SCNMICRStatusCallback += new MFDevice.SCNMICRStatusCallbackHandler(SCNMICRSetStatusBack);
            m_errResultCode = m_objmfDevice.SCNMICRSetStatusBack();
            CheckResponse(m_errResultCode, "SCNMICRSetStatusBack");
        }

        // this method is called when the user click the exit button
        public void Close()
        {
            if (m_objmfDevice != null)
            {
                m_objmfDevice.SCNMICRCancelStatusBack();
                m_objmfDevice.SCNMICRStatusCallback -= new MFDevice.SCNMICRStatusCallbackHandler(SCNMICRSetStatusBack);
                m_objmfDevice.SCNMICRCancelFunction(MfEjectType.MF_EJECT_DISCHARGE);
                m_objmfDevice.CloseMonPrinter();
            }
        }

        public void CancelScan()
        {
            if (m_objmfDevice != null)
            {
                CheckResponse(m_objmfDevice.SCNMICRCancelFunction(MfEjectType.MF_EJECT_DISCHARGE),
                                "SCNMICRCancelFunction(MF_EJECT_DISCHARGE)");
            }
        }

        // copy TMS1000SampleForm object
        public void MainFormItem(Ingreso_Cheque Item)
        {
            m_objTms1000 = Item;
        }

        // this method is return transactionNumber
        public int GetTransactionNumber()
        {
            return m_objmfDevice.TransactionNumber;
        }

        // This method is called when the program starts or the user changes configuration
        // operation is offloaded to the correct ConfigureXxx function
        public void Configure(Properties Proc)
        {
            // DPI setting method
            // Specify MF_SCAN_DPI_XXX in sResolution of the MF_SCAN structure
            // Execute BiSCNMICRFunctionXXX
            // * Execute before scanning

            // Sharpening setting method
            // Specify EPS_BI_SCN_XXX as the 5th parameter of BiSCNSetImageQuality and 	execute it (other parameters are discretionary)
            // * Execute before scanning

            // Setting method for multiple electronic endorsements
            // Execute MF_PRT_BUFFERING with BiBufferedPrint
            // Set multiple electronic endorsements
            // Execute MF_PRT_EXEC with BiBufferedPrint
            // * Execute before scanning


            SetProc(Proc);

            // Set station electronic endorse
            if (CheckResponse(m_objmfDevice.SetPrintStation(PrintingStation.MF_ST_E_ENDORSEMENT), "SetPrintStation(MF_ST_E_ENDORSEMENT)"))
            {
                return;
            }

            // the registered electronic endorsement
            if (CheckResponse(m_objmfDevice.BufferedPrint(PrintBuffer.MF_PRT_CLEAR), "BufferedPrint(MF_PRT_CLEAR)"))
            {
                return;
            }

            switch (m_objConfig.GetValue(Properties.SCAN_FUNC))
            {
                case 0:
                    ConfigureMulti();
                    break;
                case 1:
                    ConfigureSingle();
                    break;
                default:
                    ConfigureMulti();
                    break;
            }
        }

        // this method is settings of multi scan
        // primarily the BiSCNMICRFunctionContinuously method is used
        private void ConfigureMulti()
        {
            // Base
            if (CheckResponse(m_objmfDevice.SCNMICRFunctionContinuously(m_objmfBase, FunctionType.MF_GET_BASE_DEFAULT),
                "SCNMICRFunctionContinuously(m_objmfBase, MF_GET_BASE_DEFAULT)"))
            {
                return;
            }
            if (CheckResponse(m_objmfDevice.SCNMICRFunctionContinuously(m_objmfBase, FunctionType.MF_SET_BASE_PARAM),
                "SCNMICRFunctionContinuously(m_objmfBase, MF_SET_BASE_PARAM)"))
            {
                return;
            }

            // ScanFront
            if (m_objConfig.GetValueBool(Properties.SCAN_FRONT))
            {
                if (CheckResponse(m_objmfDevice.SCNMICRFunctionContinuously(m_objmfScanFront, FunctionType.MF_GET_SCAN_FRONT_DEFAULT),
                    "SCNMICRFunctionContinuously(m_objmfScanFront, MF_GET_SCAN_FRONT_DEFAULT)"))
                {
                    return;
                }
                if (CheckResponse(m_objmfDevice.SCNMICRFunctionContinuously(m_objmfScanFront, FunctionType.MF_SET_SCAN_FRONT_PARAM),
                    "SCNMICRFunctionContinuously(m_objmfScanFront, MF_SET_SCAN_FRONT_PARAM)"))
                {
                    return;
                }
            }
            else
            {
                // Delete the structure set in MF_CLEAR_SCAN_FRONT_PARAM when the front side will not be scanned
                if (CheckResponse(m_objmfDevice.SCNMICRFunctionContinuously(m_objmfScanFront, FunctionType.MF_CLEAR_SCAN_FRONT_PARAM),
                    "SCNMICRFunctionContinuously(mfScanFount, MF_CLEAR_SCAN_FRONT_PARAM)"))
                {
                    return;
                }
            }

            // ScanBack
            if (m_objConfig.GetValueBool(Properties.SCAN_BACK))
            {
                if (CheckResponse(m_objmfDevice.SCNMICRFunctionContinuously(m_objmfScanBack, FunctionType.MF_GET_SCAN_BACK_DEFAULT),
                    "SCNMICRFunctionContinuously(m_objmfScanBack, MF_GET_SCAN_BACK_DEFAULT)"))
                {
                    return;
                }
                if (CheckResponse(m_objmfDevice.SCNMICRFunctionContinuously(m_objmfScanBack, FunctionType.MF_SET_SCAN_BACK_PARAM),
                    "SCNMICRFunctionContinuously(m_objmfScanBack, MF_SET_SCAN_BACK_PARAM)"))
                {
                    return;
                }
            }
            else
            {
                // Delete the structure set in MF_CLEAR_SCAN_BACK_PARAM when the reverse side will not be scanned
                if (CheckResponse(m_objmfDevice.SCNMICRFunctionContinuously(m_objmfScanBack, FunctionType.MF_CLEAR_SCAN_BACK_PARAM),
                    "SCNMICRFunctionContinuously(m_objmfScanBack, MF_CLEAR_SCAN_BACK_PARAM)"))
                {
                    return;
                }
            }

            // Micr
            if (CheckResponse(m_objmfDevice.SCNMICRFunctionContinuously(m_objmfMicr, FunctionType.MF_GET_MICR_DEFAULT),
                "SCNMICRFunctionContinuously(m_objmfMicr, MF_GET_MICR_DEFAULT)"))
            {
                return;
            }
            // MICR font designation
            switch (m_objConfig.GetValue(Properties.MICR_FONT))
            {
                case 0:
                    m_objmfMicr.Font = MfMicrFont.MF_MICR_FONT_E13B;
                    break;
                case 1:
                    m_objmfMicr.Font = MfMicrFont.MF_MICR_FONT_CMC7;
                    break;
            }
            if (CheckResponse(m_objmfDevice.SCNMICRFunctionContinuously(m_objmfMicr, FunctionType.MF_SET_MICR_PARAM),
                "SCNMICRFunctionContinuously(m_objmfMicr, MF_SET_MICR_PARAM)"))
            {
                return;
            }

            // Print
            if (CheckResponse(m_objmfDevice.SCNMICRFunctionContinuously(m_objmfPrint, FunctionType.MF_GET_PRINT_DEFAULT),
                "SCNMICRFunctionContinuously(m_objmfPrint, MF_GET_PRINT_DEFAULT)"))
            {
                return;
            }
            // An error when the lpString array is all NULL
            m_objmfPrint.String[0] = "";	// Specify blank characters
            if (CheckResponse(m_objmfDevice.SCNMICRFunctionContinuously(m_objmfPrint, FunctionType.MF_SET_PRINT_PARAM),
                "SCNMICRFunctionContinuously(m_objmfPrint, MF_SET_PRINT_PARAM)"))
            {
                return;
            }

            // Operational settings when an error occurs
            // Process
            if (CheckResponse(m_objmfDevice.SCNMICRFunctionContinuously(m_objmfProcess, FunctionType.MF_GET_PROCESS_DEFAULT),
                "SCNMICRFunctionContinuously(m_objmfProcess, MF_GET_PROCESS_DEFAULT)"))
            {
                return;
            }
            SetProcessStruct();
            if (CheckResponse(m_objmfDevice.SCNMICRFunctionContinuously(m_objmfProcess, FunctionType.MF_SET_PROCESS_PARAM),
                "SCNMICRFunctionContinuously(m_objmfProcess, MF_SET_PROCESS_PARAM)"))
            {
                return;
            }

            // Set the endorsement
            if (m_objConfig.GetValueBool(Properties.ELEC_ENDORSE_IMAGE))
            {
                // Set the electronic endorsement
                if (CheckResponse(m_objmfDevice.BufferedPrint(PrintBuffer.MF_PRT_BUFFERING),
                    "BufferedPrint(MF_PRT_BUFFERING)"))
                {
                    return;
                }

                // Set the image electronic endorsement
                ElectricEndorseImage();

                // Register the electronic endorsement set
                if (CheckResponse(m_objmfDevice.BufferedPrint(PrintBuffer.MF_PRT_EXEC),
                    "BufferedPrint(MF_PRT_EXEC)"))
                {
                    return;
                }
            }
        }

        // this method is settings of single scan
        // primarily the BiSCNMICRFunctionPostPrint method is used
        private void ConfigureSingle()
        {
            // Base
            if (CheckResponse(m_objmfDevice.SCNMICRFunctionPostPrint(m_objmfBase, FunctionType.MF_GET_BASE_DEFAULT),
                "SCNMICRFunctionPostPrint(m_objmfBase, MF_GET_BASE_DEFAULT)"))
            {
                return;
            }
            if (CheckResponse(m_objmfDevice.SCNMICRFunctionPostPrint(m_objmfBase, FunctionType.MF_SET_BASE_PARAM),
                "SCNMICRFunctionPostPrint(m_objmfBase, MF_SET_BASE_PARAM)"))
            {
                return;
            }

            // ScanFront
            if (m_objConfig.GetValueBool(Properties.SCAN_FRONT))
            {
                if (CheckResponse(m_objmfDevice.SCNMICRFunctionPostPrint(m_objmfScanFront, FunctionType.MF_GET_SCAN_FRONT_DEFAULT),
                    "SCNMICRFunctionPostPrint(m_objmfScanFront, MF_GET_SCAN_FRONT_DEFAULT)"))
                {
                    return;
                }
                if (CheckResponse(m_objmfDevice.SCNMICRFunctionPostPrint(m_objmfScanFront, FunctionType.MF_SET_SCAN_FRONT_PARAM),
                    "SCNMICRFunctionPostPrint(m_objmfScanFront, MF_SET_SCAN_FRONT_PARAM)"))
                {
                    return;
                }
            }
            else
            {
                // Delete the structure set in MF_CLEAR_SCAN_FRONT_PARAM when the front side will not be scanned
                if (CheckResponse(m_objmfDevice.SCNMICRFunctionPostPrint(m_objmfScanFront, FunctionType.MF_CLEAR_SCAN_FRONT_PARAM),
                    "SCNMICRFunctionPostPrint(m_objmfScanFront, MF_CLEAR_SCAN_FRONT_PARAM)"))
                {
                    return;
                }
            }

            // ScanBack
            if (m_objConfig.GetValueBool(Properties.SCAN_BACK))
            {
                if (CheckResponse(m_objmfDevice.SCNMICRFunctionPostPrint(m_objmfScanBack, FunctionType.MF_GET_SCAN_BACK_DEFAULT),
                    "SCNMICRFunctionPostPrint(m_objmfScanBack, MF_GET_SCAN_BACK_DEFAULT)"))
                {
                    return;
                }
                if (CheckResponse(m_objmfDevice.SCNMICRFunctionPostPrint(m_objmfScanBack, FunctionType.MF_SET_SCAN_BACK_PARAM),
                    "SCNMICRFunctionPostPrint(m_objmfScanBack, MF_SET_SCAN_BACK_PARAM)"))
                {
                    return;
                }
            }
            else
            {
                // Delete the structure set in MF_CLEAR_SCAN_BACK_PARAM when the reverse side will not be scanned
                if (CheckResponse(m_objmfDevice.SCNMICRFunctionPostPrint(m_objmfScanBack, FunctionType.MF_CLEAR_SCAN_BACK_PARAM),
                    "SCNMICRFunctionPostPrint(m_objmfScanBack, MF_CLEAR_SCAN_BACK_PARAM)"))
                {
                    return;
                }
            }

            // Micr
            if (CheckResponse(m_objmfDevice.SCNMICRFunctionPostPrint(m_objmfMicr, FunctionType.MF_GET_MICR_DEFAULT),
                "SCNMICRFunctionPostPrint(m_objmfMicr, MF_GET_MICR_DEFAULT)"))
            {
                return;
            }
            // MICR font designation
            switch (m_objConfig.GetValue(Properties.MICR_FONT))
            {
                case 0:
                    m_objmfMicr.Font = MfMicrFont.MF_MICR_FONT_E13B;
                    break;
                case 1:
                    m_objmfMicr.Font = MfMicrFont.MF_MICR_FONT_CMC7;
                    break;
            }
            if (CheckResponse(m_objmfDevice.SCNMICRFunctionPostPrint(m_objmfMicr, FunctionType.MF_SET_MICR_PARAM),
                "SCNMICRFunctionPostPrint(m_objmfMicr, MF_SET_MICR_PARAM)"))
            {
                return;
            }

            // Print
            if (CheckResponse(m_objmfDevice.SCNMICRFunctionPostPrint(m_objmfPrint, FunctionType.MF_GET_PRINT_DEFAULT),
                "SCNMICRFunctionPostPrint(m_objmfPrint, MF_GET_PRINT_DEFAULT)"))
            {
                return;
            }
            // An error when the lpString array is all NULL
            m_objmfPrint.String[0] = "";	// Specify blank characters
            if (CheckResponse(m_objmfDevice.SCNMICRFunctionPostPrint(m_objmfPrint, FunctionType.MF_SET_PRINT_PARAM),
                "SCNMICRFunctionPostPrint(m_objmfPrint, MF_SET_PRINT_PARAM)"))
            {
                return;
            }

            // Operational settings when an error occurs
            // Process
            if (CheckResponse(m_objmfDevice.SCNMICRFunctionPostPrint(m_objmfProcess, FunctionType.MF_GET_PROCESS_DEFAULT),
                "SCNMICRFunctionPostPrint(m_objmfProcess, MF_GET_PROCESS_DEFAULT)"))
            {
                return;
            }
            SetProcessStruct();
            if (CheckResponse(m_objmfDevice.SCNMICRFunctionPostPrint(m_objmfProcess, FunctionType.MF_SET_PROCESS_PARAM),
                "SCNMICRFunctionPostPrint(m_objmfProcess, MF_SET_PROCESS_PARAM)"))
            {
                return;
            }

            // Set the endorsement
            if (m_objConfig.GetValueBool(Properties.ELEC_ENDORSE_IMAGE))
            {
                // Set the electronic endorsement
                if (CheckResponse(m_objmfDevice.BufferedPrint(PrintBuffer.MF_PRT_BUFFERING),
                    "BufferedPrint(MF_PRT_BUFFERING)"))
                {
                    return;
                }

                // Set the image electronic endorsement
                ElectricEndorseImage();

                // Register the electronic endorsement set
                if (CheckResponse(m_objmfDevice.BufferedPrint(PrintBuffer.MF_PRT_EXEC),
                    "BufferedPrint(MF_PRT_EXEC)"))
                {
                    return;
                }
            }
        }

        // This method is called when the user clicks the scan button
        // operation is offloaded to the correct Scan function
        public void Scan()
        {
            bool bRet = false;
            switch (m_objConfig.GetValue(Properties.SCAN_FUNC))
            {
                case 0:
                    bRet = CheckResponse(m_objmfDevice.SCNMICRFunctionContinuously(FunctionType.MF_EXEC),
                                "SCNMICRFunctionContinuously(MF_EXEC)");
                    break;
                case 1:
                    bRet = CheckResponse(m_objmfDevice.SCNMICRFunctionPostPrint(FunctionType.MF_EXEC),
                                "SCNMICRFunctionPostPrint(MF_EXEC)");
                    break;
                default:
                    bRet = CheckResponse(m_objmfDevice.SCNMICRFunctionContinuously(FunctionType.MF_EXEC),
                                "SCNMICRFunctionContinuously(MF_EXEC)");
                    break;
            }

            // Failure to the scan start
            if (bRet)
            {
                m_objTms1000.Complate(0);
            }

        }

        // this method is insert proc in m_objConfig
        public void SetProc(Properties Proc)
        {
            m_objConfig = Proc;
        }

        // This method is called whenever the scan state changes
        // Called when scanning with BiSCNMICRFunctionPostPrint/BiSCNMICRFunctionContinuously
        private void SCNMICRSetStatusBack(int iTransactionNumber, MainStatus mainStatus, ErrorCode subStatus, string portName)
        {
            // Finish scan process
            if (mainStatus == MainStatus.MF_FUNCTION_DONE)
            {
                if (m_IAar != null)
                {
                    m_objTms1000.EndInvoke(m_IAar);
                    m_IAar = null;
                }

                // Scan End
                m_objTms1000.Complate(iTransactionNumber);
            }
            // Error Occured
            else if (mainStatus == MainStatus.MF_ERROR_OCCURED)
            {
                m_errErrorOccured = subStatus;
            }
            // Data receive complete
            else if (mainStatus == MainStatus.MF_DATARECEIVE_DONE)
            {
                string strMicr = "";
                bool bFrontDisplay = false;
                bool bFrontGrayscale = false;
                bool bBackDisplay = false;
                bool bBackGrayscale = false;

                // get MICR data
                if (m_objConfig.GetValueBool(Properties.MICR))
                {
                    // Specify the relevant item for MICR text
                    m_objmfMicr.MicrOcrSelect = MfMicrType.MF_MICR_USE_MICR;
                    m_objmfMicr.Parsing = false;
                    // Acquire MICR text
                    m_errResultCode = m_objmfDevice.GetMicrText(iTransactionNumber, m_objmfMicr);
                    strMicr = m_objmfMicr.MicrStr.Substring(0, m_objmfMicr.MicrStr.IndexOf("\0"));
                    if (!ErrorCode.SUCCESS.Equals(m_objmfMicr.Ret))
                    {
                        // Add error code
                        strMicr += "(" + m_objmfMicr.Ret + ")";
                    }
                }

                // save MICR data
                if (m_objConfig.GetValueBool(Properties.MICR_SAVE_ENABLE) && m_objConfig.GetValueBool(Properties.MICR_SAVE))
                {
                    SaveMicr(iTransactionNumber);
                }

                // get front image
                if (m_objConfig.GetValueBool(Properties.SCAN_FRONT))
                {
                    // Set the relevant item for the front side image
                    m_errResultCode = m_objmfDevice.SCNSelectScanFace(ScanSide.MF_SCAN_FACE_FRONT);
                    if (ErrorCode.SUCCESS.Equals(m_errResultCode))
                    {
                        // Set grayscale
                        ColorDepth cdColor;
                        bFrontGrayscale = m_objConfig.GetValueBool(Properties.FRONT_GRAYSCALE);
                        if (bFrontGrayscale)
                        {
                            cdColor = ColorDepth.EPS_BI_SCN_8BIT;
                        }
                        else
                        {
                            cdColor = ColorDepth.EPS_BI_SCN_1BIT;
                        }
                        m_errResultCode = m_objmfDevice.SCNSetImageQuality(cdColor, 0, Color.EPS_BI_SCN_MONOCHROME, ExOption.EPS_BI_SCN_SHARP);

                        // set format
                        if (bFrontGrayscale)
                        {
                            m_objmfDevice.SCNSetImageFormat(Format.EPS_BI_SCN_JPEGNORMAL);
                        }
                        else
                        {
                            m_objmfDevice.SCNSetImageFormat(Format.EPS_BI_SCN_TIFF);
                        }

                        // Acquire image data
                        m_errResultCode = m_objmfDevice.GetScanImage(iTransactionNumber, m_objmfScanFront);

                        // display front image
                        bFrontDisplay = m_objConfig.GetValueBool(Properties.FRONT_DISPLAY);

                        // save front image
                        if (m_objConfig.GetValueBool(Properties.FRONT_SAVE))
                        {
                            // Set grayscale
                            string strFileName = "";
                            if (m_objConfig.GetValueBool(Properties.FRONT_GRAYSCALE))
                            {
                                strFileName = iTransactionNumber.ToString("000") + ".front.jpg";
                            }
                            else
                            {
                                strFileName = iTransactionNumber.ToString("000") + ".front.tif";
                            }

                            if (ErrorCode.SUCCESS.Equals(m_errResultCode))
                            {
                                System.IO.Stream data = m_objmfScanFront.Data;
                                System.IO.FileStream file = new System.IO.FileStream(strFileName, System.IO.FileMode.Create);
                                byte[] buffer = new byte[data.Length];

                                // Save in file
                                data.Read(buffer, 0, buffer.Length);
                                file.Write(buffer, 0, buffer.Length);

                                data.Close();
                                file.Close();
                            }
                        }
                    }
                }

                // set electric endorse
                if (m_objConfig.GetValueBool(Properties.ELEC_ENDORSE_TEXT))
                {
                    ElectricEndorseText();
                }

                // get back image
                if (m_objConfig.GetValueBool(Properties.SCAN_BACK))
                {
                    // Set the relevant item for the front side
                    m_errResultCode = m_objmfDevice.SCNSelectScanFace(ScanSide.MF_SCAN_FACE_BACK);
                    if (ErrorCode.SUCCESS.Equals(m_errResultCode))
                    {
                        // Set grayscale
                        ColorDepth bColor;
                        bBackGrayscale = m_objConfig.GetValueBool(Properties.BACK_GRAYSCALE);
                        if (bBackGrayscale)
                        {
                            bColor = ColorDepth.EPS_BI_SCN_8BIT;
                        }
                        else
                        {
                            bColor = ColorDepth.EPS_BI_SCN_1BIT;
                        }
                        m_errResultCode = m_objmfDevice.SCNSetImageQuality(bColor, 0, Color.EPS_BI_SCN_MONOCHROME, ExOption.EPS_BI_SCN_SHARP);

                        // set format
                        if (bFrontGrayscale)
                        {
                            m_objmfDevice.SCNSetImageFormat(Format.EPS_BI_SCN_JPEGNORMAL);
                        }
                        else
                        {
                            m_objmfDevice.SCNSetImageFormat(Format.EPS_BI_SCN_TIFF);
                        }

                        // Acquire image data
                        m_errResultCode = m_objmfDevice.GetScanImage(iTransactionNumber, m_objmfScanBack);

                        // display back image
                        bBackDisplay = m_objConfig.GetValueBool(Properties.BACK_DISPLAY);

                        // save back image
                        if (m_objConfig.GetValueBool(Properties.BACK_SAVE))
                        {
                            // Set grayscale
                            string strFileName = "";
                            if (m_objConfig.GetValueBool(Properties.BACK_GRAYSCALE))
                            {
                                strFileName = iTransactionNumber.ToString("000") + ".back.jpg";
                            }
                            else
                            {
                                strFileName = iTransactionNumber.ToString("000") + ".back.tif";
                            }

                            if (ErrorCode.SUCCESS.Equals(m_errResultCode))
                            {
                                System.IO.Stream data = m_objmfScanBack.Data;
                                System.IO.FileStream file = new System.IO.FileStream(strFileName, System.IO.FileMode.Create);
                                byte[] buffer = new byte[data.Length];

                                // Save in file
                                data.Read(buffer, 0, buffer.Length);
                                file.Write(buffer, 0, buffer.Length);

                                data.Close();
                                file.Close();
                            }
                        }
                    }
                }

                Update(bFrontDisplay ? m_objmfScanFront.Image : null, bBackDisplay ? m_objmfScanBack.Image : null, strMicr);

                // Is it Confirmation Mode?
                if (m_objConfig.GetValueBool(Properties.CONFIRMATION))
                {
                    // Execute BiSetBehaviorToScnResult?
                    if (m_objConfig.GetValueBool(Properties.RUN_SCN_TO_RESULT))
                    {
                        // Call BiSetBehaviorToScnResult?
                        if (!m_objConfig.GetValueBool(Properties.NO_CALL_SCN_TO_RESULT))
                        {
                            // Display BiSetBehaviorToScnResult dialog box
                            // Do no execute if it is canceled in the dialog box
                            if (m_objTms1000.Confirmation())
                            {
                                MfProcessContinue bNextCheck;

                                switch (m_objConfig.GetValue(Properties.CONF_NEXT_CHECK))
                                {
                                    case 0:
                                        bNextCheck = MfProcessContinue.MF_PROCESS_CONTINUE_OVERLAP;
                                        break;
                                    case 1:
                                        bNextCheck = MfProcessContinue.MF_PROCESS_CONTINUE_NOOVERLAP;
                                        break;
                                    case 2:
                                        bNextCheck = MfProcessContinue.MF_PROCESS_CONTINUE_CANCEL;
                                        break;
                                    default:
                                        bNextCheck = MfProcessContinue.MF_PROCESS_CONTINUE_OVERLAP;
                                        break;
                                }

                                m_objmfDevice.SetBehaviorToScnResult(GetEject(m_objConfig.GetValue(Properties.CONF_EJECT)),
                                    GetStamp(m_objConfig.GetValueBool(Properties.CONF_STAMP)),
                                    bNextCheck);
                            }
                        }
                        else
                        {
                            // Use the value set without calling BiSetBehaviorToScnResult

                            MfProcessContinue bNextCheck;

                            switch (m_objConfig.GetValue(Properties.CONF_NEXT_CHECK))
                            {
                                case 0:
                                    bNextCheck = MfProcessContinue.MF_PROCESS_CONTINUE_OVERLAP;
                                    break;
                                case 1:
                                    bNextCheck = MfProcessContinue.MF_PROCESS_CONTINUE_NOOVERLAP;
                                    break;
                                case 2:
                                    bNextCheck = MfProcessContinue.MF_PROCESS_CONTINUE_CANCEL;
                                    break;
                                default:
                                    bNextCheck = MfProcessContinue.MF_PROCESS_CONTINUE_OVERLAP;
                                    break;
                            }

                            m_objmfDevice.SetBehaviorToScnResult(GetEject(m_objConfig.GetValue(Properties.CONF_EJECT)),
                                GetStamp(m_objConfig.GetValueBool(Properties.CONF_STAMP)),
                                bNextCheck);
                        }
                    }
                }
                m_errErrorOccured = ErrorCode.SUCCESS;
            }
        }

        // This delegate enables asynchronous calls for setting.
        delegate void UpdateCallback(System.Drawing.Image FrontImage, System.Drawing.Image BackImage, string strMicr);

        private void Update(System.Drawing.Image FrontImage, System.Drawing.Image BackImage, string strMicr)
        {
            if (m_objTms1000.InvokeRequired)
            {
                if (m_UpdateCallback == null)
                {
                    m_UpdateCallback = new UpdateCallback(Update);
                }
                m_IAar = m_objTms1000.BeginInvoke(m_UpdateCallback, new object[] { FrontImage, BackImage, strMicr });
            }
            else
            {
                cheques cheque = new cheques();
                cheque.Cod_Banco = strMicr.Substring(1, 3);
                cheque.Cod_Sucursal = strMicr.Substring(4, 3);
                cheque.Cod_Postal = strMicr.Substring(7, 4);
                cheque.Num_Cuenta = strMicr.Substring(11, 8);
                cheque.Num_Cheque = strMicr.Substring(19, 11);
                m_objTms1000.llenoTablaCheques(cheque);
                //m_objTms1000.SetFrontImage(FrontImage);
                //m_objTms1000.SetBackImage(BackImage);
                //m_objTms1000.SetMicr(strMicr);
            }
        }

        // settings endorse text
        private void ElectricEndorseText()
        {
            MFTrueType mfDecorate = null;
            System.Drawing.Font objFont = null;

            // set position
            if (CheckResponse(m_objmfDevice.SetPrintPosition(10, 60), "SetPrintPosition(10, 60)"))
            {
                return;
            }

            mfDecorate = new MFTrueType();
            mfDecorate.Color = PrintColor.MF_PRINT_BLACK;
            objFont = new System.Drawing.Font("Arial", 30);
            mfDecorate.Font = objFont;
            m_errResultCode = m_objmfDevice.PrintText("Transaction#:<00000000>", mfDecorate);
            CheckResponse(m_errResultCode, "BiPrintText");
        }

        // settings endorse image
        private void ElectricEndorseImage()
        {
            // set position
            if (CheckResponse(m_objmfDevice.SetPrintPosition(100, 30), "SetPrintPosition(100, 30)"))
            {
                return;
            }

            // set size
            if (CheckResponse(m_objmfDevice.SetPrintSize(30, 30), "SetPrintSize(30, 30)"))
            {
                return;
            }

            // set endowse image
            CheckResponse(m_objmfDevice.PrintImage("image.jpg"), "PrintImage(image.jpg)");
        }

        // this method is return response
        // SUCCESS : Return to FALSE
        // ERROR : Display the message box, return TRUE
        private bool CheckResponse(ErrorCode ecError, string strMethod)
        {
            if (ecError != ErrorCode.SUCCESS)
            {
                System.Windows.Forms.MessageBox.Show(strMethod, ecError.ToString());
                return true;
            }
            return false;
        }

        // settings Process structure
        private void SetProcessStruct()
        {
            // Activate Mode
            if (m_objConfig.GetValueBool(Properties.CONFIRMATION))
            {
                m_objmfProcess.ActivationMode = MfActivateMode.MF_ACTIVATE_MODE_CONFIRMATION;
            }
            else
            {
                m_objmfProcess.ActivationMode = MfActivateMode.MF_ACTIVATE_MODE_HIGH_SPEED;
            }

            // PaperMisInsertion
            m_objmfProcess.PaperMisInsertionErrorSelect = GetDetect(m_objConfig.GetValueBool(Properties.MIS_INSERT_DETECT));
            m_objmfProcess.PaperMisInsertionErrorEject = GetEject(m_objConfig.GetValue(Properties.MIS_INSERT_EJECT));
            m_objmfProcess.PaperMisInsertionStamp = GetStamp(m_objConfig.GetValueBool(Properties.MIS_INSERT_STAMP));
            m_objmfProcess.PaperMisInsertionCancel = GetCancel(m_objConfig.GetValueBool(Properties.MIS_INSERT_CANCEL));

            // Noise
            m_objmfProcess.NoiseErrorSelect = GetDetect(m_objConfig.GetValueBool(Properties.NOISE_DETECT));
            m_objmfProcess.NoiseErrorEject = GetEject(m_objConfig.GetValue(Properties.NOISE_EJECT));
            m_objmfProcess.NoiseStamp = GetStamp(m_objConfig.GetValueBool(Properties.NOISE_STAMP));
            m_objmfProcess.NoiseCancel = GetCancel(m_objConfig.GetValueBool(Properties.NOISE_CANCEL));

            // DoubleFeed
            m_objmfProcess.DoubleFeedErrorSelect = GetDetect(m_objConfig.GetValueBool(Properties.DOUBLE_FEED_DETECT));
            m_objmfProcess.DoubleFeedErrorEject = GetEject(m_objConfig.GetValue(Properties.DOUBLE_FEED_EJECT));
            m_objmfProcess.DoubleFeedStamp = GetStamp(m_objConfig.GetValueBool(Properties.DOUBLE_FEED_STAMP));
            m_objmfProcess.DoubleFeedCancel = GetCancel(m_objConfig.GetValueBool(Properties.DOUBLE_FEED_CANCEL));

            // Baddata
            m_objmfProcess.BaddataCount = Convert.ToByte(m_objConfig.GetValue(Properties.BADDATA_COUNT));
            m_objmfProcess.BaddataErrorSelect = GetDetect(m_objConfig.GetValueBool(Properties.BADDATA_DETECT));
            m_objmfProcess.BaddataErrorEject = GetEject(m_objConfig.GetValue(Properties.BADDATA_EJECT));
            m_objmfProcess.BaddataStamp = GetStamp(m_objConfig.GetValueBool(Properties.BADDATA_STAMP));
            m_objmfProcess.BaddataCancel = GetCancel(m_objConfig.GetValueBool(Properties.BADDATA_CANCEL));

            // Nodata
            m_objmfProcess.NodataErrorSelect = GetDetect(m_objConfig.GetValueBool(Properties.NODATA_DETECT));
            m_objmfProcess.NodataErrorEject = GetEject(m_objConfig.GetValue(Properties.NODATA_EJECT));
            m_objmfProcess.NodataStamp = GetStamp(m_objConfig.GetValueBool(Properties.NODATA_STAMP));
            m_objmfProcess.NodataCancel = GetCancel(m_objConfig.GetValueBool(Properties.NODATA_CANCEL));
        }

        // MICR data is preserved
        private void SaveMicr(int transactionNumber)
        {
            // Create log file name
            System.IO.StreamWriter sw = new System.IO.StreamWriter(transactionNumber.ToString() + ".Micr.txt");
            try
            {
                // Values that are always printed out
                sw.WriteLine("# MICR Data Output");
                sw.WriteLine();
                sw.WriteLine("# General Transaction Information:");
                sw.WriteLine();
                sw.WriteLine("TransactionNumber = " + transactionNumber.ToString());
                // MICR
                if (m_objConfig.GetValueBool(Properties.MICR))
                {
                    m_objmfMicr.Parsing = true;
                    // Acquire MICR text
                    m_objmfMicr.MicrOcrSelect = MfMicrType.MF_MICR_USE_MICR;
                    // Get the text acquired
                    m_objmfDevice.GetMicrText(transactionNumber, m_objmfMicr);
                    sw.WriteLine("Result = " + m_objmfMicr.Ret.ToString());
                    sw.WriteLine("Status = " + m_objmfMicr.Status.ToString());
                    sw.WriteLine("Detail = " + m_objmfMicr.Detail.ToString());
                    sw.WriteLine();
                    sw.WriteLine();
                    sw.WriteLine("# Magnetic Character Results:");
                    sw.WriteLine();
                    sw.WriteLine("Raw Data       = " + m_objmfMicr.MicrStr);
                    sw.WriteLine("Account Number = " + m_objmfMicr.AccountNumber);
                    sw.WriteLine("Amount         = " + m_objmfMicr.Amount);
                    sw.WriteLine("Bank Number    = " + m_objmfMicr.BankNumber);
                    sw.WriteLine("Serial Number  = " + m_objmfMicr.SerialNumber);
                    sw.WriteLine("EPC Property   = " + m_objmfMicr.EPC);
                    sw.WriteLine("Transit Number = " + m_objmfMicr.TransitNumber);
                    sw.WriteLine("Check Type     = " + m_objmfMicr.CheckType.ToString());
                    sw.WriteLine("Country Code   = " + m_objmfMicr.CountryCode.ToString());
                }
            }
            finally
            {
                sw.Close();
            }
        }

        // this method is return the  value of ErrorSelect 
        private MfErrorSelect GetDetect(bool bDetect)
        {
            if (bDetect)
            {
                return MfErrorSelect.MF_ERROR_SELECT_DETECT;
            }
            else
            {
                return MfErrorSelect.MF_ERROR_SELECT_NODETECT;
            }
        }

        // this method is return the  value of ErrorEject
        private MfEject GetEject(int iEject)
        {
            switch (iEject)
            {
                case 0:
                    return MfEject.MF_EJECT_MAIN_POCKET;
                case 1:
                    return MfEject.MF_EJECT_SUB_POCKET;
                case 2:
                    return MfEject.MF_EJECT_NOEJECT;
                default:
                    return MfEject.MF_EJECT_MAIN_POCKET;
            }
        }

        // this method is return the  value of Stamp
        private MfStamp GetStamp(bool bStamp)
        {
            if (bStamp)
            {
                return MfStamp.MF_STAMP_ENABLE;
            }
            else
            {
                return MfStamp.MF_STAMP_DISABLE;
            }
        }

        // this method is return the  value of Cancel
        private MfCancel GetCancel(bool bCancel)
        {
            if (bCancel)
            {
                return MfCancel.MF_CANCEL_ENABLE;
            }
            else
            {
                return MfCancel.MF_CANCEL_DISABLE;
            }
        }

        // get error occured
        public string GetErrorOccured()
        {
            return m_errErrorOccured.ToString();
        }

        public TimeSpan GetStartWaitTime()
        {
            uint uiStartWaitTime = m_objmfProcess.StartWaitTime;
            if (uiStartWaitTime > 6400)
            {
                uiStartWaitTime = 6400;
            }
            return TimeSpan.FromMilliseconds((double)uiStartWaitTime);
        }
    }
}
