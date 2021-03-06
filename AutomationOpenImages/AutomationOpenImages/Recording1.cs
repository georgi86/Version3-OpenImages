﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;
using Ranorex.Core.Repository;

namespace AutomationOpenImages
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Recording1 recording.
    /// </summary>
    [TestModule("54d9f563-b350-47a2-b3a7-b9d922eda964", ModuleType.Recording, 1)]
    public partial class Recording1 : ITestModule
    {
        /// <summary>
        /// Holds an instance of the AutomationOpenImagesRepository repository.
        /// </summary>
        public static AutomationOpenImagesRepository repo = AutomationOpenImagesRepository.Instance;

        static Recording1 instance = new Recording1();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Recording1()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Recording1 Instance
        {
            get { return instance; }
        }

#region Variables

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "7.0")]
        public static void Start()
        {
            TestModuleRunner.Run(Instance);
        }

        /// <summary>
        /// Performs the playback of actions in this recording.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "7.0")]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.00;
            
            Init();

            string strBigModeCaptionText = "Measure";

            bool bBigMode = true;

            try
            {
                Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SnapXUntitled.TextMeasure' at 32;9.", repo.SnapXUntitled.TextMeasureInfo, new RecordItemIndex(2));
                repo.SnapXUntitled.TextMeasure.MoveTo();
                Delay.Milliseconds(200);

                bBigMode = repo.SnapXUntitled.TextMeasure.TextValue.CompareTo(strBigModeCaptionText) == 0 && repo.SnapXUntitled.TextMeasure.Visible;
            }
            catch (Exception ex)
            {
              
            }

            if (!bBigMode)

                repo.SnapXUntitled.SwitchToSensor.Click();
                Delay.Milliseconds(200);
                        
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ModeSelectorBurtton' at 59;36.", repo.ModeSelectorBurttonInfo, new RecordItemIndex(1));
            repo.ModeSelectorBurtton.Click("59;36");
            Delay.Milliseconds(200);                

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SnapXUntitled.TitleBar' at 833;13.", repo.SnapXUntitled.TitleBarInfo, new RecordItemIndex(5));
            repo.SnapXUntitled.TitleBar.Click("833;13");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SnapXUntitled.OpenImageButton' at Center.", repo.SnapXUntitled.OpenImageButtonInfo, new RecordItemIndex(6));
            repo.SnapXUntitled.OpenImageButton.Click("Center");
            Delay.Milliseconds(1000);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Delete}'.", new RecordItemIndex(7));
            Keyboard.Press("{Delete}");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'C:\\JORO\\AUTOMATIONS\\GIT_Automations\\VERSION 3\\Images\\1.bmp'.", new RecordItemIndex(8));
            Keyboard.Press("C:\\JORO\\AUTOMATIONS\\GIT_Automations\\VERSION 3\\Images\\1.bmp");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Return}'.", new RecordItemIndex(9));
            Keyboard.Press("{Return}");
            Delay.Milliseconds(100);

            
            try
            {
                Report.Log(ReportLevel.Info, "Validation", "Validating ContainsImage (Screenshot: 'Screenshot1' with region {X=118,Y=70,Width=981,Height=837}) on item 'SnapXUntitled.Pictures'.", repo.SnapXUntitled.PicturesInfo, new RecordItemIndex(11));
                Validate.ContainsImage(repo.SnapXUntitled.PicturesInfo, Pictures_Screenshot1, Pictures_Screenshot1_Options);
                Delay.Milliseconds(100);
            }
            catch (Exception ex)
            {
                
            }                  
                                    
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SnapXUntitled.OpenImageButton' at Center.", repo.SnapXUntitled.OpenImageButtonInfo, new RecordItemIndex(12));
            repo.SnapXUntitled.OpenImageButton.Click("Center");
            Delay.Milliseconds(1000);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Delete}'.", new RecordItemIndex(13));
            Keyboard.Press("{Delete}");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'C:\\JORO\\AUTOMATIONS\\GIT_Automations\\VERSION 3\\Images\\2.bmp'.", new RecordItemIndex(14));
            Keyboard.Press("C:\\JORO\\AUTOMATIONS\\GIT_Automations\\VERSION 3\\Images\\2.bmp");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Return}'.", new RecordItemIndex(15));
            Keyboard.Press("{Return}");
            Delay.Milliseconds(100);

            try
            {
                Report.Log(ReportLevel.Info, "Validation", "Validating ContainsImage (Screenshot: 'Screenshot2' with region {X=146,Y=61,Width=944,Height=823}) on item 'SnapXUntitled.Pictures'.", repo.SnapXUntitled.PicturesInfo, new RecordItemIndex(16));
                Validate.ContainsImage(repo.SnapXUntitled.PicturesInfo, Pictures_Screenshot2, Pictures_Screenshot2_Options);
                Delay.Milliseconds(100);
            }
            catch (Exception ex)
            {

            }
                        
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SnapXUntitled.OpenImageButton' at Center.", repo.SnapXUntitled.OpenImageButtonInfo, new RecordItemIndex(17));
            repo.SnapXUntitled.OpenImageButton.Click("Center");
            Delay.Milliseconds(1000);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Delete}'.", new RecordItemIndex(18));
            Keyboard.Press("{Delete}");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'C:\\JORO\\AUTOMATIONS\\GIT_Automations\\VERSION 3\\Images\\3.bmp'.", new RecordItemIndex(19));
            Keyboard.Press("C:\\JORO\\AUTOMATIONS\\GIT_Automations\\VERSION 3\\Images\\3.bmp");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Return}'.", new RecordItemIndex(20));
            Keyboard.Press("{Return}");
            Delay.Milliseconds(100);

            try
            {
                Report.Log(ReportLevel.Info, "Validation", "Validating ContainsImage (Screenshot: 'Screenshot3' with region {X=85,Y=104,Width=1019,Height=742}) on item 'SnapXUntitled.Pictures'.", repo.SnapXUntitled.PicturesInfo, new RecordItemIndex(21));
                Validate.ContainsImage(repo.SnapXUntitled.PicturesInfo, Pictures_Screenshot3, Pictures_Screenshot3_Options);
                Delay.Milliseconds(100);
            }
            catch (Exception ex)
            {

            }            
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SnapXUntitled.OpenImageButton' at Center.", repo.SnapXUntitled.OpenImageButtonInfo, new RecordItemIndex(22));
            repo.SnapXUntitled.OpenImageButton.Click("Center");
            Delay.Milliseconds(1000);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Delete}'.", new RecordItemIndex(23));
            Keyboard.Press("{Delete}");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'C:\\JORO\\AUTOMATIONS\\GIT_Automations\\VERSION 3\\Images\\4.bmp'.", new RecordItemIndex(24));
            Keyboard.Press("C:\\JORO\\AUTOMATIONS\\GIT_Automations\\VERSION 3\\Images\\4.bmp");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Return}'.", new RecordItemIndex(25));
            Keyboard.Press("{Return}");
            Delay.Milliseconds(100);

            try
            {
                Report.Log(ReportLevel.Info, "Validation", "Validating ContainsImage (Screenshot: 'Screenshot4' with region {X=109,Y=189,Width=1004,Height=676}) on item 'SnapXUntitled.Pictures'.", repo.SnapXUntitled.PicturesInfo, new RecordItemIndex(26));
                Validate.ContainsImage(repo.SnapXUntitled.PicturesInfo, Pictures_Screenshot4, Pictures_Screenshot4_Options);
                Delay.Milliseconds(100);
            }
            catch (Exception ex)
            {

            }            
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SnapXUntitled.OpenImageButton' at Center.", repo.SnapXUntitled.OpenImageButtonInfo, new RecordItemIndex(27));
            repo.SnapXUntitled.OpenImageButton.Click("Center");
            Delay.Milliseconds(1000);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Delete}'.", new RecordItemIndex(28));
            Keyboard.Press("{Delete}");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'C:\\JORO\\AUTOMATIONS\\GIT_Automations\\VERSION 3\\Images\\5.bmp'.", new RecordItemIndex(29));
            Keyboard.Press("C:\\JORO\\AUTOMATIONS\\GIT_Automations\\VERSION 3\\Images\\5.bmp");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Return}'.", new RecordItemIndex(30));
            Keyboard.Press("{Return}");
            Delay.Milliseconds(100);

            try
            {
                Report.Log(ReportLevel.Info, "Validation", "Validating ContainsImage (Screenshot: 'Screenshot5' with region {X=199,Y=217,Width=862,Height=600}) on item 'SnapXUntitled.Pictures'.", repo.SnapXUntitled.PicturesInfo, new RecordItemIndex(31));
                Validate.ContainsImage(repo.SnapXUntitled.PicturesInfo, Pictures_Screenshot5, Pictures_Screenshot5_Options);
                Delay.Milliseconds(100);
            }
            catch (Exception ex)
            {

            }            
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SnapXUntitled.OpenImageButton' at Center.", repo.SnapXUntitled.OpenImageButtonInfo, new RecordItemIndex(32));
            repo.SnapXUntitled.OpenImageButton.Click("Center");
            Delay.Milliseconds(1000);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Delete}'.", new RecordItemIndex(33));
            Keyboard.Press("{Delete}");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'C:\\JORO\\AUTOMATIONS\\GIT_Automations\\VERSION 3\\Images\\6.bmp'.", new RecordItemIndex(34));
            Keyboard.Press("C:\\JORO\\AUTOMATIONS\\GIT_Automations\\VERSION 3\\Images\\6.bmp");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Return}'.", new RecordItemIndex(35));
            Keyboard.Press("{Return}");
            Delay.Milliseconds(100);

            try
            {
                Report.Log(ReportLevel.Info, "Validation", "Validating ContainsImage (Screenshot: 'Screenshot6' with region {X=142,Y=141,Width=900,Height=653}) on item 'SnapXUntitled.Pictures'.", repo.SnapXUntitled.PicturesInfo, new RecordItemIndex(36));
                Validate.ContainsImage(repo.SnapXUntitled.PicturesInfo, Pictures_Screenshot6, Pictures_Screenshot6_Options);
                Delay.Milliseconds(100);
            }
            catch (Exception ex)
            {

            }                       
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SnapXUntitled.OpenImageButton' at Center.", repo.SnapXUntitled.OpenImageButtonInfo, new RecordItemIndex(37));
            repo.SnapXUntitled.OpenImageButton.Click("Center");
            Delay.Milliseconds(1000);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Delete}'.", new RecordItemIndex(38));
            Keyboard.Press("{Delete}");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'C:\\JORO\\AUTOMATIONS\\GIT_Automations\\VERSION 3\\Images\\7.bmp'.", new RecordItemIndex(39));
            Keyboard.Press("C:\\JORO\\AUTOMATIONS\\GIT_Automations\\VERSION 3\\Images\\7.bmp");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Return}'.", new RecordItemIndex(40));
            Keyboard.Press("{Return}");
            Delay.Milliseconds(100);

            try
            {
                Report.Log(ReportLevel.Info, "Validation", "Validating ContainsImage (Screenshot: 'Screenshot7' with region {X=127,Y=137,Width=939,Height=756}) on item 'SnapXUntitled.Pictures'.", repo.SnapXUntitled.PicturesInfo, new RecordItemIndex(41));
                Validate.ContainsImage(repo.SnapXUntitled.PicturesInfo, Pictures_Screenshot7, Pictures_Screenshot7_Options);
                Delay.Milliseconds(100);
            }
            catch (Exception ex)
            {

            }            
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SnapXUntitled.CrossHairButton' at Center.", repo.SnapXUntitled.CrossHairButtonInfo, new RecordItemIndex(42));
            repo.SnapXUntitled.CrossHairButton.Click("Center");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Right Click item 'SnapXUntitled.RightClickToReachTheGoButton' at 33;190.", repo.SnapXUntitled.RightClickToReachTheGoButtonInfo, new RecordItemIndex(43));
            repo.SnapXUntitled.RightClickToReachTheGoButton.Click(System.Windows.Forms.MouseButtons.Right, "33;190");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SNAPX.ModeSelector' at 81;10.", repo.SNAPX.ModeSelectorInfo, new RecordItemIndex(44));
            repo.SNAPX.ModeSelector.Click("81;10");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ModeSelectorBurtton' at 72;162.", repo.ModeSelectorBurttonInfo, new RecordItemIndex(45));
            repo.ModeSelectorBurtton.Click("72;162");
            Delay.Milliseconds(200);
            
        }

