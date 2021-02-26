using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZOOM_SDK_DOTNET_WRAP;

namespace JoinZoom
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            //Fill Util here
            if (args.Length == 1)
            {
                Util.meetingId = args[0];
            }

            if (args.Length == 2)
            {
                Util.meetingId = args[0];
                Util.password = args[2];
            }

            if (args.Length == 3)
            {
                Util.meetingId = args[0];
                Util.password = args[2];
                Util.userName = args[1];
                
            }

            //RegisterCallBacks();
            Application_Startup();
            //AuthZoomSDK();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ZoomLay());
        }

        private static void Application_Startup()//(object sender, StartupEventArgs e)
        {
            //init sdk
            {
                ZOOM_SDK_DOTNET_WRAP.InitParam param = new ZOOM_SDK_DOTNET_WRAP.InitParam();
                param.web_domain = "https://zoom.us";
                ZOOM_SDK_DOTNET_WRAP.SDKError err =  ZOOM_SDK_DOTNET_WRAP.CZoomSDKeDotNetWrap.Instance.Initialize(param);
                if (ZOOM_SDK_DOTNET_WRAP.SDKError.SDKERR_SUCCESS == err)
                {
#if _DEBUG_BOX_MSG
                    MessageBox.Show("SDKERR_SUCCESS");
#endif

                }
                else//error handle.todo
                {
#if DEBUG_BOX_MSG
                    MessageBox.Show("Error: Application_Startup()\n" + err);
#endif
                }
            }
        }
    }
}