#region Image Feature Data
        CompressedImage Pictures_Screenshot1
        { get { return repo.SnapXUntitled.PicturesInfo.GetScreenshot1(new Rectangle(118, 70, 981, 837)); } }

        Imaging.FindOptions Pictures_Screenshot1_Options
        { get { return Imaging.FindOptions.Default; } }

        CompressedImage Pictures_Screenshot2
        { get { return repo.SnapXUntitled.PicturesInfo.GetScreenshot2(new Rectangle(146, 61, 944, 823)); } }

        Imaging.FindOptions Pictures_Screenshot2_Options
        { get { return Imaging.FindOptions.Default; } }

        CompressedImage Pictures_Screenshot3
        { get { return repo.SnapXUntitled.PicturesInfo.GetScreenshot3(new Rectangle(85, 104, 1019, 742)); } }

        Imaging.FindOptions Pictures_Screenshot3_Options
        { get { return Imaging.FindOptions.Default; } }

        CompressedImage Pictures_Screenshot4
        { get { return repo.SnapXUntitled.PicturesInfo.GetScreenshot4(new Rectangle(109, 189, 1004, 676)); } }

        Imaging.FindOptions Pictures_Screenshot4_Options
        { get { return Imaging.FindOptions.Default; } }

        CompressedImage Pictures_Screenshot5
        { get { return repo.SnapXUntitled.PicturesInfo.GetScreenshot5(new Rectangle(199, 217, 862, 600)); } }

        Imaging.FindOptions Pictures_Screenshot5_Options
        { get { return Imaging.FindOptions.Default; } }

        CompressedImage Pictures_Screenshot6
        { get { return repo.SnapXUntitled.PicturesInfo.GetScreenshot6(new Rectangle(142, 141, 900, 653)); } }

        Imaging.FindOptions Pictures_Screenshot6_Options
        { get { return Imaging.FindOptions.Default; } }

        CompressedImage Pictures_Screenshot7
        { get { return repo.SnapXUntitled.PicturesInfo.GetScreenshot7(new Rectangle(127, 137, 939, 756)); } }

        Imaging.FindOptions Pictures_Screenshot7_Options
        { get { return Imaging.FindOptions.Default; } }

#endregion
    }
#pragma warning restore 0436
}
